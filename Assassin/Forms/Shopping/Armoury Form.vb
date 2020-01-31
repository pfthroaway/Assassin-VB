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
        ' TODO Find out why armor is out of order and doesn't show value.

        Dim _nl As String = ControlChars.NewLine 'new line
        Public BlnLoaded As Boolean = False     'has form loaded?
        Dim _buyArmor As New Armor               'currently selected armor

        Private Sub AddText(newText As String)
            '* * * * *
            '* This method adds formatted text to the TextBox.
            '* * * * *

            Dim currText As String = TxtArmor.Text
            TxtArmor.Clear()

            TxtArmor.Text = newText & _nl & _nl & currText
            TxtArmor.Select(0, 0)
            TxtArmor.ScrollToCaret()
        End Sub

        Private Sub Clear()
            '* * * * *
            '* This method clears all labels and the Listbox.
            '* * * * *

            lblCurrent.Text = ""
            lblGold.Text = ""
            lblPrice.Text = ""
            lblValue.Text = ""
            LstArmor.ClearSelected()
            LstArmor.Items.Clear()
            BtnPurchase.Enabled = False
            BtnClear.Enabled = False
        End Sub

        Public Sub DisplayArmor()
            '* * * * *
            '* This method populates the ListBox with armor names.
            '* * * * *

            For Each armor As Armor In AllArmor
                If armor.Name <> "Clothes" Then
                    LstArmor.Items.Add(armor.Name)
                End If
            Next

            Display()
        End Sub

        Private Sub Display()
            '* * * * *
            '* This method displays all the user's information.
            '* * * * *

            lblGold.Text = CurrentUser.GoldOnHand.ToString
            lblCurrent.Text = CurrentUser.Armor.Name.ToString
            lblValue.Text = (CurrentUser.Armor.Value \ 2).ToString
            BtnSell.Enabled = CurrentUser.Armor.Value > 0

            If LstArmor.SelectedIndex >= 0 Then
                BtnClear.Enabled = True
                _buyArmor = AllArmor.Find(Function(armor) armor.Name = LstArmor.SelectedItem.ToString)

                BtnPurchase.Enabled = _buyArmor.Value <= CurrentUser.GoldOnHand AndAlso Not _buyArmor.Equals(CurrentUser.Armor)
            End If

        End Sub

        Private Async Sub Purchase()
            '* * * * *
            '* This method purchases a weapon.
            '* * * * *

            Dim dlgQuestion As String = ""
            Dim dlg As DialogResult
            dlgQuestion = $"Are you sure you want to purchase this {_buyArmor.Name}?"

            If Not CurrentUser.Armor.Name = "Clothes" Then
                dlgQuestion += _nl & $"\nYou will sell your {CurrentUser.Armor.Name} for {(CurrentUser.Armor.Value \ 2)} gold."
            End If

            dlg = MessageBox.Show(dlgQuestion, "Assassin", MessageBoxButtons.YesNo)

            If dlg = DialogResult.Yes Then
                If Not CurrentUser.Armor.Name = "Clothes" Then
                    AddText($"You sell your {CurrentUser.Armor.Name} for {(CurrentUser.Armor.Value \ 2)} gold.")
                    CurrentUser.GoldOnHand += CurrentUser.Armor.Value \ 2
                End If
                CurrentUser.GoldOnHand -= _buyArmor.Value
                AddText($"You purchase the {_buyArmor.Name} for {_buyArmor.Value} gold.")
            End If

            Clear()             'set to defaults
            DisplayArmor()      'display weapons
            Display()           'display gold and weapon name
            Await SaveUser(CurrentUser)
        End Sub

        Private Async Sub Sell()
            '* * * * *
            '* This method sells your armor.
            '* * * * *

            Dim dlg As DialogResult
            Dim dlgQuestion As String = ""

            dlgQuestion = $"Are you sure you want to sell your {CurrentUser.Armor.Name} for {(CurrentUser.Armor.Value \ 2)} gold?"

            dlg = MessageBox.Show(dlgQuestion, "Assassin", MessageBoxButtons.YesNo)

            If dlg = DialogResult.Yes Then
                AddText($"You sell your {CurrentUser.Armor.Name} for {(CurrentUser.Armor.Value \ 2)} gold.")

                CurrentUser.GoldOnHand += CurrentUser.Armor.Value \ 2
            End If

            Clear()             'set to defaults
            DisplayArmor()    'display weapons
            Display()           'display gold and weapon name
            Await SaveUser(CurrentUser)
        End Sub

        Private Sub Cmb_CheckedChanged(sender As Object, e As EventArgs)
            '* * * * *
            '* This method detects when one of the Radio buttons has changed.
            '* * * * *

            lblPrice.Text = ""
            DisplayArmor()
        End Sub

        Private Sub LstWeapons_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstArmor.SelectedIndexChanged
            '* * * * *
            '* This method calls the display method when a user changes Listbox selections.
            '* * * * *

            Display()
        End Sub

        Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
            '* * * * *
            '* This method closes the form on clicking the Back button.
            '* * * * *

            Me.Close()
        End Sub

        Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
            '* * * * *
            '* This method clears and resets all form data.
            '* * * * *

            Clear()
            DisplayArmor()
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

            AddText("You exit the armor shop.")
            FrmShops.Show()
            FrmShops.AddText(TxtArmor.Text.Substring(0, TxtArmor.TextLength))
        End Sub

    End Class

End Namespace