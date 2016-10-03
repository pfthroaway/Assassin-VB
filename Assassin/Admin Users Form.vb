' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 09/06/2012
' Filename        : Admin Users Form.vb
' Description     : This form contains all User administrative functions.

Option Strict On
Option Explicit On

Public Class frmAdminUsers
    Dim funcs As New Functions          'new Functions instance
    Dim sql As String                   'SQL query
    Dim table As String                 'table name
    Dim blnNewUser As Boolean = False   'new user?
    Dim ds As New DataSet               'DataSet
    Dim userName As String              'selected user username
    Dim currUser As New User            'currently selected user

    Private Sub checkJail()
        '* * * * *
        '* This method deletes a user from Jail if the location was changed.
        '* * * * *

        sql = "SELECT * FROM Jail WHERE Username='" & lstUsers.SelectedItem.ToString & "'"
        table = "Jail"
        ds = funcs.fillDS(sql, table)

        If ds.Tables("Jail").Rows.Count > 0 Then
            funcs.deleteRecord("SELECT * FROM Jail WHERE Username='" & lstUsers.SelectedItem.ToString & "'", "Jail", ds)
        End If
    End Sub

    Private Sub clear()
        '* * * * *
        '* This method clears all the fields on the form.
        '* * * * *

        blnNewUser = False
        lstUsers.ClearSelected()
        userName = ""
        lblPass.Text = "Password:"

        'character
        txtName.Clear()
        txtLevel.Clear()
        txtExp.Clear()
        txtSkillPts.Clear()
        chkAlive.Checked = False
        cmbLoc.SelectedItem = "Streets"
        txtCurrEnd.Clear()
        txtMaxEnd.Clear()
        txtHunger.Clear()
        txtThirst.Clear()

        'inventory
        cmbCurrWeapon.SelectedIndex = 0
        cmbLightWeapon.SelectedIndex = 0
        cmbHeavyWeapon.SelectedIndex = 0
        cmbTwoHWeapon.SelectedIndex = 0
        cmbArmor.SelectedIndex = 0
        cmbPotion.SelectedIndex = 0
        txtLockpicks.Clear()
        txtGoldHand.Clear()
        txtGoldBank.Clear()
        txtGoldLoan.Clear()
        chkShovel.Checked = False
        chkLantern.Checked = False
        chkAmulet.Checked = False

        'stats
        txtLight.Clear()
        txtHeavy.Clear()
        txtTwoH.Clear()
        txtBlocking.Clear()
        txtSlipping.Clear()
        txtStealth.Clear()

        'henchmen
        txtHench1.Clear()
        txtHench2.Clear()
        txtHench3.Clear()
        txtHench4.Clear()
        txtHench5.Clear()

        'password change fields
        txtChangePass.Clear()
        txtConfPass.Clear()

        disable()
        btnDelete.Enabled = False
    End Sub

    Private Sub disable()
        '* * * * *
        '* This method disables all the Textboxes and Listboxes on the form.
        '* * * * *

        'character
        txtName.Enabled = False
        txtLevel.Enabled = False
        txtExp.Enabled = False
        txtSkillPts.Enabled = False
        chkAlive.Enabled = False
        cmbLoc.Enabled = False
        cmbLoc.Enabled = False
        txtCurrEnd.Enabled = False
        txtMaxEnd.Enabled = False
        txtHunger.Enabled = False
        txtThirst.Enabled = False

        'inventory
        cmbCurrWeapon.Enabled = False
        cmbCurrWeapon.Enabled = False
        cmbLightWeapon.Enabled = False
        cmbLightWeapon.Enabled = False
        cmbHeavyWeapon.Enabled = False
        cmbHeavyWeapon.Enabled = False
        cmbTwoHWeapon.Enabled = False
        cmbTwoHWeapon.Enabled = False
        cmbArmor.Enabled = False
        cmbArmor.Enabled = False
        cmbPotion.Enabled = False
        cmbPotion.Enabled = False
        txtLockpicks.Enabled = False
        txtGoldHand.Enabled = False
        txtGoldBank.Enabled = False
        txtGoldLoan.Enabled = False
        chkShovel.Enabled = False
        chkLantern.Enabled = False
        chkAmulet.Enabled = False

        'stats
        txtLight.Enabled = False
        txtHeavy.Enabled = False
        txtTwoH.Enabled = False
        txtBlocking.Enabled = False
        txtSlipping.Enabled = False
        txtStealth.Enabled = False

        'henchmen
        txtHench1.Enabled = False
        txtHench2.Enabled = False
        txtHench3.Enabled = False
        txtHench4.Enabled = False
        txtHench5.Enabled = False

        'password change fields
        txtChangePass.Enabled = False
        txtConfPass.Enabled = False

        'buttons
        btnClear.Enabled = False
        btnSave.Enabled = False
    End Sub

    Private Sub displayNames()
        '* * * * *
        '* This method displays all the users' names in the lstUsers Listbox
        '* * * * *

        lstUsers.Items.Clear()
        ds.Clear()                                      'clear DataSet so no duplicates
        sql = "SELECT Username FROM Users"
        table = "Users"
        ds = funcs.fillDS(sql, table)

        For i As Integer = 0 To ds.Tables("Users").Rows.Count - 1
            lstUsers.Items.Add(ds.Tables("Users").Rows(i).Item("UserName"))
        Next
    End Sub

    Private Sub enable()
        '* * * * *
        '* This method enables all the Textboxes and Listboxes on the form.
        '* * * * *

        'character
        txtName.Enabled = True
        txtLevel.Enabled = True
        txtExp.Enabled = True
        txtSkillPts.Enabled = True
        chkAlive.Enabled = True
        cmbLoc.Enabled = True
        cmbLoc.Enabled = True
        txtCurrEnd.Enabled = True
        txtMaxEnd.Enabled = True
        txtHunger.Enabled = True
        txtThirst.Enabled = True

        'inventory
        cmbCurrWeapon.Enabled = True
        cmbCurrWeapon.Enabled = True
        cmbLightWeapon.Enabled = True
        cmbLightWeapon.Enabled = True
        cmbHeavyWeapon.Enabled = True
        cmbHeavyWeapon.Enabled = True
        cmbTwoHWeapon.Enabled = True
        cmbTwoHWeapon.Enabled = True
        cmbArmor.Enabled = True
        cmbArmor.Enabled = True
        cmbPotion.Enabled = True
        cmbPotion.Enabled = True
        txtLockpicks.Enabled = True
        txtGoldHand.Enabled = True
        txtGoldBank.Enabled = True
        txtGoldLoan.Enabled = True
        chkShovel.Enabled = True
        chkLantern.Enabled = True
        chkAmulet.Enabled = True

        'stats
        txtLight.Enabled = True
        txtHeavy.Enabled = True
        txtTwoH.Enabled = True
        txtBlocking.Enabled = True
        txtSlipping.Enabled = True
        txtStealth.Enabled = True

        'henchmen
        txtHench1.Enabled = True
        txtHench2.Enabled = True
        txtHench3.Enabled = True
        txtHench4.Enabled = True
        txtHench5.Enabled = True

        'password change fields
        txtChangePass.Enabled = True
        txtConfPass.Enabled = True

        'buttons
        btnClear.Enabled = True
        btnSave.Enabled = True
    End Sub

    Private Sub keyChars(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtName.KeyPress, txtConfPass.KeyPress, txtChangePass.KeyPress
        '* * * * *
        '* This method limits the keys able to be entered in the name and password Textboxes.
        '* * * * *

        If Char.IsLetterOrDigit(e.KeyChar) OrElse e.KeyChar Like Chr(8) OrElse e.KeyChar Like " " Then 'letters, numbers, backspace, space
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub loadAdmin()
        '* * * * *
        '* This method loads all information needed from the database.
        '* * * * *

        displayNames()
        loadLightWeapons()
        loadHeavyWeapons()
        loadTwoHWeapons()
        loadArmor()
        loadPotion()
        clear()
    End Sub

    Private Sub loadArmor()
        '* * * * *
        '* This method loads all the Armors from the database.
        '* * * * *

        sql = "SELECT ArmorName,ArmorDefense FROM Armor ORDER BY ArmorDefense"
        table = "Armor"
        ds = funcs.fillDS(sql, table)

        For i As Integer = 0 To ds.Tables("Armor").Rows.Count - 1
            cmbArmor.Items.Add(ds.Tables("Armor").Rows(i).Item("ArmorName"))
        Next
    End Sub

    Private Sub loadHeavyWeapons()
        '* * * * *
        '* This method loads all the Heavy weapons from the database.
        '* * * * *

        sql = "SELECT WeaponName,WeaponDamage FROM Weapons WHERE WeaponType='Heavy' ORDER BY WeaponDamage Asc"
        table = "Weapons"
        ds = funcs.fillDS(sql, table)

        For i As Integer = 0 To ds.Tables("Weapons").Rows.Count - 1
            cmbHeavyWeapon.Items.Add(ds.Tables("Weapons").Rows(i).Item("WeaponName"))
        Next
    End Sub

    Private Sub loadLightWeapons()
        '* * * * *
        '* This method loads all the Light weapons from the database.
        '* * * * *

        sql = "SELECT WeaponName,WeaponDamage FROM Weapons WHERE WeaponType='Light' ORDER BY WeaponDamage Asc"
        table = "Weapons"
        ds = funcs.fillDS(sql, table)

        For i As Integer = 0 To ds.Tables("Weapons").Rows.Count - 1
            cmbLightWeapon.Items.Add(ds.Tables("Weapons").Rows(i).Item("WeaponName"))
        Next
    End Sub

    Private Sub loadTwoHWeapons()
        '* * * * *
        '* This method loads all the Two-H weapons from the database.
        '* * * * *

        sql = "SELECT WeaponName,WeaponDamage FROM Weapons WHERE WeaponType='Two-H' ORDER BY WeaponDamage Asc"
        table = "Weapons"
        ds = funcs.fillDS(sql, table)

        For i As Integer = 0 To ds.Tables("Weapons").Rows.Count - 1
            cmbTwoHWeapon.Items.Add(ds.Tables("Weapons").Rows(i).Item("WeaponName"))
        Next
    End Sub

    Private Sub loadUser()
        '* * * * *
        '* This method loads a user from the DataSet
        '* * * * *

        'character
        currUser.name = ds.Tables("User").Rows(0).Item("Username").ToString
        userName = currUser.name
        currUser.password = ds.Tables("User").Rows(0).Item("Pswd").ToString
        Integer.TryParse(ds.Tables("User").Rows(0).Item("UserLevel").ToString, currUser.level)
        Integer.TryParse(ds.Tables("User").Rows(0).Item("Exp").ToString, currUser.exp)
        Integer.TryParse(ds.Tables("User").Rows(0).Item("SkillPts").ToString, currUser.skillPts)
        Boolean.TryParse(ds.Tables("User").Rows(0).Item("Alive").ToString, currUser.alive)
        Integer.TryParse(ds.Tables("User").Rows(0).Item("CurrEnd").ToString, currUser.currEnd)
        currUser.currLoc = ds.Tables("User").Rows(0).Item("Location").ToString
        Integer.TryParse(ds.Tables("User").Rows(0).Item("MaxEnd").ToString, currUser.maxEnd)
        Integer.TryParse(ds.Tables("User").Rows(0).Item("Hunger").ToString, currUser.hunger)
        Integer.TryParse(ds.Tables("User").Rows(0).Item("Thirst").ToString, currUser.thirst)

        'inventory
        currUser.currWeapon = ds.Tables("User").Rows(0).Item("CurrWeapon").ToString
        currUser.lightWeapon.name = ds.Tables("User").Rows(0).Item("LightWeapon").ToString
        currUser.heavyWeapon.name = ds.Tables("User").Rows(0).Item("HeavyWeapon").ToString
        currUser.twoHWeapon.name = ds.Tables("User").Rows(0).Item("TwoHWeapon").ToString
        currUser.armor.name = ds.Tables("User").Rows(0).Item("Armor").ToString
        currUser.potion = ds.Tables("User").Rows(0).Item("Potion").ToString
        Integer.TryParse(ds.Tables("User").Rows(0).Item("Lockpicks").ToString, currUser.lockpicks)
        Integer.TryParse(ds.Tables("User").Rows(0).Item("GoldOnHand").ToString, currUser.goldOnHand)
        Integer.TryParse(ds.Tables("User").Rows(0).Item("GoldInBank").ToString, currUser.goldInBank)
        Integer.TryParse(ds.Tables("User").Rows(0).Item("GoldOnLoan").ToString, currUser.goldOnLoan)
        Boolean.TryParse(ds.Tables("User").Rows(0).Item("Shovel").ToString, currUser.shovel)
        Boolean.TryParse(ds.Tables("User").Rows(0).Item("Lantern").ToString, currUser.lantern)
        Boolean.TryParse(ds.Tables("User").Rows(0).Item("Amulet").ToString, currUser.amulet)

        'skills
        Integer.TryParse(ds.Tables("User").Rows(0).Item("LightWeaponSkill").ToString, currUser.lightWeaponSkill)
        Integer.TryParse(ds.Tables("User").Rows(0).Item("HeavyWeaponSkill").ToString, currUser.heavyWeaponSkill)
        Integer.TryParse(ds.Tables("User").Rows(0).Item("TwoHWeaponSkill").ToString, currUser.twoHWeaponSkill)
        Integer.TryParse(ds.Tables("User").Rows(0).Item("Blocking").ToString, currUser.blocking)
        Integer.TryParse(ds.Tables("User").Rows(0).Item("Slipping").ToString, currUser.slipping)
        Integer.TryParse(ds.Tables("User").Rows(0).Item("Stealth").ToString, currUser.stealth)

        'henchmen
        Integer.TryParse(ds.Tables("User").Rows(0).Item("Henchmen1").ToString, currUser.hench1)
        Integer.TryParse(ds.Tables("User").Rows(0).Item("Henchmen2").ToString, currUser.hench2)
        Integer.TryParse(ds.Tables("User").Rows(0).Item("Henchmen3").ToString, currUser.hench3)
        Integer.TryParse(ds.Tables("User").Rows(0).Item("Henchmen4").ToString, currUser.hench4)
        Integer.TryParse(ds.Tables("User").Rows(0).Item("Henchmen5").ToString, currUser.hench5)
    End Sub

    Private Sub loadPotion()
        '* * * * *
        '* This method loads all the potions from the database.
        '* * * * *

        sql = "SELECT PotionName,PotionValue FROM Potions ORDER BY PotionValue Asc"
        table = "Potions"
        ds = funcs.fillDS(sql, table)

        For i As Integer = 0 To ds.Tables("Potions").Rows.Count - 1
            cmbPotion.Items.Add(ds.Tables("Potions").Rows(i).Item("PotionName"))
        Next
    End Sub

    Private Sub newUser()
        '* * * * *
        '* This method creates a new user.
        '* * * * *

        clear()
        enable()
        blnNewUser = True
        lblPass.Text = "Password:"

        'character
        txtName.Clear()
        txtLevel.Text = "1"
        txtExp.Text = "0"
        txtSkillPts.Text = "0"
        chkAlive.Checked = True
        cmbLoc.SelectedItem = "Streets"
        txtCurrEnd.Text = "100"
        txtMaxEnd.Text = "100"
        txtHunger.Text = "0"
        txtThirst.Text = "0"

        'inventory
        cmbCurrWeapon.SelectedIndex = 0
        cmbLightWeapon.SelectedIndex = 0
        cmbHeavyWeapon.SelectedIndex = 0
        cmbTwoHWeapon.SelectedIndex = 0
        cmbArmor.SelectedIndex = 0
        cmbPotion.SelectedIndex = 0
        txtLockpicks.Text = "0"
        txtGoldHand.Text = "100"
        txtGoldBank.Text = "0"
        txtGoldLoan.Text = "0"
        chkShovel.Checked = False
        chkLantern.Checked = False
        chkAmulet.Checked = False

        'stats
        txtLight.Text = "10"
        txtHeavy.Text = "10"
        txtTwoH.Text = "10"
        txtBlocking.Text = "10"
        txtSlipping.Text = "10"
        txtStealth.Text = "10"

        'henchmen
        txtHench1.Text = "0"
        txtHench2.Text = "0"
        txtHench3.Text = "0"
        txtHench4.Text = "0"
        txtHench5.Text = "0"

        'password change fields
        txtChangePass.Clear()
        txtConfPass.Clear()

        txtName.Focus()
    End Sub

    Private Sub numChars(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTwoH.KeyPress, txtThirst.KeyPress, txtStealth.KeyPress, txtSlipping.KeyPress, txtSkillPts.KeyPress, txtMaxEnd.KeyPress, txtLockpicks.KeyPress, txtLight.KeyPress, txtLevel.KeyPress, txtHunger.KeyPress, txtHench5.KeyPress, txtHench4.KeyPress, txtHench3.KeyPress, txtHench2.KeyPress, txtHench1.KeyPress, txtHeavy.KeyPress, txtGoldLoan.KeyPress, txtGoldHand.KeyPress, txtGoldBank.KeyPress, txtExp.KeyPress, txtCurrEnd.KeyPress, txtBlocking.KeyPress
        '* * * * *
        '* This method prevents anything but numbers from being entered in specified Textboxes.
        '* * * * *

        If Char.IsDigit(e.KeyChar) OrElse e.KeyChar Like (Chr(8)) Then 'numbers, backspace
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub save()
        '* * * * *
        '* This method checks to make sure all the fields have text and then saves the user.
        '* * * * *

        Dim hashPW As String = ""

        If lstUsers.SelectedIndex > -1 OrElse blnNewUser = True Then    'if user is selected or creating a new user
            If txtBlocking.TextLength > 0 AndAlso txtCurrEnd.TextLength > 0 AndAlso txtExp.TextLength > 0 AndAlso txtGoldBank.TextLength > 0 AndAlso _
            txtGoldHand.TextLength > 0 AndAlso txtGoldLoan.TextLength > 0 AndAlso txtHeavy.TextLength > 0 AndAlso txtHench1.TextLength > 0 AndAlso _
            txtHench2.TextLength > 0 AndAlso txtHench3.TextLength > 0 AndAlso txtHench4.TextLength > 0 AndAlso txtHench5.TextLength > 0 AndAlso _
            txtLevel.TextLength > 0 AndAlso txtLight.TextLength > 0 AndAlso txtLockpicks.TextLength > 0 AndAlso txtMaxEnd.TextLength > 0 AndAlso _
            txtName.TextLength > 0 AndAlso txtSkillPts.TextLength > 0 AndAlso txtSlipping.TextLength > 0 AndAlso txtStealth.TextLength > 0 AndAlso _
            txtTwoH.TextLength > 0 AndAlso cmbArmor.SelectedIndex > -1 AndAlso cmbLoc.SelectedIndex > -1 AndAlso cmbPotion.SelectedIndex > -1 AndAlso _
            cmbCurrWeapon.SelectedIndex > -1 AndAlso cmbLightWeapon.SelectedIndex > -1 AndAlso cmbHeavyWeapon.SelectedIndex > -1 AndAlso _
            cmbTwoHWeapon.SelectedIndex > -1 Then

                If blnNewUser = False Then                                                  'if changing a current user
                    If txtChangePass.TextLength > 0 OrElse txtConfPass.TextLength > 0 Then  'if changing password
                        If txtChangePass.Text = txtConfPass.Text Then                       'if passwords are the same
                            hashPW = funcs.MD5Hash(txtChangePass.Text)
                            currUser.password = ""
                            currUser.password = hashPW
                        Else                                                                'if passwords don't match
                            MessageBox.Show("Your passwords don't match.", "Assassin", MessageBoxButtons.OK)
                            txtChangePass.Clear()
                            txtConfPass.Clear()
                            txtChangePass.Focus()
                            Exit Sub
                        End If
                    End If

                    If userName <> txtName.Text Then                                        'if changing user name
                        sql = "SELECT * FROM Users WHERE UserName='" & txtName.Text & "'"
                        table = "Users"
                        ds = funcs.fillDS(sql, table)

                        If ds.Tables("Users").Rows.Count = 0 Then                           'if user doesn't exist
                            currUser.name = txtName.Text
                            saveUser()                                                      'save to currUser
                            funcs.save(currUser, userName)                                  'save to DB
                            Exit Sub
                        Else                                                                'if username already taken
                            MessageBox.Show("The new username you have chosen is already in use.", "Assassin", MessageBoxButtons.OK)
                            txtName.Clear()
                            txtName.Focus()
                            Exit Sub
                        End If
                    End If

                    saveUser()  'save the user
                    saveToDB()  'commit changes to database
                ElseIf blnNewUser = True Then   'new user
                    saveNewUser()
                End If
            Else
                MessageBox.Show("Please ensure all fields are properly filled.", "Assassin", MessageBoxButtons.OK)
                Exit Sub
            End If 'end save
        ElseIf lstUsers.SelectedIndex < 0 Then
            MessageBox.Show("Please select a user to edit or create a new user before saving.", "Assassin", MessageBoxButtons.OK)
            Exit Sub
        End If

        If blnNewUser = True Then
            MessageBox.Show("New user successfully created.", "Assassin", MessageBoxButtons.OK)
        Else
            MessageBox.Show("Save successful.", "Assassin", MessageBoxButtons.OK)
        End If

        clear()
        displayNames()
    End Sub

    Private Sub saveToDB()
        '* * * * *
        '* This method saves the user to the database.
        '* * * * *

        funcs.save(currUser)
        If currUser.currLoc = "Jail" Then
            sql = "SELECT * FROM Jail WHERE Username='" & lstUsers.SelectedItem.ToString & "'"
            table = "Jail"
            ds = funcs.fillDS(sql, table)
            If ds.Tables("Jail").Rows.Count = 0 Then
                Dim dsNewRow As DataRow
                dsNewRow = ds.Tables("Jail").NewRow()           'create new row

                dsNewRow.Item("Username") = userName
                dsNewRow.Item("Reason") = "Administrator"
                dsNewRow.Item("Fine") = 50
                dsNewRow.Item("DateJailed") = Today

                ds.Tables("Jail").Rows.Add(dsNewRow)            'add new row to Dataset
                funcs.updateRecord(sql, table, ds)
            Else    'if not in jail
                checkJail()
            End If
        End If
    End Sub

    Private Sub saveUser()
        '* * * * *
        '* This method saves all the TextBox data to the currUser User
        '* * * * *

        'character
        Integer.TryParse(txtLevel.Text, currUser.level)
        Integer.TryParse(txtExp.Text, currUser.exp)
        Integer.TryParse(txtSkillPts.Text, currUser.skillPts)
        currUser.alive = chkAlive.Checked
        Integer.TryParse(txtCurrEnd.Text, currUser.currEnd)
        currUser.currLoc = cmbLoc.SelectedItem.ToString
        Integer.TryParse(txtMaxEnd.Text, currUser.maxEnd)
        Integer.TryParse(txtHunger.Text, currUser.hunger)
        Integer.TryParse(txtThirst.Text, currUser.thirst)

        'inventory
        currUser.currWeapon = cmbCurrWeapon.SelectedItem.ToString
        currUser.lightWeapon.name = cmbLightWeapon.SelectedItem.ToString
        currUser.heavyWeapon.name = cmbHeavyWeapon.SelectedItem.ToString
        currUser.twoHWeapon.name = cmbTwoHWeapon.SelectedItem.ToString
        currUser.armor.name = cmbArmor.SelectedItem.ToString
        currUser.potion = cmbPotion.SelectedItem.ToString
        Integer.TryParse(txtLockpicks.Text, currUser.lockpicks)
        Integer.TryParse(txtGoldHand.Text, currUser.goldOnHand)
        Integer.TryParse(txtGoldBank.Text, currUser.goldInBank)
        Integer.TryParse(txtGoldLoan.Text, currUser.goldOnLoan)
        currUser.shovel = chkShovel.Checked
        currUser.lantern = chkLantern.Checked
        currUser.amulet = chkAmulet.Checked

        'skills
        Integer.TryParse(txtLight.Text, currUser.lightWeaponSkill)
        Integer.TryParse(txtHeavy.Text, currUser.heavyWeaponSkill)
        Integer.TryParse(txtTwoH.Text, currUser.twoHWeaponSkill)
        Integer.TryParse(txtBlocking.Text, currUser.blocking)
        Integer.TryParse(txtSlipping.Text, currUser.slipping)
        Integer.TryParse(txtStealth.Text, currUser.stealth)

        'henchmen
        Integer.TryParse(txtHench1.Text, currUser.hench1)
        Integer.TryParse(txtHench2.Text, currUser.hench2)
        Integer.TryParse(txtHench3.Text, currUser.hench3)
        Integer.TryParse(txtHench4.Text, currUser.hench4)
        Integer.TryParse(txtHench5.Text, currUser.hench5)
    End Sub

    Private Sub saveNewUser()
        '* * * * *
        '* This method saves new users to the database
        '* * * * *

        If txtChangePass.TextLength > 0 AndAlso txtConfPass.TextLength > 0 Then     'if password fields both have text
            If txtChangePass.Text = txtConfPass.Text Then                           'if passwords match
                ds.Clear()
                sql = "SELECT * FROM Users WHERE Username='" & userName & "'"
                table = "Users"
                ds = funcs.fillDS(sql, table)
                If ds.Tables("Users").Rows.Count > 0 Then                           'if username already exists
                    MessageBox.Show("The username you have chosen is already in use.", "Assassin", MessageBoxButtons.OK)
                    txtName.Clear()
                    txtName.Focus()
                    Exit Sub
                Else
                    currUser.name = txtName.Text                            'save username
                    currUser.password = funcs.MD5Hash(txtChangePass.Text)   'save password

                    saveUser()      'save user to DataSet
                    funcs.joinGuild(currUser.name, 1)
                End If
            Else
                MessageBox.Show("Your passwords don't match.", "Assassin", MessageBoxButtons.OK)
                txtChangePass.Clear()
                txtConfPass.Clear()
                txtChangePass.Focus()
                Exit Sub
            End If      'end password okay
        Else
            MessageBox.Show("Please enter a password and confirm it.", "Assassin", MessageBoxButtons.OK)
            Exit Sub
        End If      'end password check

        funcs.newUser(currUser)
    End Sub


    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        '* * * * *
        '*  This method calls the clear() method on clicking the Clear button.
        '* * * * *

        clear()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        '* * * * *
        '* This method deletes a user.
        '* * * * *

        Dim dlg As DialogResult

        If lstUsers.SelectedIndex > -1 Then
            userName = lstUsers.SelectedItem.ToString
            dlg = MessageBox.Show("Are you sure you want to delete " + userName + "?", "Assassin", MessageBoxButtons.YesNo)

            If dlg = DialogResult.Yes Then
                sql = "SELECT * FROM Users WHERE UserName='" & userName & "'"
                table = "Users"
                ds = funcs.fillDS(sql, table)
                funcs.deleteRecord(sql, table, ds)

                For i As Integer = 1 To 5   'remove member from all guilds
                    sql = "SELECT * FROM Guild" & i & "Members WHERE Username='" & userName & "'"
                    table = "Members"
                    ds = funcs.fillDS(sql, table)

                    If ds.Tables("Members").Rows.Count > 0 Then
                        funcs.deleteRecord(sql, table, ds)
                    End If
                Next

                sql = "SELECT * FROM Guilds WHERE GuildMaster='" & userName & "'"
                table = "Guilds"
                ds = funcs.fillDS(sql, table)

                If ds.Tables("Guilds").Rows.Count > 0 Then  'if user is a guildmaster of any guild
                    For i As Integer = 0 To ds.Tables("Guilds").Rows.Count - 1
                        ds.Tables("Guilds").Rows(i).Item("Guildmaster") = "Computer"
                    Next

                    funcs.updateRecord(sql, table, ds)
                End If
                MessageBox.Show("User successfully deleted.", "Assassin", MessageBoxButtons.OK)

                clear()
                displayNames()
            End If
        Else
            MessageBox.Show("Please select a user to delete.", "Assassin", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        '* * * * *
        '* This method closes the form on clicking the Exit button.
        '* * * * *

        Me.Close()
    End Sub

    Private Sub btnNewUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewUser.Click
        '    '* * * * *
        '    '* This method creates a new user on clicking the New User button.
        '    '* * * * *

        newUser()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        '* * * * *
        '* This method calls the save method on clicking the Save button.
        '* * * * *

        save()
    End Sub


    Private Sub lstUsers_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstUsers.SelectedIndexChanged
        '* * * * *
        '* This method displays all of a users' information in the appropriate field when their name is clicked.
        '* * * * *

        If lstUsers.SelectedIndex > -1 Then
            sql = "SELECT * FROM Users WHERE UserName='" & lstUsers.SelectedItem.ToString & "'"
            table = "User"
            ds = funcs.fillDS(sql, table)
            lblPass.Text = "Change Pass:"
            loadUser()  'load user

            'character
            txtName.Text = currUser.name.ToString
            txtLevel.Text = currUser.level.ToString
            txtExp.Text = currUser.exp.ToString
            txtSkillPts.Text = currUser.skillPts.ToString
            chkAlive.Checked = currUser.alive
            cmbLoc.SelectedItem = currUser.currLoc.ToString
            txtCurrEnd.Text = currUser.currEnd.ToString
            txtMaxEnd.Text = currUser.maxEnd.ToString
            txtHunger.Text = currUser.hunger.ToString
            txtThirst.Text = currUser.thirst.ToString

            'inventory
            cmbCurrWeapon.SelectedItem = currUser.currWeapon.ToString
            cmbLightWeapon.SelectedItem = currUser.lightWeapon.name.ToString
            cmbHeavyWeapon.SelectedItem = currUser.heavyWeapon.name.ToString
            cmbTwoHWeapon.SelectedItem = currUser.twoHWeapon.name.ToString
            cmbArmor.SelectedItem = currUser.armor.name.ToString
            cmbPotion.SelectedItem = currUser.potion.ToString
            txtLockpicks.Text = currUser.lockpicks.ToString
            txtGoldHand.Text = currUser.goldOnHand.ToString
            txtGoldBank.Text = currUser.goldInBank.ToString
            txtGoldLoan.Text = currUser.goldOnLoan.ToString
            chkShovel.Checked = currUser.shovel
            chkLantern.Checked = currUser.lantern
            chkAmulet.Checked = currUser.amulet

            'skills
            txtLight.Text = currUser.lightWeaponSkill.ToString
            txtHeavy.Text = currUser.heavyWeaponSkill.ToString
            txtTwoH.Text = currUser.twoHWeaponSkill.ToString
            txtBlocking.Text = currUser.blocking.ToString
            txtSlipping.Text = currUser.slipping.ToString
            txtStealth.Text = currUser.stealth.ToString

            'henchmen
            txtHench1.Text = currUser.hench1.ToString
            txtHench2.Text = currUser.hench2.ToString
            txtHench3.Text = currUser.hench3.ToString
            txtHench4.Text = currUser.hench4.ToString
            txtHench5.Text = currUser.hench5.ToString

            enable()                    'enable Buttons and TextBoxes
            btnDelete.Enabled = True    'enable Delete button
        End If
    End Sub


    Private Sub txtBlocking_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBlocking.TextChanged
        '* * * * *
        '* This method limits the range of the txtBlocking field.
        '* * * * *

        If txtBlocking.TextLength > 0 Then
            If CInt(txtBlocking.Text) > 90 Then
                txtBlocking.Text = ""
            End If
        End If
    End Sub

    Private Sub txtExp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtExp.TextChanged
        '* * * * *
        '* This method limits the range of the txtExp field.
        '* * * * *

        If txtExp.TextLength > 0 Then
            If CInt(txtExp.Text) > 100 Then
                txtExp.Text = ""
            End If
        End If
    End Sub

    Private Sub txtHeavy_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHeavy.TextChanged
        '* * * * *
        '* This method limits the range of the txtHeavy field.
        '* * * * *

        If txtHeavy.TextLength > 0 Then
            If CInt(txtHeavy.Text) > 90 Then
                txtHeavy.Text = ""
            End If
        End If
    End Sub

    Private Sub txtHunger_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtHunger.TextChanged
        '* * * * *
        '* This method limits the range of the txtTwo field.
        '* * * * *

        If txtHunger.TextLength > 0 Then
            If CInt(txtHunger.Text) > 24 Then
                txtHunger.Text = ""
            End If
        End If
    End Sub

    Private Sub txtLevel_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLevel.TextChanged
        '* * * * *
        '* This method limits the range of the txtLevel field.
        '* * * * *

        If txtLevel.TextLength > 0 Then
            If CInt(txtLevel.Text) > 11 Then
                txtLevel.Text = ""
            End If
        End If
    End Sub

    Private Sub txtLight_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLight.TextChanged
        '* * * * *
        '* This method limits the range of the txtLight field.
        '* * * * *

        If txtLight.TextLength > 0 Then
            If CInt(txtLight.Text) > 90 Then
                txtLight.Text = ""
            End If
        End If
    End Sub

    Private Sub txtSlipping_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSlipping.TextChanged
        '* * * * *
        '* This method limits the range of the txtSlipping field.
        '* * * * *

        If txtSlipping.TextLength > 0 Then
            If CInt(txtSlipping.Text) > 90 Then
                txtSlipping.Text = ""
            End If
        End If
    End Sub

    Private Sub txtStealth_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStealth.TextChanged
        '* * * * *
        '* This method limits the range of the txtStealth field.
        '* * * * *

        If txtStealth.TextLength > 0 Then
            If CInt(txtStealth.Text) > 90 Then
                txtStealth.Text = ""
            End If
        End If
    End Sub

    Private Sub txtThirst_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtThirst.TextChanged
        '* * * * *
        '* This method limits the range of the txtTwo field.
        '* * * * *

        If txtThirst.TextLength > 0 Then
            If CInt(txtThirst.Text) > 24 Then
                txtThirst.Text = ""
            End If
        End If
    End Sub

    Private Sub txtTwoH_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTwoH.TextChanged
        '* * * * *
        '* This method limits the range of the txtTwo field.
        '* * * * *

        If txtTwoH.TextLength > 0 Then
            If CInt(txtTwoH.Text) > 90 Then
                txtTwoH.Text = ""
            End If
        End If
    End Sub


    Private Sub frmAdmin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '* * * * *
        '* This method displays the users' names on form loading.
        '* * * * *

        loadAdmin()
    End Sub

    Private Sub frmAdmin_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        '* * * * *
        '* This method shows the main form on form closing.
        '* * * * *

        frmAdmin.Show()
    End Sub
End Class