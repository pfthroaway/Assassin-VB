' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 09/06/2012
' Filename        : Admin Guild Form.vb
' Description     : This form contains all Guild administrative functions.

Option Strict On
Option Explicit On

Public Class frmAdminGuilds
    Dim funcs As New Functions  'new Functions instance
    Dim currGuild As New Guild  'currently selected guild
    Dim ds As New DataSet       'DataSet
    Dim sql As String           'SQL query
    Dim table As String         'table name

    Private Sub clear()
        '* * * * *
        '* This method clears all information on the form.
        '* * * * *

        disable()
        lstGuilds.Enabled = True
        lstGuilds.Items.Clear()
        lstGuilds.ClearSelected()
        btnAddMember.Text = "&Add Member"
        txtName.Clear()
        cmbGuildmaster.SelectedIndex = 0
        txtEntranceFee.Clear()
        txtGuildGold.Clear()
        txtHench1.Clear()
        txtHench2.Clear()
        txtHench3.Clear()
        txtHench4.Clear()
        txtHench5.Clear()

        lstMembers.Items.Clear()
        lstMembers.ClearSelected()
    End Sub

    Private Sub disable()
        '* * * * *
        '* This method disables everything on the form.
        '* * * * *

        txtName.Enabled = False
        cmbGuildmaster.Enabled = False
        txtEntranceFee.Enabled = False
        txtGuildGold.Enabled = False
        txtHench1.Enabled = False
        txtHench2.Enabled = False
        txtHench3.Enabled = False
        txtHench4.Enabled = False
        txtHench5.Enabled = False

        lstMembers.Enabled = False
        btnAddMember.Enabled = False
        btnClear.Enabled = False
        btnExpel.Enabled = False
        btnSave.Enabled = False
    End Sub

    Private Sub display()
        '* * * * *
        '* This method displays all information about a guild.
        '* * * * *

        enable()
        txtName.Text = currGuild.name
        getMembers()
        txtEntranceFee.Text = currGuild.fee.ToString
        txtGuildGold.Text = currGuild.gold.ToString
        txtHench1.Text = currGuild.hench1.ToString
        txtHench2.Text = currGuild.hench2.ToString
        txtHench3.Text = currGuild.hench3.ToString
        txtHench4.Text = currGuild.hench4.ToString
        txtHench5.Text = currGuild.hench5.ToString
    End Sub

    Private Sub enable()
        '* * * * *
        '* This method enables everything on the form.
        '* * * * *

        lstGuilds.Enabled = True
        txtName.Enabled = True
        cmbGuildmaster.Enabled = True
        txtEntranceFee.Enabled = True
        txtGuildGold.Enabled = True
        txtHench1.Enabled = True
        txtHench2.Enabled = True
        txtHench3.Enabled = True
        txtHench4.Enabled = True
        txtHench5.Enabled = True

        lstMembers.Enabled = True
        btnAddMember.Enabled = True
        btnClear.Enabled = True
        btnSave.Enabled = True
    End Sub

    Private Sub getMembers()
        '* * * * *
        '* This method gets the members of a guild.
        '* * * * *

        cmbGuildmaster.Items.Clear()
        lstMembers.Items.Clear()
        lstMembers.ClearSelected()
        cmbGuildmaster.Items.Add("Computer")

        sql = "SELECT * FROM Guild" & currGuild.id & "Members"
        table = "Members"

        ds = funcs.fillDS(sql, table)

        For i As Integer = 0 To ds.Tables("Members").Rows.Count - 1
            Dim username As String = ds.Tables("Members").Rows(i).Item("Username").ToString
            If currGuild.id <> 1 Then cmbGuildmaster.Items.Add(username)
            lstMembers.Items.Add(username)
        Next

        cmbGuildmaster.SelectedItem = currGuild.master
    End Sub

    Private Sub loadGuilds()
        '* * * * *
        '* This method loads all the guilds and guild informations.
        '* * * * *

        clear()

        sql = "SELECT ID,GuildName FROM Guilds ORDER BY ID Asc"
        table = "Guilds"
        ds = funcs.fillDS(sql, table)

        For i As Integer = 0 To 4
            lstGuilds.Items.Add(ds.Tables("Guilds").Rows(i).Item("GuildName"))
        Next
    End Sub

    Private Sub save()
        '* * * * *
        '* This method saves the guild.
        '* * * * *

        currGuild.name = txtName.Text
        currGuild.master = cmbGuildmaster.SelectedItem.ToString
        Integer.TryParse(txtEntranceFee.Text, currGuild.fee)
        Integer.TryParse(txtGuildGold.Text, currGuild.gold)
        Integer.TryParse(txtHench1.Text, currGuild.hench1)
        Integer.TryParse(txtHench2.Text, currGuild.hench2)
        Integer.TryParse(txtHench3.Text, currGuild.hench3)
        Integer.TryParse(txtHench4.Text, currGuild.hench4)
        Integer.TryParse(txtHench5.Text, currGuild.hench5)

        funcs.saveGuild(currGuild)
        MessageBox.Show("Guild saved successfully.", "Assassin", MessageBoxButtons.OK)
        loadGuilds()
    End Sub


    Private Sub lstGuilds_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstGuilds.SelectedIndexChanged
        '* * * * *
        '* This method handles selecting a guild.
        '* * * * *

        currGuild = funcs.getGuild(lstGuilds.SelectedIndex + 1)
        display()
        btnAddMember.Text = "&Add Member"
    End Sub


    Private Sub lstMembers_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstMembers.SelectedIndexChanged
        '* * * * *
        '* This method handles the selected index of lstMembers being changed.
        '* * * * *

        If lstMembers.SelectedIndex >= 0 AndAlso btnAddMember.Text = "&Add Member" Then
            btnExpel.Enabled = True
        ElseIf lstMembers.SelectedIndex >= 0 AndAlso btnAddMember.Text = "&Add" Then
            btnAddMember.Enabled = True
            btnExpel.Enabled = False
        Else
            btnExpel.Enabled = False
        End If
    End Sub

    Private Sub numChars_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtEntranceFee.KeyPress, txtGuildGold.KeyPress, _
            txtHench1.KeyPress, txtHench2.KeyPress, txtHench3.KeyPress, txtHench4.KeyPress, txtHench5.KeyPress
        '* * * * *
        '* This method prevents anything but numbers to be entered in several fields.
        '* * * * *

        If Char.IsDigit(e.KeyChar) OrElse e.KeyChar Like (Chr(8)) Then 'numbers, backspace
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtName_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtName.KeyPress
        '* * * * *
        '* This method prevents special characters in the txtName field.
        '* * * * *

        'letters, numbers, backspace, space, apostrophe
        If Char.IsLetterOrDigit(e.KeyChar) OrElse e.KeyChar Like Chr(8) OrElse e.KeyChar Like " " OrElse e.KeyChar Like "'" Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtEntranceFee_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtEntranceFee.TextChanged
        '* * * * *
        '* This method handles the text change in txtEntranceFee.
        '* * * * *

        If txtEntranceFee.TextLength > 0 Then
            If (CInt(txtEntranceFee.Text) > 1000) Then
                txtEntranceFee.Clear()
            End If
        End If
    End Sub




    Private Sub btnAddMember_Click(sender As System.Object, e As System.EventArgs) Handles btnAddMember.Click
        '* * * * *
        '* This method handles adding a new user
        '* * * * *

        If btnAddMember.Text <> "&Add" Then
            If btnAddMember.Text = "&Add Member" Then
                sql = "SELECT Username FROM Users WHERE Username NOT IN(SELECT Username FROM Guild" & currGuild.id & "Members)"
                table = "Members"

                ds = funcs.fillDS(sql, table)

                disable()
                lstGuilds.Enabled = False
                btnAddMember.Enabled = True
                btnAddMember.Text = "&Add"
                btnClear.Enabled = True
                lstMembers.Enabled = True
                lstMembers.Items.Clear()

                For i As Integer = 0 To ds.Tables("Members").Rows.Count - 1
                    lstMembers.Items.Add(ds.Tables("Members").Rows(i).Item("Username"))
                Next
                btnAddMember.Enabled = False
            End If
        Else
            If lstMembers.SelectedIndex >= 0 Then
                sql = "SELECT * FROM Guild" & currGuild.id & "Members"
                table = "Members"
                ds = funcs.fillDS(sql, table)

                Dim dsNewRow As DataRow
                dsNewRow = ds.Tables("Members").NewRow
                dsNewRow.Item("Username") = lstMembers.SelectedItem.ToString
                ds.Tables("Members").Rows.Add(dsNewRow)
                funcs.updateRecord(sql, table, ds)

                MessageBox.Show("Member successfully added.", "Assassin", MessageBoxButtons.OK)
                getMembers()
                enable()
                btnAddMember.Text = "&Add Member"
            Else
                MessageBox.Show("Please select a member to add to the guild.", "Assassin", MessageBoxButtons.OK)
            End If
        End If
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        '* * * * *
        '* This method clears all information on the form.
        '* * * * *

        If btnAddMember.Text = "&Add Member" Then
            loadGuilds()
        Else
            getMembers()
            enable()
            btnAddMember.Text = "&Add Member"
        End If
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        '* * * * *
        '* This method closes the form on clicking the Exit button.
        '* * * * *

        Me.Close()
    End Sub

    Private Sub btnExpel_Click(sender As System.Object, e As System.EventArgs) Handles btnExpel.Click
        '* * * * *
        '* This method expels a member from the guild.
        '* * * * *
        Dim dlg As DialogResult
        dlg = MessageBox.Show("Are you sure you want to expel this member?", "Assassin", MessageBoxButtons.YesNo)

        If dlg = Windows.Forms.DialogResult.Yes Then
            sql = "SELECT * FROM Guild" & currGuild.id & "Members WHERE Username='" & lstMembers.SelectedItem.ToString & "'"
            table = "Members"

            ds = funcs.fillDS(sql, table)
            funcs.deleteRecord(sql, table, ds)

            MessageBox.Show("Member successfully expelled.", "Assassin", MessageBoxButtons.OK)
            getMembers()
        End If
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        '* * * * *
        '* This method saves the currently selected guild.
        '* * * * *

        save()
    End Sub

    Private Sub frmAdminGuilds_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        '* * * * *
        '* This method handles loading the form.
        '* * * * *

        loadGuilds()
    End Sub

    Private Sub frmAdminGuilds_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        '* * * * *
        '* This method handles the form closing.
        '* * * * *

        frmAdmin.Show()
    End Sub
End Class