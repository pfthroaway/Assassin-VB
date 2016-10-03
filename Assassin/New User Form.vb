' Title           : Assassin
' Programmer      : pfthroaway
' Version         : 1.0
' Creation Date:  : 05/25/2012
' Filename        : New User Form.vb
' Description     : This form allows the player to make a new user.

Option Strict On
Option Explicit On

Public Class frmNewUser
    Dim funcs As New Functions                  'new Functions instance
    Dim ds As New DataSet                       'DataSet
    Dim sql As String                           'SQL
    Dim table As String                         'table name
    Dim nl As String = ControlChars.NewLine     'new line

    Dim skillPts As Integer = 5                 'current skill points
    Dim maxEnd As Integer = 100                 'maximum endurance
    Dim light As Integer = 10                   'light weapon skill
    Dim heavy As Integer = 10                   'heavy weapon skill
    Dim twoH As Integer = 10                    'two handed weapon skill
    Dim blocking As Integer = 10                'blocking skill
    Dim slipping As Integer = 10                'slipping skill
    Dim stealth As Integer = 10                 'stealth skill

    Dim blnStart As Boolean = False             'start game on form close

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

        If maxEnd < 9980 Then
            btnEndPlus.Enabled = True
        Else
            btnEndPlus.Enabled = False
        End If

        If light < 90 Then
            btnLightPlus.Enabled = True
        Else
            btnLightPlus.Enabled = False
        End If

        If heavy < 90 Then
            btnHeavyPlus.Enabled = True
        Else
            btnHeavyPlus.Enabled = False
        End If

        If twoH < 90 Then
            btnTwoPlus.Enabled = True
        Else
            btnTwoPlus.Enabled = False
        End If

        If blocking < 90 Then
            btnBlockPlus.Enabled = True
        Else
            btnBlockPlus.Enabled = False
        End If

        If slipping < 90 Then
            btnSlippingPlus.Enabled = True
        Else
            btnSlippingPlus.Enabled = False
        End If

        If stealth < 90 Then
            btnStealthPlus.Enabled = True
        Else
            btnStealthPlus.Enabled = False
        End If
    End Sub

    Private Sub clear()
        '* * * * *
        '* This method resets all stats.
        '* * * * *

        txtName.Text = ""
        txtPass.Text = ""
        txtConfirm.Text = ""

        maxEnd = 100
        light = 10
        heavy = 10
        twoH = 10
        blocking = 10
        slipping = 10
        stealth = 10
        skillPts = 5

        disableMinusButtons()   'hide minus buttons
        display()               'display stats
        txtName.Focus()         'focus on txtName TextBox
    End Sub

    Private Sub display()
        '* * * * *
        '* This method displays all stats.
        '* * * * *

        'display all stats
        lblEndCurr.Text = maxEnd.ToString + "%"
        lblLightCurr.Text = light.ToString + "%"
        lblHeavyCurr.Text = heavy.ToString + "%"
        lblTwoCurr.Text = twoH.ToString + "%"
        lblBlockingCurr.Text = blocking.ToString + "%"
        lblSlippingCurr.Text = slipping.ToString + "%"
        lblStealthCurr.Text = stealth.ToString + "%"
        lblSkillPts.Text = skillPts.ToString

        If skillPts = 0 Then
            disablePlusButtons()
            btnCreate.Enabled = True
            btnClear.Enabled = True
        Else    'skillpts > 0
            If skillPts = 5 Then
                disableMinusButtons()
                btnClear.Enabled = False
                btnCreate.Enabled = False
            Else
                btnClear.Enabled = True
            End If
            checkPlusButtons()
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

    Private Sub keyChars(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtName.KeyPress, txtPass.KeyPress, txtConfirm.KeyPress
        '* * * * *
        '* This method prevents anything but numbers and letters entered into the TextBoxes.
        '* * * * *
        If Char.IsLetterOrDigit(e.KeyChar) OrElse e.KeyChar Like " " OrElse e.KeyChar Like Chr(8) Then 'letters, numbers, backspace, space
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub textChange(sender As System.Object, e As System.EventArgs) Handles txtName.TextChanged, txtPass.TextChanged, txtConfirm.TextChanged
        '* * * * *
        '* This method handles text changes in the TextBoxes.
        '* * * * *

        If txtName.TextLength > 0 OrElse txtPass.TextLength > 0 OrElse txtConfirm.TextLength > 0 Then
            btnClear.Enabled = True
        End If

        If txtName.TextLength > 0 AndAlso txtPass.TextLength > 0 AndAlso txtConfirm.TextLength > 0 AndAlso skillPts = 0 Then
            btnCreate.Enabled = True
        End If
    End Sub


    Private Sub btnBlockMinus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBlockMinus.Click
        '* * * * *
        '* This button changes stats based on button click.
        '* * * * *

        btnMinus(blocking)

        If blocking = 10 Then btnBlockMinus.Enabled = False

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

    Private Sub btnCreate_Click(sender As System.Object, e As System.EventArgs) Handles btnCreate.Click
        '* * * * *
        '* This method creates a new user after clicking the Create button.
        '* * * * *

        Dim username As String = txtName.Text
        sql = "SELECT * FROM Users WHERE Username='" & username & "'"
        table = "User"
        ds = funcs.fillDS(sql, table)
        Dim newUser As New User

        If txtPass.Text = txtConfirm.Text Then                  'if passwords match
            If ds.Tables("User").Rows.Count > 0 Or username = "Computer" Then  'if user name is in use
                MessageBox.Show("This username has already been used.", "Assassin", MessageBoxButtons.OK)
            Else
                'character
                newUser.name = txtName.Text                     'add Username
                newUser.password = funcs.MD5Hash(txtPass.Text)  'add Password
                newUser.currEnd = maxEnd                        'add Current Endurance
                newUser.maxEnd = maxEnd                         'add Maximum Endurance

                'skills
                newUser.lightWeaponSkill = light                'add Light Weapon Skill
                newUser.heavyWeaponSkill = heavy                'add Heavy Weapon Skill
                newUser.twoHWeaponSkill = twoH                  'add Two-Handed Weapon Skill
                newUser.blocking = blocking                     'add Blocking Skill
                newUser.slipping = slipping                     'add Slipping Skill
                newUser.stealth = stealth                       'add Stealth Skill
                newUser.skillPts = skillPts                     'set skill points
                funcs.newUser(newUser)                          'add newUser to database

                ds.Clear()                                      'clear DataSet
                sql = "SELECT * FROM Users WHERE Username='" & txtName.Text & "'"
                table = "User"
                ds = funcs.fillDS(sql, table)

                funcs.joinGuild(newUser.name, 1)

                frmGame.Show()
                frmGame.ds = ds
                frmGame.loadUser()
                frmGame.txtGame.Text = "Creare An Vita, " & txtName.Text & "!" & nl & nl & _
                    "You enter the city of thieves to take your place among the legends!"
                frmGame.display()
                blnStart = True
                Me.Close()
            End If  'end user exists
        Else        'if passwords don't match
            MessageBox.Show("Passwords don't match.", "Assassin", MessageBoxButtons.OK)
        End If 'end password match
    End Sub

    Private Sub btnEndMinus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEndMinus.Click
        '* * * * *
        '* This button changes stats based on button click.
        '* * * * *

        skillPts += 1
        btnEndPlus.Enabled = True

        maxEnd -= 20

        display()
    End Sub

    Private Sub btnEndPlus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEndPlus.Click
        '* * * * *
        '* This button changes stats based on button click.
        '* * * * *

        skillPts -= 1
        btnEndMinus.Enabled = True

        maxEnd += 20
        btnEndPlus.Enabled = False

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

        If heavy = 10 Then btnHeavyMinus.Enabled = False

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

        If light = 10 Then btnLightMinus.Enabled = False

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

    Private Sub btnSlippingMinus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSlippingMinus.Click
        '* * * * *
        '* This button changes stats based on button click.
        '* * * * *

        btnMinus(slipping)

        If slipping = 10 Then btnSlippingMinus.Enabled = False

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

        If stealth = 10 Then btnStealthMinus.Enabled = False

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
        If twoH = 10 Then btnTwoMinus.Enabled = False

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

        If blnStart = False Then
            frmMain.Show()
        End If
    End Sub
End Class