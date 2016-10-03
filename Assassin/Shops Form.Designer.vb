<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShops
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
        Me.btnArmory = New System.Windows.Forms.Button()
        Me.btnGenStore = New System.Windows.Forms.Button()
        Me.btnWeapons = New System.Windows.Forms.Button()
        Me.btnThieves = New System.Windows.Forms.Button()
        Me.txtShops = New System.Windows.Forms.TextBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnArmory
        '
        Me.btnArmory.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArmory.Location = New System.Drawing.Point(13, 169)
        Me.btnArmory.Margin = New System.Windows.Forms.Padding(4)
        Me.btnArmory.Name = "btnArmory"
        Me.btnArmory.Size = New System.Drawing.Size(150, 30)
        Me.btnArmory.TabIndex = 1
        Me.btnArmory.Text = "The &Armoury"
        Me.btnArmory.UseVisualStyleBackColor = True
        '
        'btnGenStore
        '
        Me.btnGenStore.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenStore.Location = New System.Drawing.Point(171, 169)
        Me.btnGenStore.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGenStore.Name = "btnGenStore"
        Me.btnGenStore.Size = New System.Drawing.Size(150, 30)
        Me.btnGenStore.TabIndex = 2
        Me.btnGenStore.Text = "&General Store"
        Me.btnGenStore.UseVisualStyleBackColor = True
        '
        'btnWeapons
        '
        Me.btnWeapons.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWeapons.Location = New System.Drawing.Point(13, 207)
        Me.btnWeapons.Margin = New System.Windows.Forms.Padding(4)
        Me.btnWeapons.Name = "btnWeapons"
        Me.btnWeapons.Size = New System.Drawing.Size(150, 30)
        Me.btnWeapons.TabIndex = 3
        Me.btnWeapons.Text = "&Weapons 'R Us"
        Me.btnWeapons.UseVisualStyleBackColor = True
        '
        'btnThieves
        '
        Me.btnThieves.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThieves.Location = New System.Drawing.Point(171, 207)
        Me.btnThieves.Margin = New System.Windows.Forms.Padding(4)
        Me.btnThieves.Name = "btnThieves"
        Me.btnThieves.Size = New System.Drawing.Size(150, 30)
        Me.btnThieves.TabIndex = 4
        Me.btnThieves.Text = "&Thieves Guild"
        Me.btnThieves.UseVisualStyleBackColor = True
        '
        'txtShops
        '
        Me.txtShops.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtShops.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShops.Location = New System.Drawing.Point(12, 12)
        Me.txtShops.Multiline = True
        Me.txtShops.Name = "txtShops"
        Me.txtShops.ReadOnly = True
        Me.txtShops.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtShops.Size = New System.Drawing.Size(308, 150)
        Me.txtShops.TabIndex = 0
        '
        'btnBack
        '
        Me.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBack.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(91, 245)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(150, 30)
        Me.btnBack.TabIndex = 5
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'frmShops
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnBack
        Me.ClientSize = New System.Drawing.Size(332, 288)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.txtShops)
        Me.Controls.Add(Me.btnThieves)
        Me.Controls.Add(Me.btnWeapons)
        Me.Controls.Add(Me.btnGenStore)
        Me.Controls.Add(Me.btnArmory)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(348, 326)
        Me.MinimumSize = New System.Drawing.Size(348, 326)
        Me.Name = "frmShops"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Shops"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnArmory As System.Windows.Forms.Button
    Friend WithEvents btnGenStore As System.Windows.Forms.Button
    Friend WithEvents btnWeapons As System.Windows.Forms.Button
    Friend WithEvents btnThieves As System.Windows.Forms.Button
    Friend WithEvents txtShops As System.Windows.Forms.TextBox
    Friend WithEvents btnBack As System.Windows.Forms.Button
End Class
