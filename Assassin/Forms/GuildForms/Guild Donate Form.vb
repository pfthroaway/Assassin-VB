Option Strict On
Option Explicit On

Imports Assassin.Classes

Namespace Forms.GuildForms

    Public Class FrmGuildDonate
        Dim _henchmenLevel1 As Integer                   'level1 henchmen to donate
        Dim _henchmenLevel2 As Integer                   'level2 henchmen to donate
        Dim _henchmenLevel3 As Integer                   'level3 henchmen to donate
        Dim _henchmenLevel4 As Integer                   'level4 henchmen to donate
        Dim _henchmenLevel5 As Integer                   'level5 henchmen to donate
        Dim _gold As Integer                     'gold to donate

        ''' <summary>Add text to the TextBox.</summary>
        ''' <param name="newText">Text to be added</param>
        Private Sub AddText(newText As String)
            AddTextToTextBox(TxtDonate, newText)
        End Sub

        ''' <summary>checks whether the donate button should be enabled.</summary>
        Private Sub CheckDonate()
            If (_henchmenLevel1 + _henchmenLevel2 + _henchmenLevel3 + _henchmenLevel4 + _henchmenLevel5 + _gold) > 0 Then
                BtnDonate.Enabled = True
                BtnClear.Enabled = True
            Else
                BtnDonate.Enabled = False
                BtnClear.Enabled = False
            End If
        End Sub

        ''' <summary>Clears all information on the form.</summary>
        Private Sub Clear()
            TxtDonate1.Clear()
            TxtDonate2.Clear()
            TxtDonate3.Clear()
            TxtDonate4.Clear()
            TxtDonate5.Clear()
            TxtDonateGold.Clear()

            BtnClear.Enabled = False
            BtnDonate.Enabled = False

            Display()
        End Sub

        ''' <summary>Displays all important information on the form.</summary>
        Private Sub Display()
            TxtHenchmenLevel1.Text = CurrentUser.HenchmenLevel1.ToString("N0")
            TxtHenchmenLevel2.Text = CurrentUser.HenchmenLevel2.ToString("N0")
            TxtHenchmenLevel3.Text = CurrentUser.HenchmenLevel3.ToString("N0")
            TxtHenchmenLevel4.Text = CurrentUser.HenchmenLevel4.ToString("N0")
            TxtHenchmenLevel5.Text = CurrentUser.HenchmenLevel5.ToString("N0")
            TxtGold.Text = CurrentUser.GoldOnHandToString

            TxtDonate1.Enabled = CurrentUser.HenchmenLevel1 > 0
            TxtDonate2.Enabled = CurrentUser.HenchmenLevel2 > 0
            TxtDonate3.Enabled = CurrentUser.HenchmenLevel3 > 0
            TxtDonate4.Enabled = CurrentUser.HenchmenLevel4 > 0
            TxtDonate5.Enabled = CurrentUser.HenchmenLevel5 > 0
            TxtDonateGold.Enabled = CurrentUser.GoldOnHand > 0
        End Sub

        ''' <summary>Handles donating.</summary>
        Private Async Sub Donate()
            CurrentGuild.HenchmenLevel1 += _henchmenLevel1
            CurrentGuild.HenchmenLevel2 += _henchmenLevel2
            CurrentGuild.HenchmenLevel3 += _henchmenLevel3
            CurrentGuild.HenchmenLevel4 += _henchmenLevel4
            CurrentGuild.HenchmenLevel5 += _henchmenLevel5
            CurrentGuild.Gold += _gold

            CurrentUser.HenchmenLevel1 -= _henchmenLevel1
            CurrentUser.HenchmenLevel2 -= _henchmenLevel2
            CurrentUser.HenchmenLevel3 -= _henchmenLevel3
            CurrentUser.HenchmenLevel4 -= _henchmenLevel4
            CurrentUser.HenchmenLevel5 -= _henchmenLevel5
            CurrentUser.GoldOnHand -= _gold

            DonateText()
            If _gold > 0 Then
                AddText($"You donate {_gold} gold.")
            End If

            Await SaveUser(CurrentUser)
            Await SaveGuild(CurrentGuild)
            Clear()
        End Sub

        ''' <summary>Handles adding text to the Textbox based on who was donated.</summary>
        Private Sub DonateText()
            Dim textDonate As String = "You donate "

            If _henchmenLevel1 > 0 Then
                If (_henchmenLevel2 + _henchmenLevel3 + _henchmenLevel4 + _henchmenLevel5) > 0 Then
                    textDonate += _henchmenLevel1 & " Level 1 Henchmen, "
                Else
                    textDonate += _henchmenLevel1 & " Level 1 Henchmen."
                End If
            End If

            If _henchmenLevel2 > 0 Then
                If (_henchmenLevel3 + _henchmenLevel4 + _henchmenLevel5) > 0 Then
                    textDonate += _henchmenLevel2 & " Level 2 Henchmen, "
                ElseIf _henchmenLevel1 > 0 Then
                    textDonate += "and " & _henchmenLevel2 & " Level 2 Henchmen."
                Else
                    textDonate += _henchmenLevel2 & " Level 2 Henchmen."
                End If
            End If

            If _henchmenLevel3 > 0 Then
                If (_henchmenLevel4 + _henchmenLevel5) > 0 Then
                    textDonate += _henchmenLevel2 & " Level 3 Henchmen, "
                ElseIf (_henchmenLevel1 + _henchmenLevel2) > 0 Then
                    textDonate += "and " & _henchmenLevel3 & " Level 3 Henchmen."
                Else
                    textDonate += _henchmenLevel3 & " Level 3 Henchmen."
                End If
            End If

            If _henchmenLevel4 > 0 Then
                If _henchmenLevel5 > 0 Then
                    textDonate += _henchmenLevel4 & " Level 4 Henchmen, "
                ElseIf (_henchmenLevel1 + _henchmenLevel2 + _henchmenLevel3) > 0 Then
                    textDonate += "and " & _henchmenLevel4 & " Level 4 Henchmen."
                Else
                    textDonate += _henchmenLevel4 & " Level 4 Henchmen."
                End If
            End If

            If _henchmenLevel5 > 0 Then
                If (_henchmenLevel1 + _henchmenLevel2 + _henchmenLevel3 + _henchmenLevel4) > 0 Then
                    textDonate += "and " & _henchmenLevel5 & " Level 5 Henchmen."
                Else
                    textDonate += _henchmenLevel5 & " Level 5 Henchmen."
                End If
            End If

            AddText(textDonate)
        End Sub

        ''' <summary>Loads all the information needed to donate.</summary>
        Public Sub LoadDonate()
            LblDonate.Text = "Donate to " & CurrentGuild.Name
            Display()
        End Sub

