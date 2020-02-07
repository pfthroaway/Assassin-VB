' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 10/11/2012
' Filename        : Guild Manage Form.vb
' Description     : This form allows a guildmaster to manage their guild.

Option Strict On
Option Explicit On

Imports Assassin.Classes

Namespace Forms.GuildForms

    Public Class FrmGuildManage

        ''' <summary>Add text to the TextBox.</summary>
        ''' <param name="newText">Text to be added</param>
        Public Sub AddText(newText As String)
            AddTextToTextBox(TxtGuild, newText)
        End Sub

        ''' <summary>Disables all buttons on the form if master of the guild is changed.</summary>
        Public Sub Disable()
            BtnApplications.Enabled = False
            BtnHire.Enabled = False
            BtnMembers.Enabled = False
            BtnOptions.Enabled = False
            BtnTransfer.Enabled = False
        End Sub

#Region "Click"

        Private Async Sub BtnApplications_Click(sender As Object, e As EventArgs) Handles BtnApplications.Click
            FrmManageApplications.Show()
            Await FrmManageApplications.GetApplicants()

            Hide()
        End Sub

        Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
            Close()
        End Sub

        Private Sub BtnHire_Click(sender As Object, e As EventArgs) Handles BtnHire.Click
            FrmHireHenchmen.Show()
            FrmHireHenchmen.SetGuild()
            FrmHireHenchmen.BlnGuild = True
            Hide()
        End Sub

        Private Sub BtnMembers_Click(sender As Object, e As EventArgs) Handles BtnMembers.Click
            FrmMembers.Show()
            FrmMembers.loc = "Manage"
            FrmMembers.LoadMembers()
            Hide()
        End Sub

        Private Sub BtnOptions_Click(sender As Object, e As EventArgs) Handles BtnOptions.Click
            FrmGuildOptions.Show()
            FrmGuildOptions.LoadOptions()
            Hide()
        End Sub

        Private Sub BtnTransfer_Click(sender As Object, e As EventArgs) Handles BtnTransfer.Click
            FrmGuildTransfer.Show()
            FrmGuildTransfer.LoadTransfer()
            Hide()
        End Sub

#End Region

        Private Sub FrmGuildManage_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
            FrmGuild.Show()
            FrmGuild.AddText(TxtGuild.Text)
            FrmGuild.LoadGuild()
        End Sub

    End Class

End Namespace