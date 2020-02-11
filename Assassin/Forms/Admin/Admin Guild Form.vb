Option Strict On
Option Explicit On

Imports Assassin.Classes
Imports Assassin.Classes.Entities

Namespace Forms.Admin

    Public Class FrmAdminGuilds

        ''' <summary>Clears all information on the Form.</summary>
        Private Sub Clear()
            Disable()
            LstGuilds.Enabled = True
            LstGuilds.Items.Clear()
            LstGuilds.ClearSelected()
            BtnAddMember.Text = "&Add Member"
            TxtName.Clear()
            CmbGuildmaster.SelectedIndex = 0
            TxtEntranceFee.Clear()
            TxtGuildGold.Clear()
            TxtHenchmenLevel1.Clear()
            TxtHenchmenLevel2.Clear()
            TxtHenchmenLevel3.Clear()
            TxtHenchmenLevel4.Clear()
            TxtHenchmenLevel5.Clear()

            LstMembers.Items.Clear()
            LstMembers.ClearSelected()
        End Sub

        ''' <summary>Disables everything on the form.</summary>
        Private Sub Disable()
            TxtName.Enabled = False
            CmbGuildmaster.Enabled = False
            TxtEntranceFee.Enabled = False
            TxtGuildGold.Enabled = False
            TxtHenchmenLevel1.Enabled = False
            TxtHenchmenLevel2.Enabled = False
            TxtHenchmenLevel3.Enabled = False
            TxtHenchmenLevel4.Enabled = False
            TxtHenchmenLevel5.Enabled = False

            LstMembers.Enabled = False
            BtnAddMember.Enabled = False
            BtnClear.Enabled = False
            BtnExpel.Enabled = False
            BtnSave.Enabled = False
        End Sub

        ''' <summary>Displays all information about a <see cref="Guild"/>.</summary>
        Private Sub Display()
            Enable()
            TxtName.Text = CurrentGuild.Name
            GetMembers()
            TxtEntranceFee.Text = CurrentGuild.Fee.ToString
            TxtGuildGold.Text = CurrentGuild.Gold.ToString
            TxtHenchmenLevel1.Text = CurrentGuild.HenchmenLevel1.ToString
            TxtHenchmenLevel2.Text = CurrentGuild.HenchmenLevel2.ToString
            TxtHenchmenLevel3.Text = CurrentGuild.HenchmenLevel3.ToString
            TxtHenchmenLevel4.Text = CurrentGuild.HenchmenLevel4.ToString
            TxtHenchmenLevel5.Text = CurrentGuild.HenchmenLevel5.ToString
        End Sub

        Private Sub DisplayCurrentGuildMembers()
            For Each member As String In CurrentGuild.Members
                LstMembers.Items.Add(member)
            Next
        End Sub

        ''' <summary>Enables everything on the Form.</summary>
        Private Sub Enable()
            LstGuilds.Enabled = True
            TxtName.Enabled = True
            CmbGuildmaster.Enabled = True
            TxtEntranceFee.Enabled = True
            TxtGuildGold.Enabled = True
            TxtHenchmenLevel1.Enabled = True
            TxtHenchmenLevel2.Enabled = True
            TxtHenchmenLevel3.Enabled = True
            TxtHenchmenLevel4.Enabled = True
            TxtHenchmenLevel5.Enabled = True

            LstMembers.Enabled = True
            BtnAddMember.Enabled = True
            BtnClear.Enabled = True
            BtnSave.Enabled = True
        End Sub

        ''' <summary>Gets the members of a <see cref="Guild"/>.</summary>
        Private Sub GetMembers()
            CmbGuildmaster.Items.Clear()
            LstMembers.Items.Clear()
            LstMembers.ClearSelected()
            CmbGuildmaster.Items.Add("Computer")

            DisplayCurrentGuildMembers()

            If CurrentGuild.ID <> 1 Then
                For Each member As String In CurrentGuild.Members
                    CmbGuildmaster.Items.Add(member)
                Next
            End If

            CmbGuildmaster.SelectedItem = CurrentGuild.Master
        End Sub

        ''' <summary>Loads all the <see cref="Guild"/>s and their informations.</summary>
        Private Sub LoadGuilds()
            Clear()

            For Each guild As Guild In AllGuilds
                LstGuilds.Items.Add(guild)
            Next
            LstGuilds.SelectedIndex = 0
        End Sub

        ''' <summary>Saves the <see cref="Guild"/>.</summary>
        Private Async Sub Save()
            CurrentGuild.Name = TxtName.Text.Trim()
            CurrentGuild.Master = CmbGuildmaster.SelectedItem.ToString
            Integer.TryParse(TxtEntranceFee.Text.Trim(), CurrentGuild.Fee)
            Integer.TryParse(TxtGuildGold.Text.Trim(), CurrentGuild.Gold)
            Integer.TryParse(TxtHenchmenLevel1.Text.Trim(), CurrentGuild.HenchmenLevel1)
            Integer.TryParse(TxtHenchmenLevel2.Text.Trim(), CurrentGuild.HenchmenLevel2)
            Integer.TryParse(TxtHenchmenLevel3.Text.Trim(), CurrentGuild.HenchmenLevel3)
            Integer.TryParse(TxtHenchmenLevel4.Text.Trim(), CurrentGuild.HenchmenLevel4)
            Integer.TryParse(TxtHenchmenLevel5.Text.Trim(), CurrentGuild.HenchmenLevel5)

            Await DatabaseInteraction.SaveGuild(CurrentGuild)
            LoadGuilds()
        End Sub

        Private Sub NumChars_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtEntranceFee.KeyPress, TxtGuildGold.KeyPress, TxtHenchmenLevel1.KeyPress, TxtHenchmenLevel2.KeyPress, TxtHenchmenLevel3.KeyPress, TxtHenchmenLevel4.KeyPress, TxtHenchmenLevel5.KeyPress
            e.Handled = Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar Like Chr(8))
        End Sub

        Private Sub TxtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtName.KeyPress
            'letters, numbers, backspace, space, apostrophe
            e.Handled = Not (Char.IsLetterOrDigit(e.KeyChar) OrElse e.KeyChar Like Chr(8) OrElse e.KeyChar Like " " OrElse e.KeyChar Like "'")
        End Sub

        Private Sub TxtEntranceFee_TextChanged(sender As Object, e As EventArgs) Handles TxtEntranceFee.TextChanged
            If TxtEntranceFee.TextLength > 0 Then
                If (CInt(TxtEntranceFee.Text.Trim()) > 1000) Then
                    TxtEntranceFee.Clear()
                End If
            End If
        End Sub

#Region "Click"

        Private Async Sub BtnAddMember_Click(sender As Object, e As EventArgs) Handles BtnAddMember.Click
            If BtnAddMember.Text <> "&Add" Then
                If BtnAddMember.Text = "&Add Member" Then
                    Disable()
                    LstGuilds.Enabled = False
                    BtnAddMember.Enabled = True
                    BtnAddMember.Text = "&Add"
                    BtnClear.Enabled = True
                    LstMembers.Enabled = True
                    LstMembers.Items.Clear()
                    For Each user In AllUsers
                        If Not CurrentGuild.Members.Contains(user.Name) Then
                            LstMembers.Items.Add(user.Name)
                        End If
                    Next
                    BtnAddMember.Enabled = False
                End If
            Else
                If LstMembers.SelectedIndex >= 0 Then
                    If Await DatabaseInteraction.MemberJoinsGuild(CurrentUser, CurrentGuild) Then
                        CurrentGuild.Members.Add(CurrentUser.Name)
                        GetMembers()
                        Enable()
                        BtnAddMember.Text = "&Add Member"
                    End If
                Else
                    MessageBox.Show("Please select a member to add to the guild.", "Assassin", MessageBoxButtons.OK)
                End If
            End If
        End Sub

        Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
            If BtnAddMember.Text = "&Add Member" Then
                LoadGuilds()
            Else
                GetMembers()
                Enable()
                BtnAddMember.Text = "&Add Member"
            End If
        End Sub

        Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
            Me.Close()
        End Sub

        Private Async Sub BtnExpel_Click(sender As Object, e As EventArgs) Handles BtnExpel.Click
            Dim dlg As DialogResult
            dlg = MessageBox.Show("Are you sure you want to expel this member?", "Assassin", MessageBoxButtons.YesNo)

            If dlg = DialogResult.Yes Then
                Await DatabaseInteraction.MemberLeavesGuild(CurrentUser, CurrentGuild)
                CurrentGuild.Members.Remove(CurrentUser.Name)
                GetMembers()
            End If
        End Sub

        Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
            Save()
        End Sub

        Private Sub LstGuilds_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstGuilds.SelectedIndexChanged
            If LstGuilds.SelectedIndex >= 0 Then
                CurrentGuild = AllGuilds(LstGuilds.SelectedIndex)
                Display()
                BtnAddMember.Text = "&Add Member"
            End If
        End Sub

        Private Sub LstMembers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstMembers.SelectedIndexChanged
            If LstMembers.SelectedIndex >= 0 Then
                CurrentUser = AllUsers.Find(Function(user) user.Name = LstMembers.SelectedItem.ToString())
                BtnExpel.Enabled = LstMembers.SelectedIndex >= 0 AndAlso BtnAddMember.Text = "&Add Member"
                BtnAddMember.Enabled = LstMembers.SelectedIndex >= 0 OrElse BtnAddMember.Text = "&Add"
            End If
        End Sub

#End Region

#Region "Form Manipulation"

        Private Sub FrmAdminGuilds_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            LoadGuilds()
        End Sub

        Private Sub FrmAdminGuilds_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
            FrmAdmin.Show()
        End Sub

        Private Sub LstGuilds_Leave(sender As Object, e As EventArgs) Handles LstGuilds.Leave
            LstGuilds.Update()
        End Sub

        Private Sub LstMembers_Leave(sender As Object, e As EventArgs) Handles LstMembers.Leave
            LstMembers.Update()
        End Sub

#End Region

    End Class

End Namespace