#Region "Click"

        Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
            Close()
        End Sub

        Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
            Clear()
        End Sub

        Private Sub BtnDonate_Click(sender As Object, e As EventArgs) Handles BtnDonate.Click
            Donate()
        End Sub

#End Region

#Region "Form Manipulation"

        Private Sub DonateKeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDonate1.KeyPress, TxtDonate2.KeyPress, TxtDonate3.KeyPress, TxtDonate4.KeyPress, TxtDonate5.KeyPress, TxtDonateGold.KeyPress
            e.Handled = Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar Like Chr(8))
        End Sub

        Private Sub TxtDonate1_TextChanged(sender As Object, e As EventArgs) Handles TxtDonate1.TextChanged
            Integer.TryParse(TxtDonate1.Text.Trim(), _henchmenLevel1)

            If _henchmenLevel1 <= CurrentUser.HenchmenLevel1 Then
                CheckDonate()
            Else
                _henchmenLevel1 = 0
                TxtDonate1.Clear()
            End If
        End Sub

        Private Sub TxtDonate2_TextChanged(sender As Object, e As EventArgs) Handles TxtDonate2.TextChanged
            Integer.TryParse(TxtDonate1.Text.Trim(), _henchmenLevel2)

            If _henchmenLevel2 <= CurrentUser.HenchmenLevel2 Then
                CheckDonate()
            Else
                _henchmenLevel2 = 0
                TxtDonate2.Clear()
            End If
        End Sub

        Private Sub TxtDonate3_TextChanged(sender As Object, e As EventArgs) Handles TxtDonate3.TextChanged
            Integer.TryParse(TxtDonate1.Text.Trim(), _henchmenLevel3)

            If _henchmenLevel3 <= CurrentUser.HenchmenLevel3 Then
                CheckDonate()
            Else
                _henchmenLevel3 = 0
                TxtDonate3.Clear()
            End If
        End Sub

        Private Sub TxtDonate4_TextChanged(sender As Object, e As EventArgs) Handles TxtDonate4.TextChanged
            Integer.TryParse(TxtDonate1.Text.Trim(), _henchmenLevel4)

            If _henchmenLevel4 <= CurrentUser.HenchmenLevel4 Then
                CheckDonate()
            Else
                _henchmenLevel4 = 0
                TxtDonate4.Clear()
            End If
        End Sub

        Private Sub TxtDonate5_TextChanged(sender As Object, e As EventArgs) Handles TxtDonate5.TextChanged
            Integer.TryParse(TxtDonate5.Text.Trim(), _henchmenLevel1)

            If _henchmenLevel5 <= CurrentUser.HenchmenLevel5 Then
                CheckDonate()
            Else
                _henchmenLevel5 = 0
                TxtDonate5.Clear()
            End If
        End Sub

        Private Sub TxtDonateGold_TextChanged(sender As Object, e As EventArgs) Handles TxtDonateGold.TextChanged
            Integer.TryParse(TxtDonateGold.Text.Trim(), _gold)

            If _gold <= CurrentUser.GoldOnHand Then
                CheckDonate()
            Else
                _gold = 0
                TxtDonateGold.Clear()
            End If
        End Sub

        Private Sub FrmGuildDonate_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
            FrmGuild.Show()
            FrmGuild.AddText(TxtDonate.Text.Trim())
        End Sub

#End Region

    End Class

End Namespace