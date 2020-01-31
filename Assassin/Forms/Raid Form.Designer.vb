Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

Namespace Forms
    <DesignerGenerated()> _
    Partial Class FrmRaid
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
            Me.cmbRaid = New ComboBox()
            Me.Label1 = New Label()
            Me.Label2 = New Label()
            Me.Label3 = New Label()
            Me.txtHenchmenLevel1 = New TextBox()
            Me.txtMax1 = New TextBox()
            Me.txtMax2 = New TextBox()
            Me.txtHenchmenLevel2 = New TextBox()
            Me.Label4 = New Label()
            Me.txtMax3 = New TextBox()
            Me.txtHenchmenLevel3 = New TextBox()
            Me.Label5 = New Label()
            Me.txtMax4 = New TextBox()
            Me.txtHenchmenLevel4 = New TextBox()
            Me.Label6 = New Label()
            Me.txtMax5 = New TextBox()
            Me.txtHenchmenLevel5 = New TextBox()
            Me.Label7 = New Label()
            Me.btnRaid = New Button()
            Me.btnClear = New Button()
            Me.btnBack = New Button()
            Me.txtRaid = New TextBox()
            Me.SuspendLayout()
            '
            'cmbRaid
            '
            Me.cmbRaid.DropDownStyle = ComboBoxStyle.DropDownList
            Me.cmbRaid.FormattingEnabled = True
            Me.cmbRaid.Location = New Point(42, 43)
            Me.cmbRaid.Name = "cmbRaid"
            Me.cmbRaid.Size = New Size(200, 26)
            Me.cmbRaid.TabIndex = 0
            '
            'Label1
            '
            Me.Label1.Location = New Point(42, 13)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New Size(200, 25)
            Me.Label1.TabIndex = 14
            Me.Label1.Text = "Who would you like to raid?"
            Me.Label1.TextAlign = ContentAlignment.MiddleCenter
            '
            'Label2
            '
            Me.Label2.Location = New Point(42, 79)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New Size(200, 40)
            Me.Label2.TabIndex = 15
            Me.Label2.Text = "How many henchmen do you want to send?"
            Me.Label2.TextAlign = ContentAlignment.MiddleCenter
            '
            'Label3
            '
            Me.Label3.Location = New Point(42, 131)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New Size(75, 25)
            Me.Label3.TabIndex = 16
            Me.Label3.Text = "Level 1:"
            Me.Label3.TextAlign = ContentAlignment.MiddleCenter
            '
            'txtHenchmenLevel1
            '
            Me.txtHenchmenLevel1.BorderStyle = BorderStyle.FixedSingle
            Me.txtHenchmenLevel1.Location = New Point(123, 131)
            Me.txtHenchmenLevel1.MaxLength = 3
            Me.txtHenchmenLevel1.Name = "txtHenchmenLevel1"
            Me.txtHenchmenLevel1.Size = New Size(50, 26)
            Me.txtHenchmenLevel1.TabIndex = 1
            Me.txtHenchmenLevel1.TextAlign = HorizontalAlignment.Center
            '
            'txtMax1
            '
            Me.txtMax1.BackColor = SystemColors.ControlDark
            Me.txtMax1.BorderStyle = BorderStyle.FixedSingle
            Me.txtMax1.Location = New Point(179, 131)
            Me.txtMax1.MaxLength = 3
            Me.txtMax1.Name = "txtMax1"
            Me.txtMax1.ReadOnly = True
            Me.txtMax1.Size = New Size(50, 26)
            Me.txtMax1.TabIndex = 2
            Me.txtMax1.TabStop = False
            Me.txtMax1.TextAlign = HorizontalAlignment.Center
            '
            'txtMax2
            '
            Me.txtMax2.BackColor = SystemColors.ControlDark
            Me.txtMax2.BorderStyle = BorderStyle.FixedSingle
            Me.txtMax2.Location = New Point(179, 165)
            Me.txtMax2.MaxLength = 3
            Me.txtMax2.Name = "txtMax2"
            Me.txtMax2.ReadOnly = True
            Me.txtMax2.Size = New Size(50, 26)
            Me.txtMax2.TabIndex = 4
            Me.txtMax2.TabStop = False
            Me.txtMax2.TextAlign = HorizontalAlignment.Center
            '
            'txtHenchmenLevel2
            '
            Me.txtHenchmenLevel2.BorderStyle = BorderStyle.FixedSingle
            Me.txtHenchmenLevel2.Location = New Point(123, 165)
            Me.txtHenchmenLevel2.MaxLength = 3
            Me.txtHenchmenLevel2.Name = "txtHenchmenLevel2"
            Me.txtHenchmenLevel2.Size = New Size(50, 26)
            Me.txtHenchmenLevel2.TabIndex = 3
            Me.txtHenchmenLevel2.TextAlign = HorizontalAlignment.Center
            '
            'Label4
            '
            Me.Label4.Location = New Point(42, 165)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New Size(75, 25)
            Me.Label4.TabIndex = 17
            Me.Label4.Text = "Level 2:"
            Me.Label4.TextAlign = ContentAlignment.MiddleCenter
            '
            'txtMax3
            '
            Me.txtMax3.BackColor = SystemColors.ControlDark
            Me.txtMax3.BorderStyle = BorderStyle.FixedSingle
            Me.txtMax3.Location = New Point(179, 199)
            Me.txtMax3.MaxLength = 3
            Me.txtMax3.Name = "txtMax3"
            Me.txtMax3.ReadOnly = True
            Me.txtMax3.Size = New Size(50, 26)
            Me.txtMax3.TabIndex = 6
            Me.txtMax3.TabStop = False
            Me.txtMax3.TextAlign = HorizontalAlignment.Center
            '
            'txtHenchmenLevel3
            '
            Me.txtHenchmenLevel3.BorderStyle = BorderStyle.FixedSingle
            Me.txtHenchmenLevel3.Location = New Point(123, 199)
            Me.txtHenchmenLevel3.MaxLength = 3
            Me.txtHenchmenLevel3.Name = "txtHenchmenLevel3"
            Me.txtHenchmenLevel3.Size = New Size(50, 26)
            Me.txtHenchmenLevel3.TabIndex = 5
            Me.txtHenchmenLevel3.TextAlign = HorizontalAlignment.Center
            '
            'Label5
            '
            Me.Label5.Location = New Point(42, 199)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New Size(75, 25)
            Me.Label5.TabIndex = 18
            Me.Label5.Text = "Level 3:"
            Me.Label5.TextAlign = ContentAlignment.MiddleCenter
            '
            'txtMax4
            '
            Me.txtMax4.BackColor = SystemColors.ControlDark
            Me.txtMax4.BorderStyle = BorderStyle.FixedSingle
            Me.txtMax4.Location = New Point(179, 233)
            Me.txtMax4.MaxLength = 3
            Me.txtMax4.Name = "txtMax4"
            Me.txtMax4.ReadOnly = True
            Me.txtMax4.Size = New Size(50, 26)
            Me.txtMax4.TabIndex = 8
            Me.txtMax4.TabStop = False
            Me.txtMax4.TextAlign = HorizontalAlignment.Center
            '
            'txtHenchmenLevel4
            '
            Me.txtHenchmenLevel4.BorderStyle = BorderStyle.FixedSingle
            Me.txtHenchmenLevel4.Location = New Point(123, 233)
            Me.txtHenchmenLevel4.MaxLength = 3
            Me.txtHenchmenLevel4.Name = "txtHenchmenLevel4"
            Me.txtHenchmenLevel4.Size = New Size(50, 26)
            Me.txtHenchmenLevel4.TabIndex = 7
            Me.txtHenchmenLevel4.TextAlign = HorizontalAlignment.Center
            '
            'Label6
            '
            Me.Label6.Location = New Point(42, 233)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New Size(75, 25)
            Me.Label6.TabIndex = 19
            Me.Label6.Text = "Level 4:"
            Me.Label6.TextAlign = ContentAlignment.MiddleCenter
            '
            'txtMax5
            '
            Me.txtMax5.BackColor = SystemColors.ControlDark
            Me.txtMax5.BorderStyle = BorderStyle.FixedSingle
            Me.txtMax5.Location = New Point(179, 267)
            Me.txtMax5.MaxLength = 3
            Me.txtMax5.Name = "txtMax5"
            Me.txtMax5.ReadOnly = True
            Me.txtMax5.Size = New Size(50, 26)
            Me.txtMax5.TabIndex = 10
            Me.txtMax5.TabStop = False
            Me.txtMax5.TextAlign = HorizontalAlignment.Center
            '
            'txtHenchmenLevel5
            '
            Me.txtHenchmenLevel5.BorderStyle = BorderStyle.FixedSingle
            Me.txtHenchmenLevel5.Location = New Point(123, 267)
            Me.txtHenchmenLevel5.MaxLength = 3
            Me.txtHenchmenLevel5.Name = "txtHenchmenLevel5"
            Me.txtHenchmenLevel5.Size = New Size(50, 26)
            Me.txtHenchmenLevel5.TabIndex = 9
            Me.txtHenchmenLevel5.TextAlign = HorizontalAlignment.Center
            '
            'Label7
            '
            Me.Label7.Location = New Point(42, 267)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New Size(75, 25)
            Me.Label7.TabIndex = 20
            Me.Label7.Text = "Level 5:"
            Me.Label7.TextAlign = ContentAlignment.MiddleCenter
            '
            'btnRaid
            '
            Me.btnRaid.Enabled = False
            Me.btnRaid.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnRaid.Location = New Point(39, 302)
            Me.btnRaid.Name = "btnRaid"
            Me.btnRaid.Size = New Size(100, 30)
            Me.btnRaid.TabIndex = 11
            Me.btnRaid.Text = "&Raid"
            Me.btnRaid.UseVisualStyleBackColor = True
            '
            'btnClear
            '
            Me.btnClear.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnClear.Location = New Point(145, 302)
            Me.btnClear.Name = "btnClear"
            Me.btnClear.Size = New Size(100, 30)
            Me.btnClear.TabIndex = 12
            Me.btnClear.Text = "&Clear"
            Me.btnClear.UseVisualStyleBackColor = True
            '
            'btnBack
            '
            Me.btnBack.DialogResult = DialogResult.Cancel
            Me.btnBack.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnBack.Location = New Point(94, 338)
            Me.btnBack.Name = "btnBack"
            Me.btnBack.Size = New Size(100, 30)
            Me.btnBack.TabIndex = 13
            Me.btnBack.Text = "&Back"
            Me.btnBack.UseVisualStyleBackColor = True
            '
            'txtRaid
            '
            Me.txtRaid.BorderStyle = BorderStyle.FixedSingle
            Me.txtRaid.Location = New Point(273, 17)
            Me.txtRaid.Multiline = True
            Me.txtRaid.Name = "txtRaid"
            Me.txtRaid.Size = New Size(340, 351)
            Me.txtRaid.TabIndex = 21
            '
            'frmRaid
            '
            Me.AutoScaleDimensions = New SizeF(9.0!, 18.0!)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.CancelButton = Me.btnBack
            Me.ClientSize = New Size(625, 379)
            Me.Controls.Add(Me.txtRaid)
            Me.Controls.Add(Me.btnBack)
            Me.Controls.Add(Me.btnClear)
            Me.Controls.Add(Me.btnRaid)
            Me.Controls.Add(Me.txtMax5)
            Me.Controls.Add(Me.txtHenchmenLevel5)
            Me.Controls.Add(Me.Label7)
            Me.Controls.Add(Me.txtMax4)
            Me.Controls.Add(Me.txtHenchmenLevel4)
            Me.Controls.Add(Me.Label6)
            Me.Controls.Add(Me.txtMax3)
            Me.Controls.Add(Me.txtHenchmenLevel3)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.txtMax2)
            Me.Controls.Add(Me.txtHenchmenLevel2)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.txtMax1)
            Me.Controls.Add(Me.txtHenchmenLevel1)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.cmbRaid)
            Me.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Margin = New Padding(4)
            Me.MaximizeBox = False
            Me.MaximumSize = New Size(641, 418)
            Me.MinimumSize = New Size(641, 418)
            Me.Name = "frmRaid"
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.Text = "Plan a Raid"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents CmbRaid As ComboBox
        Friend WithEvents Label1 As Label
        Friend WithEvents Label2 As Label
        Friend WithEvents Label3 As Label
        Friend WithEvents TxtHenchmenLevel1 As TextBox
        Friend WithEvents TxtMax1 As TextBox
        Friend WithEvents TxtMax2 As TextBox
        Friend WithEvents TxtHenchmenLevel2 As TextBox
        Friend WithEvents Label4 As Label
        Friend WithEvents TxtMax3 As TextBox
        Friend WithEvents TxtHenchmenLevel3 As TextBox
        Friend WithEvents Label5 As Label
        Friend WithEvents TxtMax4 As TextBox
        Friend WithEvents TxtHenchmenLevel4 As TextBox
        Friend WithEvents Label6 As Label
        Friend WithEvents TxtMax5 As TextBox
        Friend WithEvents TxtHenchmenLevel5 As TextBox
        Friend WithEvents Label7 As Label
        Friend WithEvents BtnRaid As Button
        Friend WithEvents BtnClear As Button
        Friend WithEvents BtnBack As Button
        Friend WithEvents TxtRaid As TextBox
    End Class
End NameSpace