Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

Namespace Forms
    <DesignerGenerated()> _
    Partial Class FrmHelp
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
            Me.txtHelp = New TextBox()
            Me.btnBack = New Button()
            Me.SuspendLayout()
            '
            'txtHelp
            '
            Me.txtHelp.BorderStyle = BorderStyle.FixedSingle
            Me.txtHelp.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.txtHelp.Location = New Point(13, 13)
            Me.txtHelp.Margin = New Padding(4)
            Me.txtHelp.Multiline = True
            Me.txtHelp.Name = "txtHelp"
            Me.txtHelp.ReadOnly = True
            Me.txtHelp.ScrollBars = ScrollBars.Vertical
            Me.txtHelp.Size = New Size(558, 282)
            Me.txtHelp.TabIndex = 15
            '
            'btnBack
            '
            Me.btnBack.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnBack.Location = New Point(217, 302)
            Me.btnBack.Name = "btnBack"
            Me.btnBack.Size = New Size(150, 30)
            Me.btnBack.TabIndex = 16
            Me.btnBack.Text = "&Back"
            Me.btnBack.UseVisualStyleBackColor = True
            '
            'frmHelp
            '
            Me.AutoScaleDimensions = New SizeF(9.0!, 18.0!)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.ClientSize = New Size(584, 344)
            Me.Controls.Add(Me.btnBack)
            Me.Controls.Add(Me.txtHelp)
            Me.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Margin = New Padding(4)
            Me.Name = "frmHelp"
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.Text = "Help"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents TxtHelp As TextBox
        Friend WithEvents BtnBack As Button
    End Class
End NameSpace