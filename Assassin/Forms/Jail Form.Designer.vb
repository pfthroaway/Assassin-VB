Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

Namespace Forms
    <DesignerGenerated()> _
    Partial Class FrmJail
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
            Me.LstJailed = New ListBox()
            Me.Label1 = New Label()
            Me.LblReason = New Label()
            Me.LblFine = New Label()
            Me.Label3 = New Label()
            Me.BtnBack = New Button()
            Me.BtnBailOut = New Button()
            Me.SuspendLayout()
            '
            'LstJailed
            '
            Me.LstJailed.FormattingEnabled = True
            Me.LstJailed.ItemHeight = 18
            Me.LstJailed.Location = New Point(13, 13)
            Me.LstJailed.Name = "LstJailed"
            Me.LstJailed.Size = New Size(200, 184)
            Me.LstJailed.TabIndex = 0
            '
            'Label1
            '
            Me.Label1.BorderStyle = BorderStyle.FixedSingle
            Me.Label1.Location = New Point(219, 13)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New Size(150, 25)
            Me.Label1.TabIndex = 1
            Me.Label1.Text = "Reason Jailed:"
            Me.Label1.TextAlign = ContentAlignment.MiddleCenter
            '
            'LblReason
            '
            Me.LblReason.BorderStyle = BorderStyle.FixedSingle
            Me.LblReason.Location = New Point(219, 37)
            Me.LblReason.Name = "LblReason"
            Me.LblReason.Size = New Size(150, 25)
            Me.LblReason.TabIndex = 2
            Me.LblReason.TextAlign = ContentAlignment.MiddleCenter
            '
            'LblFine
            '
            Me.LblFine.BorderStyle = BorderStyle.FixedSingle
            Me.LblFine.Location = New Point(219, 95)
            Me.LblFine.Name = "LblFine"
            Me.LblFine.Size = New Size(150, 25)
            Me.LblFine.TabIndex = 4
            Me.LblFine.TextAlign = ContentAlignment.MiddleCenter
            '
            'Label3
            '
            Me.Label3.BorderStyle = BorderStyle.FixedSingle
            Me.Label3.Location = New Point(219, 71)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New Size(150, 25)
            Me.Label3.TabIndex = 3
            Me.Label3.Text = "Fine:"
            Me.Label3.TextAlign = ContentAlignment.MiddleCenter
            '
            'BtnBack
            '
            Me.BtnBack.DialogResult = DialogResult.Cancel
            Me.BtnBack.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnBack.Location = New Point(219, 167)
            Me.BtnBack.Name = "BtnBack"
            Me.BtnBack.Size = New Size(150, 30)
            Me.BtnBack.TabIndex = 15
            Me.BtnBack.Text = "E&xit"
            Me.BtnBack.UseVisualStyleBackColor = True
            '
            'BtnBailOut
            '
            Me.BtnBailOut.Enabled = False
            Me.BtnBailOut.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnBailOut.Location = New Point(219, 131)
            Me.BtnBailOut.Name = "BtnBailOut"
            Me.BtnBailOut.Size = New Size(150, 30)
            Me.BtnBailOut.TabIndex = 16
            Me.BtnBailOut.Text = "&Bail Out"
            Me.BtnBailOut.UseVisualStyleBackColor = True
            '
            'frmJail
            '
            Me.AutoScaleDimensions = New SizeF(9.0!, 18.0!)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.CancelButton = Me.BtnBack
            Me.ClientSize = New Size(381, 208)
            Me.Controls.Add(Me.BtnBailOut)
            Me.Controls.Add(Me.BtnBack)
            Me.Controls.Add(Me.LblFine)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.LblReason)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.LstJailed)
            Me.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Margin = New Padding(4)
            Me.MaximizeBox = False
            Me.MaximumSize = New Size(397, 247)
            Me.MinimumSize = New Size(397, 247)
            Me.Name = "frmJail"
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.Text = "Jail"
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents LstJailed As ListBox
        Friend WithEvents Label1 As Label
        Friend WithEvents LblReason As Label
        Friend WithEvents LblFine As Label
        Friend WithEvents Label3 As Label
        Friend WithEvents BtnBack As Button
        Friend WithEvents BtnBailOut As Button
    End Class
End NameSpace