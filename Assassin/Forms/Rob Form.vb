' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 05/25/2012
' Filename        : Rob Form.vb
' Description     : This form allows a user to rob a victim.

Option Strict On
Option Explicit On

Imports Assassin.Classes
Imports Assassin.Classes.Entities
Imports Extensions

Namespace Forms

    Public Class FrmRob

        Dim CurrentEnemy As New Enemy              'current enemy
        Dim _nl As String = ControlChars.NewLine 'new line
        Dim _blnCourt As Boolean = False         'boolean if going to court
        Dim _arrText As New ArrayList            'arraylist of text
        Dim _index As Integer                    'index on arraylist
        Dim _reason As String                    'reason arrested

        Public Sub AddText(newText As String)
            '* * * * *
            '* This method adds text to the Textbox.
            '* * * * *

            Dim currText As String = TxtRob.Text
            TxtRob.Clear()

            TxtRob.Text = newText & _nl & _nl & currText
            TxtRob.Select(0, 0)
            TxtRob.ScrollToCaret()
        End Sub

        Public Sub CheckHungerThirst()
            '* * * * *
            '* This method checks a user's hunger and thirst.
            '* * * * *

            If CurrentUser.Hunger >= 24 OrElse CurrentUser.Thirst >= 24 Then
                BtnNewVictim.Enabled = False
                BtnPickpocket.Enabled = False
                BtnWaylay.Enabled = False

                If CurrentUser.Hunger >= 24 AndAlso CurrentUser.Thirst >= 24 Then
                    AddText("You are too hungry and thirsty to continue.")
                ElseIf CurrentUser.Hunger >= 24 Then
                    AddText("You are too hungry to continue.")
                ElseIf CurrentUser.Thirst >= 24 Then
                    AddText("You are too thirsty to continue.")
                End If
            Else
                If CurrentUser.Hunger > 0 AndAlso CurrentUser.Hunger Mod 5 = 0 Then
                    AddText("You are " & GetHunger(CurrentUser.Hunger).ToLower & ".")
                End If
                If CurrentUser.Thirst > 0 AndAlso CurrentUser.Thirst Mod 5 = 0 Then
                    AddText("You are " & GetThirst(CurrentUser.Thirst).ToLower & ".")
                End If
            End If
        End Sub

        Private Sub DisableButtons()
            '* * * * *
            '* This method disables all the buttons while a robbery is in progress or while searching for a new victim.
            '* * * * *

            BtnBack.Enabled = False
            BtnPickpocket.Enabled = False
            BtnWaylay.Enabled = False
            BtnNewVictim.Enabled = False
        End Sub

        Public Sub Display()
            '* * * * *
            '* This method displays text while the Timer is active.
            '* * * * *

            If _index < _arrText.Count Then
                AddText(_arrText(_index).ToString)
                _index += 1
                If _index = _arrText.Count Then
                    _arrText.Clear()
                    Timer1.Stop()
                    _index = 0
                    EnableButtons()
                    CheckHungerThirst()
                End If
            End If
        End Sub

        Private Sub EnableButtons()
            '* * * * *
            '* This method enabled all the buttons after a robbery is completed or after searching for a new victim.
            '* * * * *

            BtnBack.Enabled = True
            BtnPickpocket.Enabled = True
            BtnWaylay.Enabled = True
            BtnNewVictim.Enabled = True
        End Sub

        Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
            '* * * * *
            '* This method closes the form on clicking the Back button.
            '* * * * *

            Me.Close()
        End Sub

        Private Sub BtnNewVictim_Click(sender As Object, e As EventArgs) Handles BtnNewVictim.Click
            '* * * * *
            '* This method gets a new enemy.
            '* * * * *

            GetEnemy()
        End Sub

        Private Async Sub BtnPickpocket_Click(sender As Object, e As EventArgs) Handles BtnPickpocket.Click
            '* * * * *
            '* This method produces the result of attempting to pickpocket an opponent.
            '* * * * *

            CurrentUser.Hunger += 1
            CurrentUser.Thirst += 1

            Dim success As Integer = Functions.GenerateRandomNumber(1, 100)
            If success <= CurrentUser.Stealth Then     'successful pickpocket
                Dim type As Integer = Functions.GenerateRandomNumber(1, 3)
                Dim gold As Integer = Functions.GenerateRandomNumber(1, CurrentEnemy.MaximumEndurance)
                If type = 1 Then                    'gold only
                    AddText("You manage to steal a pouch containing " & gold & " gold!")
                    CurrentUser.GoldOnHand += gold
                ElseIf type = 2 Then                'weapon only
                    AddText("You manage to pickpocket their " & CurrentEnemy.Weapon.Name & "!")
                    _arrText.Add("You bring it to the weaponsmith and sell it for " & (CurrentEnemy.Weapon.Value \ 2) & " gold!")
                    CurrentUser.GoldOnHand += (CurrentEnemy.Weapon.Value \ 2)
                    Timer1.Start()
                ElseIf type = 3 Then                'weapon and gold
                    AddText("You manage to steal a pouch containing " & gold & " gold!")
                    _arrText.Add("You also manage to pickpocket their " & CurrentEnemy.Weapon.Name & "!")
                    _arrText.Add("You bring it to the weapon shop and sell it for " & (CurrentEnemy.Weapon.Value \ 2) & " gold!")
                    CurrentUser.GoldOnHand += (CurrentEnemy.Weapon.Value \ 2) + gold
                    Timer1.Start()
                End If

                Await SaveUser(CurrentUser)
                GetEnemy()
            Else                                    'failure pickpocket
                AddText("You have failed miserably!")
                Dim noticed As Integer = Functions.GenerateRandomNumber(1, 100)
                If noticed <= CurrentUser.Stealth Then  'not caught
                    _arrText.Add("You got away without being noticed.")
                    GetEnemy()
                Else                                'caught
                    _arrText.Add("You have been noticed!")
                    _arrText.Add("The " & CurrentEnemy.Name & " cries out, " & Chr(34) & "Guards, a thief!" & Chr(34))
                    _arrText.Add("You hide. . .")
                    Dim spot As Integer = Functions.GenerateRandomNumber(1, 100)
                    If spot <= CurrentUser.Stealth Then    'not spotted
                        _arrText.Add("It appears you have escaped!")
                        Timer1.Start()
                        GetEnemy()
                    Else                                'spotted
                        Timer1.Start()
                        _reason = "Pickpocket"
                        Timer2.Start()
                    End If
                End If
            End If
        End Sub

        Private Async Sub BtnWaylay_Click(sender As Object, e As EventArgs) Handles BtnWaylay.Click
            '* * * * *
            '* This method handles the attempt made to Waylay an opponent.
            '* * * * *

            CurrentUser.Hunger += 1
            CurrentUser.Thirst += 1

            Dim success As Integer = Functions.GenerateRandomNumber(1, 100)
            If success <= CurrentUser.Stealth Then     'successful waylay
                Dim type As Integer = Functions.GenerateRandomNumber(1, 3)
                Dim gold As Integer = Functions.GenerateRandomNumber(1, CurrentEnemy.MaximumEndurance)
                If type = 1 Then                    'gold only
                    AddText("You manage to steal a pouch containing " & gold & " gold!")
                    CurrentUser.GoldOnHand += gold
                ElseIf type = 2 Then                'weapon only
                    AddText("You manage to pickpocket their " & CurrentEnemy.Weapon.Name & "!")
                    _arrText.Add("You bring it to the weaponsmith and sell it for " & (CurrentEnemy.Weapon.Value \ 2) & " gold!")
                    CurrentUser.GoldOnHand += (CurrentEnemy.Weapon.Value \ 2)
                    Timer1.Start()
                ElseIf type = 3 Then                'weapon and gold
                    AddText("You manage to steal a pouch containing " & gold & " gold!")
                    _arrText.Add("You also manage to pickpocket their " & CurrentEnemy.Weapon.Name & "!")
                    _arrText.Add("You bring it to the weapon shop and sell it for " & (CurrentEnemy.Weapon.Value \ 2) & " gold!")
                    CurrentUser.GoldOnHand += (CurrentEnemy.Weapon.Value \ 2) + gold
                    Timer1.Start()
                End If

                Await SaveUser(CurrentUser)
                GetEnemy()
            Else                                        'failure waylay
                AddText("You have failed miserably!")
                Dim noticed As Integer = Functions.GenerateRandomNumber(1, 100)
                If noticed <= CurrentUser.Stealth Then  'not caught
                    _arrText.Add("You got away without being noticed.")
                    GetEnemy()
                Else                                'caught
                    _arrText.Add("You have been noticed!")
                    _arrText.Add("The " & CurrentEnemy.Name & " cries out, " & Chr(34) & "Guards, a thief!" & Chr(34))
                    _arrText.Add("You hide. . .")
                    Dim spot As Integer = Functions.GenerateRandomNumber(1, 100)
                    If spot <= CurrentUser.Stealth Then    'not spotted
                        _arrText.Add("It appears you have escaped!")
                        Timer1.Start()
                        GetEnemy()
                    Else                                'spotted
                        Timer1.Start()
                        _reason = "Assault"
                        Timer2.Start()
                    End If
                End If
            End If
        End Sub

        Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
            '* * * * *
            '* This method calls the display method every time a tick passes on the Timer.
            '* * * * *

            Display()
        End Sub

        Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
            '* * * * *
            '* This method displays the court form after a user is caught.
            '* * * * *

            FrmCourt.Show()
            FrmCourt.Reason = _reason
            FrmCourt.TxtCourt.Text = "You have been caught!"
            FrmCourt.Setup()
            _blnCourt = True
            Me.Close()
        End Sub

        Private Async Sub FrmRob_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
            '* * * * *
            '* This method determines which form to show on form closing.
            '* * * * *

            If _blnCourt = False Then
                FrmGame.Show()
                Await SaveUser(CurrentUser)
                FrmGame.Display()
                AddText("You return to the streets.")
            End If

            FrmGame.AddText(TxtRob.Text)
        End Sub

    End Class

End Namespace