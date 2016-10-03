' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 09/29/2012
' Filename        : Jail Form.vb
' Description     : This form displays all users currently jailed.

Option Strict On
Option Explicit On

Public Class frmJail
    Dim funcs As New Functions              'new Functions instance
    Dim ds As New DataSet                   'DataSet
    Dim sql As String                       'SQL query
    Dim table As String                     'table name
    Dim nl As String = ControlChars.NewLine 'new line
    Public currUser As New User             'current user
    Dim username As String                  'selected username
    Dim reason As String                    'reason jailed
    Dim fine As Integer                     'fine

    Public Sub display()
        '* * * * *
        '* This method displays all the users currently in jail
        '* * * * *

        lstJailed.Items.Clear()     'clear ListBox
        lstJailed.ClearSelected()   'deselect ListBox items
        lblFine.Text = ""
        lblReason.Text = ""

        sql = "SELECT UserName FROM Jail"
        table = "Jailed"
        ds.Clear()
        ds = funcs.fillDS(sql, table)

        For i As Integer = 0 To ds.Tables("Jailed").Rows.Count - 1
            lstJailed.Items.Add(ds.Tables("Jailed").Rows(i).Item("UserName"))
        Next

        btnBailOut.Enabled = False
    End Sub


    Private Sub lstJailed_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstJailed.SelectedIndexChanged
        '* * * * *
        '* This method displays jail information about the selected user.
        '* * * * *

        If lstJailed.SelectedIndex >= 0 Then
            username = lstJailed.SelectedItem.ToString
            ds.Clear()
            sql = "SELECT * FROM Jail WHERE Username='" & username & "'"
            table = "Jail"
            ds = funcs.fillDS(sql, table)

            reason = ds.Tables("Jail").Rows(0).Item("Reason").ToString
            Integer.TryParse(ds.Tables("Jail").Rows(0).Item("Fine").ToString, fine)

            lblReason.Text = reason
            lblFine.Text = fine.ToString

            If currUser.goldOnHand >= fine Then
                btnBailOut.Enabled = True
            Else
                btnBailOut.Enabled = False
            End If
        End If
    End Sub


    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        '* * * * *
        '* This method closes the form.
        '* * * * *

        Me.Close()
    End Sub

    Private Sub btnBailOut_Click(sender As System.Object, e As System.EventArgs) Handles btnBailOut.Click
        '* * * * *
        '* This method bails a user out of jail.
        '* * * * *

        ds.Clear()                          'clear dataSet
        sql = "SELECT * FROM Jail WHERE Username='" & username & "'"
        table = "Jail"
        ds = funcs.fillDS(sql, table)       'fill DataSet

        funcs.deleteRecord(sql, table, ds)  'delete record

        currUser.goldOnHand -= fine
        ds.Clear()                          'clear DataSet

        sql = "SELECT * FROM Users WHERE Username='" & username & "'"
        table = "Users"
        ds = funcs.fillDS(sql, table)       'fill DataSet

        ds.Tables("Users").Rows(0).Item("Location") = "Streets" 'change location to street

        funcs.updateRecord(sql, table, ds)  'update Record

        display()
    End Sub


    Private Sub frmJail_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        '* * * * *
        '* This method handles what happens on loading the form.
        '* * * * *

        display()
    End Sub

    Private Sub frmJail_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        '* * * * *
        '* This method manages closing the form.
        '* * * * *

        frmGame.Show()
        frmGame.currUser = currUser
        funcs.save(currUser)
    End Sub
End Class