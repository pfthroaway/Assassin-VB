' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 10/11/2012
' Filename        : Guild Manage Form.vb
' Description     : This form allows a guildmaster to manage their guild.

Option Strict On
Option Explicit On

Imports Assassin.Classes
Imports Assassin.Classes.Entities

Namespace Forms.GuildForms

    Public Class FrmGuildManage

        Dim _nl As String = ControlChars.NewLine

        Public Sub AddText(newText As String)
            '* * * * *
            '* This method adds text to the Textbox.
            '* * * * *

            Dim currText As String = TxtGuild.Text
            TxtGuild.Clear()

            TxtGuild.Text = newText & _nl & _nl & currText
            TxtGuild.Select(0, 0)
            TxtGuild.ScrollToCaret()
        End Sub

        Public Sub Disable()
            '* * * * *
            '* This method disables all buttons on the form if master of the guild is changed.
            '* * * * *

            BtnApplications.Enabled = False
            BtnHire.Enabled = False
            BtnMembers.Enabled = False
            BtnOptions.Enabled = False
            BtnTransfer.Enabled = False
        End Sub

        Private Sub BtnApplications_Click(sender As Object, e As EventArgs) Handles BtnApplications.Click
            '* * * * *
            '* This method handles clicking the Applications button.
            '* * * * *

            FrmManageApplications.Show()
            FrmManageApplications.GetApplicants()

            Hide()
        End Sub

        Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
            '* * * * *
            '* This method closes the form on clicking the Back button.
            '* * * * *

            Close()
        End Sub

        Private Sub BtnHire_Click(sender As Object, e As EventArgs) Handles BtnHire.Click
            '* * * * *
            '* This method handles clicking the Hire button.
            '* * * * *

            FrmHireHenchmen.Show()
            FrmHireHenchmen.SetGuild()
            FrmHireHenchmen.BlnGuild = True
            Hide()
        End Sub

        Private Sub BtnMembers_Click(sender As Object, e As EventArgs) Handles BtnMembers.Click
            '* * * * *
            '* This method allows the guildmaster to manage the members of his guild.
            '* * * * *

            FrmMembers.Show()
            FrmMembers.loc = "Manage"
            FrmMembers.LoadMembers()
            Hide()
        End Sub

        Private Sub BtnOptions_Click(sender As Object, e As EventArgs) Handles BtnOptions.Click
            '* * * * *
            '* This method displays the Guild Options form.
            '* * * * *

            FrmGuildOptions.Show()
            FrmGuildOptions.LoadOptions()
            Hide()
        End Sub

        Private Sub BtnTransfer_Click(sender As Object, e As EventArgs) Handles BtnTransfer.Click
            '* * * * *
            '* This method displays the form which allows a guildmaster to transfer gold and henchmen.
            '* * * * *

            FrmGuildTransfer.Show()
            FrmGuildTransfer.LoadTransfer()
            Hide()
        End Sub

        Private Sub FrmGuildManage_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
            '* * * * *
            '* This method handles closing the form.
            '* * * * *

            FrmGuild.Show()
            FrmGuild.AddText(TxtGuild.Text)
            FrmGuild.LoadGuild()
        End Sub

    End Class

End Namespace