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

        ''' <summary>Add text to the TextBox.</summary>
        ''' <param name="newText">Text to be added</param>
        Public Sub AddText(newText As String)
            AddTextToTextBox(TxtHire, newText)
        End Sub

        ''' <summary>Checks whether you have the maximum number of henchmen for a given level.</summary>
        Private Sub CheckMax()
            Btn1P1.Enabled = _henchmenLevel1 > 998
            Btn1P5.Enabled = _henchmenLevel1 > 994

            Btn2P1.Enabled = _henchmenLevel2 > 998
            Btn2P5.Enabled = _henchmenLevel2 > 994

            Btn3P1.Enabled = _henchmenLevel3 > 998
            Btn3P5.Enabled = _henchmenLevel3 > 994

            Btn4P1.Enabled = _henchmenLevel4 > 998
            Btn4P5.Enabled = _henchmenLevel4 > 994

            Btn5P1.Enabled = _henchmenLevel5 > 998
            Btn5P5.Enabled = _henchmenLevel5 > 994
        End Sub

        ''' <summary>Checks all Minus buttons.</summary>
        Private Sub CheckMinusButtons()
            If (_buy1 + _buy2 + _buy3 + _buy4 + _buy5) > 0 Then
                BtnHire.Enabled = True
                BtnClear.Enabled = True

                Btn1M5.Enabled = _buy1 >= 5
                Btn1M1.Enabled = _buy1 >= 1

                Btn2M5.Enabled = _buy2 >= 5
                Btn2M1.Enabled = _buy2 >= 1

                Btn3M5.Enabled = _buy3 >= 5
                Btn3M1.Enabled = _buy3 >= 1

                Btn4M5.Enabled = _buy4 >= 5
                Btn4M1.Enabled = _buy4 >= 1

                Btn5M5.Enabled = _buy5 >= 5
                Btn5M1.Enabled = _buy5 >= 1
            Else
                DisableAllMinus()
                BtnHire.Enabled = False
                BtnClear.Enabled = False
            End If
        End Sub

        ''' <summary>Checks whether Plus buttons should be enabled.</summary>
        Private Sub CheckPlusButtons()
            If _goldRemaining >= 100 Then
                If _goldRemaining >= 2500 Then
                    ToggleAllPlus(True)
                ElseIf _goldRemaining >= 2000 Then
                    ToggleAllPlus(True)
                    Btn5P5.Enabled = False
                ElseIf _goldRemaining >= 1500 Then
                    ToggleAllPlus(True)
                    Btn5P5.Enabled = False
                    Btn4P5.Enabled = False
                ElseIf _goldRemaining >= 1000 Then
                    ToggleAllPlus(True)
                    Btn5P5.Enabled = False
                    Btn4P5.Enabled = False
                    Btn3P5.Enabled = False
                ElseIf _goldRemaining >= 500 Then
                    ToggleAllPlus(True)
                    Btn5P5.Enabled = False
                    Btn4P5.Enabled = False
                    Btn3P5.Enabled = False
                    Btn2P5.Enabled = False
                ElseIf _goldRemaining >= 400 Then
                    ToggleAllPlus(False)
                    Btn1P1.Enabled = True
                    Btn2P1.Enabled = True
                    Btn3P1.Enabled = True
                    Btn4P1.Enabled = True
                ElseIf _goldRemaining >= 300 Then
                    ToggleAllPlus(False)
                    Btn1P1.Enabled = True
                    Btn2P1.Enabled = True
                    Btn3P1.Enabled = True
                ElseIf _goldRemaining >= 200 Then
                    ToggleAllPlus(False)
                    Btn1P1.Enabled = True
                    Btn2P1.Enabled = True
                ElseIf _goldRemaining >= 100 Then
                    ToggleAllPlus(False)
                    Btn1P1.Enabled = True
                End If

                CheckMax()
            Else
                ToggleAllPlus(False)
            End If
        End Sub

        ''' <summary>Clears all relevant data on the form.</summary>
        Private Sub Clear()
            _buy1 = 0
            _buy2 = 0
            _buy3 = 0
            _buy4 = 0
            _buy5 = 0
            _goldRemaining = _goldOnHand
            Display()
        End Sub

        ''' <summary>Disables all the minus buttons.</summary>
        Private Sub DisableAllMinus()
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

        ''' <summary>Toggles all Plus Buttons.</summary>
        ''' <param name="enabled">Should the Buttons be enabled?</param>
        Private Sub ToggleAllPlus(enabled As Boolean)
            Btn1P1.Enabled = enabled
            Btn2P1.Enabled = enabled
            Btn3P1.Enabled = enabled
            Btn4P1.Enabled = enabled
            Btn5P1.Enabled = enabled
            Btn1P5.Enabled = enabled
            Btn2P5.Enabled = enabled
            Btn3P5.Enabled = enabled
            Btn4P5.Enabled = enabled
            Btn5P5.Enabled = enabled
        End Sub

        ''' <summary>Disables all buttons except for Back.</summary>
        Public Sub DisableButtons()
            DisableAllMinus()
            ToggleAllPlus(False)

            BtnHire.Enabled = False
            BtnClear.Enabled = False
        End Sub

        ''' <summary>Displays all relevant data on the form.</summary>
        Public Sub Display()
            CheckPlusButtons()
            CheckMinusButtons()
            LblGoldOnHand.Text = _goldOnHand.ToString("N0")
            LblGoldRemaining.Text = _goldRemaining.ToString("N0")

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

        ''' <summary>Handles adding text to the Textbox based on who was hired.</summary>
        Public Sub HireText()
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

        ''' <summary>Sets up a player to buy henchmen.</summary>
        Public Sub SetUser()
            _goldOnHand = CurrentUser.GoldOnHand
            _goldRemaining = _goldOnHand
            _henchmenLevel1 = CurrentUser.HenchmenLevel1
            _henchmenLevel2 = CurrentUser.HenchmenLevel2
            _henchmenLevel3 = CurrentUser.HenchmenLevel3
            _henchmenLevel4 = CurrentUser.HenchmenLevel4
            _henchmenLevel5 = CurrentUser.HenchmenLevel5
            Display()
        End Sub

        ''' <summary>Sets up a <see cref="Guild"/> to buy henchmen.</summary>
        Public Sub SetGuild()
            _goldOnHand = CurrentGuild.Gold
            _goldRemaining = _goldOnHand
            _henchmenLevel1 = CurrentGuild.HenchmenLevel1
            _henchmenLevel2 = CurrentGuild.HenchmenLevel2
            _henchmenLevel3 = CurrentGuild.HenchmenLevel3
            _henchmenLevel4 = CurrentGuild.HenchmenLevel4
            _henchmenLevel5 = CurrentGuild.HenchmenLevel5
            Display()
        End Sub

        ''' <summary>Adjusts the number of level 1 Henchmen being hired.</summary>
        ''' <param name="amount">Amount of henchmen to hire</param>
        Private Sub AdjustLevel1(amount As Integer)
            _buy1 += amount
            _goldRemaining += amount * 100
            Display()
        End Sub

        ''' <summary>Adjusts the number of level 2 Henchmen being hired.</summary>
        ''' <param name="amount">Amount of henchmen to hire</param>
        Private Sub AdjustLevel2(amount As Integer)
            _buy2 += amount
            _goldRemaining += amount * 200
            Display()
        End Sub

        ''' <summary>Adjusts the number of level 3 Henchmen being hired.</summary>
        ''' <param name="amount">Amount of henchmen to hire</param>
        Private Sub AdjustLevel3(amount As Integer)
            _buy3 += amount
            _goldRemaining += amount * 300
            Display()
        End Sub

        ''' <summary>Adjusts the number of level 4 Henchmen being hired.</summary>
        ''' <param name="amount">Amount of henchmen to hire</param>
        Private Sub AdjustLevel4(amount As Integer)
            _buy4 += amount
            _goldRemaining += amount * 400
            Display()
        End Sub

        ''' <summary>Adjusts the number of level 5 Henchmen being hired.</summary>
        ''' <param name="amount">Amount of henchmen to hire</param>
        Private Sub AdjustLevel5(amount As Integer)
            _buy5 += amount
            _goldRemaining += amount * 500
            Display()
        End Sub

