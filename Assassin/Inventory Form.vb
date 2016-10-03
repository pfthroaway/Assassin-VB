' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 05/25/2012
' Filename        : Inventory Form.vb
' Description     : This form displays the user's inventory.

Option Strict On
Option Explicit On

Public Class frmInventory
    Dim funcs As New Functions  'new Functions instance
    Public currUser As New User 'current user
    Public blnBattle As Boolean 'if coming here from Battle form

    Public Sub display()
        '* * * * *
        '* This method displays the user's inventory.
        '* * * * *

        lblLight.Text = currUser.lightWeapon.name
        lblHeavy.Text = currUser.heavyWeapon.name
        lblTwoH.Text = currUser.twoHWeapon.name
        lblPotion.Text = currUser.potion
        lblLockpicks.Text = currUser.lockpicks.ToString

        btnLight.Enabled = True
        btnHeavy.Enabled = True
        btnTwoH.Enabled = True
        If currUser.currWeapon = "Light" Then
            btnLight.Enabled = False
        ElseIf currUser.currWeapon = "Heavy" Then
            btnHeavy.Enabled = False
        ElseIf currUser.currWeapon = "Two-H" Then
            btnTwoH.Enabled = False
        End If
    End Sub


    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        '* * * * *
        '* This method closes the form on clicking the back button.
        '* * * * *

        Me.Close()
    End Sub

    Private Sub btnHeavy_Click(sender As System.Object, e As System.EventArgs) Handles btnHeavy.Click
        '* * * * *
        '* This method equips the user's Heavy weapon.
        '* * * * *

        currUser.currWeapon = "Heavy"
        display()
    End Sub

    Private Sub btnLight_Click(sender As System.Object, e As System.EventArgs) Handles btnLight.Click
        '* * * * *
        '* This method equips the user's Light weapon.
        '* * * * *

        currUser.currWeapon = "Light"
        display()
    End Sub

    Private Sub btnTwoH_Click(sender As System.Object, e As System.EventArgs) Handles btnTwoH.Click
        '* * * * *
        '* This method equips the user's Two-H weapon.
        '* * * * *

        currUser.currWeapon = "Two-H"
        display()
    End Sub


    Private Sub frmInventory_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        '* * * * *
        '* This method handles closing the form.
        '* * * * *

        funcs.save(currUser)
        If blnBattle = True Then
            frmBattle.Show()
            frmBattle.currUser = currUser
            frmBattle.checkWeapon()
            frmBattle.display()
        Else
            frmGame.Show()
            frmGame.currUser = currUser
            frmGame.display()
        End If
    End Sub
End Class