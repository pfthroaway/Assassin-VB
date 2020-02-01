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
        Dim _nl As String = ControlChars.NewLine 'new line
        Dim _arrText As New ArrayList            'ArrayList of text
        Dim _index As Integer = 0                'index for ArrayList
        Dim _fine As Integer = 0                 'fine if found guilty
        Dim _blnGuilty As Boolean = False        'boolean for being found guilty
        Dim _blnFinished As Boolean = False      'boolean for being finished

        Public Sub AddText(newText As String)
            '* * * * *
            '* This method adds text to the Textbox.
            '* * * * *

            Dim currText As String = TxtCourt.Text
            TxtCourt.Clear()

            TxtCourt.Text = newText & _nl & _nl & currText
            TxtCourt.Select(0, 0)
            TxtCourt.ScrollToCaret()
        End Sub

        Public Sub Display()
            '* * * * *
            '* This method displays text from the Arraylist.
            '* * * * *

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

        Public Sub Justice()
            '* * * * *
            '* This method administers justice!
            '* * * * *

            If _blnGuilty = True Then
                If CurrentUser.GoldOnHand >= _fine Then
                    BtnPayFine.Enabled = True
                End If
                BtnJail.Enabled = True
            Else
                BtnFreedom.Enabled = True
            End If
        End Sub

        Public Sub Setup()
            '* * * * *
            '* This method sets up the court scenario.
            '* * * * *

            _arrText.Add("You are dragged to the courts of justice.")
            _arrText.Add("The judge stares at you. . .")
            If CurrentUser.Level > 6 Then
                _arrText.Add(Chr(34) & "Well, if it isn't the " & AllRanks(CurrentUser.Level) & ", " & CurrentUser.Name & "." & Chr(34))
                _arrText.Add(Chr(34) & "Don't worry, I will be impartial," & Chr(34) & " he laughs.")
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
                _arrText.Add(Chr(34) & "You are to pay " & _fine & " gold as a fine. Pay it, or you will be jailed for the night." & Chr(34))
                _blnGuilty = True
            End If

            Start()
        End Sub

        Public Sub Start()
            '* * * * *
            '* This method starts the Timer.
            '* * * * *

            Timer1.Start()
        End Sub

        Private Sub BtnFreedom_Click(sender As Object, e As EventArgs) Handles BtnFreedom.Click
            '* * * * *
            '* This method displays a message and then the Game form.
            '* * * * *

            AddText("You beat a hasty retreat and return to the streets.")
            _blnFinished = True
            Close()
        End Sub

        Private Sub BtnJail_Click(sender As Object, e As EventArgs) Handles BtnJail.Click
            '* * * * *
            '* This method sends the user to jail.
            '* * * * *

            If CurrentUser.GoldOnHand < _fine Then
                AddText("You don't have the money required to pay the fine.")
            Else
                AddText("You decide it is best to spend the night in jail.")
            End If
            FrmGame.DisableButtons()
            FrmGame.btnJail.Enabled = True
            CurrentUser.CurrentLocation = "Jail"
            _blnFinished = True
            Close()
        End Sub

        Private Sub BtnPayFine_Click(sender As Object, e As EventArgs) Handles BtnPayFine.Click
            '* * * * *
            '* This method pays the fine.
            '* * * * *

            AddText("You decide it is best to pay the fine and depart.")
            CurrentUser.GoldOnHand -= _fine
            _blnFinished = True
            Close()
        End Sub

        Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
            '* * * * *
            '* This method calls the display method on the Timer Tick.
            '* * * * *

            Display()
        End Sub

        Private Async Sub FrmCourt_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
            '* * * * *
            '* This method closes the form.
            '* * * * *

            If _blnFinished = True Then
                FrmGame.Show()
                FrmGame.Display()
                FrmGame.AddText(txtCourt.Text)
                Await SaveUser(CurrentUser)
            Else
                MessageBox.Show("You must make a decision first.", "Assassin", MessageBoxButtons.OK)
                e.Cancel = True
            End If
        End Sub

    End Class

End Namespace