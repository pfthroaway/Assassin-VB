' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 10/11/2012
' Filename        : Guild Options Form.vb
' Description     : This form allows a guildmaster to manage their guild.

Option Strict On
Option Explicit On

Public Class frmGuildOptions
    Dim funcs As New Functions
    Public currUser As New User
    Public currGuild As New Guild
    Dim sql As String
    Dim table As String
    Dim ds As New DataSet
    Dim nl As String = ControlChars.NewLine
    Dim oldName As String
    Dim oldMaster As String
    Dim oldFee As Integer
    Dim blnMasterChanged As Boolean

    Private Sub addText(ByVal newText As String)
        '* * * * *
        '* This method adds text to the Textbox.
        '* * * * *

        Dim currText As String = txtOptions.Text
        txtOptions.Clear()

        txtOptions.Text = newText & nl & nl & currText
        txtOptions.Select(0, 0)
        txtOptions.ScrollToCaret()
    End Sub

    Private Sub disable()
        '* * * * *
        '* This method disables everything on the form.
        '* * * * *

        txtName.Enabled = False
        txtEntranceFee.Enabled = False
        cmbGuildmaster.Enabled = False
        btnSave.Enabled = False
    End Sub

    Private Sub display()
        '* * * * *
        '* This method displays options.
        '* * * * *

        txtName.Text = currGuild.name
        cmbGuildmaster.SelectedItem = currGuild.master
        txtEntranceFee.Text = currGuild.fee.ToString
    End Sub

    Private Sub getMembers()
        '* * * * *
        '* This method gets the members of a guild.
        '* * * * *

        cmbGuildmaster.Items.Clear()
        cmbGuildmaster.Items.Clear()
        cmbGuildmaster.Items.Add("Computer")

        sql = "SELECT * FROM Guild" & currGuild.id & "Members"
        table = "Members"

        ds = funcs.fillDS(sql, table)

        For i As Integer = 0 To ds.Tables("Members").Rows.Count - 1
            cmbGuildmaster.Items.Add(ds.Tables("Members").Rows(i).Item("Username").ToString)
        Next

        cmbGuildmaster.SelectedItem = currGuild.master
    End Sub

    Public Sub loadOptions()
        '* * * * *
        '* This method loads the options.
        '* * * * *

        oldName = currGuild.name
        oldMaster = currGuild.master
        oldFee = currGuild.fee

        display()
        getMembers()
    End Sub



    Private Sub txtEntranceFee_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtEntranceFee.KeyPress
        '* * * * *
        '* This method handles what buttons can be pressed in this TextBox.
        '* * * * *

        If Char.IsDigit(e.KeyChar) OrElse e.KeyChar Like Chr(8) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtName_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtName.KeyPress
        '* * * * *
        '* This method handles what buttons can be pressed in this TextBox.
        '* * * * *

        If Char.IsLetter(e.KeyChar) OrElse e.KeyChar Like " " OrElse e.KeyChar Like "'" OrElse e.KeyChar Like Chr(8) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        '* * * * *
        '* This method closes the form on clicking the Exit button.
        '* * * * *

        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        '* * * * *
        '* This method saves the guild.
        '* * * * *

        currGuild.name = txtName.Text
        currGuild.master = cmbGuildmaster.SelectedItem.ToString
        Integer.TryParse(txtEntranceFee.Text, currGuild.fee)

        funcs.saveGuild(currGuild)

        If currGuild.name <> oldName Then
            addText("You change the name of the guild to " & currGuild.name & ".")
        End If

        If currGuild.fee <> oldFee Then
            addText("You change the guild fee to " & currGuild.fee.ToString & ".")
        End If

        If currGuild.master <> oldMaster Then
            disable()
            addText("You transfer guildmastership to " & currGuild.master & ".")
            blnMasterChanged = True
        End If

        oldName = currGuild.name
        oldMaster = currGuild.master
        oldFee = currGuild.fee
        display()

        MessageBox.Show("Save successful.", "Assassin", MessageBoxButtons.OK)
    End Sub

    Private Sub frmGuildOptions_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        '* * * * *
        '* This method handles the form closing.
        '* * * * *

        frmGuildManage.Show()
        frmGuildManage.currGuild = currGuild
        frmGuildManage.addText(txtOptions.Text)
        If blnMasterChanged = True Then
            frmGuildManage.disable()
        End If
    End Sub
End Class