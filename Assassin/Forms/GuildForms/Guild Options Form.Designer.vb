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
            Me.lblName = New Label()
            Me.btnExit = New Button()
            Me.btnSave = New Button()
            Me.txtEntranceFee = New TextBox()
            Me.lblFee = New Label()
            Me.cmbGuildmaster = New ComboBox()
            Me.lblGuildmaster = New Label()
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
            'lblName
            '
            Me.lblName.BorderStyle = BorderStyle.FixedSingle
            Me.lblName.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblName.Location = New Point(13, 168)
            Me.lblName.Margin = New Padding(4, 0, 4, 0)
            Me.lblName.Name = "lblName"
            Me.lblName.Size = New Size(125, 26)
            Me.lblName.TabIndex = 20
            Me.lblName.Text = "Guild Name:"
            Me.lblName.TextAlign = ContentAlignment.MiddleRight
            '
            'btnExit
            '
            Me.btnExit.DialogResult = DialogResult.Cancel
            Me.btnExit.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnExit.Location = New Point(117, 311)
            Me.btnExit.Margin = New Padding(4)
            Me.btnExit.Name = "btnExit"
            Me.btnExit.Size = New Size(125, 30)
            Me.btnExit.TabIndex = 21
            Me.btnExit.Text = "E&xit"
            Me.btnExit.UseVisualStyleBackColor = True
            '
            'btnSave
            '
            Me.btnSave.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnSave.Location = New Point(117, 273)
            Me.btnSave.Margin = New Padding(4)
            Me.btnSave.Name = "btnSave"
            Me.btnSave.Size = New Size(125, 30)
            Me.btnSave.TabIndex = 22
            Me.btnSave.Text = "&Save"
            Me.btnSave.UseVisualStyleBackColor = True
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
            'lblFee
            '
            Me.lblFee.BorderStyle = BorderStyle.FixedSingle
            Me.lblFee.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblFee.Location = New Point(13, 203)
            Me.lblFee.Margin = New Padding(4, 0, 4, 0)
            Me.lblFee.Name = "lblFee"
            Me.lblFee.Size = New Size(125, 26)
            Me.lblFee.TabIndex = 24
            Me.lblFee.Text = "Entrance Fee:"
            Me.lblFee.TextAlign = ContentAlignment.MiddleRight
            '
            'cmbGuildmaster
            '
            Me.cmbGuildmaster.DropDownStyle = ComboBoxStyle.DropDownList
            Me.cmbGuildmaster.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.cmbGuildmaster.FormattingEnabled = True
            Me.cmbGuildmaster.Items.AddRange(New Object() {"Computer"})
            Me.cmbGuildmaster.Location = New Point(145, 238)
            Me.cmbGuildmaster.Name = "cmbGuildmaster"
            Me.cmbGuildmaster.Size = New Size(201, 26)
            Me.cmbGuildmaster.TabIndex = 25
            '
            'lblGuildmaster
            '
            Me.lblGuildmaster.BorderStyle = BorderStyle.FixedSingle
            Me.lblGuildmaster.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblGuildmaster.Location = New Point(13, 238)
            Me.lblGuildmaster.Margin = New Padding(4, 0, 4, 0)
            Me.lblGuildmaster.Name = "lblGuildmaster"
            Me.lblGuildmaster.Size = New Size(125, 26)
            Me.lblGuildmaster.TabIndex = 26
            Me.lblGuildmaster.Text = "Guildmaster:"
            Me.lblGuildmaster.TextAlign = ContentAlignment.MiddleRight
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
            Me.Controls.Add(Me.cmbGuildmaster)
            Me.Controls.Add(Me.lblGuildmaster)
            Me.Controls.Add(Me.txtEntranceFee)
            Me.Controls.Add(Me.lblFee)
            Me.Controls.Add(Me.btnSave)
            Me.Controls.Add(Me.btnExit)
            Me.Controls.Add(Me.txtName)
            Me.Controls.Add(Me.lblName)
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
        Friend WithEvents lblName As Label
        Friend WithEvents BtnExit As Button
        Friend WithEvents BtnSave As Button
        Friend WithEvents TxtEntranceFee As TextBox
        Friend WithEvents lblFee As Label
        Friend WithEvents CmbGuildmaster As ComboBox
        Friend WithEvents lblGuildmaster As Label
        Friend WithEvents TxtOptions As TextBox
    End Class
End NameSpace