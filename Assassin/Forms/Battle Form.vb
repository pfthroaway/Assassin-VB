Option Strict On
Option Explicit On

Imports Assassin.Classes
Imports Assassin.Classes.Entities
Imports Assassin.Classes.Enums
Imports Extensions

Namespace Forms

    Public Class FrmBattle
        Dim _blnDone As Boolean = False
        Public BlnJob As Boolean = False
        Dim _blnWin As Boolean = False
        ReadOnly _maxStamina As Integer = 100
        Dim _userStamina As Integer = _maxStamina
        Dim _enemyStamina As Integer = _maxStamina
        Dim _userStance As Stance
        Dim _enemyStance As Stance
        Dim _playerBlocking As Integer = 0
        Dim _enemyBlocking As Integer = 0
        Dim _playerDamage As Integer = 0
        Dim _enemyDamage As Integer = 0
        Dim _playerWeaponSkill As Integer = 0
        Dim _enemyWeaponSkill As Integer = 0

        ''' <summary>Gives a <see cref="User"/> a bonus.</summary>
        ''' <returns>Bonus amount</returns>
        Private Function Bonus() As Integer
            Return If(CurrentUser.Level <= 4, (11 - CurrentUser.Level) * 5, 0)
        End Function

        ''' <summary>Add text to the TextBox.</summary>
        ''' <param name="newText">Text to be added</param>
        Private Sub AddText(newText As String)
            AddTextToTextBox(TxtBattle, newText)
        End Sub

        ''' <summary>Displays all the displayable information in the labels on the form.</summary>
        Public Sub Display()
            LblPlrName.Text = CurrentUser.Name
            LblPlrEnd.ForeColor = If(CurrentUser.CurrentEndurance <= (CurrentUser.MaximumEndurance * 0.2), Color.Red, Color.Black)
            LblPlrEnd.Text = CurrentUser.EnduranceToString
            LblPlrStatus.Text = GetStatusText(_userStamina)
            LblPlrStatus.ForeColor = If(_userStamina < 3, Color.Red, Color.Black)
            LblPlrWeapon.Text = CurrentUser.CurrentWeapon.Name
            LblPlrArmor.Text = CurrentUser.Armor.Name

            LblEnemyName.Text = CurrentEnemy.Name
            LblEneEnd.ForeColor = If(CurrentEnemy.CurrentEndurance <= (CurrentEnemy.MaximumEndurance * 0.2), Color.Red, Color.Black)
            LblEneEnd.Text = CurrentEnemy.EnduranceToString
            LblEneStatus.Text = GetStatusText(_enemyStamina)
            LblEneStatus.ForeColor = If(_enemyStamina < 3, Color.Red, Color.Black)
            LblEneWeapon.Text = CurrentEnemy.Weapon.Name
            LblEneArmor.Text = CurrentEnemy.Armor.Name

            ToggleButtons(_userStamina > 0 AndAlso Not _blnDone)
        End Sub

        ''' <summary>Toggles all buttons.</summary>
        ''' <param name="enabled"></param>
        Private Sub ToggleButtons(enabled As Boolean)
            BtnAttack.Enabled = enabled
            BtnBerserk.Enabled = enabled AndAlso _userStamina >= 2
            BtnFlee.Enabled = enabled
            BtnLunge.Enabled = enabled
            BtnParry.Enabled = enabled
            BtnQuickCombat.Enabled = enabled
            BtnInventory.Enabled = Not _blnDone
            BtnDefend.Enabled = Not _blnDone
        End Sub

#Region "Hit"

        ''' <summary>The <see cref="Enemy"/> hits the <see cref="User"/>.</summary>
        Private Sub HitPlayer()
            Dim eneDamage As Integer = Functions.GenerateRandomNumber(_enemyDamage \ 2, _enemyDamage)
            Dim plrDefend As Integer = Functions.GenerateRandomNumber(CurrentUser.Armor.Defense \ 2, CurrentUser.Armor.Defense)
            If eneDamage > plrDefend Then
                Dim actualDamage As Integer = eneDamage - plrDefend
                AddText($"Your opponent attacks you for {eneDamage} damage, but your armor absorbs {plrDefend} damage. You take {actualDamage} total damage.")
                CurrentUser.CurrentEndurance -= actualDamage
            Else
                AddText($"Your opponent attacks you for {eneDamage} damage, but your armor absorbs all of it.")
            End If
        End Sub

        ''' <summary>The <see cref="User"/> hits the <see cref="Enemy"/>.</summary>
        Private Sub HitEnemy()
            Dim plrDamage As Integer = Functions.GenerateRandomNumber(_playerDamage \ 2, _playerDamage)
            Dim eneDefend As Integer = Functions.GenerateRandomNumber(CurrentEnemy.Armor.Defense \ 2, CurrentEnemy.Armor.Defense)

            If plrDamage > eneDefend Then
                Dim actualDamage As Integer = plrDamage - eneDefend
                AddText($"You attack your opponent for {plrDamage} damage, but their armor absorbs {eneDefend} damage. You do {actualDamage} total damage.")
                CurrentEnemy.CurrentEndurance -= actualDamage
                If CurrentEnemy.CurrentEndurance < 0 Then
                    CurrentEnemy.CurrentEndurance = 0
                End If
            Else
                AddText($"You attack your opponent for {plrDamage} damage, but their armor absorbs all of it.")
            End If
        End Sub

#End Region

#Region "Enemy"

        ''' <summary>Handle's an <see cref="Enemy"/>'s attack.</summary>
        Private Sub EnemyAttack()

            If _userStance <> Stance.Parry Then
                HitPlayer()
            Else
                If SkillCheck(CurrentUser.CurrentWeaponSkill + Bonus()) Then
                    AddText("You parry your opponent's attack!")
                    HitEnemy()
                Else
                    HitPlayer()
                End If
            End If
        End Sub

        ''' <summary>Chooses an <see cref="Enemy"/>'s <see cref="Stance"/>.</summary>
        Private Sub EnemyStance()
            If _enemyStamina > 2 Then
                'if enemy's stamina is above 2, any option
                Dim type As Integer = Functions.GenerateRandomNumber(1, 100)
                Select Case type
                    Case 1 To 20    '20%
                        _enemyStance = Stance.Normal
                    Case 21 To 40    '20%
                        _enemyStance = Stance.Berserk
                        _enemyDamage *= 2
                    Case 41 To 60    '20%
                        _enemyStance = Stance.Lunge
                        _enemyDamage *= 2
                        _enemyWeaponSkill \= 2
                    Case 61 To 80    '20%
                        _enemyStance = Stance.Parry
                    Case 81 To 100   '20%
                        _enemyStance = Stance.Defend
                        If _enemyStamina < 20 Then
                        End If
                End Select
            ElseIf _enemyStamina = 1 Then
                'if enemy's stamina is 1, no berserk option, higher chance of defend
                Dim type As Integer = Functions.GenerateRandomNumber(1, 100)
                Select Case type
                    Case 1 To 20    '20%
                        _enemyStance = Stance.Normal
                    Case 21 To 40   '20%
                        _enemyStance = Stance.Lunge
                        _enemyDamage *= 2
                        _enemyWeaponSkill \= 2
                    Case 41 To 60   '20%
                        _enemyStance = Stance.Parry
                    Case 61 To 100  '40%
                        _enemyStance = Stance.Defend
                End Select
            ElseIf _enemyStamina <= 0 Then
                'if enemy's stamina is 0, only defend
                _enemyStance = Stance.Defend
            End If

            If _enemyStance = Stance.Defend Then
                _enemyBlocking = If(_enemyBlocking >= 45, 90, _enemyBlocking * 2)
                AddText("Your opponent goes on the defensive and attempts to regain stamina.")
            End If

        End Sub

        ''' <summary>The <see cref="Enemy"/>'s turn.</summary>
        Private Sub EnemyTurn()

            ' If the Enemy is not defending
            ' and the Enemy can hit
            ' and the Assassin doesn't block
            ' then attempt to attack.

            If _enemyStance <> Stance.Defend Then
                If SkillCheck(_enemyWeaponSkill) Then
                    If SkillCheck(_playerBlocking + Bonus()) = False Then
                        EnemyAttack()
                    Else
                        AddText("You block your opponent's attack.")
                    End If
                Else
                    AddText("Your opponent misses you.")
                End If

            End If
        End Sub

