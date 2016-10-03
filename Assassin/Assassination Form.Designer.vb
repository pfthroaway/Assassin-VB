<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAssassinate
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
        Me.txtAssassinate = New System.Windows.Forms.TextBox()
        Me.btnAssassinate = New System.Windows.Forms.Button()
        Me.btnNewVictim = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtAssassinate
        '
        Me.txtAssassinate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAssassinate.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAssassinate.Location = New System.Drawing.Point(12, 12)
        Me.txtAssassinate.MaximumSize = New System.Drawing.Size(308, 150)
        Me.txtAssassinate.MinimumSize = New System.Drawing.Size(308, 150)
        Me.txtAssassinate.Multiline = True
        Me.txtAssassinate.Name = "txtAssassinate"
        Me.txtAssassinate.ReadOnly = True
        Me.txtAssassinate.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAssassinate.Size = New System.Drawing.Size(308, 150)
        Me.txtAssassinate.TabIndex = 0
        Me.txtAssassinate.Text = "You look around for potential targets."
        '
        'btnAssassinate
        '
        Me.btnAssassinate.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAssassinate.Location = New System.Drawing.Point(91, 169)
        Me.btnAssassinate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAssassinate.Name = "btnAssassinate"
        Me.btnAssassinate.Size = New System.Drawing.Size(150, 30)
        Me.btnAssassinate.TabIndex = 1
        Me.btnAssassinate.Text = "&Assassinate"
        Me.btnAssassinate.UseVisualStyleBackColor = True
        '
        'btnNewVictim
        '
        Me.btnNewVictim.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewVictim.Location = New System.Drawing.Point(13, 207)
        Me.btnNewVictim.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNewVictim.Name = "btnNewVictim"
        Me.btnNewVictim.Size = New System.Drawing.Size(150, 30)
        Me.btnNewVictim.TabIndex = 3
        Me.btnNewVictim.Text = "&Stalk New Victim"
        Me.btnNewVictim.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNewVictim.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBack.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(171, 207)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(150, 30)
        Me.btnBack.TabIndex = 4
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'frmAssassinate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnBack
        Me.ClientSize = New System.Drawing.Size(332, 249)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnNewVictim)
        Me.Controls.Add(Me.btnAssassinate)
        Me.Controls.Add(Me.txtAssassinate)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(348, 288)
        Me.MinimumSize = New System.Drawing.Size(348, 288)
        Me.Name = "frmAssassinate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Assassination"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtAssassinate As System.Windows.Forms.TextBox
    Friend WithEvents btnAssassinate As System.Windows.Forms.Button
    Friend WithEvents btnNewVictim As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
End Class
