Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

Namespace Forms.Shopping
    <DesignerGenerated()>
    Partial Class FrmShops
        Inherits Form

        'Form overrides dispose to clean up the component list.
        <DebuggerNonUserCode()>
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
        <DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.BtnArmory = New System.Windows.Forms.Button()
            Me.BtnGenStore = New System.Windows.Forms.Button()
            Me.BtnWeapons = New System.Windows.Forms.Button()
            Me.BtnThieves = New System.Windows.Forms.Button()
            Me.TxtShops = New System.Windows.Forms.TextBox()
            Me.BtnBack = New System.Windows.Forms.Button()
            Me.SuspendLayout()
            '
            'BtnArmory
            '
            Me.BtnArmory.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnArmory.Location = New System.Drawing.Point(13, 169)
            Me.BtnArmory.Margin = New System.Windows.Forms.Padding(4)
            Me.BtnArmory.Name = "BtnArmory"
            Me.BtnArmory.Size = New System.Drawing.Size(150, 30)
            Me.BtnArmory.TabIndex = 1
            Me.BtnArmory.Text = "The &Armoury"
            Me.BtnArmory.UseVisualStyleBackColor = True
            '
            'BtnGenStore
            '
            Me.BtnGenStore.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnGenStore.Location = New System.Drawing.Point(171, 169)
            Me.BtnGenStore.Margin = New System.Windows.Forms.Padding(4)
            Me.BtnGenStore.Name = "BtnGenStore"
            Me.BtnGenStore.Size = New System.Drawing.Size(150, 30)
            Me.BtnGenStore.TabIndex = 2
            Me.BtnGenStore.Text = "&General Store"
            Me.BtnGenStore.UseVisualStyleBackColor = True
            '
            'BtnWeapons
            '
            Me.BtnWeapons.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnWeapons.Location = New System.Drawing.Point(13, 207)
            Me.BtnWeapons.Margin = New System.Windows.Forms.Padding(4)
            Me.BtnWeapons.Name = "BtnWeapons"
            Me.BtnWeapons.Size = New System.Drawing.Size(150, 30)
            Me.BtnWeapons.TabIndex = 3
            Me.BtnWeapons.Text = "&Weapons 'R Us"
            Me.BtnWeapons.UseVisualStyleBackColor = True
            '
            'BtnThieves
            '
            Me.BtnThieves.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnThieves.Location = New System.Drawing.Point(171, 207)
            Me.BtnThieves.Margin = New System.Windows.Forms.Padding(4)
            Me.BtnThieves.Name = "BtnThieves"
            Me.BtnThieves.Size = New System.Drawing.Size(150, 30)
            Me.BtnThieves.TabIndex = 4
            Me.BtnThieves.Text = "&Thieves Guild"
            Me.BtnThieves.UseVisualStyleBackColor = True
            '
            'TxtShops
            '
            Me.TxtShops.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.TxtShops.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TxtShops.Location = New System.Drawing.Point(12, 12)
            Me.TxtShops.Multiline = True
            Me.TxtShops.Name = "TxtShops"
            Me.TxtShops.ReadOnly = True
            Me.TxtShops.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.TxtShops.Size = New System.Drawing.Size(308, 150)
            Me.TxtShops.TabIndex = 0
            '
            'BtnBack
            '
            Me.BtnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.BtnBack.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnBack.Location = New System.Drawing.Point(91, 245)
            Me.BtnBack.Margin = New System.Windows.Forms.Padding(4)
            Me.BtnBack.Name = "BtnBack"
            Me.BtnBack.Size = New System.Drawing.Size(150, 30)
            Me.BtnBack.TabIndex = 5
            Me.BtnBack.Text = "&Back"
            Me.BtnBack.UseVisualStyleBackColor = True
            '
            'FrmShops
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.BtnBack
            Me.ClientSize = New System.Drawing.Size(332, 287)
            Me.Controls.Add(Me.BtnBack)
            Me.Controls.Add(Me.TxtShops)
            Me.Controls.Add(Me.BtnThieves)
            Me.Controls.Add(Me.BtnWeapons)
            Me.Controls.Add(Me.BtnGenStore)
            Me.Controls.Add(Me.BtnArmory)
            Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Margin = New System.Windows.Forms.Padding(4)
            Me.MaximizeBox = False
            Me.MaximumSize = New System.Drawing.Size(348, 326)
            Me.MinimumSize = New System.Drawing.Size(348, 326)
            Me.Name = "FrmShops"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Shops"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents BtnArmory As Button
        Friend WithEvents BtnGenStore As Button
        Friend WithEvents BtnWeapons As Button
        Friend WithEvents BtnThieves As Button
        Friend WithEvents TxtShops As TextBox
        Friend WithEvents BtnBack As Button
    End Class
End Namespace