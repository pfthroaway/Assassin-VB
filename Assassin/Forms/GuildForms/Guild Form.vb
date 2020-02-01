' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 05/25/2012
' Filename        : Guild Form.vb
' Description     : This form contains the guild information

Option Strict On
Option Explicit On

Imports Assassin.Classes
Imports Assassin.Classes.Entities
Imports Assassin.Forms.Shopping

Namespace Forms.GuildForms

    Public Class FrmGuild

        Private Function LevelOk() As Boolean
            '* * * * *
            '* This method checks whether the character is too high to be in Guild 1.
            '* * * * *

            If CurrentGuild.ID = 1 AndAlso CurrentUser.Level > 5 Then
                DisableButtons()
                AddText("An invisible wall blocks you as you attempt to enter the guild. The guildmaster looms in the doorway.\n""You are now too experienced to belong to this guild. Good luck to you in the future.\n""You are pushed back to the streets.")
                LeaveGuild()
                Return False
            Else
                AddText("You enter " & lblGuildName.Text & ".")
                Return True
            End If
        End Function

        Public Sub AddText(newText As String)
            AddTextToTextBox(TxtGuild, newText)
        End Sub

        Private Sub CheckLeader()
            '* * * * *
            '* This method checks to see if the CurrentUser is the Guildmaster.
            '* * * * *

            If CurrentUser.Name = CurrentGuild.Master Then
                BtnChallenge.Enabled = False
                BtnManage.Enabled = True
            Else
                If CurrentGuild.ID <> 1 Then
                    BtnChallenge.Enabled = True
                End If
                BtnManage.Enabled = False
            End If
        End Sub

        Private Sub DisableButtons()
            '* * * * *
            '* This method disables all the buttons on the form.
            '* * * * *

            BtnChallenge.Enabled = False
            BtnBar.Enabled = False
            BtnDonate.Enabled = False
            BtnHire.Enabled = False
            BtnJobs.Enabled = False
            BtnManage.Enabled = False
            BtnMembers.Enabled = False
            BtnQuit.Enabled = False
            BtnRaid.Enabled = False
            BtnSleep.Enabled = False
            BtnTransfer.Enabled = False
        End Sub

        Private Sub Display()
            '* * * * *
            '* This method displays the guild name.
            '* * * * *

            lblGuildName.Text = CurrentGuild.Name
        End Sub

        Private Async Sub LeaveGuild()
            '* * * * *
            '* This method makes a user leave the guild.
            '* * * * *

            If (Await MemberLeavesGuild(CurrentUser, CurrentGuild)) Then
                DisableButtons()
            End If
        End Sub

        Public Sub LoadGuild()
            '* * * * *
            '* This method loads important information when the form loads.
            '* * * * *

            Display()
            If LevelOk() Then CheckLeader()
        End Sub

        Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
            '* * * * *
            '* This method closes the form on clicking the Back button.
            '* * * * *

            Close()
        End Sub

        Private Sub BtnBar_Click(sender As Object, e As EventArgs) Handles BtnBar.Click
            '* * * * *
            '* This method displays the Bar form on clicking the Bar button.
            '* * * * *

            FrmBar.Show()
            FrmBar.loc = "Guild"
            FrmBar.DisplayPurchases()
            Hide()
        End Sub

        Private Sub BtnChallenge_Click(sender As Object, e As EventArgs) Handles BtnChallenge.Click
            '* * * * *
            '* This method handles clicking the Challenge button.
            '* * * * *

            AddText("This feature is currently unavailable.")
        End Sub

        Private Sub BtnDonate_Click(sender As Object, e As EventArgs) Handles BtnDonate.Click
            '* * * * *
            '* This method lets you donate to the guild.
            '* * * * *

            FrmGuildDonate.Show()
            FrmGuildDonate.LoadDonate()
            Hide()
        End Sub

        Private Sub BtnHire_Click(sender As Object, e As EventArgs) Handles BtnHire.Click
            '* * * * *
            '* This method handles clicking the Hire button.
            '* * * * *

            FrmHireHenchmen.Show()
            FrmHireHenchmen.SetUser()
            Hide()
        End Sub

        Private Sub BtnJobs_Click(sender As Object, e As EventArgs) Handles BtnJobs.Click
            '* * * * *
            '* This method handles clicking the Jobs button.
            '* * * * *

            FrmJobs.Show()
            FrmJobs.LoadJobs()
            Hide()
        End Sub

        Private Sub BtnManage_Click(sender As Object, e As EventArgs) Handles BtnManage.Click
            '* * * * *
            '* This method handles clicking the Manage button.
            '* * * * *

            FrmGuildManage.Show()
            Hide()
        End Sub

        Private Sub BtnMembers_Click(sender As Object, e As EventArgs) Handles BtnMembers.Click
            '* * * * *
            '* This method handles clicking the Members button.
            '* * * * *

            FrmMembers.Show()
            FrmMembers.loc = "Guild"
            FrmMembers.LoadMembers()
            Hide()
        End Sub

        Private Sub BtnRaid_Click(sender As Object, e As EventArgs) Handles BtnRaid.Click
            '* * * * *
            '*  This button click displays the Raid form.
            '* * * * *

            FrmRaid.Show()
            FrmRaid.LoadRaid()
            Hide()

        End Sub

        Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles BtnQuit.Click
            '* * * * *
            '* This method verifies if a user wants to quit the guild.
            '* * * * *

            Dim dlg As DialogResult
            dlg = MessageBox.Show("Are you sure you want to quit the guild?", "Assassin", MessageBoxButtons.YesNo)
            If dlg = DialogResult.Yes Then
                LeaveGuild()
                AddText("You have decided to quit the guild.")
            End If
        End Sub

        Private Async Sub BtnSleep_Click(sender As Object, e As EventArgs) Handles BtnSleep.Click
            '* * * * *
            '* This method lets a user sleep in the guild.
            '* * * * *

            CurrentUser.CurrentLocation = "Guild"
            Await SaveUser(CurrentUser)
            DisableButtons()
            FrmGame.DisableButtons()
            AddText("You find an empty room and sleep.")
        End Sub

        Private Sub BtnTransfer_Click(sender As Object, e As EventArgs) Handles BtnTransfer.Click
            '* * * * *
            '* This method displays the Transfer Items form.
            '* * * * *

            AddText("This feature is currently unavailable.")
        End Sub

        Private Async Sub FrmGuild_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
            '* * * * *
            '* This method handles the form closing.
            '* * * * *

            FrmGame.Show()
            FrmGame.Display()
            FrmGame.AddText(TxtGuild.Text)
            Await SaveUser(CurrentUser)
        End Sub

    End Class

End Namespace