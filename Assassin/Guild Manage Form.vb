' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 10/11/2012
' Filename        : Guild Manage Form.vb
' Description     : This form allows a guildmaster to manage their guild.

Option Strict On
Option Explicit On

Public Class frmGuildManage
    Dim funcs As New Functions
    Public currUser As New User
    Public currGuild As New Guild
    Dim nl As String = ControlChars.NewLine

    Public Sub addText(ByVal newText As String)
        '* * * * *
        '* This method adds text to the Textbox.
        '* * * * *

        Dim currText As String = txtGuild.Text
        txtGuild.Clear()

        txtGuild.Text = newText & nl & nl & currText
        txtGuild.Select(0, 0)
        txtGuild.ScrollToCaret()
    End Sub

    Public Sub disable()
        '* * * * *
        '* This method disables all buttons on the form if master of the guild is changed.
        '* * * * *

        btnApplications.Enabled = False
        btnHire.Enabled = False
        btnMembers.Enabled = False
        btnOptions.Enabled = False
        btnTransfer.Enabled = False
    End Sub

    Private Sub btnApplications_Click(sender As System.Object, e As System.EventArgs) Handles btnApplications.Click
        '* * * * *
        '* This method handles clicking the Applications button.
        '* * * * *

        frmManageApplications.Show()
        frmManageApplications.currGuild = currGuild
        frmManageApplications.getApplicants()

        Me.Hide()
    End Sub

    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        '* * * * *
        '* This method closes the form on clicking the Back button.
        '* * * * *

        Me.Close()
    End Sub

    Private Sub btnHire_Click(sender As System.Object, e As System.EventArgs) Handles btnHire.Click
        '* * * * *
        '* This method handles clicking the Hire button.
        '* * * * *

        frmHireHenchmen.Show()
        frmHireHenchmen.currGuild = currGuild
        frmHireHenchmen.setGuild()
        frmHireHenchmen.blnGuild = True
        Me.Hide()
    End Sub

    Private Sub btnMembers_Click(sender As System.Object, e As System.EventArgs) Handles btnMembers.Click
        '* * * * *
        '* This method allows the guildmaster to manage the members of his guild.
        '* * * * *

        frmMembers.Show()
        frmMembers.currUser = currUser
        frmMembers.currGuild = currGuild
        frmMembers.loc = "Manage"
        frmMembers.loadMembers()
        Me.Hide()
    End Sub

    Private Sub btnOptions_Click(sender As System.Object, e As System.EventArgs) Handles btnOptions.Click
        '* * * * *
        '* This method displays the Guild Options form.
        '* * * * *

        frmGuildOptions.Show()
        frmGuildOptions.currUser = currUser
        frmGuildOptions.currGuild = currGuild
        frmGuildOptions.loadOptions()
        Me.Hide()
    End Sub

    Private Sub btnTransfer_Click(sender As System.Object, e As System.EventArgs) Handles btnTransfer.Click
        '* * * * *
        '* This method displays the form which allows a guildmaster to transfer gold and henchmen.
        '* * * * *

        frmGuildTransfer.Show()
        frmGuildTransfer.currUser = currUser
        frmGuildTransfer.currGuild = currGuild
        frmGuildTransfer.loadTransfer()
        Me.Hide()
    End Sub


    Private Sub frmGuildManage_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        '* * * * *
        '* This method handles closing the form.
        '* * * * *

        frmGuild.Show()
        frmGuild.currGuild = currGuild
        frmGuild.currUser = currUser
        frmGuild.addText(txtGuild.Text)
        frmGuild.loadGuild()
    End Sub
End Class