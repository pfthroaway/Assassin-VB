Option Strict On
Option Explicit On

Imports Assassin.Classes
Imports Assassin.Classes.Entities
Imports Extensions.Encryption

Namespace Forms

    Public Class FrmNewUser
        Dim _skillPts As Integer = 5
        Dim _maxEnd As Integer = 100
        Dim _light As Integer = 10
        Dim _heavy As Integer = 10
        Dim _twoH As Integer = 10
        Dim _blocking As Integer = 10
        Dim _slipping As Integer = 10
        Dim _stealth As Integer = 10

        Dim _blnStart As Boolean = False

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

        ''' <summary>Displays all stats.</summary>
        Private Sub Display()
            LblEndCurr.Text = _maxEnd.ToString + "%"
            LblLightCurr.Text = _light.ToString + "%"
            LblHeavyCurr.Text = _heavy.ToString + "%"
            LblTwoCurr.Text = _twoH.ToString + "%"
            LblBlockingCurr.Text = _blocking.ToString + "%"
            LblSlippingCurr.Text = _slipping.ToString + "%"
            LblStealthCurr.Text = _stealth.ToString + "%"
            LblSkillPts.Text = _skillPts.ToString

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
            BtnBlockMinus.Enabled = _blocking <> 10
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
                        .Password = PBKDF2.HashPassword(TxtPass.Text),
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
                    AllUsers.Add(newUser)
                    AllUsers = AllUsers.OrderBy(Function(user) user.Name).ToList()
                    AllGuilds(0).Members.Add(newUser.Name)
                    CurrentUser = AllUsers.Find(Function(user) user = newUser)
                    FrmGame.Show()
                    FrmGame.TxtGame.Text = $"Creare An Vita, {TxtName.Text}!{ControlChars.NewLine}{ControlChars.NewLine}You enter the city of thieves to take your place among the legends!"
                    FrmGame.Display()
                    _blnStart = True
                    Close()
                End If
            Else
                MessageBox.Show("Passwords don't match.", "Assassin", MessageBoxButtons.OK)
            End If
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
            BtnHeavyMinus.Enabled = _heavy <> 10
            Display()
        End Sub

        Private Sub BtnHeavyPlus_Click(sender As Object, e As EventArgs) Handles BtnHeavyPlus.Click
            BtnPlus(_heavy)
            BtnHeavyMinus.Enabled = True
            Display()
        End Sub

        Private Sub BtnLightMinus_Click(sender As Object, e As EventArgs) Handles BtnLightMinus.Click
            BtnMinus(_light)
            BtnLightMinus.Enabled = _light <> 10
            Display()
        End Sub

        Private Sub BtnLightPlus_Click(sender As Object, e As EventArgs) Handles BtnLightPlus.Click
            BtnPlus(_light)
            BtnLightMinus.Enabled = True
            Display()
        End Sub

        Private Sub BtnSlippingMinus_Click(sender As Object, e As EventArgs) Handles BtnSlippingMinus.Click
            BtnMinus(_slipping)
            BtnSlippingMinus.Enabled = _slipping <> 10
            Display()
        End Sub

        Private Sub BtnSlippingPlus_Click(sender As Object, e As EventArgs) Handles BtnSlippingPlus.Click
            BtnPlus(_slipping)
            BtnSlippingMinus.Enabled = True
            Display()
        End Sub

        Private Sub BtnStealthMinus_Click(sender As Object, e As EventArgs) Handles BtnStealthMinus.Click
            BtnMinus(_stealth)
            BtnStealthMinus.Enabled = _stealth <> 10
            Display()
        End Sub

        Private Sub BtnStealthPlus_Click(sender As Object, e As EventArgs) Handles BtnStealthPlus.Click
            BtnPlus(_stealth)
            BtnStealthMinus.Enabled = True
            Display()
        End Sub

        Private Sub BtnTwoMinus_Click(sender As Object, e As EventArgs) Handles BtnTwoMinus.Click
            BtnMinus(_twoH)
            BtnTwoMinus.Enabled = _twoH <> 10
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
            BtnClear.Enabled = TxtName.TextLength > 0 OrElse TxtPass.TextLength > 0 OrElse TxtConfirm.TextLength > 0
            BtnCreate.Enabled = TxtName.TextLength > 0 AndAlso TxtPass.TextLength > 0 AndAlso TxtConfirm.TextLength > 0 AndAlso _skillPts = 0
        End Sub

        Private Sub FrmNewUser_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
            If _blnStart = False Then
                FrmMain.Show()
            End If
        End Sub

#End Region

    End Class

End Namespace