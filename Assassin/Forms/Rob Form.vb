Option Strict On
Option Explicit On

Imports Assassin.Classes
Imports Assassin.Classes.Entities
Imports Assassin.Classes.Enums
Imports Extensions

Namespace Forms

    Public Class FrmRob
        Dim _blnCourt As Boolean = False
        Dim _arrText As New ArrayList
        Dim _index As Integer
        Dim _reason As Crime

        ''' <summary>Add text to the TextBox.</summary>
        ''' <param name="newText">Text to be added</param>
        Private Sub AddText(newText As String)
            AddTextToTextBox(TxtRob, newText)
        End Sub

        ''' <summary>Checks a user's hunger and thirst.</summary>
        Public Function CheckHungerThirst() As Boolean
            AddText(CurrentUser.DisplayHungerThirstText())
            If CurrentUser.CanDoAction() Then
                Return True
            End If
            ToggleButtons(False)
            BtnBack.Enabled = True
            Return False
        End Function

        ''' <summary>Loads the Robbery Form.</summary>
        Public Sub LoadRobbery()
            If CheckHungerThirst() Then
                TxtRob.Text = "You proceed to look for someone to rob."
                GetEnemy()
            End If
        End Sub

#Region "Display Manipulation"

        ''' <summary>Displays text while the Timer is active.</summary>
        Private Sub Display()
            If _index < _arrText.Count Then
                AddText(_arrText(_index).ToString)
                _index += 1
                If _index = _arrText.Count Then
                    _arrText.Clear()
                    Timer1.Stop()
                    _index = 0
                    If Not _blnCourt Then
                        ToggleBackNewVictim(True)
                        CheckHungerThirst()
                    Else
                        BtnBack.Enabled = True
                        BtnBack.Text = "&Court"
                    End If
                End If
            End If
        End Sub

        ''' <summary>Toggles the Back and New Victim Buttons .</summary>
        Private Sub ToggleBackNewVictim(enabled As Boolean)
            BtnNewVictim.Enabled = enabled
            BtnBack.Enabled = enabled
        End Sub

        ''' <summary>Toggles all the Buttons.</summary>
        Private Sub ToggleButtons(enabled As Boolean)
            ToggleBackNewVictim(enabled)
            BtnPickpocket.Enabled = enabled
            BtnWaylay.Enabled = enabled
        End Sub

#End Region

        ''' <summary>The <see cref="User"/> failed in attemping to rob an <see cref="Enemy"/>.</summary>
        Private Sub FailedRobbery()
            AddText("You have failed miserably!")
            Dim noticed As Integer = Functions.GenerateRandomNumber(1, 100)
            If noticed <= CurrentUser.Stealth Then 'not caught
                AddText("You got away without being noticed.")
                ToggleBackNewVictim(True)
            Else 'caught
                _arrText.Add("You have been noticed!")
                _arrText.Add($"The {CurrentEnemy.Name} cries out, ""Guards, a thief!""")
                _arrText.Add("You hide. . .")
                Dim spot As Integer = Functions.GenerateRandomNumber(1, 100)
                If spot <= CurrentUser.Stealth Then 'not spotted
                    _arrText.Add("It appears you have escaped!")
                    Timer1.Start()
                Else 'spotted
                    _blnCourt = True
                    _arrText.Add("You have been caught!")
                    Timer1.Start()
                End If
            End If
        End Sub

        ''' <summary>Starts a robbery.</summary>
        Private Sub StartRobbery()
            ToggleButtons(False)
            CurrentUser.GainHungerThirst()
        End Sub

#Region "Click"

        Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
            Close()
        End Sub

        Private Sub BtnNewVictim_Click(sender As Object, e As EventArgs) Handles BtnNewVictim.Click
            GetEnemy()
            AddText("You search for a new victim.")
            ToggleButtons(True)
        End Sub

        Private Async Sub BtnPickpocket_Click(sender As Object, e As EventArgs) Handles BtnPickpocket.Click
            If CheckHungerThirst() Then
                StartRobbery()
                Dim success As Integer = Functions.GenerateRandomNumber(1, 100)
                If success <= CurrentUser.Stealth Then 'successful pickpocket
                    Dim gold As Integer = Functions.GenerateRandomNumber(1, CurrentEnemy.MaximumEndurance)
                    AddText($"You manage to steal a pouch containing {gold} gold!")
                    CurrentUser.GoldOnHand += gold
                    Await SaveUser(CurrentUser)
                    ToggleBackNewVictim(True)
                Else 'failure pickpocket
                    _reason = Crime.Pickpocket
                    FailedRobbery()
                End If
            End If
        End Sub

        Private Async Sub BtnWaylay_Click(sender As Object, e As EventArgs) Handles BtnWaylay.Click
            If CheckHungerThirst() Then
                StartRobbery()
                Dim success As Integer = Functions.GenerateRandomNumber(1, 100)
                If success <= CurrentUser.Stealth Then 'successful waylay
                    Dim type As Integer = Functions.GenerateRandomNumber(1, 3)
                    Dim gold As Integer = Functions.GenerateRandomNumber(1, CurrentEnemy.MaximumEndurance)
                    If type = 1 Then 'gold only
                        AddText($"You manage to steal a pouch containing {gold} gold!")
                        CurrentUser.GoldOnHand += gold
                        ToggleBackNewVictim(True)
                    ElseIf type = 2 Then 'weapon only
                        AddText($"You manage to pickpocket their {CurrentEnemy.Weapon.Name}!")
                        _arrText.Add($"You bring it to the weaponsmith and sell it for {CurrentEnemy.Weapon.SellValue} gold!")
                        CurrentUser.GoldOnHand += CurrentEnemy.Weapon.SellValue
                        Timer1.Start()
                    ElseIf type = 3 Then 'weapon and gold
                        AddText($"You manage to steal a pouch containing {gold} gold!")
                        _arrText.Add($"You also manage to pickpocket their {CurrentEnemy.Weapon.Name}!")
                        _arrText.Add($"You bring it to the weapon shop and sell it for {CurrentEnemy.Weapon.SellValue} gold!")
                        CurrentUser.GoldOnHand += CurrentEnemy.Weapon.SellValue + gold
                        Timer1.Start()
                    End If

                    Await SaveUser(CurrentUser)
                Else 'failure waylay
                    _reason = Crime.Assault
                    FailedRobbery()
                End If
            End If
        End Sub

#End Region

        Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
            Display()
        End Sub

        Private Async Sub FrmRob_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
            If Not _blnCourt Then
                FrmGame.Show()
                Await SaveUser(CurrentUser)
                FrmGame.Display()
                AddText("You return to the streets.")
                FrmGame.AddText(TxtRob.Text.Trim())
            Else
                FrmCourt.Show()
                FrmCourt.Reason = _reason
                FrmCourt.Setup()
            End If
        End Sub

    End Class

End Namespace