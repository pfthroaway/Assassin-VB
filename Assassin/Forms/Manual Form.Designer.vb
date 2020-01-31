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
            Me.btnBack = New Button()
            Me.btnIntro = New Button()
            Me.btnSkills = New Button()
            Me.btnCity = New Button()
            Me.btnPlaying = New Button()
            Me.btnCombat = New Button()
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
            'btnBack
            '
            Me.btnBack.DialogResult = DialogResult.Cancel
            Me.btnBack.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnBack.Location = New Point(569, 332)
            Me.btnBack.Margin = New Padding(4)
            Me.btnBack.Name = "btnBack"
            Me.btnBack.Size = New Size(150, 30)
            Me.btnBack.TabIndex = 6
            Me.btnBack.Text = "&Back"
            Me.btnBack.UseVisualStyleBackColor = True
            '
            'btnIntro
            '
            Me.btnIntro.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnIntro.Location = New Point(569, 13)
            Me.btnIntro.Margin = New Padding(4)
            Me.btnIntro.Name = "btnIntro"
            Me.btnIntro.Size = New Size(150, 30)
            Me.btnIntro.TabIndex = 1
            Me.btnIntro.Text = "&Introduction"
            Me.btnIntro.UseVisualStyleBackColor = True
            '
            'btnSkills
            '
            Me.btnSkills.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnSkills.Location = New Point(569, 140)
            Me.btnSkills.Margin = New Padding(4)
            Me.btnSkills.Name = "btnSkills"
            Me.btnSkills.Size = New Size(150, 30)
            Me.btnSkills.TabIndex = 3
            Me.btnSkills.Text = "&Skills"
            Me.btnSkills.UseVisualStyleBackColor = True
            '
            'btnCity
            '
            Me.btnCity.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnCity.Location = New Point(569, 77)
            Me.btnCity.Margin = New Padding(4)
            Me.btnCity.Name = "btnCity"
            Me.btnCity.Size = New Size(150, 30)
            Me.btnCity.TabIndex = 2
            Me.btnCity.Text = "&The City"
            Me.btnCity.UseVisualStyleBackColor = True
            '
            'btnPlaying
            '
            Me.btnPlaying.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnPlaying.Location = New Point(569, 203)
            Me.btnPlaying.Margin = New Padding(4)
            Me.btnPlaying.Name = "btnPlaying"
            Me.btnPlaying.Size = New Size(150, 30)
            Me.btnPlaying.TabIndex = 4
            Me.btnPlaying.Text = "&Playing"
            Me.btnPlaying.UseVisualStyleBackColor = True
            '
            'btnCombat
            '
            Me.btnCombat.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnCombat.Location = New Point(569, 266)
            Me.btnCombat.Margin = New Padding(4)
            Me.btnCombat.Name = "btnCombat"
            Me.btnCombat.Size = New Size(150, 30)
            Me.btnCombat.TabIndex = 5
            Me.btnCombat.Text = "&Combat"
            Me.btnCombat.UseVisualStyleBackColor = True
            '
            'frmManual
            '
            Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.CancelButton = Me.btnBack
            Me.ClientSize = New Size(732, 374)
            Me.Controls.Add(Me.btnCombat)
            Me.Controls.Add(Me.btnPlaying)
            Me.Controls.Add(Me.btnCity)
            Me.Controls.Add(Me.btnSkills)
            Me.Controls.Add(Me.btnIntro)
            Me.Controls.Add(Me.btnBack)
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