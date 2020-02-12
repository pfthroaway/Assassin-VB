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
        Public Function CheckHungerThirst() As Boolean
            AddText(CurrentUser.DisplayHungerThirstText())
            If CurrentUser.CanDoAction() Then
                Return True
            End If
            BtnAccept.Enabled = False
            BtnDecline.Enabled = False
            Return False
        End Function

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
            CurrentUser.GainHungerThirst()
            ToggleButtons(False)
            Dim employer As Integer = Functions.GenerateRandomNumber(0, 5)
            _currEmployer = _employers(employer).ToString
            ArrText.Add($"{_currEmployer} approaches you.")
            GetEnemy()
            _bounty = Functions.GenerateRandomNumber(CurrentEnemy.CurrentEndurance, CurrentEnemy.CurrentEndurance * 2)
            ArrText.Add($"""Greetings, {CurrentUser.Rank}.{_nl}I have an opportunity for you.{_nl}It concerns the elimination of a {CurrentEnemy.Name}.{_nl}I will pay you {_bounty} gold.{_nl}Are you interested?""")

            Timer1.Start()
        End Sub

        ''' <summary>Handles getting paid.</summary>
        Public Async Sub GetPaid()
            ToggleButtons(False)
            ArrText.Add($"The {_currEmployer.Substring(_currEmployer.IndexOf(" ") + 1)} welcomes your return.{_nl}""Well done. Here is your payment.""{_nl}You are handed {_bounty} gold.")
            CurrentUser.GoldOnHand += _bounty

            _blnDone = True

            Timer1.Start()

            Await SaveUser(CurrentUser)
        End Sub

        ''' <summary>Loads everything needed for the Jobs form.</summary>
        Public Sub LoadJobs()
            TxtJobs.ScrollToCaret()
            GetEmployers()
            If CheckHungerThirst() Then
                GetJob()
            Else
                BtnLeave.Enabled = True
            End If
        End Sub

#Region "Click"

        Private Sub BtnAccept_Click(sender As Object, e As EventArgs) Handles BtnAccept.Click
            If CheckHungerThirst() Then
                CurrentUser.GainHungerThirst()
                FrmBattle.Show()
                FrmBattle.Surprise()
                If FrmBattle.TxtBattle.TextLength = 0 Then FrmBattle.TxtBattle.Text = "You stalk your opponent."
                FrmBattle.Display()
                FrmBattle.BlnJob = True
                Hide()
            Else
                BtnLeave.Enabled = True
            End If
        End Sub

        Private Sub BtnDecline_Click(sender As Object, e As EventArgs) Handles BtnDecline.Click
            If CheckHungerThirst() Then
                CurrentUser.GainHungerThirst()
                GetJob()
            Else
                BtnLeave.Enabled = True
            End If
        End Sub

        Private Sub BtnLeave_Click(sender As Object, e As EventArgs) Handles BtnLeave.Click
            Close()
        End Sub

#End Region

        Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
            CycleText()
        End Sub

        Private Sub FrmJobs_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
            FrmGuild.Show()
            FrmGuild.AddText(TxtJobs.Text.Trim())
        End Sub

    End Class

End Namespace