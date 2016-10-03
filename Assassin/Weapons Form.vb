' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 05/25/2012
' Filename        : Weapons Form.vb
' Description     : This form contains the Weapon Shop

Option Strict On
Option Explicit On

Public Class frmWeapons
    Dim funcs As New Functions              'new Functions instance
    Public currUser As New User             'current user
    Dim ds As New DataSet                   'DataSet
    Dim sql As String                       'SQL query
    Dim table As String                     'table name
    Dim nl As String = ControlChars.NewLine 'new line
    Public blnLoaded As Boolean = False     'form loaded?
    Dim buyWeapon As New Weapon             'currently selected weapon
    Dim type As String                      'currently selected weapon type

    Private Sub addText(ByVal newText As String)
        '* * * * *
        '* This method adds formatted text to the TextBox.
        '* * * * *

        Dim currText As String = txtWeapons.Text
        txtWeapons.Clear()

        txtWeapons.Text = newText & nl & nl & currText
        txtWeapons.Select(0, 0)
        txtWeapons.ScrollToCaret()
    End Sub

    Private Sub clear()
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

        lstWeapons.ClearSelected()
        lstWeapons.Items.Clear()
        btnPurchase.Enabled = False
        btnClear.Enabled = False

        cmbLight.Checked = True
        displayWeapons()
    End Sub

    Public Sub displayWeapons()
        '* * * * *
        '* This method populates the ListBox with weapon names.
        '* * * * *

        lstWeapons.Items.Clear()                        'clear Listbox so no duplicates

        If cmbLight.Checked = True Then
            sql = "SELECT WeaponName,WeaponDamage FROM Weapons WHERE WeaponType='Light' AND Hidden=False ORDER BY WeaponDamage Asc"
            type = "Light"
        ElseIf cmbHeavy.Checked = True Then
            sql = "SELECT WeaponName,WeaponDamage FROM Weapons WHERE WeaponType='Heavy' AND Hidden=False ORDER BY WeaponDamage Asc"
            type = "Heavy"
        ElseIf cmbTwoH.Checked = True Then
            sql = "SELECT WeaponName,WeaponDamage FROM Weapons WHERE WeaponType='Two-H' AND Hidden=False ORDER BY WeaponDamage Asc"
            type = "Two-H"
        End If

        table = "Weapons"

        ds = funcs.fillDS(sql, table)

        For i As Integer = 0 To ds.Tables("Weapons").Rows.Count - 1
            lstWeapons.Items.Add(ds.Tables("Weapons").Rows(i).Item("WeaponName"))
        Next

        If lstWeapons.Items.Contains("Hands") Then
            lstWeapons.Items.Remove("Hands")
        End If

        display()
    End Sub

    Private Sub display()
        '* * * * *
        '* This method displays all the user's information.
        '* * * * *

        lblGold.Text = currUser.goldOnHand.ToString

        If blnLoaded = True Then 'display current weapon information
            Select Case type
                Case "Light"
                    lblCurrent.Text = currUser.lightWeapon.name.ToString
                    lblValue.Text = (currUser.lightWeapon.value \ 2).ToString
                    lblCurrentDamage.Text = currUser.lightWeapon.damage.ToString
                Case "Heavy"
                    lblCurrent.Text = currUser.heavyWeapon.name.ToString
                    lblValue.Text = (currUser.heavyWeapon.value \ 2).ToString
                    lblCurrentDamage.Text = currUser.heavyWeapon.damage.ToString
                Case "Two-H"
                    lblCurrent.Text = currUser.twoHWeapon.name.ToString
                    lblValue.Text = (currUser.twoHWeapon.value \ 2).ToString
                    lblCurrentDamage.Text = currUser.twoHWeapon.damage.ToString
            End Select
        End If

        If lstWeapons.SelectedIndex >= 0 Then   'display selected weapon information
            Dim weaponName As String = lstWeapons.SelectedItem.ToString 'save selected weapon name

            buyWeapon = funcs.getWeapon(weaponName, type)
            lblSelected.Text = buyWeapon.name
            lblPrice.Text = buyWeapon.value.ToString
            lblSelectedDamage.Text = buyWeapon.damage.ToString

            btnClear.Enabled = True

            If buyWeapon.value <= currUser.goldOnHand Then
                btnPurchase.Enabled = True
            Else
                btnPurchase.Enabled = False
            End If

            Select Case type
                Case "Light"
                    If buyWeapon.Equals(currUser.lightWeapon) Then
                        btnPurchase.Enabled = False
                    End If
                Case "Heavy"
                    If buyWeapon.Equals(currUser.heavyWeapon) Then
                        btnPurchase.Enabled = False
                    End If
                Case "Two-H"
                    If buyWeapon.Equals(currUser.twoHWeapon) Then
                        btnPurchase.Enabled = False
                    End If
            End Select
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

        Dim type As String = ""
        Dim dlgQuestion As String = ""
        Dim dlg As DialogResult
        Dim hands As New Weapon
        dlgQuestion = "Are you sure you want to purchase this " & buyWeapon.name & "?"

        If cmbLight.Checked = True Then
            type = "Light"
            If Not currUser.lightWeapon.Equals(hands) Then
                dlgQuestion += nl & "You will sell your " & currUser.lightWeapon.name & " for " & (currUser.lightWeapon.value \ 2) & " gold."
            End If
        ElseIf cmbHeavy.Checked = True Then
            type = "Heavy"
            If Not currUser.heavyWeapon.Equals(hands) Then
                dlgQuestion += nl & "You will sell your " & currUser.heavyWeapon.name & " for " & (currUser.heavyWeapon.value \ 2) & " gold."
            End If
        ElseIf cmbTwoH.Checked = True Then
            type = "Two-H"
            If Not currUser.twoHWeapon.Equals(hands) Then
                dlgQuestion += nl & "You will sell your " & currUser.twoHWeapon.name & " for " & (currUser.twoHWeapon.value \ 2) & " gold."
            End If
        End If


        dlg = MessageBox.Show(dlgQuestion, "Assassin", MessageBoxButtons.YesNo)

        If dlg = DialogResult.Yes Then
            If type = "Light" Then
                If Not currUser.lightWeapon.Equals(hands) Then
                    addText("You sell your " & currUser.lightWeapon.name & " for " & (currUser.lightWeapon.value \ 2) & " gold.")
                End If
                currUser.goldOnHand += currUser.lightWeapon.sell
                currUser.goldOnHand -= currUser.lightWeapon.purchase(buyWeapon)
                addText("You purchase the " & buyWeapon.name & " for " & (buyWeapon.value) & " gold.")
            ElseIf type = "Heavy" Then
                If Not currUser.heavyWeapon.Equals(hands) Then
                    addText("You sell your " & currUser.heavyWeapon.name & " for " & (currUser.heavyWeapon.value \ 2) & " gold.")
                End If
                currUser.goldOnHand += currUser.heavyWeapon.sell
                currUser.goldOnHand -= currUser.heavyWeapon.purchase(buyWeapon)
                addText("You purchase the " & buyWeapon.name & " for " & (buyWeapon.value) & " gold.")
            ElseIf type = "Two-H" Then
                If Not currUser.twoHWeapon.Equals(hands) Then
                    addText("You sell your " & currUser.twoHWeapon.name & " for " & (currUser.twoHWeapon.value \ 2) & " gold.")
                End If
                addText("You sell your " & currUser.lightWeapon.name & " for " & (currUser.lightWeapon.value \ 2) & " gold.")
                currUser.goldOnHand += currUser.twoHWeapon.sell
                currUser.goldOnHand -= currUser.twoHWeapon.purchase(buyWeapon)
                addText("You purchase the " & buyWeapon.name & " for " & (buyWeapon.value) & " gold.")

            End If
        End If

        clear()             'set to defaults
        displayWeapons()    'display weapons
        display()           'display gold and weapon name
        funcs.save(currUser)
    End Sub

    Private Sub sell()
        '* * * * *
        '* This method sells a weapon.
        '* * * * *

        Dim sellWeapon As New Weapon

        Dim type As String = ""
        Dim dlg As DialogResult
        Dim dlgQuestion As String = ""

        Select Case type
            Case "Light"
                sellWeapon = currUser.lightWeapon
            Case "Heavy"
                sellWeapon = currUser.heavyWeapon
            Case "Two-H"
                sellWeapon = currUser.twoHWeapon
        End Select

        dlgQuestion = "Are you sure you want to sell this " & sellWeapon.name & " for " & (sellWeapon.value \ 2) & " gold?"

        dlg = MessageBox.Show(dlgQuestion, "Assassin", MessageBoxButtons.YesNo)

        If dlg = DialogResult.Yes Then
            addText("You sell your " & sellWeapon.name & " for " & (sellWeapon.value \ 2) & " gold.")

            If type = "Light" Then
                currUser.goldOnHand += currUser.lightWeapon.sell
            ElseIf type = "Heavy" Then
                currUser.goldOnHand += currUser.heavyWeapon.sell
            ElseIf type = "Two-H" Then
                currUser.goldOnHand += currUser.twoHWeapon.sell

            End If
        End If

        clear()             'set to defaults
        displayWeapons()    'display weapons
        display()           'display gold and weapon name
        funcs.save(currUser)              'save
    End Sub

    Private Sub cmb_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cmbLight.CheckedChanged, cmbHeavy.CheckedChanged, cmbTwoH.CheckedChanged
        '* * * * *
        '* This method detects when one of the Radio buttons has changed.
        '* * * * *

        lblPrice.Text = ""
        displayWeapons()
    End Sub

    Private Sub lstWeapons_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstWeapons.SelectedIndexChanged
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
        displayWeapons()
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

        addText("You exit the weapon shop.")
        frmShops.Show()
        frmShops.currUser = currUser
        frmShops.addText(txtWeapons.Text)
    End Sub
End Class