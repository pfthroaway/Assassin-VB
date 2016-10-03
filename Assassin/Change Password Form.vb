' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 05/25/2012
' Filename        : Change Password Form.vb
' Description     : This form allows a user to change their password.

Option Strict On
Option Explicit On

Public Class frmChangePassword
    Dim funcs As New Functions          'new Functions instance
    Public currUser As New User         'current user
    Dim ds As New DataSet               'DataSet
    Dim sql As String                   'SQL query
    Dim table As String                 'table name
    Public blnAdmin As Boolean = False  'admin?

    Private Sub txtOldPswd_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtOldPswd.KeyPress, txtNewPswd.KeyPress, _
        txtConfPswd.KeyPress
        '* * * * *
        '* This method handles what keys can be pressed in the Textboxes.
        '* * * * *

        If Char.IsLetterOrDigit(e.KeyChar) OrElse e.KeyChar Like Chr(8) Then    'letters, numbers, backspace
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub pswdTextChanged(sender As System.Object, e As System.EventArgs) Handles txtOldPswd.TextChanged, txtNewPswd.TextChanged, _
        txtConfPswd.TextChanged
        '* * * * *
        '* This method handles when to enable the Submit button.
        '* * * * *

        If txtOldPswd.TextLength > 0 AndAlso txtNewPswd.TextLength > 0 AndAlso txtConfPswd.TextLength > 0 Then
            btnSubmit.Enabled = True
        Else
            btnSubmit.Enabled = False
        End If
    End Sub


    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        '* * * * *
        '* This method closes the form on clicking the Back button.
        '* * * * *

        Me.Close()
    End Sub

    Private Sub btnSubmit_Click(sender As System.Object, e As System.EventArgs) Handles btnSubmit.Click
        '* * * * *
        '* This method handles clicking the Submit button.
        '* * * * *

        Dim oldPass As String = funcs.MD5Hash(txtOldPswd.Text)

        If txtNewPswd.Text = txtConfPswd.Text Then  'if passwords match
            Dim newPass As String = funcs.MD5Hash(txtNewPswd.Text)
            If blnAdmin = False Then
                If oldPass = currUser.password Then
                    currUser.password = newPass
                    funcs.save(currUser)
                    MessageBox.Show("Password successfully changed.", "Assassin", MessageBoxButtons.OK)
                    Me.Close()
                Else
                    MessageBox.Show("Please enter the correct current password.", "Assassin", MessageBoxButtons.OK)
                End If
            Else
                sql = "SELECT * FROM Admin"
                table = "Admin"

                ds = funcs.fillDS(sql, table)

                If oldPass = ds.Tables("Admin").Rows(0).Item("AdminPassword").ToString Then
                    ds.Tables("Admin").Rows(0).Item("AdminPassword") = newPass
                    funcs.updateRecord(sql, table, ds)
                    MessageBox.Show("Password successfully changed.", "Assassin", MessageBoxButtons.OK)
                    Me.Close()
                Else
                    MessageBox.Show("Please enter the correct current password.", "Assassin", MessageBoxButtons.OK)
                End If
            End If
        Else
            MessageBox.Show("Please verify the new password matches the confirmation.", "Assassin", MessageBoxButtons.OK)
        End If
    End Sub


    Private Sub frmChangePassword_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        '* * * * *
        '* This method handles the form closing.
        '* * * * *

        If blnAdmin = True Then
            frmAdmin.Show()
        Else
            frmGame.Show()
            frmGame.currUser = currUser
        End If
    End Sub
End Class