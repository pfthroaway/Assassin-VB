Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

Namespace Forms
    <DesignerGenerated()> _
    Partial Class FrmAssassinate
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
            Me.txtAssassinate = New TextBox()
            Me.btnAssassinate = New Button()
            Me.btnNewVictim = New Button()
            Me.btnBack = New Button()
            Me.SuspendLayout()
            '
            'txtAssassinate
            '
            Me.txtAssassinate.BorderStyle = BorderStyle.FixedSingle
            Me.txtAssassinate.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.txtAssassinate.Location = New Point(12, 12)
            Me.txtAssassinate.MaximumSize = New Size(308, 150)
            Me.txtAssassinate.MinimumSize = New Size(308, 150)
            Me.txtAssassinate.Multiline = True
            Me.txtAssassinate.Name = "txtAssassinate"
            Me.txtAssassinate.ReadOnly = True
            Me.txtAssassinate.ScrollBars = ScrollBars.Vertical
            Me.txtAssassinate.Size = New Size(308, 150)
            Me.txtAssassinate.TabIndex = 0
            Me.txtAssassinate.Text = "You look around for potential targets."
            '
            'btnAssassinate
            '
            Me.btnAssassinate.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnAssassinate.Location = New Point(91, 169)
            Me.btnAssassinate.Margin = New Padding(4)
            Me.btnAssassinate.Name = "btnAssassinate"
            Me.btnAssassinate.Size = New Size(150, 30)
            Me.btnAssassinate.TabIndex = 1
            Me.btnAssassinate.Text = "&Assassinate"
            Me.btnAssassinate.UseVisualStyleBackColor = True
            '
            'btnNewVictim
            '
            Me.btnNewVictim.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnNewVictim.Location = New Point(13, 207)
            Me.btnNewVictim.Margin = New Padding(4)
            Me.btnNewVictim.Name = "btnNewVictim"
            Me.btnNewVictim.Size = New Size(150, 30)
            Me.btnNewVictim.TabIndex = 3
            Me.btnNewVictim.Text = "&Stalk New Victim"
            Me.btnNewVictim.TextAlign = ContentAlignment.MiddleRight
            Me.btnNewVictim.UseVisualStyleBackColor = True
            '
            'btnBack
            '
            Me.btnBack.DialogResult = DialogResult.Cancel
            Me.btnBack.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnBack.Location = New Point(171, 207)
            Me.btnBack.Margin = New Padding(4)
            Me.btnBack.Name = "btnBack"
            Me.btnBack.Size = New Size(150, 30)
            Me.btnBack.TabIndex = 4
            Me.btnBack.Text = "&Back"
            Me.btnBack.UseVisualStyleBackColor = True
            '
            'frmAssassinate
            '
            Me.AutoScaleDimensions = New SizeF(7.0!, 16.0!)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.CancelButton = Me.btnBack
            Me.ClientSize = New Size(332, 249)
            Me.Controls.Add(Me.btnBack)
            Me.Controls.Add(Me.btnNewVictim)
            Me.Controls.Add(Me.btnAssassinate)
            Me.Controls.Add(Me.txtAssassinate)
            Me.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Margin = New Padding(3, 4, 3, 4)
            Me.MaximizeBox = False
            Me.MaximumSize = New Size(348, 288)
            Me.MinimumSize = New Size(348, 288)
            Me.Name = "frmAssassinate"
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.Text = "Assassination"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents TxtAssassinate As TextBox
        Friend WithEvents BtnAssassinate As Button
        Friend WithEvents BtnNewVictim As Button
        Friend WithEvents BtnBack As Button
    End Class
End NameSpace