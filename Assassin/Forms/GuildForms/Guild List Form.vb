Option Strict On
Option Explicit On

Imports Assassin.Classes
Imports Assassin.Classes.Entities

Namespace Forms.GuildForms

    Public Class FrmGuildList

        Dim _blnGuild As Boolean = False

        ''' <summary>Determines if the current <see cref="User"/> is a member of the selected <see cref="Guild"/>.</summary>
        ''' <returns>True if a member</returns>
        Private Function IsMember() As Boolean
            Return CurrentGuild.Members.Contains(CurrentUser.Name)
        End Function

        ''' <summary>Add text to the TextBox.</summary>
        ''' <param name="newText">Text to be added</param>
        Public Sub AddText(newText As String)
            AddTextToTextBox(TxtGuilds, newText)
        End Sub

        ''' <summary>Displays information about the selected <see cref="Guild"/>.</summary>
        Public Async Sub Display()
            If LstGuilds.SelectedIndex >= 0 Then
                CurrentGuild = AllGuilds.Find(Function(guild) guild.ID = LstGuilds.SelectedIndex + 1)
                LblGoldOnHand.Text = CurrentUser.GoldOnHandToString
                If CurrentGuild.Master = "Computer" Then
                    Select Case CurrentGuild.ID
                        Case 1
                            LblGuildmaster.Text = "The Master"
                        Case 2
                            LblGuildmaster.Text = "Rathskeller"
                        Case Else
                            LblGuildmaster.Text = $"{CurrentGuild.Name} Master"
                    End Select
                Else
                    LblGuildmaster.Text = CurrentGuild.Master.ToString
                End If

                LblFee.Text = CurrentGuild.Fee.ToString("N0")
                LblGuildGold.Text = CurrentGuild.Gold.ToString("N0")
                LblHenchmenLevel1.Text = CurrentGuild.HenchmenLevel1.ToString("N0")
                LblHenchmenLevel2.Text = CurrentGuild.HenchmenLevel2.ToString("N0")
                LblHenchmenLevel3.Text = CurrentGuild.HenchmenLevel3.ToString("N0")
                LblHenchmenLevel4.Text = CurrentGuild.HenchmenLevel4.ToString("N0")
                LblHenchmenLevel5.Text = CurrentGuild.HenchmenLevel5.ToString("N0")

                If IsMember() Then
                    'if CurrentUser is a member of selected guild
                    BtnEnter.Enabled = True
                    BtnApply.Enabled = False
                Else
                    'if CurrentUser isn't a member
                    If Await HasAppliedToGuild(CurrentUser, CurrentGuild) Then
                        'user has already applied
                        BtnEnter.Enabled = False
                        BtnApply.Enabled = False
                    Else
                        'can potentially apply
                        BtnEnter.Enabled = False
                        If CurrentGuild.ID = 1 AndAlso CurrentUser.Level > 5 Then
                            'if guild is beginner's guild and greater than level 5
                            BtnApply.Enabled = False
                        ElseIf CurrentUser.GoldOnHand < CurrentGuild.Fee Then
                            'if user doesn't have enough gold
                            BtnApply.Enabled = False
                            LblFee.Text = CurrentGuild.Fee.ToString("N0")
                        Else
                            BtnApply.Enabled = True
                            LblFee.Text = CurrentGuild.Fee.ToString("N0")
                        End If
                    End If
                End If
            Else    'should never happen
                MessageBox.Show("Please select a guild.", "Assassin", MessageBoxButtons.OK)
            End If
        End Sub

        ''' <summary>Populates the ListBox.</summary>
        Public Sub Populate()
            For Each guild As Guild In AllGuilds
                LstGuilds.Items.Add(guild.ToString)
            Next
        End Sub

#Region "Click"

        Private Sub LstGuilds_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstGuilds.SelectedIndexChanged
            Display()
        End Sub

        Private Async Sub BtnApply_Click(sender As Object, e As EventArgs) Handles BtnApply.Click
            Dim dlg As DialogResult
            dlg = MessageBox.Show($"Are you sure you want to apply for this guild? It will cost {CurrentGuild.Fee} gold.", "Assassin", MessageBoxButtons.YesNo)

            If dlg = DialogResult.Yes Then  'if applying
                If CurrentGuild.Master = "Computer" Then
                    'if guildmaster is Computer, always accept
                    Await MemberJoinsGuild(CurrentUser, CurrentGuild)
                    AddText($"You paid {CurrentGuild.Fee} gold to join the {CurrentGuild.Name} guild, and have been accepted!")
                    CurrentGuild.Members.Add(CurrentUser.Name)
                    BtnEnter.Enabled = True
                Else
                    'submit new application
                    Await ApplyToGuild(CurrentUser, CurrentGuild)
                    AddText($"You paid {CurrentGuild.Fee} gold and applied for the {CurrentGuild.Name} guild.")
                End If

                BtnApply.Enabled = False
                CurrentUser.GoldOnHand -= CurrentGuild.Fee
                CurrentGuild.Gold += CurrentGuild.Fee
                Await SaveGuild(CurrentGuild)
                Await SaveUser(CurrentUser)

                Display()
            End If
        End Sub

        Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
            Me.Close()
        End Sub

        Private Sub BtnEnter_Click(sender As Object, e As EventArgs) Handles BtnEnter.Click
            _blnGuild = True
            Me.Close()
        End Sub

#End Region

        Private Sub FrmGuildList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Populate()
        End Sub

        Private Sub FrmGuildList_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
            'TODO Hide Guild List Form
            If _blnGuild = False Then 'return to Game form
                FrmGame.Show()
                If FrmGame.TxtGame.TextLength > 0 Then
                    FrmGame.AddText(TxtGuilds.Text.Trim())
                Else
                    FrmGame.Text = TxtGuilds.Text.Trim()
                End If
            Else 'enter Guild
                FrmGuild.Show()
                CurrentGuild = CurrentGuild
                FrmGuild.TxtGuild.Text = TxtGuilds.Text.Trim()
                FrmGuild.LoadGuild()
            End If
        End Sub

    End Class

End Namespace