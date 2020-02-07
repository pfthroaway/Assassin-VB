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

        ''' <summary>Resets all stats.</summary>
        Private Sub Clear()
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

            DisableMinusButtons()
            Display()
            TxtName.Focus()
        End Sub

        ''' <summary>displays all stats.</summary>
        Private Sub Display()
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
            Else
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

        ''' <summary>Checks whether a plus button should be enabled or not.</summary>
        Private Sub CheckPlusButtons()
            BtnEndPlus.Enabled = _maxEnd < 9980
            BtnLightPlus.Enabled = _light < 90
            BtnHeavyPlus.Enabled = _heavy < 90
            BtnTwoPlus.Enabled = _twoH < 90
            BtnBlockPlus.Enabled = _blocking < 90
            BtnSlippingPlus.Enabled = _slipping < 90
            BtnStealthPlus.Enabled = _stealth < 90
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

#End Region

#Region "Click"

        Private Sub BtnBlockMinus_Click(sender As Object, e As EventArgs) Handles BtnBlockMinus.Click
            BtnMinus(_blocking)
            If _blocking = 10 Then BtnBlockMinus.Enabled = False
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

        Private Async Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles BtnCreate.Click
            Dim username As String = TxtName.Text

            If TxtPass.Text = TxtConfirm.Text Then
                If AllUsers.Exists(Function(user As User) user.Name = username) OrElse username = "Computer" Then
                    MessageBox.Show("This username has already been used.", "Assassin", MessageBoxButtons.OK)
                Else
                    Dim newUser As New User With {
                        .Name = username,
                        .Password = Argon2.HashPassword(TxtPass.Text),
                        .CurrentEndurance = _maxEnd,
                        .MaximumEndurance = _maxEnd,
                        .LightWeaponSkill = _light,
                        .HeavyWeaponSkill = _heavy,
                        .TwoHandedWeaponSkill = _twoH,
                        .Blocking = _blocking,
                        .Slipping = _slipping,
                        .Stealth = _stealth,
                        .SkillPoints = _skillPts
                    }
                    Await GameState.NewUser(newUser)
                    Await MemberJoinsGuild(newUser, AllGuilds(0))

                    FrmGame.Show()
                    FrmGame.TxtGame.Text = $"Creare An Vita, {TxtName.Text}!{ControlChars.NewLine}{ControlChars.NewLine}You enter the city of thieves to take your place among the legends!"
                    FrmGame.Display()
                    _blnStart = True
                    Close()
                End If  'end user exists
            Else        'if passwords don't match
                MessageBox.Show("Passwords don't match.", "Assassin", MessageBoxButtons.OK)
            End If 'end password match
        End Sub

        Private Sub BtnEndMinus_Click(sender As Object, e As EventArgs) Handles BtnEndMinus.Click
            _skillPts += 1
            BtnEndPlus.Enabled = True
            _maxEnd -= 20
            Display()
        End Sub

        Private Sub BtnEndPlus_Click(sender As Object, e As EventArgs) Handles BtnEndPlus.Click
            _skillPts -= 1
            BtnEndMinus.Enabled = True
            _maxEnd += 20
            BtnEndPlus.Enabled = False
            Display()
        End Sub

        Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
            Close()
        End Sub

        Private Sub BtnHeavyMinus_Click(sender As Object, e As EventArgs) Handles BtnHeavyMinus.Click
            BtnMinus(_heavy)
            If _heavy = 10 Then BtnHeavyMinus.Enabled = False
            Display()
        End Sub

        Private Sub BtnHeavyPlus_Click(sender As Object, e As EventArgs) Handles BtnHeavyPlus.Click
            BtnPlus(_heavy)
            BtnHeavyMinus.Enabled = True
            Display()
        End Sub

        Private Sub BtnLightMinus_Click(sender As Object, e As EventArgs) Handles BtnLightMinus.Click
            BtnMinus(_light)
            If _light = 10 Then BtnLightMinus.Enabled = False
            Display()
        End Sub

        Private Sub BtnLightPlus_Click(sender As Object, e As EventArgs) Handles BtnLightPlus.Click
            BtnPlus(_light)
            BtnLightMinus.Enabled = True
            Display()
        End Sub

        Private Sub BtnSlippingMinus_Click(sender As Object, e As EventArgs) Handles BtnSlippingMinus.Click
            BtnMinus(_slipping)
            If _slipping = 10 Then BtnSlippingMinus.Enabled = False
            Display()
        End Sub

        Private Sub BtnSlippingPlus_Click(sender As Object, e As EventArgs) Handles BtnSlippingPlus.Click
            BtnPlus(_slipping)
            BtnSlippingMinus.Enabled = True
            Display()
        End Sub

        Private Sub BtnStealthMinus_Click(sender As Object, e As EventArgs) Handles BtnStealthMinus.Click
            BtnMinus(_stealth)
            If _stealth = 10 Then BtnStealthMinus.Enabled = False
            Display()
        End Sub

        Private Sub BtnStealthPlus_Click(sender As Object, e As EventArgs) Handles BtnStealthPlus.Click
            BtnPlus(_stealth)
            BtnStealthMinus.Enabled = True
            Display()
        End Sub

        Private Sub BtnTwoMinus_Click(sender As Object, e As EventArgs) Handles BtnTwoMinus.Click
            BtnMinus(_twoH)
            If _twoH = 10 Then BtnTwoMinus.Enabled = False
            Display()
        End Sub

        Private Sub BtnTwoPlus_Click(sender As Object, e As EventArgs) Handles BtnTwoPlus.Click
            BtnPlus(_twoH)
            BtnTwoMinus.Enabled = True
            Display()
        End Sub

#End Region

#Region "Form Management"

        Private Sub KeyChars(sender As Object, e As KeyPressEventArgs) Handles TxtName.KeyPress, TxtPass.KeyPress, TxtConfirm.KeyPress
            'letters, numbers, backspace, space
            e.Handled = Not (Char.IsLetterOrDigit(e.KeyChar) OrElse e.KeyChar Like " " OrElse e.KeyChar Like Chr(8))
        End Sub

        Private Sub TextChange(sender As Object, e As EventArgs) Handles TxtName.TextChanged, TxtPass.TextChanged, TxtConfirm.TextChanged
            If TxtName.TextLength > 0 OrElse TxtPass.TextLength > 0 OrElse TxtConfirm.TextLength > 0 Then
                BtnClear.Enabled = True
            End If

            If TxtName.TextLength > 0 AndAlso TxtPass.TextLength > 0 AndAlso TxtConfirm.TextLength > 0 AndAlso _skillPts = 0 Then
                BtnCreate.Enabled = True
            End If
        End Sub

        Private Sub FrmNewUser_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
            If _blnStart = False Then
                FrmMain.Show()
            End If
        End Sub

#End Region

    End Class

End Namespace