' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 05/25/2012
' Filename        : Train Form.vb
' Description     : This form is used for training a character.

Option Strict On
Option Explicit On

Public Class frmTrain
    Dim funcs As New Functions  'new Functions instance
    Public currUser As New User 'current user
    Dim maxEnd As Integer       'maximum endurance
    Dim light As Integer        'light weapon skill
    Dim heavy As Integer        'heavy weapon skill
    Dim twoH As Integer         'two-handed weapon skill
    Dim blocking As Integer     'blocking skill
    Dim slipping As Integer     'slipping skill
    Dim stealth As Integer      'stealth skill
    Dim skillPts As Integer     'current skill points

    Private Sub btnMinus(ByRef stat As Integer)
        '* * * * *
        '* This method accepts a stat and decreases it.
        '* * * * *

        skillPts += 1   'increase skill points
        stat -= 8       'decrease stat

        display()       'display stats
    End Sub

    Private Sub btnPlus(ByRef stat As Integer)
        '* * * * *
        '* This method accepts a stat and increases it.
        '* * * * *

        skillPts -= 1   'decrease skill points
        stat += 8       'increase stat

        display()       'display stats
    End Sub

    Private Sub checkPlusButtons()
        '* * * * *
        '* This method checks whether a plus button should be enabled or not.
        '* * * * *

        If currUser.maxEnd + maxEnd < 9980 Then
            btnEndPlus.Enabled = True
        Else
            btnEndPlus.Enabled = False
        End If

        If (currUser.lightWeaponSkill + light) < 90 Then
            btnLightPlus.Enabled = True
        Else
            btnLightPlus.Enabled = False
        End If

        If (currUser.heavyWeaponSkill + heavy) < 90 Then
            btnHeavyPlus.Enabled = True
        Else
            btnHeavyPlus.Enabled = False
        End If

        If (currUser.twoHWeaponSkill + twoH) < 90 Then
            btnTwoPlus.Enabled = True
        Else
            btnTwoPlus.Enabled = False
        End If

        If (currUser.blocking + blocking) < 90 Then
            btnBlockPlus.Enabled = True
        Else
            btnBlockPlus.Enabled = False
        End If

        If (currUser.slipping + slipping) < 90 Then
            btnSlippingPlus.Enabled = True
        Else
            btnSlippingPlus.Enabled = False
        End If

        If (currUser.stealth + stealth) < 90 Then
            btnStealthPlus.Enabled = True
        Else
            btnStealthPlus.Enabled = False
        End If
    End Sub

    Private Sub clear()
        '* * * * *
        '* This method resets all stats.
        '* * * * *

        maxEnd = 0
        light = 0
        heavy = 0
        twoH = 0
        blocking = 0
        slipping = 0
        stealth = 0
        skillPts = currUser.skillPts

        disableMinusButtons()  'hide minus buttons
        display()               'display stats
    End Sub

    Private Sub display()
        '* * * * *
        '* This method displays all stats.
        '* * * * *

        'display all stats
        lblEndCurr.Text = (currUser.maxEnd + maxEnd).ToString + "%"
        lblLightCurr.Text = (currUser.lightWeaponSkill + light).ToString + "%"
        lblHeavyCurr.Text = (currUser.heavyWeaponSkill + heavy).ToString + "%"
        lblTwoCurr.Text = (currUser.twoHWeaponSkill + twoH).ToString + "%"
        lblBlockingCurr.Text = (currUser.blocking + blocking).ToString + "%"
        lblSlippingCurr.Text = (currUser.slipping + slipping).ToString + "%"
        lblStealthCurr.Text = (currUser.stealth + stealth).ToString + "%"
        lblSkillPts.Text = skillPts.ToString

        If skillPts = 0 Then
            disablePlusButtons()
        Else    'skillpts > 0
            checkPlusButtons()
        End If
        If skillPts = currUser.skillPts Then
            disableMinusButtons()
            btnClear.Enabled = False
            btnSave.Enabled = False
        Else
            btnClear.Enabled = True
            btnSave.Enabled = True
        End If
    End Sub

    Private Sub disableMinusButtons()
        '* * * * *
        '* This method disables minus buttons.
        '* * * * *

        btnEndMinus.Enabled = False
        btnLightMinus.Enabled = False
        btnHeavyMinus.Enabled = False
        btnTwoMinus.Enabled = False
        btnBlockMinus.Enabled = False
        btnSlippingMinus.Enabled = False
        btnStealthMinus.Enabled = False
    End Sub

    Private Sub disablePlusButtons()
        '* * * * *
        '* This method disables plus buttons.
        '* * * * *

        btnEndPlus.Enabled = False
        btnLightPlus.Enabled = False
        btnHeavyPlus.Enabled = False
        btnTwoPlus.Enabled = False
        btnBlockPlus.Enabled = False
        btnSlippingPlus.Enabled = False
        btnStealthPlus.Enabled = False
    End Sub

    Private Sub enablePlusButtons()
        '* * * * *
        '* This method enables all plus buttons.
        '* * * * *

        btnEndPlus.Enabled = True
        btnLightPlus.Enabled = True
        btnHeavyPlus.Enabled = True
        btnTwoPlus.Enabled = True
        btnBlockPlus.Enabled = True
        btnSlippingPlus.Enabled = True
        btnStealthPlus.Enabled = True
    End Sub

    Public Sub loadUser()
        '* * * * *
        '* This method performs operations on loading.
        '* * * * *

        skillPts = currUser.skillPts
        display()
    End Sub


    Private Sub btnBlockMinus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBlockMinus.Click
        '* * * * *
        '* This button changes stats based on button click.
        '* * * * *

        btnMinus(blocking)

        If blocking = 0 Then btnBlockMinus.Enabled = False

        display()
    End Sub

    Private Sub btnBlockPlus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBlockPlus.Click
        '* * * * *
        '* This button changes stats based on button click.
        '* * * * *

        btnPlus(blocking)
        btnBlockMinus.Enabled = True
        display()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        '* * * * *
        '* This button clears all stats and TextBoxes.
        '* * * * *

        clear()
    End Sub

    Private Sub btnEndMinus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEndMinus.Click
        '* * * * *
        '* This button changes stats based on button click.
        '* * * * *

        skillPts += 1     'add a skillpoint

        maxEnd -= 20      'subtract 20 from maximum endurance

        display()
    End Sub

    Private Sub btnEndPlus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEndPlus.Click
        '* * * * *
        '* This button changes stats based on button click.
        '* * * * *

        skillPts -= 1
        btnEndMinus.Enabled = True

        maxEnd += 20  'add 20 to maximum endurance

        display()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        '* * * * *
        '* This button closes the program.
        '* * * * *

        Me.Close()
    End Sub

    Private Sub btnHeavyMinus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHeavyMinus.Click
        '* * * * *
        '* This button changes stats based on button click.
        '* * * * *

        btnMinus(heavy)

        If heavy = 0 Then btnHeavyMinus.Enabled = False

        display()
    End Sub

    Private Sub btnHeavyPlus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHeavyPlus.Click
        '* * * * *
        '* This button changes stats based on button click.
        '* * * * *

        btnPlus(heavy)
        btnHeavyMinus.Enabled = True
        display()
    End Sub

    Private Sub btnLightMinus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLightMinus.Click
        '* * * * *
        '* This button changes stats based on button click.
        '* * * * *

        btnMinus(light)

        If light = 0 Then btnLightMinus.Enabled = False

        display()
    End Sub

    Private Sub btnLightPlus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLightPlus.Click
        '* * * * *
        '* This button changes stats based on button click.
        '* * * * *

        btnPlus(light)
        btnLightMinus.Enabled = True
        display()
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        '* * * * *
        '* This method saves the user on clicking the Save button.
        '* * * * *

        currUser.skillPts = skillPts
        currUser.maxEnd += maxEnd
        currUser.currEnd += maxEnd
        currUser.lightWeaponSkill += light
        currUser.heavyWeaponSkill += heavy
        currUser.twoHWeaponSkill += twoH
        currUser.blocking += blocking
        currUser.slipping += slipping
        currUser.stealth += stealth

        funcs.save(currUser)
        MessageBox.Show("Save successful.", "Assassin", MessageBoxButtons.OK)

        disableMinusButtons()
        btnClear.Enabled = False
        btnSave.Enabled = False
    End Sub

    Private Sub btnSlippingMinus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSlippingMinus.Click
        '* * * * *
        '* This button changes stats based on button click.
        '* * * * *

        btnMinus(slipping)

        If slipping = 0 Then btnSlippingMinus.Enabled = False

        display()
    End Sub

    Private Sub btnSlippingPlus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSlippingPlus.Click
        '* * * * *
        '* This button changes stats based on button click.
        '* * * * *

        btnPlus(slipping)
        btnSlippingMinus.Enabled = True
        display()
    End Sub

    Private Sub btnStealthMinus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStealthMinus.Click
        '* * * * *
        '* This button changes stats based on button click.
        '* * * * *

        btnMinus(stealth)

        If stealth = 0 Then btnStealthMinus.Enabled = False

        display()
    End Sub

    Private Sub btnStealthPlus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStealthPlus.Click
        '* * * * *
        '* This button changes stats based on button click.
        '* * * * *

        btnPlus(stealth)
        btnStealthMinus.Enabled = True
        display()
    End Sub

    Private Sub btnTwoMinus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTwoMinus.Click
        '* * * * *
        '* This button changes stats based on button click.
        '* * * * *

        btnMinus(twoH)

        If twoH = 0 Then btnTwoMinus.Enabled = False

        display()
    End Sub

    Private Sub btnTwoPlus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTwoPlus.Click
        '* * * * *
        '* This button changes stats based on button click.
        '* * * * *

        btnPlus(twoH)
        btnTwoMinus.Enabled = True
        display()
    End Sub


    Private Sub frmNewUser_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        '* * * * *
        '* This button determines what form to show on closing.
        '* * * * *

        frmGame.Show()
        frmGame.currUser = currUser
        frmGame.display()
    End Sub
End Class