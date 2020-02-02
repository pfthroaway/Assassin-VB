' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 05/25/2012
' Filename        : Armoury Form.vb
' Description     : This form contains the Armoury.

Option Strict On
Option Explicit On

Imports Assassin.Classes
Imports Assassin.Classes.Entities
Imports Assassin.Classes.Items

Namespace Forms.Shopping

    Public Class FrmArmor
        Public BlnLoaded As Boolean = False     'has form loaded?
        Dim _buyArmor As New Armor               'currently selected armor

        ''' <summary>Add text to the TextBox.</summary>
        ''' <param name="newText">Text to be added</param>
        Public Sub AddText(newText As String)
            AddTextToTextBox(TxtArmor, newText)
        End Sub

        ''' <summary>Clears all labels and the Listbox.</summary>
        Private Sub Clear()
            LblGold.Text = ""
            LblCurrent.Text = ""
            LblValue.Text = ""
            LblCurrentDefense.Text = ""
            LblSelected.Text = ""
            LblPrice.Text = ""
            LblSelectedDefense.Text = ""
            LblValue.Text = ""
            LstArmor.ClearSelected()
            LstArmor.Items.Clear()
            BtnPurchase.Enabled = False
            BtnClear.Enabled = False
        End Sub

        ''' <summary>Populates the ListBox with armor names.</summary>
        Public Sub DisplayArmor()
            For Each armor As Armor In AllArmor
                If armor.Name <> "Clothes" Then
                    LstArmor.Items.Add(armor.Name)
                End If
            Next

            Display()
        End Sub

        ''' <summary>Displays all the <see cref="User"/>'s information.</summary>
        Private Sub Display()
            LblCurrent.Text = CurrentUser.Armor.Name
            LblGold.Text = CurrentUser.GoldOnHand.ToString
            LblCurrentDefense.Text = CurrentUser.Armor.DefenseToString
            LblValue.Text = CurrentUser.Armor.SellValueToString
            BtnSell.Enabled = CurrentUser.Armor.Value > 0

            If LstArmor.SelectedIndex >= 0 Then
                BtnClear.Enabled = True
                _buyArmor = AllArmor.Find(Function(armor) armor.Name = LstArmor.SelectedItem.ToString)

                BtnPurchase.Enabled = _buyArmor.Value <= CurrentUser.GoldOnHand AndAlso Not _buyArmor.Equals(CurrentUser.Armor)
                LblSelected.Text = _buyArmor.Name
                LblSelectedDefense.Text = _buyArmor.DefenseToString
                LblPrice.Text = _buyArmor.ValueToString
            End If
        End Sub

        ''' <summary>The <see cref="User"/> purchases <see cref="Armor"/>.</summary>
        Private Async Sub Purchase()
            Dim dlg As DialogResult
            Dim dlgQuestion As String = $"Are you sure you want to purchase this {_buyArmor.Name}?"

            If Not CurrentUser.Armor.Name = "Clothes" Then
                dlgQuestion += $"{ControlChars.NewLine}You will sell your {CurrentUser.Armor.Name} for {CurrentUser.Armor.SellValue} gold."
            End If

            dlg = MessageBox.Show(dlgQuestion, "Assassin", MessageBoxButtons.YesNo)

            If dlg = DialogResult.Yes Then
                If Not CurrentUser.Armor.Name = "Clothes" Then
                    AddText($"You sell your {CurrentUser.Armor.Name} for {CurrentUser.Armor.SellValue} gold.")
                    CurrentUser.GoldOnHand += CurrentUser.Armor.SellValue
                End If
                CurrentUser.GoldOnHand -= _buyArmor.Value
                AddText($"You purchase the {_buyArmor.Name} for {_buyArmor.Value} gold.")
                CurrentUser.Armor = _buyArmor
            End If

            Clear()
            DisplayArmor()
            Display()
            Await SaveUser(CurrentUser)
        End Sub

        ''' <summary>Sells the <see cref="User"/>'s <see cref="Armor"/>.</summary>
        Private Async Sub Sell()
            Dim dlg As DialogResult
            Dim dlgQuestion As String = $"Are you sure you want to sell your {CurrentUser.Armor.Name} for {CurrentUser.Armor.SellValue} gold?"
            dlg = MessageBox.Show(dlgQuestion, "Assassin", MessageBoxButtons.YesNo)

            If dlg = DialogResult.Yes Then
                AddText($"You sell your {CurrentUser.Armor.Name} for {CurrentUser.Armor.SellValue} gold.")

                CurrentUser.GoldOnHand += CurrentUser.Armor.SellValue
            End If

            Clear()
            DisplayArmor()
            Display()
            Await SaveUser(CurrentUser)
        End Sub

#Region "Click"

        Private Sub Cmb_CheckedChanged(sender As Object, e As EventArgs)
            LblPrice.Text = ""
            DisplayArmor()
        End Sub

        Private Sub LstWeapons_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstArmor.SelectedIndexChanged
            Display()
        End Sub

        Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
            Close()
        End Sub

        Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
            Clear()
            DisplayArmor()
            Display()
        End Sub

        Private Sub BtnPurchase_Click(sender As Object, e As EventArgs) Handles BtnPurchase.Click
            Purchase()
        End Sub

        Private Sub BtnSell_Click(sender As Object, e As EventArgs) Handles BtnSell.Click
            Sell()
        End Sub

#End Region

        Private Sub FrmWeapons_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
            AddText("You exit the armor shop.")
            FrmShops.Show()
            FrmShops.AddText(TxtArmor.Text.Substring(0, TxtArmor.TextLength))
        End Sub

    End Class

End Namespace