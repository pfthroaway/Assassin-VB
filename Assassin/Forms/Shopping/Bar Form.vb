Option Strict On
Option Explicit On

Imports Assassin.Classes
Imports Assassin.Classes.Entities
Imports Assassin.Classes.Items
Imports Assassin.Forms.GuildForms

Namespace Forms.Shopping

    Public Class FrmBar

        Public loc As String = ""               'location
        Dim _selectedItem As Item

        ''' <summary>Add text to the TextBox.</summary>
        ''' <param name="newText">Text to be added</param>
        Private Sub AddText(newText As String)
            AddTextToTextBox(TxtBar, newText)
        End Sub

#Region "Display Management"

        ''' <summary>Clears all labels and the Listbox.</summary>
        Private Sub Clear()
            LblGold.Text = ""
            LblPrice.Text = ""
            LstPurchases.ClearSelected()
            LstPurchases.Items.Clear()
            BtnPurchase.Enabled = False
            CmbDrinks.Checked = True
        End Sub

        ''' <summary>Clears and displays everything.</summary>
        Public Sub ClearAndDisplay()
            Clear()
            DisplayPurchases()
            Display()
        End Sub

        ''' <summary>Displays all the <see cref="User"/>'s information.</summary>
        Private Sub Display()
            LblGold.Text = CurrentUser.GoldOnHandToString
            LblHunger.Text = GetHunger(CurrentUser.Hunger)
            LblThirst.Text = GetThirst(CurrentUser.Thirst)

            LblHunger.ForeColor = If(CurrentUser.Hunger < 20, Color.Black, Color.Red)

            LblThirst.ForeColor = If(CurrentUser.Thirst < 20, Color.Black, Color.Red)

            If LstPurchases.SelectedIndex >= 0 Then
                If CmbDrinks.Checked Then
                    _selectedItem = AllDrinks.Find(Function(drink) drink.Name = LstPurchases.SelectedItem.ToString)
                ElseIf CmbFood.Checked Then
                    _selectedItem = AllFood.Find(Function(food) food.Name = LstPurchases.SelectedItem.ToString)
                End If
                LblPrice.Text = _selectedItem.ValueToString

                BtnPurchase.Enabled = CurrentUser.GoldOnHand >= _selectedItem.Value
            End If
        End Sub

        ''' <summary>Populates the ListBox with <see cref="Food"/> or <see cref="Drink"/> names.</summary>
        Public Sub DisplayPurchases()
            LstPurchases.Items.Clear()

            If CmbDrinks.Checked = True Then
                For Each drink As Drink In AllDrinks
                    LstPurchases.Items.Add(drink.Name)
                Next
            ElseIf CmbFood.Checked = True Then
                For Each food As Food In AllFood
                    LstPurchases.Items.Add(food.Name)
                Next
            End If

            Display()
        End Sub

#End Region

        ''' <summary>Purchases a <see cref="Food"/> or <see cref="Drink"/>.</summary>
        Private Async Sub Purchase()
            CurrentUser.GoldOnHand -= _selectedItem.Value

            If CmbDrinks.Checked = True Then
                CurrentUser.Thirst -= LstPurchases.SelectedIndex + 1
                If CurrentUser.Thirst < 0 Then CurrentUser.Thirst = 0
            ElseIf CmbFood.Checked = True Then
                CurrentUser.Hunger -= LstPurchases.SelectedIndex + 1
                If CurrentUser.Hunger < 0 Then CurrentUser.Hunger = 0
            End If

            AddText($"You purchase the {_selectedItem.Name}  for {_selectedItem.ValueToString} gold.")

            Display()
            Await SaveUser(CurrentUser)
        End Sub

#Region "Click"

        Private Sub Cmb_CheckedChanged(sender As Object, e As EventArgs) Handles CmbDrinks.CheckedChanged, CmbFood.CheckedChanged
            LblPrice.Text = ""
            DisplayPurchases()
        End Sub

        Private Sub LstWeapons_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstPurchases.SelectedIndexChanged
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

#End Region

        Private Sub FrmBar_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
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