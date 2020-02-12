Option Strict On
Option Explicit On

Imports Assassin.Classes
Imports Assassin.Classes.Entities
Imports Assassin.Classes.Enums
Imports Assassin.Forms.Shopping

Namespace Forms.GuildForms

    Public Class FrmGuild

        ''' <summary>Add text to the TextBox.</summary>
        ''' <param name="newText">Text to be added</param>
        Public Sub AddText(newText As String)
            AddTextToTextBox(TxtGuild, newText)
        End Sub

        ''' <summary>Checks whether the character is too high to be in Guild 1.</summary>
        Private Function LevelOk() As Boolean
            If CurrentGuild.ID = 1 AndAlso CurrentUser.Level > 5 Then
                DisableButtons()
                AddText($"An invisible wall blocks you as you attempt to enter the guild. The guildmaster looms in the doorway.{ControlChars.NewLine}""You are now too experienced to belong to this guild. Good luck to you in the future.{ControlChars.NewLine}""You are pushed back to the streets.")
                LeaveGuild()
                Return False
            Else
                AddText($"You enter {LblGuildName.Text}.")
                Return True
            End If
        End Function

        ''' <summary>Checks to see if the CurrentUser is the Guildmaster.</summary>
        Private Sub CheckLeader()
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

        ''' <summary>Disables all the buttons on the form.</summary>
        Private Sub DisableButtons()
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

        ''' <summary>Displays the guild name.</summary>
        Private Sub Display()
            LblGuildName.Text = CurrentGuild.Name
        End Sub

        ''' <summary>Makes a <see cref="User"/> leave the <see cref="Guild"/>.</summary>
        Private Async Sub LeaveGuild()
            If (Await MemberLeavesGuild(CurrentUser, CurrentGuild)) Then
                DisableButtons()
            End If
        End Sub

        ''' <summary>Loads important information when the form loads.</summary>
        Public Sub LoadGuild()
            Display()
            If LevelOk() Then CheckLeader()
        End Sub

#Region "Click"

        Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
            Close()
        End Sub

        Private Sub BtnBar_Click(sender As Object, e As EventArgs) Handles BtnBar.Click
            FrmBar.Show()
            FrmBar.loc = "Guild"
            FrmBar.DisplayPurchases()
            Hide()
        End Sub

        Private Sub BtnChallenge_Click(sender As Object, e As EventArgs) Handles BtnChallenge.Click
            'TODO Implement challenging the Guildmaster.
            AddText("This feature is currently unavailable.")
        End Sub

        Private Sub BtnDonate_Click(sender As Object, e As EventArgs) Handles BtnDonate.Click
            FrmGuildDonate.Show()
            FrmGuildDonate.LoadDonate()
            Hide()
        End Sub

        Private Sub BtnHire_Click(sender As Object, e As EventArgs) Handles BtnHire.Click
            FrmHireHenchmen.Show()
            FrmHireHenchmen.SetUser()
            Hide()
        End Sub

        Private Sub BtnJobs_Click(sender As Object, e As EventArgs) Handles BtnJobs.Click
            FrmJobs.Show()
            FrmJobs.LoadJobs()
            Hide()
        End Sub

        Private Sub BtnManage_Click(sender As Object, e As EventArgs) Handles BtnManage.Click
            FrmGuildManage.Show()
            Hide()
        End Sub

        Private Sub BtnMembers_Click(sender As Object, e As EventArgs) Handles BtnMembers.Click
            FrmMembers.Show()
            FrmMembers.loc = "Guild"
            FrmMembers.LoadMembers()
            Hide()
        End Sub

        Private Sub BtnRaid_Click(sender As Object, e As EventArgs) Handles BtnRaid.Click
            FrmRaid.Show()
            FrmRaid.LoadRaid()
            Hide()
        End Sub

        Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles BtnQuit.Click
            Dim dlg As DialogResult
            dlg = MessageBox.Show("Are you sure you want to quit the guild?", "Assassin", MessageBoxButtons.YesNo)
            If dlg = DialogResult.Yes Then
                LeaveGuild()
                AddText("You have decided to quit the guild.")
            End If
        End Sub

        Private Async Sub BtnSleep_Click(sender As Object, e As EventArgs) Handles BtnSleep.Click
            CurrentUser.CurrentLocation = SleepLocation.Guild
            Await SaveUser(CurrentUser)
            DisableButtons()
            FrmGame.ToggleButtons(False)
            AddText("You find an empty room and sleep.")
        End Sub

        Private Sub BtnTransfer_Click(sender As Object, e As EventArgs) Handles BtnTransfer.Click
            'TODO Implement transferring henchmen and gold.
            AddText("This feature is currently unavailable.")
        End Sub

#End Region

        Private Async Sub FrmGuild_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
            FrmGuildList.Show()
            FrmGuildList.Display()
            FrmGuildList.AddText(TxtGuild.Text.Trim())
            Await SaveUser(CurrentUser)
        End Sub

    End Class

End Namespace