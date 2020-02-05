' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 05/25/2012
' Filename        : Jobs Form.vb
' Description     : This form allows job opportunities.

Option Explicit On
Option Strict On

Imports Assassin.Classes
Imports Assassin.Forms.GuildForms
Imports Extensions

Namespace Forms

    Public Class FrmJobs
        ReadOnly _employers As New List(Of String)
        Public ArrText As New List(Of String)
        ReadOnly _nl As String = ControlChars.NewLine
        Dim _index As Integer
        Dim _currEmployer As String
        Dim _bounty As Integer
        Dim _blnDone As Boolean = False

        ''' <summary>Add text to the TextBox.</summary>
        ''' <param name="newText">Text to be added</param>
        Public Sub AddText(newText As String)
            AddTextToTextBox(TxtJobs, newText)
        End Sub

        ''' <summary>Checks a user's hunger and thirst.</summary>
        Public Sub CheckHungerThirst()
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

        ''' <summary>Cycles the text in the ArrayList on the Timer's tick.</summary>
        Private Sub CycleText()
            AddText(ArrText(_index).ToString)
            _index += 1

            If _index = ArrText.Count Then
                If _blnDone = False Then
                    ToggleButtons(True)
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

        ''' <summary>Toggles all buttons on the form.</summary>
        ''' <param name="enabled">Should the buttons be enabled?</param>

        Public Sub ToggleButtons(enabled As Boolean)
            BtnAccept.Enabled = enabled
            BtnDecline.Enabled = enabled
            BtnLeave.Enabled = enabled
        End Sub

        ''' <summary>Fills the employers List with employers.</summary>
        Private Sub GetEmployers()
            _employers.Add("A youthful man")
            _employers.Add("A middle-aged man")
            _employers.Add("An old man")
            _employers.Add("A youthful woman")
            _employers.Add("A middle-aged woman")
            _employers.Add("An old woman")
        End Sub

        ''' <summary>Gets a job opportunity from an employer.</summary>
        Private Sub GetJob()
            ToggleButtons(False)
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

        ''' <summary>Handles getting paid.</summary>
        Public Async Sub GetPaid()
            ToggleButtons(False)
            ArrText.Add("The " & _currEmployer.Substring(_currEmployer.IndexOf(" ") + 1) & " welcomes your return." & _nl &
                        Chr(34) & "Well done. Here is your payment." & Chr(34) & _nl &
                        "You are handed " & _bounty & " gold.")
            CurrentUser.GoldOnHand += _bounty

            _blnDone = True

            Timer1.Start()

            Await SaveUser(CurrentUser)
        End Sub

        ''' <summary>Loads everything needed for the Jobs form.</summary>
        Public Sub LoadJobs()
            TxtJobs.ScrollToCaret()
            GetEmployers()
            GetJob()
        End Sub

        Private Sub BtnAccept_Click(sender As Object, e As EventArgs) Handles BtnAccept.Click
            CurrentUser.Hunger += 1
            CurrentUser.Thirst += 1
            FrmBattle.Show()
            FrmBattle.Surprise()
            If FrmBattle.TxtBattle.TextLength = 0 Then FrmBattle.TxtBattle.Text = "You stalk your opponent."
            FrmBattle.Display()
            FrmBattle.BlnJob = True
            Hide()
        End Sub

        Private Sub BtnDecline_Click(sender As Object, e As EventArgs) Handles BtnDecline.Click
            CurrentUser.Hunger += 1
            CurrentUser.Thirst += 1
            GetJob()
            CheckHungerThirst()
        End Sub

        Private Sub BtnLeave_Click(sender As Object, e As EventArgs) Handles BtnLeave.Click
            Close()
        End Sub

        Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
            CycleText()
        End Sub

        Private Sub FrmJobs_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
            FrmGuild.Show()
            FrmGuild.AddText(TxtJobs.Text)
        End Sub

    End Class

End Namespace