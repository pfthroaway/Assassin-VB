' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 05/25/2012
' Filename        : Change Password Form.vb
' Description     : This form allows a user to change their password.

Option Strict On
Option Explicit On

Imports Assassin.Classes
Imports Assassin.Forms.Admin
Imports Extensions.Encryption

Namespace Forms

    Public Class FrmChangePassword

        Public BlnAdmin As Boolean = False  'admin?

#Region "Click"

        Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
            Close()
        End Sub

        Private Async Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
            If Not TxtOldPswd.Text = TxtNewPswd.Text Then

                If TxtNewPswd.Text = TxtConfPswd.Text Then  'if passwords match
                    Dim newPass As String = Argon2.HashPassword(TxtNewPswd.Text)
                    If BlnAdmin = False Then
                        If Argon2.ValidatePassword(CurrentUser.Password, TxtOldPswd.Text) Then
                            CurrentUser.Password = newPass
                            Await SaveUser(CurrentUser)
                            MessageBox.Show("Password successfully changed.", "Assassin", MessageBoxButtons.OK)
                            Close()
                        Else
                            MessageBox.Show("Please enter the correct current password.", "Assassin", MessageBoxButtons.OK)
                        End If
                    Else
                        If Argon2.ValidatePassword(AdminPassword, TxtOldPswd.Text) Then
                            If Await (ChangeAdminPassword(newPass)) Then
                                MessageBox.Show("Password successfully changed.", "Assassin", MessageBoxButtons.OK)
                                Close()
                            End If
                        Else
                            MessageBox.Show("Please enter the correct current password.", "Assassin", MessageBoxButtons.OK)
                        End If
                    End If
                End If
            Else
                MessageBox.Show("Please verify the new password matches the confirmation.", "Assassin", MessageBoxButtons.OK)
            End If
        End Sub

#End Region

#Region "Form Management"

        Private Sub TxtOldPswd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtOldPswd.KeyPress, TxtNewPswd.KeyPress, TxtConfPswd.KeyPress
            If Char.IsLetterOrDigit(e.KeyChar) OrElse e.KeyChar Like Chr(8) Then    'letters, numbers, backspace
                e.Handled = False
            Else
                e.Handled = True
            End If
        End Sub

        Private Sub PswdTextChanged(sender As Object, e As EventArgs) Handles TxtOldPswd.TextChanged, TxtNewPswd.TextChanged, TxtConfPswd.TextChanged
            If TxtOldPswd.TextLength > 0 AndAlso TxtNewPswd.TextLength > 0 AndAlso TxtConfPswd.TextLength > 0 Then
                BtnSubmit.Enabled = True
            Else
                BtnSubmit.Enabled = False
            End If
        End Sub

        Private Sub FrmChangePassword_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
            If BlnAdmin = True Then
                FrmAdmin.Show()
            Else
                FrmGame.Show()
            End If
        End Sub

#End Region

    End Class

End Namespace