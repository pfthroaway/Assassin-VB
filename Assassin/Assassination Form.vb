' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 05/25/2012
' Filename        : Assassinate Form.vb
' Description     : This form allows a user to assassinate a victim.

Option Strict On
Option Explicit On

Public Class frmAssassinate
    Dim funcs As New Functions                  'new Functions instance
    Public currUser As New User                 'current user
    Dim currEnemy As New Enemy                  'current enemy
    Dim ds As New DataSet                       'DataSet
    Dim nl As String = ControlChars.NewLine     'new line
    Dim blnBattle As Boolean = False            'boolean to determine if going to battle or game form

    Private Sub addText(ByVal newText As String)
        '* * * * *
        '* This method adds text to the Textbox.
        '* * * * *

        Dim currText As String = txtAssassinate.Text
        txtAssassinate.Clear()

        txtAssassinate.Text = newText & nl & nl & currText
        txtAssassinate.Select(0, 0)
        txtAssassinate.ScrollToCaret()
    End Sub

    Public Sub checkHungerThirst()
        '* * * * *
        '* This method checks a user's hunger and thirst.
        '* * * * *

        If currUser.hunger >= 24 OrElse currUser.thirst >= 24 Then
            btnNewVictim.Enabled = False
            btnAssassinate.Enabled = False

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

    Public Sub newEnemy()
        '* * * * *
        '* This method gets a new enemy.
        '* * * * *

        currEnemy = funcs.getEnemy(currUser)
        addText("You spot a " & currEnemy.name & ".")
    End Sub


    Private Sub btnAssassinate_Click(sender As System.Object, e As System.EventArgs) Handles btnAssassinate.Click
        '* * * * *
        '* This method displays the Battle form.
        '* * * * *

        currUser.hunger += 1
        currUser.thirst += 1

        blnBattle = True
        Me.Close()
    End Sub

    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        '* * * * *
        '* This method closes the form.
        '* * * * *

        Me.Close()
    End Sub

    Private Sub btnNewVictim_Click(sender As System.Object, e As System.EventArgs) Handles btnNewVictim.Click
        '* * * * *
        '* This method gets a new enemy.
        '* * * * *

        currUser.hunger += 1
        currUser.thirst += 1

        newEnemy()
    End Sub


    Private Sub frmAssassinate_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        '* * * * *
        '* This method handles the form closing.
        '* * * * *

        If blnBattle = True Then    'if going to battle
            frmBattle.Show()
            frmBattle.currUser = currUser
            frmBattle.currEnemy = currEnemy
            frmBattle.setPlayer()
            frmBattle.setEnemy()
            frmBattle.txtBattle.Text = "You approach the " & currEnemy.name & "." & nl & nl & txtAssassinate.Text
            frmBattle.surprise()
            frmBattle.display()
        Else                        'if not going to battle
            frmGame.Show()
            frmGame.currUser = currUser
            frmGame.addText(txtAssassinate.Text)
        End If
    End Sub
End Class