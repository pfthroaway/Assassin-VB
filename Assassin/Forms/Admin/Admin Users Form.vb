Option Strict On
Option Explicit On

Imports Assassin.Classes
Imports Assassin.Classes.Entities
Imports Assassin.Classes.Enums
Imports Assassin.Classes.Items
Imports Extensions
Imports Extensions.DataTypeHelpers
Imports Extensions.Encryption

Namespace Forms.Admin

    Public Class FrmAdminUsers
        Dim _selectedUser As New User()
        Dim _blnNewUser As Boolean = False

        ''' <summary>Assigns all the Controls' data to the _selectedUser <see cref="User"/>.</summary>
        Private Sub AssignSelectedUser(Optional hashPassword As Boolean = False)
            _selectedUser.Name = TxtName.Text.Trim()
            If hashPassword Then
                _selectedUser.Password = PBKDF2.HashPassword(PswdPassword.Text.Trim())
            End If

            'character
            Integer.TryParse(TxtLevel.Text.Trim(), _selectedUser.Level)
            Integer.TryParse(TxtExperience.Text.Trim(), _selectedUser.Experience)
            Integer.TryParse(TxtSkillPoints.Text.Trim(), _selectedUser.SkillPoints)
            _selectedUser.Alive = chkAlive.Checked
            Integer.TryParse(TxtCurrentEndurance.Text.Trim(), _selectedUser.CurrentEndurance)
            _selectedUser.CurrentLocation = EnumHelper.Parse(Of SleepLocation)(CmbLocation.SelectedItem.ToString)
            Integer.TryParse(TxtMaximumEndurance.Text.Trim(), _selectedUser.MaximumEndurance)
            Integer.TryParse(TxtHunger.Text.Trim(), _selectedUser.Hunger)
            Integer.TryParse(TxtThirst.Text.Trim(), _selectedUser.Thirst)

            'inventory
            _selectedUser.CurrentWeaponType = EnumHelper.Parse(Of WeaponType)(CmbCurrentWeapon.SelectedItem.ToString)
            _selectedUser.LightWeapon = CType(CmbLightWeapon.SelectedItem, Weapon)
            _selectedUser.HeavyWeapon = CType(CmbHeavyWeapon.SelectedItem, Weapon)
            _selectedUser.TwoHandedWeapon = CType(CmbTwoHWeapon.SelectedItem, Weapon)
            _selectedUser.Armor = CType(CmbArmor.SelectedItem, Armor)
            _selectedUser.Potion = CType(CmbPotion.SelectedItem, Potion)
            Integer.TryParse(TxtLockpicks.Text.Trim(), _selectedUser.Lockpicks)
            Integer.TryParse(TxtGoldOnHand.Text.Trim(), _selectedUser.GoldOnHand)
            Integer.TryParse(TxtGoldinBank.Text.Trim(), _selectedUser.GoldInBank)
            Integer.TryParse(TxtGoldOnLoan.Text.Trim(), _selectedUser.GoldOnLoan)
            _selectedUser.Shovel = chkShovel.Checked
            _selectedUser.Lantern = chkLantern.Checked
            _selectedUser.Amulet = chkAmulet.Checked

            'skills
            Integer.TryParse(TxtLightWeaponSkill.Text.Trim(), _selectedUser.LightWeaponSkill)
            Integer.TryParse(TxtHeavyWeaponSkill.Text.Trim(), _selectedUser.HeavyWeaponSkill)
            Integer.TryParse(TxtTwoHWeaponSkill.Text.Trim(), _selectedUser.TwoHandedWeaponSkill)
            Integer.TryParse(TxtBlockingSkill.Text.Trim(), _selectedUser.Blocking)
            Integer.TryParse(TxtSlippingSkill.Text.Trim(), _selectedUser.Slipping)
            Integer.TryParse(TxtStealthSkill.Text.Trim(), _selectedUser.Stealth)

            'henchmen
            Integer.TryParse(TxtHenchmenLevel1.Text.Trim(), _selectedUser.HenchmenLevel1)
            Integer.TryParse(TxtHenchmenLevel2.Text.Trim(), _selectedUser.HenchmenLevel2)
            Integer.TryParse(TxtHenchmenLevel3.Text.Trim(), _selectedUser.HenchmenLevel3)
            Integer.TryParse(TxtHenchmenLevel4.Text.Trim(), _selectedUser.HenchmenLevel4)
            Integer.TryParse(TxtHenchmenLevel5.Text.Trim(), _selectedUser.HenchmenLevel5)
        End Sub

        ''' <summary>Deletes a <see cref="User"/> from Jail if the location was changed.</summary>
        Private Async Sub CheckJail()
            If CurrentUser.CurrentLocation = SleepLocation.Jail Then
                Dim jailedUser As JailedUser = AllJailedUsers.Find(Function(jailed) jailed.Name = CurrentUser.Name)
                If Await DatabaseInteraction.FreeFromJail(jailedUser) Then
                    AllJailedUsers.Remove(jailedUser)
                End If
            End If
        End Sub

        ''' <summary>Clears all the fields on the form.</summary>
        Private Sub Clear()
            _blnNewUser = False
            LstUsers.ClearSelected()
            LblPass.Text = "Password:"

            'character
            TxtName.Clear()
            TxtLevel.Clear()
            TxtExperience.Clear()
            TxtSkillPoints.Clear()
            chkAlive.Checked = False
            CmbLocation.SelectedItem = "Streets"
            TxtCurrentEndurance.Clear()
            TxtMaximumEndurance.Clear()
            TxtHunger.Clear()
            TxtThirst.Clear()

            'inventory
            CmbCurrentWeapon.SelectedIndex = 0
            CmbLightWeapon.SelectedIndex = 0
            CmbHeavyWeapon.SelectedIndex = 0
            CmbTwoHWeapon.SelectedIndex = 0
            CmbArmor.SelectedIndex = 0
            CmbPotion.SelectedIndex = 0
            TxtLockpicks.Clear()
            TxtGoldOnHand.Clear()
            TxtGoldinBank.Clear()
            TxtGoldOnLoan.Clear()
            chkShovel.Checked = False
            chkLantern.Checked = False
            chkAmulet.Checked = False

            'stats
            TxtLightWeaponSkill.Clear()
            TxtHeavyWeaponSkill.Clear()
            TxtTwoHWeaponSkill.Clear()
            TxtBlockingSkill.Clear()
            TxtSlippingSkill.Clear()
            TxtStealthSkill.Clear()

            'henchmen
            TxtHenchmenLevel1.Clear()
            TxtHenchmenLevel2.Clear()
            TxtHenchmenLevel3.Clear()
            TxtHenchmenLevel4.Clear()
            TxtHenchmenLevel5.Clear()

            'password change fields
            PswdPassword.Clear()
            PswdConfirm.Clear()

            ToggleControls(False)
        End Sub

        ''' <summary>Displays the names of all <see cref="User"/>s.</summary>
        Private Sub DisplayNames()
            LstUsers.Items.Clear()
            For Each user As User In AllUsers
                LstUsers.Items.Add(user.Name)
            Next
        End Sub

        ''' <summary>Displays information about the current <see cref="User"/>.</summary>
        Private Sub DisplayUser()
            'character
            TxtName.Text = CurrentUser.Name.ToString
            TxtLevel.Text = CurrentUser.Level.ToString
            TxtExperience.Text = CurrentUser.Experience.ToString
            TxtSkillPoints.Text = CurrentUser.SkillPoints.ToString
            chkAlive.Checked = CurrentUser.Alive
            CmbLocation.SelectedItem = CurrentUser.CurrentLocation.ToString
            TxtCurrentEndurance.Text = CurrentUser.CurrentEndurance.ToString
            TxtMaximumEndurance.Text = CurrentUser.MaximumEndurance.ToString
            TxtHunger.Text = CurrentUser.Hunger.ToString
            TxtThirst.Text = CurrentUser.Thirst.ToString

            'inventory
            CmbCurrentWeapon.SelectedItem = CurrentUser.CurrentWeaponType.ToString
            CmbLightWeapon.SelectedItem = CurrentUser.LightWeapon
            CmbHeavyWeapon.SelectedItem = CurrentUser.HeavyWeapon
            CmbTwoHWeapon.SelectedItem = CurrentUser.TwoHandedWeapon
            CmbArmor.SelectedItem = CurrentUser.Armor
            CmbPotion.SelectedItem = CurrentUser.Potion
            TxtLockpicks.Text = CurrentUser.Lockpicks.ToString
            TxtGoldOnHand.Text = CurrentUser.GoldOnHand.ToString
            TxtGoldinBank.Text = CurrentUser.GoldInBank.ToString
            TxtGoldOnLoan.Text = CurrentUser.GoldOnLoan.ToString
            chkShovel.Checked = CurrentUser.Shovel
            chkLantern.Checked = CurrentUser.Lantern
            chkAmulet.Checked = CurrentUser.Amulet

            'skills
            TxtLightWeaponSkill.Text = CurrentUser.LightWeaponSkill.ToString
            TxtHeavyWeaponSkill.Text = CurrentUser.HeavyWeaponSkill.ToString
            TxtTwoHWeaponSkill.Text = CurrentUser.TwoHandedWeaponSkill.ToString
            TxtBlockingSkill.Text = CurrentUser.Blocking.ToString
            TxtSlippingSkill.Text = CurrentUser.Slipping.ToString
            TxtStealthSkill.Text = CurrentUser.Stealth.ToString

            'henchmen
            TxtHenchmenLevel1.Text = CurrentUser.HenchmenLevel1.ToString
            TxtHenchmenLevel2.Text = CurrentUser.HenchmenLevel2.ToString
            TxtHenchmenLevel3.Text = CurrentUser.HenchmenLevel3.ToString
            TxtHenchmenLevel4.Text = CurrentUser.HenchmenLevel4.ToString
            TxtHenchmenLevel5.Text = CurrentUser.HenchmenLevel5.ToString

        End Sub

        ''' <summary>Toggles all the Controls on the form.</summary>
        Private Sub ToggleControls(enabled As Boolean)
            'character
            TxtName.Enabled = enabled
            TxtLevel.Enabled = enabled
            TxtExperience.Enabled = enabled
            TxtSkillPoints.Enabled = enabled
            chkAlive.Enabled = enabled
            CmbLocation.Enabled = enabled
            CmbLocation.Enabled = enabled
            TxtCurrentEndurance.Enabled = enabled
            TxtMaximumEndurance.Enabled = enabled
            TxtHunger.Enabled = enabled
            TxtThirst.Enabled = enabled

            'inventory
            CmbCurrentWeapon.Enabled = enabled
            CmbLightWeapon.Enabled = enabled
            CmbLightWeapon.Enabled = enabled
            CmbHeavyWeapon.Enabled = enabled
            CmbHeavyWeapon.Enabled = enabled
            CmbTwoHWeapon.Enabled = enabled
            CmbTwoHWeapon.Enabled = enabled
            CmbArmor.Enabled = enabled
            CmbArmor.Enabled = enabled
            CmbPotion.Enabled = enabled
            CmbPotion.Enabled = enabled
            TxtLockpicks.Enabled = enabled
            TxtGoldOnHand.Enabled = enabled
            TxtGoldinBank.Enabled = enabled
            TxtGoldOnLoan.Enabled = enabled
            chkShovel.Enabled = enabled
            chkLantern.Enabled = enabled
            chkAmulet.Enabled = enabled

            'stats
            TxtLightWeaponSkill.Enabled = enabled
            TxtHeavyWeaponSkill.Enabled = enabled
            TxtTwoHWeaponSkill.Enabled = enabled
            TxtBlockingSkill.Enabled = enabled
            TxtSlippingSkill.Enabled = enabled
            TxtStealthSkill.Enabled = enabled

            'henchmen
            TxtHenchmenLevel1.Enabled = enabled
            TxtHenchmenLevel2.Enabled = enabled
            TxtHenchmenLevel3.Enabled = enabled
            TxtHenchmenLevel4.Enabled = enabled
            TxtHenchmenLevel5.Enabled = enabled

            'password change fields
            PswdPassword.Enabled = enabled
            PswdConfirm.Enabled = enabled

            'buttons
            BtnClear.Enabled = enabled
            BtnSave.Enabled = enabled
        End Sub

        ''' <summary>Loads the Admin Users Form.</summary>
        Private Sub LoadAdmin()
            DisplayNames()
            LoadArmor()
            LoadPotions()
            LoadWeapons()
            Clear()
        End Sub

        ''' <summary>Loads all Armor into the CmbArmor TextBox.</summary>
        Private Sub LoadArmor()
            For Each armor In AllArmor
                CmbArmor.Items.Add(armor)
            Next
        End Sub

        ''' <summary>Loads all Potions into the CmbPotions TextBox.</summary>
        Private Sub LoadPotions()
            For Each potion In AllPotions
                CmbPotion.Items.Add(potion)
            Next
        End Sub

        ''' <summary>Loads all Weapons into the CmbWeapons TextBox.</summary>
        Private Sub LoadWeapons()
            For Each weapon In AllWeapons
                Select Case weapon.Type
                    Case WeaponType.Light
                        CmbLightWeapon.Items.Add(weapon)
                    Case WeaponType.Heavy
                        CmbHeavyWeapon.Items.Add(weapon)
                    Case WeaponType.TwoHanded
                        CmbTwoHWeapon.Items.Add(weapon)
                End Select
            Next
        End Sub

        ''' <summary>Modifies an existing <see cref="User"/> and saves it to the database.</summary>
        Private Async Sub ModifyExistingUser()
            'if changing password
            Dim blnChangePass As Boolean
            If PswdPassword.Text.Trim().Length > 0 AndAlso PswdConfirm.Text.Trim().Length > 0 AndAlso PswdPassword.Text.Trim() = PswdConfirm.Text.Trim() Then
                blnChangePass = True
            ElseIf PswdPassword.Text.Trim() <> PswdConfirm.Text.Trim() Then
                MessageBox.Show("Your passwords don't match.", "Assassin", MessageBoxButtons.OK)
                PswdPassword.Clear()
                PswdConfirm.Clear()
                PswdPassword.Focus()
                Exit Sub
            End If

            'if changing user name
            Dim blnChangeName As Boolean
            If TxtName.Text.Trim() <> CurrentUser.Name Then
                If Not AllUsers.Exists(Function(user) user.Name = TxtName.Text.Trim()) Then
                    blnChangeName = True
                Else
                    MessageBox.Show("The new username you have chosen is already in use.", "Assassin", MessageBoxButtons.OK)
                    TxtName.Clear()
                    TxtName.Focus()
                    Exit Sub
                End If
            End If

            AssignSelectedUser(blnChangePass)

            If blnChangeName AndAlso Await DatabaseInteraction.SaveUser(_selectedUser, TxtName.Text) Then
                For Each guild As Guild In AllGuilds
                    If guild.HasMember(CurrentUser) Then
                        Await MemberLeavesGuild(CurrentUser, guild)
                        Await MemberJoinsGuild(_selectedUser, guild)
                    End If
                    If Await DatabaseInteraction.HasAppliedToGuild(CurrentUser, guild) Then
                        Await DatabaseInteraction.DenyGuildApplication(CurrentUser, guild)
                        Await DatabaseInteraction.ApplyToGuild(_selectedUser, guild)
                    End If

                    If guild.Master = CurrentUser.Name Then
                        guild.Master = _selectedUser.Name
                    End If
                Next
            ElseIf Not blnChangeName Then
                Await SaveUser(_selectedUser)
            End If

            AllUsers.Replace(CurrentUser, _selectedUser)

            If CurrentUser.CurrentLocation = SleepLocation.Jail AndAlso _selectedUser.CurrentLocation <> SleepLocation.Jail Then
                CheckJail()
            End If

            Clear()
            DisplayNames()
        End Sub

        ''' <summary>Sets up a new <see cref="User"/>.</summary>
        Private Sub SetUpNewUser()
            Clear()
            ToggleControls(True)
            _blnNewUser = True
            LblPass.Text = "Password:"

            CurrentUser = New User()
            _selectedUser = New User()
            DisplayUser()
            TxtName.Focus()
        End Sub

        ''' <summary>Checks to make sure all the fields have text and then saves the <see cref="User"/>.</summary>
        Private Sub Save()
            If LstUsers.SelectedIndex >= 0 OrElse _blnNewUser = True Then
                If TxtBlockingSkill.TextLength > 0 AndAlso TxtCurrentEndurance.TextLength > 0 AndAlso TxtExperience.TextLength > 0 AndAlso TxtGoldinBank.TextLength > 0 AndAlso TxtGoldOnHand.TextLength > 0 AndAlso TxtGoldOnLoan.TextLength > 0 AndAlso TxtHeavyWeaponSkill.TextLength > 0 AndAlso TxtHenchmenLevel1.TextLength > 0 AndAlso TxtHenchmenLevel2.TextLength > 0 AndAlso TxtHenchmenLevel3.TextLength > 0 AndAlso TxtHenchmenLevel4.TextLength > 0 AndAlso TxtHenchmenLevel5.TextLength > 0 AndAlso TxtLevel.TextLength > 0 AndAlso TxtLightWeaponSkill.TextLength > 0 AndAlso TxtLockpicks.TextLength > 0 AndAlso TxtMaximumEndurance.TextLength > 0 AndAlso TxtName.TextLength > 0 AndAlso TxtSkillPoints.TextLength > 0 AndAlso TxtSlippingSkill.TextLength > 0 AndAlso TxtStealthSkill.TextLength > 0 AndAlso TxtTwoHWeaponSkill.TextLength > 0 AndAlso CmbArmor.SelectedIndex > -1 AndAlso CmbLocation.SelectedIndex > -1 AndAlso CmbPotion.SelectedIndex > -1 AndAlso CmbCurrentWeapon.SelectedIndex > -1 AndAlso CmbLightWeapon.SelectedIndex > -1 AndAlso CmbHeavyWeapon.SelectedIndex > -1 AndAlso CmbTwoHWeapon.SelectedIndex > -1 Then
                    If _blnNewUser Then
                        SaveNewUser()
                    Else
                        ModifyExistingUser()
                    End If
                Else
                    MessageBox.Show("Please ensure all fields are properly filled.", "Assassin", MessageBoxButtons.OK)
                    Exit Sub
                End If 'end save
            ElseIf LstUsers.SelectedIndex < 0 Then
                MessageBox.Show("Please select a user to edit or create a new user before saving.", "Assassin", MessageBoxButtons.OK)
                Exit Sub
            End If
        End Sub

        ''' <summary>Saves a new <see cref="User"/> to the database.</summary>
        Private Async Sub SaveNewUser()
            If PswdPassword.Text.Trim().Length > 0 AndAlso PswdConfirm.Text.Trim().Length > 0 Then
                If PswdPassword.Text.Trim() = PswdConfirm.Text.Trim() Then
                    If Not AllUsers.Exists(Function(user) user.Name = TxtName.Text.Trim()) Then
                        AssignSelectedUser(True)
                        If Await NewUser(_selectedUser) Then
                            MessageBox.Show("New user successfully created.", "Assassin", MessageBoxButtons.OK)
                            Clear()
                            DisplayNames()
                        End If
                    Else 'if username already exists
                        MessageBox.Show("The username you have chosen is already in use.", "Assassin", MessageBoxButtons.OK)
                        TxtName.Clear()
                        TxtName.Focus()
                    End If
                Else
                    MessageBox.Show("Your passwords don't match.", "Assassin", MessageBoxButtons.OK)
                    PswdPassword.Clear()
                    PswdConfirm.Clear()
                    PswdPassword.Focus()
                    Exit Sub
                End If
            Else
                MessageBox.Show("Please enter a password and confirm it.", "Assassin", MessageBoxButtons.OK)
                Exit Sub
            End If
        End Sub