#End Region

#Region "Battle Results"

        ''' <summary>The Player loses the battle.</summary>
        Private Sub LoseBattle()
            AddText("You have been slain by your opponent!")
            CurrentUser.CurrentEndurance = 0
            CurrentUser.Alive = False

            ToggleButtons(False)
            BtnExit.Enabled = True
            _blnDone = True
        End Sub

        ''' <summary>The Player wins the battle.</summary>
        Private Async Sub WinBattle()
            AddText("You have slain your opponent!")
            If CurrentUser.Experience < 100 Then 'if player can get more experience
                Dim exp As Integer = CurrentEnemy.Level + 1 - CurrentUser.Level
                If exp > 0 Then
                    AddText(CurrentUser.GainExperience(exp))
                End If
            End If

            If CurrentUser.Level - CurrentEnemy.Level >= -2 Then
                CurrentUser.SkillPoints += 1
                AddText("You have earned a skill point from this battle.")
            End If

            CurrentUser.GoldOnHand += CurrentEnemy.GoldOnHand
            AddText($"You frisk your opponent's body and find {CurrentEnemy.GoldOnHand} gold.")

            ToggleButtons(False)
            BtnDefend.Enabled = False
            BtnExit.Enabled = True
            _blnDone = True
            _blnWin = True

            Await SaveUser(CurrentUser)
        End Sub

