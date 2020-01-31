' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 09/06/2012
' Filename        : Admin Enemies Form.vb
' Description     : This form contains all Enemy administrative functions.

Option Strict On
Option Explicit On

Namespace Forms.Admin

    Public Class FrmAdminEnemies
        'TODO Fix Admin Enemies
        'Dim _currentEnemy As New Enemy

        'Private Sub Clear()
        '    '* * * * *
        '    '* This method clears all information on the form.
        '    '* * * * *

        '    Disable()

        '    LstEnemies.ClearSelected()
        '    TxtName.Clear()
        '    TxtEndurance.Clear()
        '    CmbWeaponType.SelectedIndex = 0
        '    CmbWeapon.Items.Clear()
        '    CmbWeapon.Items.Add("Hands")
        '    CmbWeapon.SelectedIndex = 0
        '    CmbWeaponType.SelectedIndex = 0
        '    CmbArmor.SelectedIndex = 0
        '    TxtWeaponSkill.Clear()
        '    TxtSlipping.Clear()
        '    TxtBlocking.Clear()
        'End Sub

        'Private Sub Disable()
        '    '* * * * *
        '    '* This method disables most of the fields on the form.
        '    '* * * * *

        '    BtnClear.Enabled = False
        '    BtnSave.Enabled = False

        '    TxtName.Enabled = False
        '    TxtEndurance.Enabled = False
        '    CmbWeaponType.Enabled = False
        '    CmbWeapon.Enabled = False
        '    CmbArmor.Enabled = False
        '    TxtWeaponSkill.Enabled = False
        '    TxtBlocking.Enabled = False
        '    TxtSlipping.Enabled = False
        'End Sub

        'Private Sub Display()
        '    ''* * * * *
        '    ''* This method displays information about an enemy.
        '    ''* * * * *

        '    'Enable()
        '    'GetEnemy()

        '    'txtName.Text = _currentEnemy.Name
        '    'txtEndurance.Text = _currentEnemy.MaximumEndurance.ToString
        '    'cmbWeaponType.SelectedItem = _currentEnemy.Stance
        '    'If _weaponType = "Light" Then
        '    '    LoadLightWeapons()
        '    'ElseIf _weaponType = "Heavy" Then
        '    '    LoadHeavyWeapons()
        '    'ElseIf _weaponType = "Two-H" Then
        '    '    LoadTwoHWeapons()
        '    'End If
        '    'cmbWeapon.SelectedItem = _currentEnemy.Weapon.Name
        '    'cmbArmor.SelectedItem = _currentEnemy.Armor.Name
        '    'txtWeaponSkill.Text = _currentEnemy.AttackSkill.ToString
        '    'txtBlocking.Text = _currentEnemy.Blocking.ToString
        '    'txtSlipping.Text = _currentEnemy.Slipping.ToString
        'End Sub

        'Private Sub Enable()

        '    '* * * * *
        '    '* This method enables most of the fields on the form.
        '    '* * * * *

        '    BtnClear.Enabled = True
        '    BtnSave.Enabled = True

        '    TxtName.Enabled = True
        '    TxtEndurance.Enabled = True
        '    CmbWeaponType.Enabled = True
        '    CmbWeapon.Enabled = True
        '    CmbArmor.Enabled = True
        '    TxtWeaponSkill.Enabled = True
        '    TxtBlocking.Enabled = True
        '    TxtSlipping.Enabled = True
        'End Sub

        'Private Async Sub SaveEnemy()

        '    MessageBox.Show("Enemy successfully saved.", "Assassin", MessageBoxButtons.OK)
        '    Clear()
        '    LoadEnemies()
        'End Sub

        'Private Sub LstEnemies_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstEnemies.SelectedIndexChanged
        '    '* * * * *
        '    '* This method handles the selected index of LstEnemies being changed.
        '    '* * * * *

        '    If LstEnemies.SelectedIndex >= 0 Then
        '        Display()
        '    End If
        'End Sub

        'Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        '    '* * * * *
        '    '* This method clears all data on the form.
        '    '* * * * *

        '    Clear()
        'End Sub

        'Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        '    '* * * * *
        '    '* This method closes the form on clicking the Exit button.
        '    '* * * * *

        '    Me.Close()
        'End Sub

        'Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        '    '* * * * *
        '    '* This method saves the current enemy.
        '    '* * * * *

        '    SaveEnemy()
        'End Sub

        'Private Sub FrmAdminEnemies_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '    '* * * * *
        '    '* This method handles the form loading.
        '    '* * * * *

        '    LoadEnemies()
        '    Clear()
        'End Sub

        'Private Sub FrmAdminEnemies_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        '    '* * * * *
        '    '* This method handles the form closing.
        '    '* * * * *

        '    FrmAdmin.Show()
        'End Sub

        'Private Sub numKeys_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtEndurance.KeyPress,
        '                                                                                                    TxtWeaponSkill.KeyPress, TxtBlocking.KeyPress, TxtSlipping.KeyPress
        '    '* * * * *
        '    '* This method handles the fields which require numbers
        '    '* * * * *

        '    If Char.IsDigit(e.KeyChar) OrElse e.KeyChar Like Chr(8) Then
        '        e.Handled = False
        '    Else
        '        e.Handled = True
        '    End If
        'End Sub

        'Private Sub TxtWeaponSkill_TextChanged(sender As Object, e As EventArgs) Handles TxtWeaponSkill.TextChanged
        '    '* * * * *
        '    '* This method prevents numbers above 90 in the TxtWeaponSkill field.
        '    '* * * * *

        '    If TxtWeaponSkill.TextLength > 0 Then
        '        If CInt(txtWeaponSkill.Text) > 90 Then
        '            TxtWeaponSkill.Clear()
        '        End If
        '    End If
        'End Sub

        'Private Sub TxtSlipping_TextChanged(sender As Object, e As EventArgs) Handles TxtSlipping.TextChanged
        '    '* * * * *
        '    '* This method prevents numbers above 90 in the TxtSlipping field.
        '    '* * * * *

        '    If TxtSlipping.TextLength > 0 Then
        '        If CInt(txtSlipping.Text) > 90 Then
        '            TxtSlipping.Clear()
        '        End If
        '    End If
        'End Sub

        'Private Sub TxtBlocking_TextChanged(sender As Object, e As EventArgs) Handles TxtBlocking.TextChanged
        '    '* * * * *
        '    '* This method prevents numbers above 90 in the TxtBlocking field.
        '    '* * * * *

        '    If TxtBlocking.TextLength > 0 Then
        '        If CInt(txtBlocking.Text) > 90 Then
        '            TxtBlocking.Clear()
        '        End If
        '    End If
        'End Sub

        'Private Sub TxtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtName.KeyPress
        '    '* * * * *
        '    '* This method prevents numbers above 90 in the TxtBlocking field.
        '    '* * * * *

        '    If Char.IsLetter(e.KeyChar) OrElse e.KeyChar Like Chr(8) Then
        '        e.Handled = False
        '    Else
        '        e.Handled = True
        '    End If
        'End Sub

    End Class

End Namespace