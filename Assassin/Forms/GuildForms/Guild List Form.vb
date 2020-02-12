Option Strict On
Option Explicit On

Imports Assassin.Classes
Imports Assassin.Classes.Entities

Namespace Forms.GuildForms

    Public Class FrmGuildList

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

                If CurrentGuild.HasMember(CurrentUser) Then
                    'if CurrentUser is a member of selected guild
                    BtnEnter.Enabled = True
                    BtnApply.Enabled = False
                Else
                    'if CurrentUser isn't a member
                    If Await DatabaseInteraction.HasAppliedToGuild(CurrentUser, CurrentGuild) Then
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
                    Await DatabaseInteraction.ApplyToGuild(CurrentUser, CurrentGuild)
                    AddText($"You paid {CurrentGuild.Fee} gold and applied for the {CurrentGuild.Name} guild.")
                End If

                BtnApply.Enabled = False
                CurrentUser.GoldOnHand -= CurrentGuild.Fee
                CurrentGuild.Gold += CurrentGuild.Fee
                Await DatabaseInteraction.SaveGuild(CurrentGuild)
                Await SaveUser(CurrentUser)

                Display()
            End If
        End Sub

        Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
            Close()
        End Sub

        Private Sub BtnEnter_Click(sender As Object, e As EventArgs) Handles BtnEnter.Click
            FrmGuild.Show()
            FrmGuild.LoadGuild()
            Hide()
        End Sub

#End Region

        Private Sub FrmGuildList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Populate()
        End Sub

        Private Sub FrmGuildList_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
            FrmGame.Show()
            FrmGame.Display()
            FrmGame.AddText(TxtGuilds.Text.Trim())
        End Sub

    End Class

End Namespace