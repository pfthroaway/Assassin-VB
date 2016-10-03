<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangePassword
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtOldPswd = New System.Windows.Forms.TextBox()
        Me.txtNewPswd = New System.Windows.Forms.TextBox()
        Me.txtConfPswd = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(279, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Change Password"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Old Password:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 26)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "New Password:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 26)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Confirm Password:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtOldPswd
        '
        Me.txtOldPswd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOldPswd.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOldPswd.Location = New System.Drawing.Point(169, 37)
        Me.txtOldPswd.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOldPswd.MaxLength = 16
        Me.txtOldPswd.Name = "txtOldPswd"
        Me.txtOldPswd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOldPswd.Size = New System.Drawing.Size(125, 26)
        Me.txtOldPswd.TabIndex = 11
        Me.txtOldPswd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtOldPswd.UseSystemPasswordChar = True
        '
        'txtNewPswd
        '
        Me.txtNewPswd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNewPswd.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPswd.Location = New System.Drawing.Point(169, 71)
        Me.txtNewPswd.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNewPswd.MaxLength = 16
        Me.txtNewPswd.Name = "txtNewPswd"
        Me.txtNewPswd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNewPswd.Size = New System.Drawing.Size(125, 26)
        Me.txtNewPswd.TabIndex = 12
        Me.txtNewPswd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtNewPswd.UseSystemPasswordChar = True
        '
        'txtConfPswd
        '
        Me.txtConfPswd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConfPswd.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfPswd.Location = New System.Drawing.Point(169, 105)
        Me.txtConfPswd.Margin = New System.Windows.Forms.Padding(4)
        Me.txtConfPswd.MaxLength = 16
        Me.txtConfPswd.Name = "txtConfPswd"
        Me.txtConfPswd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtConfPswd.Size = New System.Drawing.Size(125, 26)
        Me.txtConfPswd.TabIndex = 13
        Me.txtConfPswd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtConfPswd.UseSystemPasswordChar = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Enabled = False
        Me.btnSubmit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(91, 138)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(125, 30)
        Me.btnSubmit.TabIndex = 20
        Me.btnSubmit.Text = "&Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBack.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(91, 174)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(125, 30)
        Me.btnBack.TabIndex = 21
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'frmChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnBack
        Me.ClientSize = New System.Drawing.Size(307, 215)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtConfPswd)
        Me.Controls.Add(Me.txtNewPswd)
        Me.Controls.Add(Me.txtOldPswd)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(323, 254)
        Me.MinimumSize = New System.Drawing.Size(323, 254)
        Me.Name = "frmChangePassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtOldPswd As System.Windows.Forms.TextBox
    Friend WithEvents txtNewPswd As System.Windows.Forms.TextBox
    Friend WithEvents txtConfPswd As System.Windows.Forms.TextBox
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
End Class
