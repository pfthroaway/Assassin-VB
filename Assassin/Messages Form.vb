' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 05/25/2012
' Filename        : Messages Form.vb
' Description     : This form allows users to send messages to one another.

Option Strict On
Option Explicit On

Public Class frmMessages
    Dim funcs As New Functions  'new Functions instance
    Public currUser As New User 'current user
    Dim ds As New DataSet       'Dataset
    Dim sql As String           'SQL query
    Dim table As String         'table name
    Dim sql1 As String          'secondary SQL query
    Dim ds1 As New DataSet      'secondary DataSet
    Dim table1 As String        'secondary table
    Dim index As Integer        'index in table
    Dim message As String       'message
    Dim userFrom As String      'message sender
    Public loc As String        'location to return to
    Dim blnNew As Boolean       'new message?

    Private Sub clear()
        '* * * * *
        '* This method clears all the information on the form.
        '* * * * *

        btnNext.Enabled = False
        btnPrev.Enabled = False
        btnDelete.Enabled = False
        btnReply.Enabled = False
        lblCount.Text = ""
        txtMessage.Clear()
        cmbNames.Items.Clear()
        cmbNames.Enabled = False
        txtDate.Clear()
    End Sub

    Private Sub display()
        '* * * * *
        '* This method displays the message.
        '* * * * *

        If ds.Tables("Messages").Rows.Count > 0 Then
            userFrom = ds.Tables("Messages").Rows(index).Item("UserFrom").ToString

            cmbNames.Items.Clear()
            cmbNames.Items.Add(userFrom)
            cmbNames.SelectedItem = userFrom

            txtDate.Text = ds.Tables("Messages").Rows(index).Item("DateSent").ToString
            message = ds.Tables("Messages").Rows(index).Item("Message").ToString

            txtMessage.Text = message
            lblCount.Text = (index + 1) & " / " & ds.Tables("Messages").Rows.Count
            btnDelete.Enabled = True
            If ds.Tables("Messages").Rows.Count = 1 Then
                btnNext.Enabled = False
                btnPrev.Enabled = False
            Else
                btnNext.Enabled = True
                btnPrev.Enabled = True
            End If

            If CBool(ds.Tables("Messages").Rows(index).Item("GuildMessage").ToString) = True Then
                btnReply.Enabled = False
            Else
                btnReply.Enabled = True
            End If
        Else
            clear()
            btnNew.Enabled = True
            txtMessage.Text = "You have no messages."
        End If
    End Sub

    Public Sub loadMessages()
        '* * * * *
        '* This method loads messages for the current user.
        '* * * * *

        sql = "SELECT * FROM Messages WHERE UserTo='" & currUser.name & "'"
        table = "Messages"

        ds = funcs.fillDS(sql, table)

        If ds.Tables("Messages").Rows.Count > 0 Then
            index = 0
            display()
        Else
            clear()
            txtMessage.Text = "You have no messages."
        End If
    End Sub

    Private Sub loadNames()
        '* * * * *
        '* This method loads names into the cmbNames ComboBox.
        '* * * * *

        cmbNames.Items.Clear()

        sql1 = "SELECT Username FROM Users ORDER BY ID Asc"
        table1 = "Users"
        ds1 = funcs.fillDS(sql1, table1)

        For i As Integer = 0 To ds1.Tables("Users").Rows.Count - 1
            cmbNames.Items.Add(ds1.Tables("Users").Rows(i).Item("Username").ToString)
        Next

        cmbNames.Items.Remove(currUser.name)
    End Sub

    Public Sub startSend()
        '* * * * *
        '* This method starts the form being able to send messages.
        '* * * * *

        loadMessages()
        btnReply.Enabled = True
        btnDelete.Enabled = True
        btnReply.Text = "&Send"     'change text to Send
        btnDelete.Text = "&Clear"   'change text to Clear
        lblFrom.Text = "To:"        'change text to To:
        lblCount.Text = ""          'Clear lblCount
        txtMessage.Clear()
        txtDate.Clear()

        loadNames()
        cmbNames.Enabled = True
        txtMessage.ReadOnly = False 'allow Textbox to be edited
        btnNext.Enabled = False     'disable Next button
        btnPrev.Enabled = False     'disable Prev button
        btnBack.Enabled = False     'disable Back button
    End Sub


    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        '* * * * *
        '* This method closes the form on clicking the Back button.
        '* * * * *

        Me.Close()
    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        '* * * * *
        '* This method closes the form on clicking the Back button.
        '* * * * *

        If btnDelete.Text = "&Delete" Then  'delete
            sql1 = "SELECT * FROM Messages WHERE UserTo='" & currUser.name & "' AND UserFrom='" & userFrom.Replace("'", "''") & "' AND Message='" & message.Replace("'", "''") & "'"
            table1 = "Messages"
            ds1 = funcs.fillDS(sql1, table1)

            funcs.deleteRecord(sql1, table1, ds1)
            MessageBox.Show("Message successfully deleted.", "Assassin", MessageBoxButtons.OK)
            loadMessages()
        Else                                'Clear
            btnReply.Text = "&Reply"    'change text to Send
            btnDelete.Text = "&Delete"  'change text to Clear
            lblFrom.Text = "From:"      'change text to From:

            btnNew.Enabled = True
            cmbNames.Enabled = False
            txtMessage.ReadOnly = True  'allow Textbox to be edited
            btnNext.Enabled = True      'disable Next button
            btnPrev.Enabled = True      'disable Prev button
            btnBack.Enabled = True      'disable Back button
            display()
        End If
    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        '* * * * *
        '* This method allows a user to create a new message.
        '* * * * *

        btnNew.Enabled = False
        startSend()
    End Sub

    Private Sub btnNext_Click(sender As System.Object, e As System.EventArgs) Handles btnNext.Click
        '* * * * *
        '* This method closes the form on clicking the Back button.
        '* * * * *

        If index = ds.Tables("Messages").Rows.Count - 1 Then
            index = 0
        Else
            index += 1
        End If

        display()
    End Sub

    Private Sub btnPrev_Click(sender As System.Object, e As System.EventArgs) Handles btnPrev.Click
        '* * * * *
        '* This method closes the form on clicking the Back button.
        '* * * * *

        If index = 0 Then
            index = ds.Tables("Messages").Rows.Count - 1
        Else
            index -= 1
        End If

        display()
    End Sub

    Private Sub btnReply_Click(sender As System.Object, e As System.EventArgs) Handles btnReply.Click
        '* * * * *
        '* This method closes the form on clicking the Back button.
        '* * * * *

        If btnReply.Text = "&Reply" Then    'reply
            btnReply.Text = "&Send"         'change text to Send
            btnDelete.Text = "&Clear"       'change text to Clear
            lblFrom.Text = "To:"            'change text to To:
            lblCount.Text = ""              'Clear lblCount
            txtDate.Clear()                 'clear Date TextBox
            txtMessage.Clear()              'clear Message TextBox

            txtMessage.ReadOnly = False 'allow Textbox to be edited
            btnNext.Enabled = False     'disable Next button
            btnPrev.Enabled = False     'disable Prev button
            btnBack.Enabled = False     'disable Back button
            btnDelete.Enabled = True    'enable Delete button
            btnNew.Enabled = False      'disable New button
        Else                                'send
            If txtMessage.TextLength > 0 Then
                sql1 = "SELECT * FROM Users WHERE Username='" & cmbNames.SelectedItem.ToString & "'"
                table1 = "Users"
                ds1 = funcs.fillDS(sql1, table1)

                If ds1.Tables("Users").Rows.Count > 0 Then   'if user exists
                    sql1 = "SELECT * FROM Messages"
                    table1 = "Messages"
                    ds1 = funcs.fillDS(sql1, table1)

                    Dim dsNewRow As DataRow
                    dsNewRow = ds1.Tables("Messages").NewRow()
                    dsNewRow.Item("UserTo") = cmbNames.SelectedItem.ToString
                    dsNewRow.Item("UserFrom") = currUser.name
                    dsNewRow.Item("Message") = txtMessage.Text
                    dsNewRow.Item("DateSent") = Now
                    ds1.Tables("Messages").Rows.Add(dsNewRow)
                    funcs.updateRecord(sql1, table1, ds1)

                    btnReply.Text = "&Reply"    'change text to Send
                    btnDelete.Text = "&Delete"  'change text to Clear
                    lblFrom.Text = "From:"      'change text to From:

                    btnNew.Enabled = True       'enable btnNew
                    cmbNames.Enabled = False    'enable cmbNames
                    txtMessage.ReadOnly = True  'allow Textbox to be edited
                    btnNext.Enabled = True      'disable Next button
                    btnPrev.Enabled = True      'disable Prev button
                    btnBack.Enabled = True      'disable Back button
                    btnNew.Enabled = True       'enable New button

                    MessageBox.Show("Message successfully sent.", "Assassin", MessageBoxButtons.OK)
                    display()
                Else
                    MessageBox.Show("Please enter a valid username to be the recipient of the message.", "Assassin", MessageBoxButtons.OK)
                End If
            Else
                MessageBox.Show("Please ensure you have filled out all fields correctly.", "Assassin", MessageBoxButtons.OK)
            End If
        End If
    End Sub


    Private Sub frmMessages_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        '* * * * *
        '* This method handles closing the form.
        '* * * * *

        If loc = "Streets" Then
            frmGame.Show()
        ElseIf loc = "Members" Then
            frmMembers.Show()
        End If
    End Sub
End Class