' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 05/25/2012
' Filename        : Train Form.vb
' Description     : This form is used for training a character.

Option Strict On
Option Explicit On

Imports Assassin.Classes

Namespace Forms

    Public Class FrmTrain

        Dim _maxEnd As Integer
        Dim _light As Integer
        Dim _heavy As Integer
        Dim _twoH As Integer
        Dim _blocking As Integer
        Dim _slipping As Integer
        Dim _stealth As Integer
        Dim _skillPts As Integer

        ''' <summary>Resets all stats.</summary>
        Private Sub Clear()
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

        ''' <summary>Displays all stats.</summary>
        Private Sub Display()
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
            Else
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

        ''' <summary>Performs operations on loading.</summary>
        Public Sub LoadUser()
            _skillPts = CurrentUser.SkillPoints
            Display()
        End Sub

#Region "Button Management"

        ''' <summary>Accepts a stat and decreases it.</summary>
        ''' <param name="stat">Stat to be decreased</param>
        Private Sub BtnMinus(ByRef stat As Integer)
            _skillPts += 1
            stat -= 8

            Display()
        End Sub

        ''' <summary>Accepts a stat and increases it.</summary>
        ''' <param name="stat">Stat to be increased</param>
        Private Sub BtnPlus(ByRef stat As Integer)
            _skillPts -= 1
            stat += 8

            Display()
        End Sub

        ''' <summary>Checks whether the plus buttons should be enabled.</summary>
        Private Sub CheckPlusButtons()
            BtnEndPlus.Enabled = (CurrentUser.MaximumEndurance + _maxEnd) < 9980
            BtnLightPlus.Enabled = (CurrentUser.LightWeaponSkill + _light) < 90
            BtnHeavyPlus.Enabled = (CurrentUser.HeavyWeaponSkill + _heavy) < 90
            BtnTwoPlus.Enabled = (CurrentUser.TwoHandedWeaponSkill + _twoH) < 90
            BtnBlockPlus.Enabled = (CurrentUser.Blocking + _blocking) < 90
            BtnSlippingPlus.Enabled = (CurrentUser.Slipping + _slipping) < 90
            BtnStealthPlus.Enabled = (CurrentUser.Stealth + _stealth) < 90
        End Sub

        ''' <summary>Disables minus buttons.</summary>
        Private Sub DisableMinusButtons()
            BtnEndMinus.Enabled = False
            BtnLightMinus.Enabled = False
            BtnHeavyMinus.Enabled = False
            BtnTwoMinus.Enabled = False
            BtnBlockMinus.Enabled = False
            BtnSlippingMinus.Enabled = False
            BtnStealthMinus.Enabled = False
        End Sub

        ''' <summary>Disables plus buttons.</summary>
        Private Sub DisablePlusButtons()
            BtnEndPlus.Enabled = False
            BtnLightPlus.Enabled = False
            BtnHeavyPlus.Enabled = False
            BtnTwoPlus.Enabled = False
            BtnBlockPlus.Enabled = False
            BtnSlippingPlus.Enabled = False
            BtnStealthPlus.Enabled = False
        End Sub

        ''' <summary>Enables all plus buttons.</summary>
        Private Sub EnablePlusButtons()
            BtnEndPlus.Enabled = True
            BtnLightPlus.Enabled = True
            BtnHeavyPlus.Enabled = True
            BtnTwoPlus.Enabled = True
            BtnBlockPlus.Enabled = True
            BtnSlippingPlus.Enabled = True
            BtnStealthPlus.Enabled = True
        End Sub

#End Region

#Region "Click"

        Private Sub BtnBlockMinus_Click(sender As Object, e As EventArgs) Handles BtnBlockMinus.Click
            BtnMinus(_blocking)
            If _blocking = 0 Then BtnBlockMinus.Enabled = False
            Display()
        End Sub

        Private Sub BtnBlockPlus_Click(sender As Object, e As EventArgs) Handles BtnBlockPlus.Click
            BtnPlus(_blocking)
            BtnBlockMinus.Enabled = True
            Display()
        End Sub

        Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
            Clear()
        End Sub

        Private Sub BtnEndMinus_Click(sender As Object, e As EventArgs) Handles BtnEndMinus.Click
            _skillPts += 1
            _maxEnd -= 20
            Display()
        End Sub

        Private Sub BtnEndPlus_Click(sender As Object, e As EventArgs) Handles BtnEndPlus.Click
            _skillPts -= 1
            BtnEndMinus.Enabled = True
            _maxEnd += 20
            Display()
        End Sub

        Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
            Close()
        End Sub

        Private Sub BtnHeavyMinus_Click(sender As Object, e As EventArgs) Handles BtnHeavyMinus.Click
            BtnMinus(_heavy)
            If _heavy = 0 Then BtnHeavyMinus.Enabled = False
            Display()
        End Sub

        Private Sub BtnHeavyPlus_Click(sender As Object, e As EventArgs) Handles BtnHeavyPlus.Click
            BtnPlus(_heavy)
            BtnHeavyMinus.Enabled = True
            Display()
        End Sub

        Private Sub BtnLightMinus_Click(sender As Object, e As EventArgs) Handles BtnLightMinus.Click
            BtnMinus(_light)
            If _light = 0 Then BtnLightMinus.Enabled = False
            Display()
        End Sub

        Private Sub BtnLightPlus_Click(sender As Object, e As EventArgs) Handles BtnLightPlus.Click
            BtnPlus(_light)
            BtnLightMinus.Enabled = True
            Display()
        End Sub

        Private Async Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
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
            BtnMinus(_slipping)
            If _slipping = 0 Then BtnSlippingMinus.Enabled = False
            Display()
        End Sub

        Private Sub BtnSlippingPlus_Click(sender As Object, e As EventArgs) Handles BtnSlippingPlus.Click
            BtnPlus(_slipping)
            BtnSlippingMinus.Enabled = True
            Display()
        End Sub

        Private Sub BtnStealthMinus_Click(sender As Object, e As EventArgs) Handles BtnStealthMinus.Click
            BtnMinus(_stealth)
            If _stealth = 0 Then BtnStealthMinus.Enabled = False
            Display()
        End Sub

        Private Sub BtnStealthPlus_Click(sender As Object, e As EventArgs) Handles BtnStealthPlus.Click
            BtnPlus(_stealth)
            BtnStealthMinus.Enabled = True
            Display()
        End Sub

        Private Sub BtnTwoMinus_Click(sender As Object, e As EventArgs) Handles BtnTwoMinus.Click
            BtnMinus(_twoH)
            If _twoH = 0 Then BtnTwoMinus.Enabled = False
            Display()
        End Sub

        Private Sub BtnTwoPlus_Click(sender As Object, e As EventArgs) Handles BtnTwoPlus.Click
            BtnPlus(_twoH)
            BtnTwoMinus.Enabled = True
            Display()
        End Sub

#End Region

        Private Sub FrmNewUser_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
            FrmGame.Show()
            FrmGame.Display()
        End Sub

    End Class

End Namespace