Option Strict On
Option Explicit On

Imports Assassin.Classes
Imports Assassin.Classes.Entities
Imports Assassin.Classes.Enums
Imports Assassin.Classes.Items
Imports Extensions
Imports Extensions.DataTypeHelpers

Namespace Forms.Admin

    Public Class FrmAdminEnemies

        Dim _blnNew As Boolean
        Dim _currentEnemy As Enemy

        ''' <summary>Clears all information on the Form.</summary>
        Private Sub Clear()
            _currentEnemy = New Enemy()
            CurrentEnemy = New Enemy()
            ToggleControls(False)
            BtnNew.Enabled = True
            LstEnemies.ClearSelected()
            TxtName.Clear()
            TxtLevel.Clear()
            TxtEndurance.Clear()
            CmbWeaponType.SelectedIndex = 0
            CmbWeapon.SelectedIndex = 0
            CmbWeaponType.SelectedIndex = 0
            CmbArmor.SelectedIndex = 0
            TxtGold.Clear()
            TxtWeaponSkill.Clear()
            TxtSlipping.Clear()
            TxtBlocking.Clear()
        End Sub

        ''' <summary>Toggles all Controls on the Form.</summary>
        ''' <param name="enabled">Should the Controls be enabled?</param>
        Private Sub ToggleControls(enabled As Boolean)
            BtnClear.Enabled = enabled
            BtnSave.Enabled = enabled
            BtnDelete.Enabled = enabled

            TxtName.Enabled = enabled
            TxtLevel.Enabled = enabled
            TxtEndurance.Enabled = enabled
            CmbWeaponType.Enabled = enabled
            CmbWeapon.Enabled = enabled
            CmbArmor.Enabled = enabled
            TxtGold.Enabled = enabled
            TxtWeaponSkill.Enabled = enabled
            TxtBlocking.Enabled = enabled
            TxtSlipping.Enabled = enabled
        End Sub

        ''' <summary>Displays information about an <see cref="Enemy"/>.</summary>
        Private Sub Display()
            ToggleControls(True)
            BtnNew.Enabled = False

            TxtName.Text = CurrentEnemy.Name
            TxtLevel.Text = CurrentEnemy.Level.ToString()
            TxtEndurance.Text = CurrentEnemy.MaximumEndurance.ToString()
            CmbWeaponType.SelectedItem = CurrentEnemy.Weapon.Type.ToString()
            CmbWeapon.SelectedItem = CurrentEnemy.Weapon
            CmbArmor.SelectedItem = CurrentEnemy.Armor
            TxtGold.Text = CurrentEnemy.GoldOnHand.ToString()
            TxtWeaponSkill.Text = CurrentEnemy.WeaponSkill.ToString()
            TxtBlocking.Text = CurrentEnemy.Blocking.ToString()
            TxtSlipping.Text = CurrentEnemy.Slipping.ToString()
        End Sub

        ''' <summary>Loads everything for the Form.</summary>
        Private Sub LoadEnemies()
            LstEnemies.Items.Clear()
            For Each enemy In AllEnemies
                LstEnemies.Items.Add(enemy)
            Next
        End Sub

        ''' <summary>Saves the current <see cref="Enemy"/> to the database.</summary>
        Private Async Sub Save()
            If TxtName.Text.Trim().Length >= 4 AndAlso TxtLevel.Text.Trim().Length > 0 AndAlso TxtEndurance.Text.Trim().Length > 0 AndAlso CmbWeaponType.SelectedIndex >= 0 AndAlso CmbWeapon.SelectedIndex >= 0 AndAlso CmbArmor.SelectedIndex >= 0 AndAlso TxtGold.Text.Trim().Length > 0 AndAlso TxtWeaponSkill.Text.Trim().Length > 0 AndAlso TxtBlocking.Text.Trim().Length > 0 AndAlso TxtSlipping.Text.Trim().Length > 0 Then
                _currentEnemy.Name = TxtName.Text.Trim()
                _currentEnemy.Level = Int32Helper.Parse(TxtLevel.Text.Trim())
                _currentEnemy.CurrentEndurance = Int32Helper.Parse(TxtEndurance.Text.Trim())
                _currentEnemy.MaximumEndurance = _currentEnemy.CurrentEndurance
                _currentEnemy.Weapon = CType(CmbWeapon.SelectedItem, Weapon)
                _currentEnemy.Armor = CType(CmbArmor.SelectedItem, Armor)
                _currentEnemy.GoldOnHand = Int32Helper.Parse(TxtGold.Text.Trim())
                _currentEnemy.WeaponSkill = Int32Helper.Parse(TxtWeaponSkill.Text.Trim())
                _currentEnemy.Blocking = Int32Helper.Parse(TxtBlocking.Text.Trim())
                _currentEnemy.Slipping = Int32Helper.Parse(TxtSlipping.Text.Trim())
                If _currentEnemy.Name = CurrentEnemy.Name OrElse Not AllEnemies.Exists(Function(enemy) enemy.Name = _currentEnemy.Name) Then
                    If Not _blnNew Then
                        If Await DatabaseInteraction.SaveEnemy(_currentEnemy, CurrentEnemy) Then
                            MessageBox.Show("Enemy successfully saved.", "Assassin", MessageBoxButtons.OK)
                            AllEnemies.Replace(CurrentEnemy, _currentEnemy)
                        End If
                    Else
                        If Await DatabaseInteraction.NewEnemy(_currentEnemy) Then
                            MessageBox.Show("Enemy successfully saved.", "Assassin", MessageBoxButtons.OK)
                            AllEnemies.Add(_currentEnemy)
                            AllEnemies = AllEnemies.OrderBy(Function(enemy) enemy.Level).ThenBy(Function(enemy) enemy.Name).ToList()
                            _blnNew = False
                        End If
                    End If
                    Clear()
                    LoadEnemies()
                Else
                    MessageBox.Show("The Enemy name you have chosen is already taken.", "Assassin", MessageBoxButtons.OK)
                End If
            Else
                MessageBox.Show("Please ensure all fields have valid data. The Enemy's name must be at least 4 characters.", "Assassin", MessageBoxButtons.OK)
            End If
        End Sub

