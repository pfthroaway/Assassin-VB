' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 05/25/2012
' Filename        : Weapons Form.vb
' Description     : This form contains the Weapon Shop

Option Strict On
Option Explicit On

Imports Assassin.Classes
Imports Assassin.Classes.Enums
Imports Assassin.Classes.Items

Namespace Forms.Shopping

    Public Class FrmWeapons
        Dim _weaponList As New List(Of Weapon)
        Dim _selectedWeapon As New Weapon

        Private Sub AddText(newText As String)
            AddTextToTextBox(TxtWeapons, newText)
        End Sub

        Private Sub Clear()
            '* * * * *
            '* This method clears all labels and the Listbox.
            '* * * * *
            lblGold.Text = ""
            lblCurrent.Text = ""
            lblValue.Text = ""
            lblCurrentDamage.Text = ""
            lblSelected.Text = ""
            lblPrice.Text = ""
            lblSelectedDamage.Text = ""

            LstWeapons.ClearSelected()
            LstWeapons.Items.Clear()
            BtnPurchase.Enabled = False
            BtnClear.Enabled = False

            CmbLight.Checked = True
            DisplayWeapons()
        End Sub

        Public Sub DisplayWeapons()
            '* * * * *
            '* This method populates the ListBox with weapon names.
            '* * * * *

            LstWeapons.Items.Clear()                        'clear Listbox so no duplicates
            _weaponList.Clear()

            If CmbLight.Checked Then
                _weaponList = AllWeapons.Where(Function(weapon) weapon.Type = WeaponType.Light).ToList()
            ElseIf CmbHeavy.Checked Then
                _weaponList = AllWeapons.Where(Function(weapon) weapon.Type = WeaponType.Heavy).ToList()
            ElseIf CmbTwoH.Checked Then
                _weaponList = AllWeapons.Where(Function(weapon) weapon.Type = WeaponType.TwoHanded).ToList()
            End If

            For Each weapon As Weapon In _weaponList
                LstWeapons.Items.Add(weapon.Name)
            Next

            If LstWeapons.Items.Contains("Hands") Then
                LstWeapons.Items.Remove("Hands")
            End If

            Display()
        End Sub

        Private Sub Display()
            If LstWeapons.SelectedIndex >= 0 Then   'display selected weapon information
                If CmbLight.Checked Then
                    _selectedWeapon = AllWeapons.Find(Function(weapon) weapon.Name = LstWeapons.SelectedItem.ToString AndAlso weapon.Type = WeaponType.Light)
                    BtnPurchase.Enabled = _selectedWeapon.Value <= CurrentUser.GoldOnHand AndAlso Not _selectedWeapon.Equals(CurrentUser.LightWeapon)
                ElseIf CmbHeavy.Checked Then
                    _selectedWeapon = AllWeapons.Find(Function(weapon) weapon.Name = LstWeapons.SelectedItem.ToString AndAlso weapon.Type = WeaponType.Heavy)
                    BtnPurchase.Enabled = _selectedWeapon.Value <= CurrentUser.GoldOnHand AndAlso Not _selectedWeapon.Equals(CurrentUser.LightWeapon)
                ElseIf CmbTwoH.Checked Then
                    _selectedWeapon = AllWeapons.Find(Function(weapon) weapon.Name = LstWeapons.SelectedItem.ToString AndAlso weapon.Type = WeaponType.TwoHanded)
                    BtnPurchase.Enabled = _selectedWeapon.Value <= CurrentUser.GoldOnHand AndAlso Not _selectedWeapon.Equals(CurrentUser.LightWeapon)
                End If
                BtnClear.Enabled = True

                lblSelected.Text = _selectedWeapon.Name
                lblPrice.Text = _selectedWeapon.Value.ToString
                lblSelectedDamage.Text = _selectedWeapon.Damage.ToString
            Else
                BtnPurchase.Enabled = False
                BtnClear.Enabled = False
                lblSelected.Text = ""
                lblPrice.Text = ""
                lblSelectedDamage.Text = ""
            End If

            lblGold.Text = CurrentUser.GoldOnHand.ToString
            lblCurrent.Text = CurrentUser.CurrentWeapon.Name
            lblValue.Text = CurrentUser.CurrentWeapon.SellValue.ToString
            lblCurrentDamage.Text = CurrentUser.CurrentWeapon.Damage.ToString

            BtnSell.Enabled = CurrentUser.CurrentWeapon.Value > 0
        End Sub

        Private Async Sub Purchase()
            '* * * * *
            '* This method purchases a weapon.
            '* * * * *

            Dim dlgQuestion As String = ""
            Dim dlg As DialogResult

            dlgQuestion = $"Are you sure you want to purchase this {_selectedWeapon.Name}?"

            If CmbLight.Checked = True Then
                If Not CurrentUser.LightWeapon.Name = "Hands" Then
                    dlgQuestion += $"{ControlChars.NewLine}You will sell your {CurrentUser.LightWeapon.Name} for {CurrentUser.LightWeapon.SellValue} gold."
                End If
            ElseIf CmbHeavy.Checked = True Then
                If Not CurrentUser.HeavyWeapon.Name = "Hands" Then
                    dlgQuestion += $"{ControlChars.NewLine}You will sell your {CurrentUser.HeavyWeapon.Name} for {CurrentUser.HeavyWeapon.SellValue} gold."
                End If
            ElseIf CmbTwoH.Checked = True Then
                If Not CurrentUser.TwoHandedWeapon.Name = "Hands" Then
                    dlgQuestion += $"{ControlChars.NewLine}You will sell your {CurrentUser.TwoHandedWeapon.Name} for {CurrentUser.TwoHandedWeapon.SellValue} gold."
                End If
            End If

            dlg = MessageBox.Show(dlgQuestion, "Assassin", MessageBoxButtons.YesNo)

            If dlg = DialogResult.Yes Then
                Select Case _selectedWeapon.Type
                    Case WeaponType.Light
                        If Not CurrentUser.LightWeapon.Name = "Hands" Then
                            AddText($"You sell your {CurrentUser.LightWeapon.Name} for {CurrentUser.LightWeapon.SellValue} gold.")
                            CurrentUser.GoldOnHand += CurrentUser.LightWeapon.SellValue
                        End If
                        CurrentUser.LightWeapon = _selectedWeapon
                    Case WeaponType.Heavy
                        If Not CurrentUser.HeavyWeapon.Name = "Hands" Then
                            AddText($"You sell your {CurrentUser.HeavyWeapon.Name} for {CurrentUser.HeavyWeapon.SellValue} gold.")
                            CurrentUser.GoldOnHand += CurrentUser.HeavyWeapon.SellValue
                        End If
                        CurrentUser.HeavyWeapon = _selectedWeapon
                    Case WeaponType.TwoHanded
                        If Not CurrentUser.TwoHandedWeapon.Name = "Hands" Then
                            AddText($"You sell your {CurrentUser.TwoHandedWeapon.Name} for {CurrentUser.TwoHandedWeapon.SellValue} gold.")
                            CurrentUser.GoldOnHand += CurrentUser.TwoHandedWeapon.SellValue
                        End If
                        CurrentUser.TwoHandedWeapon = _selectedWeapon
                End Select
                CurrentUser.GoldOnHand -= _selectedWeapon.Value
                AddText($"You purchase the {_selectedWeapon.Name} for {_selectedWeapon.Value} gold.")

                Clear()             'set to defaults
                DisplayWeapons()    'display weapons
                Display()           'display gold and weapon name
                Await SaveUser(CurrentUser)
            End If
        End Sub

        Private Async Sub Sell()
            '* * * * *
            '* This method sells a weapon.
            '* * * * *

            Dim dlg As DialogResult

            dlg = MessageBox.Show($"Are you sure you want to sell this {CurrentUser.CurrentWeapon.Name} for {CurrentUser.CurrentWeapon.SellValue} gold?", "Assassin", MessageBoxButtons.YesNo)

            If dlg = DialogResult.Yes Then
                AddText($"You sell your {CurrentUser.CurrentWeapon.Name} for {CurrentUser.CurrentWeapon.SellValue} gold.")
                CurrentUser.GoldOnHand += CurrentUser.CurrentWeapon.SellValue

                Select Case CurrentUser.CurrentWeapon.Type
                    Case WeaponType.Light
                        CurrentUser.LightWeapon = AllWeapons.Find(Function(weapon) weapon.Name = "Hands" AndAlso weapon.Type = WeaponType.Light)
                    Case WeaponType.Heavy
                        CurrentUser.HeavyWeapon = AllWeapons.Find(Function(weapon) weapon.Name = "Hands" AndAlso weapon.Type = WeaponType.Heavy)
                    Case WeaponType.TwoHanded
                        CurrentUser.TwoHandedWeapon = AllWeapons.Find(Function(weapon) weapon.Name = "Hands" AndAlso weapon.Type = WeaponType.TwoHanded)
                End Select
            End If

            Clear()             'set to defaults
            DisplayWeapons()    'display weapons
            Display()           'display gold and weapon name
            Await SaveUser(CurrentUser)              'save
        End Sub

        Private Sub Cmb_CheckedChanged(sender As Object, e As EventArgs) Handles CmbLight.CheckedChanged, CmbHeavy.CheckedChanged, CmbTwoH.CheckedChanged
            '* * * * *
            '* This method detects when one of the Radio buttons has changed.
            '* * * * *

            lblPrice.Text = ""
            DisplayWeapons()
        End Sub

        Private Sub LstWeapons_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstWeapons.SelectedIndexChanged
            '* * * * *
            '* This method calls the display method when a user changes Listbox selections.
            '* * * * *

            Display()
        End Sub

        Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
            '* * * * *
            '* This method closes the form on clicking the Back button.
            '* * * * *

            Close()
        End Sub

        Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
            '* * * * *
            '* This method clears and resets all form data.
            '* * * * *

            Clear()
            DisplayWeapons()
            Display()
        End Sub

        Private Sub BtnPurchase_Click(sender As Object, e As EventArgs) Handles BtnPurchase.Click
            '* * * * *
            '* This method purchases a weapon.
            '* * * * *

            Purchase()
        End Sub

        Private Sub BtnSell_Click(sender As Object, e As EventArgs) Handles BtnSell.Click
            '* * * * *
            '* This method sells a weapon.
            '* * * * *

            Sell()
        End Sub

        Private Sub FrmWeapons_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
            '* * * * *
            '* This method closes the form and saves information to the previous form.
            '* * * * *

            AddText("You exit the weapon shop.")
            FrmShops.Show()
            FrmShops.AddText(TxtWeapons.Text)
        End Sub

    End Class

End Namespace