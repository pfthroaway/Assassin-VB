Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

Namespace Forms.GuildForms
    <DesignerGenerated()> _
    Partial Class FrmGuildOptions
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
            Me.TxtName = New System.Windows.Forms.TextBox()
            Me.LblName = New System.Windows.Forms.Label()
            Me.BtnExit = New System.Windows.Forms.Button()
            Me.BtnSave = New System.Windows.Forms.Button()
            Me.TxtEntranceFee = New System.Windows.Forms.TextBox()
            Me.LblFee = New System.Windows.Forms.Label()
            Me.CmbGuildmaster = New System.Windows.Forms.ComboBox()
            Me.LblGuildmaster = New System.Windows.Forms.Label()
            Me.TxtOptions = New System.Windows.Forms.TextBox()
            Me.SuspendLayout()
            '
            'TxtName
            '
            Me.TxtName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TxtName.Location = New System.Drawing.Point(146, 168)
            Me.TxtName.Margin = New System.Windows.Forms.Padding(4)
            Me.TxtName.MaxLength = 30
            Me.TxtName.Name = "TxtName"
            Me.TxtName.Size = New System.Drawing.Size(200, 26)
            Me.TxtName.TabIndex = 19
            Me.TxtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'LblName
            '
            Me.LblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblName.Location = New System.Drawing.Point(13, 168)
            Me.LblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.LblName.Name = "LblName"
            Me.LblName.Size = New System.Drawing.Size(125, 26)
            Me.LblName.TabIndex = 20
            Me.LblName.Text = "Guild Name:"
            Me.LblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'BtnExit
            '
            Me.BtnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.BtnExit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnExit.Location = New System.Drawing.Point(117, 311)
            Me.BtnExit.Margin = New System.Windows.Forms.Padding(4)
            Me.BtnExit.Name = "BtnExit"
            Me.BtnExit.Size = New System.Drawing.Size(125, 30)
            Me.BtnExit.TabIndex = 21
            Me.BtnExit.Text = "E&xit"
            Me.BtnExit.UseVisualStyleBackColor = True
            '
            'BtnSave
            '
            Me.BtnSave.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnSave.Location = New System.Drawing.Point(117, 273)
            Me.BtnSave.Margin = New System.Windows.Forms.Padding(4)
            Me.BtnSave.Name = "BtnSave"
            Me.BtnSave.Size = New System.Drawing.Size(125, 30)
            Me.BtnSave.TabIndex = 22
            Me.BtnSave.Text = "&Save"
            Me.BtnSave.UseVisualStyleBackColor = True
            '
            'TxtEntranceFee
            '
            Me.TxtEntranceFee.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TxtEntranceFee.Location = New System.Drawing.Point(146, 203)
            Me.TxtEntranceFee.Margin = New System.Windows.Forms.Padding(4)
            Me.TxtEntranceFee.MaxLength = 4
            Me.TxtEntranceFee.Name = "TxtEntranceFee"
            Me.TxtEntranceFee.Size = New System.Drawing.Size(60, 26)
            Me.TxtEntranceFee.TabIndex = 23
            Me.TxtEntranceFee.Text = "4444"
            Me.TxtEntranceFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'LblFee
            '
            Me.LblFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblFee.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblFee.Location = New System.Drawing.Point(13, 203)
            Me.LblFee.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.LblFee.Name = "LblFee"
            Me.LblFee.Size = New System.Drawing.Size(125, 26)
            Me.LblFee.TabIndex = 24
            Me.LblFee.Text = "Entrance Fee:"
            Me.LblFee.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'CmbGuildmaster
            '
            Me.CmbGuildmaster.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.CmbGuildmaster.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CmbGuildmaster.FormattingEnabled = True
            Me.CmbGuildmaster.Location = New System.Drawing.Point(145, 238)
            Me.CmbGuildmaster.Name = "CmbGuildmaster"
            Me.CmbGuildmaster.Size = New System.Drawing.Size(201, 26)
            Me.CmbGuildmaster.TabIndex = 25
            '
            'LblGuildmaster
            '
            Me.LblGuildmaster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblGuildmaster.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblGuildmaster.Location = New System.Drawing.Point(13, 238)
            Me.LblGuildmaster.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.LblGuildmaster.Name = "LblGuildmaster"
            Me.LblGuildmaster.Size = New System.Drawing.Size(125, 26)
            Me.LblGuildmaster.TabIndex = 26
            Me.LblGuildmaster.Text = "Guildmaster:"
            Me.LblGuildmaster.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'TxtOptions
            '
            Me.TxtOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.TxtOptions.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TxtOptions.Location = New System.Drawing.Point(13, 13)
            Me.TxtOptions.Margin = New System.Windows.Forms.Padding(4)
            Me.TxtOptions.Multiline = True
            Me.TxtOptions.Name = "TxtOptions"
            Me.TxtOptions.ReadOnly = True
            Me.TxtOptions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.TxtOptions.Size = New System.Drawing.Size(333, 147)
            Me.TxtOptions.TabIndex = 27
            Me.TxtOptions.Text = "What would you like to change?"
            '
            'FrmGuildOptions
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(359, 354)
            Me.Controls.Add(Me.TxtOptions)
            Me.Controls.Add(Me.CmbGuildmaster)
            Me.Controls.Add(Me.LblGuildmaster)
            Me.Controls.Add(Me.TxtEntranceFee)
            Me.Controls.Add(Me.LblFee)
            Me.Controls.Add(Me.BtnSave)
            Me.Controls.Add(Me.BtnExit)
            Me.Controls.Add(Me.TxtName)
            Me.Controls.Add(Me.LblName)
            Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Margin = New System.Windows.Forms.Padding(4)
            Me.MaximizeBox = False
            Me.Name = "FrmGuildOptions"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Guild Options"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents TxtName As TextBox
        Friend WithEvents LblName As Label
        Friend WithEvents BtnExit As Button
        Friend WithEvents BtnSave As Button
        Friend WithEvents TxtEntranceFee As TextBox
        Friend WithEvents LblFee As Label
        Friend WithEvents CmbGuildmaster As ComboBox
        Friend WithEvents LblGuildmaster As Label
        Friend WithEvents TxtOptions As TextBox
    End Class
End NameSpace