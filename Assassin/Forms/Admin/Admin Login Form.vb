﻿Option Strict On
Option Explicit On

Imports Assassin.Classes
Imports Extensions.Encryption

Namespace Forms.Admin

    Public Class FrmAdminLogin
        Dim _blnAdmin As Boolean = False

        Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
            If PBKDF2.ValidatePassword(TxtPassword.Text.Trim(), AdminPassword) Then
                _blnAdmin = True
                Close()
            Else
                MessageBox.Show("Please enter the correct password.", "Assassin", MessageBoxButtons.OK)
                TxtPassword.SelectAll()
            End If
        End Sub

        Private Sub FrmAdminLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
            If _blnAdmin = True Then
                FrmAdmin.Show()
            Else
                FrmMain.Show()
            End If
        End Sub

    End Class

End Namespace