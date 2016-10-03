' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 10/11/2012
' Filename        : Guild Donate Form.vb
' Description     : This form allows a user to donate henchmen and gold to their guild.

Option Strict On
Option Explicit On

Public Class frmGuildDonate
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

        Dim currText As String = txtDonate.Text
        txtDonate.Clear()

        txtDonate.Text = newText & nl & nl & currText
        txtDonate.Select(0, 0)
        txtDonate.ScrollToCaret()
    End Sub

    Private Sub checkDonate()
        '* * * * *
        '* This method checks whether the donate button should be enabled.
        '* * * * *

        If (hench1 + hench2 + hench3 + hench4 + hench5 + gold) > 0 Then
            btnDonate.Enabled = True
            btnClear.Enabled = True
        Else
            btnDonate.Enabled = False
            btnClear.Enabled = False
        End If
    End Sub

    Private Sub clear()
        '* * * * *
        '* This method clears all information on the form.
        '* * * * *

        txtDonate1.Clear()
        txtDonate2.Clear()
        txtDonate3.Clear()
        txtDonate4.Clear()
        txtDonate5.Clear()
        txtDonateGold.Clear()

        btnClear.Enabled = False
        btnDonate.Enabled = False

        display()
    End Sub

    Private Sub display()
        '* * * * *
        '* This method displays all important information on the form.
        '* * * * *

        txtHench1.Text = currUser.hench1.ToString("N0")
        txtHench2.Text = currUser.hench2.ToString("N0")
        txtHench3.Text = currUser.hench3.ToString("N0")
        txtHench4.Text = currUser.hench4.ToString("N0")
        txtHench5.Text = currUser.hench5.ToString("N0")
        txtGold.Text = currUser.goldOnHand.ToString("N0")

        If currUser.hench1 > 0 Then
            txtDonate1.Enabled = True
        Else
            txtDonate1.Enabled = False
        End If
        If currUser.hench2 > 0 Then
            txtDonate2.Enabled = True
        Else
            txtDonate2.Enabled = False
        End If
        If currUser.hench3 > 0 Then
            txtDonate3.Enabled = True
        Else
            txtDonate3.Enabled = False
        End If
        If currUser.hench4 > 0 Then
            txtDonate4.Enabled = True
        Else
            txtDonate4.Enabled = False
        End If
        If currUser.hench5 > 0 Then
            txtDonate5.Enabled = True
        Else
            txtDonate5.Enabled = False
        End If
        If currUser.goldOnHand > 0 Then
            txtDonateGold.Enabled = True
        Else
            txtDonateGold.Enabled = False
        End If
    End Sub

    Private Sub donate()
        '* * * * *
        '* This method handles donating.
        '* * * * *

        'addhenchmen to guild
        currGuild.hench1 += hench1
        currGuild.hench2 += hench2
        currGuild.hench3 += hench3
        currGuild.hench4 += hench4
        currGuild.hench5 += hench5
        currGuild.gold += gold

        'subtract henchmen from user
        currUser.hench1 -= hench1
        currUser.hench2 -= hench2
        currUser.hench3 -= hench3
        currUser.hench4 -= hench4
        currUser.hench5 -= hench5
        currUser.goldOnHand -= gold

        donateText()
        If gold > 0 Then
            addText("You donate " & gold & " gold.")
        End If
        'save
        funcs.save(currUser)
        funcs.saveGuild(currGuild)
        clear()
    End Sub

    Private Sub donateText()
        '* * * * *
        '* This method handles adding text to the Textbox based on who was donated.
        '* * * * *

        Dim textDonate As String = "You donate "

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

    Public Sub loadDonate()
        '* * * * *
        '* This method loads all the information needed to donate.
        '* * * * *

        lblDonate.Text = "Donate to " & currGuild.name
        display()
    End Sub


    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        '* * * * *
        '* This method closes the form on clicking the Back button.
        '* * * * *

        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        '* * * * *
        '* This method clears all information on the form.
        '* * * * *

        clear()
    End Sub

    Private Sub btnDonate_Click(sender As System.Object, e As System.EventArgs) Handles btnDonate.Click
        '* * * * *
        '* This method donates items to the guild.
        '* * * * *

        donate()
    End Sub

    Private Sub donateKeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtDonate1.KeyPress, txtDonate2.KeyPress, txtDonate3.KeyPress, txtDonate4.KeyPress, txtDonate5.KeyPress, txtDonateGold.KeyPress
        '* * * * *
        '* This method handles KeyPresses for all editable fields.
        '* * * * *

        If Char.IsDigit(e.KeyChar) OrElse e.KeyChar Like Chr(8) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtDonate1_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDonate1.TextChanged
        '* * * * *
        '* This method determines if the Donate button should be enabled.
        '* * * * *

        Integer.TryParse(txtDonate1.Text, hench1)

        If hench1 <= currUser.hench1 Then
            checkDonate()
        Else
            hench1 = 0
            txtDonate1.Clear()
        End If
    End Sub

    Private Sub txtDonate2_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDonate2.TextChanged
        '* * * * *
        '* This method determines if the Donate button should be enabled.
        '* * * * *

        Integer.TryParse(txtDonate1.Text, hench2)

        If hench2 <= currUser.hench1 Then
            checkDonate()
        Else
            hench2 = 0
            txtDonate2.Clear()
        End If
    End Sub

    Private Sub txtDonate3_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDonate3.TextChanged
        '* * * * *
        '* This method determines if the Donate button should be enabled.
        '* * * * *

        Integer.TryParse(txtDonate1.Text, hench3)

        If hench3 <= currUser.hench1 Then
            checkDonate()
        Else
            hench3 = 0
            txtDonate3.Clear()
        End If
    End Sub

    Private Sub txtDonate4_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDonate4.TextChanged
        '* * * * *
        '* This method determines if the Donate button should be enabled.
        '* * * * *

        Integer.TryParse(txtDonate1.Text, hench4)

        If hench4 <= currUser.hench1 Then
            checkDonate()
        Else
            hench4 = 0
            txtDonate4.Clear()
        End If
    End Sub

    Private Sub txtDonate5_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDonate5.TextChanged
        '* * * * *
        '* This method determines if the Donate button should be enabled.
        '* * * * *

        Integer.TryParse(txtDonate5.Text, hench1)

        If hench5 <= currUser.hench1 Then
            checkDonate()
        Else
            hench5 = 0
            txtDonate5.Clear()
        End If
    End Sub

    Private Sub txtDonateGold_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDonateGold.TextChanged
        '* * * * *
        '* This method determines if the Donate button should be enabled.
        '* * * * *

        Integer.TryParse(txtDonateGold.Text, gold)

        If gold <= currUser.goldOnHand Then
            checkDonate()
        Else
            gold = 0
            txtDonateGold.Clear()
        End If
    End Sub

    Private Sub frmGuildDonate_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        '* * * * *
        '* This method handles closing the form.
        '* * * * *

        frmGuild.Show()
        frmGuild.currGuild = currGuild
        frmGuild.currUser = currUser
        frmGuild.addText(txtDonate.Text)
    End Sub

End Class