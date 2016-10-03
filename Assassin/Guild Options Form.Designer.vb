<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGuildOptions
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
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtEntranceFee = New System.Windows.Forms.TextBox()
        Me.lblFee = New System.Windows.Forms.Label()
        Me.cmbGuildmaster = New System.Windows.Forms.ComboBox()
        Me.lblGuildmaster = New System.Windows.Forms.Label()
        Me.txtOptions = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(146, 168)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtName.MaxLength = 30
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(200, 26)
        Me.txtName.TabIndex = 19
        Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblName
        '
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(13, 168)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(125, 26)
        Me.lblName.TabIndex = 20
        Me.lblName.Text = "Guild Name:"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(117, 311)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(125, 30)
        Me.btnExit.TabIndex = 21
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(117, 273)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(125, 30)
        Me.btnSave.TabIndex = 22
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtEntranceFee
        '
        Me.txtEntranceFee.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEntranceFee.Location = New System.Drawing.Point(146, 203)
        Me.txtEntranceFee.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEntranceFee.MaxLength = 4
        Me.txtEntranceFee.Name = "txtEntranceFee"
        Me.txtEntranceFee.Size = New System.Drawing.Size(60, 26)
        Me.txtEntranceFee.TabIndex = 23
        Me.txtEntranceFee.Text = "4444"
        Me.txtEntranceFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblFee
        '
        Me.lblFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFee.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFee.Location = New System.Drawing.Point(13, 203)
        Me.lblFee.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFee.Name = "lblFee"
        Me.lblFee.Size = New System.Drawing.Size(125, 26)
        Me.lblFee.TabIndex = 24
        Me.lblFee.Text = "Entrance Fee:"
        Me.lblFee.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbGuildmaster
        '
        Me.cmbGuildmaster.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGuildmaster.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGuildmaster.FormattingEnabled = True
        Me.cmbGuildmaster.Items.AddRange(New Object() {"Computer"})
        Me.cmbGuildmaster.Location = New System.Drawing.Point(145, 238)
        Me.cmbGuildmaster.Name = "cmbGuildmaster"
        Me.cmbGuildmaster.Size = New System.Drawing.Size(201, 26)
        Me.cmbGuildmaster.TabIndex = 25
        '
        'lblGuildmaster
        '
        Me.lblGuildmaster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGuildmaster.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuildmaster.Location = New System.Drawing.Point(13, 238)
        Me.lblGuildmaster.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGuildmaster.Name = "lblGuildmaster"
        Me.lblGuildmaster.Size = New System.Drawing.Size(125, 26)
        Me.lblGuildmaster.TabIndex = 26
        Me.lblGuildmaster.Text = "Guildmaster:"
        Me.lblGuildmaster.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtOptions
        '
        Me.txtOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOptions.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOptions.Location = New System.Drawing.Point(13, 13)
        Me.txtOptions.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOptions.Multiline = True
        Me.txtOptions.Name = "txtOptions"
        Me.txtOptions.ReadOnly = True
        Me.txtOptions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOptions.Size = New System.Drawing.Size(333, 147)
        Me.txtOptions.TabIndex = 27
        Me.txtOptions.Text = "What would you like to change?"
        '
        'frmGuildOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 354)
        Me.Controls.Add(Me.txtOptions)
        Me.Controls.Add(Me.cmbGuildmaster)
        Me.Controls.Add(Me.lblGuildmaster)
        Me.Controls.Add(Me.txtEntranceFee)
        Me.Controls.Add(Me.lblFee)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmGuildOptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Guild Options"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtEntranceFee As System.Windows.Forms.TextBox
    Friend WithEvents lblFee As System.Windows.Forms.Label
    Friend WithEvents cmbGuildmaster As System.Windows.Forms.ComboBox
    Friend WithEvents lblGuildmaster As System.Windows.Forms.Label
    Friend WithEvents txtOptions As System.Windows.Forms.TextBox
End Class
