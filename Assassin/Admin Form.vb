' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 09/06/2012
' Filename        : Admin Form.vb
' Description     : This form allows access to the various admin functions.

Option Strict On
Option Explicit On

Public Class frmAdmin
    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        '* * * * *
        '* This method closes the form on clicking the Back button.
        '* * * * *

        Me.Close()
    End Sub

    Private Sub btnChangePassword_Click(sender As System.Object, e As System.EventArgs) Handles btnChangePassword.Click
        '* * * * *
        '* This method displays the Change password form.
        '* * * * *

        frmChangePassword.Show()
        frmChangePassword.blnAdmin = True
        Me.Hide()
    End Sub

    Private Sub btnEnemies_Click(sender As System.Object, e As System.EventArgs) Handles btnEnemies.Click
        '* * * * *
        '* This method closes the form on clicking the Back button.
        '* * * * *

        frmAdminEnemies.Show()
        Me.Hide()
    End Sub

    Private Sub btnGuilds_Click(sender As System.Object, e As System.EventArgs) Handles btnGuilds.Click
        '* * * * *
        '* This method closes the form on clicking the Back button.
        '* * * * *

        frmAdminGuilds.Show()
        Me.Hide()
    End Sub

    Private Sub btnUsers_Click(sender As System.Object, e As System.EventArgs) Handles btnUsers.Click
        '* * * * *
        '* This method closes the form on clicking the Back button.
        '* * * * *

        frmAdminUsers.Show()
        Me.Hide()
    End Sub


    Private Sub frmAdmin_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        '* * * * *
        '* This method handles closing the form.
        '* * * * *

        frmMain.Show()
    End Sub
End Class