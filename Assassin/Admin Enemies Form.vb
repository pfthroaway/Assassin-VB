' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 09/06/2012
' Filename        : Admin Enemies Form.vb
' Description     : This form contains all Enemy administrative functions.

Option Strict On
Option Explicit On

Public Class frmAdminEnemies
    Dim funcs As New Functions  'new Functions instance
    Dim ds As New DataSet       'DataSet
    Dim sql As String           'SQL query
    Dim table As String         'table name
    Dim currEnemy As New Enemy  'current Enemy
    Dim index As Integer        'selected index
    Dim weaponType As String    'weapon type

    Private Sub clear()
        '* * * * *
        '* This method clears all information on the form.
        '* * * * *

        disable()

        lstEnemies.ClearSelected()
        txtName.Clear()
        txtEndurance.Clear()
        cmbWeaponType.SelectedIndex = 0
        cmbWeapon.Items.Clear()
        cmbWeapon.Items.Add("Hands")
        cmbWeapon.SelectedIndex = 0
        cmbWeaponType.SelectedIndex = 0
        cmbArmor.SelectedIndex = 0
        txtWeaponSkill.Clear()
        txtSlipping.Clear()
        txtBlocking.Clear()
    End Sub

    Private Sub disable()
        '* * * * *
        '* This method disables most of the fields on the form.
        '* * * * *

        btnClear.Enabled = False
        btnSave.Enabled = False

        txtName.Enabled = False
        txtEndurance.Enabled = False
        cmbWeaponType.Enabled = False
        cmbWeapon.Enabled = False
        cmbArmor.Enabled = False
        txtWeaponSkill.Enabled = False
        txtBlocking.Enabled = False
        txtSlipping.Enabled = False
    End Sub

    Private Sub display()
        '* * * * *
        '* This method displays information about an enemy.
        '* * * * *

        enable()
        getEnemy()

        txtName.Text = currEnemy.name
        txtEndurance.Text = currEnemy.maxEnd.ToString
        cmbWeaponType.SelectedItem = weaponType
        If weaponType = "Light" Then
            loadLightWeapons()
        ElseIf weaponType = "Heavy" Then
            loadHeavyWeapons()
        ElseIf weaponType = "Two-H" Then
            loadTwoHWeapons()
        End If
        cmbWeapon.SelectedItem = currEnemy.weapon.name
        cmbArmor.SelectedItem = currEnemy.armor.name
        txtWeaponSkill.Text = currEnemy.attackSkill.ToString
        txtBlocking.Text = currEnemy.blocking.ToString
        txtSlipping.Text = currEnemy.slipping.ToString
    End Sub

    Private Sub enable()

        '* * * * *
        '* This method enables most of the fields on the form.
        '* * * * *

        btnClear.Enabled = True
        btnSave.Enabled = True

        txtName.Enabled = True
        txtEndurance.Enabled = True
        cmbWeaponType.Enabled = True
        cmbWeapon.Enabled = True
        cmbArmor.Enabled = True
        txtWeaponSkill.Enabled = True
        txtBlocking.Enabled = True
        txtSlipping.Enabled = True
    End Sub

    Private Sub getEnemy()
        '* * * * *
        '* This method gets the selected enemy.
        '* * * * *

        index = lstEnemies.SelectedIndex + 1

        sql = "SELECT * FROM Enemies WHERE Level=" & (index)
        table = "Enemy"
        ds = funcs.fillDS(sql, table)

        Integer.TryParse(ds.Tables("Enemy").Rows(0).Item("Level").ToString, currEnemy.level)
        currEnemy.name = ds.Tables("Enemy").Rows(0).Item("EnemyName").ToString

        Integer.TryParse(ds.Tables("Enemy").Rows(0).Item("Endurance").ToString, currEnemy.maxEnd)
        currEnemy.currEnd = currEnemy.maxEnd

        currEnemy.weapon = funcs.getWeapon(ds.Tables("Enemy").Rows(0).Item("Weapon").ToString)
        weaponType = ds.Tables("Enemy").Rows(0).Item("WeaponType").ToString
        currEnemy.armor = funcs.getArmor(ds.Tables("Enemy").Rows(0).Item("Armor").ToString)
        Integer.TryParse(ds.Tables("Enemy").Rows(0).Item("Attack").ToString, currEnemy.attackSkill)
        Integer.TryParse(ds.Tables("Enemy").Rows(0).Item("Blocking").ToString, currEnemy.blocking)
        Integer.TryParse(ds.Tables("Enemy").Rows(0).Item("Slipping").ToString, currEnemy.slipping)
    End Sub

    Private Sub loadArmor()
        '* * * * *
        '* This method loads all the Armors from the database.
        '* * * * *

        cmbArmor.Items.Clear()
        sql = "SELECT ArmorName,ArmorDefense FROM Armor ORDER BY ArmorDefense"
        table = "Armor"
        ds = funcs.fillDS(sql, table)

        For i As Integer = 0 To ds.Tables("Armor").Rows.Count - 1
            cmbArmor.Items.Add(ds.Tables("Armor").Rows(i).Item("ArmorName"))
        Next
    End Sub

    Private Sub loadEnemies()
        '* * * * *
        '* This method loads all the enemies.
        '* * * * *

        lstEnemies.Items.Clear()

        sql = "SELECT EnemyName From Enemies"
        table = "Enemy"

        ds = funcs.fillDS(sql, table)

        For i As Integer = 0 To 9
            lstEnemies.Items.Add(ds.Tables("Enemy").Rows(i).Item("EnemyName").ToString)
        Next

        loadArmor()
    End Sub

    Private Sub loadHeavyWeapons()
        '* * * * *
        '* This method loads all the Heavy weapons from the database.
        '* * * * *

        cmbWeapon.Items.Clear()
        sql = "SELECT WeaponName,WeaponDamage FROM Weapons WHERE WeaponType='Heavy' ORDER BY WeaponDamage Asc"
        table = "Weapons"
        ds = funcs.fillDS(sql, table)

        For i As Integer = 0 To ds.Tables("Weapons").Rows.Count - 1
            cmbWeapon.Items.Add(ds.Tables("Weapons").Rows(i).Item("WeaponName"))
        Next
    End Sub

    Private Sub loadLightWeapons()
        '* * * * *
        '* This method loads all the Light weapons from the database.
        '* * * * *

        cmbWeapon.Items.Clear()
        sql = "SELECT WeaponName,WeaponDamage FROM Weapons WHERE WeaponType='Light' ORDER BY WeaponDamage Asc"
        table = "Weapons"
        ds = funcs.fillDS(sql, table)

        For i As Integer = 0 To ds.Tables("Weapons").Rows.Count - 1
            cmbWeapon.Items.Add(ds.Tables("Weapons").Rows(i).Item("WeaponName"))
        Next
    End Sub

    Private Sub loadTwoHWeapons()
        '* * * * *
        '* This method loads all the Two-H weapons from the database.
        '* * * * *

        cmbWeapon.Items.Clear()
        sql = "SELECT WeaponName,WeaponDamage FROM Weapons WHERE WeaponType='Two-H' ORDER BY WeaponDamage Asc"
        table = "Weapons"
        ds = funcs.fillDS(sql, table)

        For i As Integer = 0 To ds.Tables("Weapons").Rows.Count - 1
            cmbWeapon.Items.Add(ds.Tables("Weapons").Rows(i).Item("WeaponName"))
        Next
    End Sub


    Private Sub saveEnemy()
        '* * * * *
        '* This method saves an enemy to the database.
        '* * * * *

        index = lstEnemies.SelectedIndex + 1

        sql = "SELECT * FROM Enemies WHERE Level=" & (index)
        table = "Enemy"
        ds = funcs.fillDS(sql, table)

        currEnemy.name = txtName.Text
        Integer.TryParse(txtEndurance.Text, currEnemy.maxEnd)
        currEnemy.weapon.name = cmbWeapon.SelectedItem.ToString
        currEnemy.armor.name = cmbArmor.SelectedItem.ToString
        Integer.TryParse(txtWeaponSkill.Text, currEnemy.attackSkill)
        Integer.TryParse(txtBlocking.Text, currEnemy.blocking)
        Integer.TryParse(txtSlipping.Text, currEnemy.slipping)


        ds.Tables("Enemy").Rows(0).Item("Level") = currEnemy.level
        ds.Tables("Enemy").Rows(0).Item("EnemyName") = currEnemy.name

        ds.Tables("Enemy").Rows(0).Item("Endurance") = currEnemy.maxEnd

        ds.Tables("Enemy").Rows(0).Item("Weapon") = currEnemy.weapon.name
        ds.Tables("Enemy").Rows(0).Item("WeaponType") = weaponType
        ds.Tables("Enemy").Rows(0).Item("Armor") = currEnemy.armor.name
        ds.Tables("Enemy").Rows(0).Item("Attack") = currEnemy.attackSkill
        ds.Tables("Enemy").Rows(0).Item("Blocking") = currEnemy.blocking
        ds.Tables("Enemy").Rows(0).Item("Slipping") = currEnemy.slipping

        funcs.updateRecord(sql, table, ds)

        MessageBox.Show("Enemy successfully saved.", "Assassin", MessageBoxButtons.OK)
        clear()
        loadEnemies()
    End Sub



    Private Sub lstEnemies_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstEnemies.SelectedIndexChanged
        '* * * * *
        '* This method handles the selected index of lstEnemies being changed.
        '* * * * *

        If lstEnemies.SelectedIndex >= 0 Then
            display()
        End If
    End Sub


    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        '* * * * * 
        '* This method clears all data on the form.
        '* * * * *

        clear()
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        '* * * * *
        '* This method closes the form on clicking the Exit button.
        '* * * * *

        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        '* * * * *
        '* This method saves the current enemy.
        '* * * * *

        saveEnemy()
    End Sub


    Private Sub frmAdminEnemies_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        '* * * * *
        '* This method handles the form loading.
        '* * * * *

        loadEnemies()
        clear()
    End Sub


    Private Sub frmAdminEnemies_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        '* * * * *
        '* This method handles the form closing.
        '* * * * *

        frmAdmin.Show()
    End Sub

    Private Sub numKeys_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtEndurance.KeyPress, _
        txtWeaponSkill.KeyPress, txtBlocking.KeyPress, txtSlipping.KeyPress
        '* * * * *
        '* This method handles the fields which require numbers
        '* * * * *

        If Char.IsDigit(e.KeyChar) OrElse e.KeyChar Like Chr(8) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtWeaponSkill_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtWeaponSkill.TextChanged
        '* * * * *
        '* This method prevents numbers above 90 in the txtWeaponSkill field.
        '* * * * *

        If txtWeaponSkill.TextLength > 0 Then
            If CInt(txtWeaponSkill.Text) > 90 Then
                txtWeaponSkill.Clear()
            End If
        End If
    End Sub

    Private Sub txtSlipping_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtSlipping.TextChanged
        '* * * * *
        '* This method prevents numbers above 90 in the txtSlipping field.
        '* * * * *

        If txtSlipping.TextLength > 0 Then
            If CInt(txtSlipping.Text) > 90 Then
                txtSlipping.Clear()
            End If
        End If
    End Sub

    Private Sub txtBlocking_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtBlocking.TextChanged
        '* * * * *
        '* This method prevents numbers above 90 in the txtBlocking field.
        '* * * * *

        If txtBlocking.TextLength > 0 Then
            If CInt(txtBlocking.Text) > 90 Then
                txtBlocking.Clear()
            End If
        End If
    End Sub

    Private Sub txtName_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtName.KeyPress
        '* * * * *
        '* This method prevents numbers above 90 in the txtBlocking field.
        '* * * * *

        If Char.IsLetter(e.KeyChar) OrElse e.KeyChar Like Chr(8) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class