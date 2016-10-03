<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManageApplications
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
        Me.lblGuildName = New System.Windows.Forms.Label()
        Me.lstApplications = New System.Windows.Forms.ListBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.btnDeny = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblGuildName
        '
        Me.lblGuildName.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuildName.Location = New System.Drawing.Point(12, 9)
        Me.lblGuildName.Name = "lblGuildName"
        Me.lblGuildName.Size = New System.Drawing.Size(250, 40)
        Me.lblGuildName.TabIndex = 14
        Me.lblGuildName.Text = "Manage Applications"
        Me.lblGuildName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstApplications
        '
        Me.lstApplications.FormattingEnabled = True
        Me.lstApplications.ItemHeight = 18
        Me.lstApplications.Location = New System.Drawing.Point(17, 52)
        Me.lstApplications.Name = "lstApplications"
        Me.lstApplications.Size = New System.Drawing.Size(245, 184)
        Me.lstApplications.TabIndex = 15
        '
        'btnConfirm
        '
        Me.btnConfirm.Enabled = False
        Me.btnConfirm.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.Location = New System.Drawing.Point(62, 242)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(150, 30)
        Me.btnConfirm.TabIndex = 16
        Me.btnConfirm.Text = "&Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'btnDeny
        '
        Me.btnDeny.Enabled = False
        Me.btnDeny.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeny.Location = New System.Drawing.Point(62, 278)
        Me.btnDeny.Name = "btnDeny"
        Me.btnDeny.Size = New System.Drawing.Size(150, 30)
        Me.btnDeny.TabIndex = 17
        Me.btnDeny.Text = "&Deny"
        Me.btnDeny.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBack.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(62, 314)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(150, 30)
        Me.btnBack.TabIndex = 18
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'frmManageApplications
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnBack
        Me.ClientSize = New System.Drawing.Size(274, 355)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnDeny)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.lstApplications)
        Me.Controls.Add(Me.lblGuildName)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(290, 394)
        Me.MinimumSize = New System.Drawing.Size(290, 394)
        Me.Name = "frmManageApplications"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manage Applications"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblGuildName As System.Windows.Forms.Label
    Friend WithEvents lstApplications As System.Windows.Forms.ListBox
    Friend WithEvents btnConfirm As System.Windows.Forms.Button
    Friend WithEvents btnDeny As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
End Class
