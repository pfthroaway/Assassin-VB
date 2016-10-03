' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 05/25/2012
' Filename        : Raid Form.vb
' Description     : This form allows a user to raid other guilds and the bank.

Option Strict On
Option Explicit On

Public Class frmRaid
    Dim funcs As New Functions              'new Functions instance
    Public currUser As New User             'current user
    Dim ds As DataSet                       'DataSet
    Dim sql As String                       'SQL query
    Dim table As String                     'table name
    Dim nl As String = ControlChars.NewLine 'new line
    Public currGuild As New Guild           'current guild
    Dim raidGuild As New Guild              'guild selected to be raided
    Dim plrHench As New Henchman            'player's henchmen
    Dim eneHench As New Henchman            'enemy's henchmen

    Private Function checkPlrMax() As Integer
        '* * * * *
        '* This function determines the highest level of henchmen the player has.
        '* * * * *

        If plrHench.hench5 > 0 Then
            plrHench.number = plrHench.hench5
            Return 5
        ElseIf plrHench.hench4 > 0 Then
            plrHench.number = plrHench.hench4
            Return 4
        ElseIf plrHench.hench3 > 0 Then
            plrHench.number = plrHench.hench3
            Return 3
        ElseIf plrHench.hench2 > 0 Then
            plrHench.number = plrHench.hench2
            Return 2
        ElseIf plrHench.hench1 > 0 Then
            plrHench.number = plrHench.hench1
            Return 1
        Else
            Return 0
        End If
    End Function

    Private Function checkEneMax() As Integer
        '* * * * *
        '* This function determines the highest level of henchmen the enemy has.
        '* * * * *

        If eneHench.hench5 > 0 Then
            eneHench.number = plrHench.hench5
            Return 5
        ElseIf eneHench.hench4 > 0 Then
            eneHench.number = plrHench.hench4
            Return 4
        ElseIf eneHench.hench3 > 0 Then
            eneHench.number = plrHench.hench3
            Return 3
        ElseIf eneHench.hench2 > 0 Then
            eneHench.number = plrHench.hench2
            Return 2
        ElseIf eneHench.hench1 > 0 Then
            eneHench.number = plrHench.hench1
            Return 1
        Else
            Return 0
        End If
    End Function

    Private Function decHench(ByVal Hench As Henchman) As Henchman
        '* * * * *
        '* This method decrements the henchman at that level.
        '* * * * *

        Select Case Hench.level
            Case 5
                Hench.number -= 1
                Hench.hench5 -= 1
            Case 4
                Hench.number -= 1
                Hench.hench4 -= 1
            Case 3
                Hench.number -= 1
                Hench.hench3 -= 1
            Case 2
                Hench.number -= 1
                Hench.hench2 -= 1
            Case 1
                Hench.number -= 1
                Hench.hench1 -= 1
        End Select

        Return Hench
    End Function

    Private Function eneCount() As Integer
        '* * * * *
        '* This function determines the number of henchmen the enemy has at that level.
        '* * * * *

        Return (eneHench.hench1 + eneHench.hench2 + eneHench.hench3 + eneHench.hench4 + eneHench.hench5)
    End Function

    Private Function plrCount() As Integer
        '* * * * *
        '* This function determines the number of henchmen the player has at that level.
        '* * * * *

        Return (plrHench.hench1 + plrHench.hench2 + plrHench.hench3 + plrHench.hench4 + plrHench.hench5)
    End Function


    Public Sub addText(ByVal newText As String)
        '* * * * *
        '* This method adds text to the Textbox.
        '* * * * *

        Dim currText As String = txtRaid.Text
        txtRaid.Clear()

        txtRaid.Text = newText & nl & nl & currText
        txtRaid.Select(0, 0)
        txtRaid.ScrollToCaret()
    End Sub

    Private Sub battle()
        '* * * * *
        '* This method handles raiding.
        '* * * * *

        While plrHench.number > 0 AndAlso eneHench.number > 0
            Dim first As Integer = funcs.random(1, 100)
            If first <= 50 Then
                playerAtt()
                If eneHench.number > 0 Then
                    enemyAtt()
                End If
            Else
                enemyAtt()
                If plrHench.number > 0 Then
                    playerAtt()
                End If
            End If
        End While

    End Sub

    Private Sub checkRaid()
        '* * * * *
        '* This method checks whether you can click the Raid button
        '* * * * *

        If cmbRaid.SelectedIndex <> currGuild.id AndAlso cmbRaid.SelectedIndex <> 1 Then
            Dim hench1 As Integer
            Dim hench2 As Integer
            Dim hench3 As Integer
            Dim hench4 As Integer
            Dim hench5 As Integer
            Integer.TryParse(txtHench1.Text, hench1)
            Integer.TryParse(txtHench2.Text, hench2)
            Integer.TryParse(txtHench3.Text, hench3)
            Integer.TryParse(txtHench4.Text, hench4)
            Integer.TryParse(txtHench5.Text, hench5)

            If (hench1 + hench2 + hench3 + hench4 + hench5) > 0 AndAlso cmbRaid.SelectedIndex >= 0 Then
                btnRaid.Enabled = True
            Else
                btnRaid.Enabled = False
            End If
        ElseIf cmbRaid.SelectedIndex = 1 Then
            MessageBox.Show("You cannot raid The Master's Tavern.", "Assassin", MessageBoxButtons.OK)
            btnRaid.Enabled = False
        ElseIf cmbRaid.SelectedIndex = currGuild.id Then
            MessageBox.Show("You cannot raid the guild you are currently in.", "Assassin", MessageBoxButtons.OK)
            btnRaid.Enabled = False
        End If
    End Sub

    Private Sub disableButtons()
        '* * * * *
        '* This method disables everything except the Back button.
        '* * * * *

        cmbRaid.Enabled = False
        btnRaid.Enabled = False
        btnClear.Enabled = False
        txtHench1.Enabled = False
        txtHench2.Enabled = False
        txtHench3.Enabled = False
        txtHench4.Enabled = False
        txtHench5.Enabled = False
    End Sub

    Private Sub enemyAtt()
        '* * * * *
        '* This method handles the enemy's henchman attacking.
        '* * * * *

        Dim toHit As Integer = funcs.random(1, 100)             'random number for enemy to hit
        Dim plrBlock As Integer = funcs.random(1, 100)          'random number for player to block

        If toHit <= plrHench.toHit Then                         'potential to hit
            If plrBlock >= plrHench.blocking Then               'player didn't block
                plrHench.health -= eneHench.damage              'player loses health
                If plrHench.health <= 0 Then                    'if player has no health
                    plrHench = decHench(plrHench)
                    If plrHench.number > 0 Then                 'if player still has members
                        plrHench.health = plrHench.level * 2    'set health to max
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub loadRaid()
        '* * * * *
        '* This method loads all the information on the form.
        '* * * * *

        sql = "SELECT GuildName FROM Guilds"
        table = "Guilds"
        ds = funcs.fillDS(sql, table)
        cmbRaid.Items.Add("Bank")
        For i As Integer = 0 To ds.Tables("Guilds").Rows.Count - 1
            cmbRaid.Items.Add(ds.Tables("Guilds").Rows(i).Item("GuildName").ToString)
        Next

        txtMax1.Text = currUser.hench1.ToString
        txtMax2.Text = currUser.hench2.ToString
        txtMax3.Text = currUser.hench3.ToString
        txtMax4.Text = currUser.hench4.ToString
        txtMax5.Text = currUser.hench5.ToString
    End Sub

    Private Sub loseBattle()
        '* * * * *
        '* This method handles the player failing the raiding.
        '* * * * *

        addText("You failed to raid the " & cmbRaid.SelectedItem.ToString & ".")
        cmbRaid.Enabled = False
        btnRaid.Enabled = False
        btnClear.Enabled = False

    End Sub

    Private Sub playerAtt()
        '* * * * *
        '* This method handles the player's henchman attacking.
        '* * * * *

        Dim toHit As Integer = funcs.random(1, 100)             'random number for player to hit
        Dim eneBlock As Integer = funcs.random(1, 100)          'random number for enemy to block

        If toHit <= plrHench.toHit Then                         'potential to hit
            If eneBlock >= eneHench.blocking Then               'enemy didn't block
                eneHench.health -= plrHench.damage              'enemy loses health
                If eneHench.health <= 0 Then                    'if enemy has no health
                    decHench(eneHench)
                    If eneHench.number > 0 Then                 'if enemy still has members
                        eneHench.health = eneHench.level * 2    'set health to max
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub setHenchmen()
        '* * * * *
        '* This method sets the number of henchmen for both parties.
        '* * * * *

        plrHench.hench1 = currUser.hench1
        plrHench.hench2 = currUser.hench2
        plrHench.hench3 = currUser.hench3
        plrHench.hench4 = currUser.hench4
        plrHench.hench5 = currUser.hench5

        eneHench.hench1 = raidGuild.hench1
        eneHench.hench2 = raidGuild.hench2
        eneHench.hench3 = raidGuild.hench3
        eneHench.hench4 = raidGuild.hench4
        eneHench.hench5 = raidGuild.hench5
    End Sub

    Private Sub winbattle()
        '* * * * *
        '* This method handles the player successfully raiding.
        '* * * * *

        Dim number As Integer = plrCount()
        Dim maxgold As Integer
        Dim stolenGold As Integer

        If cmbRaid.SelectedItem.ToString <> "Bank" Then
            maxgold = raidGuild.gold
            If (number * 100) <= raidGuild.gold Then
                stolenGold = number * 100
            Else
                stolenGold = maxgold
            End If

            raidGuild.gold -= stolenGold
            raidGuild.hench1 = 0
            raidGuild.hench2 = 0
            raidGuild.hench3 = 0
            raidGuild.hench4 = 0
            raidGuild.hench5 = 0

            funcs.saveGuild(raidGuild)
        Else
            stolenGold = number * 100
        End If

        currUser.hench1 = plrHench.hench1
        currUser.hench2 = plrHench.hench2
        currUser.hench3 = plrHench.hench3
        currUser.hench4 = plrHench.hench4
        currUser.hench5 = plrHench.hench5

        addText("You have won the battle! Your " & number & " remaining henchmen make off with " & stolenGold & " gold.")
        currUser.goldOnHand += stolenGold
        funcs.save(currUser)

        cmbRaid.Enabled = False
        txtHench1.Enabled = False
        txtHench2.Enabled = False
        txtHench3.Enabled = False
        txtHench4.Enabled = False
        txtHench5.Enabled = False
        btnRaid.Enabled = False
        btnClear.Enabled = False
    End Sub

    Private Sub HenchKeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtHench1.KeyPress, txtHench2.KeyPress, _
        txtHench3.KeyPress, txtHench4.KeyPress, txtHench5.KeyPress
        '* * * * *
        '* This method only allows numbers to be entered into the Textboxes on the form.
        '* * * * *

        If Char.IsDigit(e.KeyChar) OrElse e.KeyChar Like Chr(8) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub cmbRaid_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbRaid.SelectedIndexChanged
        '* * * * *
        '* This method checks whether you can click the Raid button
        '* * * * *

        checkRaid()
    End Sub

    Private Sub txtHench1_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtHench1.TextChanged
        '* * * * *
        '* This method checks whether you can click the Raid button after text changed.
        '* * * * *

        Dim currHench As Integer
        Integer.TryParse(txtHench1.Text, currHench)
        If currHench > currUser.hench1 Then
            txtHench1.Text = ""
        End If

        checkRaid()
    End Sub

    Private Sub txtHench2_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtHench2.TextChanged
        '* * * * *
        '* This method checks whether you can click the Raid button after text changed.
        '* * * * *

        Dim currHench As Integer
        Integer.TryParse(txtHench2.Text, currHench)
        If currHench > currUser.hench2 Then
            txtHench2.Text = ""
        End If

        checkRaid()
    End Sub

    Private Sub txtHench3_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtHench3.TextChanged
        '* * * * *
        '* This method checks whether you can click the Raid button after text changed.
        '* * * * *

        Dim currHench As Integer
        Integer.TryParse(txtHench3.Text, currHench)
        If currHench > currUser.hench3 Then
            txtHench3.Text = ""
        End If

        checkRaid()
    End Sub

    Private Sub txtHench4_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtHench4.TextChanged
        '* * * * *
        '* This method checks whether you can click the Raid button after text changed.
        '* * * * *

        Dim currHench As Integer
        Integer.TryParse(txtHench4.Text, currHench)
        If currHench > currUser.hench4 Then
            txtHench4.Text = ""
        End If

        checkRaid()
    End Sub

    Private Sub txtHench5_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtHench5.TextChanged
        '* * * * *
        '* This method checks whether you can click the Raid button after text changed.
        '* * * * *

        Dim currHench As Integer
        Integer.TryParse(txtHench5.Text, currHench)
        If currHench > currUser.hench5 Then
            txtHench5.Text = ""
        End If

        checkRaid()
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

        cmbRaid.SelectedIndex = -1

        txtHench1.Text = ""
        txtHench2.Text = ""
        txtHench3.Text = ""
        txtHench4.Text = ""
        txtHench5.Text = ""

        btnRaid.Enabled = False
    End Sub

    Private Sub btnRaid_Click(sender As System.Object, e As System.EventArgs) Handles btnRaid.Click
        '* * * * *
        '* This method handles clicking the Raid button.
        '* * * * *

        If cmbRaid.SelectedItem.ToString <> "Bank" Then
            raidGuild = funcs.getGuild(cmbRaid.SelectedIndex)

            setHenchmen()
            Dim round As Integer = 1

            While plrCount() > 0 AndAlso eneCount() > 0
                plrHench.level = checkPlrMax()
                Select Case plrHench.level
                    Case 5
                        plrHench.number = plrHench.hench5
                    Case 4
                        plrHench.number = plrHench.hench4
                    Case 3
                        plrHench.number = plrHench.hench3
                    Case 2
                        plrHench.number = plrHench.hench2
                    Case 1
                        plrHench.number = plrHench.hench1
                End Select
                eneHench.level = checkEneMax()
                Select Case eneHench.level
                    Case 5
                        eneHench.number = eneHench.hench5
                    Case 4
                        eneHench.number = eneHench.hench4
                    Case 3
                        eneHench.number = eneHench.hench3
                    Case 2
                        eneHench.number = eneHench.hench2
                    Case 1
                        eneHench.number = eneHench.hench1
                End Select

                addText("You begin Round " & round & " with " & plrHench.number & " Level " & plrHench.level & _
                        " Henchmen. Your opponent begins the round with " & eneHench.number & " Level " & eneHench.level & " Henchmen.")

                battle()

                addText("You end Round " & round & " with " & plrHench.number & " Level " & plrHench.level & _
                        " Henchmen. Your opponent ends the round with " & eneHench.number & " Level " & eneHench.level & " Henchmen.")

                round += 1
            End While
        End If

        If plrCount() > 0 AndAlso eneCount() <= 0 Then
            winbattle()
        ElseIf eneCount() > 0 AndAlso plrCount() <= 0 Then
            loseBattle()
        End If
    End Sub


    Private Sub frmRaid_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        '* * * * *
        '* This method handles the form closing.
        '* * * * *

        frmGuild.Show()
        frmGuild.currUser = currUser
    End Sub
End Class