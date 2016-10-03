' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 05/25/2012
' Filename        : Rob Form.vb
' Description     : This form allows a user to rob a victim.

Option Strict On
Option Explicit On

Public Class frmRob
    Dim funcs As New Functions              'new Functions instance
    Public currUser As New User             'current user
    Dim ds As New DataSet                   'DataSet
    Dim sql As String                       'SQL
    Dim table As String                     'table name
    Dim currEnemy As New Enemy              'current enemy
    Dim nl As String = ControlChars.NewLine 'new line
    Dim blnCourt As Boolean = False         'boolean if going to court
    Dim arrText As New ArrayList            'arraylist of text
    Dim index As Integer                    'index on arraylist
    Dim reason As String                    'reason arrested

    Public Sub addText(ByVal newText As String)
        '* * * * *
        '* This method adds text to the Textbox.
        '* * * * *

        Dim currText As String = txtRob.Text
        txtRob.Clear()

        txtRob.Text = newText & nl & nl & currText
        txtRob.Select(0, 0)
        txtRob.ScrollToCaret()
    End Sub

    Public Sub checkHungerThirst()
        '* * * * *
        '* This method checks a user's hunger and thirst.
        '* * * * *

        If currUser.hunger >= 24 OrElse currUser.thirst >= 24 Then
            btnNewVictim.Enabled = False
            btnPickpocket.Enabled = False
            btnWaylay.Enabled = False

            If currUser.hunger >= 24 AndAlso currUser.thirst >= 24 Then
                addText("You are too hungry and thirsty to continue.")
            ElseIf currUser.hunger >= 24 Then
                addText("You are too hungry to continue.")
            ElseIf currUser.thirst >= 24 Then
                addText("You are too thirsty to continue.")
            End If
        Else
            If currUser.hunger > 0 AndAlso currUser.hunger Mod 5 = 0 Then
                addText("You are " & funcs.getHunger(currUser.hunger).ToLower & ".")
            End If
            If currUser.thirst > 0 AndAlso currUser.thirst Mod 5 = 0 Then
                addText("You are " & funcs.getThirst(currUser.thirst).ToLower & ".")
            End If
        End If
    End Sub

    Private Sub disableButtons()
        '* * * * *
        '* This method disables all the buttons while a robbery is in progress or while searching for a new victim.
        '* * * * *

        btnBack.Enabled = False
        btnPickpocket.Enabled = False
        btnWaylay.Enabled = False
        btnNewVictim.Enabled = False
    End Sub

    Public Sub display()
        '* * * * *
        '* This method displays text while the Timer is active.
        '* * * * *

        If index < arrText.Count Then
            addText(arrText(index).ToString)
            index += 1
            If index = arrText.Count Then
                arrText.Clear()
                Timer1.Stop()
                index = 0
                enableButtons()
                checkHungerThirst()
            End If
        End If
    End Sub

    Private Sub enableButtons()
        '* * * * *
        '* This method enabled all the buttons after a robbery is completed or after searching for a new victim.
        '* * * * *

        btnBack.Enabled = True
        btnPickpocket.Enabled = True
        btnWaylay.Enabled = True
        btnNewVictim.Enabled = True
    End Sub

    Public Sub getEnemy()
        '* * * * *
        '* This method gets a new enemy.
        '* * * * *

        currEnemy = funcs.getEnemy(currUser)
        disableButtons()
        arrText.Add("You spot a " & currEnemy.name & ".")
        Timer1.Start()
    End Sub


    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        '* * * * *
        '* This method closes the form on clicking the Back button.
        '* * * * *

        Me.Close()
    End Sub

    Private Sub btnNewVictim_Click(sender As System.Object, e As System.EventArgs) Handles btnNewVictim.Click
        '* * * * *
        '* This method gets a new enemy.
        '* * * * *

        getEnemy()
    End Sub

    Private Sub btnPickpocket_Click(sender As System.Object, e As System.EventArgs) Handles btnPickpocket.Click
        '* * * * *
        '* This method produces the result of attempting to pickpocket an opponent.
        '* * * * *

        currUser.hunger += 1
        currUser.thirst += 1

        Dim success As Integer = funcs.random(1, 100)
        If success <= currUser.stealth Then     'successful pickpocket
            Dim type As Integer = funcs.random(1, 3)
            Dim gold As Integer = funcs.random(1, currEnemy.maxEnd)
            If type = 1 Then                    'gold only
                addText("You manage to steal a pouch containing " & gold & " gold!")
                currUser.goldOnHand += gold
            ElseIf type = 2 Then                'weapon only
                addText("You manage to pickpocket their " & currEnemy.weapon.name & "!")
                arrText.Add("You bring it to the weaponsmith and sell it for " & (currEnemy.weapon.value \ 2) & " gold!")
                currUser.goldOnHand += (currEnemy.weapon.value \ 2)
                Timer1.Start()
            ElseIf type = 3 Then                'weapon and gold
                addText("You manage to steal a pouch containing " & gold & " gold!")
                arrText.Add("You also manage to pickpocket their " & currEnemy.weapon.name & "!")
                arrText.Add("You bring it to the weapon shop and sell it for " & (currEnemy.weapon.value \ 2) & " gold!")
                currUser.goldOnHand += (currEnemy.weapon.value \ 2) + gold
                Timer1.Start()
            End If

            funcs.save(currUser)
            getEnemy()
        Else                                    'failure pickpocket
            addText("You have failed miserably!")
            Dim noticed As Integer = funcs.random(1, 100)
            If noticed <= currUser.stealth Then  'not caught
                arrText.Add("You got away without being noticed.")
                getEnemy()
            Else                                'caught
                arrText.Add("You have been noticed!")
                arrText.Add("The " & currEnemy.name & " cries out, " & Chr(34) & "Guards, a thief!" & Chr(34))
                arrText.Add("You hide. . .")
                Dim spot As Integer = funcs.random(1, 100)
                If spot <= currUser.stealth Then    'not spotted
                    arrText.Add("It appears you have escaped!")
                    Timer1.Start()
                    getEnemy()
                Else                                'spotted
                    Timer1.Start()
                    reason = "Pickpocket"
                    Timer2.Start()
                End If
            End If
        End If
    End Sub

    Private Sub btnWaylay_Click(sender As System.Object, e As System.EventArgs) Handles btnWaylay.Click
        '* * * * *
        '* This method handles the attempt made to Waylay an opponent.
        '* * * * *

        currUser.hunger += 1
        currUser.thirst += 1

        Dim success As Integer = funcs.random(1, 100)
        If success <= currUser.stealth Then     'successful waylay
            Dim type As Integer = funcs.random(1, 3)
            Dim gold As Integer = funcs.random(1, currEnemy.maxEnd)
            If type = 1 Then                    'gold only
                addText("You manage to steal a pouch containing " & gold & " gold!")
                currUser.goldOnHand += gold
            ElseIf type = 2 Then                'weapon only
                addText("You manage to pickpocket their " & currEnemy.weapon.name & "!")
                arrText.Add("You bring it to the weaponsmith and sell it for " & (currEnemy.weapon.value \ 2) & " gold!")
                currUser.goldOnHand += (currEnemy.weapon.value \ 2)
                Timer1.Start()
            ElseIf type = 3 Then                'weapon and gold
                addText("You manage to steal a pouch containing " & gold & " gold!")
                arrText.Add("You also manage to pickpocket their " & currEnemy.weapon.name & "!")
                arrText.Add("You bring it to the weapon shop and sell it for " & (currEnemy.weapon.value \ 2) & " gold!")
                currUser.goldOnHand += (currEnemy.weapon.value \ 2) + gold
                Timer1.Start()
            End If

            funcs.save(currUser)
            getEnemy()
        Else                                        'failure waylay
            addText("You have failed miserably!")
            Dim noticed As Integer = funcs.random(1, 100)
            If noticed <= currUser.stealth Then  'not caught
                arrText.Add("You got away without being noticed.")
                getEnemy()
            Else                                'caught
                arrText.Add("You have been noticed!")
                arrText.Add("The " & currEnemy.name & " cries out, " & Chr(34) & "Guards, a thief!" & Chr(34))
                arrText.Add("You hide. . .")
                Dim spot As Integer = funcs.random(1, 100)
                If spot <= currUser.stealth Then    'not spotted
                    arrText.Add("It appears you have escaped!")
                    Timer1.Start()
                    getEnemy()
                Else                                'spotted
                    Timer1.Start()
                    reason = "Assault"
                    Timer2.Start()
                End If
            End If
        End If
    End Sub


    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        '* * * * *
        '* This method calls the display method every time a tick passes on the Timer.
        '* * * * *

        display()
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        '* * * * *
        '* This method displays the court form after a user is caught.
        '* * * * *

        frmCourt.Show()
        frmCourt.currUser = currUser
        frmCourt.reason = reason
        frmCourt.txtCourt.Text = "You have been caught!"
        frmCourt.setup()
        blnCourt = True
        Me.Close()
    End Sub


    Private Sub frmRob_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        '* * * * *
        '* This method determines which form to show on form closing.
        '* * * * *

        If blnCourt = False Then
            frmGame.Show()
            frmGame.currUser = currUser
            funcs.save(currUser)
            frmGame.display()
            addText("You return to the streets.")
        End If

        frmGame.addText(txtRob.Text)
    End Sub
End Class