#Region "Click"

        Private Sub Btn1M5_Click(sender As Object, e As EventArgs) Handles Btn1M5.Click
            AdjustLevel1(-5)
        End Sub

        Private Sub Btn1M1_Click(sender As Object, e As EventArgs) Handles Btn1M1.Click
            AdjustLevel1(-1)
        End Sub

        Private Sub Btn1P1_Click(sender As Object, e As EventArgs) Handles Btn1P1.Click
            AdjustLevel1(1)
        End Sub

        Private Sub Btn1P5_Click(sender As Object, e As EventArgs) Handles Btn1P5.Click
            AdjustLevel1(5)
        End Sub

        Private Sub Btn2M5_Click(sender As Object, e As EventArgs) Handles Btn2M5.Click
            AdjustLevel2(-5)
        End Sub

        Private Sub Btn2M1_Click(sender As Object, e As EventArgs) Handles Btn2M1.Click
            AdjustLevel2(-1)
        End Sub

        Private Sub Btn2P1_Click(sender As Object, e As EventArgs) Handles Btn2P1.Click
            AdjustLevel2(1)
        End Sub

        Private Sub Btn2P5_Click(sender As Object, e As EventArgs) Handles Btn2P5.Click
            AdjustLevel2(5)
        End Sub

        Private Sub Btn3M5_Click(sender As Object, e As EventArgs) Handles Btn3M5.Click
            AdjustLevel3(-5)
        End Sub

        Private Sub Btn3M1_Click(sender As Object, e As EventArgs) Handles Btn3M1.Click
            AdjustLevel3(-1)
        End Sub

        Private Sub Btn3P1_Click(sender As Object, e As EventArgs) Handles Btn3P1.Click
            AdjustLevel3(1)
        End Sub

        Private Sub Btn3P5_Click(sender As Object, e As EventArgs) Handles Btn3P5.Click
            AdjustLevel3(5)
        End Sub

        Private Sub Btn4M5_Click(sender As Object, e As EventArgs) Handles Btn4M5.Click
            AdjustLevel4(-5)
        End Sub

        Private Sub Btn4M1_Click(sender As Object, e As EventArgs) Handles Btn4M1.Click
            AdjustLevel4(-1)
        End Sub

        Private Sub Btn4P1_Click(sender As Object, e As EventArgs) Handles Btn4P1.Click
            AdjustLevel4(1)
        End Sub

        Private Sub Btn4P5_Click(sender As Object, e As EventArgs) Handles Btn4P5.Click
            AdjustLevel4(5)
        End Sub

        Private Sub Btn5M5_Click(sender As Object, e As EventArgs) Handles Btn5M5.Click
            AdjustLevel5(-5)
        End Sub

        Private Sub Btn5M1_Click(sender As Object, e As EventArgs) Handles Btn5M1.Click
            AdjustLevel5(-1)
        End Sub

        Private Sub Btn5P1_Click(sender As Object, e As EventArgs) Handles Btn5P1.Click
            AdjustLevel5(1)
        End Sub

        Private Sub Btn5P5_Click(sender As Object, e As EventArgs) Handles Btn5P5.Click
            AdjustLevel5(5)
        End Sub

        Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
            Close()
        End Sub

        Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
            Clear()
        End Sub

        Private Async Sub BtnHire_Click(sender As Object, e As EventArgs) Handles BtnHire.Click
            If BlnGuild = True Then
                CurrentGuild.HenchmenLevel1 += _buy1
                CurrentGuild.HenchmenLevel2 += _buy2
                CurrentGuild.HenchmenLevel3 += _buy3
                CurrentGuild.HenchmenLevel4 += _buy4
                CurrentGuild.HenchmenLevel5 += _buy5
                CurrentGuild.Gold = _goldRemaining
                Await SaveGuild(CurrentGuild)
                SetGuild()
            Else
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

#End Region

        Private Sub FrmHireHenchmen_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
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