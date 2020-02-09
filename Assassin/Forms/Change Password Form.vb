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
                    Dim newPass As String = PBKDF2.HashPassword(TxtNewPswd.Text)
                    If BlnAdmin = False Then
                        If PBKDF2.ValidatePassword(TxtOldPswd.Text, CurrentUser.Password) Then
                            CurrentUser.Password = newPass
                            Await SaveUser(CurrentUser)
                            MessageBox.Show("Password successfully changed.", "Assassin", MessageBoxButtons.OK)
                            Close()
                        Else
                            MessageBox.Show("Please enter the correct current password.", "Assassin", MessageBoxButtons.OK)
                        End If
                    Else
                        If PBKDF2.ValidatePassword(TxtOldPswd.Text, AdminPassword) Then
                            If Await ChangeAdminPassword(newPass) Then
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
            e.Handled = Not (Char.IsLetterOrDigit(e.KeyChar) OrElse e.KeyChar Like Chr(8))
        End Sub

        Private Sub PswdTextChanged(sender As Object, e As EventArgs) Handles TxtOldPswd.TextChanged, TxtNewPswd.TextChanged, TxtConfPswd.TextChanged
            BtnSubmit.Enabled = TxtOldPswd.TextLength > 0 AndAlso TxtNewPswd.TextLength > 0 AndAlso TxtConfPswd.TextLength > 0
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