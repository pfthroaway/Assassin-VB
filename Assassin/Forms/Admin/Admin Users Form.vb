' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 09/06/2012
' Filename        : Admin Users Form.vb
' Description     : This form contains all User administrative functions.

Option Strict On
Option Explicit On

Namespace Forms.Admin

    Public Class FrmAdminUsers
        'TODO Fix Admin Users
        '        Dim _selectedUser As New User
        '        Dim _blnNewUser As Boolean = False   'new user?
        '        Dim _allUsers As New List(Of User)

        '        Private Sub CheckJail()
        '            '* * * * *
        '            '* This method deletes a user from Jail if the location was changed.
        '            '* * * * *

        '            'TODO Fix Jail Admin Users
        '            '_sql = "SELECT * FROM Jail WHERE Username='" & LstUsers.SelectedItem.ToString & "'"
        '            '_table = "Jail"
        '            '

        '            'If _ds.Tables(0).Rows.Count > 0 Then
        '            '    .DeleteRecord("SELECT * FROM Jail WHERE Username='" & LstUsers.SelectedItem.ToString & "'", "Jail", _ds)
        '            'End If
        '        End Sub

        '        Private Sub Clear()
        '            '* * * * *
        '            '* This method clears all the fields on the form.
        '            '* * * * *

        '            _blnNewUser = False
        '            LstUsers.ClearSelected()
        '            LblPass.Text = "Password:"

        '            'character
        '            TxtName.Clear()
        '            TxtLevel.Clear()
        '            TxtExp.Clear()
        '            TxtSkillPts.Clear()
        '            chkAlive.Checked = False
        '            CmbLoc.SelectedItem = "Streets"
        '            TxtCurrentEndurance.Clear()
        '            TxtMaximumEndurance.Clear()
        '            TxtHunger.Clear()
        '            TxtThirst.Clear()

        '            'inventory
        '            CmbCurrWeapon.SelectedIndex = 0
        '            CmbLightWeapon.SelectedIndex = 0
        '            CmbHeavyWeapon.SelectedIndex = 0
        '            CmbTwoHWeapon.SelectedIndex = 0
        '            CmbArmor.SelectedIndex = 0
        '            CmbPotion.SelectedIndex = 0
        '            TxtLockpicks.Clear()
        '            TxtGoldHand.Clear()
        '            TxtGoldBank.Clear()
        '            TxtGoldLoan.Clear()
        '            chkShovel.Checked = False
        '            chkLantern.Checked = False
        '            chkAmulet.Checked = False

        '            'stats
        '            TxtLight.Clear()
        '            TxtHeavy.Clear()
        '            TxtTwoH.Clear()
        '            TxtBlocking.Clear()
        '            TxtSlipping.Clear()
        '            TxtStealth.Clear()

        '            'henchmen
        '            TxtHenchmenLevel1.Clear()
        '            TxtHenchmenLevel2.Clear()
        '            TxtHenchmenLevel3.Clear()
        '            TxtHenchmenLevel4.Clear()
        '            TxtHenchmenLevel5.Clear()

        '            'password change fields
        '            TxtChangePass.Clear()
        '            TxtConfPass.Clear()

        '            Disable()
        '            BtnDelete.Enabled = False
        '        End Sub

        '        Private Sub Disable()
        '            '* * * * *
        '            '* This method disables all the Textboxes and Listboxes on the form.
        '            '* * * * *

        '            'character
        '            TxtName.Enabled = False
        '            TxtLevel.Enabled = False
        '            TxtExp.Enabled = False
        '            TxtSkillPts.Enabled = False
        '            chkAlive.Enabled = False
        '            CmbLoc.Enabled = False
        '            CmbLoc.Enabled = False
        '            TxtCurrentEndurance.Enabled = False
        '            TxtMaximumEndurance.Enabled = False
        '            TxtHunger.Enabled = False
        '            TxtThirst.Enabled = False

        '            'inventory
        '            CmbCurrWeapon.Enabled = False
        '            CmbCurrWeapon.Enabled = False
        '            CmbLightWeapon.Enabled = False
        '            CmbLightWeapon.Enabled = False
        '            CmbHeavyWeapon.Enabled = False
        '            CmbHeavyWeapon.Enabled = False
        '            CmbTwoHWeapon.Enabled = False
        '            CmbTwoHWeapon.Enabled = False
        '            CmbArmor.Enabled = False
        '            CmbArmor.Enabled = False
        '            CmbPotion.Enabled = False
        '            CmbPotion.Enabled = False
        '            TxtLockpicks.Enabled = False
        '            TxtGoldHand.Enabled = False
        '            TxtGoldBank.Enabled = False
        '            TxtGoldLoan.Enabled = False
        '            chkShovel.Enabled = False
        '            chkLantern.Enabled = False
        '            chkAmulet.Enabled = False

        '            'stats
        '            TxtLight.Enabled = False
        '            TxtHeavy.Enabled = False
        '            TxtTwoH.Enabled = False
        '            TxtBlocking.Enabled = False
        '            TxtSlipping.Enabled = False
        '            TxtStealth.Enabled = False

        '            'henchmen
        '            TxtHenchmenLevel1.Enabled = False
        '            TxtHenchmenLevel2.Enabled = False
        '            TxtHenchmenLevel3.Enabled = False
        '            TxtHenchmenLevel4.Enabled = False
        '            TxtHenchmenLevel5.Enabled = False

        '            'password change fields
        '            TxtChangePass.Enabled = False
        '            TxtConfPass.Enabled = False

        '            'buttons
        '            BtnClear.Enabled = False
        '            BtnSave.Enabled = False
        '        End Sub

        '        Private Async Sub DisplayNames()
        '            '* * * * *
        '            '* This method displays all the users' names in the LstUsers Listbox
        '            '* * * * *
        '            _allUsers = Await LoadUsers()
        '            For Each user As User In _allUsers
        '                LstUsers.Items.Add(user.Name)
        '            Next

        '        End Sub

        '        Private Sub Enable()
        '            '* * * * *
        '            '* This method enables all the Textboxes and Listboxes on the form.
        '            '* * * * *

        '            'character
        '            TxtName.Enabled = True
        '            TxtLevel.Enabled = True
        '            TxtExp.Enabled = True
        '            TxtSkillPts.Enabled = True
        '            chkAlive.Enabled = True
        '            CmbLoc.Enabled = True
        '            CmbLoc.Enabled = True
        '            TxtCurrentEndurance.Enabled = True
        '            TxtMaximumEndurance.Enabled = True
        '            TxtHunger.Enabled = True
        '            TxtThirst.Enabled = True

        '            'inventory
        '            CmbCurrWeapon.Enabled = True
        '            CmbCurrWeapon.Enabled = True
        '            CmbLightWeapon.Enabled = True
        '            CmbLightWeapon.Enabled = True
        '            CmbHeavyWeapon.Enabled = True
        '            CmbHeavyWeapon.Enabled = True
        '            CmbTwoHWeapon.Enabled = True
        '            CmbTwoHWeapon.Enabled = True
        '            CmbArmor.Enabled = True
        '            CmbArmor.Enabled = True
        '            CmbPotion.Enabled = True
        '            CmbPotion.Enabled = True
        '            TxtLockpicks.Enabled = True
        '            TxtGoldHand.Enabled = True
        '            TxtGoldBank.Enabled = True
        '            TxtGoldLoan.Enabled = True
        '            chkShovel.Enabled = True
        '            chkLantern.Enabled = True
        '            chkAmulet.Enabled = True

        '            'stats
        '            TxtLight.Enabled = True
        '            TxtHeavy.Enabled = True
        '            TxtTwoH.Enabled = True
        '            TxtBlocking.Enabled = True
        '            TxtSlipping.Enabled = True
        '            TxtStealth.Enabled = True

        '            'henchmen
        '            TxtHenchmenLevel1.Enabled = True
        '            TxtHenchmenLevel2.Enabled = True
        '            TxtHenchmenLevel3.Enabled = True
        '            TxtHenchmenLevel4.Enabled = True
        '            TxtHenchmenLevel5.Enabled = True

        '            'password change fields
        '            TxtChangePass.Enabled = True
        '            TxtConfPass.Enabled = True

        '            'buttons
        '            BtnClear.Enabled = True
        '            BtnSave.Enabled = True
        '        End Sub

        '        Private Sub KeyChars(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TxtName.KeyPress, TxtConfPass.KeyPress, TxtChangePass.KeyPress
        '            '* * * * *
        '            '* This method limits the keys able to be entered in the name and password Textboxes.
        '            '* * * * *

        '            If Char.IsLetterOrDigit(e.KeyChar) OrElse e.KeyChar Like Chr(8) OrElse e.KeyChar Like " " Then 'letters, numbers, backspace, space
        '                e.Handled = False
        '            Else
        '                e.Handled = True
        '            End If
        '        End Sub

        '        Private Sub LoadAdmin()
        '            '* * * * *
        '            '* This method loads all information needed from the database.
        '            '* * * * *

        '            DisplayNames()
        '            Clear()
        '        End Sub

        '        Private Sub NewUser()
        '            '* * * * *
        '            '* This method creates a new user.
        '            '* * * * *

        '            Clear()
        '            Enable()
        '            _blnNewUser = True
        '            LblPass.Text = "Password:"

        '            'character
        '            TxtName.Clear()
        '            TxtLevel.Text = "1"
        '            TxtExp.Text = "0"
        '            TxtSkillPts.Text = "0"
        '            chkAlive.Checked = True
        '            CmbLoc.SelectedItem = "Streets"
        '            TxtCurrentEndurance.Text = "100"
        '            TxtMaximumEndurance.Text = "100"
        '            TxtHunger.Text = "0"
        '            TxtThirst.Text = "0"

        '            'inventory
        '            CmbCurrWeapon.SelectedIndex = 0
        '            CmbLightWeapon.SelectedIndex = 0
        '            CmbHeavyWeapon.SelectedIndex = 0
        '            CmbTwoHWeapon.SelectedIndex = 0
        '            CmbArmor.SelectedIndex = 0
        '            CmbPotion.SelectedIndex = 0
        '            TxtLockpicks.Text = "0"
        '            TxtGoldHand.Text = "100"
        '            TxtGoldBank.Text = "0"
        '            TxtGoldLoan.Text = "0"
        '            chkShovel.Checked = False
        '            chkLantern.Checked = False
        '            chkAmulet.Checked = False

        '            'stats
        '            TxtLight.Text = "10"
        '            TxtHeavy.Text = "10"
        '            TxtTwoH.Text = "10"
        '            TxtBlocking.Text = "10"
        '            TxtSlipping.Text = "10"
        '            TxtStealth.Text = "10"

        '            'henchmen
        '            TxtHenchmenLevel1.Text = "0"
        '            TxtHenchmenLevel2.Text = "0"
        '            TxtHenchmenLevel3.Text = "0"
        '            TxtHenchmenLevel4.Text = "0"
        '            TxtHenchmenLevel5.Text = "0"

        '            'password change fields
        '            TxtChangePass.Clear()
        '            TxtConfPass.Clear()

        '            TxtName.Focus()
        '        End Sub

        '        Private Sub NumChars(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TxtTwoH.KeyPress, TxtThirst.KeyPress, TxtStealth.KeyPress, TxtSlipping.KeyPress, TxtSkillPts.KeyPress, TxtMaximumEndurance.KeyPress, TxtLockpicks.KeyPress, TxtLight.KeyPress, TxtLevel.KeyPress, TxtHunger.KeyPress, TxtHenchmenLevel5.KeyPress, TxtHenchmenLevel4.KeyPress, TxtHenchmenLevel3.KeyPress, TxtHenchmenLevel2.KeyPress, TxtHenchmenLevel1.KeyPress, TxtHeavy.KeyPress, TxtGoldLoan.KeyPress, TxtGoldHand.KeyPress, TxtGoldBank.KeyPress, TxtExp.KeyPress, TxtCurrentEndurance.KeyPress, TxtBlocking.KeyPress
        '            '* * * * *
        '            '* This method prevents anything but numbers from being entered in specified Textboxes.
        '            '* * * * *

        '            If Char.IsDigit(e.KeyChar) OrElse e.KeyChar Like (Chr(8)) Then 'numbers, backspace
        '                e.Handled = False
        '            Else
        '                e.Handled = True
        '            End If
        '        End Sub

        '        Private Async Sub Save()
        '            '* * * * *
        '            '* This method checks to make sure all the fields have text and then saves the user.
        '            '* * * * *

        '            Dim hashPw As String = ""

        '            If LstUsers.SelectedIndex > -1 OrElse _blnNewUser = True Then    'if user is selected or creating a new user
        '                If TxtBlocking.TextLength > 0 AndAlso TxtCurrentEndurance.TextLength > 0 AndAlso TxtExp.TextLength > 0 AndAlso TxtGoldBank.TextLength > 0 AndAlso
        '                   TxtGoldHand.TextLength > 0 AndAlso TxtGoldLoan.TextLength > 0 AndAlso TxtHeavy.TextLength > 0 AndAlso TxtHenchmenLevel1.TextLength > 0 AndAlso
        '                   TxtHenchmenLevel2.TextLength > 0 AndAlso TxtHenchmenLevel3.TextLength > 0 AndAlso TxtHenchmenLevel4.TextLength > 0 AndAlso TxtHenchmenLevel5.TextLength > 0 AndAlso
        '                   TxtLevel.TextLength > 0 AndAlso TxtLight.TextLength > 0 AndAlso TxtLockpicks.TextLength > 0 AndAlso TxtMaximumEndurance.TextLength > 0 AndAlso
        '                   TxtName.TextLength > 0 AndAlso TxtSkillPts.TextLength > 0 AndAlso TxtSlipping.TextLength > 0 AndAlso TxtStealth.TextLength > 0 AndAlso
        '                   TxtTwoH.TextLength > 0 AndAlso CmbArmor.SelectedIndex > -1 AndAlso CmbLoc.SelectedIndex > -1 AndAlso CmbPotion.SelectedIndex > -1 AndAlso
        '                   CmbCurrWeapon.SelectedIndex > -1 AndAlso CmbLightWeapon.SelectedIndex > -1 AndAlso CmbHeavyWeapon.SelectedIndex > -1 AndAlso
        '                   CmbTwoHWeapon.SelectedIndex > -1 Then

        '                    If _blnNewUser = False Then                                                  'if changing a current user
        '                        If TxtChangePass.TextLength > 0 OrElse TxtConfPass.TextLength > 0 Then  'if changing password
        '                            If TxtChangePass.Text = TxtConfPass.Text Then                       'if passwords are the same
        '                                hashPw = PBKDF2.HashPassword(txtChangePass.Text)
        '                                CurrentUser.Password = ""
        '                                CurrentUser.Password = hashPw
        '                            Else                                                                'if passwords don't match
        '                                MessageBox.Show("Your passwords don't match.", "Assassin", MessageBoxButtons.OK)
        '                                TxtChangePass.Clear()
        '                                TxtConfPass.Clear()
        '                                TxtChangePass.Focus()
        '                                Exit Sub
        '                            End If
        '                        End If

        '                        If _selectedUser.Name <> TxtName.Text Then                                        'if changing user name
        '                            Dim checkUser As User = _allUsers.Find(Function(user) user.Name = TxtName.Text)
        '                            If checkUser <> New User Then                           'if user doesn't exist
        '                                CurrentUser.Name = TxtName.Text
        '                                Await GameState.SaveUser(CurrentUser, TxtName.Text)                                  'save to DB
        '                                Exit Sub
        '                            Else                                                                'if username already taken
        '                                MessageBox.Show("The new username you have chosen is already in use.", "Assassin", MessageBoxButtons.OK)
        '                                TxtName.Clear()
        '                                TxtName.Focus()
        '                                Exit Sub
        '                            End If
        '                        End If

        '                        SaveUser()  'save the user
        '                        SaveToDb()  'commit changes to database
        '                    ElseIf _blnNewUser = True Then   'new user
        '                        SaveNewUser()
        '                    End If
        '                Else
        '                    MessageBox.Show("Please ensure all fields are properly filled.", "Assassin", MessageBoxButtons.OK)
        '                    Exit Sub
        '                End If 'end save
        '            ElseIf LstUsers.SelectedIndex < 0 Then
        '                MessageBox.Show("Please select a user to edit or create a new user before saving.", "Assassin", MessageBoxButtons.OK)
        '                Exit Sub
        '            End If

        '            If _blnNewUser = True Then
        '                MessageBox.Show("New user successfully created.", "Assassin", MessageBoxButtons.OK)
        '            Else
        '                MessageBox.Show("Save successful.", "Assassin", MessageBoxButtons.OK)
        '            End If

        '            Clear()
        '            DisplayNames()
        '        End Sub

        '        Private Sub SaveToDb()
        '            '* * * * *
        '            '* This method saves the user to the database.
        '            '* * * * *

        '            SaveUser()
        '            'TODO Try to understand this mess
        '            'If CurrentUser.CurrentLocation = SleepLocation.Jail Then
        '            '    _sql = "SELECT * FROM Jail WHERE Username='" & LstUsers.SelectedItem.ToString & "'"
        '            '    _table = "Jail"

        '            '    If _ds.Tables(0).Rows.Count = 0 Then
        '            '        Dim dsNewRow As DataRow
        '            '        dsNewRow = _ds.Tables(0).NewRow()           'create new row

        '            '        dsNewRow.Item("Username") = _userName
        '            '        dsNewRow.Item("Reason") = "Administrator"
        '            '        dsNewRow.Item("Fine") = 50
        '            '        dsNewRow.Item("DateJailed") = Today

        '            '        _ds.Tables(0).Rows.Add(dsNewRow)            'add new row to Dataset
        '            '        .UpdateRecord(_sql, _table, _ds)
        '            '    Else    'if not in jail
        '            '        CheckJail()
        '            '    End If
        '            'End If
        '        End Sub

        '        Private Sub SaveUser()
        '            '* * * * *
        '            '* This method saves all the TextBox data to the CurrentUser User
        '            '* * * * *

        '            'character
        '            Integer.TryParse(txtLevel.Text, CurrentUser.Level)
        '            Integer.TryParse(txtExp.Text, CurrentUser.Experience)
        '            Integer.TryParse(txtSkillPts.Text, CurrentUser.SkillPoints)
        '            CurrentUser.Alive = chkAlive.Checked
        '            Integer.TryParse(txtCurrentEndurance.Text, CurrentUser.CurrentEndurance)
        '            CurrentUser.CurrentLocation = CmbLoc.SelectedItem.ToString
        '            Integer.TryParse(txtMaximumEndurance.Text, CurrentUser.MaximumEndurance)
        '            Integer.TryParse(txtHunger.Text, CurrentUser.Hunger)
        '            Integer.TryParse(txtThirst.Text, CurrentUser.Thirst)

        '            'inventory
        '            CurrentUser.CurrentWeaponType = CmbCurrWeapon.SelectedItem.ToString
        '            CurrentUser.LightWeapon.Name = CmbLightWeapon.SelectedItem.ToString
        '            CurrentUser.HeavyWeapon.Name = CmbHeavyWeapon.SelectedItem.ToString
        '            CurrentUser.TwoHandedWeapon.Name = CmbTwoHWeapon.SelectedItem.ToString
        '            CurrentUser.Armor.Name = CmbArmor.SelectedItem.ToString
        '            CurrentUser.Potion = CmbPotion.SelectedItem.ToString
        '            Integer.TryParse(txtLockpicks.Text, CurrentUser.Lockpicks)
        '            Integer.TryParse(txtGoldHand.Text, CurrentUser.GoldOnHand)
        '            Integer.TryParse(txtGoldBank.Text, CurrentUser.GoldInBank)
        '            Integer.TryParse(txtGoldLoan.Text, CurrentUser.GoldOnLoan)
        '            CurrentUser.Shovel = chkShovel.Checked
        '            CurrentUser.Lantern = chkLantern.Checked
        '            CurrentUser.Amulet = chkAmulet.Checked

        '            'skills
        '            Integer.TryParse(txtLight.Text, CurrentUser.LightWeaponSkill)
        '            Integer.TryParse(txtHeavy.Text, CurrentUser.HeavyWeaponSkill)
        '            Integer.TryParse(txtTwoH.Text, CurrentUser.TwoHandedWeaponSkill)
        '            Integer.TryParse(txtBlocking.Text, CurrentUser.Blocking)
        '            Integer.TryParse(txtSlipping.Text, CurrentUser.Slipping)
        '            Integer.TryParse(txtStealth.Text, CurrentUser.Stealth)

        '            'henchmen
        '            Integer.TryParse(txtHenchmenLevel1.Text, CurrentUser.HenchmenLevel1)
        '            Integer.TryParse(txtHenchmenLevel2.Text, CurrentUser.HenchmenLevel2)
        '            Integer.TryParse(txtHenchmenLevel3.Text, CurrentUser.HenchmenLevel3)
        '            Integer.TryParse(txtHenchmenLevel4.Text, CurrentUser.HenchmenLevel4)
        '            Integer.TryParse(txtHenchmenLevel5.Text, CurrentUser.HenchmenLevel5)
        '        End Sub

        '        Private Async Sub SaveNewUser()
        '            '* * * * *
        '            '* This method saves new users to the database
        '            '* * * * *

        '            If TxtChangePass.TextLength > 0 AndAlso TxtConfPass.TextLength > 0 Then     'if password fields both have text
        '                If TxtChangePass.Text = TxtConfPass.Text Then                           'if passwords match
        '                    _ds.Clear()
        '                    _sql = "SELECT * FROM Users WHERE Username='" & _userName & "'"
        '                    _table = "Users"

        '                    If _ds.Tables(0).Rows.Count > 0 Then                           'if username already exists
        '                        MessageBox.Show("The username you have chosen is already in use.", "Assassin", MessageBoxButtons.OK)
        '                        TxtName.Clear()
        '                        TxtName.Focus()
        '                        Exit Sub
        '                    Else
        '                        CurrentUser.Name = TxtName.Text                            'save username
        '                        CurrentUser.Password = PBKDF2.HashPassword(txtChangePass.Text)   'save password

        '                        SaveUser()      'save user to DataSet
        '                        Await MemberJoinsGuild(CurrentUser, AllGuilds(0))
        '                    End If
        '                Else
        '                    MessageBox.Show("Your passwords don't match.", "Assassin", MessageBoxButtons.OK)
        '                    TxtChangePass.Clear()
        '                    TxtConfPass.Clear()
        '                    TxtChangePass.Focus()
        '                    Exit Sub
        '                End If      'end password okay
        '            Else
        '                MessageBox.Show("Please enter a password and confirm it.", "Assassin", MessageBoxButtons.OK)
        '                Exit Sub
        '            End If      'end password check

        '            .NewUser(CurrentUser)
        '        End Sub

        '        Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        '            '* * * * *
        '            '*  This method calls the clear() method on clicking the Clear button.
        '            '* * * * *

        '            Clear()
        '        End Sub

        '        Private Async Sub BtnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnDelete.Click
        '            '* * * * *
        '            '* This method deletes a user.
        '            '* * * * *

        '            Dim dlg As DialogResult

        '            If LstUsers.SelectedIndex > -1 Then
        '                _userName = LstUsers.SelectedItem.ToString
        '                dlg = MessageBox.Show("Are you sure you want to delete " + _userName + "?", "Assassin", MessageBoxButtons.YesNo)

        '                If dlg = DialogResult.Yes Then
        '                    _sql = "SELECT * FROM Users WHERE UserName='" & _userName & "'"
        '                    _table = "Users"

        '                    .DeleteRecord(_sql, _table, _ds)

        '                    For i As Integer = 1 To 5   'remove member from all guilds
        '                        _sql = "SELECT * FROM Guild" & i & "Members WHERE Username='" & _userName & "'"
        '                        _table = "Members"

        '                        If _ds.Tables(0).Rows.Count > 0 Then
        '                            .DeleteRecord(_sql, _table, _ds)
        '                        End If
        '                    Next

        '                    _sql = "SELECT * FROM Guilds WHERE GuildMaster='" & _userName & "'"
        '                    _table = "Guilds"

        '                    If _ds.Tables(0).Rows.Count > 0 Then  'if user is a guildmaster of any guild
        '                        For i As Integer = 0 To _ds.Tables(0).Rows.Count - 1
        '                            _ds.Tables(0).Rows(i).Item("Guildmaster") = "Computer"
        '                        Next

        '                        .UpdateRecord(_sql, _table, _ds)
        '                    End If
        '                    MessageBox.Show("User successfully deleted.", "Assassin", MessageBoxButtons.OK)

        '                    Clear()
        '                    DisplayNames()
        '                End If
        '            Else
        '                MessageBox.Show("Please select a user to delete.", "Assassin", MessageBoxButtons.OK)
        '            End If
        '        End Sub

        Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
            Me.Close()
        End Sub

        '        Private Sub BtnNewUser_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnNewUser.Click
        '            '    '* * * * *
        '            '    '* This method creates a new user on clicking the New User button.
        '            '    '* * * * *

        '            NewUser()
        '        End Sub

        '        Private Sub BtnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnSave.Click
        '            '* * * * *
        '            '* This method calls the save method on clicking the Save button.
        '            '* * * * *

        '            Save()
        '        End Sub

        '        Private Async Sub LstUsers_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles LstUsers.SelectedIndexChanged
        '            '* * * * *
        '            '* This method displays all of a users' information in the appropriate field when their name is clicked.
        '            '* * * * *

        '            If LstUsers.SelectedIndex > -1 Then
        '                _sql = "SELECT * FROM Users WHERE UserName='" & LstUsers.SelectedItem.ToString & "'"
        '                _table = "User"

        '                LblPass.Text = "Change Pass:"
        '                LoadUser()  'load user

        '                'character
        '                TxtName.Text = CurrentUser.Name.ToString
        '                TxtLevel.Text = CurrentUser.Level.ToString
        '                TxtExp.Text = CurrentUser.Experience.ToString
        '                TxtSkillPts.Text = CurrentUser.SkillPoints.ToString
        '                chkAlive.Checked = CurrentUser.Alive
        '                CmbLoc.SelectedItem = CurrentUser.CurrentLocation.ToString
        '                TxtCurrentEndurance.Text = CurrentUser.CurrentEndurance.ToString
        '                TxtMaximumEndurance.Text = CurrentUser.MaximumEndurance.ToString
        '                TxtHunger.Text = CurrentUser.Hunger.ToString
        '                TxtThirst.Text = CurrentUser.Thirst.ToString

        '                'inventory
        '                CmbCurrWeapon.SelectedItem = CurrentUser.CurrentWeaponType.ToString
        '                CmbLightWeapon.SelectedItem = CurrentUser.LightWeapon.Name.ToString
        '                CmbHeavyWeapon.SelectedItem = CurrentUser.HeavyWeapon.Name.ToString
        '                CmbTwoHWeapon.SelectedItem = CurrentUser.TwoHandedWeapon.Name.ToString
        '                CmbArmor.SelectedItem = CurrentUser.Armor.Name.ToString
        '                CmbPotion.SelectedItem = CurrentUser.Potion.ToString
        '                TxtLockpicks.Text = CurrentUser.Lockpicks.ToString
        '                TxtGoldHand.Text = CurrentUser.GoldOnHand.ToString
        '                TxtGoldBank.Text = CurrentUser.GoldInBank.ToString
        '                TxtGoldLoan.Text = CurrentUser.GoldOnLoan.ToString
        '                chkShovel.Checked = CurrentUser.Shovel
        '                chkLantern.Checked = CurrentUser.Lantern
        '                chkAmulet.Checked = CurrentUser.Amulet

        '                'skills
        '                TxtLight.Text = CurrentUser.LightWeaponSkill.ToString
        '                TxtHeavy.Text = CurrentUser.HeavyWeaponSkill.ToString
        '                TxtTwoH.Text = CurrentUser.TwoHandedWeaponSkill.ToString
        '                TxtBlocking.Text = CurrentUser.Blocking.ToString
        '                TxtSlipping.Text = CurrentUser.Slipping.ToString
        '                TxtStealth.Text = CurrentUser.Stealth.ToString

        '                'henchmen
        '                TxtHenchmenLevel1.Text = CurrentUser.HenchmenLevel1.ToString
        '                TxtHenchmenLevel2.Text = CurrentUser.HenchmenLevel2.ToString
        '                TxtHenchmenLevel3.Text = CurrentUser.HenchmenLevel3.ToString
        '                TxtHenchmenLevel4.Text = CurrentUser.HenchmenLevel4.ToString
        '                TxtHenchmenLevel5.Text = CurrentUser.HenchmenLevel5.ToString

        '                Enable()                    'enable Buttons and TextBoxes
        '                BtnDelete.Enabled = True    'enable Delete button
        '            End If
        '        End Sub

        '        Private Sub TxtBlocking_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TxtBlocking.TextChanged
        '            '* * * * *
        '            '* This method limits the range of the TxtBlocking field.
        '            '* * * * *

        '            If TxtBlocking.TextLength > 0 Then
        '                If CInt(txtBlocking.Text) > 90 Then
        '                    TxtBlocking.Text = ""
        '                End If
        '            End If
        '        End Sub

        '        Private Sub TxtExp_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TxtExp.TextChanged
        '            '* * * * *
        '            '* This method limits the range of the TxtExp field.
        '            '* * * * *

        '            If TxtExp.TextLength > 0 Then
        '                If CInt(txtExp.Text) > 100 Then
        '                    TxtExp.Text = ""
        '                End If
        '            End If
        '        End Sub

        '        Private Sub TxtHeavy_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TxtHeavy.TextChanged
        '            '* * * * *
        '            '* This method limits the range of the TxtHeavy field.
        '            '* * * * *

        '            If TxtHeavy.TextLength > 0 Then
        '                If CInt(txtHeavy.Text) > 90 Then
        '                    TxtHeavy.Text = ""
        '                End If
        '            End If
        '        End Sub

        '        Private Sub TxtHunger_TextChanged(sender As Object, e As EventArgs) Handles TxtHunger.TextChanged
        '            '* * * * *
        '            '* This method limits the range of the TxtTwo field.
        '            '* * * * *

        '            If TxtHunger.TextLength > 0 Then
        '                If CInt(txtHunger.Text) > 24 Then
        '                    TxtHunger.Text = ""
        '                End If
        '            End If
        '        End Sub

        '        Private Sub TxtLevel_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TxtLevel.TextChanged
        '            '* * * * *
        '            '* This method limits the range of the TxtLevel field.
        '            '* * * * *

        '            If TxtLevel.TextLength > 0 Then
        '                If CInt(txtLevel.Text) > 11 Then
        '                    TxtLevel.Text = ""
        '                End If
        '            End If
        '        End Sub

        '        Private Sub TxtLight_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TxtLight.TextChanged
        '            '* * * * *
        '            '* This method limits the range of the TxtLight field.
        '            '* * * * *

        '            If TxtLight.TextLength > 0 Then
        '                If CInt(txtLight.Text) > 90 Then
        '                    TxtLight.Text = ""
        '                End If
        '            End If
        '        End Sub

        '        Private Sub TxtSlipping_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TxtSlipping.TextChanged
        '            '* * * * *
        '            '* This method limits the range of the TxtSlipping field.
        '            '* * * * *

        '            If TxtSlipping.TextLength > 0 Then
        '                If CInt(txtSlipping.Text) > 90 Then
        '                    TxtSlipping.Text = ""
        '                End If
        '            End If
        '        End Sub

        '        Private Sub TxtStealth_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TxtStealth.TextChanged
        '            '* * * * *
        '            '* This method limits the range of the TxtStealth field.
        '            '* * * * *

        '            If TxtStealth.TextLength > 0 Then
        '                If CInt(txtStealth.Text) > 90 Then
        '                    TxtStealth.Text = ""
        '                End If
        '            End If
        '        End Sub

        '        Private Sub TxtThirst_TextChanged(sender As Object, e As EventArgs) Handles TxtThirst.TextChanged
        '            '* * * * *
        '            '* This method limits the range of the TxtTwo field.
        '            '* * * * *

        '            If TxtThirst.TextLength > 0 Then
        '                If CInt(txtThirst.Text) > 24 Then
        '                    TxtThirst.Text = ""
        '                End If
        '            End If
        '        End Sub

        '        Private Sub TxtTwoH_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TxtTwoH.TextChanged
        '            '* * * * *
        '            '* This method limits the range of the TxtTwo field.
        '            '* * * * *

        '            If TxtTwoH.TextLength > 0 Then
        '                If CInt(txtTwoH.Text) > 90 Then
        '                    TxtTwoH.Text = ""
        '                End If
        '            End If
        '        End Sub

        '        Private Sub FrmAdmin_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        '            '* * * * *
        '            '* This method displays the users' names on form loading.
        '            '* * * * *

        '            LoadAdmin()
        '        End Sub

        Private Sub FrmAdmin_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
            FrmAdmin.Show()
        End Sub

    End Class

End Namespace