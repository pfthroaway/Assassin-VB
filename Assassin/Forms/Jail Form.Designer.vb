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
            Me.lstJailed = New ListBox()
            Me.Label1 = New Label()
            Me.lblReason = New Label()
            Me.lblFine = New Label()
            Me.Label3 = New Label()
            Me.btnBack = New Button()
            Me.btnBailOut = New Button()
            Me.SuspendLayout()
            '
            'lstJailed
            '
            Me.lstJailed.FormattingEnabled = True
            Me.lstJailed.ItemHeight = 18
            Me.lstJailed.Location = New Point(13, 13)
            Me.lstJailed.Name = "lstJailed"
            Me.lstJailed.Size = New Size(200, 184)
            Me.lstJailed.TabIndex = 0
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
            'lblReason
            '
            Me.lblReason.BorderStyle = BorderStyle.FixedSingle
            Me.lblReason.Location = New Point(219, 37)
            Me.lblReason.Name = "lblReason"
            Me.lblReason.Size = New Size(150, 25)
            Me.lblReason.TabIndex = 2
            Me.lblReason.TextAlign = ContentAlignment.MiddleCenter
            '
            'lblFine
            '
            Me.lblFine.BorderStyle = BorderStyle.FixedSingle
            Me.lblFine.Location = New Point(219, 95)
            Me.lblFine.Name = "lblFine"
            Me.lblFine.Size = New Size(150, 25)
            Me.lblFine.TabIndex = 4
            Me.lblFine.TextAlign = ContentAlignment.MiddleCenter
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
            'btnBack
            '
            Me.btnBack.DialogResult = DialogResult.Cancel
            Me.btnBack.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnBack.Location = New Point(219, 167)
            Me.btnBack.Name = "btnBack"
            Me.btnBack.Size = New Size(150, 30)
            Me.btnBack.TabIndex = 15
            Me.btnBack.Text = "E&xit"
            Me.btnBack.UseVisualStyleBackColor = True
            '
            'btnBailOut
            '
            Me.btnBailOut.Enabled = False
            Me.btnBailOut.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnBailOut.Location = New Point(219, 131)
            Me.btnBailOut.Name = "btnBailOut"
            Me.btnBailOut.Size = New Size(150, 30)
            Me.btnBailOut.TabIndex = 16
            Me.btnBailOut.Text = "&Bail Out"
            Me.btnBailOut.UseVisualStyleBackColor = True
            '
            'frmJail
            '
            Me.AutoScaleDimensions = New SizeF(9.0!, 18.0!)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.CancelButton = Me.btnBack
            Me.ClientSize = New Size(381, 208)
            Me.Controls.Add(Me.btnBailOut)
            Me.Controls.Add(Me.btnBack)
            Me.Controls.Add(Me.lblFine)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.lblReason)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.lstJailed)
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
        Friend WithEvents lblReason As Label
        Friend WithEvents lblFine As Label
        Friend WithEvents Label3 As Label
        Friend WithEvents BtnBack As Button
        Friend WithEvents BtnBailOut As Button
    End Class
End NameSpace