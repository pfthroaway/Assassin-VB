Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

Namespace Forms
    <DesignerGenerated()> _
    Partial Class FrmChangePassword
        Inherits Form

        'Form overrides dispose to clean up the component list.
        <DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        'Required by the Windows Form Designer
        Private components As IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.Label1 = New Label()
            Me.Label2 = New Label()
            Me.Label3 = New Label()
            Me.Label4 = New Label()
            Me.txtOldPswd = New TextBox()
            Me.txtNewPswd = New TextBox()
            Me.txtConfPswd = New TextBox()
            Me.btnSubmit = New Button()
            Me.btnBack = New Button()
            Me.SuspendLayout()
            '
            'Label1
            '
            Me.Label1.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New Point(15, 9)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New Size(279, 26)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Change Password"
            Me.Label1.TextAlign = ContentAlignment.MiddleCenter
            '
            'Label2
            '
            Me.Label2.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New Point(12, 35)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New Size(150, 26)
            Me.Label2.TabIndex = 1
            Me.Label2.Text = "Old Password:"
            Me.Label2.TextAlign = ContentAlignment.MiddleRight
            '
            'Label3
            '
            Me.Label3.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New Point(12, 69)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New Size(150, 26)
            Me.Label3.TabIndex = 2
            Me.Label3.Text = "New Password:"
            Me.Label3.TextAlign = ContentAlignment.MiddleRight
            '
            'Label4
            '
            Me.Label4.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New Point(12, 103)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New Size(150, 26)
            Me.Label4.TabIndex = 3
            Me.Label4.Text = "Confirm Password:"
            Me.Label4.TextAlign = ContentAlignment.MiddleRight
            '
            'txtOldPswd
            '
            Me.txtOldPswd.BorderStyle = BorderStyle.FixedSingle
            Me.txtOldPswd.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.txtOldPswd.Location = New Point(169, 37)
            Me.txtOldPswd.Margin = New Padding(4)
            Me.txtOldPswd.MaxLength = 16
            Me.txtOldPswd.Name = "txtOldPswd"
            Me.txtOldPswd.ScrollBars = ScrollBars.Vertical
            Me.txtOldPswd.Size = New Size(125, 26)
            Me.txtOldPswd.TabIndex = 11
            Me.txtOldPswd.TextAlign = HorizontalAlignment.Center
            Me.txtOldPswd.UseSystemPasswordChar = True
            '
            'txtNewPswd
            '
            Me.txtNewPswd.BorderStyle = BorderStyle.FixedSingle
            Me.txtNewPswd.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.txtNewPswd.Location = New Point(169, 71)
            Me.txtNewPswd.Margin = New Padding(4)
            Me.txtNewPswd.MaxLength = 16
            Me.txtNewPswd.Name = "txtNewPswd"
            Me.txtNewPswd.ScrollBars = ScrollBars.Vertical
            Me.txtNewPswd.Size = New Size(125, 26)
            Me.txtNewPswd.TabIndex = 12
            Me.txtNewPswd.TextAlign = HorizontalAlignment.Center
            Me.txtNewPswd.UseSystemPasswordChar = True
            '
            'txtConfPswd
            '
            Me.txtConfPswd.BorderStyle = BorderStyle.FixedSingle
            Me.txtConfPswd.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.txtConfPswd.Location = New Point(169, 105)
            Me.txtConfPswd.Margin = New Padding(4)
            Me.txtConfPswd.MaxLength = 16
            Me.txtConfPswd.Name = "txtConfPswd"
            Me.txtConfPswd.ScrollBars = ScrollBars.Vertical
            Me.txtConfPswd.Size = New Size(125, 26)
            Me.txtConfPswd.TabIndex = 13
            Me.txtConfPswd.TextAlign = HorizontalAlignment.Center
            Me.txtConfPswd.UseSystemPasswordChar = True
            '
            'btnSubmit
            '
            Me.btnSubmit.Enabled = False
            Me.btnSubmit.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnSubmit.Location = New Point(91, 138)
            Me.btnSubmit.Name = "btnSubmit"
            Me.btnSubmit.Size = New Size(125, 30)
            Me.btnSubmit.TabIndex = 20
            Me.btnSubmit.Text = "&Submit"
            Me.btnSubmit.UseVisualStyleBackColor = True
            '
            'btnBack
            '
            Me.btnBack.DialogResult = DialogResult.Cancel
            Me.btnBack.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnBack.Location = New Point(91, 174)
            Me.btnBack.Name = "btnBack"
            Me.btnBack.Size = New Size(125, 30)
            Me.btnBack.TabIndex = 21
            Me.btnBack.Text = "&Back"
            Me.btnBack.UseVisualStyleBackColor = True
            '
            'frmChangePassword
            '
            Me.AutoScaleDimensions = New SizeF(9.0!, 18.0!)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.CancelButton = Me.btnBack
            Me.ClientSize = New Size(307, 215)
            Me.Controls.Add(Me.btnBack)
            Me.Controls.Add(Me.btnSubmit)
            Me.Controls.Add(Me.txtConfPswd)
            Me.Controls.Add(Me.txtNewPswd)
            Me.Controls.Add(Me.txtOldPswd)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Label1)
            Me.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Margin = New Padding(4)
            Me.MaximizeBox = False
            Me.MaximumSize = New Size(323, 254)
            Me.MinimumSize = New Size(323, 254)
            Me.Name = "frmChangePassword"
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.Text = "Change Password"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents Label1 As Label
        Friend WithEvents Label2 As Label
        Friend WithEvents Label3 As Label
        Friend WithEvents Label4 As Label
        Friend WithEvents TxtOldPswd As TextBox
        Friend WithEvents TxtNewPswd As TextBox
        Friend WithEvents TxtConfPswd As TextBox
        Friend WithEvents BtnSubmit As Button
        Friend WithEvents BtnBack As Button
    End Class
End NameSpace