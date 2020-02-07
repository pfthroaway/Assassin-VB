' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 09/06/2012
' Filename        : Admin Guild Form.vb
' Description     : This form contains all Guild administrative functions.

Option Strict On
Option Explicit On

Namespace Forms.Admin

    Public Class FrmAdminGuilds
        'TODO Fix Admin Guild
    End Class

    '    Dim _currentGuild As New Guild  'currently selected guild

    '    Private Sub Clear()
    '        '* * * * *
    '        '* This method clears all information on the form.
    '        '* * * * *

    '        Disable()
    '        LstGuilds.Enabled = True
    '        LstGuilds.Items.Clear()
    '        LstGuilds.ClearSelected()
    '        BtnAddMember.Text = "&Add Member"
    '        TxtName.Clear()
    '        CmbGuildmaster.SelectedIndex = 0
    '        TxtEntranceFee.Clear()
    '        TxtGuildGold.Clear()
    '        TxtHenchmenLevel1.Clear()
    '        TxtHenchmenLevel2.Clear()
    '        TxtHenchmenLevel3.Clear()
    '        TxtHenchmenLevel4.Clear()
    '        TxtHenchmenLevel5.Clear()

    '        LstMembers.Items.Clear()
    '        LstMembers.ClearSelected()
    '    End Sub

    '    Private Sub Disable()
    '        '* * * * *
    '        '* This method disables everything on the form.
    '        '* * * * *

    '        TxtName.Enabled = False
    '        CmbGuildmaster.Enabled = False
    '        TxtEntranceFee.Enabled = False
    '        TxtGuildGold.Enabled = False
    '        TxtHenchmenLevel1.Enabled = False
    '        TxtHenchmenLevel2.Enabled = False
    '        TxtHenchmenLevel3.Enabled = False
    '        TxtHenchmenLevel4.Enabled = False
    '        TxtHenchmenLevel5.Enabled = False

    '        LstMembers.Enabled = False
    '        BtnAddMember.Enabled = False
    '        BtnClear.Enabled = False
    '        BtnExpel.Enabled = False
    '        BtnSave.Enabled = False
    '    End Sub

    '    Private Sub Display()
    '        '* * * * *
    '        '* This method displays all information about a guild.
    '        '* * * * *

    '        Enable()
    '        TxtName.Text = _currentGuild.Name
    '        GetMembers()
    '        TxtEntranceFee.Text = _currentGuild.Fee.ToString
    '        TxtGuildGold.Text = _currentGuild.Gold.ToString
    '        TxtHenchmenLevel1.Text = _currentGuild.HenchmenLevel1.ToString
    '        TxtHenchmenLevel2.Text = _currentGuild.HenchmenLevel2.ToString
    '        TxtHenchmenLevel3.Text = _currentGuild.HenchmenLevel3.ToString
    '        TxtHenchmenLevel4.Text = _currentGuild.HenchmenLevel4.ToString
    '        TxtHenchmenLevel5.Text = _currentGuild.HenchmenLevel5.ToString
    '    End Sub

    '    Private Sub Enable()
    '        '* * * * *
    '        '* This method enables everything on the form.
    '        '* * * * *

    '        LstGuilds.Enabled = True
    '        TxtName.Enabled = True
    '        CmbGuildmaster.Enabled = True
    '        TxtEntranceFee.Enabled = True
    '        TxtGuildGold.Enabled = True
    '        TxtHenchmenLevel1.Enabled = True
    '        TxtHenchmenLevel2.Enabled = True
    '        TxtHenchmenLevel3.Enabled = True
    '        TxtHenchmenLevel4.Enabled = True
    '        TxtHenchmenLevel5.Enabled = True

    '        LstMembers.Enabled = True
    '        BtnAddMember.Enabled = True
    '        BtnClear.Enabled = True
    '        BtnSave.Enabled = True
    '    End Sub

    '    Private Async Sub GetMembers()
    '        '* * * * *
    '        '* This method gets the members of a guild.
    '        '* * * * *

    '        CmbGuildmaster.Items.Clear()
    '        LstMembers.Items.Clear()
    '        LstMembers.ClearSelected()
    '        CmbGuildmaster.Items.Add("Computer")

    '        '_sql = "SELECT * FROM Guild" & _currentGuild.ID & "Members"
    '        '_table = "Members"

    '        '

    '        'For i As Integer = 0 To _ds.Tables(0).Rows.Count - 1
    '        '    Dim username As String = _ds.Tables(0).Rows(i).Item("Username").ToString
    '        '    If _currentGuild.ID <> 1 Then CmbGuildmaster.Items.Add(username)
    '        '    LstMembers.Items.Add(username)
    '        'Next

    '        'CmbGuildmaster.SelectedItem = _currentGuild.Master
    '    End Sub

    '    Private Async Sub LoadGuilds()
    '        '* * * * *
    '        '* This method loads all the guilds and guild informations.
    '        '* * * * *

    '        Clear()

    '        '_sql = "SELECT ID,GuildName FROM Guilds ORDER BY ID Asc"
    '        '_table = "Guilds"
    '        '

    '        'For i As Integer = 0 To 4
    '        '    LstGuilds.Items.Add(_ds.Tables(0).Rows(i).Item("GuildName"))
    '        'Next
    '    End Sub

    '    Private Sub Save()
    '        '* * * * *
    '        '* This method saves the guild.
    '        '* * * * *

    '        '_currentGuild.Name = TxtName.Text
    '        '_currentGuild.Master = CmbGuildmaster.SelectedItem.ToString
    '        'Integer.TryParse(txtEntranceFee.Text, _currentGuild.Fee)
    '        'Integer.TryParse(txtGuildGold.Text, _currentGuild.Gold)
    '        'Integer.TryParse(txtHenchmenLevel1.Text, _currentGuild.HenchmenLevel1)
    '        'Integer.TryParse(txtHenchmenLevel2.Text, _currentGuild.HenchmenLevel2)
    '        'Integer.TryParse(txtHenchmenLevel3.Text, _currentGuild.HenchmenLevel3)
    '        'Integer.TryParse(txtHenchmenLevel4.Text, _currentGuild.HenchmenLevel4)
    '        'Integer.TryParse(txtHenchmenLevel5.Text, _currentGuild.HenchmenLevel5)

    '        '.SaveGuild(_currentGuild)
    '        'MessageBox.Show("Guild saved successfully.", "Assassin", MessageBoxButtons.OK)
    '        'LoadGuilds()
    '    End Sub

    '    Private Async Sub LstGuilds_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstGuilds.SelectedIndexChanged
    '        '* * * * *
    '        '* This method handles selecting a guild.
    '        '* * * * *

    '        '_currentGuild = Await .GetGuild(LstGuilds.SelectedIndex + 1)
    '        'Display()
    '        'BtnAddMember.Text = "&Add Member"
    '    End Sub

    '    Private Sub LstMembers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstMembers.SelectedIndexChanged
    '        '* * * * *
    '        '* This method handles the selected index of LstMembers being changed.
    '        '* * * * *

    '        If LstMembers.SelectedIndex >= 0 AndAlso BtnAddMember.Text = "&Add Member" Then
    '            BtnExpel.Enabled = True
    '        ElseIf LstMembers.SelectedIndex >= 0 AndAlso BtnAddMember.Text = "&Add" Then
    '            BtnAddMember.Enabled = True
    '            BtnExpel.Enabled = False
    '        Else
    '            BtnExpel.Enabled = False
    '        End If
    '    End Sub

    '    Private Sub numChars_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtEntranceFee.KeyPress, TxtGuildGold.KeyPress,
    '                                                                                                         TxtHenchmenLevel1.KeyPress, TxtHenchmenLevel2.KeyPress, TxtHenchmenLevel3.KeyPress, TxtHenchmenLevel4.KeyPress, TxtHenchmenLevel5.KeyPress
    '        '* * * * *
    '        '* This method prevents anything but numbers to be entered in several fields.
    '        '* * * * *

    '        If Char.IsDigit(e.KeyChar) OrElse e.KeyChar Like (Chr(8)) Then 'numbers, backspace
    '            e.Handled = False
    '        Else
    '            e.Handled = True
    '        End If
    '    End Sub

    '    Private Sub TxtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtName.KeyPress
    '        '* * * * *
    '        '* This method prevents special characters in the TxtName field.
    '        '* * * * *

    '        'letters, numbers, backspace, space, apostrophe
    '        If Char.IsLetterOrDigit(e.KeyChar) OrElse e.KeyChar Like Chr(8) OrElse e.KeyChar Like " " OrElse e.KeyChar Like "'" Then
    '            e.Handled = False
    '        Else
    '            e.Handled = True
    '        End If
    '    End Sub

    '    Private Sub TxtEntranceFee_TextChanged(sender As Object, e As EventArgs) Handles TxtEntranceFee.TextChanged
    '        '* * * * *
    '        '* This method handles the text change in TxtEntranceFee.
    '        '* * * * *

    '        If TxtEntranceFee.TextLength > 0 Then
    '            If (CInt(txtEntranceFee.Text) > 1000) Then
    '                TxtEntranceFee.Clear()
    '            End If
    '        End If
    '    End Sub

    '    Private Async Sub BtnAddMember_Click(sender As Object, e As EventArgs) Handles BtnAddMember.Click
    '        '* * * * *
    '        '* This method handles adding a new user
    '        '* * * * *

    '        'If BtnAddMember.Text <> "&Add" Then
    '        '    If BtnAddMember.Text = "&Add Member" Then
    '        '        _sql = "SELECT Username FROM Users WHERE Username NOT IN(SELECT Username FROM Guild" & _currentGuild.ID & "Members)"
    '        '        _table = "Members"

    '        '

    '        '        Disable()
    '        '        LstGuilds.Enabled = False
    '        '        BtnAddMember.Enabled = True
    '        '        BtnAddMember.Text = "&Add"
    '        '        BtnClear.Enabled = True
    '        '        LstMembers.Enabled = True
    '        '        LstMembers.Items.Clear()

    '        '        For i As Integer = 0 To _ds.Tables(0).Rows.Count - 1
    '        '            LstMembers.Items.Add(_ds.Tables(0).Rows(i).Item("Username"))
    '        '        Next
    '        '        BtnAddMember.Enabled = False
    '        '    End If
    '        'Else
    '        '    If LstMembers.SelectedIndex >= 0 Then
    '        '        _sql = "SELECT * FROM Guild" & _currentGuild.ID & "Members"
    '        '        _table = "Members"
    '        '

    '        '        Dim dsNewRow As DataRow
    '        '        dsNewRow = _ds.Tables(0).NewRow
    '        '        dsNewRow.Item("Username") = LstMembers.SelectedItem.ToString
    '        '        _ds.Tables(0).Rows.Add(dsNewRow)
    '        '        .UpdateRecord(_sql, _table, _ds)

    '        '        MessageBox.Show("Member successfully added.", "Assassin", MessageBoxButtons.OK)
    '        '        GetMembers()
    '        '        Enable()
    '        '        BtnAddMember.Text = "&Add Member"
    '        '    Else
    '        '        MessageBox.Show("Please select a member to add to the guild.", "Assassin", MessageBoxButtons.OK)
    '        '    End If
    '        'End If
    '    End Sub

    '    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
    '        '* * * * *
    '        '* This method clears all information on the form.
    '        '* * * * *

    '        If BtnAddMember.Text = "&Add Member" Then
    '            LoadGuilds()
    '        Else
    '            GetMembers()
    '            Enable()
    '            BtnAddMember.Text = "&Add Member"
    '        End If
    '    End Sub

    '    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
    '        '* * * * *
    '        '* This method closes the form on clicking the Exit button.
    '        '* * * * *

    '        Me.Close()
    '    End Sub

    '    Private Async Sub BtnExpel_Click(sender As Object, e As EventArgs) Handles BtnExpel.Click
    '        ''* * * * *
    '        ''* This method expels a member from the guild.
    '        ''* * * * *
    '        'Dim dlg As DialogResult
    '        'dlg = MessageBox.Show("Are you sure you want to expel this member?", "Assassin", MessageBoxButtons.YesNo)

    '        'If dlg = DialogResult.Yes Then
    '        '    _sql = "SELECT * FROM Guild" & _currentGuild.ID & "Members WHERE Username='" & LstMembers.SelectedItem.ToString & "'"
    '        '    _table = "Members"

    '        '
    '        '    .DeleteRecord(_sql, _table, _ds)

    '        '    MessageBox.Show("Member successfully expelled.", "Assassin", MessageBoxButtons.OK)
    '        '    GetMembers()
    '        'End If
    '    End Sub

    '    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
    '        '* * * * *
    '        '* This method saves the currently selected guild.
    '        '* * * * *

    '        Save()
    '    End Sub

    '    Private Sub FrmAdminGuilds_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '        '* * * * *
    '        '* This method handles loading the form.
    '        '* * * * *

    '        LoadGuilds()
    '    End Sub

    '    Private Sub FrmAdminGuilds_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    '        '* * * * *
    '        '* This method handles the form closing.
    '        '* * * * *

    '        FrmAdmin.Show()
    '    End Sub

    'End Class

End Namespace