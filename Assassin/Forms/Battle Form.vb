' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 05/25/2012
' Filename        : Battle Form.vb
' Description     : This form allows battles.

Option Strict On
Option Explicit On

Imports Assassin.Classes
Imports Assassin.Classes.Enums
Imports Extensions

Namespace Forms

    Public Class FrmBattle

        Dim _blnDone As Boolean = False          'battle over?
        Public BlnJob As Boolean = False        'on the job?
        Dim _blnWin As Boolean = False           'win?
        Dim _userStamina As Integer = 20
        Dim _enemyStamina As Integer = 20
        Dim _userStance As Stance
        Dim _enemyStance As Stance

        Private Function Bonus() As Integer
            '* * * * *
            '* This method gives a user a bonus.
            '* * * * *

            If CurrentUser.Level <= 4 Then
                Return (11 - CurrentUser.Level) * 5
            Else
                Return 0
            End If
        End Function

        Private Function EnemyBlock() As Boolean
            '* * * * *
            '* This method determines whether the enemy blocks an attack.
            '* * * * *

            Dim toBlock As Integer = Functions.GenerateRandomNumber(1, 100)
            If toBlock <= CurrentEnemy.Blocking Then
                Return True
            Else
                Return False
            End If
        End Function

        Private Function EnemyHit() As Boolean
            '* * * * *
            '* This method determines whether the enemy's attack hits.
            '* * * * *

            Dim toHit As Integer = Functions.GenerateRandomNumber(1, 100)
            If toHit <= CurrentEnemy.WeaponSkill Then
                Return True
            Else
                Return False
            End If
        End Function

        Private Function PlayerBlock() As Boolean
            '* * * * *
            '* This method determines whether the player blocks an attack.
            '* * * * *

            Dim toBlock As Integer = Functions.GenerateRandomNumber(1, 100)
            If toBlock <= CurrentUser.Blocking Then
                Return True
            Else
                Return False
            End If
        End Function

        Private Function PlayerHit() As Boolean
            '* * * * *
            '* This method determines whether the player's attack hits.
            '* * * * *

            Dim toHit As Integer = Functions.GenerateRandomNumber(1, 100)
            If toHit <= CurrentUser.CurrentWeaponSkill Then
                Return True
            Else
                Return False
            End If
        End Function

        Private Function Status(stamina As Integer) As String
            '* * * * *
            '* This method determines the status text to be returned.
            '* * * * *

            Select Case stamina
                Case 19, 20
                    Return "Vigorous"
                Case 17, 18
                    Return "Robust"
                Case 15, 16
                    Return "Stalwart"
                Case 13, 14
                    Return "Beat"
                Case 11, 12
                    Return "Shaky"
                Case 9, 10
                    Return "Spent"
                Case 7, 8
                    Return "Bushed"
                Case 5, 6
                    Return "Weary"
                Case 3, 4
                    Return "Tired"
                Case 0, 1, 2
                    Return "Exhausted"
                Case Else
                    Return "BROKEN"
            End Select
        End Function

        Public Sub AddText(newText As String)
            AddTextToTextBox(txtBattle, newText)
        End Sub

        Public Sub Display()
            '* * * * *
            '* This method displays all the displayable information in the labels on the form.
            '* * * * *

            'player
            If CurrentUser.CurrentEndurance <= (CurrentUser.MaximumEndurance * 0.2) Then
                lblPlrEnd.ForeColor = Color.Red
            Else
                lblPlrEnd.ForeColor = Color.Black
            End If
            lblPlrEnd.Text = CurrentUser.CurrentEndurance & " / " & CurrentUser.MaximumEndurance
            lblPlrStatus.Text = Status(_userStamina)
            If _userStamina < 3 Then
                lblPlrStatus.ForeColor = Color.Red
            Else
                lblPlrStatus.ForeColor = Color.Black
            End If
            lblPlrWeapon.Text = CurrentUser.CurrentWeapon.Name
            lblPlrArmor.Text = CurrentUser.Armor.Name

            'enemy
            If CurrentEnemy.CurrentEndurance <= (CurrentEnemy.MaximumEndurance * 0.2) Then
                lblEneEnd.ForeColor = Color.Red
            Else
                lblEneEnd.ForeColor = Color.Black
            End If
            lblEneEnd.Text = CurrentEnemy.CurrentEndurance & " / " & CurrentEnemy.MaximumEndurance
            lblEneStatus.Text = Status(_enemyStamina)
            If _enemyStamina < 3 Then
                lblEneStatus.ForeColor = Color.Red
            Else
                lblEneStatus.ForeColor = Color.Black
            End If
            lblEneWeapon.Text = CurrentEnemy.Weapon.Name
            lblEneArmor.Text = CurrentEnemy.Armor.Name

            If _userStamina > 0 AndAlso CurrentUser.CurrentEndurance > 0 AndAlso CurrentEnemy.CurrentEndurance > 0 Then
                EnableButtons()
            ElseIf _userStamina = 0 Then
                BtnDefend.Enabled = True
                BtnInventory.Enabled = True
            Else
                DisableButtons()
            End If
        End Sub

        Private Sub DisableButtons()
            '* * * * *
            '* This method disables all the buttons.
            '* * * * *

            BtnAttack.Enabled = False
            BtnBerserk.Enabled = False
            BtnFlee.Enabled = False
            BtnLunge.Enabled = False
            BtnParry.Enabled = False
            BtnQuickCombat.Enabled = False
            BtnInventory.Enabled = False
        End Sub

        Private Sub EnableButtons()
            '* * * * *
            '* This method enables all the buttons.
            '* * * * *

            BtnAttack.Enabled = True
            BtnBerserk.Enabled = True
            BtnFlee.Enabled = True
            BtnLunge.Enabled = True
            BtnParry.Enabled = True
            BtnDefend.Enabled = True
            BtnQuickCombat.Enabled = True
            BtnInventory.Enabled = True

            If _userStamina < 2 Then
                BtnBerserk.Enabled = False
            End If
        End Sub

        Private Sub EnemyAttack()
            '* * * * *
            '* This method contains the instructions for an enemy's attack.
            '* * * * *

            If _userStance <> Stance.Parry Then                                         'if player stance isn't parry
                Dim eneDamage As Integer = Functions.GenerateRandomNumber(1, CurrentEnemy.Weapon.Damage)
                Dim plrDefend As Integer = Functions.GenerateRandomNumber(1, CurrentUser.Armor.Defense)

                If eneDamage > plrDefend Then   'if enemy damages player
                    AddText("Your opponent attacks you for " & eneDamage & " damage, but your armor absorbs " & plrDefend & " damage.")
                    CurrentUser.CurrentEndurance -= (eneDamage - plrDefend)
                Else                            'if all damage absorbed
                    AddText("Your opponent attacks you for " & eneDamage & " damage, but your armor absorbs all of it.")
                End If
            Else                                                                    'if player stance is parry
                Dim eneParry As Integer = Functions.GenerateRandomNumber(1, 100)
                If eneParry <= CurrentUser.CurrentWeaponSkill Then     'if player successfully parries
                    AddText("You parry your opponent's attack!")
                    Dim plrDamage As Integer = Functions.GenerateRandomNumber(1, CurrentUser.CurrentWeapon.Damage)
                    Dim eneDefend As Integer = Functions.GenerateRandomNumber(1, CurrentEnemy.Armor.Defense)

                    If plrDamage > eneDefend Then
                        AddText("You attack your opponent for " & plrDamage & " damage, but their armor absorbs " & eneDefend & " damage.")
                        CurrentEnemy.CurrentEndurance -= (plrDamage - eneDefend)
                    Else
                        AddText("You attacks you for " & plrDamage & " damage, but their armor absorbs all of it.")
                    End If
                Else                                'if player fails to parry
                    Dim eneDamage As Integer = Functions.GenerateRandomNumber(1, CurrentEnemy.Weapon.Damage)
                    Dim plrDefend As Integer = Functions.GenerateRandomNumber(1, CurrentUser.Armor.Defense)

                    If eneDamage > plrDefend Then   'if enemy damages player
                        AddText("Your opponent attacks you for " & eneDamage & " damage, but your armor absorbs " & plrDefend & " damage.")
                        CurrentUser.CurrentEndurance -= (eneDamage - plrDefend)
                    Else                            'if all damage absorbed
                        AddText("Your opponent attacks you for " & eneDamage & " damage, but your armor absorbs all of it.")
                    End If
                End If
            End If
        End Sub

        Private Sub EnemyStance()
            '* * * * *
            '* This method contains the instructions for choosing an enemy's stance.
            '* * * * *

            If _enemyStamina > 2 Then                   'if enemy's stamina is above 2, any option
                Dim type As Integer = Functions.GenerateRandomNumber(1, 100)
                Select Case type
                    Case 1 To 20    '20%
                        _enemyStance = Stance.Normal
                    Case 21 To 40    '20%
                        _enemyStance = Stance.Berserk
                        CurrentEnemy.Weapon.Damage *= 2
                    Case 41 To 60    '20%
                        _enemyStance = Stance.Lunge
                        CurrentEnemy.Weapon.Damage *= 2
                        CurrentEnemy.WeaponSkill \= 2
                    Case 61 To 80    '20%
                        _enemyStance = Stance.Parry
                    Case 81 To 100   '20%
                        _enemyStance = Stance.Defend
                        If _enemyStamina < 20 Then
                        End If
                End Select
            ElseIf _enemyStamina = 1 Then               'if enemy's stamina is 1, no berserk option, higher chance of defend
                Dim type As Integer = Functions.GenerateRandomNumber(1, 100)
                Select Case type
                    Case 1 To 20    '20%
                        _enemyStance = Stance.Normal
                    Case 21 To 40   '20%
                        _enemyStance = Stance.Lunge
                        CurrentEnemy.Weapon.Damage *= 2
                        CurrentEnemy.WeaponSkill \= 2
                    Case 41 To 60   '20%
                        _enemyStance = Stance.Parry
                    Case 61 To 100  '40%
                        _enemyStance = Stance.Defend
                End Select
            ElseIf _enemyStamina <= 0 Then              'if enemy's stamina is 0, only defend
                _enemyStance = Stance.Defend
            End If
        End Sub

        Private Sub EnemyTurn()
            '* * * * *
            '* This method contains the instructions for an enemy's turn.
            '* * * * *

            If _enemyStance <> Stance.Defend Then        'not defending
                If EnemyHit() Then                  'if player has chance to hit
                    If PlayerBlock() = False Then   'if enemy fails to block
                        EnemyAttack()               'attack
                    Else
                        AddText("You block your opponent's attack.")
                    End If
                Else
                    AddText("Your opponent misses you.")
                End If
            Else
                If CurrentEnemy.Blocking >= 45 Then        'if blocking can't be doubled
                    CurrentEnemy.Blocking = 90             'set blocking to max
                Else
                    CurrentEnemy.Blocking *= 2             'double blocking
                End If

                AddText("Your opponent goes on the defensive and attempts to regain stamina.")
            End If
        End Sub

        Private Sub LoseBattle()
            '* * * * *
            '* This method contains the instructions for the player losing the battle.
            '* * * * *

            AddText("You have been slain by your opponent!")
            CurrentUser.CurrentEndurance = CurrentUser.CurrentEndurance
            CurrentUser.Alive = False

            DisableButtons()
            BtnExit.Enabled = True
            _blnDone = True

        End Sub

        Private Sub NewRound()
            '* * * * *
            '* This method contains the instructions for a new round.
            '* * * * *

            'funcs.random integers generated to see who goes first
            Dim playerFirst As Integer = Functions.GenerateRandomNumber(1, 100)
            Dim enemyFirst As Integer = Functions.GenerateRandomNumber(1, 100)
            EnemyStance()

            DisableButtons()
            BtnDefend.Enabled = False

            If playerFirst >= enemyFirst Then   'if player goes first
                PlayerTurn()                    'go player
                If CurrentEnemy.CurrentEndurance > 0 Then       'if enemy still alive
                    EnemyTurn()                 'go enemy
                Else                            'enemy dead
                    WinBattle()                 'win!
                    Exit Sub
                End If
            Else                                'if enemy goes first
                EnemyTurn()                     'go enemy
                If CurrentUser.CurrentEndurance > 0 Then      'if player still alive
                    PlayerTurn()                'go player
                Else                            'player dead
                    LoseBattle()                'lose :(
                    Exit Sub
                End If
            End If

            If CurrentEnemy.CurrentEndurance <= 0 Then
                WinBattle()
                Exit Sub
            ElseIf CurrentUser.CurrentEndurance <= 0 Then
                LoseBattle()
                Exit Sub
            Else

                RoundReset()
            End If
        End Sub

        Private Sub PlayerAttack()
            '* * * * *
            '* This method contains the instructions for the player's turn.
            '* * * * *

            If _enemyStance <> Stance.Parry Then                                         'if enemy stance isn't parry
                Dim plrDamage As Integer = Functions.GenerateRandomNumber(1, CurrentUser.CurrentWeapon.Damage)
                Dim eneDefend As Integer = Functions.GenerateRandomNumber(1, CurrentEnemy.Armor.Defense)

                If plrDamage > eneDefend Then   'if player damages enemy
                    AddText("You attack your opponent for " & plrDamage & " damage, but their armor absorbs " & eneDefend & " damage.")
                    CurrentEnemy.CurrentEndurance -= (plrDamage - eneDefend)
                Else                            'if all damage absorbed
                    AddText("You attack your opponent for " & plrDamage & " damage, but their armor absorbs all of it.")
                End If
            Else                                                                    'if enemy stance is parry
                Dim eneParry As Integer = Functions.GenerateRandomNumber(1, 100)
                If eneParry <= CurrentEnemy.WeaponSkill Then     'if enemy successfully parries
                    AddText("Your opponent parries your attack!")
                    Dim eneDamage As Integer = Functions.GenerateRandomNumber(1, CurrentEnemy.Weapon.Damage)
                    Dim plrDefend As Integer = Functions.GenerateRandomNumber(1, CurrentUser.Armor.Defense)

                    If eneDamage > plrDefend Then
                        AddText("Your opponent attacks you for " & eneDamage & " damage, but your armor absorbs " & plrDefend & " damage.")
                        CurrentUser.CurrentEndurance -= (eneDamage - plrDefend)
                    Else
                        AddText("Your opponent attacks you for " & eneDamage & " damage, but your armor absorbs all of it.")
                    End If
                Else                                'if enemy fails to parry
                    Dim plrDamage As Integer = Functions.GenerateRandomNumber(1, CurrentUser.CurrentWeapon.Damage)
                    Dim eneDefend As Integer = Functions.GenerateRandomNumber(1, CurrentEnemy.Armor.Defense)

                    If plrDamage > eneDefend Then   'if player damages enemy
                        AddText("You attack your opponent for " & plrDamage & " damage, but their armor absorbs " & eneDefend & " damage.")
                        CurrentEnemy.CurrentEndurance -= (plrDamage - eneDefend)
                    Else                            'if all damage absorbed
                        AddText("You attack your opponent for " & plrDamage & " damage, but their armor absorbs all of it.")
                    End If
                End If
            End If
        End Sub

        Private Sub PlayerFlee()
            '* * * * *
            '* This method contains the instructions for the player fleeing.
            '* * * * *

            AddText("You have escaped the battle!")

            If CurrentUser.Experience < 100 Then          'if user can get more experience
                If (CurrentEnemy.Level - CurrentUser.Level) >= 2 Then
                    AddText("You have gained 1 experience from the battle.")
                    CurrentUser.Experience += 1
                End If
            End If

            CurrentUser.CurrentEndurance = CurrentUser.CurrentEndurance   'save player endurance

            DisableButtons()                    'disable buttons
            BtnExit.Enabled = True              'enable Exit buton
            _blnDone = True                      'allow the form to exit

        End Sub

        Private Sub PlayerStance()
            '* * * * *
            '* This method handles the player's stance in QuickCombat.
            '* * * * *

            Select Case _userStamina
                Case 2 To 20
                    Dim percent As Integer = Functions.GenerateRandomNumber(1, 100)
                    Select Case percent
                        Case 1 To 20    '20%
                            _userStance = Stance.Normal
                        Case 21 To 40   '20%
                            _userStance = Stance.Berserk
                            CurrentUser.CurrentWeapon.Damage *= 2
                        Case 41 To 60   '20%
                            _userStance = Stance.Parry
                        Case 61 To 80   '20%
                            _userStance = Stance.Lunge
                            CurrentUser.CurrentWeapon.Damage *= 2           'increase damage
                            'CurrentUser.CurrentWeaponSkill \= 2                   'decrease hit chance
                        Case 81 To 100  '20%
                            _userStance = Stance.Defend
                            If CurrentUser.Blocking >= 45 Then
                                CurrentUser.Blocking = 90
                            Else
                                CurrentUser.Blocking *= 2
                            End If
                    End Select
                Case 1
                    Dim percent As Integer = Functions.GenerateRandomNumber(1, 100)
                    Select Case percent
                        Case 1 To 20    '20%
                            _userStance = Stance.Normal
                            _userStance = Stance.Berserk
                            CurrentUser.CurrentWeapon.Damage *= 2
                        Case 21 To 40    '20%
                            _userStance = Stance.Parry
                        Case 41 To 60    '20%
                            _userStance = Stance.Lunge
                            CurrentUser.CurrentWeapon.Damage *= 2           'increase damage
                            'CurrentUser.CurrentWeaponSkill \= 2                   'decrease hit chance
                        Case 61 To 100   '40%
                            _userStance = Stance.Defend
                            If CurrentUser.Blocking >= 45 Then
                                CurrentUser.Blocking = 90
                            Else
                                CurrentUser.Blocking *= 2
                            End If
                    End Select
                Case 0
                    _userStance = Stance.Defend    '100%
                    If CurrentUser.Blocking >= 45 Then
                        CurrentUser.Blocking = 90
                    Else
                        CurrentUser.Blocking *= 2
                    End If
            End Select
        End Sub

        Private Sub PlayerTurn()
            '* * * * *
            '* This method contains the instructions for the player's turn.
            '* * * * *

            If _userStance <> Stance.Defend AndAlso _userStance <> Stance.Flee Then   'not defending or fleeing
                If PlayerHit() Then                 'if player has chance to hit
                    If EnemyBlock() = False Then    'if enemy fails to block
                        PlayerAttack()              'attack
                    Else
                        AddText("Your opponent blocks your attack.")
                    End If
                Else
                    AddText("You miss your opponent.")
                End If
            ElseIf _userStance = Stance.Defend Then    'if defending
                If CurrentUser.Blocking >= 45 Then        'if blocking can't be doubled
                    CurrentUser.Blocking = 90             'set blocking to max
                Else
                    CurrentUser.Blocking *= 2             'double blocking
                End If

                AddText("You go on the defensive and attempt to regain stamina.")
            End If
        End Sub

        Private Sub RoundReset()
            '* * * * *
            '* This method contains the instructions for resetting player and enemy stats after a round.
            '* * * * *

            Select Case _userStance
                Case Stance.Defend   'if stance was Defend
                    If _userStamina < 20 Then
                        _userStamina += 1
                    End If
                    CurrentUser.Blocking = CurrentUser.Blocking
                Case Stance.Berserk  'if stance was Stance.Berserk
                    _userStamina -= 2
                Case Else       'if stance is Lunge, Parry, or Normal
                    _userStamina -= 1
            End Select

            Select Case _enemyStance
                Case Stance.Defend   'if stance was Defend
                    If _enemyStamina < 20 Then
                        _enemyStamina += 1
                    End If
                    CurrentEnemy.Blocking = CurrentEnemy.Blocking
                Case Stance.Berserk  'if stance was Stance.Berserk
                    _enemyStamina -= 2
                Case Else       'if stance is Lunge, Parry, or Normal
                    _enemyStamina -= 1
            End Select

        End Sub

        Public Sub surprise()
            '* * * * *
            '* This method determines if you surprise the enemy when first attacking them.
            '* * * * *

            Dim surprise As Integer = Functions.GenerateRandomNumber(1, 100)
            If surprise <= CurrentUser.Stealth Then
                Dim plrDamage As Integer = Functions.GenerateRandomNumber(1, CurrentUser.CurrentWeapon.Damage)
                Dim eneDefend As Integer = Functions.GenerateRandomNumber(1, CurrentEnemy.Armor.Defense)

                If plrDamage > eneDefend Then   'if did damage
                    If TxtBattle.TextLength > 0 Then
                        AddText("You surprise your opponent! You do " & plrDamage & " damage, but their armor absorbs " & eneDefend & " damage.")
                    Else
                        TxtBattle.Text = "You surprise your opponent! You do " & plrDamage & " damage, but their armor absorbs " & eneDefend & " damage."
                    End If

                    CurrentEnemy.CurrentEndurance -= (plrDamage - eneDefend)

                    If CurrentEnemy.CurrentEndurance <= 0 Then  'if enemy dead
                        WinBattle()             'win!
                    End If
                Else                            'if all damage absorbed
                    If TxtBattle.TextLength > 0 Then
                        AddText("You surprise your opponent! You do " & plrDamage & " damage, but their armor absorbs all of it.")
                    Else
                        TxtBattle.Text = "You surprise your opponent! You do " & plrDamage & " damage, but their armor absorbs all of it."
                    End If
                End If
            End If
        End Sub

        Private Async Sub WinBattle()
            '* * * * *
            '* This method contains the instructions for the player winning the battle.
            '* * * * *

            AddText("You have slain your opponent!")
            If CurrentUser.Experience < 100 Then  'if player can get more experience
                Dim exp As Integer = ((CurrentEnemy.Level + 1) - CurrentUser.Level)
                If exp > 0 Then  'if experience gained is positive
                    CurrentUser.GainExperience(exp)
                End If
            End If

            CurrentUser.SkillPoints += 1          'increment skill points
            AddText("You have earned a skill point from this battle.")

            Dim gold As Integer = Functions.GenerateRandomNumber(CurrentEnemy.GoldOnHand \ 2, CurrentEnemy.MaximumEndurance)
            CurrentUser.GoldOnHand += gold     'increment gold on hand
            AddText("You frisk your opponent's body and find " & gold & " gold.")

            DisableButtons()                'disable buttons
            BtnDefend.Enabled = False       'disable Defend button
            _blnDone = True                  'allow form to close
            _blnWin = True                   'win!

            Await SaveUser(CurrentUser)
        End Sub

        Private Sub BtnAttack_Click(sender As Object, e As EventArgs) Handles BtnAttack.Click
            '* * * * *
            '* This method starts a new round with Normal stance.
            '* * * * *

            _userStance = Stance.Normal
            NewRound()
        End Sub

        Private Sub BtnBerserk_Click(sender As Object, e As EventArgs) Handles BtnBerserk.Click
            '* * * * *
            '* This method starts a new round with Stance.Berserk stance.
            '* * * * *

            _userStance = Stance.Berserk
            CurrentUser.CurrentWeapon.Damage *= 2
            NewRound()
        End Sub

        Private Sub BtnDefend_Click(sender As Object, e As EventArgs) Handles BtnDefend.Click
            '* * * * *
            '* This method starts a new round with Defend stance.
            '* * * * *

            _userStance = Stance.Defend
            If CurrentUser.Blocking >= 45 Then
                CurrentUser.Blocking = 90
            Else
                CurrentUser.Blocking *= 2
            End If
            NewRound()
        End Sub

        Private Sub BtnFlee_Click(sender As Object, e As EventArgs) Handles BtnFlee.Click
            '* * * * *
            '* This method starts a new round with Flee stance if failed to flee.
            '* * * * *

            Dim flee As Integer = Functions.GenerateRandomNumber(1, 100)
            If flee <= CurrentUser.Slipping Then       'if flee has chance to be successful
                Dim block As Integer = Functions.GenerateRandomNumber(1, 100)
                If block > CurrentEnemy.Blocking Then       'successful flee
                    PlayerFlee()
                Else                                'blocked flee
                    _userStance = Stance.Flee
                    AddText("Your opponent blocked your attempt to flee.")
                    NewRound()
                End If
            Else
                _userStance = Stance.Flee
                AddText("Your attempt at flight failed miserably.")
                NewRound()
            End If
        End Sub

        Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
            '* * * * *
            '* This method closes the form on clicking the Exit button.
            '* * * * *

            Me.Close()
        End Sub

        Private Sub BtnInventory_Click(sender As Object, e As EventArgs) Handles BtnInventory.Click
            '* * * * *
            '* This method displays the Inventory form.
            '* * * * *

            FrmInventory.Show()
            FrmInventory.BlnBattle = True
            Me.Hide()
        End Sub

        Private Sub BtnLunge_Click(sender As Object, e As EventArgs) Handles BtnLunge.Click
            '* * * * *
            '* This method starts a new round with Lunge stance.
            '* * * * *

            _userStance = Stance.Lunge
            CurrentUser.CurrentWeapon.Damage *= 2           'increase damage
            'CurrentUser.CurrentWeaponSkill \= 2                   'decrease hit chance
            NewRound()
        End Sub

        Private Sub BtnParry_Click(sender As Object, e As EventArgs) Handles BtnParry.Click
            '* * * * *
            '* This method starts a new round with Parry stance.
            '* * * * *

            _userStance = Stance.Parry
            NewRound()
        End Sub

        Private Sub BtnQuickCombat_Click(sender As Object, e As EventArgs) Handles BtnQuickCombat.Click
            '* * * * *
            '* This method starts quickly completes the combat.
            '* * * * *

            While CurrentUser.CurrentEndurance > 0 AndAlso CurrentEnemy.CurrentEndurance > 0
                PlayerStance()
                NewRound()
            End While
        End Sub

        Private Async Sub FrmBattle_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
            '* * * * *
            '* This method handles everything on form closing.
            '* * * * *

            If _blnDone = False Then 'don't close the form
                e.Cancel = True
                MessageBox.Show("You must flee or finish the battle first.", "Assassin", MessageBoxButtons.OK)
            Else                    'close the form
                Await SaveUser(CurrentUser)
                If BlnJob = False Then
                    FrmGame.Show()
                    FrmGame.Display()
                    FrmGame.AddText(txtBattle.Text)
                Else
                    FrmJobs.Show()
                    FrmJobs.AddText(txtBattle.Text)
                    FrmJobs.DisableButtons()
                    If _blnWin = True Then
                        FrmJobs.ArrText.Add("You take your opponent's engraved weapon back to your employer.")
                        FrmJobs.GetPaid()
                    End If
                End If
            End If
        End Sub

    End Class

End Namespace