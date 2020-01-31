' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 05/25/2012
' Filename        : Bar Form.vb
' Description     : This form contains the Bar.

Option Strict On
Option Explicit On

Imports Assassin.Classes
Imports Assassin.Classes.Entities
Imports Assassin.Classes.Items
Imports Assassin.Forms.GuildForms

Namespace Forms.Shopping

    Public Class FrmBar

        Dim _nl As String = ControlChars.NewLine 'new line
        Public loc As String = ""               'location
        Dim _selectedItem As Item

        Private Sub AddText(newText As String)
            '* * * * *
            '* This method adds formatted text to the TextBox.
            '* * * * *

            Dim currText As String = TxtBar.Text
            TxtBar.Clear()

            TxtBar.Text = newText & _nl & _nl & currText
            TxtBar.Select(0, 0)
            TxtBar.ScrollToCaret()
        End Sub

        Private Sub Clear()
            '* * * * *
            '* This method clears all labels and the Listbox.
            '* * * * *

            lblGold.Text = ""
            lblPrice.Text = ""
            LstPurchases.ClearSelected()
            LstPurchases.Items.Clear()
            BtnPurchase.Enabled = False
            CmbDrinks.Checked = True
        End Sub

        Public Sub DisplayPurchases()
            '* * * * *
            '* This method populates the ListBox with item names.
            '* * * * *

            LstPurchases.Items.Clear()  'clear Listbox so no duplicates

            If CmbDrinks.Checked = True Then
                For Each drink As Drink In GameState.AllDrinks
                    LstPurchases.Items.Add(drink.Name)
                Next
            ElseIf CmbFood.Checked = True Then
                For Each food As Food In GameState.AllFood
                    LstPurchases.Items.Add(food.Name)
                Next
            End If

            Display()
        End Sub

        Private Sub Display()
            '* * * * *
            '* This method displays all the user's information.
            '* * * * *

            lblGold.Text = CurrentUser.GoldOnHandToString
            lblHunger.Text = GetHunger(CurrentUser.Hunger)
            lblThirst.Text = GetThirst(CurrentUser.Thirst)

            If CurrentUser.Hunger < 20 Then
                lblHunger.ForeColor = Color.Black
            Else
                lblHunger.ForeColor = Color.Red
            End If

            If CurrentUser.Thirst < 20 Then
                lblThirst.ForeColor = Color.Black
            Else
                lblThirst.ForeColor = Color.Red
            End If

            If LstPurchases.SelectedIndex >= 0 Then
                If CmbDrinks.Checked Then
                    _selectedItem = AllDrinks.Find(Function(drink) drink.Name = LstPurchases.SelectedItem.ToString)
                ElseIf CmbFood.Checked Then
                    _selectedItem = AllFood.Find(Function(food) food.Name = LstPurchases.SelectedItem.ToString)
                End If
                lblPrice.Text = _selectedItem.ValueToString

                BtnPurchase.Enabled = CurrentUser.GoldOnHand >= _selectedItem.Value
            End If
        End Sub

        Private Async Sub Purchase()
            '* * * * *
            '* This method purchases an item.
            '* * * * *

            CurrentUser.GoldOnHand -= _selectedItem.Value

            If CmbDrinks.Checked = True Then
                CurrentUser.Thirst -= (LstPurchases.SelectedIndex + 1)
                If CurrentUser.Thirst < 0 Then CurrentUser.Thirst = 0
            ElseIf CmbFood.Checked = True Then
                CurrentUser.Hunger -= (LstPurchases.SelectedIndex + 1)
                If CurrentUser.Hunger < 0 Then CurrentUser.Hunger = 0
            End If

            AddText($"You purchase the {_selectedItem.Name}  for {_selectedItem.ValueToString} gold.")

            Display()               'display gold and stats
            Await SaveUser(CurrentUser)    'save
        End Sub

        Private Sub Cmb_CheckedChanged(sender As Object, e As EventArgs) Handles CmbDrinks.CheckedChanged, CmbFood.CheckedChanged
            '* * * * *
            '* This method detects when one of the Radio buttons has changed.
            '* * * * *

            lblPrice.Text = ""
            DisplayPurchases()
        End Sub

        Private Sub LstWeapons_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstPurchases.SelectedIndexChanged
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
            DisplayPurchases()
            Display()
        End Sub

        Private Sub BtnPurchase_Click(sender As Object, e As EventArgs) Handles BtnPurchase.Click
            '* * * * *
            '* This method purchases a weapon.
            '* * * * *

            Purchase()
        End Sub

        Private Sub FrmBar_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
            '* * * * *
            '* This method closes the form and saves information to the previous form.
            '* * * * *

            AddText("You walk away from the bar.")

            If loc = "Pub" Then
                'frmPub.Show()
            ElseIf loc = "Guild" Then
                FrmGuild.Show()
                FrmGuild.AddText(TxtBar.Text)
            ElseIf loc = "Inn" Then
                'frmInn.Show()
            End If
        End Sub

    End Class

End Namespace