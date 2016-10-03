<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJail
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
        Me.lstJailed = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblReason = New System.Windows.Forms.Label()
        Me.lblFine = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnBailOut = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstJailed
        '
        Me.lstJailed.FormattingEnabled = True
        Me.lstJailed.ItemHeight = 18
        Me.lstJailed.Location = New System.Drawing.Point(13, 13)
        Me.lstJailed.Name = "lstJailed"
        Me.lstJailed.Size = New System.Drawing.Size(200, 184)
        Me.lstJailed.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(219, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Reason Jailed:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblReason
        '
        Me.lblReason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblReason.Location = New System.Drawing.Point(219, 37)
        Me.lblReason.Name = "lblReason"
        Me.lblReason.Size = New System.Drawing.Size(150, 25)
        Me.lblReason.TabIndex = 2
        Me.lblReason.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFine
        '
        Me.lblFine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFine.Location = New System.Drawing.Point(219, 95)
        Me.lblFine.Name = "lblFine"
        Me.lblFine.Size = New System.Drawing.Size(150, 25)
        Me.lblFine.TabIndex = 4
        Me.lblFine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(219, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Fine:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBack
        '
        Me.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBack.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(219, 167)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(150, 30)
        Me.btnBack.TabIndex = 15
        Me.btnBack.Text = "E&xit"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnBailOut
        '
        Me.btnBailOut.Enabled = False
        Me.btnBailOut.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBailOut.Location = New System.Drawing.Point(219, 131)
        Me.btnBailOut.Name = "btnBailOut"
        Me.btnBailOut.Size = New System.Drawing.Size(150, 30)
        Me.btnBailOut.TabIndex = 16
        Me.btnBailOut.Text = "&Bail Out"
        Me.btnBailOut.UseVisualStyleBackColor = True
        '
        'frmJail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnBack
        Me.ClientSize = New System.Drawing.Size(381, 208)
        Me.Controls.Add(Me.btnBailOut)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblFine)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblReason)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstJailed)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(397, 247)
        Me.MinimumSize = New System.Drawing.Size(397, 247)
        Me.Name = "frmJail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Jail"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstJailed As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblReason As System.Windows.Forms.Label
    Friend WithEvents lblFine As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnBailOut As System.Windows.Forms.Button
End Class
