' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 05/25/2012
' Filename        : Court Form.vb
' Description     : This form conducts the court activities after a player has been apprehended.

Imports Assassin.Classes
Imports Extensions

Namespace Forms

    Public Class FrmCourt
        Public Reason As String = ""            'reason for being sent to court
        Dim _arrText As New ArrayList            'ArrayList of text
        Dim _index As Integer = 0                'index for ArrayList
        Dim _fine As Integer = 0                 'fine if found guilty
        Dim _blnGuilty As Boolean = False        'boolean for being found guilty
        Dim _blnFinished As Boolean = False      'boolean for being finished

        ''' <summary>Add text to the TextBox.</summary>
        ''' <param name="newText">Text to be added</param>
        Private Sub AddText(newText As String)
            AddTextToTextBox(TxtCourt, newText)
        End Sub

        ''' <summary>Displays text from the Arraylist.</summary>
        Public Sub Display()
            If _index < _arrText.Count Then
                AddText(_arrText(_index))
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
                _arrText.Add($"""Well, if it isn't the {AllRanks(CurrentUser.Level)}, {CurrentUser.Name}.""")
                _arrText.Add("""Don't worry, I will be impartial,"" he laughs.")
            End If
            _arrText.Add("The trial begins. . .")
            If Reason = "Pickpocket" Then
                _arrText.Add("You are charged with the crime of attempted theft of property.")
                _fine = 50
            ElseIf Reason = "Assault" Then
                _arrText.Add("You are charged with the crime of attempted assault and robbery.")
                _fine = 100
            ElseIf Reason = "Assassinate" Then
                _arrText.Add("You are charged with the crime of attempted murder.")
                _fine = 250
            End If
            _arrText.Add("Prosecution. . .")
            _arrText.Add("Defense. . .")

            Dim guilty As Integer = Functions.GenerateRandomNumber(1, 100)
            If guilty <= (100 - (CurrentUser.Level * 5)) Then  'not guilty
                _arrText.Add("The judge finds you. . . innocent!")
            Else                                            'guilty
                _arrText.Add("The judge finds you. . . guilty!")
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
            AddText("You beat a hasty retreat and return to the streets.")
            _blnFinished = True
            Close()
        End Sub

        Private Sub BtnJail_Click(sender As Object, e As EventArgs) Handles BtnJail.Click
            If CurrentUser.GoldOnHand < _fine Then
                AddText("You don't have the money required to pay the fine.")
            Else
                AddText("You decide it is best to spend the night in jail.")
            End If
            FrmGame.DisableButtons()
            FrmGame.BtnJail.Enabled = True
            CurrentUser.CurrentLocation = "Jail"
            _blnFinished = True
            Close()
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
                FrmGame.AddText(TxtCourt.Text)
                Await SaveUser(CurrentUser)
            Else
                MessageBox.Show("You must make a decision first.", "Assassin", MessageBoxButtons.OK)
                e.Cancel = True
            End If
        End Sub

    End Class

End Namespace