#Region "Click"

        Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
            Clear()
        End Sub

        Private Async Sub BtnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnDelete.Click
            If LstUsers.SelectedIndex >= 0 Then
                If MessageBox.Show($"Are you sure you want to delete {CurrentUser.Name}?", "Assassin", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    If Await DatabaseInteraction.DeleteUser(CurrentUser) Then
                        For Each guild In AllGuilds   'remove member from all guilds
                            guild.Members.Remove(CurrentUser.Name)
                            Await MemberLeavesGuild(CurrentUser, guild)
                            Await DatabaseInteraction.DenyGuildApplication(CurrentUser, guild)
                            If guild.Master = CurrentUser.Name Then
                                guild.Master = guild.DefaultMaster
                            End If
                        Next
                        Dim messages As List(Of Message) = Await DatabaseInteraction.LoadMessages(CurrentUser)
                        For Each message In messages
                            Await DatabaseInteraction.DeleteMessage(message)
                        Next
                        AllUsers.Remove(CurrentUser)
                        MessageBox.Show("User successfully deleted.", "Assassin", MessageBoxButtons.OK)

                        Clear()
                        DisplayNames()
                    End If
                End If
            Else
                MessageBox.Show("Please select a user to delete.", "Assassin", MessageBoxButtons.OK)
            End If
        End Sub

        Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
            Close()
        End Sub

        Private Sub BtnNewUser_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnNewUser.Click
            SetUpNewUser()
        End Sub

        Private Sub BtnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnSave.Click
            Save()
        End Sub

        Private Sub LstUsers_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles LstUsers.SelectedIndexChanged
            If LstUsers.SelectedIndex >= 0 Then
                CurrentUser = AllUsers.Find(Function(user) user.Name = LstUsers.SelectedItem.ToString())
                _selectedUser = New User(CurrentUser)
                LblPass.Text = "Change Pass:"
                DisplayUser()
                ToggleControls(True)
                BtnDelete.Enabled = True
            Else
                BtnDelete.Enabled = False
            End If
        End Sub

#End Region

#Region "Control Manipulation"

        ''' <summary>Handles integer values in TextBoxes</summary>
        ''' <param name="sender">TextBox</param>
        ''' <param name="maxValue">Maximum value allowed in the TextBox</param>
        Private Sub HandleIntTextBox(ByRef sender As Object, maxValue As Integer)
            Dim txt As TextBox = CType(sender, TextBox)
            If txt.TextLength > 0 Then
                If CInt(txt.Text) > maxValue Then
                    txt.Text = ""
                End If
            End If
        End Sub

        Private Sub NumChars(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TxtTwoHWeaponSkill.KeyPress, TxtThirst.KeyPress, TxtStealthSkill.KeyPress, TxtSlippingSkill.KeyPress, TxtSkillPoints.KeyPress, TxtMaximumEndurance.KeyPress, TxtLockpicks.KeyPress, TxtLightWeaponSkill.KeyPress, TxtLevel.KeyPress, TxtHunger.KeyPress, TxtHenchmenLevel5.KeyPress, TxtHenchmenLevel4.KeyPress, TxtHenchmenLevel3.KeyPress, TxtHenchmenLevel2.KeyPress, TxtHenchmenLevel1.KeyPress, TxtHeavyWeaponSkill.KeyPress, TxtGoldOnLoan.KeyPress, TxtGoldOnHand.KeyPress, TxtGoldinBank.KeyPress, TxtExperience.KeyPress, TxtCurrentEndurance.KeyPress, TxtBlockingSkill.KeyPress
            e.Handled = Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar Like Chr(8))
        End Sub

        Private Sub TxtExp_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TxtExperience.TextChanged
            HandleIntTextBox(sender, 100)
        End Sub

        Private Sub TxtHungerThirst_TextChanged(sender As Object, e As EventArgs) Handles TxtHunger.TextChanged, TxtThirst.TextChanged
            HandleIntTextBox(sender, 24)
        End Sub

        Private Sub TxtLevel_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TxtLevel.TextChanged
            HandleIntTextBox(sender, 11)
        End Sub

        Private Sub TxtSkill_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TxtLightWeaponSkill.TextChanged, TxtHeavyWeaponSkill.TextChanged, TxtTwoHWeaponSkill.TextChanged, TxtBlockingSkill.TextChanged, TxtSlippingSkill.TextChanged, TxtStealthSkill.TextChanged
            HandleIntTextBox(sender, 90)
        End Sub

#End Region

#Region "Form Manipulation"

        Private Sub FrmAdmin_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            LoadAdmin()
        End Sub

        Private Sub FrmAdmin_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
            FrmAdmin.Show()
        End Sub

        Private Sub LstUsers_Leave(sender As Object, e As EventArgs) Handles LstUsers.Leave
            LstUsers.Update()
        End Sub

#End Region

    End Class

End Namespace