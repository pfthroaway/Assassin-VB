' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 05/25/2012
' Filename        : Jobs Form.vb
' Description     : This form allows job opportunities.

Option Explicit On
Option Strict On

Imports Assassin.Classes
Imports Assassin.Classes.Entities
Imports Assassin.Forms.GuildForms
Imports Extensions

Namespace Forms

    Public Class FrmJobs
        Private _employers As New ArrayList      'employers Arraylist
        Dim CurrentEnemy As New Enemy              'current enemy
        Public ArrText As New ArrayList         'ArrayList of text to be added
        Dim _nl As String = ControlChars.NewLine 'new line
        Dim _index As Integer                    'index in employers ArrayList
        Dim _currEmployer As String              'current employer name
        Dim _bounty As Integer                   'bounty
        Dim _blnDone As Boolean = False          'done?

        Public Sub AddText(newText As String)
            '* * * * *
            '* This method adds text to the Textbox.
            '* * * * *

            Dim currText As String = TxtJobs.Text
            TxtJobs.Clear()

            TxtJobs.Text = newText & _nl & _nl & currText
            TxtJobs.Select(0, 0)
            TxtJobs.ScrollToCaret()
        End Sub

        Public Sub CheckHungerThirst()
            '* * * * *
            '* This method checks a user's hunger and thirst.
            '* * * * *

            If CurrentUser.Hunger >= 24 OrElse CurrentUser.Thirst >= 24 Then
                BtnAccept.Enabled = False
                BtnDecline.Enabled = False

                If CurrentUser.Hunger >= 24 AndAlso CurrentUser.Thirst >= 24 Then
                    AddText("You are too hungry and thirsty to continue.")
                ElseIf CurrentUser.Hunger >= 24 Then
                    AddText("You are too hungry to continue.")
                ElseIf CurrentUser.Thirst >= 24 Then
                    AddText("You are too thirsty to continue.")
                End If
            Else
                If CurrentUser.Hunger > 0 AndAlso CurrentUser.Hunger Mod 5 = 0 Then
                    AddText("You are " & GetHunger(CurrentUser.Hunger).ToLower & ".")
                End If
                If CurrentUser.Thirst > 0 AndAlso CurrentUser.Thirst Mod 5 = 0 Then
                    AddText("You are " & GetThirst(CurrentUser.Thirst).ToLower & ".")
                End If
            End If
        End Sub

        Private Sub CycleText()
            '* * * * *
            '* This method cycles the text in the ArrayList on the Timer's tick.
            '* * * * *

            AddText(ArrText(_index).ToString)
            _index += 1

            If _index = ArrText.Count Then
                If _blnDone = False Then
                    EnableButtons()
                    Timer1.Stop()
                    _index = 0
                    ArrText.Clear()
                Else
                    BtnLeave.Enabled = True
                    Timer1.Stop()
                    _index = 0
                    ArrText.Clear()
                End If
            End If
        End Sub

        Public Sub DisableButtons()
            '* * * * *
            '* This method disabled the buttons on the form
            '* * * * *

            BtnAccept.Enabled = False
            BtnDecline.Enabled = False
            BtnLeave.Enabled = False
        End Sub

        Private Sub EnableButtons()
            '* * * * *
            '* This method enables the buttons on the form
            '* * * * *

            BtnAccept.Enabled = True
            BtnDecline.Enabled = True
            BtnLeave.Enabled = True
        End Sub

        Private Sub GetEmployers()
            '* * * * *
            '* This method fills the employers Arraylist with employers.
            '* * * * *

            _employers.Add("A youthful man")
            _employers.Add("A middle-aged man")
            _employers.Add("An old man")
            _employers.Add("A youthful woman")
            _employers.Add("A middle-aged woman")
            _employers.Add("An old woman")
        End Sub

        Private Sub GetJob()
            '* * * * *
            '* This method gets a job opportunity from an employer.
            '* * * * *

            DisableButtons()
            Dim employer As Integer = Functions.GenerateRandomNumber(0, 5)
            _currEmployer = _employers(employer).ToString
            ArrText.Add(_currEmployer & " approaches you.")
            GetEnemy()
            _bounty = Functions.GenerateRandomNumber(CurrentEnemy.CurrentEndurance, CurrentEnemy.CurrentEndurance * 2)
            ArrText.Add(Chr(34) & "Greetings, " & AllRanks(CurrentUser.Level) & "." & _nl &
                                                        "I have an opportunity for you." & _nl &
                                                        "It concerns the elimination of a " & CurrentEnemy.Name & "." & _nl &
                                                        "I will pay you " & _bounty & " gold." & _nl &
                                                        "Are you interested?" & Chr(34))

            Timer1.Start()
        End Sub

        Public Async Sub GetPaid()
            '* * * * *
            '* This method handles getting paid.
            '* * * * *

            DisableButtons()
            ArrText.Add("The " & _currEmployer.Substring(_currEmployer.IndexOf(" ") + 1) & " welcomes your return." & _nl &
                        Chr(34) & "Well done. Here is your payment." & Chr(34) & _nl &
                        "You are handed " & _bounty & " gold.")
            CurrentUser.GoldOnHand += _bounty

            _blnDone = True

            Timer1.Start()

            Await SaveUser(CurrentUser)
        End Sub

        Public Sub LoadJobs()
            '* * * * *
            '* This method loads everything needed for the Jobs form.
            '* * * * *

            TxtJobs.ScrollToCaret()
            GetEmployers()
            GetJob()
        End Sub

        Private Sub BtnAccept_Click(sender As Object, e As EventArgs) Handles BtnAccept.Click
            '* * * * *
            '* This method accepts the job.
            '* * * * *

            CurrentUser.Hunger += 1
            CurrentUser.Thirst += 1
            FrmBattle.Show()
            FrmBattle.surprise()
            If FrmBattle.txtBattle.TextLength = 0 Then FrmBattle.txtBattle.Text = "You stalk your opponent."
            FrmBattle.Display()
            FrmBattle.BlnJob = True
            Me.Hide()
        End Sub

        Private Sub BtnDecline_Click(sender As Object, e As EventArgs) Handles BtnDecline.Click
            '* * * * *
            '* This method declines the job.
            '* * * * *

            CurrentUser.Hunger += 1
            CurrentUser.Thirst += 1
            GetJob()
            CheckHungerThirst()
        End Sub

        Private Sub BtnLeave_Click(sender As Object, e As EventArgs) Handles BtnLeave.Click
            '* * * * *
            '* This method leaves the table.
            '* * * * *

            Me.Close()
        End Sub

        Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
            '* * * * *
            '* This method handles what happens on the timer's tick.
            '* * * * *

            CycleText()
        End Sub

        Private Sub FrmJobs_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
            '* * * * *
            '* This method handles closing the form.
            '* * * * *

            FrmGuild.Show()
            FrmGuild.AddText(txtJobs.Text)
        End Sub

    End Class

End Namespace