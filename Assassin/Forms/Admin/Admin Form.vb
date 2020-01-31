' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 09/06/2012
' Filename        : Admin Form.vb
' Description     : This form allows access to the various admin functions.

Option Strict On
Option Explicit On

Namespace Forms.Admin

    Public Class FrmAdmin

        Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
            '* * * * *
            '* This method closes the form on clicking the Back button.
            '* * * * *

            Me.Close()
        End Sub

        Private Sub BtnChangePassword_Click(sender As Object, e As EventArgs) Handles BtnChangePassword.Click
            '* * * * *
            '* This method displays the Change password form.
            '* * * * *

            FrmChangePassword.Show()
            FrmChangePassword.BlnAdmin = True
            Me.Hide()
        End Sub

        Private Sub BtnEnemies_Click(sender As Object, e As EventArgs) Handles BtnEnemies.Click
            '* * * * *
            '* This method closes the form on clicking the Back button.
            '* * * * *

            FrmAdminEnemies.Show()
            Me.Hide()
        End Sub

        Private Sub BtnGuilds_Click(sender As Object, e As EventArgs) Handles BtnGuilds.Click
            '* * * * *
            '* This method closes the form on clicking the Back button.
            '* * * * *

            FrmAdminGuilds.Show()
            Me.Hide()
        End Sub

        Private Sub BtnUsers_Click(sender As Object, e As EventArgs) Handles BtnUsers.Click
            '* * * * *
            '* This method closes the form on clicking the Back button.
            '* * * * *

            FrmAdminUsers.Show()
            Me.Hide()
        End Sub

        Private Sub FrmAdmin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
            '* * * * *
            '* This method handles closing the form.
            '* * * * *

            FrmMain.Show()
        End Sub

    End Class

End Namespace