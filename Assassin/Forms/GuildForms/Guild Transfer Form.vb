' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 10/11/2012
' Filename        : Guild Transfer Form.vb
' Description     : This form allows a guildmaster to transfer henchmen and gold to and from their guild.

Option Strict On
Option Explicit On

Imports Assassin.Classes

Namespace Forms.GuildForms

    Public Class FrmGuildTransfer

        Dim _nl As String = ControlChars.NewLine 'new line
        Dim _henchmenLevel1 As Integer                   'level1 henchmen to donate
        Dim _henchmenLevel2 As Integer                   'level2 henchmen to donate
        Dim _henchmenLevel3 As Integer                   'level3 henchmen to donate
        Dim _henchmenLevel4 As Integer                   'level4 henchmen to donate
        Dim _henchmenLevel5 As Integer                   'level5 henchmen to donate
        Dim _gold As Integer                     'gold to donate

        Private Sub AddText(newText As String)
            '* * * * *
            '* This method adds text to the Textbox.
            '* * * * *

            Dim currText As String = TxtTransfer.Text
            TxtTransfer.Clear()

            TxtTransfer.Text = newText & _nl & _nl & currText
            TxtTransfer.Select(0, 0)
            TxtTransfer.ScrollToCaret()
        End Sub

        Private Sub CheckTransfer()
            '* * * * *
            '* This method checks whether a transfer is viable.
            '* * * * *

            If (_henchmenLevel1 + _henchmenLevel2 + _henchmenLevel3 + _henchmenLevel4 + _henchmenLevel5 + _gold) > 0 Then
                BtnTransfer.Enabled = True
                BtnClear.Enabled = True
            Else
                BtnTransfer.Enabled = False
                BtnClear.Enabled = False
            End If
        End Sub

        Private Sub Clear()
            '* * * * *
            '* This method clears everything on the form.
            '* * * * *

            TxtTransfer1.Clear()
            TxtTransfer2.Clear()
            TxtTransfer3.Clear()
            TxtTransfer4.Clear()
            TxtTransfer5.Clear()
            TxtTransferGold.Clear()

            BtnTransfer.Enabled = False
            BtnClear.Enabled = False
        End Sub

        Private Sub Display()
            '* * * * *
            '* This method displays information on the form.
            '* * * * *

            TxtGuild1.Text = CurrentGuild.HenchmenLevel1.ToString("N0")
            TxtGuild2.Text = CurrentGuild.HenchmenLevel2.ToString("N0")
            TxtGuild3.Text = CurrentGuild.HenchmenLevel3.ToString("N0")
            TxtGuild4.Text = CurrentGuild.HenchmenLevel4.ToString("N0")
            TxtGuild5.Text = CurrentGuild.HenchmenLevel5.ToString("N0")
            TxtGuildGold.Text = CurrentGuild.Gold.ToString("N0")

            TxtCurrent1.Text = CurrentUser.HenchmenLevel1.ToString("N0")
            TxtCurrent2.Text = CurrentUser.HenchmenLevel2.ToString("N0")
            TxtCurrent3.Text = CurrentUser.HenchmenLevel3.ToString("N0")
            TxtCurrent4.Text = CurrentUser.HenchmenLevel4.ToString("N0")
            TxtCurrent5.Text = CurrentUser.HenchmenLevel5.ToString("N0")
            TxtCurrentGold.Text = CurrentUser.GoldOnHand.ToString("N0")

            CheckTransfer()
        End Sub

        Public Sub LoadTransfer()
            '* * * * *
            '* This method loads all the important information on the form.
            '* * * * *

            Display()
        End Sub

        Private Async Sub Transfer()
            '* * * * *
            '* This method transfers everything.
            '* * * * *

            If radGuild.Checked = True Then
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
            ElseIf radPlayer.Checked = True Then
                CurrentUser.HenchmenLevel1 += _henchmenLevel1
                CurrentUser.HenchmenLevel2 += _henchmenLevel2
                CurrentUser.HenchmenLevel3 += _henchmenLevel3
                CurrentUser.HenchmenLevel4 += _henchmenLevel4
                CurrentUser.HenchmenLevel5 += _henchmenLevel5
                CurrentUser.GoldOnHand += _gold

                CurrentGuild.HenchmenLevel1 -= _henchmenLevel1
                CurrentGuild.HenchmenLevel2 -= _henchmenLevel2
                CurrentGuild.HenchmenLevel3 -= _henchmenLevel3
                CurrentGuild.HenchmenLevel4 -= _henchmenLevel4
                CurrentGuild.HenchmenLevel5 -= _henchmenLevel5
                CurrentGuild.Gold -= _gold
            End If

            Await SaveUser(CurrentUser)
            Await SaveGuild(CurrentGuild)
            MessageBox.Show("Transfer successful.", "Assassin", MessageBoxButtons.OK)
            TransferText()
            Clear()
            Display()
        End Sub

        Private Sub TransferText()
            '* * * * *
            '* This method handles adding text to the Textbox based on who was donated.
            '* * * * *

            Dim textDonate As String = "You transfer "

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

        Private Sub TransferKeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTransfer1.KeyPress, TxtTransfer2.KeyPress, TxtTransfer3.KeyPress, TxtTransfer4.KeyPress, TxtTransfer5.KeyPress, TxtTransferGold.KeyPress
            '* * * * *
            '* This method handles KeyPresses for all editable fields.
            '* * * * *

            e.Handled = Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar Like Chr(8)
        End Sub

        Private Sub TxtTransfer1_TextChanged(sender As Object, e As EventArgs) Handles TxtTransfer1.TextChanged
            '* * * * *
            '* This method handles the TextBox's text being chnaged.
            '* * * * *

            Integer.TryParse(TxtTransfer1.Text, _henchmenLevel1)

            If radGuild.Checked = True Then
                If _henchmenLevel1 <= CurrentUser.HenchmenLevel1 Then
                    CheckTransfer()
                Else
                    _henchmenLevel1 = 0
                    TxtTransfer1.Clear()
                End If
            ElseIf radPlayer.Checked = True Then
                If _henchmenLevel1 <= CurrentGuild.HenchmenLevel1 Then
                    CheckTransfer()
                Else
                    _henchmenLevel1 = 0
                    TxtTransfer1.Clear()
                End If
            End If
        End Sub

        Private Sub TxtTransfer2_TextChanged(sender As Object, e As EventArgs) Handles TxtTransfer2.TextChanged
            '* * * * *
            '* This method handles the TextBox's text being chnaged.
            '* * * * *

            Integer.TryParse(TxtTransfer2.Text, _henchmenLevel2)

            If radGuild.Checked = True Then
                If _henchmenLevel2 <= CurrentUser.HenchmenLevel2 Then
                    CheckTransfer()
                Else
                    _henchmenLevel2 = 0
                    TxtTransfer2.Clear()
                End If
            ElseIf radPlayer.Checked = True Then
                If _henchmenLevel2 <= CurrentGuild.HenchmenLevel2 Then
                    CheckTransfer()
                Else
                    _henchmenLevel2 = 0
                    TxtTransfer2.Clear()
                End If
            End If
        End Sub

        Private Sub TxtTransfer3_TextChanged(sender As Object, e As EventArgs) Handles TxtTransfer3.TextChanged
            '* * * * *
            '* This method handles the TextBox's text being chnaged.
            '* * * * *

            Integer.TryParse(TxtTransfer3.Text, _henchmenLevel3)

            If radGuild.Checked = True Then
                If _henchmenLevel3 <= CurrentUser.HenchmenLevel3 Then
                    CheckTransfer()
                Else
                    _henchmenLevel3 = 0
                    TxtTransfer3.Clear()
                End If
            ElseIf radPlayer.Checked = True Then
                If _henchmenLevel3 <= CurrentGuild.HenchmenLevel3 Then
                    CheckTransfer()
                Else
                    _henchmenLevel3 = 0
                    TxtTransfer3.Clear()
                End If
            End If
        End Sub

        Private Sub TxtTransfer4_TextChanged(sender As Object, e As EventArgs) Handles TxtTransfer4.TextChanged
            '* * * * *
            '* This method handles the TextBox's text being chnaged.
            '* * * * *

            Integer.TryParse(TxtTransfer4.Text, _henchmenLevel4)

            If radGuild.Checked = True Then
                If _henchmenLevel4 <= CurrentUser.HenchmenLevel4 Then
                    CheckTransfer()
                Else
                    _henchmenLevel4 = 0
                    TxtTransfer4.Clear()
                End If
            ElseIf radPlayer.Checked = True Then
                If _henchmenLevel4 <= CurrentGuild.HenchmenLevel4 Then
                    CheckTransfer()
                Else
                    _henchmenLevel4 = 0
                    TxtTransfer4.Clear()
                End If
            End If
        End Sub

        Private Sub TxtTransfer5_TextChanged(sender As Object, e As EventArgs) Handles TxtTransfer5.TextChanged
            '* * * * *
            '* This method handles the TextBox's text being chnaged.
            '* * * * *

            Integer.TryParse(TxtTransfer5.Text, _henchmenLevel5)

            If radGuild.Checked = True Then
                If _henchmenLevel5 <= CurrentUser.HenchmenLevel5 Then
                    CheckTransfer()
                Else
                    _henchmenLevel5 = 0
                    TxtTransfer5.Clear()
                End If
            ElseIf radPlayer.Checked = True Then
                If _henchmenLevel5 <= CurrentGuild.HenchmenLevel5 Then
                    CheckTransfer()
                Else
                    _henchmenLevel5 = 0
                    TxtTransfer5.Clear()
                End If
            End If
        End Sub

        Private Sub TxtTransferGold_TextChanged(sender As Object, e As EventArgs) Handles TxtTransferGold.TextChanged
            '* * * * *
            '* This method handles the TextBox's text being chnaged.
            '* * * * *

            Integer.TryParse(TxtTransferGold.Text, _gold)

            If radGuild.Checked = True Then
                If _gold <= CurrentUser.GoldOnHand Then
                    CheckTransfer()
                Else
                    _gold = 0
                    TxtTransferGold.Clear()
                End If
            ElseIf radPlayer.Checked = True Then
                If _gold <= CurrentGuild.Gold Then
                    CheckTransfer()
                Else
                    _gold = 0
                    TxtTransferGold.Clear()
                End If
            End If
        End Sub

        Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
            '* * * * *
            '* This method closes the form on clicking the Back button.
            '* * * * *

            Close()
        End Sub

        Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
            '* * * * *
            '* This method clears everything on the form.
            '* * * * *

            Clear()
        End Sub

        Private Sub BtnTransfer_Click(sender As Object, e As EventArgs) Handles BtnTransfer.Click
            '* * * * *
            '* This method transfers everything.
            '* * * * *

            Transfer()
        End Sub

        Private Sub FrmGuildTransfer_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
            '* * * * *
            '* This method handles the form closing.
            '* * * * *

            FrmGuildManage.Show()
        End Sub

        Private Sub pctHelp_Click(sender As Object, e As EventArgs) Handles pctHelp.Click
            '* * * * *
            '* This method handles clicking the Question Mark picture.
            '* * * * *

            FrmHelp.Show()
            FrmHelp.loc = "Guild Transfer"
            FrmHelp.Display()
        End Sub

        Private Sub pctHelp_MouseHover(sender As Object, e As EventArgs) Handles pctHelp.MouseHover
            '* * * * *
            '* This method handles the mouse hovering over the Question Mark icon.
            '* * * * *

            Dim cur As Cursor = Cursors.Hand
            Cursor = cur
        End Sub

        Private Sub pctHelp_MouseLeave(sender As Object, e As EventArgs) Handles pctHelp.MouseLeave
            '* * * * *
            '* This method handles the mouse leaving the Question Mark icon.
            '* * * * *

            Dim cur As Cursor = Cursors.Default
            Cursor = cur
        End Sub

    End Class

End Namespace