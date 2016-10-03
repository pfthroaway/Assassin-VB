<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRaid
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
        Me.cmbRaid = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtHench1 = New System.Windows.Forms.TextBox()
        Me.txtMax1 = New System.Windows.Forms.TextBox()
        Me.txtMax2 = New System.Windows.Forms.TextBox()
        Me.txtHench2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMax3 = New System.Windows.Forms.TextBox()
        Me.txtHench3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMax4 = New System.Windows.Forms.TextBox()
        Me.txtHench4 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMax5 = New System.Windows.Forms.TextBox()
        Me.txtHench5 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnRaid = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.txtRaid = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmbRaid
        '
        Me.cmbRaid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRaid.FormattingEnabled = True
        Me.cmbRaid.Location = New System.Drawing.Point(42, 43)
        Me.cmbRaid.Name = "cmbRaid"
        Me.cmbRaid.Size = New System.Drawing.Size(200, 26)
        Me.cmbRaid.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(42, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 25)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Who would you like to raid?"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(42, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(200, 40)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "How many henchmen do you want to send?"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(42, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 25)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Level 1:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtHench1
        '
        Me.txtHench1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHench1.Location = New System.Drawing.Point(123, 131)
        Me.txtHench1.MaxLength = 3
        Me.txtHench1.Name = "txtHench1"
        Me.txtHench1.Size = New System.Drawing.Size(50, 26)
        Me.txtHench1.TabIndex = 1
        Me.txtHench1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMax1
        '
        Me.txtMax1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.txtMax1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMax1.Location = New System.Drawing.Point(179, 131)
        Me.txtMax1.MaxLength = 3
        Me.txtMax1.Name = "txtMax1"
        Me.txtMax1.ReadOnly = True
        Me.txtMax1.Size = New System.Drawing.Size(50, 26)
        Me.txtMax1.TabIndex = 2
        Me.txtMax1.TabStop = False
        Me.txtMax1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMax2
        '
        Me.txtMax2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.txtMax2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMax2.Location = New System.Drawing.Point(179, 165)
        Me.txtMax2.MaxLength = 3
        Me.txtMax2.Name = "txtMax2"
        Me.txtMax2.ReadOnly = True
        Me.txtMax2.Size = New System.Drawing.Size(50, 26)
        Me.txtMax2.TabIndex = 4
        Me.txtMax2.TabStop = False
        Me.txtMax2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtHench2
        '
        Me.txtHench2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHench2.Location = New System.Drawing.Point(123, 165)
        Me.txtHench2.MaxLength = 3
        Me.txtHench2.Name = "txtHench2"
        Me.txtHench2.Size = New System.Drawing.Size(50, 26)
        Me.txtHench2.TabIndex = 3
        Me.txtHench2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(42, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 25)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Level 2:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMax3
        '
        Me.txtMax3.BackColor = System.Drawing.SystemColors.ControlDark
        Me.txtMax3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMax3.Location = New System.Drawing.Point(179, 199)
        Me.txtMax3.MaxLength = 3
        Me.txtMax3.Name = "txtMax3"
        Me.txtMax3.ReadOnly = True
        Me.txtMax3.Size = New System.Drawing.Size(50, 26)
        Me.txtMax3.TabIndex = 6
        Me.txtMax3.TabStop = False
        Me.txtMax3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtHench3
        '
        Me.txtHench3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHench3.Location = New System.Drawing.Point(123, 199)
        Me.txtHench3.MaxLength = 3
        Me.txtHench3.Name = "txtHench3"
        Me.txtHench3.Size = New System.Drawing.Size(50, 26)
        Me.txtHench3.TabIndex = 5
        Me.txtHench3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(42, 199)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 25)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Level 3:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMax4
        '
        Me.txtMax4.BackColor = System.Drawing.SystemColors.ControlDark
        Me.txtMax4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMax4.Location = New System.Drawing.Point(179, 233)
        Me.txtMax4.MaxLength = 3
        Me.txtMax4.Name = "txtMax4"
        Me.txtMax4.ReadOnly = True
        Me.txtMax4.Size = New System.Drawing.Size(50, 26)
        Me.txtMax4.TabIndex = 8
        Me.txtMax4.TabStop = False
        Me.txtMax4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtHench4
        '
        Me.txtHench4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHench4.Location = New System.Drawing.Point(123, 233)
        Me.txtHench4.MaxLength = 3
        Me.txtHench4.Name = "txtHench4"
        Me.txtHench4.Size = New System.Drawing.Size(50, 26)
        Me.txtHench4.TabIndex = 7
        Me.txtHench4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(42, 233)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 25)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Level 4:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMax5
        '
        Me.txtMax5.BackColor = System.Drawing.SystemColors.ControlDark
        Me.txtMax5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMax5.Location = New System.Drawing.Point(179, 267)
        Me.txtMax5.MaxLength = 3
        Me.txtMax5.Name = "txtMax5"
        Me.txtMax5.ReadOnly = True
        Me.txtMax5.Size = New System.Drawing.Size(50, 26)
        Me.txtMax5.TabIndex = 10
        Me.txtMax5.TabStop = False
        Me.txtMax5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtHench5
        '
        Me.txtHench5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHench5.Location = New System.Drawing.Point(123, 267)
        Me.txtHench5.MaxLength = 3
        Me.txtHench5.Name = "txtHench5"
        Me.txtHench5.Size = New System.Drawing.Size(50, 26)
        Me.txtHench5.TabIndex = 9
        Me.txtHench5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(42, 267)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 25)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Level 5:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRaid
        '
        Me.btnRaid.Enabled = False
        Me.btnRaid.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRaid.Location = New System.Drawing.Point(39, 302)
        Me.btnRaid.Name = "btnRaid"
        Me.btnRaid.Size = New System.Drawing.Size(100, 30)
        Me.btnRaid.TabIndex = 11
        Me.btnRaid.Text = "&Raid"
        Me.btnRaid.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(145, 302)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 30)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBack.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(94, 338)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(100, 30)
        Me.btnBack.TabIndex = 13
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'txtRaid
        '
        Me.txtRaid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRaid.Location = New System.Drawing.Point(273, 17)
        Me.txtRaid.Multiline = True
        Me.txtRaid.Name = "txtRaid"
        Me.txtRaid.Size = New System.Drawing.Size(340, 351)
        Me.txtRaid.TabIndex = 21
        '
        'frmRaid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnBack
        Me.ClientSize = New System.Drawing.Size(625, 379)
        Me.Controls.Add(Me.txtRaid)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnRaid)
        Me.Controls.Add(Me.txtMax5)
        Me.Controls.Add(Me.txtHench5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtMax4)
        Me.Controls.Add(Me.txtHench4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtMax3)
        Me.Controls.Add(Me.txtHench3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtMax2)
        Me.Controls.Add(Me.txtHench2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtMax1)
        Me.Controls.Add(Me.txtHench1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbRaid)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(641, 418)
        Me.MinimumSize = New System.Drawing.Size(641, 418)
        Me.Name = "frmRaid"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Plan a Raid"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbRaid As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtHench1 As System.Windows.Forms.TextBox
    Friend WithEvents txtMax1 As System.Windows.Forms.TextBox
    Friend WithEvents txtMax2 As System.Windows.Forms.TextBox
    Friend WithEvents txtHench2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtMax3 As System.Windows.Forms.TextBox
    Friend WithEvents txtHench3 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtMax4 As System.Windows.Forms.TextBox
    Friend WithEvents txtHench4 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtMax5 As System.Windows.Forms.TextBox
    Friend WithEvents txtHench5 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnRaid As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents txtRaid As System.Windows.Forms.TextBox
End Class
