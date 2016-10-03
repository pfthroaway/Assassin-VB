' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 12/14/2012
' Filename        : Hire Henchmen Form.vb
' Description     : This form allows the hiring of henchmen.

Option Strict On
Option Explicit On

Public Class frmHireHenchmen
    Dim funcs As New Functions
    Public currUser As New User
    Public currGuild As New Guild
    Dim goldOnHand As Integer
    Dim goldRemaining As Integer
    Dim buy1 As Integer
    Dim buy2 As Integer
    Dim buy3 As Integer
    Dim buy4 As Integer
    Dim buy5 As Integer
    Dim hench1 As Integer
    Dim hench2 As Integer
    Dim hench3 As Integer
    Dim hench4 As Integer
    Dim hench5 As Integer
    Public blnGuild As Boolean = False
    Dim nl As String = ControlChars.NewLine

    Public Sub addText(ByVal newText As String)
        '* * * * *
        '* This method adds formatted text to the TextBox.
        '* * * * *

        Dim currText As String = txtHire.Text
        txtHire.Clear()

        txtHire.Text = newText & nl & nl & currText
        txtHire.Select(0, 0)
        txtHire.ScrollToCaret()
    End Sub

    Private Sub checkMax()
        '* * * * *
        '* This method checks whether you have the maximum number of henchmen for a given level.
        '* * * * *

        If hench1 > 998 Then
            btn1P1.Enabled = False
            btn1P5.Enabled = False
        ElseIf hench1 > 994 Then
            btn1P5.Enabled = False
        End If

        If hench2 > 998 Then
            btn2P1.Enabled = False
            btn2P5.Enabled = False
        ElseIf hench2 > 994 Then
            btn2P5.Enabled = False
        End If


        If hench3 > 998 Then
            btn3P1.Enabled = False
            btn3P5.Enabled = False
        ElseIf hench3 > 994 Then
            btn3P5.Enabled = False
        End If

        If hench4 > 998 Then
            btn4P1.Enabled = False
            btn4P5.Enabled = False
        ElseIf hench4 > 994 Then
            btn4P5.Enabled = False
        End If

        If hench5 > 998 Then
            btn5P1.Enabled = False
            btn5P5.Enabled = False
        ElseIf hench5 > 994 Then
            btn5P5.Enabled = False
        End If
    End Sub

    Private Sub checkMinusButtons()
        '* * * * *
        '* This method checks all Minus buttons.
        '* * * * *

        If (buy1 + buy2 + buy3 + buy4 + buy5) > 0 Then
            btnHire.Enabled = True
            btnClear.Enabled = True
            If buy1 > 0 Then
                If buy1 >= 5 Then
                    btn1M5.Enabled = True
                    btn1M1.Enabled = True
                Else
                    btn1M1.Enabled = True
                    btn1M5.Enabled = False
                End If
            Else
                btn1M1.Enabled = False
                btn1M5.Enabled = False
            End If

            If buy2 > 0 Then
                If buy2 >= 5 Then
                    btn2M5.Enabled = True
                    btn2M1.Enabled = True
                Else
                    btn2M1.Enabled = True
                    btn2M5.Enabled = False
                End If
            Else
                btn2M1.Enabled = False
                btn2M5.Enabled = False
            End If

            If buy3 > 0 Then
                If buy3 >= 5 Then
                    btn3M5.Enabled = True
                    btn3M1.Enabled = True
                Else
                    btn3M1.Enabled = True
                    btn3M5.Enabled = False
                End If
            Else
                btn3M1.Enabled = False
                btn3M5.Enabled = False
            End If

            If buy4 > 0 Then
                If buy4 >= 5 Then
                    btn4M5.Enabled = True
                    btn4M1.Enabled = True
                Else
                    btn4M1.Enabled = True
                    btn4M5.Enabled = False
                End If
            Else
                btn4M1.Enabled = False
                btn4M5.Enabled = False
            End If

            If buy5 > 0 Then
                If buy5 >= 5 Then
                    btn5M5.Enabled = True
                    btn5M1.Enabled = True
                Else
                    btn5M1.Enabled = True
                    btn5M5.Enabled = False
                End If
            Else
                btn5M1.Enabled = False
                btn5M5.Enabled = False
            End If
        Else
            disableAllMinus()
            btnHire.Enabled = False
            btnClear.Enabled = False
        End If
    End Sub

    Private Sub checkPlusButtons()
        '* * * * *
        '* This method checks whether Plus buttons should be enabled.
        '* * * * *

        If goldRemaining >= 100 Then
            If goldRemaining >= 2500 Then
                enableAllPlus()
            ElseIf goldRemaining >= 2000 Then
                enableAllPlus()
                btn5P5.Enabled = False
            ElseIf goldRemaining >= 1500 Then
                enableAllPlus()
                btn5P5.Enabled = False
                btn4P5.Enabled = False
            ElseIf goldRemaining >= 1000 Then
                enableAllPlus()
                btn5P5.Enabled = False
                btn4P5.Enabled = False
                btn3P5.Enabled = False
            ElseIf goldRemaining >= 500 Then
                enableAllPlus()
                btn5P5.Enabled = False
                btn4P5.Enabled = False
                btn3P5.Enabled = False
                btn2P5.Enabled = False
            ElseIf goldRemaining >= 400 Then
                disableAllPlus()
                btn1P1.Enabled = True
                btn2P1.Enabled = True
                btn3P1.Enabled = True
                btn4P1.Enabled = True
            ElseIf goldRemaining >= 300 Then
                disableAllPlus()
                btn1P1.Enabled = True
                btn2P1.Enabled = True
                btn3P1.Enabled = True
            ElseIf goldRemaining >= 200 Then
                disableAllPlus()
                btn1P1.Enabled = True
                btn2P1.Enabled = True
            ElseIf goldRemaining >= 100 Then
                disableAllPlus()
                btn1P1.Enabled = True
            End If

            checkMax()
        Else
            disableAllPlus()
        End If
    End Sub

    Private Sub clear()
        '* * * * *
        '* This method clears all relevant data on the form.
        '* * * * *

        buy1 = 0
        buy2 = 0
        buy3 = 0
        buy4 = 0
        buy5 = 0
        goldRemaining = goldOnHand
        display()
    End Sub

    Private Sub disableAllMinus()
        '* * * * *
        '* This method disables all the minus buttons.
        '* * * * *

        btn1M5.Enabled = False
        btn2M5.Enabled = False
        btn3M5.Enabled = False
        btn4M5.Enabled = False
        btn5M5.Enabled = False
        btn1M1.Enabled = False
        btn2M1.Enabled = False
        btn2M1.Enabled = False
        btn3M1.Enabled = False
        btn4M1.Enabled = False
        btn5M1.Enabled = False
    End Sub

    Private Sub disableAllPlus()
        '* * * * *
        '* This method disables all Plus buttons.
        '* * * * *

        btn1P1.Enabled = False
        btn2P1.Enabled = False
        btn3P1.Enabled = False
        btn4P1.Enabled = False
        btn5P1.Enabled = False
        btn1P5.Enabled = False
        btn2P5.Enabled = False
        btn3P5.Enabled = False
        btn4P5.Enabled = False
        btn5P5.Enabled = False
    End Sub

    Public Sub disablebuttons()
        '* * * * *
        '* This method disables all buttons except for Back.
        '* * * * *

        btn1M5.Enabled = False
        btn2M5.Enabled = False
        btn3M5.Enabled = False
        btn4M5.Enabled = False
        btn5M5.Enabled = False
        btn1M1.Enabled = False
        btn2M1.Enabled = False
        btn2M1.Enabled = False
        btn3M1.Enabled = False
        btn4M1.Enabled = False
        btn5M1.Enabled = False
        btn1P1.Enabled = False
        btn2P1.Enabled = False
        btn3P1.Enabled = False
        btn4P1.Enabled = False
        btn5P1.Enabled = False
        btn1P5.Enabled = False
        btn2P5.Enabled = False
        btn3P5.Enabled = False
        btn4P5.Enabled = False
        btn5P5.Enabled = False

        btnHire.Enabled = False
        btnClear.Enabled = False
    End Sub

    Public Sub display()
        '* * * * *
        '* This method displays all relevant data on the form.
        '* * * * *

        checkPlusButtons()
        checkMinusButtons()
        lblGoldOnHand.Text = goldOnHand.ToString("N0")
        lblGoldRemaining.Text = goldRemaining.ToString("N0")

        txtHench1.Text = hench1.ToString
        txtBuy1.Text = buy1.ToString
        txtHench2.Text = hench2.ToString
        txtBuy2.Text = buy2.ToString
        txtHench3.Text = hench3.ToString
        txtBuy3.Text = buy3.ToString
        txtHench4.Text = hench4.ToString
        txtBuy4.Text = buy4.ToString
        txtHench5.Text = hench5.ToString
        txtBuy5.Text = buy5.ToString
    End Sub

    Public Sub enableAllPlus()
        '* * * * *
        '* This method enables all Plus buttons.
        '* * * * *

        btn1P1.Enabled = True
        btn2P1.Enabled = True
        btn3P1.Enabled = True
        btn4P1.Enabled = True
        btn5P1.Enabled = True
        btn1P5.Enabled = True
        btn2P5.Enabled = True
        btn3P5.Enabled = True
        btn4P5.Enabled = True
        btn5P5.Enabled = True
    End Sub

    Public Sub hireText()
        '* * * * *
        '* This method handles adding text to the Textbox based on who was hired.
        '* * * * *

        Dim textHire As String = "You hire "

        If buy1 > 0 Then
            If (buy2 + buy3 + buy4 + buy5) > 0 Then
                textHire += buy1 & " Level 1 Henchmen, "
            Else
                textHire += buy1 & " Level 1 Henchmen."
            End If
        End If

        If buy2 > 0 Then
            If (buy3 + buy4 + buy5) > 0 Then
                textHire += buy2 & " Level 2 Henchmen, "
            ElseIf buy1 > 0 Then
                textHire += "and " & buy2 & " Level 2 Henchmen."
            Else
                textHire += buy2 & " Level 2 Henchmen."
            End If
        End If

        If buy3 > 0 Then
            If (buy4 + buy5) > 0 Then
                textHire += buy2 & " Level 3 Henchmen, "
            ElseIf (buy1 + buy2) > 0 Then
                textHire += "and " & buy3 & " Level 3 Henchmen."
            Else
                textHire += buy3 & " Level 3 Henchmen."
            End If
        End If

        If buy4 > 0 Then
            If buy5 > 0 Then
                textHire += buy4 & " Level 4 Henchmen, "
            ElseIf (buy1 + buy2 + buy3) > 0 Then
                textHire += "and " & buy4 & " Level 4 Henchmen."
            Else
                textHire += buy4 & " Level 4 Henchmen."
            End If
        End If

        If buy5 > 0 Then
            If (buy1 + buy2 + buy3 + buy4) > 0 Then
                textHire += "and " & buy5 & " Level 5 Henchmen."
            Else
                textHire += buy5 & " Level 5 Henchmen."
            End If
        End If

        addText(textHire)
    End Sub

    Public Sub setUser()
        '* * * * *
        '* This method sets up a player to buy henchmen.
        '* * * * *

        goldOnHand = currUser.goldOnHand
        goldRemaining = goldOnHand
        hench1 = currUser.hench1
        hench2 = currUser.hench2
        hench3 = currUser.hench3
        hench4 = currUser.hench4
        hench5 = currUser.hench5
        display()
    End Sub

    Public Sub setGuild()

        '* * * * *
        '* This method sets up a guild to buy henchmen.
        '* * * * *

        goldOnHand = currGuild.gold
        goldRemaining = goldOnHand
        hench1 = currGuild.hench1
        hench2 = currGuild.hench2
        hench3 = currGuild.hench3
        hench4 = currGuild.hench4
        hench5 = currGuild.hench5
        display()
    End Sub


    Private Sub btn1M5_Click(sender As System.Object, e As System.EventArgs) Handles btn1M5.Click
        '* * * * *
        '* This method removes 5 Level 1 Henchmen from the queue.
        '* * * * *

        buy1 -= 5
        goldRemaining += 500
        display()
    End Sub

    Private Sub btn1M1_Click(sender As System.Object, e As System.EventArgs) Handles btn1M1.Click
        '* * * * *
        '* This method removes 1 Level 1 Henchman from the queue.
        '* * * * *


        buy1 -= 1
        goldRemaining += 100
        display()
    End Sub

    Private Sub btn1P1_Click(sender As System.Object, e As System.EventArgs) Handles btn1P1.Click
        '* * * * *
        '* This method adds 1 Level 1 Henchman to the queue.
        '* * * * *


        buy1 += 1
        goldRemaining -= 100
        display()
    End Sub

    Private Sub btn1P5_Click(sender As System.Object, e As System.EventArgs) Handles btn1P5.Click
        '* * * * *
        '* This method adds 5 Level 1 Henchmen to the queue.
        '* * * * *

        buy1 += 5
        goldRemaining -= 500
        display()
    End Sub

    Private Sub btn2M5_Click(sender As System.Object, e As System.EventArgs) Handles btn2M5.Click
        '* * * * *
        '* This method removes 5 Level 2 Henchmen from the queue.
        '* * * * *

        buy2 -= 5
        goldRemaining += 1000
        display()
    End Sub

    Private Sub btn2M1_Click(sender As System.Object, e As System.EventArgs) Handles btn2M1.Click
        '* * * * *
        '* This method removes 1 Level 2 Henchman to the queue.
        '* * * * *

        buy2 -= 1
        goldRemaining += 200
        display()
    End Sub

    Private Sub btn2P1_Click(sender As System.Object, e As System.EventArgs) Handles btn2P1.Click
        '* * * * *
        '* This method adds 1 Level 2 Henchman to the queue.
        '* * * * *

        buy2 += 1
        goldRemaining -= 200
        display()
    End Sub

    Private Sub btn2P5_Click(sender As System.Object, e As System.EventArgs) Handles btn2P5.Click
        '* * * * *
        '* This method adds 5 Level 2 Henchmen to the queue.
        '* * * * *

        buy2 += 5
        goldRemaining -= 1000
        display()
    End Sub

    Private Sub btn3M5_Click(sender As System.Object, e As System.EventArgs) Handles btn3M5.Click
        '* * * * *
        '* This method removes 5 Level 3 Henchmen from the queue.
        '* * * * *

        buy3 -= 5
        goldRemaining += 1500
        display()
    End Sub

    Private Sub btn3M1_Click(sender As System.Object, e As System.EventArgs) Handles btn3M1.Click
        '* * * * *
        '* This method removes 1 Level 3 Henchman from the queue.
        '* * * * *

        buy3 -= 1
        goldRemaining += 300
        display()
    End Sub

    Private Sub btn3P1_Click(sender As System.Object, e As System.EventArgs) Handles btn3P1.Click
        '* * * * *
        '* This method adds 1 Level 3 Henchman to the queue.
        '* * * * *

        buy3 += 1
        goldRemaining -= 300
        display()
    End Sub

    Private Sub btn3P5_Click(sender As System.Object, e As System.EventArgs) Handles btn3P5.Click
        '* * * * *
        '* This method adds 5 Level 3 Henchmen to the queue.
        '* * * * *

        buy3 += 5
        goldRemaining -= 1500
        display()
    End Sub

    Private Sub btn4M5_Click(sender As System.Object, e As System.EventArgs) Handles btn4M5.Click
        '* * * * *
        '* This method removes 5 Level 4 Henchmen from the queue.
        '* * * * *

        buy4 -= 5
        goldRemaining += 2000
        display()
    End Sub

    Private Sub btn4M1_Click(sender As System.Object, e As System.EventArgs) Handles btn4M1.Click
        '* * * * *
        '* This method removes 1 Level 4 Henchman from the queue.
        '* * * * *

        buy4 -= 1
        goldRemaining += 400
        display()
    End Sub

    Private Sub btn4P1_Click(sender As System.Object, e As System.EventArgs) Handles btn4P1.Click
        '* * * * *
        '* This method adds 1 Level 4 Henchman to the queue.
        '* * * * *

        buy4 += 1
        goldRemaining -= 400
        display()
    End Sub

    Private Sub btn4P5_Click(sender As System.Object, e As System.EventArgs) Handles btn4P5.Click
        '* * * * *
        '* This method adds 5 Level 4 Henchmen to the queue.
        '* * * * *

        buy4 += 5
        goldRemaining -= 2000
        display()
    End Sub

    Private Sub btn5M5_Click(sender As System.Object, e As System.EventArgs) Handles btn5M5.Click
        '* * * * *
        '* This method removes 5 Level 5 Henchmen from the queue.
        '* * * * *

        buy5 -= 5
        goldRemaining += 2500
        display()
    End Sub

    Private Sub btn5M1_Click(sender As System.Object, e As System.EventArgs) Handles btn5M1.Click
        '* * * * *
        '* This method removes 1 Level 5 Henchman from the queue.
        '* * * * *

        buy5 -= 1
        goldRemaining += 500
        display()
    End Sub

    Private Sub btn5P1_Click(sender As System.Object, e As System.EventArgs) Handles btn5P1.Click
        '* * * * *
        '* This method adds 1 Level 5 Henchman to the queue.
        '* * * * *

        buy5 += 1
        goldRemaining -= 500
        display()
    End Sub

    Private Sub btn5P5_Click(sender As System.Object, e As System.EventArgs) Handles btn5P5.Click
        '* * * * *
        '* This method adds 5 Level 5 Henchmen to the queue.
        '* * * * *

        buy5 += 5
        goldRemaining -= 2500
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
        '* This method clears all data on the form.
        '* * * * *

        clear()
    End Sub

    Private Sub btnHire_Click(sender As System.Object, e As System.EventArgs) Handles btnHire.Click
        '* * * * *
        '* This method hires the henchmen allocated.
        '* * * * *

        If blnGuild = True Then 'hire henchmen for guild
            currGuild.hench1 += buy1
            currGuild.hench2 += buy2
            currGuild.hench3 += buy3
            currGuild.hench4 += buy4
            currGuild.hench5 += buy5
            currGuild.gold = goldRemaining
            funcs.saveGuild(currGuild)
            setGuild()
        Else                    'hire henchmen for user
            currUser.hench1 += buy1
            currUser.hench2 += buy2
            currUser.hench3 += buy3
            currUser.hench4 += buy4
            currUser.hench5 += buy5
            currUser.goldOnHand = goldRemaining
            funcs.save(currUser)
            setUser()
        End If

        hireText()
        goldOnHand = goldRemaining
        clear()
    End Sub


    Private Sub frmHireHenchmen_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        '* * * * *
        '* This method handles closing the form.
        '* * * * *

        If blnGuild = True Then
            frmGuildManage.Show()
            frmGuildManage.currGuild = currGuild
            frmGuildManage.addText(txtHire.Text)
        Else
            frmGuild.Show()
            frmGuild.currUser = currUser
            frmGuild.addText(txtHire.Text)
        End If
    End Sub
End Class