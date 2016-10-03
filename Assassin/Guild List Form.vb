' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 05/25/2012
' Filename        : Guild List Form.vb
' Description     : This form contains the list of guilds.

Option Strict On
Option Explicit On

Public Class frmGuildList
    Dim funcs As New Functions                  'new Functions instance
    Public currUser As New User                 'current user
    Dim sql As String                           'SQL query
    Dim table As String                         'table name
    Dim ds As New DataSet                       'DataSet
    Dim nl As String = ControlChars.NewLine     'new line
    Dim blnGuild As Boolean = False             'go to guild?
    Dim currGuild As New Guild                  'current guild

    Private Function hasApplied() As Boolean
        '* * * * *
        '* This function checks whether the user has applied to the selected guild.
        '* * * * *

        sql = "SELECT * FROM Applications WHERE Guild=" & currGuild.id & " AND Username='" & currUser.name & "'"
        table = "Applications"
        ds.Clear()
        ds = funcs.fillDS(sql, table)

        If ds.Tables("Applications").Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function isMember() As Boolean
        '* * * * *
        '* This function determines if the currUser is a member of the selected guild.
        '* * * * *

        sql = "SELECT * FROM Guild" & currGuild.id & "Members WHERE Username='" & currUser.name & "'"
        table = "Members"
        ds.Clear()
        ds = funcs.fillDS(sql, table)

        If ds.Tables("Members").Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function


    Public Sub addText(ByVal newText As String)
        '* * * * *
        '* This method adds text to the Textbox.
        '* * * * *

        txtGuilds.Text.Contains(nl + nl)
        Dim currText As String = txtGuilds.Text
        txtGuilds.Clear()

        txtGuilds.Text = newText & nl & nl & currText
        txtGuilds.Select(0, 0)
        txtGuilds.ScrollToCaret()
    End Sub

    Public Sub display()
        '* * * * *
        '* This method displays information about the selected guild.
        '* * * * *

        If lstGuilds.SelectedIndex > -1 Then
            Dim guild As Integer = lstGuilds.SelectedIndex + 1

            sql = "SELECT * FROM Guilds WHERE ID=" & guild & ""
            table = "Guilds"
            currGuild = funcs.getGuild(guild)

            lblFee.Text = ""
            lblGoldOnHand.Text = currUser.goldOnHand.ToString("N0")

            If currGuild.master = "Computer" Then
                Select Case currGuild.id
                    Case 1
                        lblGuildmaster.Text = "The Master"
                    Case 2
                        lblGuildmaster.Text = "Rathskeller"
                    Case Else
                        lblGuildmaster.Text = currGuild.name & " Master"
                End Select
            Else
                lblGuildmaster.Text = currGuild.master.ToString
            End If

            lblFee.Text = currGuild.fee.ToString("N0")
            lblGuildGold.Text = currGuild.gold.ToString("N0")
            lblHench1.Text = currGuild.hench1.ToString("N0")
            lblHench2.Text = currGuild.hench2.ToString("N0")
            lblHench3.Text = currGuild.hench3.ToString("N0")
            lblHench4.Text = currGuild.hench4.ToString("N0")
            lblHench5.Text = currGuild.hench5.ToString("N0")

            If isMember() Then              'if currUser is a member of selected guild
                btnEnter.Enabled = True
                btnApply.Enabled = False
            Else                            'if currUser isn't a member
                If hasApplied() Then
                    btnEnter.Enabled = False
                    'user has already applied
                    btnApply.Enabled = False
                Else                                                'can potentially apply
                    btnEnter.Enabled = False
                    If guild = 1 AndAlso currUser.level > 5 Then    'if guild is beginner's guild and greater than level 5
                        btnApply.Enabled = False
                    ElseIf currUser.goldOnHand < currGuild.fee Then 'if user doesn't have enough gold
                        btnApply.Enabled = False
                        lblFee.Text = currGuild.fee.ToString("N0")
                    Else
                        btnApply.Enabled = True
                        lblFee.Text = currGuild.fee.ToString("N0")
                    End If
                End If
            End If
        Else    'should never happen
            MessageBox.Show("Please select a guild.", "Assassin", MessageBoxButtons.OK)
        End If
    End Sub

    Public Sub populate()
        '* * * * *
        '* This method populates the ListBox with all the guilds' names)
        '* * * * *

        sql = "SELECT ID,GuildName FROM Guilds ORDER BY ID Asc"
        table = "Guilds"

        ds.Clear()
        ds = funcs.fillDS(sql, table)

        For i As Integer = 0 To ds.Tables("Guilds").Rows.Count - 1
            lstGuilds.Items.Add(ds.Tables("Guilds").Rows(i).Item("GuildName").ToString)
        Next
    End Sub


    Private Sub lstGuilds_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstGuilds.SelectedIndexChanged
        '* * * * *
        '* This method handles the selected ListBox item.
        '* * * * *

        display()
    End Sub


    Private Sub btnApply_Click(sender As System.Object, e As System.EventArgs) Handles btnApply.Click
        '* * * * *
        '* This method applies the currUser to the selected guild.
        '* * * * *

        Dim dlg As DialogResult
        dlg = MessageBox.Show("Are you sure you want to apply for this guild? It will cost " & currGuild.fee & " gold.", "Assassin", MessageBoxButtons.YesNo)

        If dlg = DialogResult.Yes Then  'if applying

            sql = "SELECT Guildmaster FROM Guilds WHERE ID=" & currGuild.id & ""
            table = "Guild"
            ds.Clear()
            ds = funcs.fillDS(sql, table)
            Dim dsNewRow As DataRow
            If ds.Tables("Guild").Rows(0).Item("Guildmaster").ToString = "Computer" Then    'if guildmaster is Computer, always accept
                sql = "SELECT * FROM Guild" & currGuild.id & "Members WHERE Username='" & currUser.name & "'"
                table = "Guild"

                ds.Clear()
                ds = funcs.fillDS(sql, table)

                dsNewRow = ds.Tables("Guild").NewRow()          'create new row
                dsNewRow.Item("Username") = currUser.name

                ds.Tables("Guild").Rows.Add(dsNewRow)           'add new row to DataSet
                funcs.updateRecord(sql, table, ds)              'update DataSet

                addText("You paid " & currGuild.fee & " gold to join the " & currGuild.name & " guild, and have been accepted!")
            Else                                                                            'submit new application
                sql = "SELECT * FROM Applications"
                table = "Applications"

                ds.Clear()
                ds = funcs.fillDS(sql, table)

                dsNewRow = ds.Tables("Applications").NewRow()   'create new row
                dsNewRow.Item("Guild") = currGuild.id
                dsNewRow.Item("Username") = currUser.name

                ds.Tables("Applications").Rows.Add(dsNewRow)    'add new row to Dataset
                funcs.updateRecord(sql, table, ds)              'update DataSet

                addText("You paid " & currGuild.fee & " gold and applied for the " & currGuild.name & " guild.")
            End If

            btnApply.Enabled = False
            currUser.goldOnHand -= currGuild.fee    'subtract gold from currUser
            currGuild.gold += currGuild.fee         'add gold to currGuild
            funcs.saveGuild(currGuild)              'save currGuild
            funcs.save(currUser)                    'save currUser

            display()
        End If
    End Sub

    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        '* * * * *
        '* This method closes the form on clicking the Back button.
        '* * * * *

        Me.Close()
    End Sub

    Private Sub btnEnter_Click(sender As System.Object, e As System.EventArgs) Handles btnEnter.Click
        '* * * * *
        '* This method enters the currently selected guild.
        '* * * * *

        blnGuild = True
        Me.Close()
    End Sub


    Private Sub frmGuildList_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        '* * * * *
        '* On loading the form, populate the ListBox.
        '* * * * *

        populate()
    End Sub

    Private Sub frmGuildList_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        '* * * * *
        '* This method handles the form closing.
        '* * * * *

        If blnGuild = False Then    'return to Game form
            frmGame.Show()
            frmGame.currUser = currUser
            If frmGame.txtGame.TextLength > 0 Then
                frmGame.addText(txtGuilds.Text)
            Else
                frmGame.Text = txtGuilds.Text
            End If
        Else                        'enter Guild
            frmGuild.Show()
            frmGuild.currGuild = currGuild
            frmGuild.currUser = currUser
            frmGuild.txtGuild.Text = txtGuilds.Text
            frmGuild.loadGuild()
        End If
    End Sub
End Class