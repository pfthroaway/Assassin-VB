Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

Namespace Forms
    <DesignerGenerated()> _
    Partial Class FrmMain
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPswd = New System.Windows.Forms.Label()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.TxtPswd = New System.Windows.Forms.TextBox()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.mnu = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAdmin = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpManual = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnNewUser = New System.Windows.Forms.Button()
        Me.mnu.SuspendLayout
        Me.SuspendLayout
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Viner Hand ITC", 24!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblTitle.Location = New System.Drawing.Point(50, 35)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(150, 45)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Text = "Assassin"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUsername
        '
        Me.lblUsername.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblUsername.Location = New System.Drawing.Point(12, 80)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(226, 25)
        Me.lblUsername.TabIndex = 5
        Me.lblUsername.Text = "Username:"
        Me.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPswd
        '
        Me.lblPswd.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblPswd.Location = New System.Drawing.Point(58, 145)
        Me.lblPswd.Name = "lblPswd"
        Me.lblPswd.Size = New System.Drawing.Size(105, 25)
        Me.lblPswd.TabIndex = 6
        Me.lblPswd.Text = "Password:"
        Me.lblPswd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtUsername
        '
        Me.TxtUsername.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TxtUsername.Location = New System.Drawing.Point(12, 108)
        Me.TxtUsername.MaxLength = 30
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(226, 33)
        Me.TxtUsername.TabIndex = 0
        Me.TxtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtPswd
        '
        Me.TxtPswd.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TxtPswd.Location = New System.Drawing.Point(12, 173)
        Me.TxtPswd.MaxLength = 15
        Me.TxtPswd.Name = "TxtPswd"
        Me.TxtPswd.Size = New System.Drawing.Size(226, 33)
        Me.TxtPswd.TabIndex = 1
        Me.TxtPswd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtPswd.UseSystemPasswordChar = true
        '
        'BtnLogin
        '
        Me.BtnLogin.Enabled = false
        Me.BtnLogin.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.BtnLogin.Location = New System.Drawing.Point(12, 220)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(100, 40)
        Me.BtnLogin.TabIndex = 2
        Me.BtnLogin.Text = "&Log In"
        Me.BtnLogin.UseVisualStyleBackColor = true
        '
        'mnu
        '
        Me.mnu.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.mnu.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.mnu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuAdmin, Me.mnuHelp})
        Me.mnu.Location = New System.Drawing.Point(0, 0)
        Me.mnu.Name = "mnu"
        Me.mnu.Size = New System.Drawing.Size(250, 33)
        Me.mnu.TabIndex = 6
        Me.mnu.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileExit})
        Me.mnuFile.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(54, 29)
        Me.mnuFile.Text = "&File"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.Size = New System.Drawing.Size(116, 30)
        Me.mnuFileExit.Text = "E&xit"
        '
        'mnuAdmin
        '
        Me.mnuAdmin.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.mnuAdmin.Name = "mnuAdmin"
        Me.mnuAdmin.Size = New System.Drawing.Size(81, 29)
        Me.mnuAdmin.Text = "&Admin"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelpManual, Me.mnuHelpAbout})
        Me.mnuHelp.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(64, 29)
        Me.mnuHelp.Text = "&Help"
        '
        'mnuHelpManual
        '
        Me.mnuHelpManual.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.mnuHelpManual.Name = "mnuHelpManual"
        Me.mnuHelpManual.Size = New System.Drawing.Size(149, 30)
        Me.mnuHelpManual.Text = "&Manual"
        '
        'mnuHelpAbout
        '
        Me.mnuHelpAbout.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.mnuHelpAbout.Name = "mnuHelpAbout"
        Me.mnuHelpAbout.Size = New System.Drawing.Size(149, 30)
        Me.mnuHelpAbout.Text = "A&bout"
        '
        'BtnNewUser
        '
        Me.BtnNewUser.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.BtnNewUser.Location = New System.Drawing.Point(113, 220)
        Me.BtnNewUser.Name = "BtnNewUser"
        Me.BtnNewUser.Size = New System.Drawing.Size(125, 40)
        Me.BtnNewUser.TabIndex = 3
        Me.BtnNewUser.Text = "&New User"
        Me.BtnNewUser.UseVisualStyleBackColor = true
        '
        'FrmMain
        '
        Me.AcceptButton = Me.BtnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9!, 18!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(250, 278)
        Me.Controls.Add(Me.BtnNewUser)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.TxtPswd)
        Me.Controls.Add(Me.TxtUsername)
        Me.Controls.Add(Me.lblPswd)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.mnu)
        Me.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.MainMenuStrip = Me.mnu
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = false
        Me.MinimumSize = New System.Drawing.Size(223, 300)
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Assassin"
        Me.mnu.ResumeLayout(false)
        Me.mnu.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
        Friend WithEvents lblTitle As Label
        Friend WithEvents lblUsername As Label
        Friend WithEvents lblPswd As Label
        Friend WithEvents TxtUsername As TextBox
        Friend WithEvents TxtPswd As TextBox
        Friend WithEvents BtnLogin As Button
        Friend WithEvents mnu As MenuStrip
        Friend WithEvents mnuFile As ToolStripMenuItem
        Friend WithEvents mnuFileExit As ToolStripMenuItem
        Friend WithEvents mnuAdmin As ToolStripMenuItem
        Friend WithEvents mnuHelp As ToolStripMenuItem
        Friend WithEvents BtnNewUser As Button
        Friend WithEvents mnuHelpManual As ToolStripMenuItem
        Friend WithEvents mnuHelpAbout As ToolStripMenuItem

    End Class
End NameSpace