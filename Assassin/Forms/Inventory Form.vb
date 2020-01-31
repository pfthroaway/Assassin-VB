' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 05/25/2012
' Filename        : Inventory Form.vb
' Description     : This form displays the user's inventory.

Option Strict On
Option Explicit On

Imports Assassin.Classes
Imports Assassin.Classes.Enums

Namespace Forms

    Public Class FrmInventory
        Public BlnBattle As Boolean 'if coming here from Battle form

        Public Sub Display()
            '* * * * *
            '* This method displays the user's inventory.
            '* * * * *

            lblLight.Text = CurrentUser.LightWeapon.Name
            lblHeavy.Text = CurrentUser.HeavyWeapon.Name
            lblTwoH.Text = CurrentUser.TwoHandedWeapon.Name
            lblPotion.Text = CurrentUser.Potion.Name
            lblLockpicks.Text = CurrentUser.Lockpicks.ToString

            BtnLight.Enabled = CurrentUser.CurrentWeaponType = WeaponType.Light
            BtnHeavy.Enabled = CurrentUser.CurrentWeaponType = WeaponType.Heavy
            BtnTwoH.Enabled = CurrentUser.CurrentWeaponType = WeaponType.TwoHanded
        End Sub

        Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
            '* * * * *
            '* This method closes the form on clicking the back button.
            '* * * * *

            Me.Close()
        End Sub

        Private Sub BtnHeavy_Click(sender As Object, e As EventArgs) Handles BtnHeavy.Click
            '* * * * *
            '* This method equips the user's Heavy weapon.
            '* * * * *

            CurrentUser.CurrentWeaponType = WeaponType.Heavy
            Display()
        End Sub

        Private Sub BtnLight_Click(sender As Object, e As EventArgs) Handles BtnLight.Click
            '* * * * *
            '* This method equips the user's Light weapon.
            '* * * * *

            CurrentUser.CurrentWeaponType = WeaponType.Light
            Display()
        End Sub

        Private Sub BtnTwoH_Click(sender As Object, e As EventArgs) Handles BtnTwoH.Click
            '* * * * *
            '* This method equips the user's Two-H weapon.
            '* * * * *

            CurrentUser.CurrentWeaponType = WeaponType.TwoHanded
            Display()
        End Sub

        Private Async Sub FrmInventory_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
            '* * * * *
            '* This method handles closing the form.
            '* * * * *

            Await SaveUser(CurrentUser)
            If BlnBattle = True Then
                FrmBattle.Show()
                FrmBattle.Display()
            Else
                FrmGame.Show()
                FrmGame.Display()
            End If
        End Sub

    End Class

End Namespace