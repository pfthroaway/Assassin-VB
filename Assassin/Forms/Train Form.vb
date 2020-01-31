' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 05/25/2012
' Filename        : Train Form.vb
' Description     : This form is used for training a character.

Option Strict On
Option Explicit On

Imports Assassin.Classes
Imports Assassin.Classes.Entities

Namespace Forms

    Public Class FrmTrain

        Dim _maxEnd As Integer       'maximum endurance
        Dim _light As Integer        'light weapon skill
        Dim _heavy As Integer        'heavy weapon skill
        Dim _twoH As Integer         'two-handed weapon skill
        Dim _blocking As Integer     'blocking skill
        Dim _slipping As Integer     'slipping skill
        Dim _stealth As Integer      'stealth skill
        Dim _skillPts As Integer     'current skill points

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

            If CurrentUser.MaximumEndurance + _maxEnd < 9980 Then
                BtnEndPlus.Enabled = True
            Else
                BtnEndPlus.Enabled = False
            End If

            If (CurrentUser.LightWeaponSkill + _light) < 90 Then
                BtnLightPlus.Enabled = True
            Else
                BtnLightPlus.Enabled = False
            End If

            If (CurrentUser.HeavyWeaponSkill + _heavy) < 90 Then
                BtnHeavyPlus.Enabled = True
            Else
                BtnHeavyPlus.Enabled = False
            End If

            If (CurrentUser.TwoHandedWeaponSkill + _twoH) < 90 Then
                BtnTwoPlus.Enabled = True
            Else
                BtnTwoPlus.Enabled = False
            End If

            If (CurrentUser.Blocking + _blocking) < 90 Then
                BtnBlockPlus.Enabled = True
            Else
                BtnBlockPlus.Enabled = False
            End If

            If (CurrentUser.Slipping + _slipping) < 90 Then
                BtnSlippingPlus.Enabled = True
            Else
                BtnSlippingPlus.Enabled = False
            End If

            If (CurrentUser.Stealth + _stealth) < 90 Then
                BtnStealthPlus.Enabled = True
            Else
                BtnStealthPlus.Enabled = False
            End If
        End Sub

        Private Sub Clear()
            '* * * * *
            '* This method resets all stats.
            '* * * * *

            _maxEnd = 0
            _light = 0
            _heavy = 0
            _twoH = 0
            _blocking = 0
            _slipping = 0
            _stealth = 0
            _skillPts = CurrentUser.SkillPoints

            DisableMinusButtons()  'hide minus buttons
            Display()               'display stats
        End Sub

        Private Sub Display()
            '* * * * *
            '* This method displays all stats.
            '* * * * *

            'display all stats
            lblEndCurr.Text = (CurrentUser.MaximumEndurance + _maxEnd).ToString + "%"
            lblLightCurr.Text = (CurrentUser.LightWeaponSkill + _light).ToString + "%"
            lblHeavyCurr.Text = (CurrentUser.HeavyWeaponSkill + _heavy).ToString + "%"
            lblTwoCurr.Text = (CurrentUser.TwoHandedWeaponSkill + _twoH).ToString + "%"
            lblBlockingCurr.Text = (CurrentUser.Blocking + _blocking).ToString + "%"
            lblSlippingCurr.Text = (CurrentUser.Slipping + _slipping).ToString + "%"
            lblStealthCurr.Text = (CurrentUser.Stealth + _stealth).ToString + "%"
            lblSkillPts.Text = _skillPts.ToString

            If _skillPts = 0 Then
                DisablePlusButtons()
            Else    'skillpts > 0
                CheckPlusButtons()
            End If
            If _skillPts = CurrentUser.SkillPoints Then
                DisableMinusButtons()
                BtnClear.Enabled = False
                BtnSave.Enabled = False
            Else
                BtnClear.Enabled = True
                BtnSave.Enabled = True
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

        Public Sub LoadUser()
            '* * * * *
            '* This method performs operations on loading.
            '* * * * *

            _skillPts = CurrentUser.SkillPoints
            Display()
        End Sub

        Private Sub BtnBlockMinus_Click(sender As Object, e As EventArgs) Handles BtnBlockMinus.Click
            '* * * * *
            '* This button changes stats based on button click.
            '* * * * *

            BtnMinus(_blocking)

            If _blocking = 0 Then BtnBlockMinus.Enabled = False

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

        Private Sub BtnEndMinus_Click(sender As Object, e As EventArgs) Handles BtnEndMinus.Click
            '* * * * *
            '* This button changes stats based on button click.
            '* * * * *

            _skillPts += 1     'add a skillpoint

            _maxEnd -= 20      'subtract 20 from maximum endurance

            Display()
        End Sub

        Private Sub BtnEndPlus_Click(sender As Object, e As EventArgs) Handles BtnEndPlus.Click
            '* * * * *
            '* This button changes stats based on button click.
            '* * * * *

            _skillPts -= 1
            BtnEndMinus.Enabled = True

            _maxEnd += 20  'add 20 to maximum endurance

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

            If _heavy = 0 Then BtnHeavyMinus.Enabled = False

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

            If _light = 0 Then BtnLightMinus.Enabled = False

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

        Private Async Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
            '* * * * *
            '* This method saves the user on clicking the Save button.
            '* * * * *

            CurrentUser.SkillPoints = _skillPts
            CurrentUser.MaximumEndurance += _maxEnd
            CurrentUser.CurrentEndurance += _maxEnd
            CurrentUser.LightWeaponSkill += _light
            CurrentUser.HeavyWeaponSkill += _heavy
            CurrentUser.TwoHandedWeaponSkill += _twoH
            CurrentUser.Blocking += _blocking
            CurrentUser.Slipping += _slipping
            CurrentUser.Stealth += _stealth

            Await SaveUser(CurrentUser)
            MessageBox.Show("Save successful.", "Assassin", MessageBoxButtons.OK)

            DisableMinusButtons()
            BtnClear.Enabled = False
            BtnSave.Enabled = False
        End Sub

        Private Sub BtnSlippingMinus_Click(sender As Object, e As EventArgs) Handles BtnSlippingMinus.Click
            '* * * * *
            '* This button changes stats based on button click.
            '* * * * *

            BtnMinus(_slipping)

            If _slipping = 0 Then BtnSlippingMinus.Enabled = False

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

            If _stealth = 0 Then BtnStealthMinus.Enabled = False

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

            If _twoH = 0 Then BtnTwoMinus.Enabled = False

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

            FrmGame.Show()
            FrmGame.Display()
        End Sub

    End Class

End Namespace