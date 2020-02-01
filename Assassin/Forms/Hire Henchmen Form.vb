' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 12/14/2012
' Filename        : Hire Henchmen Form.vb
' Description     : This form allows the hiring of henchmen.

Option Strict On
Option Explicit On

Imports Assassin.Classes
Imports Assassin.Classes.Entities
Imports Assassin.Forms.GuildForms

Namespace Forms

    Public Class FrmHireHenchmen

        Dim _goldOnHand As Integer
        Dim _goldRemaining As Integer
        Dim _buy1 As Integer
        Dim _buy2 As Integer
        Dim _buy3 As Integer
        Dim _buy4 As Integer
        Dim _buy5 As Integer
        Dim _henchmenLevel1 As Integer
        Dim _henchmenLevel2 As Integer
        Dim _henchmenLevel3 As Integer
        Dim _henchmenLevel4 As Integer
        Dim _henchmenLevel5 As Integer
        Public BlnGuild As Boolean = False
        Dim _nl As String = ControlChars.NewLine

        Public Sub AddText(newText As String)
            '* * * * *
            '* This method adds formatted text to the TextBox.
            '* * * * *

            Dim currText As String = TxtHire.Text
            TxtHire.Clear()

            TxtHire.Text = newText & _nl & _nl & currText
            TxtHire.Select(0, 0)
            TxtHire.ScrollToCaret()
        End Sub

        Private Sub CheckMax()
            '* * * * *
            '* This method checks whether you have the maximum number of henchmen for a given level.
            '* * * * *

            If _henchmenLevel1 > 998 Then
                Btn1P1.Enabled = False
                Btn1P5.Enabled = False
            ElseIf _henchmenLevel1 > 994 Then
                Btn1P5.Enabled = False
            End If

            If _henchmenLevel2 > 998 Then
                Btn2P1.Enabled = False
                Btn2P5.Enabled = False
            ElseIf _henchmenLevel2 > 994 Then
                Btn2P5.Enabled = False
            End If

            If _henchmenLevel3 > 998 Then
                Btn3P1.Enabled = False
                Btn3P5.Enabled = False
            ElseIf _henchmenLevel3 > 994 Then
                Btn3P5.Enabled = False
            End If

            If _henchmenLevel4 > 998 Then
                Btn4P1.Enabled = False
                Btn4P5.Enabled = False
            ElseIf _henchmenLevel4 > 994 Then
                Btn4P5.Enabled = False
            End If

            If _henchmenLevel5 > 998 Then
                Btn5P1.Enabled = False
                Btn5P5.Enabled = False
            ElseIf _henchmenLevel5 > 994 Then
                Btn5P5.Enabled = False
            End If
        End Sub

        Private Sub CheckMinusButtons()
            '* * * * *
            '* This method checks all Minus buttons.
            '* * * * *

            If (_buy1 + _buy2 + _buy3 + _buy4 + _buy5) > 0 Then
                BtnHire.Enabled = True
                BtnClear.Enabled = True
                If _buy1 > 0 Then
                    If _buy1 >= 5 Then
                        Btn1M5.Enabled = True
                        Btn1M1.Enabled = True
                    Else
                        Btn1M1.Enabled = True
                        Btn1M5.Enabled = False
                    End If
                Else
                    Btn1M1.Enabled = False
                    Btn1M5.Enabled = False
                End If

                If _buy2 > 0 Then
                    If _buy2 >= 5 Then
                        Btn2M5.Enabled = True
                        Btn2M1.Enabled = True
                    Else
                        Btn2M1.Enabled = True
                        Btn2M5.Enabled = False
                    End If
                Else
                    Btn2M1.Enabled = False
                    Btn2M5.Enabled = False
                End If

                If _buy3 > 0 Then
                    If _buy3 >= 5 Then
                        Btn3M5.Enabled = True
                        Btn3M1.Enabled = True
                    Else
                        Btn3M1.Enabled = True
                        Btn3M5.Enabled = False
                    End If
                Else
                    Btn3M1.Enabled = False
                    Btn3M5.Enabled = False
                End If

                If _buy4 > 0 Then
                    If _buy4 >= 5 Then
                        Btn4M5.Enabled = True
                        Btn4M1.Enabled = True
                    Else
                        Btn4M1.Enabled = True
                        Btn4M5.Enabled = False
                    End If
                Else
                    Btn4M1.Enabled = False
                    Btn4M5.Enabled = False
                End If

                If _buy5 > 0 Then
                    If _buy5 >= 5 Then
                        Btn5M5.Enabled = True
                        Btn5M1.Enabled = True
                    Else
                        Btn5M1.Enabled = True
                        Btn5M5.Enabled = False
                    End If
                Else
                    Btn5M1.Enabled = False
                    Btn5M5.Enabled = False
                End If
            Else
                DisableAllMinus()
                BtnHire.Enabled = False
                BtnClear.Enabled = False
            End If
        End Sub

        Private Sub CheckPlusButtons()
            '* * * * *
            '* This method checks whether Plus buttons should be enabled.
            '* * * * *

            If _goldRemaining >= 100 Then
                If _goldRemaining >= 2500 Then
                    EnableAllPlus()
                ElseIf _goldRemaining >= 2000 Then
                    EnableAllPlus()
                    Btn5P5.Enabled = False
                ElseIf _goldRemaining >= 1500 Then
                    EnableAllPlus()
                    Btn5P5.Enabled = False
                    Btn4P5.Enabled = False
                ElseIf _goldRemaining >= 1000 Then
                    EnableAllPlus()
                    Btn5P5.Enabled = False
                    Btn4P5.Enabled = False
                    Btn3P5.Enabled = False
                ElseIf _goldRemaining >= 500 Then
                    EnableAllPlus()
                    Btn5P5.Enabled = False
                    Btn4P5.Enabled = False
                    Btn3P5.Enabled = False
                    Btn2P5.Enabled = False
                ElseIf _goldRemaining >= 400 Then
                    DisableAllPlus()
                    Btn1P1.Enabled = True
                    Btn2P1.Enabled = True
                    Btn3P1.Enabled = True
                    Btn4P1.Enabled = True
                ElseIf _goldRemaining >= 300 Then
                    DisableAllPlus()
                    Btn1P1.Enabled = True
                    Btn2P1.Enabled = True
                    Btn3P1.Enabled = True
                ElseIf _goldRemaining >= 200 Then
                    DisableAllPlus()
                    Btn1P1.Enabled = True
                    Btn2P1.Enabled = True
                ElseIf _goldRemaining >= 100 Then
                    DisableAllPlus()
                    Btn1P1.Enabled = True
                End If

                CheckMax()
            Else
                DisableAllPlus()
            End If
        End Sub

        Private Sub Clear()
            '* * * * *
            '* This method clears all relevant data on the form.
            '* * * * *

            _buy1 = 0
            _buy2 = 0
            _buy3 = 0
            _buy4 = 0
            _buy5 = 0
            _goldRemaining = _goldOnHand
            Display()
        End Sub

        Private Sub DisableAllMinus()
            '* * * * *
            '* This method disables all the minus buttons.
            '* * * * *

            Btn1M5.Enabled = False
            Btn2M5.Enabled = False
            Btn3M5.Enabled = False
            Btn4M5.Enabled = False
            Btn5M5.Enabled = False
            Btn1M1.Enabled = False
            Btn2M1.Enabled = False
            Btn2M1.Enabled = False
            Btn3M1.Enabled = False
            Btn4M1.Enabled = False
            Btn5M1.Enabled = False
        End Sub

        Private Sub DisableAllPlus()
            '* * * * *
            '* This method disables all Plus buttons.
            '* * * * *

            Btn1P1.Enabled = False
            Btn2P1.Enabled = False
            Btn3P1.Enabled = False
            Btn4P1.Enabled = False
            Btn5P1.Enabled = False
            Btn1P5.Enabled = False
            Btn2P5.Enabled = False
            Btn3P5.Enabled = False
            Btn4P5.Enabled = False
            Btn5P5.Enabled = False
        End Sub

        Public Sub Disablebuttons()
            '* * * * *
            '* This method disables all buttons except for Back.
            '* * * * *

            Btn1M5.Enabled = False
            Btn2M5.Enabled = False
            Btn3M5.Enabled = False
            Btn4M5.Enabled = False
            Btn5M5.Enabled = False
            Btn1M1.Enabled = False
            Btn2M1.Enabled = False
            Btn2M1.Enabled = False
            Btn3M1.Enabled = False
            Btn4M1.Enabled = False
            Btn5M1.Enabled = False
            Btn1P1.Enabled = False
            Btn2P1.Enabled = False
            Btn3P1.Enabled = False
            Btn4P1.Enabled = False
            Btn5P1.Enabled = False
            Btn1P5.Enabled = False
            Btn2P5.Enabled = False
            Btn3P5.Enabled = False
            Btn4P5.Enabled = False
            Btn5P5.Enabled = False

            BtnHire.Enabled = False
            BtnClear.Enabled = False
        End Sub

        Public Sub Display()
            '* * * * *
            '* This method displays all relevant data on the form.
            '* * * * *

            CheckPlusButtons()
            CheckMinusButtons()
            lblGoldOnHand.Text = _goldOnHand.ToString("N0")
            lblGoldRemaining.Text = _goldRemaining.ToString("N0")

            TxtHenchmenLevel1.Text = _henchmenLevel1.ToString
            TxtBuy1.Text = _buy1.ToString
            TxtHenchmenLevel2.Text = _henchmenLevel2.ToString
            TxtBuy2.Text = _buy2.ToString
            TxtHenchmenLevel3.Text = _henchmenLevel3.ToString
            TxtBuy3.Text = _buy3.ToString
            TxtHenchmenLevel4.Text = _henchmenLevel4.ToString
            TxtBuy4.Text = _buy4.ToString
            TxtHenchmenLevel5.Text = _henchmenLevel5.ToString
            TxtBuy5.Text = _buy5.ToString
        End Sub

        Public Sub EnableAllPlus()
            '* * * * *
            '* This method enables all Plus buttons.
            '* * * * *

            Btn1P1.Enabled = True
            Btn2P1.Enabled = True
            Btn3P1.Enabled = True
            Btn4P1.Enabled = True
            Btn5P1.Enabled = True
            Btn1P5.Enabled = True
            Btn2P5.Enabled = True
            Btn3P5.Enabled = True
            Btn4P5.Enabled = True
            Btn5P5.Enabled = True
        End Sub

        Public Sub HireText()
            '* * * * *
            '* This method handles adding text to the Textbox based on who was hired.
            '* * * * *

            Dim textHire As String = "You hire "

            If _buy1 > 0 Then
                If (_buy2 + _buy3 + _buy4 + _buy5) > 0 Then
                    textHire += _buy1 & " Level 1 Henchmen, "
                Else
                    textHire += _buy1 & " Level 1 Henchmen."
                End If
            End If

            If _buy2 > 0 Then
                If (_buy3 + _buy4 + _buy5) > 0 Then
                    textHire += _buy2 & " Level 2 Henchmen, "
                ElseIf _buy1 > 0 Then
                    textHire += "and " & _buy2 & " Level 2 Henchmen."
                Else
                    textHire += _buy2 & " Level 2 Henchmen."
                End If
            End If

            If _buy3 > 0 Then
                If (_buy4 + _buy5) > 0 Then
                    textHire += _buy2 & " Level 3 Henchmen, "
                ElseIf (_buy1 + _buy2) > 0 Then
                    textHire += "and " & _buy3 & " Level 3 Henchmen."
                Else
                    textHire += _buy3 & " Level 3 Henchmen."
                End If
            End If

            If _buy4 > 0 Then
                If _buy5 > 0 Then
                    textHire += _buy4 & " Level 4 Henchmen, "
                ElseIf (_buy1 + _buy2 + _buy3) > 0 Then
                    textHire += "and " & _buy4 & " Level 4 Henchmen."
                Else
                    textHire += _buy4 & " Level 4 Henchmen."
                End If
            End If

            If _buy5 > 0 Then
                If (_buy1 + _buy2 + _buy3 + _buy4) > 0 Then
                    textHire += "and " & _buy5 & " Level 5 Henchmen."
                Else
                    textHire += _buy5 & " Level 5 Henchmen."
                End If
            End If

            AddText(textHire)
        End Sub

        Public Sub SetUser()
            '* * * * *
            '* This method sets up a player to buy henchmen.
            '* * * * *

            _goldOnHand = CurrentUser.GoldOnHand
            _goldRemaining = _goldOnHand
            _henchmenLevel1 = CurrentUser.HenchmenLevel1
            _henchmenLevel2 = CurrentUser.HenchmenLevel2
            _henchmenLevel3 = CurrentUser.HenchmenLevel3
            _henchmenLevel4 = CurrentUser.HenchmenLevel4
            _henchmenLevel5 = CurrentUser.HenchmenLevel5
            Display()
        End Sub

        Public Sub SetGuild()

            '* * * * *
            '* This method sets up a guild to buy henchmen.
            '* * * * *

            _goldOnHand = CurrentGuild.Gold
            _goldRemaining = _goldOnHand
            _henchmenLevel1 = CurrentGuild.HenchmenLevel1
            _henchmenLevel2 = CurrentGuild.HenchmenLevel2
            _henchmenLevel3 = CurrentGuild.HenchmenLevel3
            _henchmenLevel4 = CurrentGuild.HenchmenLevel4
            _henchmenLevel5 = CurrentGuild.HenchmenLevel5
            Display()
        End Sub

        Private Sub Btn1M5_Click(sender As Object, e As EventArgs) Handles Btn1M5.Click
            '* * * * *
            '* This method removes 5 Level 1 Henchmen from the queue.
            '* * * * *

            _buy1 -= 5
            _goldRemaining += 500
            Display()
        End Sub

        Private Sub Btn1M1_Click(sender As Object, e As EventArgs) Handles Btn1M1.Click
            '* * * * *
            '* This method removes 1 Level 1 Henchman from the queue.
            '* * * * *

            _buy1 -= 1
            _goldRemaining += 100
            Display()
        End Sub

        Private Sub Btn1P1_Click(sender As Object, e As EventArgs) Handles Btn1P1.Click
            '* * * * *
            '* This method adds 1 Level 1 Henchman to the queue.
            '* * * * *

            _buy1 += 1
            _goldRemaining -= 100
            Display()
        End Sub

        Private Sub Btn1P5_Click(sender As Object, e As EventArgs) Handles Btn1P5.Click
            '* * * * *
            '* This method adds 5 Level 1 Henchmen to the queue.
            '* * * * *

            _buy1 += 5
            _goldRemaining -= 500
            Display()
        End Sub

        Private Sub Btn2M5_Click(sender As Object, e As EventArgs) Handles Btn2M5.Click
            '* * * * *
            '* This method removes 5 Level 2 Henchmen from the queue.
            '* * * * *

            _buy2 -= 5
            _goldRemaining += 1000
            Display()
        End Sub

        Private Sub Btn2M1_Click(sender As Object, e As EventArgs) Handles Btn2M1.Click
            '* * * * *
            '* This method removes 1 Level 2 Henchman to the queue.
            '* * * * *

            _buy2 -= 1
            _goldRemaining += 200
            Display()
        End Sub

        Private Sub Btn2P1_Click(sender As Object, e As EventArgs) Handles Btn2P1.Click
            '* * * * *
            '* This method adds 1 Level 2 Henchman to the queue.
            '* * * * *

            _buy2 += 1
            _goldRemaining -= 200
            Display()
        End Sub

        Private Sub Btn2P5_Click(sender As Object, e As EventArgs) Handles Btn2P5.Click
            '* * * * *
            '* This method adds 5 Level 2 Henchmen to the queue.
            '* * * * *

            _buy2 += 5
            _goldRemaining -= 1000
            Display()
        End Sub

        Private Sub Btn3M5_Click(sender As Object, e As EventArgs) Handles Btn3M5.Click
            '* * * * *
            '* This method removes 5 Level 3 Henchmen from the queue.
            '* * * * *

            _buy3 -= 5
            _goldRemaining += 1500
            Display()
        End Sub

        Private Sub Btn3M1_Click(sender As Object, e As EventArgs) Handles Btn3M1.Click
            '* * * * *
            '* This method removes 1 Level 3 Henchman from the queue.
            '* * * * *

            _buy3 -= 1
            _goldRemaining += 300
            Display()
        End Sub

        Private Sub Btn3P1_Click(sender As Object, e As EventArgs) Handles Btn3P1.Click
            '* * * * *
            '* This method adds 1 Level 3 Henchman to the queue.
            '* * * * *

            _buy3 += 1
            _goldRemaining -= 300
            Display()
        End Sub

        Private Sub Btn3P5_Click(sender As Object, e As EventArgs) Handles Btn3P5.Click
            '* * * * *
            '* This method adds 5 Level 3 Henchmen to the queue.
            '* * * * *

            _buy3 += 5
            _goldRemaining -= 1500
            Display()
        End Sub

        Private Sub Btn4M5_Click(sender As Object, e As EventArgs) Handles Btn4M5.Click
            '* * * * *
            '* This method removes 5 Level 4 Henchmen from the queue.
            '* * * * *

            _buy4 -= 5
            _goldRemaining += 2000
            Display()
        End Sub

        Private Sub Btn4M1_Click(sender As Object, e As EventArgs) Handles Btn4M1.Click
            '* * * * *
            '* This method removes 1 Level 4 Henchman from the queue.
            '* * * * *

            _buy4 -= 1
            _goldRemaining += 400
            Display()
        End Sub

        Private Sub Btn4P1_Click(sender As Object, e As EventArgs) Handles Btn4P1.Click
            '* * * * *
            '* This method adds 1 Level 4 Henchman to the queue.
            '* * * * *

            _buy4 += 1
            _goldRemaining -= 400
            Display()
        End Sub

        Private Sub Btn4P5_Click(sender As Object, e As EventArgs) Handles Btn4P5.Click
            '* * * * *
            '* This method adds 5 Level 4 Henchmen to the queue.
            '* * * * *

            _buy4 += 5
            _goldRemaining -= 2000
            Display()
        End Sub

        Private Sub Btn5M5_Click(sender As Object, e As EventArgs) Handles Btn5M5.Click
            '* * * * *
            '* This method removes 5 Level 5 Henchmen from the queue.
            '* * * * *

            _buy5 -= 5
            _goldRemaining += 2500
            Display()
        End Sub

        Private Sub Btn5M1_Click(sender As Object, e As EventArgs) Handles Btn5M1.Click
            '* * * * *
            '* This method removes 1 Level 5 Henchman from the queue.
            '* * * * *

            _buy5 -= 1
            _goldRemaining += 500
            Display()
        End Sub

        Private Sub Btn5P1_Click(sender As Object, e As EventArgs) Handles Btn5P1.Click
            '* * * * *
            '* This method adds 1 Level 5 Henchman to the queue.
            '* * * * *

            _buy5 += 1
            _goldRemaining -= 500
            Display()
        End Sub

        Private Sub Btn5P5_Click(sender As Object, e As EventArgs) Handles Btn5P5.Click
            '* * * * *
            '* This method adds 5 Level 5 Henchmen to the queue.
            '* * * * *

            _buy5 += 5
            _goldRemaining -= 2500
            Display()
        End Sub

        Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
            '* * * * *
            '* This method closes the form on clicking the Back button.
            '* * * * *

            Close()
        End Sub

        Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
            '* * * * *
            '* This method clears all data on the form.
            '* * * * *

            Clear()
        End Sub

        Private Async Sub BtnHire_Click(sender As Object, e As EventArgs) Handles BtnHire.Click
            '* * * * *
            '* This method hires the henchmen allocated.
            '* * * * *

            If BlnGuild = True Then 'hire henchmen for guild
                CurrentGuild.HenchmenLevel1 += _buy1
                CurrentGuild.HenchmenLevel2 += _buy2
                CurrentGuild.HenchmenLevel3 += _buy3
                CurrentGuild.HenchmenLevel4 += _buy4
                CurrentGuild.HenchmenLevel5 += _buy5
                CurrentGuild.Gold = _goldRemaining
                Await SaveGuild(CurrentGuild)
                SetGuild()
            Else                    'hire henchmen for user
                CurrentUser.HenchmenLevel1 += _buy1
                CurrentUser.HenchmenLevel2 += _buy2
                CurrentUser.HenchmenLevel3 += _buy3
                CurrentUser.HenchmenLevel4 += _buy4
                CurrentUser.HenchmenLevel5 += _buy5
                CurrentUser.GoldOnHand = _goldRemaining
                Await SaveUser(CurrentUser)
                SetUser()
            End If

            HireText()
            _goldOnHand = _goldRemaining
            Clear()
        End Sub

        Private Sub FrmHireHenchmen_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
            '* * * * *
            '* This method handles closing the form.
            '* * * * *

            If BlnGuild = True Then
                FrmGuildManage.Show()
                FrmGuildManage.AddText(TxtHire.Text)
            Else
                FrmGuild.Show()
                FrmGuild.AddText(TxtHire.Text)
            End If
        End Sub

    End Class

End Namespace