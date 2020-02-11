Option Strict On
Option Explicit On

Imports Assassin.Classes
Imports Assassin.Classes.Entities
Imports Assassin.Classes.Enums
Imports Extensions

Namespace Forms

    Public Class FrmCourt
        Public Reason As Crime
        Dim _arrText As New ArrayList
        Dim _index As Integer = 0
        Dim _fine As Integer = 0
        Dim _blnGuilty As Boolean = False
        Dim _blnFinished As Boolean = False

        ''' <summary>Add text to the TextBox.</summary>
        ''' <param name="newText">Text to be added</param>
        Private Sub AddText(newText As String)
            AddTextToTextBox(TxtCourt, newText)
        End Sub

        ''' <summary>Displays text from the Arraylist.</summary>
        Public Sub Display()
            If _index < _arrText.Count Then
                AddText(_arrText(_index).ToString())
                _index += 1
                If _index = _arrText.Count Then
                    Timer1.Stop()
                    Justice()
                    _arrText.Clear()
                    _index = 0
                End If
            End If
        End Sub

        ''' <summary>Administers justice!</summary>
        Public Sub Justice()
            If _blnGuilty = True Then
                If CurrentUser.GoldOnHand >= _fine Then
                    BtnPayFine.Enabled = True
                End If
                BtnJail.Enabled = True
            Else
                BtnFreedom.Enabled = True
            End If
        End Sub

        ''' <summary>Sets up the court scenario.</summary>
        Public Sub Setup()
            _arrText.Add("You are dragged to the courts of justice.")
            _arrText.Add("The judge stares at you. . .")
            If CurrentUser.Level > 6 Then
                _arrText.Add($"""Well, if it isn't the {CurrentUser.Rank}, {CurrentUser.Name}.""")
                _arrText.Add("""Don't worry, I will be impartial,"" he laughs.")
            End If
            _arrText.Add("The trial begins. . .")

            Select Case Reason
                Case Crime.Assault
                    _arrText.Add("You are charged with the crime of attempted assault and robbery.")
                    _fine = 100
                Case Crime.AttemptedMurder
                    _arrText.Add("You are charged with the crime of attempted murder.")
                    _fine = 250
                Case Crime.Pickpocket
                    _arrText.Add("You are charged with the crime of attempted theft of property.")
                    _fine = 50
            End Select

            _arrText.Add("Prosecution. . .")
            _arrText.Add("Defense. . .")
            _arrText.Add("The judge finds you. . .")
            Dim guilty As Integer = Functions.GenerateRandomNumber(1, 100)
            If guilty <= (100 - (CurrentUser.Level * 5)) Then 'not guilty
                _arrText.Add("innocent!")
            Else 'guilty
                _arrText.Add("guilty!")
                _arrText.Add($"""You are to pay {_fine} gold as a fine. Pay it, or you will be jailed for the night.""")
                _blnGuilty = True
            End If

            Start()
        End Sub

        ''' <summary>Starts the Timer.</summary>
        Public Sub Start()
            Timer1.Start()
        End Sub

#Region "Click"

        Private Sub BtnFreedom_Click(sender As Object, e As EventArgs) Handles BtnFreedom.Click
            If CurrentUser.CurrentLocation <> SleepLocation.Jail Then
                AddText("You beat a hasty retreat and return to the streets.")
                _blnFinished = True
            End If
            Close()
        End Sub

        Private Async Sub BtnJail_Click(sender As Object, e As EventArgs) Handles BtnJail.Click
            AddText(If(CurrentUser.GoldOnHand < _fine, "You don't have the money required to pay the fine.", "You decide it is best to spend the night in jail."))
            FrmGame.ToggleButtons(False)
            Dim jailedUser As New JailedUser(CurrentUser.Name, Reason, _fine, Date.UtcNow)
            If Await DatabaseInteraction.SendToJail(jailedUser) Then
                BtnPayFine.Enabled = False
                BtnJail.Enabled = False
                CurrentUser.CurrentLocation = SleepLocation.Jail
                AllJailedUsers.Add(jailedUser)
                _blnFinished = True
                BtnFreedom.Enabled = True
                BtnFreedom.Text = "&Back"
            End If

        End Sub

        Private Sub BtnPayFine_Click(sender As Object, e As EventArgs) Handles BtnPayFine.Click
            AddText("You decide it is best to pay the fine and depart.")
            CurrentUser.GoldOnHand -= _fine
            _blnFinished = True
            Close()
        End Sub

#End Region

        Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
            Display()
        End Sub

        Private Async Sub FrmCourt_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
            If _blnFinished = True Then
                FrmGame.Show()
                FrmGame.Display()
                FrmGame.AddText(TxtCourt.Text.Trim())
                If CurrentUser.CurrentLocation = SleepLocation.Jail Then
                    FrmGame.CheckJailed()
                End If
                Await SaveUser(CurrentUser)
            Else
                MessageBox.Show("You must make a decision first.", "Assassin", MessageBoxButtons.OK)
                e.Cancel = True
            End If
        End Sub

    End Class

End Namespace