<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJobs
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
        Me.components = New System.ComponentModel.Container()
        Me.txtJobs = New System.Windows.Forms.TextBox()
        Me.btnAccept = New System.Windows.Forms.Button()
        Me.btnDecline = New System.Windows.Forms.Button()
        Me.btnLeave = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout
        '
        'txtJobs
        '
        Me.txtJobs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtJobs.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJobs.Location = New System.Drawing.Point(13, 13)
        Me.txtJobs.Margin = New System.Windows.Forms.Padding(4)
        Me.txtJobs.Multiline = True
        Me.txtJobs.Name = "txtJobs"
        Me.txtJobs.ReadOnly = True
        Me.txtJobs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtJobs.Size = New System.Drawing.Size(400, 150)
        Me.txtJobs.TabIndex = 3
        Me.txtJobs.Text = "You sit at a table and wait."
        '
        'btnAccept
        '
        Me.btnAccept.Enabled = False
        Me.btnAccept.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccept.Location = New System.Drawing.Point(60, 170)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(150, 30)
        Me.btnAccept.TabIndex = 0
        Me.btnAccept.Text = "&Accept"
        Me.btnAccept.UseVisualStyleBackColor = True
        '
        'btnDecline
        '
        Me.btnDecline.Enabled = False
        Me.btnDecline.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDecline.Location = New System.Drawing.Point(216, 170)
        Me.btnDecline.Name = "btnDecline"
        Me.btnDecline.Size = New System.Drawing.Size(150, 30)
        Me.btnDecline.TabIndex = 1
        Me.btnDecline.Text = "&Decline"
        Me.btnDecline.UseVisualStyleBackColor = True
        '
        'btnLeave
        '
        Me.btnLeave.Enabled = False
        Me.btnLeave.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLeave.Location = New System.Drawing.Point(138, 206)
        Me.btnLeave.Name = "btnLeave"
        Me.btnLeave.Size = New System.Drawing.Size(150, 30)
        Me.btnLeave.TabIndex = 2
        Me.btnLeave.Text = "&Leave Table"
        Me.btnLeave.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'frmJobs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnLeave
        Me.ClientSize = New System.Drawing.Size(426, 247)
        Me.Controls.Add(Me.btnLeave)
        Me.Controls.Add(Me.btnDecline)
        Me.Controls.Add(Me.btnAccept)
        Me.Controls.Add(Me.txtJobs)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(442, 286)
        Me.MinimumSize = New System.Drawing.Size(442, 286)
        Me.Name = "frmJobs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Job Opportunities"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents txtJobs As System.Windows.Forms.TextBox
    Friend WithEvents btnAccept As System.Windows.Forms.Button
    Friend WithEvents btnDecline As System.Windows.Forms.Button
    Friend WithEvents btnLeave As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
