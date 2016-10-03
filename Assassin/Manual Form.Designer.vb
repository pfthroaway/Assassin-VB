<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManual
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
        Me.txtManual = New System.Windows.Forms.TextBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnIntro = New System.Windows.Forms.Button()
        Me.btnSkills = New System.Windows.Forms.Button()
        Me.btnCity = New System.Windows.Forms.Button()
        Me.btnPlaying = New System.Windows.Forms.Button()
        Me.btnCombat = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtManual
        '
        Me.txtManual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtManual.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtManual.Location = New System.Drawing.Point(12, 12)
        Me.txtManual.Multiline = True
        Me.txtManual.Name = "txtManual"
        Me.txtManual.ReadOnly = True
        Me.txtManual.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtManual.Size = New System.Drawing.Size(550, 350)
        Me.txtManual.TabIndex = 0
        '
        'btnBack
        '
        Me.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBack.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(569, 332)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(150, 30)
        Me.btnBack.TabIndex = 6
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnIntro
        '
        Me.btnIntro.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIntro.Location = New System.Drawing.Point(569, 13)
        Me.btnIntro.Margin = New System.Windows.Forms.Padding(4)
        Me.btnIntro.Name = "btnIntro"
        Me.btnIntro.Size = New System.Drawing.Size(150, 30)
        Me.btnIntro.TabIndex = 1
        Me.btnIntro.Text = "&Introduction"
        Me.btnIntro.UseVisualStyleBackColor = True
        '
        'btnSkills
        '
        Me.btnSkills.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSkills.Location = New System.Drawing.Point(569, 140)
        Me.btnSkills.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSkills.Name = "btnSkills"
        Me.btnSkills.Size = New System.Drawing.Size(150, 30)
        Me.btnSkills.TabIndex = 3
        Me.btnSkills.Text = "&Skills"
        Me.btnSkills.UseVisualStyleBackColor = True
        '
        'btnCity
        '
        Me.btnCity.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCity.Location = New System.Drawing.Point(569, 77)
        Me.btnCity.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCity.Name = "btnCity"
        Me.btnCity.Size = New System.Drawing.Size(150, 30)
        Me.btnCity.TabIndex = 2
        Me.btnCity.Text = "&The City"
        Me.btnCity.UseVisualStyleBackColor = True
        '
        'btnPlaying
        '
        Me.btnPlaying.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlaying.Location = New System.Drawing.Point(569, 203)
        Me.btnPlaying.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPlaying.Name = "btnPlaying"
        Me.btnPlaying.Size = New System.Drawing.Size(150, 30)
        Me.btnPlaying.TabIndex = 4
        Me.btnPlaying.Text = "&Playing"
        Me.btnPlaying.UseVisualStyleBackColor = True
        '
        'btnCombat
        '
        Me.btnCombat.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCombat.Location = New System.Drawing.Point(569, 266)
        Me.btnCombat.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCombat.Name = "btnCombat"
        Me.btnCombat.Size = New System.Drawing.Size(150, 30)
        Me.btnCombat.TabIndex = 5
        Me.btnCombat.Text = "&Combat"
        Me.btnCombat.UseVisualStyleBackColor = True
        '
        'frmManual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnBack
        Me.ClientSize = New System.Drawing.Size(732, 374)
        Me.Controls.Add(Me.btnCombat)
        Me.Controls.Add(Me.btnPlaying)
        Me.Controls.Add(Me.btnCity)
        Me.Controls.Add(Me.btnSkills)
        Me.Controls.Add(Me.btnIntro)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.txtManual)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(748, 413)
        Me.MinimumSize = New System.Drawing.Size(748, 413)
        Me.Name = "frmManual"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manual"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtManual As System.Windows.Forms.TextBox
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnIntro As System.Windows.Forms.Button
    Friend WithEvents btnSkills As System.Windows.Forms.Button
    Friend WithEvents btnCity As System.Windows.Forms.Button
    Friend WithEvents btnPlaying As System.Windows.Forms.Button
    Friend WithEvents btnCombat As System.Windows.Forms.Button
End Class
