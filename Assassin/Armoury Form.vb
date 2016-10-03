' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 05/25/2012
' Filename        : Armoury Form.vb
' Description     : This form contains the Armoury.

Option Strict On
Option Explicit On

Public Class frmArmor
    Dim funcs As New Functions              'new Functions instance
    Public currUser As New User             'current user
    Dim ds As New DataSet                   'DataSet
    Dim sql As String                       'SQL query
    Dim table As String                     'table name
    Dim nl As String = ControlChars.NewLine 'new line
    Public blnLoaded As Boolean = False     'has form loaded?
    Dim buyArmor As New Armor               'currently selected armor


    Private Sub addText(ByVal newText As String)
        '* * * * *
        '* This method adds formatted text to the TextBox.
        '* * * * *

        Dim currText As String = txtArmor.Text
        txtArmor.Clear()

        txtArmor.Text = newText & nl & nl & currText
        txtArmor.Select(0, 0)
        txtArmor.ScrollToCaret()
    End Sub

    Private Sub clear()
        '* * * * *
        '* This method clears all labels and the Listbox.
        '* * * * *

        lblCurrent.Text = ""
        lblGold.Text = ""
        lblPrice.Text = ""
        lblValue.Text = ""
        lstArmor.ClearSelected()
        lstArmor.Items.Clear()
        btnPurchase.Enabled = False
        btnClear.Enabled = False
    End Sub

    Public Sub displayArmor()
        '* * * * *
        '* This method populates the ListBox with armor names.
        '* * * * *

        lstArmor.Items.Clear()                          'clear Listbox so no duplicates
        ds.Clear()
        sql = "SELECT ArmorName,ArmorDefense FROM Armor ORDER BY ArmorDefense Asc"             'what we're looking for
        table = "Armor"
        ds = funcs.fillDS(sql, table)                   'fill DataSet

        For i As Integer = 0 To ds.Tables("Armor").Rows.Count - 1
            lstArmor.Items.Add(ds.Tables("Armor").Rows(i).Item("ArmorName"))
        Next

        If lstArmor.Items.Contains("Clothes") Then
            lstArmor.Items.Remove("Clothes")
        End If

        display()
    End Sub

    Private Sub display()
        '* * * * *
        '* This method displays all the user's information.
        '* * * * *

        lblGold.Text = currUser.goldOnHand.ToString

        If blnLoaded = True Then
            lblCurrent.Text = currUser.armor.name.ToString
            lblValue.Text = (currUser.armor.value \ 2).ToString

        End If

        If lstArmor.SelectedIndex >= 0 Then
            Dim armorName As String = lstArmor.SelectedItem.ToString            'save selected weapon name
            sql = "SELECT * FROM Armor WHERE ArmorName='" & armorName & "'"     'what we're looking for
            table = "Armor"

            ds.Clear()                                                          'clear DataSet so no duplicates
            ds = funcs.fillDS(sql, table)                                                'fill DataSet

            buyArmor.name = ds.Tables("Armor").Rows(0).Item("ArmorName").ToString
            Integer.TryParse(ds.Tables("Armor").Rows(0).Item("ArmorDefense").ToString, buyArmor.defense)
            Integer.TryParse(ds.Tables("Armor").Rows(0).Item("ArmorValue").ToString, buyArmor.value)
            lblPrice.Text = buyArmor.value.ToString

            btnClear.Enabled = True

            If buyArmor.value <= currUser.goldOnHand Then
                btnPurchase.Enabled = True
            Else
                btnPurchase.Enabled = False
            End If

            If buyArmor.Equals(currUser.armor) Then
                btnPurchase.Enabled = False
            End If
        End If

        If lblValue.Text = "0" Then
            btnSell.Enabled = False
        Else
            btnSell.Enabled = True
        End If
    End Sub

    Private Sub purchase()
        '* * * * *
        '* This method purchases a weapon.
        '* * * * *

        Dim dlgQuestion As String = ""
        Dim dlg As DialogResult
        Dim clothes As New Armor
        dlgQuestion = "Are you sure you want to purchase this " & buyArmor.name & "?"

        If Not currUser.armor.Equals(clothes) Then
            dlgQuestion += nl & "You will sell your " & currUser.armor.name & " for " & (currUser.armor.value \ 2) & " gold."
        End If

        dlg = MessageBox.Show(dlgQuestion, "Assassin", MessageBoxButtons.YesNo)

        If dlg = DialogResult.Yes Then
            If Not currUser.armor.Equals(clothes) Then
                addText("You sell your " & currUser.armor.name & " for " & (currUser.armor.value \ 2) & " gold.")
            End If
            currUser.goldOnHand += currUser.armor.sell
            currUser.goldOnHand -= currUser.armor.purchase(buyArmor)
            addText("You purchase the " & buyArmor.name & " for " & (buyArmor.value) & " gold.")
        End If

        clear()             'set to defaults
        displayArmor()      'display weapons
        display()           'display gold and weapon name
        funcs.save(currUser)
    End Sub

    Private Sub sell()
        '* * * * *
        '* This method sells your armor.
        '* * * * *

        Dim clothes As New Armor

        Dim type As String = ""
        Dim dlg As DialogResult
        Dim dlgQuestion As String = ""

        dlgQuestion = "Are you sure you want to sell your " & currUser.armor.name & " for " & (currUser.armor.value \ 2) & " gold?"

        dlg = MessageBox.Show(dlgQuestion, "Assassin", MessageBoxButtons.YesNo)

        If dlg = DialogResult.Yes Then
            addText("You sell your " & currUser.armor.name & " for " & (currUser.armor.value \ 2) & " gold.")

            currUser.goldOnHand += currUser.armor.sell
        End If

        clear()             'set to defaults
        displayArmor()    'display weapons
        display()           'display gold and weapon name
        funcs.save(currUser)
    End Sub


    Private Sub cmb_CheckedChanged(sender As System.Object, e As System.EventArgs)
        '* * * * *
        '* This method detects when one of the Radio buttons has changed.
        '* * * * *

        lblPrice.Text = ""
        displayArmor()
    End Sub

    Private Sub lstWeapons_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstArmor.SelectedIndexChanged
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
        displayArmor()
        display()
    End Sub

    Private Sub btnPurchase_Click(sender As System.Object, e As System.EventArgs) Handles btnPurchase.Click
        '* * * * *
        '* This method purchases a weapon.
        '* * * * *

        purchase()
    End Sub

    Private Sub btnSell_Click(sender As System.Object, e As System.EventArgs) Handles btnSell.Click
        '* * * * *
        '* This method sells a weapon.
        '* * * * *

        sell()
    End Sub


    Private Sub frmWeapons_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        '* * * * *
        '* This method closes the form and saves information to the previous form.
        '* * * * *

        addText("You exit the armor shop.")
        frmShops.Show()
        frmShops.currUser = currUser
        frmShops.addText(txtArmor.Text.Substring(0, txtArmor.TextLength))
    End Sub
End Class