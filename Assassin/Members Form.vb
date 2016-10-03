' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 05/25/2012
' Filename        : Members Form.vb
' Description     : This form contains the list of users.

Option Strict On
Option Explicit On

Public Class frmMembers
    Dim funcs As New Functions      'new Functions instance
    Public currUser As New User     'current user
    Public currGuild As New Guild   'current guild
    Dim ds As New DataSet           'DataSet
    Dim sql As String               'SQL query
    Dim table As String             'table name
    Public loc As String            'location

    Public Sub loadMembers()
        '* * * * *
        '* This method loads members of the current guild.
        '* * * * *

        lstMembers.Items.Clear()

        If loc = "Manage" Then
            btnExpel.Show()
            lblName.Text = currGuild.name & " Members"

            sql = "SELECT * FROM Guild" & currGuild.id & "Members ORDER BY Username Asc"
            table = "Members"
            ds = funcs.fillDS(sql, table)

            For i As Integer = 0 To ds.Tables("Members").Rows.Count - 1
                lstMembers.Items.Add(ds.Tables("Members").Rows(i).Item("Username"))
            Next
        ElseIf loc = "Guild" Then
            lblName.Text = currGuild.name & " Members"

            sql = "SELECT * FROM Guild" & currGuild.id & "Members ORDER BY Username Asc"
            table = "Members"
            ds = funcs.fillDS(sql, table)

            For i As Integer = 0 To ds.Tables("Members").Rows.Count - 1
                lstMembers.Items.Add(ds.Tables("Members").Rows(i).Item("Username"))
            Next
        ElseIf loc = "Streets" Then
            btnAttack.Show()
            lblName.Text = "All Players"

            sql = "SELECT ID,Username,Location FROM Users ORDER BY ID Asc"
            table = "Members"
            ds = funcs.fillDS(sql, table)

            For i As Integer = 0 To ds.Tables("Members").Rows.Count - 1
                lstMembers.Items.Add(ds.Tables("Members").Rows(i).Item("Username"))
            Next
        End If
    End Sub


    Private Sub btnAttack_Click(sender As System.Object, e As System.EventArgs) Handles btnAttack.Click
        '* * * * *
        '* This method attacks another player.
        '* * * * *


    End Sub

    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        '* * * * *
        '* This method closes the form on clicking the Back button.
        '* * * * *

        Me.Close()
    End Sub

    Private Sub btnExpel_Click(sender As System.Object, e As System.EventArgs) Handles btnExpel.Click
        '* * * * *
        '* This method expels the selected user.
        '* * * * *

        Dim dlg As DialogResult
        Dim expelName As String = lstMembers.SelectedItem.ToString
        dlg = MessageBox.Show("Are you sure you want to expel " & expelName & "?", "Assassin", MessageBoxButtons.YesNo)
        If dlg = DialogResult.Yes Then
            sql = "SELECT * FROM Guild" & currGuild.id & "Members WHERE Username='" & expelName & "'"
            table = "Members"

            ds = funcs.fillDS(sql, table)
            funcs.deleteRecord(sql, table, ds)

            MessageBox.Show("Member successfully expelled.")

            sql = "SELECT * FROM Messages WHERE UserTo='" & expelName & "' AND UserFrom='" & currGuild.name.Replace("'", "''") & _
            "' AND Message='You have been expelled from " & currGuild.name.Replace("'", "''") & ".'"
            table = "Messages"

            ds = funcs.fillDS(sql, table)
            Dim dsNewRow As DataRow
            dsNewRow = ds.Tables("Messages").NewRow()
            dsNewRow.Item("UserTo") = expelName
            dsNewRow.Item("UserFrom") = currGuild.name
            dsNewRow.Item("Message") = "You have been expelled from " & currGuild.name & "."
            dsNewRow.Item("DateSent") = Now
            dsNewRow.Item("GuildMessage") = True

            ds.Tables("Messages").Rows.Add(dsNewRow)
            funcs.updateRecord(sql, table, ds)
            loadMembers()
        End If
    End Sub

    Private Sub btnMessage_Click(sender As System.Object, e As System.EventArgs) Handles btnMessage.Click
        '* * * * *
        '* This method closes the form on clicking the Back button.
        '* * * * *

        frmMessages.Show()
        frmMessages.currUser = currUser
        frmMessages.startSend()
        frmMessages.loc = "Members"
        frmMessages.cmbNames.SelectedItem = lstMembers.SelectedItem.ToString
        Me.Hide()
    End Sub


    Private Sub lstMembers_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstMembers.SelectedIndexChanged
        '* * * * *
        '* This method closes the form on clicking the Back button.
        '* * * * *

        If lstMembers.SelectedIndex >= 0 Then
            If lstMembers.SelectedItem.ToString <> currUser.name Then
                btnMessage.Enabled = True
                btnExpel.Enabled = True
                If loc = "Streets" Then
                    If ds.Tables("Members").Rows(lstMembers.SelectedIndex).Item("Location").ToString = "Streets" Then
                        btnAttack.Enabled = True
                    Else
                        btnAttack.Enabled = False
                    End If
                End If
            Else
                btnMessage.Enabled = False
                btnExpel.Enabled = False
                btnAttack.Enabled = False
            End If
        Else
            btnMessage.Enabled = False
            btnExpel.Enabled = False
            btnAttack.Enabled = False
        End If
    End Sub


    Private Sub frmMembers_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        '* * * * *
        '* This method handles closing the form.
        '* * * * *

        If loc = "Manage" Then
            frmGuildManage.Show()
            frmGuildManage.currUser = currUser
        ElseIf loc = "Guild" Then
            frmGuild.Show()
            frmGuild.currUser = currUser
        ElseIf loc = "Streets" Then
            frmGame.Show()
            frmGame.currUser = currUser
        End If
    End Sub
End Class