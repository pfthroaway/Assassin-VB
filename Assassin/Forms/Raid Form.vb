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
        Dim _plrHench As New Henchman            'player's henchmen
        Dim _eneHench As New Henchman            'enemy's henchmen

        Private Function CheckPlrMax() As Integer
            '* * * * *
            '* This function determines the highest level of henchmen the player has.
            '* * * * *

            If _plrHench.HenchmenLevel5 > 0 Then
                _plrHench.Number = _plrHench.HenchmenLevel5
                Return 5
            ElseIf _plrHench.HenchmenLevel4 > 0 Then
                _plrHench.Number = _plrHench.HenchmenLevel4
                Return 4
            ElseIf _plrHench.HenchmenLevel3 > 0 Then
                _plrHench.Number = _plrHench.HenchmenLevel3
                Return 3
            ElseIf _plrHench.HenchmenLevel2 > 0 Then
                _plrHench.Number = _plrHench.HenchmenLevel2
                Return 2
            ElseIf _plrHench.HenchmenLevel1 > 0 Then
                _plrHench.Number = _plrHench.HenchmenLevel1
                Return 1
            Else
                Return 0
            End If
        End Function

        Private Function CheckEneMax() As Integer
            '* * * * *
            '* This function determines the highest level of henchmen the enemy has.
            '* * * * *

            If _eneHench.HenchmenLevel5 > 0 Then
                _eneHench.Number = _plrHench.HenchmenLevel5
                Return 5
            ElseIf _eneHench.HenchmenLevel4 > 0 Then
                _eneHench.Number = _plrHench.HenchmenLevel4
                Return 4
            ElseIf _eneHench.HenchmenLevel3 > 0 Then
                _eneHench.Number = _plrHench.HenchmenLevel3
                Return 3
            ElseIf _eneHench.HenchmenLevel2 > 0 Then
                _eneHench.Number = _plrHench.HenchmenLevel2
                Return 2
            ElseIf _eneHench.HenchmenLevel1 > 0 Then
                _eneHench.Number = _plrHench.HenchmenLevel1
                Return 1
            Else
                Return 0
            End If
        End Function

        Private Function DecHench(hench As Henchman) As Henchman
            '* * * * *
            '* This method decrements the henchman at that level.
            '* * * * *

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

        Private Function EneCount() As Integer
            '* * * * *
            '* This function determines the number of henchmen the enemy has at that level.
            '* * * * *

            Return (_eneHench.HenchmenLevel1 + _eneHench.HenchmenLevel2 + _eneHench.HenchmenLevel3 + _eneHench.HenchmenLevel4 + _eneHench.HenchmenLevel5)
        End Function

        Private Function PlrCount() As Integer
            '* * * * *
            '* This function determines the number of henchmen the player has at that level.
            '* * * * *

            Return (_plrHench.HenchmenLevel1 + _plrHench.HenchmenLevel2 + _plrHench.HenchmenLevel3 + _plrHench.HenchmenLevel4 + _plrHench.HenchmenLevel5)
        End Function

        Public Sub AddText(newText As String)
            AddTextToTextBox(TxtRaid, newText)
        End Sub

        Private Sub Battle()
            '* * * * *
            '* This method handles raiding.
            '* * * * *

            While _plrHench.Number > 0 AndAlso _eneHench.Number > 0
                Dim first As Integer = Functions.GenerateRandomNumber(1, 100)
                If first <= 50 Then
                    PlayerAtt()
                    If _eneHench.Number > 0 Then
                        EnemyAtt()
                    End If
                Else
                    EnemyAtt()
                    If _plrHench.Number > 0 Then
                        PlayerAtt()
                    End If
                End If
            End While

        End Sub

        Private Sub CheckRaid()
            '* * * * *
            '* This method checks whether you can click the Raid button
            '* * * * *

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

                If (henchmenLevel1 + henchmenLevel2 + henchmenLevel3 + henchmenLevel4 + henchmenLevel5) > 0 AndAlso CmbRaid.SelectedIndex >= 0 Then
                    BtnRaid.Enabled = True
                Else
                    BtnRaid.Enabled = False
                End If
            ElseIf CmbRaid.SelectedIndex = 1 Then
                MessageBox.Show("You cannot raid The Master's Tavern.", "Assassin", MessageBoxButtons.OK)
                BtnRaid.Enabled = False
            ElseIf CmbRaid.SelectedIndex = CurrentGuild.ID Then
                MessageBox.Show("You cannot raid the guild you are currently in.", "Assassin", MessageBoxButtons.OK)
                BtnRaid.Enabled = False
            End If
        End Sub

        Private Sub DisableButtons()
            '* * * * *
            '* This method disables everything except the Back button.
            '* * * * *

            CmbRaid.Enabled = False
            BtnRaid.Enabled = False
            BtnClear.Enabled = False
            TxtHenchmenLevel1.Enabled = False
            TxtHenchmenLevel2.Enabled = False
            TxtHenchmenLevel3.Enabled = False
            TxtHenchmenLevel4.Enabled = False
            TxtHenchmenLevel5.Enabled = False
        End Sub

        Private Sub EnemyAtt()
            '* * * * *
            '* This method handles the enemy's henchman attacking.
            '* * * * *

            Dim toHit As Integer = Functions.GenerateRandomNumber(1, 100)             'random number for enemy to hit
            Dim plrBlock As Integer = Functions.GenerateRandomNumber(1, 100)          'random number for player to block

            If toHit <= _plrHench.WeaponSkill Then                         'potential to hit
                If plrBlock >= _plrHench.Blocking Then               'player didn't block
                    _plrHench.Health -= _eneHench.Damage              'player loses health
                    If _plrHench.Health <= 0 Then                    'if player has no health
                        _plrHench = DecHench(_plrHench)
                        If _plrHench.Number > 0 Then                 'if player still has members
                            _plrHench.Health = _plrHench.Level * 2    'set health to max
                        End If
                    End If
                End If
            End If
        End Sub

        Public Sub LoadRaid()
            '* * * * *
            '* This method loads all the information on the form.
            '* * * * *

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

        Private Sub LoseBattle()
            '* * * * *
            '* This method handles the player failing the raiding.
            '* * * * *

            AddText("You failed to raid the " & CmbRaid.SelectedItem.ToString & ".")
            CmbRaid.Enabled = False
            BtnRaid.Enabled = False
            BtnClear.Enabled = False

        End Sub

        Private Sub PlayerAtt()
            '* * * * *
            '* This method handles the player's henchman attacking.
            '* * * * *

            Dim toHit As Integer = Functions.GenerateRandomNumber(1, 100)             'random number for player to hit
            Dim eneBlock As Integer = Functions.GenerateRandomNumber(1, 100)          'random number for enemy to block

            If toHit <= _plrHench.WeaponSkill Then                         'potential to hit
                If eneBlock >= _eneHench.Blocking Then               'enemy didn't block
                    _eneHench.Health -= _plrHench.Damage              'enemy loses health
                    If _eneHench.Health <= 0 Then                    'if enemy has no health
                        DecHench(_eneHench)
                        If _eneHench.Number > 0 Then                 'if enemy still has members
                            _eneHench.Health = _eneHench.Level * 2    'set health to max
                        End If
                    End If
                End If
            End If
        End Sub

        Private Sub SetHenchmen()
            '* * * * *
            '* This method sets the number of henchmen for both parties.
            '* * * * *

            _plrHench.HenchmenLevel1 = CurrentUser.HenchmenLevel1
            _plrHench.HenchmenLevel2 = CurrentUser.HenchmenLevel2
            _plrHench.HenchmenLevel3 = CurrentUser.HenchmenLevel3
            _plrHench.HenchmenLevel4 = CurrentUser.HenchmenLevel4
            _plrHench.HenchmenLevel5 = CurrentUser.HenchmenLevel5

            _eneHench.HenchmenLevel1 = _raidGuild.HenchmenLevel1
            _eneHench.HenchmenLevel2 = _raidGuild.HenchmenLevel2
            _eneHench.HenchmenLevel3 = _raidGuild.HenchmenLevel3
            _eneHench.HenchmenLevel4 = _raidGuild.HenchmenLevel4
            _eneHench.HenchmenLevel5 = _raidGuild.HenchmenLevel5
        End Sub

        Private Async Sub Winbattle()
            '* * * * *
            '* This method handles the player successfully raiding.
            '* * * * *

            Dim number As Integer = PlrCount()
            Dim maxgold As Integer
            Dim stolenGold As Integer

            If CmbRaid.SelectedItem.ToString <> "Bank" Then
                maxgold = _raidGuild.Gold
                If (number * 100) <= _raidGuild.Gold Then
                    stolenGold = number * 100
                Else
                    stolenGold = maxgold
                End If

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

            CurrentUser.HenchmenLevel1 = _plrHench.HenchmenLevel1
            CurrentUser.HenchmenLevel2 = _plrHench.HenchmenLevel2
            CurrentUser.HenchmenLevel3 = _plrHench.HenchmenLevel3
            CurrentUser.HenchmenLevel4 = _plrHench.HenchmenLevel4
            CurrentUser.HenchmenLevel5 = _plrHench.HenchmenLevel5

            AddText("You have won the battle! Your " & number & " remaining henchmen make off with " & stolenGold & " gold.")
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

        Private Sub HenchKeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtHenchmenLevel1.KeyPress, TxtHenchmenLevel2.KeyPress,
                                                                                                         TxtHenchmenLevel3.KeyPress, TxtHenchmenLevel4.KeyPress, TxtHenchmenLevel5.KeyPress
            '* * * * *
            '* This method only allows numbers to be entered into the Textboxes on the form.
            '* * * * *

            If Char.IsDigit(e.KeyChar) OrElse e.KeyChar Like Chr(8) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End Sub

        Private Sub CmbRaid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbRaid.SelectedIndexChanged
            '* * * * *
            '* This method checks whether you can click the Raid button
            '* * * * *

            CheckRaid()
        End Sub

        Private Sub TxtHenchmenLevel1_TextChanged(sender As Object, e As EventArgs) Handles TxtHenchmenLevel1.TextChanged
            '* * * * *
            '* This method checks whether you can click the Raid button after text changed.
            '* * * * *

            Dim currHench As Integer
            Integer.TryParse(TxtHenchmenLevel1.Text, currHench)
            If currHench > CurrentUser.HenchmenLevel1 Then
                TxtHenchmenLevel1.Text = ""
            End If

            CheckRaid()
        End Sub

        Private Sub TxtHenchmenLevel2_TextChanged(sender As Object, e As EventArgs) Handles TxtHenchmenLevel2.TextChanged
            '* * * * *
            '* This method checks whether you can click the Raid button after text changed.
            '* * * * *

            Dim currHench As Integer
            Integer.TryParse(TxtHenchmenLevel2.Text, currHench)
            If currHench > CurrentUser.HenchmenLevel2 Then
                TxtHenchmenLevel2.Text = ""
            End If

            CheckRaid()
        End Sub

        Private Sub TxtHenchmenLevel3_TextChanged(sender As Object, e As EventArgs) Handles TxtHenchmenLevel3.TextChanged
            '* * * * *
            '* This method checks whether you can click the Raid button after text changed.
            '* * * * *

            Dim currHench As Integer
            Integer.TryParse(TxtHenchmenLevel3.Text, currHench)
            If currHench > CurrentUser.HenchmenLevel3 Then
                TxtHenchmenLevel3.Text = ""
            End If

            CheckRaid()
        End Sub

        Private Sub TxtHenchmenLevel4_TextChanged(sender As Object, e As EventArgs) Handles TxtHenchmenLevel4.TextChanged
            '* * * * *
            '* This method checks whether you can click the Raid button after text changed.
            '* * * * *

            Dim currHench As Integer
            Integer.TryParse(TxtHenchmenLevel4.Text, currHench)
            If currHench > CurrentUser.HenchmenLevel4 Then
                TxtHenchmenLevel4.Text = ""
            End If

            CheckRaid()
        End Sub

        Private Sub TxtHenchmenLevel5_TextChanged(sender As Object, e As EventArgs) Handles TxtHenchmenLevel5.TextChanged
            '* * * * *
            '* This method checks whether you can click the Raid button after text changed.
            '* * * * *

            Dim currHench As Integer
            Integer.TryParse(TxtHenchmenLevel5.Text, currHench)
            If currHench > CurrentUser.HenchmenLevel5 Then
                TxtHenchmenLevel5.Text = ""
            End If

            CheckRaid()
        End Sub

        Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
            '* * * * *
            '* This method closes the form on clicking the Back button.
            '* * * * *

            Me.Close()
        End Sub

        Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
            '* * * * *
            '* This method clears everything on the form.
            '* * * * *

            CmbRaid.SelectedIndex = -1

            TxtHenchmenLevel1.Text = ""
            TxtHenchmenLevel2.Text = ""
            TxtHenchmenLevel3.Text = ""
            TxtHenchmenLevel4.Text = ""
            TxtHenchmenLevel5.Text = ""

            BtnRaid.Enabled = False
        End Sub

        Private Sub BtnRaid_Click(sender As Object, e As EventArgs) Handles BtnRaid.Click
            '* * * * *
            '* This method handles clicking the Raid button.
            '* * * * *

            If CmbRaid.SelectedItem.ToString <> "Bank" Then
                _raidGuild = AllGuilds(CmbRaid.SelectedIndex - 1)

                SetHenchmen()
                Dim round As Integer = 1

                While PlrCount() > 0 AndAlso EneCount() > 0
                    _plrHench.Level = CheckPlrMax()
                    Select Case _plrHench.Level
                        Case 5
                            _plrHench.Number = _plrHench.HenchmenLevel5
                        Case 4
                            _plrHench.Number = _plrHench.HenchmenLevel4
                        Case 3
                            _plrHench.Number = _plrHench.HenchmenLevel3
                        Case 2
                            _plrHench.Number = _plrHench.HenchmenLevel2
                        Case 1
                            _plrHench.Number = _plrHench.HenchmenLevel1
                    End Select
                    _eneHench.Level = CheckEneMax()
                    Select Case _eneHench.Level
                        Case 5
                            _eneHench.Number = _eneHench.HenchmenLevel5
                        Case 4
                            _eneHench.Number = _eneHench.HenchmenLevel4
                        Case 3
                            _eneHench.Number = _eneHench.HenchmenLevel3
                        Case 2
                            _eneHench.Number = _eneHench.HenchmenLevel2
                        Case 1
                            _eneHench.Number = _eneHench.HenchmenLevel1
                    End Select

                    AddText("You begin Round " & round & " with " & _plrHench.Number & " Level " & _plrHench.Level &
                            " Henchmen. Your opponent begins the round with " & _eneHench.Number & " Level " & _eneHench.Level & " Henchmen.")

                    Battle()

                    AddText("You end Round " & round & " with " & _plrHench.Number & " Level " & _plrHench.Level &
                            " Henchmen. Your opponent ends the round with " & _eneHench.Number & " Level " & _eneHench.Level & " Henchmen.")

                    round += 1
                End While
            End If

            If PlrCount() > 0 AndAlso EneCount() <= 0 Then
                Winbattle()
            ElseIf EneCount() > 0 AndAlso PlrCount() <= 0 Then
                LoseBattle()
            End If
        End Sub

        Private Sub FrmRaid_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
            '* * * * *
            '* This method handles the form closing.
            '* * * * *

            FrmGuild.Show()
        End Sub

    End Class

End Namespace