' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 05/25/2012
' Filename        : Guild Form.vb
' Description     : This form contains the guild information

Option Strict On
Option Explicit On

Public Class frmGuild
    Dim funcs As New Functions              'new Functions instance
    Public currUser As New User             'current user
    Dim ds As New DataSet                   'DataSet
    Dim sql As String                       'SQL query
    Dim table As String                     'table name
    Dim nl As String = ControlChars.NewLine 'new line
    Public currGuild As New Guild           'current guild

    Private Function levelOK() As Boolean
        '* * * * *
        '* This method checks whether the character is too high to be in Guild 1.
        '* * * * *

        If currGuild.id = 1 AndAlso currUser.level > 5 Then
            disableButtons()
            addText("An invisible wall blocks you as you attempt to enter the guild. The guildmaster looms in the doorway." & nl & _
                Chr(34) & "You are now too experienced to belong to this guild. Good luck to you in the future." & Chr(34) & nl & _
                "You are pushed back to the streets.")
            leaveGuild()
            Return False
        Else
            addText("You enter " & lblGuildName.Text & ".")
            Return True
        End If
    End Function


    Public Sub addText(ByVal newText As String)
        '* * * * *
        '* This method adds text to the Textbox.
        '* * * * *

        Dim currText As String = txtGuild.Text
        txtGuild.Clear()

        txtGuild.Text = newText & nl & nl & currText
        txtGuild.Select(0, 0)
        txtGuild.ScrollToCaret()
    End Sub

    Private Sub checkLeader()
        '* * * * *
        '* This method checks to see if the currUser is the Guildmaster.
        '* * * * *

        If currUser.name = currGuild.master Then
            btnChallenge.Enabled = False
            btnManage.Enabled = True
        Else
            If currGuild.id <> 1 Then
                btnChallenge.Enabled = True
            End If
            btnManage.Enabled = False
        End If
    End Sub

    Private Sub disableButtons()
        '* * * * *
        '* This method disables all the buttons on the form.
        '* * * * *

        btnChallenge.Enabled = False
        btnBar.Enabled = False
        btnDonate.Enabled = False
        btnHire.Enabled = False
        btnJobs.Enabled = False
        btnManage.Enabled = False
        btnMembers.Enabled = False
        btnQuit.Enabled = False
        btnRaid.Enabled = False
        btnSleep.Enabled = False
        btnTransfer.Enabled = False
    End Sub

    Private Sub display()
        '* * * * *
        '* This method displays the guild name.
        '* * * * *

        lblGuildName.Text = currGuild.name
    End Sub

    Private Sub leaveGuild()
        '* * * * *
        '* This method makes a user leave the guild.
        '* * * * *

        sql = "SELECT * FROM Guild" & currGuild.id & "Members WHERE Username='" & currUser.name & "'"
        table = "Members"
        ds = funcs.fillDS(sql, table)
        funcs.deleteRecord(sql, table, ds)
        disableButtons()
    End Sub

    Public Sub loadGuild()
        '* * * * *
        '* This method loads important information when the form loads.
        '* * * * *

        display()
        If levelOK() Then checkLeader()
    End Sub


    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        '* * * * *
        '* This method closes the form on clicking the Back button.
        '* * * * *

        Me.Close()
    End Sub

    Private Sub btnBar_Click(sender As System.Object, e As System.EventArgs) Handles btnBar.Click
        '* * * * *
        '* This method displays the Bar form on clicking the Bar button.
        '* * * * *

        frmBar.Show()
        frmBar.loc = "Guild"
        frmBar.currUser = currUser
        frmBar.displayPurchases()
        Me.Hide()
    End Sub

    Private Sub btnChallenge_Click(sender As System.Object, e As System.EventArgs) Handles btnChallenge.Click
        '* * * * *
        '* This method handles clicking the Challenge button.
        '* * * * *

        addText("This feature is currently unavailable.")
    End Sub

    Private Sub btnDonate_Click(sender As System.Object, e As System.EventArgs) Handles btnDonate.Click
        '* * * * *
        '* This method lets you donate to the guild.
        '* * * * *

        frmGuildDonate.Show()
        frmGuildDonate.currUser = currUser
        frmGuildDonate.currGuild = currGuild
        frmGuildDonate.loadDonate()
        Me.Hide()
    End Sub

    Private Sub btnHire_Click(sender As System.Object, e As System.EventArgs) Handles btnHire.Click
        '* * * * *
        '* This method handles clicking the Hire button.
        '* * * * *

        frmHireHenchmen.Show()
        frmHireHenchmen.currUser = currUser
        frmHireHenchmen.setUser()
        Me.Hide()
    End Sub

    Private Sub btnJobs_Click(sender As System.Object, e As System.EventArgs) Handles btnJobs.Click
        '* * * * *
        '* This method handles clicking the Jobs button.
        '* * * * *

        frmJobs.Show()
        frmJobs.currUser = currUser
        frmJobs.loadJobs()
        Me.Hide()
    End Sub

    Private Sub btnManage_Click(sender As System.Object, e As System.EventArgs) Handles btnManage.Click
        '* * * * *
        '* This method handles clicking the Manage button.
        '* * * * *

        frmGuildManage.Show()
        frmGuildManage.currUser = currUser
        frmGuildManage.currGuild = currGuild
        Me.Hide()
    End Sub

    Private Sub btnMembers_Click(sender As System.Object, e As System.EventArgs) Handles btnMembers.Click
        '* * * * *
        '* This method handles clicking the Members button.
        '* * * * *

        frmMembers.Show()
        frmMembers.currUser = currUser
        frmMembers.currGuild = currGuild
        frmMembers.loc = "Guild"
        frmMembers.loadMembers()
        Me.Hide()
    End Sub

    Private Sub btnRaid_Click(sender As System.Object, e As System.EventArgs) Handles btnRaid.Click
        '* * * * *
        '*  This button click displays the Raid form.
        '* * * * *

        frmRaid.Show()
        frmRaid.currUser = currUser
        frmRaid.currGuild = currGuild
        frmRaid.loadRaid()
        Me.Hide()

    End Sub

    Private Sub btnQuit_Click(sender As System.Object, e As System.EventArgs) Handles btnQuit.Click
        '* * * * *
        '* This method verifies if a user wants to quit the guild.
        '* * * * *

        Dim dlg As DialogResult
        dlg = MessageBox.Show("Are you sure you want to quit the guild?", "Assassin", MessageBoxButtons.YesNo)
        If dlg = DialogResult.Yes Then
            leaveGuild()
            addText("You have decided to quit the guild.")
        End If
    End Sub

    Private Sub btnSleep_Click(sender As System.Object, e As System.EventArgs) Handles btnSleep.Click
        '* * * * *
        '* This method lets a user sleep in the guild.
        '* * * * *

        currUser.currLoc = "Guild"
        funcs.save(currUser)
        disableButtons()
        frmGame.disableButtons()
        addText("You find an empty room and sleep.")
    End Sub

    Private Sub btnTransfer_Click(sender As System.Object, e As System.EventArgs) Handles btnTransfer.Click
        '* * * * *
        '* This method displays the Transfer Items form.
        '* * * * *

        addText("This feature is currently unavailable.")
    End Sub


    Private Sub frmGuild_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        '* * * * *
        '* This method handles the form closing.
        '* * * * *

        frmGame.Show()
        frmGame.currUser = currUser
        frmGame.display()
        frmGame.addText(txtGuild.Text)
        funcs.save(currUser)
    End Sub
End Class