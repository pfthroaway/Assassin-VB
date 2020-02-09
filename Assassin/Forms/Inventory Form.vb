Option Strict On
Option Explicit On

Imports Assassin.Classes
Imports Assassin.Classes.Enums

Namespace Forms

    Public Class FrmInventory
        Public BlnBattle As Boolean 'if coming here from Battle form

        ''' <summary>Displays the user's inventory.</summary>
        Public Sub Display()
            LblLight.Text = CurrentUser.LightWeapon.Name
            LblHeavy.Text = CurrentUser.HeavyWeapon.Name
            LblTwoH.Text = CurrentUser.TwoHandedWeapon.Name
            LblPotion.Text = CurrentUser.Potion.Name
            LblLockpicks.Text = CurrentUser.Lockpicks.ToString

            BtnLight.Enabled = CurrentUser.CurrentWeaponType <> WeaponType.Light
            BtnHeavy.Enabled = CurrentUser.CurrentWeaponType <> WeaponType.Heavy
            BtnTwoH.Enabled = CurrentUser.CurrentWeaponType <> WeaponType.TwoHanded
        End Sub

#Region "Click"

        Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
            Close()
        End Sub

        Private Sub BtnHeavy_Click(sender As Object, e As EventArgs) Handles BtnHeavy.Click
            CurrentUser.CurrentWeaponType = WeaponType.Heavy
            Display()
        End Sub

        Private Sub BtnLight_Click(sender As Object, e As EventArgs) Handles BtnLight.Click
            CurrentUser.CurrentWeaponType = WeaponType.Light
            Display()
        End Sub

        Private Sub BtnTwoH_Click(sender As Object, e As EventArgs) Handles BtnTwoH.Click
            CurrentUser.CurrentWeaponType = WeaponType.TwoHanded
            Display()
        End Sub

#End Region

        Private Async Sub FrmInventory_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
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