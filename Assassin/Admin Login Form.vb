' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 09/06/2012
' Filename        : Admin Login Form.vb
' Description     : This form allows access to the Admin form.

Option Strict On
Option Explicit On

Public Class frmAdminLogin
    Dim funcs As New Functions      'new Functions instance
    Dim ds As DataSet               'DataSet
    Dim sql As String               'SQL query
    Dim table As String             'table name
    Dim blnAdmin As Boolean = False 'going to admin form?

    Private Sub btnSubmit_Click(sender As System.Object, e As System.EventArgs) Handles btnSubmit.Click
        '* * * * *
        '* This method handles clicking the Submit button.
        '* * * * *

        Dim password As String = funcs.MD5Hash(txtPassword.Text)
        sql = "SELECT * FROM Admin"
        table = "Admin"
        ds = funcs.fillDS(sql, table)

        If password = ds.Tables("Admin").Rows(0).Item("AdminPassword").ToString Then
            blnAdmin = True
            Me.Close()
        Else
            MessageBox.Show("Please enter the correct password.", "Assassin", MessageBoxButtons.OK)
            txtPassword.SelectAll()
        End If
    End Sub


    Private Sub frmAdminLogin_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        '* * * * *
        '* This method handles the form closing.
        '* * * * *

        If blnAdmin = True Then
            frmAdmin.Show()
        Else
            frmMain.Show()
        End If
    End Sub
End Class