' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 05/25/2012
' Filename        : Raid Form.vb
' Description     : This form allows a user to raid other guilds and the bank.

Option Strict On
Option Explicit On

Imports Assassin.Classes
Imports Assassin.Classes.Entities
Imports Assassin.Forms.GuildForms
Imports Extensions

Namespace Forms

    Public Class FrmRaid

        Dim _raidGuild As New Guild              'guild selected to be raided
        Dim _playerHenchmen As New Henchman            'player's henchmen
        Dim _enemyHenchmen As New Henchman            'enemy's henchmen

        ''' <summary>Determines the highest level of henchmen the enemy has.</summary>
        ''' <returns>the highest level of henchmen the enemy has</returns>
        Private Function CheckMaxHenchmanLevel(ByRef henchmen As Henchman) As Integer
            If henchmen.HenchmenLevel5 > 0 Then
                henchmen.Number = henchmen.HenchmenLevel5
                Return 5
            ElseIf henchmen.HenchmenLevel4 > 0 Then
                henchmen.Number = henchmen.HenchmenLevel4
                Return 4
            ElseIf henchmen.HenchmenLevel3 > 0 Then
                henchmen.Number = henchmen.HenchmenLevel3
                Return 3
            ElseIf henchmen.HenchmenLevel2 > 0 Then
                henchmen.Number = henchmen.HenchmenLevel2
                Return 2
            ElseIf henchmen.HenchmenLevel1 > 0 Then
                henchmen.Number = henchmen.HenchmenLevel1
                Return 1
            Else
                Return 0
            End If
        End Function

        ''' <summary>Decrements the henchman at that level.</summary>
        ''' <param name="hench">Level of henchmen</param>
        ''' <returns>Modified henchmen</returns>
        Private Function DecreaseHenchmen(hench As Henchman) As Henchman
            Select Case hench.Level
                Case 5
                    hench.Number -= 1
                    hench.HenchmenLevel5 -= 1
                Case 4
                    hench.Number -= 1
                    hench.HenchmenLevel4 -= 1
                Case 3
                    hench.Number -= 1
                    hench.HenchmenLevel3 -= 1
                Case 2
                    hench.Number -= 1
                    hench.HenchmenLevel2 -= 1
                Case 1
                    hench.Number -= 1
                    hench.HenchmenLevel1 -= 1
            End Select

            Return hench
        End Function

        ''' <summary>Determines the number of henchmen the enemy has.</summary>
        ''' <returns>The number of henchmen the enemy has</returns>
        Private Function EnemyCount() As Integer
            Return _enemyHenchmen.HenchmenLevel1 + _enemyHenchmen.HenchmenLevel2 + _enemyHenchmen.HenchmenLevel3 + _enemyHenchmen.HenchmenLevel4 + _enemyHenchmen.HenchmenLevel5
        End Function

        ''' <summary>Determines the number of henchmen the player has.</summary>
        ''' <returns>The number of henchmen the player has</returns>
        Private Function PlayerCount() As Integer
            Return _playerHenchmen.HenchmenLevel1 + _playerHenchmen.HenchmenLevel2 + _playerHenchmen.HenchmenLevel3 + _playerHenchmen.HenchmenLevel4 + _playerHenchmen.HenchmenLevel5
        End Function

        Public Sub AddText(newText As String)
            AddTextToTextBox(TxtRaid, newText)
        End Sub

        ''' <summary>Handles raiding.</summary>
        Private Sub Battle()
            While _playerHenchmen.Number > 0 AndAlso _enemyHenchmen.Number > 0
                Dim first As Integer = Functions.GenerateRandomNumber(1, 100)
                If first <= 50 Then
                    PlayerAttack()
                    If _enemyHenchmen.Number > 0 Then
                        EnemyAttack()
                    End If
                Else
                    EnemyAttack()
                    If _playerHenchmen.Number > 0 Then
                        PlayerAttack()
                    End If
                End If
            End While

        End Sub

        ''' <summary>Checks whether you can click the Raid button.</summary>
        Private Sub CheckRaid()
            If CmbRaid.SelectedIndex <> CurrentGuild.ID AndAlso CmbRaid.SelectedIndex <> 1 Then
                Dim henchmenLevel1 As Integer
                Dim henchmenLevel2 As Integer
                Dim henchmenLevel3 As Integer
                Dim henchmenLevel4 As Integer
                Dim henchmenLevel5 As Integer
                Integer.TryParse(TxtHenchmenLevel1.Text, henchmenLevel1)
                Integer.TryParse(TxtHenchmenLevel2.Text, henchmenLevel2)
                Integer.TryParse(TxtHenchmenLevel3.Text, henchmenLevel3)
                Integer.TryParse(TxtHenchmenLevel4.Text, henchmenLevel4)
                Integer.TryParse(TxtHenchmenLevel5.Text, henchmenLevel5)

                BtnRaid.Enabled = (henchmenLevel1 + henchmenLevel2 + henchmenLevel3 + henchmenLevel4 + henchmenLevel5) > 0 AndAlso CmbRaid.SelectedIndex >= 0
            ElseIf CmbRaid.SelectedIndex = 1 Then
                MessageBox.Show("You cannot raid The Master's Tavern.", "Assassin", MessageBoxButtons.OK)
                BtnRaid.Enabled = False
            ElseIf CmbRaid.SelectedIndex = CurrentGuild.ID Then
                MessageBox.Show("You cannot raid the guild you are currently in.", "Assassin", MessageBoxButtons.OK)
                BtnRaid.Enabled = False
            End If
        End Sub

        ''' <summary>Disables everything except the Back button.</summary>
        Private Sub DisableButtons()
            CmbRaid.Enabled = False
            BtnRaid.Enabled = False
            BtnClear.Enabled = False
            TxtHenchmenLevel1.Enabled = False
            TxtHenchmenLevel2.Enabled = False
            TxtHenchmenLevel3.Enabled = False
            TxtHenchmenLevel4.Enabled = False
            TxtHenchmenLevel5.Enabled = False
        End Sub

        ''' <summary>Handles the enemy's henchman attacking.</summary>
        Private Sub EnemyAttack()
            Dim toHit As Integer = Functions.GenerateRandomNumber(1, 100)
            Dim plrBlock As Integer = Functions.GenerateRandomNumber(1, 100)

            If toHit <= _playerHenchmen.WeaponSkill Then                         'potential to hit
                If plrBlock >= _playerHenchmen.Blocking Then               'player didn't block
                    _playerHenchmen.Health -= _enemyHenchmen.Damage              'player loses health
                    If _playerHenchmen.Health <= 0 Then                    'if player has no health
                        _playerHenchmen = DecreaseHenchmen(_playerHenchmen)
                        If _playerHenchmen.Number > 0 Then                 'if player still has members
                            _playerHenchmen.Health = _playerHenchmen.Level * 2    'set health to max
                        End If
                    End If
                End If
            End If
        End Sub

        ''' <summary>Loads all the information on the form.</summary>
        Public Sub LoadRaid()
            CmbRaid.Items.Add("Bank")
            For Each guild As Guild In AllGuilds
                CmbRaid.Items.Add(guild.Name)
            Next

            TxtMax1.Text = CurrentUser.HenchmenLevel1.ToString
            TxtMax2.Text = CurrentUser.HenchmenLevel2.ToString
            TxtMax3.Text = CurrentUser.HenchmenLevel3.ToString
            TxtMax4.Text = CurrentUser.HenchmenLevel4.ToString
            TxtMax5.Text = CurrentUser.HenchmenLevel5.ToString
        End Sub

        ''' <summary>Handles the player failing the raiding.</summary>
        Private Sub LoseBattle()
            AddText($"You failed to raid the {CmbRaid.SelectedItem.ToString}.")
            CmbRaid.Enabled = False
            BtnRaid.Enabled = False
            BtnClear.Enabled = False
        End Sub

        ''' <summary>Handles the player's henchman attacking.</summary>
        Private Sub PlayerAttack()
            Dim toHit As Integer = Functions.GenerateRandomNumber(1, 100)
            Dim eneBlock As Integer = Functions.GenerateRandomNumber(1, 100)

            If toHit <= _playerHenchmen.WeaponSkill Then                         'potential to hit
                If eneBlock >= _enemyHenchmen.Blocking Then               'enemy didn't block
                    _enemyHenchmen.Health -= _playerHenchmen.Damage              'enemy loses health
                    If _enemyHenchmen.Health <= 0 Then                    'if enemy has no health
                        DecreaseHenchmen(_enemyHenchmen)
                        If _enemyHenchmen.Number > 0 Then                 'if enemy still has members
                            _enemyHenchmen.Health = _enemyHenchmen.Level * 2    'set health to max
                        End If
                    End If
                End If
            End If
        End Sub

        ''' <summary>Sets the number of henchmen for both parties.</summary>
        Private Sub SetHenchmen()
            _playerHenchmen.HenchmenLevel1 = CurrentUser.HenchmenLevel1
            _playerHenchmen.HenchmenLevel2 = CurrentUser.HenchmenLevel2
            _playerHenchmen.HenchmenLevel3 = CurrentUser.HenchmenLevel3
            _playerHenchmen.HenchmenLevel4 = CurrentUser.HenchmenLevel4
            _playerHenchmen.HenchmenLevel5 = CurrentUser.HenchmenLevel5

            _enemyHenchmen.HenchmenLevel1 = _raidGuild.HenchmenLevel1
            _enemyHenchmen.HenchmenLevel2 = _raidGuild.HenchmenLevel2
            _enemyHenchmen.HenchmenLevel3 = _raidGuild.HenchmenLevel3
            _enemyHenchmen.HenchmenLevel4 = _raidGuild.HenchmenLevel4
            _enemyHenchmen.HenchmenLevel5 = _raidGuild.HenchmenLevel5
        End Sub

        ''' <summary>Handles the player successfully raiding.</summary>
        Private Async Sub WinBattle()
            Dim number As Integer = PlayerCount()
            Dim maxgold As Integer
            Dim stolenGold As Integer

            If CmbRaid.SelectedItem.ToString <> "Bank" Then
                maxgold = _raidGuild.Gold
                stolenGold = If((number * 100) <= _raidGuild.Gold, number * 100, maxgold)

                _raidGuild.Gold -= stolenGold
                _raidGuild.HenchmenLevel1 = 0
                _raidGuild.HenchmenLevel2 = 0
                _raidGuild.HenchmenLevel3 = 0
                _raidGuild.HenchmenLevel4 = 0
                _raidGuild.HenchmenLevel5 = 0

                Await SaveGuild(_raidGuild)
            Else
                stolenGold = number * 100
            End If

            CurrentUser.HenchmenLevel1 = _playerHenchmen.HenchmenLevel1
            CurrentUser.HenchmenLevel2 = _playerHenchmen.HenchmenLevel2
            CurrentUser.HenchmenLevel3 = _playerHenchmen.HenchmenLevel3
            CurrentUser.HenchmenLevel4 = _playerHenchmen.HenchmenLevel4
            CurrentUser.HenchmenLevel5 = _playerHenchmen.HenchmenLevel5

            AddText($"You have won the battle! Your {number} remaining henchmen make off with {stolenGold} gold.")
            CurrentUser.GoldOnHand += stolenGold
            Await SaveUser(CurrentUser)

            CmbRaid.Enabled = False
            TxtHenchmenLevel1.Enabled = False
            TxtHenchmenLevel2.Enabled = False
            TxtHenchmenLevel3.Enabled = False
            TxtHenchmenLevel4.Enabled = False
            TxtHenchmenLevel5.Enabled = False
            BtnRaid.Enabled = False
            BtnClear.Enabled = False
        End Sub

        Private Sub HenchKeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtHenchmenLevel1.KeyPress, TxtHenchmenLevel2.KeyPress, TxtHenchmenLevel3.KeyPress, TxtHenchmenLevel4.KeyPress, TxtHenchmenLevel5.KeyPress
            e.Handled = Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar Like Chr(8))
        End Sub

        Private Sub CmbRaid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbRaid.SelectedIndexChanged
            CheckRaid()
        End Sub

        Private Sub TxtHenchmenLevel1_TextChanged(sender As Object, e As EventArgs) Handles TxtHenchmenLevel1.TextChanged
            Dim currHench As Integer
            Integer.TryParse(TxtHenchmenLevel1.Text, currHench)
            If currHench > CurrentUser.HenchmenLevel1 Then
                TxtHenchmenLevel1.Text = ""
            End If

            CheckRaid()
        End Sub

        Private Sub TxtHenchmenLevel2_TextChanged(sender As Object, e As EventArgs) Handles TxtHenchmenLevel2.TextChanged
            Dim currHench As Integer
            Integer.TryParse(TxtHenchmenLevel2.Text, currHench)
            If currHench > CurrentUser.HenchmenLevel2 Then
                TxtHenchmenLevel2.Text = ""
            End If

            CheckRaid()
        End Sub

        Private Sub TxtHenchmenLevel3_TextChanged(sender As Object, e As EventArgs) Handles TxtHenchmenLevel3.TextChanged
            Dim currHench As Integer
            Integer.TryParse(TxtHenchmenLevel3.Text, currHench)
            If currHench > CurrentUser.HenchmenLevel3 Then
                TxtHenchmenLevel3.Text = ""
            End If

            CheckRaid()
        End Sub

        Private Sub TxtHenchmenLevel4_TextChanged(sender As Object, e As EventArgs) Handles TxtHenchmenLevel4.TextChanged
            Dim currHench As Integer
            Integer.TryParse(TxtHenchmenLevel4.Text, currHench)
            If currHench > CurrentUser.HenchmenLevel4 Then
                TxtHenchmenLevel4.Text = ""
            End If

            CheckRaid()
        End Sub

        Private Sub TxtHenchmenLevel5_TextChanged(sender As Object, e As EventArgs) Handles TxtHenchmenLevel5.TextChanged
            Dim currHench As Integer
            Integer.TryParse(TxtHenchmenLevel5.Text, currHench)
            If currHench > CurrentUser.HenchmenLevel5 Then
                TxtHenchmenLevel5.Text = ""
            End If

            CheckRaid()
        End Sub

        Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
            Close()
        End Sub

        Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
            CmbRaid.SelectedIndex = -1

            TxtHenchmenLevel1.Text = ""
            TxtHenchmenLevel2.Text = ""
            TxtHenchmenLevel3.Text = ""
            TxtHenchmenLevel4.Text = ""
            TxtHenchmenLevel5.Text = ""

            BtnRaid.Enabled = False
        End Sub

        Private Sub BtnRaid_Click(sender As Object, e As EventArgs) Handles BtnRaid.Click
            If CmbRaid.SelectedItem.ToString <> "Bank" Then
                _raidGuild = AllGuilds(CmbRaid.SelectedIndex - 1)

                SetHenchmen()
                Dim round As Integer = 1

                While PlayerCount() > 0 AndAlso EnemyCount() > 0
                    _playerHenchmen.Level = CheckMaxHenchmanLevel(_playerHenchmen)
                    Select Case _playerHenchmen.Level
                        Case 5
                            _playerHenchmen.Number = _playerHenchmen.HenchmenLevel5
                        Case 4
                            _playerHenchmen.Number = _playerHenchmen.HenchmenLevel4
                        Case 3
                            _playerHenchmen.Number = _playerHenchmen.HenchmenLevel3
                        Case 2
                            _playerHenchmen.Number = _playerHenchmen.HenchmenLevel2
                        Case 1
                            _playerHenchmen.Number = _playerHenchmen.HenchmenLevel1
                    End Select
                    _enemyHenchmen.Level = CheckMaxHenchmanLevel(_enemyHenchmen)
                    Select Case _enemyHenchmen.Level
                        Case 5
                            _enemyHenchmen.Number = _enemyHenchmen.HenchmenLevel5
                        Case 4
                            _enemyHenchmen.Number = _enemyHenchmen.HenchmenLevel4
                        Case 3
                            _enemyHenchmen.Number = _enemyHenchmen.HenchmenLevel3
                        Case 2
                            _enemyHenchmen.Number = _enemyHenchmen.HenchmenLevel2
                        Case 1
                            _enemyHenchmen.Number = _enemyHenchmen.HenchmenLevel1
                    End Select

                    AddText($"You begin Round {round} with {_playerHenchmen.Number} Level {_playerHenchmen.Level} Henchmen. Your opponent begins the round with {_enemyHenchmen.Number} Level {_enemyHenchmen.Level} Henchmen.")

                    Battle()

                    AddText($"You end Round {round} with {_playerHenchmen.Number} Level {_playerHenchmen.Level} Henchmen. Your opponent ends the round with {_enemyHenchmen.Number} Level {_enemyHenchmen.Level} Henchmen.")

                    round += 1
                End While
            End If

            If PlayerCount() > 0 AndAlso EnemyCount() <= 0 Then
                WinBattle()
            ElseIf EnemyCount() > 0 AndAlso PlayerCount() <= 0 Then
                LoseBattle()
            End If
        End Sub

        Private Sub FrmRaid_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
            FrmGuild.Show()
        End Sub

    End Class

End Namespace