#End Region

#Region "Battle Management"

        ''' <summary>Adjusts the stamina for a given <see cref="Stance"/>.</summary>
        ''' <param name="stance">Given <see cref="Stance"/></param>
        ''' <param name="stamina">Reference to current stamina value</param>
        Private Sub AdjustStamina(stance As Stance, ByRef stamina As Integer)
            Select Case stance
                Case Stance.Defend
                    If stamina < _maxStamina Then
                        stamina += 1
                    End If
                Case Stance.Berserk
                    stamina -= 2
                Case Else 'if stance is Lunge, Parry, or Normal
                    stamina -= 1
            End Select
        End Sub

        ''' <summary>Determines the status text to be returned.</summary>
        ''' <param name="stamina">Amount of stamina</param>
        ''' <returns>Status text</returns>
        Private Function GetStatusText(stamina As Integer) As String
            Select Case stamina
                Case > 18
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

        ''' <summary>Sets default values for <see cref="User"/> and <see cref="Enemy"/> blocking, damage, and weapon skill.</summary>
        Private Sub LoadBattle()
            _playerBlocking = CurrentUser.Blocking
            _enemyBlocking = CurrentEnemy.Blocking
            _playerDamage = CurrentUser.CurrentWeapon.Damage
            _enemyDamage = CurrentEnemy.Weapon.Damage
            _playerWeaponSkill = CurrentUser.CurrentWeaponSkill
            _enemyWeaponSkill = CurrentEnemy.WeaponSkill
        End Sub

        ''' <summary>Starts a new round of battle.</summary>
        Private Sub NewRound()

            Dim playerFirst As Integer = Functions.GenerateRandomNumber(1, 100)
            Dim enemyFirst As Integer = Functions.GenerateRandomNumber(1, 100)
            EnemyStance()

            ToggleButtons(False)
            BtnDefend.Enabled = False

            If playerFirst >= enemyFirst Then
                PlayerTurn()
                If CurrentEnemy.CurrentEndurance > 0 Then
                    EnemyTurn()
                End If
            Else
                EnemyTurn()
                If CurrentUser.CurrentEndurance > 0 Then
                    PlayerTurn()
                End If
            End If

            If CurrentEnemy.CurrentEndurance <= 0 Then
                WinBattle()
            ElseIf CurrentUser.CurrentEndurance <= 0 Then
                LoseBattle()
            Else
                RoundReset()
            End If

            Display()
        End Sub

        ''' <summary>Resets <see cref="User"/> and <see cref="Enemy"/> stats after a round.</summary>
        Private Sub RoundReset()
            AdjustStamina(_userStance, _userStamina)
            _playerBlocking = CurrentUser.Blocking
            _playerDamage = CurrentUser.CurrentWeapon.Damage
            _playerWeaponSkill = CurrentUser.CurrentWeaponSkill

            AdjustStamina(_enemyStance, _enemyStamina)
            _enemyBlocking = CurrentEnemy.Blocking
            _enemyDamage = CurrentEnemy.Weapon.Damage
            _enemyWeaponSkill = CurrentEnemy.WeaponSkill
        End Sub

        ''' <summary>Determines whether an attempt to hit is successful.</summary>
        ''' <param name="skill">Skill to be tested against</param>
        ''' <returns>True if successful hit</returns>
        Private Function SkillCheck(skill As Integer) As Boolean
            Return Functions.GenerateRandomNumber(1, 100) <= If(skill > 90, 90, skill)
        End Function

