' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 05/25/2012
' Filename        : Battle Form.vb
' Description     : This form allows battles.

Option Strict On
Option Explicit On

Public Class frmBattle
    Dim funcs As New Functions              'new Functions instance
    Public currUser As New User             'current user
    Dim nl As String = ControlChars.NewLine 'new line   
    Public currEnemy As New Enemy           'current enemy
    Dim currWeapon As New Weapon            'current player weapon
    Dim player As New BattleUser            'player
    Dim enemy As New BattleUser             'enemy
    Dim blnDone As Boolean = False          'battle over?
    Dim arrText As New ArrayList            'array of text to be displayed
    Dim index As Integer = 0                'index on array
    Public blnJob As Boolean = False        'on the job?
    Dim blnWin As Boolean = False           'win?

    Private Function bonus() As Integer
        '* * * * *
        '* This method gives a user a bonus.
        '* * * * *

        If currUser.level <= 4 Then
            Return (11 - currUser.level) * 5
        Else
            Return 0
        End If
    End Function

    Private Function enemyBlock() As Boolean
        '* * * * *
        '* This method determines whether the enemy blocks an attack.
        '* * * * *

        Dim toBlock As Integer = funcs.random(1, 100)
        If toBlock <= enemy.toBlock Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function enemyHit() As Boolean
        '* * * * *
        '* This method determines whether the enemy's attack hits.
        '* * * * *

        Dim toHit As Integer = funcs.random(1, 100)
        If toHit <= enemy.toHit Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function playerBlock() As Boolean
        '* * * * *
        '* This method determines whether the player blocks an attack.
        '* * * * *

        Dim toBlock As Integer = funcs.random(1, 100)
        If toBlock <= player.toBlock Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function playerHit() As Boolean
        '* * * * *
        '* This method determines whether the player's attack hits.
        '* * * * *

        Dim toHit As Integer = funcs.random(1, 100)
        If toHit <= player.toHit Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function status(ByVal stamina As Integer) As String
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


    Public Sub addText(ByVal newText As String)
        '* * * * *
        '* This method adds text to the Textbox.
        '* * * * *

        Dim currText As String = txtBattle.Text
        txtBattle.Clear()

        txtBattle.Text = newText & nl & nl & currText
        txtBattle.Select(0, 0)
        txtBattle.ScrollToCaret()
    End Sub

    Public Sub checkWeapon()
        '* * * * *
        '* This method determines the player and enemy's current weapon
        '* * * * *
        Select Case currUser.currWeapon
            Case "Light"
                player.weapon = New Weapon(currUser.lightWeapon)
                player.toHit = currUser.lightWeaponSkill + bonus()
            Case "Heavy"
                player.weapon = New Weapon(currUser.heavyWeapon)
                player.toHit = currUser.heavyWeaponSkill + bonus()
            Case "Two-H"
                player.weapon = New Weapon(currUser.twoHWeapon)
                player.toHit = currUser.twoHWeaponSkill + bonus()
        End Select

        enemy.weapon = New Weapon(currEnemy.weapon)
        enemy.toHit = currEnemy.attackSkill
    End Sub

    Private Sub cycleText()
        '* * * * *
        '* This method cycles the text in the ArrayList on the Timer's tick.
        '* * * * *

        addText(arrText(index).ToString)
        index += 1

        If index = arrText.Count Then
            Timer1.Stop()
            index = 0
            arrText.Clear()
            display()

            If blnWin = True Then
                btnExit.Enabled = True          'enable Exit button
            End If
        End If
    End Sub

    Public Sub display()
        '* * * * *
        '* This method displays all the displayable information in the labels on the form.
        '* * * * *

        'player
        If player.currEnd <= (player.maxEnd * 0.2) Then
            lblPlrEnd.ForeColor = Color.Red
        Else
            lblPlrEnd.ForeColor = Color.Black
        End If
        lblPlrEnd.Text = player.currEnd & " / " & player.maxEnd
        lblPlrStatus.Text = status(player.stamina)
        If player.stamina < 3 Then
            lblPlrStatus.ForeColor = Color.Red
        Else
            lblPlrStatus.ForeColor = Color.Black
        End If
        lblPlrWeapon.Text = player.weapon.name
        lblPlrArmor.Text = player.armor.name

        'enemy
        If enemy.currEnd <= (enemy.maxEnd * 0.2) Then
            lblEneEnd.ForeColor = Color.Red
        Else
            lblEneEnd.ForeColor = Color.Black
        End If
        lblEneEnd.Text = enemy.currEnd & " / " & enemy.maxEnd
        lblEneStatus.Text = status(enemy.stamina)
        If enemy.stamina < 3 Then
            lblEneStatus.ForeColor = Color.Red
        Else
            lblEneStatus.ForeColor = Color.Black
        End If
        lblEneWeapon.Text = enemy.weapon.name
        lblEneArmor.Text = enemy.armor.name

        If player.stamina > 0 AndAlso player.currEnd > 0 AndAlso enemy.currEnd > 0 Then
            enableButtons()
        ElseIf player.stamina = 0 Then
            btnDefend.Enabled = True
            btnInventory.Enabled = True
        Else
            disableButtons()
        End If
    End Sub

    Private Sub disableButtons()
        '* * * * *
        '* This method disables all the buttons.
        '* * * * *

        btnAttack.Enabled = False
        btnBerserk.Enabled = False
        btnFlee.Enabled = False
        btnLunge.Enabled = False
        btnParry.Enabled = False
        btnQuickCombat.Enabled = False
        btnInventory.Enabled = False
    End Sub

    Private Sub enableButtons()
        '* * * * *
        '* This method enables all the buttons.
        '* * * * *

        btnAttack.Enabled = True
        btnBerserk.Enabled = True
        btnFlee.Enabled = True
        btnLunge.Enabled = True
        btnParry.Enabled = True
        btnDefend.Enabled = True
        btnQuickCombat.Enabled = True
        btnInventory.Enabled = True

        If player.stamina < 2 Then
            btnBerserk.Enabled = False
        End If
    End Sub

    Private Sub enemyAttack()
        '* * * * *
        '* This method contains the instructions for an enemy's attack.
        '* * * * *

        If player.stance <> "Parry" Then                                         'if player stance isn't parry
            Dim eneDamage As Integer = funcs.random(1, enemy.weapon.damage)
            Dim plrDefend As Integer = funcs.random(1, player.armor.defense)

            If eneDamage > plrDefend Then   'if enemy damages player
                arrText.Add("Your opponent attacks you for " & eneDamage & " damage, but your armor absorbs " & plrDefend & " damage.")
                player.currEnd -= (eneDamage - plrDefend)
            Else                            'if all damage absorbed
                arrText.Add("Your opponent attacks you for " & eneDamage & " damage, but your armor absorbs all of it.")
            End If
        Else                                                                    'if player stance is parry
            Dim eneParry As Integer = funcs.random(1, 100)
            If eneParry <= player.toHit Then     'if player successfully parries
                arrText.Add("You parry your opponent's attack!")
                Dim plrDamage As Integer = funcs.random(1, player.weapon.damage)
                Dim eneDefend As Integer = funcs.random(1, enemy.armor.defense)

                If plrDamage > eneDefend Then
                    arrText.Add("You attack your opponent for " & plrDamage & " damage, but their armor absorbs " & eneDefend & " damage.")
                    enemy.currEnd -= (plrDamage - eneDefend)
                Else
                    arrText.Add("You attacks you for " & plrDamage & " damage, but their armor absorbs all of it.")
                End If
            Else                                'if player fails to parry
                Dim eneDamage As Integer = funcs.random(1, enemy.weapon.damage)
                Dim plrDefend As Integer = funcs.random(1, player.armor.defense)

                If eneDamage > plrDefend Then   'if enemy damages player
                    arrText.Add("Your opponent attacks you for " & eneDamage & " damage, but your armor absorbs " & plrDefend & " damage.")
                    player.currEnd -= (eneDamage - plrDefend)
                Else                            'if all damage absorbed
                    arrText.Add("Your opponent attacks you for " & eneDamage & " damage, but your armor absorbs all of it.")
                End If
            End If
        End If
    End Sub

    Private Sub enemyStance()
        '* * * * *
        '* This method contains the instructions for choosing an enemy's stance.
        '* * * * *

        If enemy.stamina > 2 Then                   'if enemy's stamina is above 2, any option
            Dim type As Integer = funcs.random(1, 100)
            Select Case type
                Case 1 To 20    '20%
                    enemy.stance = "Normal"
                Case 21 To 40    '20%
                    enemy.stance = "Berserk"
                    enemy.weapon.damage *= 2
                Case 41 To 60    '20%
                    enemy.stance = "Lunge"
                    enemy.weapon.damage *= 2
                    enemy.toHit \= 2
                Case 61 To 80    '20%
                    enemy.stance = "Parry"
                Case 81 To 100   '20%
                    enemy.stance = "Defend"
                    If enemy.stamina < 20 Then
                    End If
            End Select
        ElseIf enemy.stamina = 1 Then               'if enemy's stamina is 1, no berserk option, higher chance of defend
            Dim type As Integer = funcs.random(1, 100)
            Select Case type
                Case 1 To 20    '20%
                    enemy.stance = "Normal"
                Case 21 To 40   '20%
                    enemy.stance = "Lunge"
                    enemy.weapon.damage *= 2
                    enemy.toHit \= 2
                Case 41 To 60   '20%
                    enemy.stance = "Parry"
                Case 61 To 100  '40%
                    enemy.stance = "Defend"
            End Select
        ElseIf enemy.stamina <= 0 Then              'if enemy's stamina is 0, only defend
            enemy.stance = "Defend"
        End If
    End Sub

    Private Sub enemyTurn()
        '* * * * *
        '* This method contains the instructions for an enemy's turn.
        '* * * * *

        If enemy.stance <> "Defend" Then        'not defending
            If enemyHit() Then                  'if player has chance to hit
                If playerBlock() = False Then   'if enemy fails to block
                    enemyAttack()               'attack
                Else
                    arrText.Add("You block your opponent's attack.")
                End If
            Else
                arrText.Add("Your opponent misses you.")
            End If
        Else
            If enemy.toBlock >= 45 Then        'if blocking can't be doubled
                enemy.toBlock = 90             'set blocking to max
            Else
                enemy.toBlock *= 2             'double blocking
            End If

            arrText.Add("Your opponent goes on the defensive and attempts to regain stamina.")
        End If
    End Sub

    Private Sub loseBattle()
        '* * * * *
        '* This method contains the instructions for the player losing the battle.
        '* * * * *

        arrText.Add("You have been slain by your opponent!")
        currUser.currEnd = player.currEnd
        currUser.alive = False

        disableButtons()
        btnExit.Enabled = True
        blnDone = True

        Timer1.Start()
    End Sub

    Private Sub newRound()
        '* * * * *
        '* This method contains the instructions for a new round.
        '* * * * *

        'funcs.random integers generated to see who goes first
        Dim playerFirst As Integer = funcs.random(1, 100)
        Dim enemyFirst As Integer = funcs.random(1, 100)
        enemyStance()


        disableButtons()
        btnDefend.Enabled = False

        If playerFirst >= enemyFirst Then   'if player goes first
            playerTurn()                    'go player
            If enemy.currEnd > 0 Then       'if enemy still alive
                enemyTurn()                 'go enemy
            Else                            'enemy dead
                winBattle()                 'win!
                Exit Sub
            End If
        Else                                'if enemy goes first
            enemyTurn()                     'go enemy
            If player.currEnd > 0 Then      'if player still alive
                playerTurn()                'go player
            Else                            'player dead
                loseBattle()                'lose :(
                Exit Sub
            End If
        End If

        If enemy.currEnd <= 0 Then
            winBattle()
            Exit Sub
        ElseIf player.currEnd <= 0 Then
            loseBattle()
            Exit Sub
        Else
            Timer1.Start()
            roundReset()
        End If
    End Sub

    Private Sub playerAttack()
        '* * * * *
        '* This method contains the instructions for the player's turn.
        '* * * * *

        If enemy.stance <> "Parry" Then                                         'if enemy stance isn't parry
            Dim plrDamage As Integer = funcs.random(1, player.weapon.damage)
            Dim eneDefend As Integer = funcs.random(1, enemy.armor.defense)

            If plrDamage > eneDefend Then   'if player damages enemy
                arrText.Add("You attack your opponent for " & plrDamage & " damage, but their armor absorbs " & eneDefend & " damage.")
                enemy.currEnd -= (plrDamage - eneDefend)
            Else                            'if all damage absorbed
                arrText.Add("You attack your opponent for " & plrDamage & " damage, but their armor absorbs all of it.")
            End If
        Else                                                                    'if enemy stance is parry
            Dim eneParry As Integer = funcs.random(1, 100)
            If eneParry <= enemy.toHit Then     'if enemy successfully parries
                arrText.Add("Your opponent parries your attack!")
                Dim eneDamage As Integer = funcs.random(1, enemy.weapon.damage)
                Dim plrDefend As Integer = funcs.random(1, player.armor.defense)

                If eneDamage > plrDefend Then
                    arrText.Add("Your opponent attacks you for " & eneDamage & " damage, but your armor absorbs " & plrDefend & " damage.")
                    player.currEnd -= (eneDamage - plrDefend)
                Else
                    arrText.Add("Your opponent attacks you for " & eneDamage & " damage, but your armor absorbs all of it.")
                End If
            Else                                'if enemy fails to parry
                Dim plrDamage As Integer = funcs.random(1, player.weapon.damage)
                Dim eneDefend As Integer = funcs.random(1, enemy.armor.defense)

                If plrDamage > eneDefend Then   'if player damages enemy
                    arrText.Add("You attack your opponent for " & plrDamage & " damage, but their armor absorbs " & eneDefend & " damage.")
                    enemy.currEnd -= (plrDamage - eneDefend)
                Else                            'if all damage absorbed
                    arrText.Add("You attack your opponent for " & plrDamage & " damage, but their armor absorbs all of it.")
                End If
            End If
        End If
    End Sub

    Private Sub playerFlee()
        '* * * * *
        '* This method contains the instructions for the player fleeing.
        '* * * * *

        arrText.Add("You have escaped the battle!")

        If currUser.exp < 100 Then          'if user can get more experience
            If (currEnemy.level - currUser.level) >= 2 Then
                arrText.Add("You have gained 1 experience from the battle.")
                currUser.exp += 1
            End If
        End If

        currUser.currEnd = player.currEnd   'save player endurance

        disableButtons()                    'disable buttons
        btnExit.Enabled = True              'enable Exit buton
        blnDone = True                      'allow the form to exit

        Timer1.Start()
    End Sub

    Private Sub playerStance()
        '* * * * *
        '* This method handles the player's stance in QuickCombat.
        '* * * * *

        Select Case player.stamina
            Case 2 To 20
                Dim percent As Integer = funcs.random(1, 100)
                Select Case percent
                    Case 1 To 20    '20%
                        player.stance = "Normal"
                    Case 21 To 40   '20%
                        player.stance = "Berserk"
                        player.weapon.damage *= 2
                    Case 41 To 60   '20%
                        player.stance = "Parry"
                    Case 61 To 80   '20%
                        player.stance = "Lunge"
                        player.weapon.damage *= 2           'increase damage
                        player.toHit \= 2                   'decrease hit chance
                    Case 81 To 100  '20%
                        player.stance = "Defend"
                        If player.toBlock >= 45 Then
                            player.toBlock = 90
                        Else
                            player.toBlock *= 2
                        End If
                End Select
            Case 1
                Dim percent As Integer = funcs.random(1, 100)
                Select Case percent
                    Case 1 To 20    '20%
                        player.stance = "Normal"
                        player.stance = "Berserk"
                        player.weapon.damage *= 2
                    Case 21 To 40    '20%
                        player.stance = "Parry"
                    Case 41 To 60    '20%
                        player.stance = "Lunge"
                        player.weapon.damage *= 2           'increase damage
                        player.toHit \= 2                   'decrease hit chance
                    Case 61 To 100   '40%
                        player.stance = "Defend"
                        If player.toBlock >= 45 Then
                            player.toBlock = 90
                        Else
                            player.toBlock *= 2
                        End If
                End Select
            Case 0
                player.stance = "Defend"    '100%
                If player.toBlock >= 45 Then
                    player.toBlock = 90
                Else
                    player.toBlock *= 2
                End If
        End Select
    End Sub

    Private Sub playerTurn()
        '* * * * *
        '* This method contains the instructions for the player's turn.
        '* * * * *

        If player.stance <> "Defend" AndAlso player.stance <> "Flee" Then   'not defending or fleeing
            If playerHit() Then                 'if player has chance to hit
                If enemyBlock() = False Then    'if enemy fails to block
                    playerAttack()              'attack
                Else
                    arrText.Add("Your opponent blocks your attack.")
                End If
            Else
                arrText.Add("You miss your opponent.")
            End If
        ElseIf player.stance = "Defend" Then    'if defending
            If player.toBlock >= 45 Then        'if blocking can't be doubled
                player.toBlock = 90             'set blocking to max
            Else
                player.toBlock *= 2             'double blocking
            End If

            arrText.Add("You go on the defensive and attempt to regain stamina.")
        End If
    End Sub

    Private Sub roundReset()
        '* * * * *
        '* This method contains the instructions for resetting player and enemy stats after a round.
        '* * * * *

        Select Case player.stance
            Case "Defend"   'if stance was Defend
                If player.stamina < 20 Then
                    player.stamina += 1
                End If
                player.toBlock = currUser.blocking
            Case "Berserk"  'if stance was Berserk
                player.stamina -= 2
            Case Else       'if stance is Lunge, Parry, or Normal
                player.stamina -= 1
        End Select

        Select Case enemy.stance
            Case "Defend"   'if stance was Defend
                If enemy.stamina < 20 Then
                    enemy.stamina += 1
                End If
                enemy.toBlock = currEnemy.blocking
            Case "Berserk"  'if stance was Berserk
                enemy.stamina -= 2
            Case Else       'if stance is Lunge, Parry, or Normal
                enemy.stamina -= 1
        End Select

        checkWeapon()
    End Sub

    Public Sub setEnemy()
        '* * * * *
        '* This method contains the instructions for setting up the enemy before the battle.
        '* * * * *

        lblEnemyName.Text = currEnemy.name          'display the enemy's name on the form
        enemy.currEnd = currEnemy.currEnd           'current endurance
        enemy.maxEnd = currEnemy.maxEnd             'maximum endurance
        enemy.weapon = New Weapon(currEnemy.weapon) 'set weapon
        enemy.toHit = currEnemy.attackSkill         'set chance to hit
        enemy.armor = currEnemy.armor               'set armor
        enemy.toBlock = currEnemy.blocking          'set blocking ability
        enemy.toFlee = currEnemy.slipping           'set chance to flee
        enemy.stamina = 20                          'set stamina
        enemy.stance = "Normal"                     'set stance
    End Sub

    Public Sub setPlayer()
        '* * * * *
        '* This method contains the instructions for setting up the player before the battle.
        '* * * * *

        lblPlrName.Text = currUser.name             'display the enemy's name on the form
        player.currEnd = currUser.currEnd           'current endurance
        player.maxEnd = currUser.maxEnd             'maximum endurance
        If currUser.currWeapon = "Light" Then       'if currweapon is light weapon
            player.weapon = New Weapon(currUser.lightWeapon)
            player.toHit = currUser.lightWeaponSkill + bonus()
        ElseIf currUser.currWeapon = "Heavy" Then   'if currweapon is light weapon
            player.weapon = New Weapon(currUser.heavyWeapon)
            player.toHit = currUser.heavyWeaponSkill + bonus()
        ElseIf currUser.currWeapon = "Two-H" Then   'if currweapon is light weapon
            player.weapon = New Weapon(currUser.twoHWeapon)
            player.toHit = currUser.twoHWeaponSkill + bonus()
        End If
        player.armor = currUser.armor               'set armor
        player.toBlock = currUser.blocking          'set blocking ability
        player.toFlee = currUser.slipping + bonus() 'set chance to flee
        player.stamina = 20                         'set stamina
        player.stance = "Normal"                    'set stance
    End Sub

    Public Sub surprise()
        '* * * * *
        '* This method determines if you surprise the enemy when first attacking them.
        '* * * * *

        Dim surprise As Integer = funcs.random(1, 100)
        If surprise <= currUser.stealth Then
            Dim plrDamage As Integer = funcs.random(1, player.weapon.damage)
            Dim eneDefend As Integer = funcs.random(1, enemy.armor.defense)

            If plrDamage > eneDefend Then   'if did damage
                If txtBattle.TextLength > 0 Then
                    addText("You surprise your opponent! You do " & plrDamage & " damage, but their armor absorbs " & eneDefend & " damage.")
                Else
                    txtBattle.Text = "You surprise your opponent! You do " & plrDamage & " damage, but their armor absorbs " & eneDefend & " damage."
                End If

                enemy.currEnd -= (plrDamage - eneDefend)

                If enemy.currEnd <= 0 Then  'if enemy dead
                    winBattle()             'win!
                End If
            Else                            'if all damage absorbed
                If txtBattle.TextLength > 0 Then
                    addText("You surprise your opponent! You do " & plrDamage & " damage, but their armor absorbs all of it.")
                Else
                    txtBattle.Text = "You surprise your opponent! You do " & plrDamage & " damage, but their armor absorbs all of it."
                End If
            End If
        End If
    End Sub

    Private Sub winBattle()
        '* * * * *
        '* This method contains the instructions for the player winning the battle.
        '* * * * *

        arrText.Add("You have slain your opponent!")
        currUser.currEnd = player.currEnd
        If currUser.exp < 100 Then  'if player can get more experience
            Dim exp As Integer = ((currEnemy.level + 1) - currUser.level)
            If exp > 0 Then  'if experience gained is positive
                Dim oldExp As Integer = currUser.exp
                currUser.exp += currEnemy.level
                arrText.Add("You have earned " & exp & " experience from the battle.")
                If oldExp Mod 10 > currUser.exp Mod 10 Then
                    currUser.level += 1
                    arrText.Add("You have gained a level! You are now a " & funcs.getRank(currUser) & "!")
                End If

                If currUser.exp > 100 Then  'if past maximum exp
                    currUser.exp = 100      'set to maximum
                End If
            End If
        End If

        currUser.skillPts += 1          'increment skill points
        arrText.Add("You have earned a skill point from this battle.")

        Dim gold As Integer = funcs.random(currEnemy.maxEnd \ 4, currEnemy.maxEnd)
        currUser.goldOnHand += gold     'increment gold on hand
        arrText.Add("You frisk your opponent's body and find " & gold & " gold.")

        disableButtons()                'disable buttons
        btnDefend.Enabled = False       'disable Defend button
        blnDone = True                  'allow form to close
        blnWin = True                   'win!

        Timer1.Start()                  'start Timer
    End Sub


    Private Sub btnAttack_Click(sender As System.Object, e As System.EventArgs) Handles btnAttack.Click
        '* * * * *
        '* This method starts a new round with Normal stance.
        '* * * * *

        player.stance = "Normal"
        newRound()
    End Sub

    Private Sub btnBerserk_Click(sender As System.Object, e As System.EventArgs) Handles btnBerserk.Click
        '* * * * *
        '* This method starts a new round with Berserk stance.
        '* * * * *

        player.stance = "Berserk"
        player.weapon.damage *= 2
        newRound()
    End Sub

    Private Sub btnDefend_Click(sender As System.Object, e As System.EventArgs) Handles btnDefend.Click
        '* * * * *
        '* This method starts a new round with Defend stance.
        '* * * * *

        player.stance = "Defend"
        If player.toBlock >= 45 Then
            player.toBlock = 90
        Else
            player.toBlock *= 2
        End If
        newRound()
    End Sub

    Private Sub btnFlee_Click(sender As System.Object, e As System.EventArgs) Handles btnFlee.Click
        '* * * * *
        '* This method starts a new round with Flee stance if failed to flee.
        '* * * * *

        Dim flee As Integer = funcs.random(1, 100)
        If flee <= currUser.slipping Then       'if flee has chance to be successful
            Dim block As Integer = funcs.random(1, 100)
            If block > enemy.toBlock Then       'successful flee
                playerFlee()
            Else                                'blocked flee
                player.stance = "Flee"
                arrText.Add("Your opponent blocked your attempt to flee.")
                newRound()
            End If
        Else
            player.stance = "Flee"
            arrText.Add("Your attempt at flight failed miserably.")
            newRound()
        End If
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        '* * * * *
        '* This method closes the form on clicking the Exit button.
        '* * * * *

        Me.Close()
    End Sub

    Private Sub btnInventory_Click(sender As System.Object, e As System.EventArgs) Handles btnInventory.Click
        '* * * * *
        '* This method displays the Inventory form.
        '* * * * *

        frmInventory.Show()
        frmInventory.currUser = currUser
        frmInventory.blnBattle = True
        Me.Hide()
    End Sub

    Private Sub btnLunge_Click(sender As System.Object, e As System.EventArgs) Handles btnLunge.Click
        '* * * * *
        '* This method starts a new round with Lunge stance.
        '* * * * *

        player.stance = "Lunge"
        player.weapon.damage *= 2           'increase damage
        player.toHit \= 2                   'decrease hit chance
        newRound()
    End Sub

    Private Sub btnParry_Click(sender As System.Object, e As System.EventArgs) Handles btnParry.Click
        '* * * * *
        '* This method starts a new round with Parry stance.
        '* * * * *

        player.stance = "Parry"
        newRound()
    End Sub

    Private Sub btnQuickCombat_Click(sender As System.Object, e As System.EventArgs) Handles btnQuickCombat.Click
        '* * * * *
        '* This method starts quickly completes the combat.
        '* * * * *

        While player.currEnd > 0 AndAlso enemy.currEnd > 0
            playerStance()
            newRound()
        End While
    End Sub


    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        '* * * * *
        '* This method cycles the text on the Timer's tick.
        '* * * * *

        cycleText()
    End Sub


    Private Sub frmBattle_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        '* * * * *
        '* This method handles everything on form closing.
        '* * * * *

        If blnDone = False Then 'don't close the form
            e.Cancel = True
            MessageBox.Show("You must flee or finish the battle first.", "Assassin", MessageBoxButtons.OK)
        Else                    'close the form
            funcs.save(currUser)
            If blnJob = False Then
                frmGame.Show()
                frmGame.currUser = currUser
                frmGame.display()
                frmGame.addText(txtBattle.Text)
            Else
                frmJobs.Show()
                frmJobs.currUser = currUser
                frmJobs.addText(txtBattle.Text)
                frmJobs.disableButtons()
                If blnWin = True Then
                    frmJobs.arrText.Add("You take your opponent's engraved weapon back to your employer.")
                    frmJobs.getPaid()
                End If
            End If
        End If
    End Sub
End Class