' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 05/25/2012
' Filename        : Main Form.vb
' Description     : This game is based on an MS-DOS BBS game created by Kevin MacFarland.
'                   This form allows a user to log into the game, view the Admin form, or view the Manual.

Option Strict On
Option Explicit On

Imports Assassin.Classes
Imports Assassin.Classes.Entities
Imports Assassin.Forms.Admin
Imports Extensions.Encryption
Imports System.Threading.Tasks

Namespace Forms

    Public Class FrmMain

        ''' <summary>Checks whether a valid login has occurred.</summary>
        ''' <returns></returns>
        Private Async Function CheckLogin() As Task(Of Boolean)
            Dim newUser As User = Await LoadUser(TxtUsername.Text)
            If newUser <> New User() Then
                If Argon2.ValidatePassword(newUser.Password, TxtPswd.Text) Then
                    CurrentUser = newUser
                    Return True
                Else
                    MessageBox.Show("Unable to verify credentials.", "Assassin", MessageBoxButtons.OK)
                End If
            Else
                MessageBox.Show("Unable to verify credentials.", "Assassin", MessageBoxButtons.OK)
            End If
            Return False
        End Function

        ''' <summary>When a valid login has occurred, log the character in.</summary>
        Private Sub Login()

            TxtUsername.Clear()     'clear username TextBox
            TxtPswd.Clear()         'clear password TextBox
            TxtUsername.Focus()     'set focus to username TextBox

            FrmGame.Show()          'show Game form
            FrmGame.Awaken()        'display awakening text

            Me.Hide()
        End Sub

        Private Sub TxtPswd_GotFocus(sender As Object, e As EventArgs) Handles TxtPswd.GotFocus

            TxtPswd.SelectAll()
        End Sub

        Private Sub TxtUsername_GotFocus(sender As Object, e As EventArgs) Handles TxtUsername.GotFocus

            TxtUsername.SelectAll()
        End Sub

        Private Shared Sub KeyChars(sender As Object, e As KeyPressEventArgs) Handles TxtUsername.KeyPress, TxtPswd.KeyPress
            If Char.IsLetterOrDigit(e.KeyChar) OrElse e.KeyChar Like " " OrElse e.KeyChar Like Chr(8) Then 'letters, numbers, backspace, space
                e.Handled = False
            Else
                e.Handled = True
            End If
        End Sub

        Private Sub Txt_TextChanged(sender As Object, e As EventArgs) Handles TxtUsername.TextChanged, TxtPswd.TextChanged
            BtnLogin.Enabled = TxtUsername.TextLength > 0 AndAlso TxtPswd.TextLength > 0
        End Sub

        Private Async Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
            If TxtUsername.TextLength > 0 AndAlso TxtPswd.TextLength > 0 Then
                If Await CheckLogin() Then
                    Login()
                End If
            Else
                MessageBox.Show("Please enter a username and password to login.", "Assassin", MessageBoxButtons.OK)
            End If
        End Sub

        Private Sub BtnNewUser_Click(sender As Object, e As EventArgs) Handles BtnNewUser.Click
            FrmNewUser.Show()
            Me.Hide()
        End Sub

        Private Sub MnuAdmin_Click(sender As Object, e As EventArgs) Handles mnuAdmin.Click
            FrmAdminLogin.Show()
            TxtUsername.Clear()
            TxtPswd.Clear()
            TxtUsername.Focus()
            Me.Hide()
        End Sub

        Private Sub MnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
            Me.Close()
        End Sub

        Private Sub MnuHelpAbout_Click(sender As Object, e As EventArgs) Handles mnuHelpAbout.Click
            Dim nl As String = Environment.NewLine
            MessageBox.Show("Assassin" & nl &
                            "v1.0" & nl &
                            "Original version:" & nl &
                            "Copyright 1990-1995 Kevin MacFarland" & nl &
                            "Recreated for Windows:" & nl &
                            "Copyright 2012 pfthroaway", "Assassin", MessageBoxButtons.OK)
        End Sub

        Private Sub MnuHelpManual_Click(sender As Object, e As EventArgs) Handles mnuHelpManual.Click
            FrmManual.Show()
            Me.Hide()
        End Sub

        Private Async Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Await LoadAll()
        End Sub

    End Class

End Namespace