#End Region

#Region "Player Stance Management"

        ''' <summary>Sets the <see cref="User"/>'s <see cref="Stance"/>.</summary>
        ''' <param name="stance"><see cref="Stance"/> to be set</param>
        Private Sub SetPlayerStance(stance As Stance)
            _userStance = stance

            Select Case _userStance
                Case Stance.Berserk
                    _playerDamage *= 2
                Case Stance.Lunge
                    _playerDamage *= 2
                    _playerWeaponSkill \= 2
                Case Stance.Defend
                    _playerBlocking = If(_playerBlocking >= 45, 90, _playerBlocking * 2)
            End Select

        End Sub

        ''' <summary>Sets the <see cref="User"/>'s <see cref="Stance"/> and starts a new round.</summary>
        ''' <param name="stance">Stance to be set</param>
        Private Sub SetPlayerStanceNewRound(stance As Stance)
            SetPlayerStance(stance)
            NewRound()
        End Sub

#End Region

#Region "Player"

        ''' <summary>The <see cref="User"/> attacks.</summary>
        Private Sub PlayerAttack()
            If _enemyStance <> Stance.Parry Then
                HitEnemy()
            Else
                If SkillCheck(CurrentEnemy.WeaponSkill) Then
                    AddText("Your opponent parries your attack!")
                    HitPlayer()
                Else
                    HitEnemy()
                End If
            End If
        End Sub

        ''' <summary>The <see cref="User"/> flees the battle.</summary>
        Private Sub PlayerFlee()
            AddText("You have escaped the battle!")

            If CurrentUser.Experience < 100 Then 'if user can get more experience
                If (CurrentEnemy.Level - CurrentUser.Level) >= 2 Then
                    AddText("You have gained 1 experience from the battle.")
                    CurrentUser.Experience += 1
                End If
            End If

            ToggleButtons(False)                    'disable buttons
            BtnExit.Enabled = True              'enable Exit buton
            _blnDone = True                      'allow the form to exit
        End Sub

        ''' <summary>Handles the <see cref="User"/>'s <see cref="Stance"/> in QuickCombat.</summary>
        Private Sub QuickCombatPlayerStance()
            Select Case _userStamina
                Case > 2
                    Dim percent As Integer = Functions.GenerateRandomNumber(1, 100)
                    Select Case percent
                        Case 1 To 20
                            SetPlayerStance(Stance.Normal)
                        Case 21 To 40
                            SetPlayerStance(Stance.Berserk)
                        Case 41 To 60
                            SetPlayerStance(Stance.Parry)
                        Case 61 To 80
                            SetPlayerStance(Stance.Lunge)
                        Case 81 To 100
                            SetPlayerStance(Stance.Defend)
                    End Select
                Case 1
                    Dim percent As Integer = Functions.GenerateRandomNumber(1, 100)
                    Select Case percent
                        Case 1 To 20
                            SetPlayerStance(Stance.Normal)
                        Case 21 To 40
                            SetPlayerStance(Stance.Parry)
                        Case 41 To 60
                            SetPlayerStance(Stance.Lunge)
                        Case 61 To 100
                            SetPlayerStance(Stance.Defend)
                    End Select
                Case 0
                    SetPlayerStance(Stance.Defend)
            End Select
        End Sub

        ''' <summary>The <see cref="User"/>'s turn.</summary>
        Private Sub PlayerTurn()
            If _userStance <> Stance.Defend AndAlso _userStance <> Stance.Flee Then
                If SkillCheck(_playerWeaponSkill + Bonus()) Then
                    If SkillCheck(_enemyBlocking) = False Then
                        PlayerAttack()
                    Else
                        AddText("Your opponent blocks your attack.")
                    End If
                Else
                    AddText("You miss your opponent.")
                End If
            End If
        End Sub

        ''' <summary>Determines if you surprise the <see cref="Enemy"/> when first attacking them.</summary>
        Public Sub Surprise()
            LoadBattle()
            AddText($"You approach the {CurrentEnemy.Name}.")
            If SkillCheck(CurrentUser.Stealth + Bonus()) Then
                _playerDamage *= 2
                AddText("You surprise your opponent!")
                HitEnemy()

                If CurrentEnemy.CurrentEndurance <= 0 Then
                    WinBattle()
                Else
                    RoundReset()
                End If
            End If
        End Sub

#End Region

#Region "Button Click"

        Private Sub BtnAttack_Click(sender As Object, e As EventArgs) Handles BtnAttack.Click
            SetPlayerStanceNewRound(Stance.Normal)
        End Sub

        Private Sub BtnBerserk_Click(sender As Object, e As EventArgs) Handles BtnBerserk.Click
            SetPlayerStanceNewRound(Stance.Berserk)
        End Sub

        Private Sub BtnDefend_Click(sender As Object, e As EventArgs) Handles BtnDefend.Click
            SetPlayerStanceNewRound(Stance.Defend)
        End Sub

        Private Sub BtnFlee_Click(sender As Object, e As EventArgs) Handles BtnFlee.Click
            If SkillCheck(CurrentUser.Slipping + Bonus()) Then 'if flee has chance to be successful
                If SkillCheck(_enemyBlocking - Bonus()) Then  'successful flee
                    PlayerFlee()
                Else 'blocked flee
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
            Close()
        End Sub

        Private Sub BtnInventory_Click(sender As Object, e As EventArgs) Handles BtnInventory.Click
            FrmInventory.Show()
            FrmInventory.BlnBattle = True
            Hide()
        End Sub

        Private Sub BtnLunge_Click(sender As Object, e As EventArgs) Handles BtnLunge.Click
            SetPlayerStanceNewRound(Stance.Lunge)
        End Sub

        Private Sub BtnParry_Click(sender As Object, e As EventArgs) Handles BtnParry.Click
            SetPlayerStanceNewRound(Stance.Parry)
        End Sub

        Private Sub BtnQuickCombat_Click(sender As Object, e As EventArgs) Handles BtnQuickCombat.Click
            While CurrentUser.CurrentEndurance > 0 AndAlso CurrentEnemy.CurrentEndurance > 0
                QuickCombatPlayerStance()
                NewRound()
            End While
        End Sub

#End Region

        Private Async Sub FrmBattle_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
            Dim text As String = TxtBattle.Text
            If _blnDone = False Then
                e.Cancel = True
                MessageBox.Show("You must flee or finish the battle first.", "Assassin", MessageBoxButtons.OK)
            Else
                Await SaveUser(CurrentUser)
                If BlnJob = False Then
                    FrmAssassinate.Show()
                    FrmAssassinate.AddText(text)
                    FrmAssassinate.FinishBattle()
                Else
                    FrmJobs.Show()
                    FrmJobs.AddText(TxtBattle.Text)
                    FrmJobs.BtnLeave.Enabled = True
                    If _blnWin = True Then
                        FrmJobs.ArrText.Add("You take your opponent's engraved weapon back to your employer.")
                        FrmJobs.GetPaid()
                    End If
                End If
            End If
        End Sub

    End Class

End Namespace