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
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.TxtOldPswd = New System.Windows.Forms.TextBox()
            Me.TxtNewPswd = New System.Windows.Forms.TextBox()
            Me.TxtConfPswd = New System.Windows.Forms.TextBox()
            Me.BtnSubmit = New System.Windows.Forms.Button()
            Me.BtnBack = New System.Windows.Forms.Button()
            Me.SuspendLayout()
            '
            'Label1
            '
            Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(12, 9)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(384, 26)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Change Password"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label2
            '
            Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(12, 38)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(150, 26)
            Me.Label2.TabIndex = 1
            Me.Label2.Text = "Old Password:"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label3
            '
            Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(13, 72)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(150, 26)
            Me.Label3.TabIndex = 2
            Me.Label3.Text = "New Password:"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label4
            '
            Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(12, 106)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(150, 26)
            Me.Label4.TabIndex = 3
            Me.Label4.Text = "Confirm Password:"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'TxtOldPswd
            '
            Me.TxtOldPswd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.TxtOldPswd.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TxtOldPswd.Location = New System.Drawing.Point(169, 37)
            Me.TxtOldPswd.Margin = New System.Windows.Forms.Padding(4)
            Me.TxtOldPswd.MaxLength = 16
            Me.TxtOldPswd.Name = "TxtOldPswd"
            Me.TxtOldPswd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.TxtOldPswd.Size = New System.Drawing.Size(226, 29)
            Me.TxtOldPswd.TabIndex = 11
            Me.TxtOldPswd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.TxtOldPswd.UseSystemPasswordChar = True
            '
            'TxtNewPswd
            '
            Me.TxtNewPswd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.TxtNewPswd.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TxtNewPswd.Location = New System.Drawing.Point(169, 71)
            Me.TxtNewPswd.Margin = New System.Windows.Forms.Padding(4)
            Me.TxtNewPswd.MaxLength = 16
            Me.TxtNewPswd.Name = "TxtNewPswd"
            Me.TxtNewPswd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.TxtNewPswd.Size = New System.Drawing.Size(226, 29)
            Me.TxtNewPswd.TabIndex = 12
            Me.TxtNewPswd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.TxtNewPswd.UseSystemPasswordChar = True
            '
            'TxtConfPswd
            '
            Me.TxtConfPswd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.TxtConfPswd.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TxtConfPswd.Location = New System.Drawing.Point(169, 105)
            Me.TxtConfPswd.Margin = New System.Windows.Forms.Padding(4)
            Me.TxtConfPswd.MaxLength = 16
            Me.TxtConfPswd.Name = "TxtConfPswd"
            Me.TxtConfPswd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.TxtConfPswd.Size = New System.Drawing.Size(226, 29)
            Me.TxtConfPswd.TabIndex = 13
            Me.TxtConfPswd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.TxtConfPswd.UseSystemPasswordChar = True
            '
            'BtnSubmit
            '
            Me.BtnSubmit.Enabled = False
            Me.BtnSubmit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnSubmit.Location = New System.Drawing.Point(141, 138)
            Me.BtnSubmit.Name = "BtnSubmit"
            Me.BtnSubmit.Size = New System.Drawing.Size(125, 30)
            Me.BtnSubmit.TabIndex = 20
            Me.BtnSubmit.Text = "&Submit"
            Me.BtnSubmit.UseVisualStyleBackColor = True
            '
            'BtnBack
            '
            Me.BtnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.BtnBack.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnBack.Location = New System.Drawing.Point(141, 174)
            Me.BtnBack.Name = "BtnBack"
            Me.BtnBack.Size = New System.Drawing.Size(125, 30)
            Me.BtnBack.TabIndex = 21
            Me.BtnBack.Text = "&Back"
            Me.BtnBack.UseVisualStyleBackColor = True
            '
            'FrmChangePassword
            '
            Me.AcceptButton = Me.BtnSubmit
            Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.BtnBack
            Me.ClientSize = New System.Drawing.Size(408, 215)
            Me.Controls.Add(Me.BtnBack)
            Me.Controls.Add(Me.BtnSubmit)
            Me.Controls.Add(Me.TxtConfPswd)
            Me.Controls.Add(Me.TxtNewPswd)
            Me.Controls.Add(Me.TxtOldPswd)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Label1)
            Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Margin = New System.Windows.Forms.Padding(4)
            Me.MaximizeBox = False
            Me.MaximumSize = New System.Drawing.Size(424, 254)
            Me.MinimumSize = New System.Drawing.Size(424, 254)
            Me.Name = "FrmChangePassword"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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