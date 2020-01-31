Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

Namespace Forms.GuildForms
    <DesignerGenerated()> _
    Partial Class FrmGuildDonate
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
            Me.Label9 = New Label()
            Me.Label2 = New Label()
            Me.txtDonate5 = New TextBox()
            Me.txtDonate4 = New TextBox()
            Me.txtDonate3 = New TextBox()
            Me.txtDonate2 = New TextBox()
            Me.txtDonate1 = New TextBox()
            Me.txtHenchmenLevel5 = New TextBox()
            Me.Label7 = New Label()
            Me.txtHenchmenLevel4 = New TextBox()
            Me.Label6 = New Label()
            Me.txtHenchmenLevel3 = New TextBox()
            Me.Label5 = New Label()
            Me.txtHenchmenLevel2 = New TextBox()
            Me.Label4 = New Label()
            Me.txtHenchmenLevel1 = New TextBox()
            Me.Label3 = New Label()
            Me.txtDonate = New TextBox()
            Me.lblDonate = New Label()
            Me.btnBack = New Button()
            Me.btnClear = New Button()
            Me.btnDonate = New Button()
            Me.txtDonateGold = New TextBox()
            Me.txtGold = New TextBox()
            Me.Label1 = New Label()
            Me.SuspendLayout()
            '
            'Label9
            '
            Me.Label9.Location = New Point(196, 43)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New Size(70, 25)
            Me.Label9.TabIndex = 53
            Me.Label9.Text = "Donate:"
            Me.Label9.TextAlign = ContentAlignment.MiddleCenter
            '
            'Label2
            '
            Me.Label2.Location = New Point(120, 43)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New Size(70, 25)
            Me.Label2.TabIndex = 52
            Me.Label2.Text = "Current:"
            Me.Label2.TextAlign = ContentAlignment.MiddleCenter
            '
            'txtDonate5
            '
            Me.txtDonate5.BorderStyle = BorderStyle.FixedSingle
            Me.txtDonate5.Location = New Point(197, 237)
            Me.txtDonate5.MaxLength = 3
            Me.txtDonate5.Name = "txtDonate5"
            Me.txtDonate5.Size = New Size(60, 26)
            Me.txtDonate5.TabIndex = 4
            Me.txtDonate5.TextAlign = HorizontalAlignment.Center
            '
            'txtDonate4
            '
            Me.txtDonate4.BorderStyle = BorderStyle.FixedSingle
            Me.txtDonate4.Location = New Point(197, 197)
            Me.txtDonate4.MaxLength = 3
            Me.txtDonate4.Name = "txtDonate4"
            Me.txtDonate4.Size = New Size(60, 26)
            Me.txtDonate4.TabIndex = 3
            Me.txtDonate4.TextAlign = HorizontalAlignment.Center
            '
            'txtDonate3
            '
            Me.txtDonate3.BorderStyle = BorderStyle.FixedSingle
            Me.txtDonate3.Location = New Point(199, 157)
            Me.txtDonate3.MaxLength = 3
            Me.txtDonate3.Name = "txtDonate3"
            Me.txtDonate3.Size = New Size(60, 26)
            Me.txtDonate3.TabIndex = 2
            Me.txtDonate3.TextAlign = HorizontalAlignment.Center
            '
            'txtDonate2
            '
            Me.txtDonate2.BorderStyle = BorderStyle.FixedSingle
            Me.txtDonate2.Location = New Point(199, 117)
            Me.txtDonate2.MaxLength = 3
            Me.txtDonate2.Name = "txtDonate2"
            Me.txtDonate2.Size = New Size(60, 26)
            Me.txtDonate2.TabIndex = 1
            Me.txtDonate2.TextAlign = HorizontalAlignment.Center
            '
            'txtDonate1
            '
            Me.txtDonate1.BorderStyle = BorderStyle.FixedSingle
            Me.txtDonate1.Location = New Point(199, 77)
            Me.txtDonate1.MaxLength = 3
            Me.txtDonate1.Name = "txtDonate1"
            Me.txtDonate1.Size = New Size(60, 26)
            Me.txtDonate1.TabIndex = 0
            Me.txtDonate1.TextAlign = HorizontalAlignment.Center
            '
            'txtHenchmenLevel5
            '
            Me.txtHenchmenLevel5.BorderStyle = BorderStyle.FixedSingle
            Me.txtHenchmenLevel5.Location = New Point(123, 237)
            Me.txtHenchmenLevel5.MaxLength = 3
            Me.txtHenchmenLevel5.Name = "txtHenchmenLevel5"
            Me.txtHenchmenLevel5.ReadOnly = True
            Me.txtHenchmenLevel5.Size = New Size(60, 26)
            Me.txtHenchmenLevel5.TabIndex = 50
            Me.txtHenchmenLevel5.TextAlign = HorizontalAlignment.Center
            '
            'Label7
            '
            Me.Label7.Location = New Point(12, 228)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New Size(90, 40)
            Me.Label7.TabIndex = 58
            Me.Label7.Text = "Level 5 Henchmen:"
            Me.Label7.TextAlign = ContentAlignment.MiddleCenter
            '
            'txtHenchmenLevel4
            '
            Me.txtHenchmenLevel4.BorderStyle = BorderStyle.FixedSingle
            Me.txtHenchmenLevel4.Location = New Point(123, 197)
            Me.txtHenchmenLevel4.MaxLength = 3
            Me.txtHenchmenLevel4.Name = "txtHenchmenLevel4"
            Me.txtHenchmenLevel4.ReadOnly = True
            Me.txtHenchmenLevel4.Size = New Size(60, 26)
            Me.txtHenchmenLevel4.TabIndex = 48
            Me.txtHenchmenLevel4.TextAlign = HorizontalAlignment.Center
            '
            'Label6
            '
            Me.Label6.Location = New Point(12, 188)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New Size(90, 40)
            Me.Label6.TabIndex = 57
            Me.Label6.Text = "Level 4 Henchmen:"
            Me.Label6.TextAlign = ContentAlignment.MiddleCenter
            '
            'txtHenchmenLevel3
            '
            Me.txtHenchmenLevel3.BorderStyle = BorderStyle.FixedSingle
            Me.txtHenchmenLevel3.Location = New Point(123, 157)
            Me.txtHenchmenLevel3.MaxLength = 3
            Me.txtHenchmenLevel3.Name = "txtHenchmenLevel3"
            Me.txtHenchmenLevel3.ReadOnly = True
            Me.txtHenchmenLevel3.Size = New Size(60, 26)
            Me.txtHenchmenLevel3.TabIndex = 46
            Me.txtHenchmenLevel3.TextAlign = HorizontalAlignment.Center
            '
            'Label5
            '
            Me.Label5.Location = New Point(12, 148)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New Size(90, 40)
            Me.Label5.TabIndex = 56
            Me.Label5.Text = "Level 3 Henchmen:"
            Me.Label5.TextAlign = ContentAlignment.MiddleCenter
            '
            'txtHenchmenLevel2
            '
            Me.txtHenchmenLevel2.BorderStyle = BorderStyle.FixedSingle
            Me.txtHenchmenLevel2.Location = New Point(123, 117)
            Me.txtHenchmenLevel2.MaxLength = 3
            Me.txtHenchmenLevel2.Name = "txtHenchmenLevel2"
            Me.txtHenchmenLevel2.ReadOnly = True
            Me.txtHenchmenLevel2.Size = New Size(60, 26)
            Me.txtHenchmenLevel2.TabIndex = 44
            Me.txtHenchmenLevel2.TextAlign = HorizontalAlignment.Center
            '
            'Label4
            '
            Me.Label4.Location = New Point(12, 108)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New Size(90, 40)
            Me.Label4.TabIndex = 55
            Me.Label4.Text = "Level 2 Henchmen:"
            Me.Label4.TextAlign = ContentAlignment.MiddleCenter
            '
            'txtHenchmenLevel1
            '
            Me.txtHenchmenLevel1.BorderStyle = BorderStyle.FixedSingle
            Me.txtHenchmenLevel1.Location = New Point(123, 77)
            Me.txtHenchmenLevel1.MaxLength = 3
            Me.txtHenchmenLevel1.Name = "txtHenchmenLevel1"
            Me.txtHenchmenLevel1.ReadOnly = True
            Me.txtHenchmenLevel1.Size = New Size(60, 26)
            Me.txtHenchmenLevel1.TabIndex = 42
            Me.txtHenchmenLevel1.TextAlign = HorizontalAlignment.Center
            '
            'Label3
            '
            Me.Label3.Location = New Point(12, 68)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New Size(90, 40)
            Me.Label3.TabIndex = 54
            Me.Label3.Text = "Level 1 Henchmen:"
            Me.Label3.TextAlign = ContentAlignment.MiddleCenter
            '
            'txtDonate
            '
            Me.txtDonate.BorderStyle = BorderStyle.FixedSingle
            Me.txtDonate.Location = New Point(265, 77)
            Me.txtDonate.Multiline = True
            Me.txtDonate.Name = "txtDonate"
            Me.txtDonate.ReadOnly = True
            Me.txtDonate.Size = New Size(300, 300)
            Me.txtDonate.TabIndex = 9
            Me.txtDonate.Text = "What would you like to donate?"
            '
            'lblDonate
            '
            Me.lblDonate.Font = New Font("Arial", 15.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblDonate.Location = New Point(17, 3)
            Me.lblDonate.Name = "lblDonate"
            Me.lblDonate.Size = New Size(548, 40)
            Me.lblDonate.TabIndex = 60
            Me.lblDonate.Text = "Donate"
            Me.lblDonate.TextAlign = ContentAlignment.MiddleCenter
            '
            'btnBack
            '
            Me.btnBack.DialogResult = DialogResult.Cancel
            Me.btnBack.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnBack.Location = New Point(83, 347)
            Me.btnBack.Name = "btnBack"
            Me.btnBack.Size = New Size(100, 30)
            Me.btnBack.TabIndex = 8
            Me.btnBack.Text = "&Back"
            Me.btnBack.UseVisualStyleBackColor = True
            '
            'btnClear
            '
            Me.btnClear.Enabled = False
            Me.btnClear.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnClear.Location = New Point(157, 311)
            Me.btnClear.Name = "btnClear"
            Me.btnClear.Size = New Size(100, 30)
            Me.btnClear.TabIndex = 7
            Me.btnClear.Text = "&Clear"
            Me.btnClear.UseVisualStyleBackColor = True
            '
            'btnDonate
            '
            Me.btnDonate.Enabled = False
            Me.btnDonate.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnDonate.Location = New Point(15, 311)
            Me.btnDonate.Name = "btnDonate"
            Me.btnDonate.Size = New Size(100, 30)
            Me.btnDonate.TabIndex = 6
            Me.btnDonate.Text = "&Donate"
            Me.btnDonate.UseVisualStyleBackColor = True
            '
            'txtDonateGold
            '
            Me.txtDonateGold.BorderStyle = BorderStyle.FixedSingle
            Me.txtDonateGold.Location = New Point(197, 277)
            Me.txtDonateGold.MaxLength = 6
            Me.txtDonateGold.Name = "txtDonateGold"
            Me.txtDonateGold.Size = New Size(60, 26)
            Me.txtDonateGold.TabIndex = 5
            Me.txtDonateGold.TextAlign = HorizontalAlignment.Center
            '
            'txtGold
            '
            Me.txtGold.BorderStyle = BorderStyle.FixedSingle
            Me.txtGold.Location = New Point(123, 277)
            Me.txtGold.MaxLength = 6
            Me.txtGold.Name = "txtGold"
            Me.txtGold.ReadOnly = True
            Me.txtGold.Size = New Size(60, 26)
            Me.txtGold.TabIndex = 64
            Me.txtGold.TextAlign = HorizontalAlignment.Center
            '
            'Label1
            '
            Me.Label1.Location = New Point(12, 268)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New Size(85, 40)
            Me.Label1.TabIndex = 66
            Me.Label1.Text = "Gold:"
            Me.Label1.TextAlign = ContentAlignment.MiddleCenter
            '
            'frmGuildDonate
            '
            Me.AutoScaleDimensions = New SizeF(9.0!, 18.0!)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.CancelButton = Me.btnBack
            Me.ClientSize = New Size(577, 388)
            Me.Controls.Add(Me.txtDonateGold)
            Me.Controls.Add(Me.txtGold)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.btnBack)
            Me.Controls.Add(Me.btnClear)
            Me.Controls.Add(Me.btnDonate)
            Me.Controls.Add(Me.txtDonate)
            Me.Controls.Add(Me.lblDonate)
            Me.Controls.Add(Me.Label9)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.txtDonate5)
            Me.Controls.Add(Me.txtDonate4)
            Me.Controls.Add(Me.txtDonate3)
            Me.Controls.Add(Me.txtDonate2)
            Me.Controls.Add(Me.txtDonate1)
            Me.Controls.Add(Me.txtHenchmenLevel5)
            Me.Controls.Add(Me.Label7)
            Me.Controls.Add(Me.txtHenchmenLevel4)
            Me.Controls.Add(Me.Label6)
            Me.Controls.Add(Me.txtHenchmenLevel3)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.txtHenchmenLevel2)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.txtHenchmenLevel1)
            Me.Controls.Add(Me.Label3)
            Me.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Margin = New Padding(4)
            Me.MaximizeBox = False
            Me.MaximumSize = New Size(593, 427)
            Me.MinimumSize = New Size(593, 427)
            Me.Name = "frmGuildDonate"
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.Text = "Donate"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents Label9 As Label
        Friend WithEvents Label2 As Label
        Friend WithEvents TxtDonate5 As TextBox
        Friend WithEvents TxtDonate4 As TextBox
        Friend WithEvents TxtDonate3 As TextBox
        Friend WithEvents TxtDonate2 As TextBox
        Friend WithEvents TxtDonate1 As TextBox
        Friend WithEvents TxtHenchmenLevel5 As TextBox
        Friend WithEvents Label7 As Label
        Friend WithEvents TxtHenchmenLevel4 As TextBox
        Friend WithEvents Label6 As Label
        Friend WithEvents TxtHenchmenLevel3 As TextBox
        Friend WithEvents Label5 As Label
        Friend WithEvents TxtHenchmenLevel2 As TextBox
        Friend WithEvents Label4 As Label
        Friend WithEvents TxtHenchmenLevel1 As TextBox
        Friend WithEvents Label3 As Label
        Friend WithEvents TxtDonate As TextBox
        Friend WithEvents lblDonate As Label
        Friend WithEvents BtnBack As Button
        Friend WithEvents BtnClear As Button
        Friend WithEvents BtnDonate As Button
        Friend WithEvents TxtDonateGold As TextBox
        Friend WithEvents TxtGold As TextBox
        Friend WithEvents Label1 As Label
    End Class
End NameSpace