#Region "Click"

        Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
            Clear()
        End Sub

        Private Async Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
            If AllEnemies.Count > 1 AndAlso MessageBox.Show($"Are you sure you want to delete {CurrentEnemy.Name}?{ControlChars.NewLine}This action cannot be undone.", "Assassin", MessageBoxButtons.YesNo) = DialogResult.Yes AndAlso Await DatabaseInteraction.DeleteEnemy(CurrentEnemy) Then
                MessageBox.Show("Enemy deleted successfully.", "Assassin", MessageBoxButtons.OK)
                AllEnemies.Remove(CurrentEnemy)
                LoadEnemies()
                Clear()
            ElseIf AllEnemies.Count = 1 Then
                MessageBox.Show("There must be at least one Enemy.", "Assassin", MessageBoxButtons.OK)
            End If
        End Sub

        Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
            Close()
        End Sub

        Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
            _blnNew = True
            ToggleControls(True)
            BtnNew.Enabled = False
            TxtName.Focus()
        End Sub

        Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
            Save()
        End Sub

        Private Sub CmbWeaponType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbWeaponType.SelectedIndexChanged
            CmbWeapon.Items.Clear()
            For Each weapon As Weapon In AllWeapons.Where(Function(wpn) wpn.Type = EnumHelper.Parse(Of WeaponType)(CmbWeaponType.SelectedItem.ToString())).ToList()
                CmbWeapon.Items.Add(weapon)
            Next
        End Sub

        Private Sub LstEnemies_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstEnemies.SelectedIndexChanged
            If LstEnemies.SelectedIndex >= 0 Then
                CurrentEnemy = CType(LstEnemies.SelectedItem, Enemy)
                _currentEnemy = New Enemy(CType(LstEnemies.SelectedItem, Enemy))
                Display()
            End If
        End Sub

#End Region

#Region "Form Manipulation"

#Region "KeyPress"

        Private Sub NumKeys_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtEndurance.KeyPress, TxtWeaponSkill.KeyPress, TxtBlocking.KeyPress, TxtSlipping.KeyPress, TxtLevel.KeyPress, TxtGold.KeyPress
            e.Handled = Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar Like Chr(8))
        End Sub

        Private Sub TxtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtName.KeyPress
            e.Handled = Not (Char.IsLetter(e.KeyChar) OrElse e.KeyChar Like Chr(8))
        End Sub

#End Region

#Region "Text Changed"

        Private Sub TxtBlocking_TextChanged(sender As Object, e As EventArgs) Handles TxtBlocking.TextChanged
            If TxtBlocking.TextLength > 0 Then
                If CInt(TxtBlocking.Text.Trim()) > 90 Then
                    TxtBlocking.Clear()
                End If
            End If
        End Sub

        Private Sub TxtLevel_TextChanged(sender As Object, e As EventArgs) Handles TxtLevel.TextChanged
            If TxtLevel.TextLength > 0 Then
                If CInt(TxtLevel.Text.Trim()) > 10 Then
                    TxtLevel.Clear()
                End If
            End If
        End Sub

        Private Sub TxtSlipping_TextChanged(sender As Object, e As EventArgs) Handles TxtSlipping.TextChanged
            If TxtSlipping.TextLength > 0 Then
                If CInt(TxtSlipping.Text.Trim()) > 90 Then
                    TxtSlipping.Clear()
                End If
            End If
        End Sub

        Private Sub TxtWeaponSkill_TextChanged(sender As Object, e As EventArgs) Handles TxtWeaponSkill.TextChanged
            If TxtWeaponSkill.TextLength > 0 Then
                If CInt(TxtWeaponSkill.Text.Trim()) > 90 Then
                    TxtWeaponSkill.Clear()
                End If
            End If
        End Sub

#End Region

        Private Sub FrmAdminEnemies_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            CmbArmor.Items.Clear()
            For Each armor As Armor In AllArmor
                CmbArmor.Items.Add(armor)
            Next
            LoadEnemies()
            Clear()
        End Sub

        Private Sub FrmAdminEnemies_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
            FrmAdmin.Show()
        End Sub

        Private Sub LstEnemies_Leave(sender As Object, e As EventArgs) Handles LstEnemies.Leave
            LstEnemies.Update()
        End Sub

#End Region

    End Class

End Namespace