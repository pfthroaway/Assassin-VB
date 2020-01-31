' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 05/25/2012
' Filename        : Guild List Form.vb
' Description     : This form contains the list of guilds.

Option Strict On
Option Explicit On

Namespace Forms.GuildForms

    Public Class FrmGuildList
        'TODO Fix Guild List
        '    Dim _blnGuild As Boolean = False             'go to guild?
        '    Dim _currGuild As New Entities.Guild                  'current guild

        '    Private Function HasApplied() As Task(Of Boolean)
        '        '* * * * *
        '        '* This function checks whether the user has applied to the selected guild.
        '        '* * * * *
        '        'TODO Fix Guild Applications
        '        '_sql = "SELECT * FROM Applications WHERE Guild=" & _currGuild.ID & " AND Username='" & CurrentUser.Name & "'"
        '        '_table = "Applications"
        '        '_ds.Clear()
        '        '

        '        'If _ds.Tables(0).Rows.Count > 0 Then
        '        '    Return True
        '        'Else
        '        '    Return False
        '        'End If
        '    End Function

        '    Private Async Function IsMember() As Task(Of Boolean)
        '        '* * * * *
        '        '* This function determines if the CurrentUser is a member of the selected guild.
        '        '* * * * *
        '        'TODO Fix Guild Membership checking
        '        _sql = "SELECT * FROM Guild" & _currGuild.ID & "Members WHERE Username='" & CurrentUser.Name & "'"
        '        _table = "Members"
        '        _ds.Clear()

        '        If _ds.Tables(0).Rows.Count > 0 Then
        '            Return True
        '        Else
        '            Return False
        '        End If
        '    End Function

        '    Public Sub AddText(ByVal newText As String)
        '        '* * * * *
        '        '* This method adds text to the Textbox.
        '        '* * * * *

        '        TxtGuilds.Text.Contains(_nl + _nl)
        '        Dim currText As String = TxtGuilds.Text
        '        TxtGuilds.Clear()

        '        TxtGuilds.Text = newText & _nl & _nl & currText
        '        TxtGuilds.Select(0, 0)
        '        TxtGuilds.ScrollToCaret()
        '    End Sub

        '    Public Async Sub Display()
        '        '* * * * *
        '        '* This method displays information about the selected guild.
        '        '* * * * *

        '        If LstGuilds.SelectedIndex > -1 Then
        '            Dim guild As Integer = LstGuilds.SelectedIndex + 1

        '            _sql = "SELECT * FROM Guilds WHERE ID=" & guild & ""
        '            _table = "Guilds"
        '            _currGuild = Await .GetGuild(guild)

        '            lblFee.Text = ""
        '            lblGoldOnHand.Text = CurrentUser.GoldOnHand.ToString("N0")

        '            If _currGuild.Master = "Computer" Then
        '                Select Case _currGuild.ID
        '                    Case 1
        '                        lblGuildmaster.Text = "The Master"
        '                    Case 2
        '                        lblGuildmaster.Text = "Rathskeller"
        '                    Case Else
        '                        lblGuildmaster.Text = _currGuild.Name & " Master"
        '                End Select
        '            Else
        '                lblGuildmaster.Text = _currGuild.Master.ToString
        '            End If

        '            lblFee.Text = _currGuild.Fee.ToString("N0")
        '            lblGuildGold.Text = _currGuild.Gold.ToString("N0")
        '            lblHenchmenLevel1.Text = _currGuild.HenchmenLevel1.ToString("N0")
        '            lblHenchmenLevel2.Text = _currGuild.HenchmenLevel2.ToString("N0")
        '            lblHenchmenLevel3.Text = _currGuild.HenchmenLevel3.ToString("N0")
        '            lblHenchmenLevel4.Text = _currGuild.HenchmenLevel4.ToString("N0")
        '            lblHenchmenLevel5.Text = _currGuild.HenchmenLevel5.ToString("N0")

        '            If Await IsMember() Then              'if CurrentUser is a member of selected guild
        '                BtnEnter.Enabled = True
        '                BtnApply.Enabled = False
        '            Else                            'if CurrentUser isn't a member
        '                If Await HasApplied() Then
        '                    BtnEnter.Enabled = False
        '                    'user has already applied
        '                    BtnApply.Enabled = False
        '                Else                                                'can potentially apply
        '                    BtnEnter.Enabled = False
        '                    If guild = 1 AndAlso CurrentUser.Level > 5 Then    'if guild is beginner's guild and greater than level 5
        '                        BtnApply.Enabled = False
        '                    ElseIf CurrentUser.GoldOnHand < _currGuild.Fee Then 'if user doesn't have enough gold
        '                        BtnApply.Enabled = False
        '                        lblFee.Text = _currGuild.Fee.ToString("N0")
        '                    Else
        '                        BtnApply.Enabled = True
        '                        lblFee.Text = _currGuild.Fee.ToString("N0")
        '                    End If
        '                End If
        '            End If
        '        Else    'should never happen
        '            MessageBox.Show("Please select a guild.", "Assassin", MessageBoxButtons.OK)
        '        End If
        '    End Sub

        '    Public Async Sub Populate()
        '        '* * * * *
        '        '* This method populates the ListBox with all the guilds' names)
        '        '* * * * *

        '        _sql = "SELECT ID,GuildName FROM Guilds ORDER BY ID Asc"
        '        _table = "Guilds"

        '        _ds.Clear()

        '        For i As Integer = 0 To _ds.Tables(0).Rows.Count - 1
        '            LstGuilds.Items.Add(_ds.Tables(0).Rows(i).Item("GuildName").ToString)
        '        Next
        '    End Sub

        '    Private Sub LstGuilds_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstGuilds.SelectedIndexChanged
        '        '* * * * *
        '        '* This method handles the selected ListBox item.
        '        '* * * * *

        '        Display()
        '    End Sub

        '    Private Async Sub BtnApply_Click(sender As Object, e As EventArgs) Handles BtnApply.Click
        '        '* * * * *
        '        '* This method applies the CurrentUser to the selected guild.
        '        '* * * * *

        '        Dim dlg As DialogResult
        '        dlg = MessageBox.Show("Are you sure you want to apply for this guild? It will cost " & _currGuild.Fee & " gold.", "Assassin", MessageBoxButtons.YesNo)

        '        If dlg = DialogResult.Yes Then  'if applying

        '            _sql = "SELECT Guildmaster FROM Guilds WHERE ID=" & _currGuild.ID & ""
        '            _table = "Guild"
        '            _ds.Clear()

        '            Dim dsNewRow As DataRow
        '            If _ds.Tables(0).Rows(0).Item("Guildmaster").ToString = "Computer" Then    'if guildmaster is Computer, always accept
        '                _sql = "SELECT * FROM Guild" & _currGuild.ID & "Members WHERE Username='" & CurrentUser.Name & "'"
        '                _table = "Guild"

        '                _ds.Clear()

        '                dsNewRow = _ds.Tables(0).NewRow()          'create new row
        '                dsNewRow.Item("Username") = CurrentUser.Name

        '                _ds.Tables(0).Rows.Add(dsNewRow)           'add new row to DataSet
        '                .UpdateRecord(_sql, _table, _ds)              'update DataSet

        '                AddText("You paid " & _currGuild.Fee & " gold to join the " & _currGuild.Name & " guild, and have been accepted!")
        '            Else                                                                            'submit new application
        '                _sql = "SELECT * FROM Applications"
        '                _table = "Applications"

        '                _ds.Clear()

        '                dsNewRow = _ds.Tables(0).NewRow()   'create new row
        '                dsNewRow.Item("Guild") = _currGuild.ID
        '                dsNewRow.Item("Username") = CurrentUser.Name

        '                _ds.Tables(0).Rows.Add(dsNewRow)    'add new row to Dataset
        '                .UpdateRecord(_sql, _table, _ds)              'update DataSet

        '                AddText("You paid " & _currGuild.Fee & " gold and applied for the " & _currGuild.Name & " guild.")
        '            End If

        '            BtnApply.Enabled = False
        '            CurrentUser.GoldOnHand -= _currGuild.Fee    'subtract gold from CurrentUser
        '            _currGuild.Gold += _currGuild.Fee         'add gold to currGuild
        '            .SaveGuild(_currGuild)              'save currGuild
        '            SaveUser(CurrentUser)                    'save CurrentUser

        '            Display()
        '        End If
        '    End Sub

        '    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        '        '* * * * *
        '        '* This method closes the form on clicking the Back button.
        '        '* * * * *

        '        Me.Close()
        '    End Sub

        '    Private Sub BtnEnter_Click(sender As Object, e As EventArgs) Handles BtnEnter.Click
        '        '* * * * *
        '        '* This method enters the currently selected guild.
        '        '* * * * *

        '        _blnGuild = True
        '        Me.Close()
        '    End Sub

        '    Private Sub FrmGuildList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '        '* * * * *
        '        '* On loading the form, populate the ListBox.
        '        '* * * * *

        '        Populate()
        '    End Sub

        '    Private Sub FrmGuildList_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        '        '* * * * *
        '        '* This method handles the form closing.
        '        '* * * * *

        '        If _blnGuild = False Then    'return to Game form
        '            FrmGame.Show()
        '            FrmGame.CurrentUser = CurrentUser
        '            If FrmGame.txtGame.TextLength > 0 Then
        '                FrmGame.AddText(txtGuilds.Text)
        '            Else
        '                FrmGame.Text = TxtGuilds.Text
        '            End If
        '        Else                        'enter Guild
        '            FrmGuild.Show()
        '            FrmGuild.CurrentGuild = _currGuild
        '            FrmGuild.CurrentUser = CurrentUser
        '            FrmGuild.txtGuild.Text = TxtGuilds.Text
        '            FrmGuild.LoadGuild()
        '        End If
        '    End Sub

    End Class

End Namespace