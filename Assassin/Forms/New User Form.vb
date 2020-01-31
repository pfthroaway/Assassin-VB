' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 05/25/2012
' Filename        : New User Form.vb
' Description     : This form allows the player to make a new user.

Option Strict On
Option Explicit On

Imports Assassin.Classes
Imports Assassin.Classes.Entities
Imports Extensions.Encryption

Namespace Forms

    Public Class FrmNewUser
        Dim _skillPts As Integer = 5                 'current skill points
        Dim _maxEnd As Integer = 100                 'maximum endurance
        Dim _light As Integer = 10                   'light weapon skill
        Dim _heavy As Integer = 10                   'heavy weapon skill
        Dim _twoH As Integer = 10                    'two handed weapon skill
        Dim _blocking As Integer = 10                'blocking skill
        Dim _slipping As Integer = 10                'slipping skill
        Dim _stealth As Integer = 10                 'stealth skill

        Dim _blnStart As Boolean = False             'start game on form close

        Private Sub BtnMinus(ByRef stat As Integer)
            '* * * * *
            '* This method accepts a stat and decreases it.
            '* * * * *

            _skillPts += 1   'increase skill points
            stat -= 8       'decrease stat

            Display()       'display stats
        End Sub

        Private Sub BtnPlus(ByRef stat As Integer)
            '* * * * *
            '* This method accepts a stat and increases it.
            '* * * * *

            _skillPts -= 1   'decrease skill points
            stat += 8       'increase stat

            Display()       'display stats
        End Sub

        Private Sub CheckPlusButtons()
            '* * * * *
            '* This method checks whether a plus button should be enabled or not.
            '* * * * *

            If _maxEnd < 9980 Then
                BtnEndPlus.Enabled = True
            Else
                BtnEndPlus.Enabled = False
            End If

            If _light < 90 Then
                BtnLightPlus.Enabled = True
            Else
                BtnLightPlus.Enabled = False
            End If

            If _heavy < 90 Then
                BtnHeavyPlus.Enabled = True
            Else
                BtnHeavyPlus.Enabled = False
            End If

            If _twoH < 90 Then
                BtnTwoPlus.Enabled = True
            Else
                BtnTwoPlus.Enabled = False
            End If

            If _blocking < 90 Then
                BtnBlockPlus.Enabled = True
            Else
                BtnBlockPlus.Enabled = False
            End If

            If _slipping < 90 Then
                BtnSlippingPlus.Enabled = True
            Else
                BtnSlippingPlus.Enabled = False
            End If

            If _stealth < 90 Then
                BtnStealthPlus.Enabled = True
            Else
                BtnStealthPlus.Enabled = False
            End If
        End Sub

        Private Sub Clear()
            '* * * * *
            '* This method resets all stats.
            '* * * * *

            TxtName.Text = ""
            TxtPass.Text = ""
            TxtConfirm.Text = ""

            _maxEnd = 100
            _light = 10
            _heavy = 10
            _twoH = 10
            _blocking = 10
            _slipping = 10
            _stealth = 10
            _skillPts = 5

            DisableMinusButtons()   'hide minus buttons
            Display()               'display stats
            TxtName.Focus()         'focus on TxtName TextBox
        End Sub

        Private Sub Display()
            '* * * * *
            '* This method displays all stats.
            '* * * * *

            'display all stats
            lblEndCurr.Text = _maxEnd.ToString + "%"
            lblLightCurr.Text = _light.ToString + "%"
            lblHeavyCurr.Text = _heavy.ToString + "%"
            lblTwoCurr.Text = _twoH.ToString + "%"
            lblBlockingCurr.Text = _blocking.ToString + "%"
            lblSlippingCurr.Text = _slipping.ToString + "%"
            lblStealthCurr.Text = _stealth.ToString + "%"
            lblSkillPts.Text = _skillPts.ToString

            If _skillPts = 0 Then
                DisablePlusButtons()
                BtnCreate.Enabled = True
                BtnClear.Enabled = True
            Else    'skillpts > 0
                If _skillPts = 5 Then
                    DisableMinusButtons()
                    BtnClear.Enabled = False
                    BtnCreate.Enabled = False
                Else
                    BtnClear.Enabled = True
                End If
                CheckPlusButtons()
            End If
        End Sub

        Private Sub DisableMinusButtons()
            '* * * * *
            '* This method disables minus buttons.
            '* * * * *

            BtnEndMinus.Enabled = False
            BtnLightMinus.Enabled = False
            BtnHeavyMinus.Enabled = False
            BtnTwoMinus.Enabled = False
            BtnBlockMinus.Enabled = False
            BtnSlippingMinus.Enabled = False
            BtnStealthMinus.Enabled = False
        End Sub

        Private Sub DisablePlusButtons()
            '* * * * *
            '* This method disables plus buttons.
            '* * * * *

            BtnEndPlus.Enabled = False
            BtnLightPlus.Enabled = False
            BtnHeavyPlus.Enabled = False
            BtnTwoPlus.Enabled = False
            BtnBlockPlus.Enabled = False
            BtnSlippingPlus.Enabled = False
            BtnStealthPlus.Enabled = False
        End Sub

        Private Sub EnablePlusButtons()
            '* * * * *
            '* This method enables all plus buttons.
            '* * * * *

            BtnEndPlus.Enabled = True
            BtnLightPlus.Enabled = True
            BtnHeavyPlus.Enabled = True
            BtnTwoPlus.Enabled = True
            BtnBlockPlus.Enabled = True
            BtnSlippingPlus.Enabled = True
            BtnStealthPlus.Enabled = True
        End Sub

        Private Sub KeyChars(sender As Object, e As KeyPressEventArgs) Handles TxtName.KeyPress, TxtPass.KeyPress, TxtConfirm.KeyPress
            '* * * * *
            '* This method prevents anything but numbers and letters entered into the TextBoxes.
            '* * * * *
            If Char.IsLetterOrDigit(e.KeyChar) OrElse e.KeyChar Like " " OrElse e.KeyChar Like Chr(8) Then 'letters, numbers, backspace, space
                e.Handled = False
            Else
                e.Handled = True
            End If
        End Sub

        Private Sub TextChange(sender As Object, e As EventArgs) Handles TxtName.TextChanged, TxtPass.TextChanged, TxtConfirm.TextChanged
            '* * * * *
            '* This method handles text changes in the TextBoxes.
            '* * * * *

            If TxtName.TextLength > 0 OrElse TxtPass.TextLength > 0 OrElse TxtConfirm.TextLength > 0 Then
                BtnClear.Enabled = True
            End If

            If TxtName.TextLength > 0 AndAlso TxtPass.TextLength > 0 AndAlso TxtConfirm.TextLength > 0 AndAlso _skillPts = 0 Then
                BtnCreate.Enabled = True
            End If
        End Sub

        Private Sub BtnBlockMinus_Click(sender As Object, e As EventArgs) Handles BtnBlockMinus.Click
            '* * * * *
            '* This button changes stats based on button click.
            '* * * * *

            BtnMinus(_blocking)

            If _blocking = 10 Then BtnBlockMinus.Enabled = False

            Display()
        End Sub

        Private Sub BtnBlockPlus_Click(sender As Object, e As EventArgs) Handles BtnBlockPlus.Click
            '* * * * *
            '* This button changes stats based on button click.
            '* * * * *

            BtnPlus(_blocking)
            BtnBlockMinus.Enabled = True
            Display()
        End Sub

        Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
            '* * * * *
            '* This button clears all stats and TextBoxes.
            '* * * * *

            Clear()
        End Sub

        Private Async Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles BtnCreate.Click
            '* * * * *
            '* This method creates a new user after clicking the Create button.
            '* * * * *

            Dim username As String = TxtName.Text
            Dim newUser As New User

            If TxtPass.Text = TxtConfirm.Text Then                  'if passwords match
                If Await LoadUser(username) <> New User() OrElse username = "Computer" Then  'if user name is in use
                    MessageBox.Show("This username has already been used.", "Assassin", MessageBoxButtons.OK)
                Else
                    'character
                    newUser.Name = TxtName.Text                     'add Username
                    newUser.Password = Argon2.HashPassword(TxtPass.Text)  'add Password
                    newUser.CurrentEndurance = _maxEnd                        'add Current Endurance
                    newUser.MaximumEndurance = _maxEnd                         'add Maximum Endurance

                    'skills
                    newUser.LightWeaponSkill = _light                'add Light Weapon Skill
                    newUser.HeavyWeaponSkill = _heavy                'add Heavy Weapon Skill
                    newUser.TwoHandedWeaponSkill = _twoH                  'add Two-Handed Weapon Skill
                    newUser.Blocking = _blocking                     'add Blocking Skill
                    newUser.Slipping = _slipping                     'add Slipping Skill
                    newUser.Stealth = _stealth                       'add Stealth Skill
                    newUser.SkillPoints = _skillPts                     'set skill points
                    Await GameState.NewUser(newUser)                          'add newUser to database
                    Await MemberJoinsGuild(newUser, AllGuilds(0))

                    FrmGame.Show()
                    FrmGame.TxtGame.Text = $"Creare An Vita, {TxtName.Text}!\n\nYou enter the city of thieves to take your place among the legends!"
                    FrmGame.Display()
                    _blnStart = True
                    Me.Close()
                End If  'end user exists
            Else        'if passwords don't match
                MessageBox.Show("Passwords don't match.", "Assassin", MessageBoxButtons.OK)
            End If 'end password match
        End Sub

        Private Sub BtnEndMinus_Click(sender As Object, e As EventArgs) Handles BtnEndMinus.Click
            '* * * * *
            '* This button changes stats based on button click.
            '* * * * *

            _skillPts += 1
            BtnEndPlus.Enabled = True

            _maxEnd -= 20

            Display()
        End Sub

        Private Sub BtnEndPlus_Click(sender As Object, e As EventArgs) Handles BtnEndPlus.Click
            '* * * * *
            '* This button changes stats based on button click.
            '* * * * *

            _skillPts -= 1
            BtnEndMinus.Enabled = True

            _maxEnd += 20
            BtnEndPlus.Enabled = False

            Display()
        End Sub

        Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
            '* * * * *
            '* This button closes the program.
            '* * * * *

            Me.Close()
        End Sub

        Private Sub BtnHeavyMinus_Click(sender As Object, e As EventArgs) Handles BtnHeavyMinus.Click
            '* * * * *
            '* This button changes stats based on button click.
            '* * * * *

            BtnMinus(_heavy)

            If _heavy = 10 Then BtnHeavyMinus.Enabled = False

            Display()
        End Sub

        Private Sub BtnHeavyPlus_Click(sender As Object, e As EventArgs) Handles BtnHeavyPlus.Click
            '* * * * *
            '* This button changes stats based on button click.
            '* * * * *

            BtnPlus(_heavy)
            BtnHeavyMinus.Enabled = True
            Display()
        End Sub

        Private Sub BtnLightMinus_Click(sender As Object, e As EventArgs) Handles BtnLightMinus.Click
            '* * * * *
            '* This button changes stats based on button click.
            '* * * * *

            BtnMinus(_light)

            If _light = 10 Then BtnLightMinus.Enabled = False

            Display()
        End Sub

        Private Sub BtnLightPlus_Click(sender As Object, e As EventArgs) Handles BtnLightPlus.Click
            '* * * * *
            '* This button changes stats based on button click.
            '* * * * *

            BtnPlus(_light)
            BtnLightMinus.Enabled = True
            Display()
        End Sub

        Private Sub BtnSlippingMinus_Click(sender As Object, e As EventArgs) Handles BtnSlippingMinus.Click
            '* * * * *
            '* This button changes stats based on button click.
            '* * * * *

            BtnMinus(_slipping)

            If _slipping = 10 Then BtnSlippingMinus.Enabled = False

            Display()
        End Sub

        Private Sub BtnSlippingPlus_Click(sender As Object, e As EventArgs) Handles BtnSlippingPlus.Click
            '* * * * *
            '* This button changes stats based on button click.
            '* * * * *

            BtnPlus(_slipping)
            BtnSlippingMinus.Enabled = True
            Display()
        End Sub

        Private Sub BtnStealthMinus_Click(sender As Object, e As EventArgs) Handles BtnStealthMinus.Click
            '* * * * *
            '* This button changes stats based on button click.
            '* * * * *

            BtnMinus(_stealth)

            If _stealth = 10 Then BtnStealthMinus.Enabled = False

            Display()
        End Sub

        Private Sub BtnStealthPlus_Click(sender As Object, e As EventArgs) Handles BtnStealthPlus.Click
            '* * * * *
            '* This button changes stats based on button click.
            '* * * * *

            BtnPlus(_stealth)
            BtnStealthMinus.Enabled = True
            Display()
        End Sub

        Private Sub BtnTwoMinus_Click(sender As Object, e As EventArgs) Handles BtnTwoMinus.Click
            '* * * * *
            '* This button changes stats based on button click.
            '* * * * *

            BtnMinus(_twoH)
            If _twoH = 10 Then BtnTwoMinus.Enabled = False

            Display()
        End Sub

        Private Sub BtnTwoPlus_Click(sender As Object, e As EventArgs) Handles BtnTwoPlus.Click
            '* * * * *
            '* This button changes stats based on button click.
            '* * * * *

            BtnPlus(_twoH)
            BtnTwoMinus.Enabled = True
            Display()
        End Sub

        Private Sub FrmNewUser_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
            '* * * * *
            '* This button determines what form to show on closing.
            '* * * * *

            If _blnStart = False Then
                FrmMain.Show()
            End If
        End Sub

    End Class

End Namespace