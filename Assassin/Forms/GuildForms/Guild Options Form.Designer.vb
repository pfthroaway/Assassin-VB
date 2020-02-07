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
            Me.txtName = New TextBox()
            Me.LblName = New Label()
            Me.BtnExit = New Button()
            Me.BtnSave = New Button()
            Me.txtEntranceFee = New TextBox()
            Me.LblFee = New Label()
            Me.CmbGuildmaster = New ComboBox()
            Me.LblGuildmaster = New Label()
            Me.txtOptions = New TextBox()
            Me.SuspendLayout()
            '
            'txtName
            '
            Me.txtName.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.txtName.Location = New Point(146, 168)
            Me.txtName.Margin = New Padding(4)
            Me.txtName.MaxLength = 30
            Me.txtName.Name = "txtName"
            Me.txtName.Size = New Size(200, 26)
            Me.txtName.TabIndex = 19
            Me.txtName.TextAlign = HorizontalAlignment.Center
            '
            'LblName
            '
            Me.LblName.BorderStyle = BorderStyle.FixedSingle
            Me.LblName.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.LblName.Location = New Point(13, 168)
            Me.LblName.Margin = New Padding(4, 0, 4, 0)
            Me.LblName.Name = "LblName"
            Me.LblName.Size = New Size(125, 26)
            Me.LblName.TabIndex = 20
            Me.LblName.Text = "Guild Name:"
            Me.LblName.TextAlign = ContentAlignment.MiddleRight
            '
            'BtnExit
            '
            Me.BtnExit.DialogResult = DialogResult.Cancel
            Me.BtnExit.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnExit.Location = New Point(117, 311)
            Me.BtnExit.Margin = New Padding(4)
            Me.BtnExit.Name = "BtnExit"
            Me.BtnExit.Size = New Size(125, 30)
            Me.BtnExit.TabIndex = 21
            Me.BtnExit.Text = "E&xit"
            Me.BtnExit.UseVisualStyleBackColor = True
            '
            'BtnSave
            '
            Me.BtnSave.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnSave.Location = New Point(117, 273)
            Me.BtnSave.Margin = New Padding(4)
            Me.BtnSave.Name = "BtnSave"
            Me.BtnSave.Size = New Size(125, 30)
            Me.BtnSave.TabIndex = 22
            Me.BtnSave.Text = "&Save"
            Me.BtnSave.UseVisualStyleBackColor = True
            '
            'txtEntranceFee
            '
            Me.txtEntranceFee.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.txtEntranceFee.Location = New Point(146, 203)
            Me.txtEntranceFee.Margin = New Padding(4)
            Me.txtEntranceFee.MaxLength = 4
            Me.txtEntranceFee.Name = "txtEntranceFee"
            Me.txtEntranceFee.Size = New Size(60, 26)
            Me.txtEntranceFee.TabIndex = 23
            Me.txtEntranceFee.Text = "4444"
            Me.txtEntranceFee.TextAlign = HorizontalAlignment.Center
            '
            'LblFee
            '
            Me.LblFee.BorderStyle = BorderStyle.FixedSingle
            Me.LblFee.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.LblFee.Location = New Point(13, 203)
            Me.LblFee.Margin = New Padding(4, 0, 4, 0)
            Me.LblFee.Name = "LblFee"
            Me.LblFee.Size = New Size(125, 26)
            Me.LblFee.TabIndex = 24
            Me.LblFee.Text = "Entrance Fee:"
            Me.LblFee.TextAlign = ContentAlignment.MiddleRight
            '
            'CmbGuildmaster
            '
            Me.CmbGuildmaster.DropDownStyle = ComboBoxStyle.DropDownList
            Me.CmbGuildmaster.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.CmbGuildmaster.FormattingEnabled = True
            Me.CmbGuildmaster.Items.AddRange(New Object() {"Computer"})
            Me.CmbGuildmaster.Location = New Point(145, 238)
            Me.CmbGuildmaster.Name = "CmbGuildmaster"
            Me.CmbGuildmaster.Size = New Size(201, 26)
            Me.CmbGuildmaster.TabIndex = 25
            '
            'LblGuildmaster
            '
            Me.LblGuildmaster.BorderStyle = BorderStyle.FixedSingle
            Me.LblGuildmaster.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.LblGuildmaster.Location = New Point(13, 238)
            Me.LblGuildmaster.Margin = New Padding(4, 0, 4, 0)
            Me.LblGuildmaster.Name = "LblGuildmaster"
            Me.LblGuildmaster.Size = New Size(125, 26)
            Me.LblGuildmaster.TabIndex = 26
            Me.LblGuildmaster.Text = "Guildmaster:"
            Me.LblGuildmaster.TextAlign = ContentAlignment.MiddleRight
            '
            'txtOptions
            '
            Me.txtOptions.BorderStyle = BorderStyle.FixedSingle
            Me.txtOptions.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.txtOptions.Location = New Point(13, 13)
            Me.txtOptions.Margin = New Padding(4)
            Me.txtOptions.Multiline = True
            Me.txtOptions.Name = "txtOptions"
            Me.txtOptions.ReadOnly = True
            Me.txtOptions.ScrollBars = ScrollBars.Vertical
            Me.txtOptions.Size = New Size(333, 147)
            Me.txtOptions.TabIndex = 27
            Me.txtOptions.Text = "What would you like to change?"
            '
            'frmGuildOptions
            '
            Me.AutoScaleDimensions = New SizeF(9.0!, 18.0!)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.ClientSize = New Size(359, 354)
            Me.Controls.Add(Me.txtOptions)
            Me.Controls.Add(Me.CmbGuildmaster)
            Me.Controls.Add(Me.LblGuildmaster)
            Me.Controls.Add(Me.txtEntranceFee)
            Me.Controls.Add(Me.LblFee)
            Me.Controls.Add(Me.BtnSave)
            Me.Controls.Add(Me.BtnExit)
            Me.Controls.Add(Me.txtName)
            Me.Controls.Add(Me.LblName)
            Me.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Margin = New Padding(4)
            Me.MaximizeBox = False
            Me.Name = "frmGuildOptions"
            Me.StartPosition = FormStartPosition.CenterScreen
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