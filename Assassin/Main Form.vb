' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 05/25/2012
' Filename        : Main Form.vb
' Description     : This game is based on an MS-DOS BBS game created by Kevin MacFarland.
'                   This form allows a user to log into the game, view the Admin form, or view the Manual.

Option Strict On
Option Explicit On

Public Class frmMain
    Dim funcs As New Functions                  'new Functions instance
    Dim ds As New DataSet                       'DataSet
    Dim sql As String                           'SQL
    Dim table As String                         'table name
    Dim nl As String = ControlChars.NewLine     'new line

    Private Function checkLogin() As Boolean
        '* * * * *
        '* This function checks the validity of a login.
        '* * * * *

        Dim userName As String = txtUsername.Text
        Dim pswd As String = txtPswd.Text

        sql = "SELECT * FROM Users WHERE Username='" & userName & "'"
        table = "User"

        ds = funcs.fillDS(sql, table)

        If ds.Tables("User").Rows.Count > 0 Then                                'if username exists
            Dim hashPw As String = funcs.MD5Hash(txtPswd.Text)                  'hash password
            If ds.Tables("User").Rows(0).Item("Pswd").ToString = hashPw Then    'if passwords match
                Return True
            Else                                                                'if passwords don't match
                MessageBox.Show("Please enter the correct password.", "Assassin", MessageBoxButtons.OK)
                Return False
            End If
        Else
            MessageBox.Show("This username doesn't exist.", "Assassin", MessageBoxButtons.OK)
            Return False
        End If
    End Function

    Private Sub login()
        '* * * * *
        '* This function provides information to another form.
        '* * * * *

        Dim userName As String = txtUsername.Text   'save username entered

        ds.Clear()                                  'clear DataSet
        sql = "SELECT * FROM Users WHERE Username='" & userName & "'"
        table = "User"
        ds = funcs.fillDS(sql, table)

        txtUsername.Clear()     'clear username TextBox
        txtPswd.Clear()         'clear password TextBox
        txtUsername.Focus()     'set focus to username TextBox

        frmGame.Show()          'show Game form
        frmGame.ds = ds         'copy DataSet to Game form
        frmGame.loadUser()      'save DataSet information to User Structure
        frmGame.awaken()        'display awakening text

        Me.Hide()
    End Sub


    Private Sub txtPswd_GotFocus(sender As Object, e As System.EventArgs) Handles txtPswd.GotFocus
        '* * * * *
        '* This method selects all text when the Textbox receives focus.
        '* * * * *

        txtPswd.SelectAll()
    End Sub

    Private Sub txtUsername_GotFocus(sender As Object, e As System.EventArgs) Handles txtUsername.GotFocus
        '* * * * *
        '* This method selects all text when the Textbox receives focus.
        '* * * * *

        txtUsername.SelectAll()
    End Sub

    Private Sub keyChars(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUsername.KeyPress, txtPswd.KeyPress
        '* * * * *
        '* This method prevents anything but numbers and letters entered into the TextBoxes.
        '* * * * *

        If Char.IsLetterOrDigit(e.KeyChar) OrElse e.KeyChar Like " " OrElse e.KeyChar Like Chr(8) Then 'letters, numbers, backspace, space
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtUsername.TextChanged, txtPswd.TextChanged
        '* * * * *
        '* This method handles text changing in the TextBoxes as to whether the Login button will be enabled.
        '* * * * *

        If txtUsername.TextLength > 0 AndAlso txtPswd.TextLength > 0 Then
            btnLogin.Enabled = True
        Else
            btnLogin.Enabled = False
        End If
    End Sub


    Private Sub btnLogin_Click(sender As System.Object, e As System.EventArgs) Handles btnLogin.Click
        '* * * * *
        '* This method checks the validity of a login, then logs them in if it is valid.
        '* * * * *

        If txtUsername.TextLength > 0 AndAlso txtPswd.TextLength > 0 Then

            If checkLogin() = True Then
                login()
            End If
        Else
            MessageBox.Show("Please enter a username and password to login.", "Assassin", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub btnNewUser_Click(sender As System.Object, e As System.EventArgs) Handles btnNewUser.Click
        '* * * * *
        '* This method displays the New User form.
        '* * * * *

        frmNewUser.Show()
        Me.Hide()
    End Sub


    Private Sub mnuAdmin_Click(sender As System.Object, e As System.EventArgs) Handles mnuAdmin.Click
        '* * * * *
        '* This method displays the Admin form.
        '* * * * *

        frmAdminLogin.Show()
        txtUsername.Clear()
        txtPswd.Clear()
        txtUsername.Focus()
        Me.Hide()
    End Sub

    Private Sub mnuFileExit_Click(sender As System.Object, e As System.EventArgs) Handles mnuFileExit.Click
        '* * * * *
        '* This method closes the form.
        '* * * * *

        Me.Close()
    End Sub

    Private Sub mnuHelpAbout_Click(sender As System.Object, e As System.EventArgs) Handles mnuHelpAbout.Click
        '* * * * *
        '* This method displays information about the game.
        '* * * * *

        MessageBox.Show("Assassin" & nl & _
                        "v1.0" & nl & _
                        "Original version:" & nl & _
                        "Copyright 1990-1995 Kevin MacFarland" & nl & _
                        "Recreated for Windows:" & nl & _
                        "Copyright 2012 pfthroaway", "Assassin", MessageBoxButtons.OK)
    End Sub

    Private Sub mnuHelpManual_Click(sender As System.Object, e As System.EventArgs) Handles mnuHelpManual.Click
        '* * * * *
        '* This method displays the Manual form.
        '* * * * *

        frmManual.Show()
        Me.Hide()
    End Sub

    Private Sub pctHelp_Click(sender As System.Object, e As System.EventArgs)
        '* * * * *
        '* This method handles clicking the Question Mark picture.
        '* * * * *

        frmManual.Show()
        Me.Hide()
    End Sub

    Private Sub pctHelp_MouseHover(sender As Object, e As System.EventArgs)
        '* * * * *
        '* This method handles the mouse hovering over the Question Mark icon.
        '* * * * *

        Dim cur As Cursor = Cursors.Hand
        Me.Cursor = cur
    End Sub

    Private Sub pctHelp_MouseLeave(sender As Object, e As System.EventArgs)
        '* * * * *
        '* This method handles the mouse leaving the Question Mark icon.
        '* * * * *

        Dim cur As Cursor = Cursors.Default
        Me.Cursor = cur
    End Sub
End Class