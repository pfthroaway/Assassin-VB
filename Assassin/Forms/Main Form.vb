Option Strict On
Option Explicit On

Imports Assassin.Classes
Imports Assassin.Classes.Entities
Imports Assassin.Forms.Admin
Imports Extensions.Encryption

Namespace Forms

    Public Class FrmMain

        ''' <summary>Checks whether a valid login has occurred.</summary>
        ''' <returns>True if successful login</returns>
        Private Function CheckLogin() As Boolean
            If AllUsers.Count > 0 Then
                Dim NewUser As User = AllUsers.Find(Function(user) String.Equals(user.Name, TxtUsername.Text, StringComparison.OrdinalIgnoreCase))
                If Not NewUser Is Nothing AndAlso NewUser <> New User() AndAlso PBKDF2.ValidatePassword(TxtPswd.Text, NewUser.Password) Then
                    CurrentUser = NewUser
                    Return True
                End If
                MessageBox.Show("Unable to verify credentials.", "Assassin", MessageBoxButtons.OK)
                Return False
            Else
                MessageBox.Show($"There are no users.{ControlChars.NewLine}Please create one to log in.", "Assassin", MessageBoxButtons.OK)
                Return False
            End If
        End Function

        ''' <summary>When a valid login has occurred, log the character in.</summary>
        Private Sub Login()
            TxtUsername.Clear()
            TxtPswd.Clear()
            TxtUsername.Focus()

            FrmGame.Show()
            FrmGame.Awaken()

            Hide()
        End Sub

#Region "Click"

        Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
            If TxtUsername.TextLength > 0 AndAlso TxtPswd.TextLength > 0 Then
                If CheckLogin() Then
                    Login()
                End If
            Else
                MessageBox.Show("Please enter a username and password to login.", "Assassin", MessageBoxButtons.OK)
            End If
        End Sub

        Private Sub BtnNewUser_Click(sender As Object, e As EventArgs) Handles BtnNewUser.Click
            FrmNewUser.Show()
            Hide()
        End Sub

        Private Sub MnuAdmin_Click(sender As Object, e As EventArgs) Handles mnuAdmin.Click
            FrmAdminLogin.Show()
            TxtUsername.Clear()
            TxtPswd.Clear()
            TxtUsername.Focus()
            Hide()
        End Sub

        Private Sub MnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
            Close()
        End Sub

        Private Sub MnuHelpAbout_Click(sender As Object, e As EventArgs) Handles mnuHelpAbout.Click
            Dim nl As String = Environment.NewLine
            MessageBox.Show("Assassin" & nl &
                            "v1.0" & nl &
                            "Original version:" & nl &
                            "Copyright 1990-1995 Kevin MacFarland" & nl &
                            "Recreated for Windows:" & nl &
                            "Copyright 2012-2020 pfthroaway", "Assassin", MessageBoxButtons.OK)
        End Sub

        Private Sub MnuHelpManual_Click(sender As Object, e As EventArgs) Handles mnuHelpManual.Click
            FrmManual.Show()
            Hide()
        End Sub

#End Region

#Region "Form Management"

        Private Async Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Await LoadAll()
        End Sub

        Private Sub TxtPswd_GotFocus(sender As Object, e As EventArgs) Handles TxtPswd.GotFocus
            TxtPswd.SelectAll()
        End Sub

        Private Sub TxtUsername_GotFocus(sender As Object, e As EventArgs) Handles TxtUsername.GotFocus
            TxtUsername.SelectAll()
        End Sub

        Private Shared Sub KeyChars(sender As Object, e As KeyPressEventArgs) Handles TxtUsername.KeyPress, TxtPswd.KeyPress
            e.Handled = Not (Char.IsLetterOrDigit(e.KeyChar) OrElse e.KeyChar Like " " OrElse e.KeyChar Like Chr(8))
        End Sub

        Private Sub Txt_TextChanged(sender As Object, e As EventArgs) Handles TxtUsername.TextChanged, TxtPswd.TextChanged
            BtnLogin.Enabled = TxtUsername.TextLength > 0 AndAlso TxtPswd.TextLength > 0
        End Sub

#End Region

    End Class

End Namespace