Option Strict On
Option Explicit On

Imports Assassin.Classes
Imports Assassin.Classes.Entities
Imports Assassin.Classes.Enums
Imports Assassin.Classes.Items

Namespace Forms.Shopping

    Public Class FrmWeapons
        Dim _weaponList As New List(Of Weapon)
        Dim _selectedWeapon As New Weapon

        ''' <summary>Add text to the TextBox.</summary>
        ''' <param name="newText">Text to be added</param>
        Private Sub AddText(newText As String)
            AddTextToTextBox(TxtWeapons, newText)
        End Sub

#Region "Display Management"

        ''' <summary>Clears all labels and the Listbox.</summary>
        Private Sub Clear()
            LblGold.Text = ""
            LblCurrent.Text = ""
            LblValue.Text = ""
            LblCurrentDamage.Text = ""
            LblSelected.Text = ""
            LblPrice.Text = ""
            LblSelectedDamage.Text = ""

            LstWeapons.ClearSelected()
            LstWeapons.Items.Clear()
            BtnPurchase.Enabled = False
            BtnClear.Enabled = False

            CmbLight.Checked = True
            DisplayWeapons()
        End Sub

        ''' <summary>Clears and displays everything.</summary>
        Public Sub ClearAndDisplay()
            Clear()
            DisplayWeapons()
            Display()
        End Sub

        ''' <summary>Displays all the <see cref="User"/>'s information.</summary>
        Private Sub Display()
            If LstWeapons.SelectedIndex >= 0 Then
                If CmbLight.Checked Then
                    _selectedWeapon = AllWeapons.Find(Function(weapon) weapon.Name = LstWeapons.SelectedItem.ToString AndAlso weapon.Type = WeaponType.Light)
                    BtnPurchase.Enabled = _selectedWeapon.Value <= CurrentUser.GoldOnHand AndAlso _selectedWeapon <> CurrentUser.LightWeapon
                ElseIf CmbHeavy.Checked Then
                    _selectedWeapon = AllWeapons.Find(Function(weapon) weapon.Name = LstWeapons.SelectedItem.ToString AndAlso weapon.Type = WeaponType.Heavy)
                    BtnPurchase.Enabled = _selectedWeapon.Value <= CurrentUser.GoldOnHand AndAlso _selectedWeapon <> CurrentUser.LightWeapon
                ElseIf CmbTwoH.Checked Then
                    _selectedWeapon = AllWeapons.Find(Function(weapon) weapon.Name = LstWeapons.SelectedItem.ToString AndAlso weapon.Type = WeaponType.TwoHanded)
                    BtnPurchase.Enabled = _selectedWeapon.Value <= CurrentUser.GoldOnHand AndAlso _selectedWeapon <> CurrentUser.LightWeapon
                End If
                BtnClear.Enabled = True

                LblSelected.Text = _selectedWeapon.Name
                LblPrice.Text = _selectedWeapon.Value.ToString
                LblSelectedDamage.Text = _selectedWeapon.Damage.ToString
            Else
                BtnPurchase.Enabled = False
                BtnClear.Enabled = False
                LblSelected.Text = ""
                LblPrice.Text = ""
                LblSelectedDamage.Text = ""
            End If

            LblGold.Text = CurrentUser.GoldOnHand.ToString
            LblCurrent.Text = CurrentUser.CurrentWeapon.Name
            LblValue.Text = CurrentUser.CurrentWeapon.SellValue.ToString
            LblCurrentDamage.Text = CurrentUser.CurrentWeapon.Damage.ToString

            BtnSell.Enabled = CurrentUser.CurrentWeapon.Value > 0
        End Sub

        ''' <summary>Populates the ListBox with <see cref="Weapon"/> names.</summary>
        Public Sub DisplayWeapons()
            LstWeapons.Items.Clear()
            _weaponList.Clear()

            If CmbLight.Checked Then
                _weaponList = AllWeapons.Where(Function(weapon) weapon.Type = WeaponType.Light AndAlso Not weapon.Hidden).ToList()
            ElseIf CmbHeavy.Checked Then
                _weaponList = AllWeapons.Where(Function(weapon) weapon.Type = WeaponType.Heavy AndAlso Not weapon.Hidden).ToList()
            ElseIf CmbTwoH.Checked Then
                _weaponList = AllWeapons.Where(Function(weapon) weapon.Type = WeaponType.TwoHanded AndAlso Not weapon.Hidden).ToList()
            End If

            For Each weapon As Weapon In _weaponList
                LstWeapons.Items.Add(weapon.Name)
            Next

            If LstWeapons.Items.Contains("Hands") Then
                LstWeapons.Items.Remove("Hands")
            End If

            Display()
        End Sub

#End Region

#Region "Transactions"

        ''' <summary>Purchases a <see cref="Weapon"/>.</summary>
        Private Async Sub Purchase()
            Dim dlg As DialogResult

            Dim dlgQuestion As String = $"Are you sure you want to purchase this {_selectedWeapon.Name}?"

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
                ClearAndDisplay()
                Await SaveUser(CurrentUser)
            End If
        End Sub

        ''' <summary>Sells a <see cref="Weapon"/>.</summary>
        Private Async Sub Sell()
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
            ClearAndDisplay()
            Await SaveUser(CurrentUser)
        End Sub

#End Region

#Region "Click"

        Private Sub Cmb_CheckedChanged(sender As Object, e As EventArgs) Handles CmbLight.CheckedChanged, CmbHeavy.CheckedChanged, CmbTwoH.CheckedChanged
            LblPrice.Text = ""
            DisplayWeapons()
        End Sub

        Private Sub LstWeapons_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstWeapons.SelectedIndexChanged
            Display()
        End Sub

        Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
            Close()
        End Sub

        Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
            ClearAndDisplay()
        End Sub

        Private Sub BtnPurchase_Click(sender As Object, e As EventArgs) Handles BtnPurchase.Click
            Purchase()
        End Sub

        Private Sub BtnSell_Click(sender As Object, e As EventArgs) Handles BtnSell.Click
            Sell()
        End Sub

#End Region

        Private Sub FrmWeapons_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
            AddText("You exit the weapon shop.")
            FrmShops.Show()
            FrmShops.AddText(TxtWeapons.Text.Trim())
        End Sub

    End Class

End Namespace