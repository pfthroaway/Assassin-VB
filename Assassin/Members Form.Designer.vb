<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMembers
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
        Me.lstMembers = New System.Windows.Forms.ListBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnMessage = New System.Windows.Forms.Button()
        Me.btnExpel = New System.Windows.Forms.Button()
        Me.btnAttack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstMembers
        '
        Me.lstMembers.FormattingEnabled = True
        Me.lstMembers.ItemHeight = 18
        Me.lstMembers.Location = New System.Drawing.Point(12, 72)
        Me.lstMembers.Name = "lstMembers"
        Me.lstMembers.ScrollAlwaysVisible = True
        Me.lstMembers.Size = New System.Drawing.Size(225, 220)
        Me.lstMembers.TabIndex = 0
        '
        'lblName
        '
        Me.lblName.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(12, 9)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(225, 60)
        Me.lblName.TabIndex = 5
        Me.lblName.Text = "Members"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBack
        '
        Me.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBack.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(49, 406)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(150, 30)
        Me.btnBack.TabIndex = 4
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnMessage
        '
        Me.btnMessage.Enabled = False
        Me.btnMessage.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMessage.Location = New System.Drawing.Point(49, 298)
        Me.btnMessage.Name = "btnMessage"
        Me.btnMessage.Size = New System.Drawing.Size(150, 30)
        Me.btnMessage.TabIndex = 1
        Me.btnMessage.Text = "&Message"
        Me.btnMessage.UseVisualStyleBackColor = True
        '
        'btnExpel
        '
        Me.btnExpel.Enabled = False
        Me.btnExpel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExpel.Location = New System.Drawing.Point(49, 334)
        Me.btnExpel.Name = "btnExpel"
        Me.btnExpel.Size = New System.Drawing.Size(150, 30)
        Me.btnExpel.TabIndex = 2
        Me.btnExpel.Text = "&Expel"
        Me.btnExpel.UseVisualStyleBackColor = True
        Me.btnExpel.Visible = False
        '
        'btnAttack
        '
        Me.btnAttack.Enabled = False
        Me.btnAttack.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAttack.Location = New System.Drawing.Point(49, 370)
        Me.btnAttack.Name = "btnAttack"
        Me.btnAttack.Size = New System.Drawing.Size(150, 30)
        Me.btnAttack.TabIndex = 3
        Me.btnAttack.Text = "&Attack"
        Me.btnAttack.UseVisualStyleBackColor = True
        Me.btnAttack.Visible = False
        '
        'frmMembers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnBack
        Me.ClientSize = New System.Drawing.Size(249, 447)
        Me.Controls.Add(Me.btnAttack)
        Me.Controls.Add(Me.btnExpel)
        Me.Controls.Add(Me.btnMessage)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lstMembers)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(265, 486)
        Me.MinimumSize = New System.Drawing.Size(265, 486)
        Me.Name = "frmMembers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Members"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstMembers As System.Windows.Forms.ListBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnMessage As System.Windows.Forms.Button
    Friend WithEvents btnExpel As System.Windows.Forms.Button
    Friend WithEvents btnAttack As System.Windows.Forms.Button
End Class
