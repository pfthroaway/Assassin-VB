Option Strict On
Option Explicit On

Namespace Forms.Admin

    Public Class FrmAdmin

#Region "Click"

        Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
            Close()
        End Sub

        Private Sub BtnChangePassword_Click(sender As Object, e As EventArgs) Handles BtnChangePassword.Click
            FrmChangePassword.Show()
            FrmChangePassword.BlnAdmin = True
            Hide()
        End Sub

        Private Sub BtnEnemies_Click(sender As Object, e As EventArgs) Handles BtnEnemies.Click
            FrmAdminEnemies.Show()
            Hide()
        End Sub

        Private Sub BtnGuilds_Click(sender As Object, e As EventArgs) Handles BtnGuilds.Click
            FrmAdminGuilds.Show()
            Hide()
        End Sub

        Private Sub BtnUsers_Click(sender As Object, e As EventArgs) Handles BtnUsers.Click
            FrmAdminUsers.Show()
            Hide()
        End Sub

#End Region

        Private Sub FrmAdmin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
            FrmMain.Show()
        End Sub

    End Class

End Namespace