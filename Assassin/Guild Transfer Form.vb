' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 10/11/2012
' Filename        : Guild Transfer Form.vb
' Description     : This form allows a guildmaster to transfer henchmen and gold to and from their guild.

Option Strict On
Option Explicit On

Public Class frmGuildTransfer
    Dim funcs As New Functions              'new Functions instance
    Public currUser As New User             'current user
    Public currGuild As New Guild           'current guild
    Dim nl As String = ControlChars.NewLine 'new line
    Dim hench1 As Integer                   'level1 henchmen to donate
    Dim hench2 As Integer                   'level2 henchmen to donate
    Dim hench3 As Integer                   'level3 henchmen to donate
    Dim hench4 As Integer                   'level4 henchmen to donate
    Dim hench5 As Integer                   'level5 henchmen to donate
    Dim gold As Integer                     'gold to donate

    Private Sub addText(ByVal newText As String)
        '* * * * *
        '* This method adds text to the Textbox.
        '* * * * *

        Dim currText As String = txtTransfer.Text
        txtTransfer.Clear()

        txtTransfer.Text = newText & nl & nl & currText
        txtTransfer.Select(0, 0)
        txtTransfer.ScrollToCaret()
    End Sub


    Private Sub checkTransfer()
        '* * * * *
        '* This method checks whether a transfer is viable.
        '* * * * *

        If (hench1 + hench2 + hench3 + hench4 + hench5 + gold) > 0 Then
            btnTransfer.Enabled = True
            btnClear.Enabled = True
        Else
            btnTransfer.Enabled = False
            btnClear.Enabled = False
        End If
    End Sub

    Private Sub clear()
        '* * * * *
        '* This method clears everything on the form.
        '* * * * *

        txtTransfer1.Clear()
        txtTransfer2.Clear()
        txtTransfer3.Clear()
        txtTransfer4.Clear()
        txtTransfer5.Clear()
        txtTransferGold.Clear()

        btnTransfer.Enabled = False
        btnClear.Enabled = False
    End Sub

    Private Sub display()
        '* * * * *
        '* This method displays information on the form.
        '* * * * *

        txtGuild1.Text = currGuild.hench1.ToString("N0")
        txtGuild2.Text = currGuild.hench2.ToString("N0")
        txtGuild3.Text = currGuild.hench3.ToString("N0")
        txtGuild4.Text = currGuild.hench4.ToString("N0")
        txtGuild5.Text = currGuild.hench5.ToString("N0")
        txtGuildGold.Text = currGuild.gold.ToString("N0")

        txtCurrent1.Text = currUser.hench1.ToString("N0")
        txtCurrent2.Text = currUser.hench2.ToString("N0")
        txtCurrent3.Text = currUser.hench3.ToString("N0")
        txtCurrent4.Text = currUser.hench4.ToString("N0")
        txtCurrent5.Text = currUser.hench5.ToString("N0")
        txtCurrentGold.Text = currUser.goldOnHand.ToString("N0")

        checkTransfer()
    End Sub

    Public Sub loadTransfer()
        '* * * * *
        '* This method loads all the important information on the form.
        '* * * * *

        display()
    End Sub

    Private Sub transfer()
        '* * * * *
        '* This method transfers everything.
        '* * * * *

        If radGuild.Checked = True Then
            currGuild.hench1 += hench1
            currGuild.hench2 += hench2
            currGuild.hench3 += hench3
            currGuild.hench4 += hench4
            currGuild.hench5 += hench5
            currGuild.gold += gold

            currUser.hench1 -= hench1
            currUser.hench2 -= hench2
            currUser.hench3 -= hench3
            currUser.hench4 -= hench4
            currUser.hench5 -= hench5
            currUser.goldOnHand -= gold
        ElseIf radPlayer.Checked = True Then
            currUser.hench1 += hench1
            currUser.hench2 += hench2
            currUser.hench3 += hench3
            currUser.hench4 += hench4
            currUser.hench5 += hench5
            currUser.goldOnHand += gold

            currGuild.hench1 -= hench1
            currGuild.hench2 -= hench2
            currGuild.hench3 -= hench3
            currGuild.hench4 -= hench4
            currGuild.hench5 -= hench5
            currGuild.gold -= gold
        End If

        funcs.save(currUser)
        funcs.saveGuild(currGuild)
        MessageBox.Show("Transfer successful.", "Assassin", MessageBoxButtons.OK)
        transferText()
        clear()
        display()
    End Sub

    Private Sub transferText()
        '* * * * *
        '* This method handles adding text to the Textbox based on who was donated.
        '* * * * *

        Dim textDonate As String = "You transfer "

        If hench1 > 0 Then
            If (hench2 + hench3 + hench4 + hench5) > 0 Then
                textDonate += hench1 & " Level 1 Henchmen, "
            Else
                textDonate += hench1 & " Level 1 Henchmen."
            End If
        End If

        If hench2 > 0 Then
            If (hench3 + hench4 + hench5) > 0 Then
                textDonate += hench2 & " Level 2 Henchmen, "
            ElseIf hench1 > 0 Then
                textDonate += "and " & hench2 & " Level 2 Henchmen."
            Else
                textDonate += hench2 & " Level 2 Henchmen."
            End If
        End If

        If hench3 > 0 Then
            If (hench4 + hench5) > 0 Then
                textDonate += hench2 & " Level 3 Henchmen, "
            ElseIf (hench1 + hench2) > 0 Then
                textDonate += "and " & hench3 & " Level 3 Henchmen."
            Else
                textDonate += hench3 & " Level 3 Henchmen."
            End If
        End If

        If hench4 > 0 Then
            If hench5 > 0 Then
                textDonate += hench4 & " Level 4 Henchmen, "
            ElseIf (hench1 + hench2 + hench3) > 0 Then
                textDonate += "and " & hench4 & " Level 4 Henchmen."
            Else
                textDonate += hench4 & " Level 4 Henchmen."
            End If
        End If

        If hench5 > 0 Then
            If (hench1 + hench2 + hench3 + hench4) > 0 Then
                textDonate += "and " & hench5 & " Level 5 Henchmen."
            Else
                textDonate += hench5 & " Level 5 Henchmen."
            End If
        End If

        addText(textDonate)
    End Sub

    Private Sub TransferKeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtTransfer1.KeyPress, txtTransfer2.KeyPress, txtTransfer3.KeyPress, txtTransfer4.KeyPress, txtTransfer5.KeyPress, txtTransferGold.KeyPress
        '* * * * *
        '* This method handles KeyPresses for all editable fields.
        '* * * * *

        If Char.IsDigit(e.KeyChar) OrElse e.KeyChar Like Chr(8) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtTransfer1_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtTransfer1.TextChanged
        '* * * * *
        '* This method handles the TextBox's text being chnaged.
        '* * * * *

        Integer.TryParse(txtTransfer1.Text, hench1)

        If radGuild.Checked = True Then
            If hench1 <= currUser.hench1 Then
                checkTransfer()
            Else
                hench1 = 0
                txtTransfer1.Clear()
            End If
        ElseIf radPlayer.Checked = True Then
            If hench1 <= currGuild.hench1 Then
                checkTransfer()
            Else
                hench1 = 0
                txtTransfer1.Clear()
            End If
        End If
    End Sub

    Private Sub txtTransfer2_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtTransfer2.TextChanged
        '* * * * *
        '* This method handles the TextBox's text being chnaged.
        '* * * * *

        Integer.TryParse(txtTransfer2.Text, hench2)

        If radGuild.Checked = True Then
            If hench2 <= currUser.hench2 Then
                checkTransfer()
            Else
                hench2 = 0
                txtTransfer2.Clear()
            End If
        ElseIf radPlayer.Checked = True Then
            If hench2 <= currGuild.hench2 Then
                checkTransfer()
            Else
                hench2 = 0
                txtTransfer2.Clear()
            End If
        End If
    End Sub

    Private Sub txtTransfer3_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtTransfer3.TextChanged
        '* * * * *
        '* This method handles the TextBox's text being chnaged.
        '* * * * *

        Integer.TryParse(txtTransfer3.Text, hench3)

        If radGuild.Checked = True Then
            If hench3 <= currUser.hench3 Then
                checkTransfer()
            Else
                hench3 = 0
                txtTransfer3.Clear()
            End If
        ElseIf radPlayer.Checked = True Then
            If hench3 <= currGuild.hench3 Then
                checkTransfer()
            Else
                hench3 = 0
                txtTransfer3.Clear()
            End If
        End If
    End Sub

    Private Sub txtTransfer4_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtTransfer4.TextChanged
        '* * * * *
        '* This method handles the TextBox's text being chnaged.
        '* * * * *

        Integer.TryParse(txtTransfer4.Text, hench4)

        If radGuild.Checked = True Then
            If hench4 <= currUser.hench4 Then
                checkTransfer()
            Else
                hench4 = 0
                txtTransfer4.Clear()
            End If
        ElseIf radPlayer.Checked = True Then
            If hench4 <= currGuild.hench4 Then
                checkTransfer()
            Else
                hench4 = 0
                txtTransfer4.Clear()
            End If
        End If
    End Sub

    Private Sub txtTransfer5_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtTransfer5.TextChanged
        '* * * * *
        '* This method handles the TextBox's text being chnaged.
        '* * * * *

        Integer.TryParse(txtTransfer5.Text, hench5)

        If radGuild.Checked = True Then
            If hench5 <= currUser.hench5 Then
                checkTransfer()
            Else
                hench5 = 0
                txtTransfer5.Clear()
            End If
        ElseIf radPlayer.Checked = True Then
            If hench5 <= currGuild.hench5 Then
                checkTransfer()
            Else
                hench5 = 0
                txtTransfer5.Clear()
            End If
        End If
    End Sub

    Private Sub txtTransferGold_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtTransferGold.TextChanged
        '* * * * *
        '* This method handles the TextBox's text being chnaged.
        '* * * * *

        Integer.TryParse(txtTransferGold.Text, gold)

        If radGuild.Checked = True Then
            If gold <= currUser.goldOnHand Then
                checkTransfer()
            Else
                gold = 0
                txtTransferGold.Clear()
            End If
        ElseIf radPlayer.Checked = True Then
            If gold <= currGuild.gold Then
                checkTransfer()
            Else
                gold = 0
                txtTransferGold.Clear()
            End If
        End If
    End Sub


    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        '* * * * *
        '* This method closes the form on clicking the Back button.
        '* * * * *

        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        '* * * * *
        '* This method clears everything on the form.
        '* * * * *

        clear()
    End Sub

    Private Sub btnTransfer_Click(sender As System.Object, e As System.EventArgs) Handles btnTransfer.Click
        '* * * * *
        '* This method transfers everything.
        '* * * * *

        transfer()
    End Sub


    Private Sub frmGuildTransfer_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        '* * * * *
        '* This method handles the form closing.
        '* * * * *

        frmGuildManage.Show()
        frmGuildManage.currUser = currUser
        frmGuildManage.currGuild = currGuild
    End Sub

    Private Sub pctHelp_Click(sender As System.Object, e As System.EventArgs) Handles pctHelp.Click
        '* * * * *
        '* This method handles clicking the Question Mark picture.
        '* * * * *

        frmHelp.Show()
        frmHelp.loc = "Guild Transfer"
        frmHelp.display()
    End Sub

    Private Sub pctHelp_MouseHover(sender As Object, e As System.EventArgs) Handles pctHelp.MouseHover
        '* * * * *
        '* This method handles the mouse hovering over the Question Mark icon.
        '* * * * *

        Dim cur As Cursor = Cursors.Hand
        Me.Cursor = cur
    End Sub

    Private Sub pctHelp_MouseLeave(sender As Object, e As System.EventArgs) Handles pctHelp.MouseLeave
        '* * * * *
        '* This method handles the mouse leaving the Question Mark icon.
        '* * * * *

        Dim cur As Cursor = Cursors.Default
        Me.Cursor = cur
    End Sub
End Class