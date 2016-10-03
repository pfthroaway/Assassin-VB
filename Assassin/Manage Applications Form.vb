' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 05/25/2012
' Filename        : Manage Applications Form.vb
' Description     : This form allows a guildmaster to confirm or deny applications to join the guild.

Option Strict On
Option Explicit On

Public Class frmManageApplications
    Dim funcs As New Functions      'new Functions instance
    Public currGuild As New Guild   'current Guild
    Dim ds As New DataSet           'DataSet
    Dim sql As String               'SQL query
    Dim table As String             'table name
    Dim applicant As String         'applicant's username

    Private Sub clear()
        '* * * * *
        '* This method resets all the data in the form.
        '* * * * *

        btnConfirm.Enabled = False
        btnDeny.Enabled = False
        lstApplications.ClearSelected()
        lstApplications.Items.Clear()
    End Sub

    Private Sub confirm()
        '* * * * *
        '* This method confirms an applicant.
        '* * * * *

        sql = "SELECT * FROM Applications WHERE Guild=" & currGuild.id & " AND Username='" & applicant & "'"
        table = "Applications"

        ds = funcs.fillDS(sql, table)                   'fill DS with applicants
        funcs.deleteRecord(sql, table, ds)              'delete application

        sql = "SELECT * FROM Guild" & currGuild.id & "Members WHERE Username='" & applicant & "'"
        table = "Guild"

        ds = funcs.fillDS(sql, table)                   'fill DS with guild members with applicant name
        Dim dsNewRow As DataRow
        dsNewRow = ds.Tables("Guild").NewRow()          'create new row
        dsNewRow.Item("Username") = applicant

        ds.Tables("Guild").Rows.Add(dsNewRow)           'add new row to DataSet
        funcs.updateRecord(sql, table, ds)              'update DataSet

        sql = "SELECT * FROM Messages WHERE UserTo='" & applicant & "' AND UserFrom='" & currGuild.name.Replace("'", "''") & _
            "' AND Message='Your application to join the " & currGuild.name.Replace("'", "''") & " guild has been approved. Welcome!'"
        table = "Messages"

        ds = funcs.fillDS(sql, table)

        Dim dsNewRow2 As DataRow
        dsNewRow2 = ds.Tables("Messages").NewRow()
        dsNewRow2.Item("UserTo") = applicant
        dsNewRow2.Item("UserFrom") = currGuild.name
        dsNewRow2.Item("Message") = "Your application to join the " & currGuild.name & " guild has been approved. Welcome!"
        dsNewRow2.Item("DateSent") = Now
        dsNewRow2.Item("GuildMessage") = True

        ds.Tables("Messages").Rows.Add(dsNewRow2)
        funcs.updateRecord(sql, table, ds)
        
        getApplicants()
        MessageBox.Show("Application successfully approved.", "Assassin", MessageBoxButtons.OK)
        frmGuildManage.addText(applicant & " has been accepted to the guild.")
    End Sub

    Private Sub deny()
        '* * * * *
        '* This method denies an applicant.
        '* * * * *

        sql = "SELECT * FROM Applications WHERE Guild=" & currGuild.id & " AND Username='" & applicant & "'"
        table = "Applications"

        ds = funcs.fillDS(sql, table)       'fill DS
        funcs.deleteRecord(sql, table, ds)  'delete application

        sql = "SELECT * FROM Messages WHERE UserTo='" & applicant & "' AND UserFrom='" & currGuild.name.Replace("'", "''") & _
            "' AND Message='Your application to join the " & currGuild.name.Replace("'", "''") & " guild has been approved. Welcome!'"
        table = "Messages"

        ds = funcs.fillDS(sql, table)
        If ds.Tables("Messages").Rows.Count = 0 Then
            Dim dsNewRow As DataRow
            dsNewRow = ds.Tables("Messages").NewRow()
            dsNewRow.Item("UserTo") = applicant
            dsNewRow.Item("UserFrom") = currGuild.name
            dsNewRow.Item("Message") = "Your application to join the " & currGuild.name & " guild has been declined."
            dsNewRow.Item("DateSent") = Now
            dsNewRow.Item("GuildMessage") = True

            ds.Tables("Messages").Rows.Add(dsNewRow)
            funcs.updateRecord(sql, table, ds)
        End If

        getApplicants()
        MessageBox.Show("Application successfully denied.", "Assassin", MessageBoxButtons.OK)
        frmGuildManage.addText(applicant & " has been denied access to the guild.")
    End Sub

    Public Sub getApplicants()
        '* * * * *
        '* This method gets all applicants for the current guild.
        '* * * * *

        clear()
        sql = "SELECT * FROM Applications WHERE Guild=" & currGuild.id
        table = "Applications"

        ds = funcs.fillDS(sql, table)

        If ds.Tables("Applications").Rows.Count > 0 Then
            For i As Integer = 0 To ds.Tables("Applications").Rows.Count - 1
                lstApplications.Items.Add(ds.Tables("Applications").Rows(i).Item("Username").ToString)
            Next
        End If
    End Sub


    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        '* * * * *
        '* This method closes the form.
        '* * * * *

        Me.Close()
    End Sub

    Private Sub btnConfirm_Click(sender As System.Object, e As System.EventArgs) Handles btnConfirm.Click
        '* * * * *
        '* This method confirms an applicant.
        '* * * * *

        confirm()
    End Sub

    Private Sub btnDeny_Click(sender As System.Object, e As System.EventArgs) Handles btnDeny.Click
        '* * * * *
        '* This method denies an applicant.
        '* * * * *

        deny()
    End Sub

    Private Sub lstApplications_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstApplications.SelectedIndexChanged
        '* * * * *
        '* This method handles the selected index changing on the lstApplications ListBox.
        '* * * * *

        If lstApplications.SelectedIndex >= 0 Then
            applicant = lstApplications.SelectedItem.ToString   'save selected applicant name
            btnConfirm.Enabled = True
            btnDeny.Enabled = True
        Else
            btnConfirm.Enabled = False
            btnDeny.Enabled = False
        End If
    End Sub

    Private Sub frmGuildManageApplications_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        '* * * * *
        '* This method handles closing the form.
        '* * * * *

        frmGuildManage.Show()
    End Sub
End Class