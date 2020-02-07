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
            Me.BtnAssassinate = New Button()
            Me.BtnNewVictim = New Button()
            Me.BtnBack = New Button()
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
            'BtnAssassinate
            '
            Me.BtnAssassinate.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnAssassinate.Location = New Point(91, 169)
            Me.BtnAssassinate.Margin = New Padding(4)
            Me.BtnAssassinate.Name = "BtnAssassinate"
            Me.BtnAssassinate.Size = New Size(150, 30)
            Me.BtnAssassinate.TabIndex = 1
            Me.BtnAssassinate.Text = "&Assassinate"
            Me.BtnAssassinate.UseVisualStyleBackColor = True
            '
            'BtnNewVictim
            '
            Me.BtnNewVictim.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnNewVictim.Location = New Point(13, 207)
            Me.BtnNewVictim.Margin = New Padding(4)
            Me.BtnNewVictim.Name = "BtnNewVictim"
            Me.BtnNewVictim.Size = New Size(150, 30)
            Me.BtnNewVictim.TabIndex = 3
            Me.BtnNewVictim.Text = "&Stalk New Victim"
            Me.BtnNewVictim.TextAlign = ContentAlignment.MiddleRight
            Me.BtnNewVictim.UseVisualStyleBackColor = True
            '
            'BtnBack
            '
            Me.BtnBack.DialogResult = DialogResult.Cancel
            Me.BtnBack.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnBack.Location = New Point(171, 207)
            Me.BtnBack.Margin = New Padding(4)
            Me.BtnBack.Name = "BtnBack"
            Me.BtnBack.Size = New Size(150, 30)
            Me.BtnBack.TabIndex = 4
            Me.BtnBack.Text = "&Back"
            Me.BtnBack.UseVisualStyleBackColor = True
            '
            'frmAssassinate
            '
            Me.AutoScaleDimensions = New SizeF(7.0!, 16.0!)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.CancelButton = Me.BtnBack
            Me.ClientSize = New Size(332, 249)
            Me.Controls.Add(Me.BtnBack)
            Me.Controls.Add(Me.BtnNewVictim)
            Me.Controls.Add(Me.BtnAssassinate)
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