Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

Namespace Forms
    <DesignerGenerated()> _
    Partial Class FrmManual
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
            Me.txtManual = New TextBox()
            Me.BtnBack = New Button()
            Me.BtnIntro = New Button()
            Me.BtnSkills = New Button()
            Me.BtnCity = New Button()
            Me.BtnPlaying = New Button()
            Me.BtnCombat = New Button()
            Me.SuspendLayout()
            '
            'txtManual
            '
            Me.txtManual.BorderStyle = BorderStyle.FixedSingle
            Me.txtManual.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.txtManual.Location = New Point(12, 12)
            Me.txtManual.Multiline = True
            Me.txtManual.Name = "txtManual"
            Me.txtManual.ReadOnly = True
            Me.txtManual.ScrollBars = ScrollBars.Vertical
            Me.txtManual.Size = New Size(550, 350)
            Me.txtManual.TabIndex = 0
            '
            'BtnBack
            '
            Me.BtnBack.DialogResult = DialogResult.Cancel
            Me.BtnBack.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnBack.Location = New Point(569, 332)
            Me.BtnBack.Margin = New Padding(4)
            Me.BtnBack.Name = "BtnBack"
            Me.BtnBack.Size = New Size(150, 30)
            Me.BtnBack.TabIndex = 6
            Me.BtnBack.Text = "&Back"
            Me.BtnBack.UseVisualStyleBackColor = True
            '
            'BtnIntro
            '
            Me.BtnIntro.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnIntro.Location = New Point(569, 13)
            Me.BtnIntro.Margin = New Padding(4)
            Me.BtnIntro.Name = "BtnIntro"
            Me.BtnIntro.Size = New Size(150, 30)
            Me.BtnIntro.TabIndex = 1
            Me.BtnIntro.Text = "&Introduction"
            Me.BtnIntro.UseVisualStyleBackColor = True
            '
            'BtnSkills
            '
            Me.BtnSkills.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnSkills.Location = New Point(569, 140)
            Me.BtnSkills.Margin = New Padding(4)
            Me.BtnSkills.Name = "BtnSkills"
            Me.BtnSkills.Size = New Size(150, 30)
            Me.BtnSkills.TabIndex = 3
            Me.BtnSkills.Text = "&Skills"
            Me.BtnSkills.UseVisualStyleBackColor = True
            '
            'BtnCity
            '
            Me.BtnCity.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnCity.Location = New Point(569, 77)
            Me.BtnCity.Margin = New Padding(4)
            Me.BtnCity.Name = "BtnCity"
            Me.BtnCity.Size = New Size(150, 30)
            Me.BtnCity.TabIndex = 2
            Me.BtnCity.Text = "&The City"
            Me.BtnCity.UseVisualStyleBackColor = True
            '
            'BtnPlaying
            '
            Me.BtnPlaying.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnPlaying.Location = New Point(569, 203)
            Me.BtnPlaying.Margin = New Padding(4)
            Me.BtnPlaying.Name = "BtnPlaying"
            Me.BtnPlaying.Size = New Size(150, 30)
            Me.BtnPlaying.TabIndex = 4
            Me.BtnPlaying.Text = "&Playing"
            Me.BtnPlaying.UseVisualStyleBackColor = True
            '
            'BtnCombat
            '
            Me.BtnCombat.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnCombat.Location = New Point(569, 266)
            Me.BtnCombat.Margin = New Padding(4)
            Me.BtnCombat.Name = "BtnCombat"
            Me.BtnCombat.Size = New Size(150, 30)
            Me.BtnCombat.TabIndex = 5
            Me.BtnCombat.Text = "&Combat"
            Me.BtnCombat.UseVisualStyleBackColor = True
            '
            'frmManual
            '
            Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.CancelButton = Me.BtnBack
            Me.ClientSize = New Size(732, 374)
            Me.Controls.Add(Me.BtnCombat)
            Me.Controls.Add(Me.BtnPlaying)
            Me.Controls.Add(Me.BtnCity)
            Me.Controls.Add(Me.BtnSkills)
            Me.Controls.Add(Me.BtnIntro)
            Me.Controls.Add(Me.BtnBack)
            Me.Controls.Add(Me.txtManual)
            Me.MaximizeBox = False
            Me.MaximumSize = New Size(748, 413)
            Me.MinimumSize = New Size(748, 413)
            Me.Name = "frmManual"
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.Text = "Manual"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents TxtManual As TextBox
        Friend WithEvents BtnBack As Button
        Friend WithEvents BtnIntro As Button
        Friend WithEvents BtnSkills As Button
        Friend WithEvents BtnCity As Button
        Friend WithEvents BtnPlaying As Button
        Friend WithEvents BtnCombat As Button
    End Class
End NameSpace