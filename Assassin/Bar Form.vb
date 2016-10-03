' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 05/25/2012
' Filename        : Bar Form.vb
' Description     : This form contains the Bar.

Option Strict On
Option Explicit On

Public Class frmBar
    Dim funcs As New Functions              'new Functions instance
    Public currUser As New User             'current user
    Dim ds As New DataSet                   'DataSet
    Dim sql As String                       'SQL query
    Dim table As String                     'table name
    Dim nl As String = ControlChars.NewLine 'new line
    Dim price As Integer                    'selected item price
    Public loc As String = ""               'location


    Private Sub addText(ByVal newText As String)
        '* * * * *
        '* This method adds formatted text to the TextBox.
        '* * * * *

        Dim currText As String = txtBar.Text
        txtBar.Clear()

        txtBar.Text = newText & nl & nl & currText
        txtBar.Select(0, 0)
        txtBar.ScrollToCaret()
    End Sub

    Private Sub clear()
        '* * * * *
        '* This method clears all labels and the Listbox.
        '* * * * *

        lblGold.Text = ""
        lblPrice.Text = ""
        price = 0
        lstPurchases.ClearSelected()
        lstPurchases.Items.Clear()
        btnPurchase.Enabled = False
        cmbDrinks.Checked = True
    End Sub

    Public Sub displayPurchases()
        '* * * * *
        '* This method populates the ListBox with item names.
        '* * * * *

        lstPurchases.Items.Clear()  'clear Listbox so no duplicates
        table = "Purchases"

        If cmbDrinks.Checked = True Then
            sql = "SELECT * From Drinks ORDER BY ID Asc"

            ds = funcs.fillDS(sql, table)

            For i As Integer = 0 To ds.Tables("Purchases").Rows.Count - 1
                lstPurchases.Items.Add(ds.Tables("Purchases").Rows(i).Item("DrinkName"))
            Next
        ElseIf cmbFood.Checked = True Then
            sql = "SELECT * From Food ORDER BY ID Asc"

            ds = funcs.fillDS(sql, table)

            For i As Integer = 0 To ds.Tables("Purchases").Rows.Count - 1
                lstPurchases.Items.Add(ds.Tables("Purchases").Rows(i).Item("FoodName"))
            Next
        End If

        display()
    End Sub

    Private Sub display()
        '* * * * *
        '* This method displays all the user's information.
        '* * * * *

        lblGold.Text = currUser.goldOnHand.ToString
        lblHunger.Text = funcs.getHunger(currUser.hunger)
        lblThirst.Text = funcs.getThirst(currUser.thirst)

        If currUser.hunger < 20 Then
            lblHunger.ForeColor = Color.Black
        Else
            lblHunger.ForeColor = Color.Red
        End If

        If currUser.thirst < 20 Then
            lblThirst.ForeColor = Color.Black
        Else
            lblThirst.ForeColor = Color.Red
        End If

        If lstPurchases.SelectedIndex >= 0 Then
            If cmbDrinks.Checked = True Then
                sql = "SELECT * FROM Drinks WHERE ID=" & lstPurchases.SelectedIndex + 1
                table = "Drinks"
                ds.Clear()
                ds = funcs.fillDS(sql, table)
                Integer.TryParse(ds.Tables("Drinks").Rows(0).Item("ID").ToString, price)
            ElseIf cmbFood.Checked = True Then
                sql = "SELECT * FROM Food WHERE ID=" & lstPurchases.SelectedIndex + 1
                table = "Food"
                ds.Clear()
                ds = funcs.fillDS(sql, table)
                Integer.TryParse(ds.Tables("Food").Rows(0).Item("ID").ToString, price)
            End If

            price *= 5
            lblPrice.Text = price.ToString
            If currUser.goldOnHand >= price Then
                btnPurchase.Enabled = True
            Else
                btnPurchase.Enabled = False
            End If
        End If
    End Sub

    Private Sub purchase()
        '* * * * *
        '* This method purchases an item.
        '* * * * *

        currUser.goldOnHand -= price

        If cmbDrinks.Checked = True Then
            currUser.thirst -= (lstPurchases.SelectedIndex + 1)
            If currUser.thirst < 0 Then currUser.thirst = 0
        ElseIf cmbFood.Checked = True Then
            currUser.hunger -= (lstPurchases.SelectedIndex + 1)
            If currUser.hunger < 0 Then currUser.hunger = 0
        End If

        addText("You purchase the " & lstPurchases.SelectedItem.ToString & " for " & price & " gold.")

        display()               'display gold and stats
        funcs.save(currUser)    'save
    End Sub


    Private Sub cmb_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cmbDrinks.CheckedChanged, cmbFood.CheckedChanged
        '* * * * *
        '* This method detects when one of the Radio buttons has changed.
        '* * * * *

        lblPrice.Text = ""
        displayPurchases()
    End Sub

    Private Sub lstWeapons_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstPurchases.SelectedIndexChanged
        '* * * * *
        '* This method calls the display method when a user changes Listbox selections.
        '* * * * *

        display()
    End Sub


    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        '* * * * *
        '* This method closes the form on clicking the Back button.
        '* * * * *

        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        '* * * * *
        '* This method clears and resets all form data.
        '* * * * *

        clear()
        displayPurchases()
        display()
    End Sub

    Private Sub btnPurchase_Click(sender As System.Object, e As System.EventArgs) Handles btnPurchase.Click
        '* * * * *
        '* This method purchases a weapon.
        '* * * * *

        purchase()
    End Sub


    Private Sub frmBar_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        '* * * * *
        '* This method closes the form and saves information to the previous form.
        '* * * * *

        addText("You walk away from the bar.")

        If loc = "Pub" Then
            'frmPub.Show()
        ElseIf loc = "Guild" Then
            frmGuild.Show()
            frmGuild.currUser = currUser
            frmGuild.addText(txtBar.Text)
        ElseIf loc = "Inn" Then
            'frmInn.Show()
        End If
    End Sub
End Class