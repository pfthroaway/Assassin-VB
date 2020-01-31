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
            Me.BtnArmory = New Button()
            Me.BtnGenStore = New Button()
            Me.BtnWeapons = New Button()
            Me.BtnThieves = New Button()
            Me.TxtShops = New TextBox()
            Me.BtnBack = New Button()
            Me.SuspendLayout()
            '
            'btnArmory
            '
            Me.BtnArmory.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnArmory.Location = New Point(13, 169)
            Me.BtnArmory.Margin = New Padding(4)
            Me.BtnArmory.Name = "btnArmory"
            Me.BtnArmory.Size = New Size(150, 30)
            Me.BtnArmory.TabIndex = 1
            Me.BtnArmory.Text = "The &Armoury"
            Me.BtnArmory.UseVisualStyleBackColor = True
            '
            'btnGenStore
            '
            Me.BtnGenStore.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnGenStore.Location = New Point(171, 169)
            Me.BtnGenStore.Margin = New Padding(4)
            Me.BtnGenStore.Name = "btnGenStore"
            Me.BtnGenStore.Size = New Size(150, 30)
            Me.BtnGenStore.TabIndex = 2
            Me.BtnGenStore.Text = "&General Store"
            Me.BtnGenStore.UseVisualStyleBackColor = True
            '
            'btnWeapons
            '
            Me.BtnWeapons.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnWeapons.Location = New Point(13, 207)
            Me.BtnWeapons.Margin = New Padding(4)
            Me.BtnWeapons.Name = "btnWeapons"
            Me.BtnWeapons.Size = New Size(150, 30)
            Me.BtnWeapons.TabIndex = 3
            Me.BtnWeapons.Text = "&Weapons 'R Us"
            Me.BtnWeapons.UseVisualStyleBackColor = True
            '
            'btnThieves
            '
            Me.BtnThieves.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnThieves.Location = New Point(171, 207)
            Me.BtnThieves.Margin = New Padding(4)
            Me.BtnThieves.Name = "btnThieves"
            Me.BtnThieves.Size = New Size(150, 30)
            Me.BtnThieves.TabIndex = 4
            Me.BtnThieves.Text = "&Thieves Guild"
            Me.BtnThieves.UseVisualStyleBackColor = True
            '
            'txtShops
            '
            Me.TxtShops.BorderStyle = BorderStyle.FixedSingle
            Me.TxtShops.Font = New Font("Arial", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.TxtShops.Location = New Point(12, 12)
            Me.TxtShops.Multiline = True
            Me.TxtShops.Name = "txtShops"
            Me.TxtShops.ReadOnly = True
            Me.TxtShops.ScrollBars = ScrollBars.Vertical
            Me.TxtShops.Size = New Size(308, 150)
            Me.TxtShops.TabIndex = 0
            '
            'btnBack
            '
            Me.BtnBack.DialogResult = DialogResult.Cancel
            Me.BtnBack.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.BtnBack.Location = New Point(91, 245)
            Me.BtnBack.Margin = New Padding(4)
            Me.BtnBack.Name = "btnBack"
            Me.BtnBack.Size = New Size(150, 30)
            Me.BtnBack.TabIndex = 5
            Me.BtnBack.Text = "&Back"
            Me.BtnBack.UseVisualStyleBackColor = True
            '
            'frmShops
            '
            Me.AutoScaleDimensions = New SizeF(9.0!, 18.0!)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.CancelButton = Me.BtnBack
            Me.ClientSize = New Size(332, 288)
            Me.Controls.Add(Me.BtnBack)
            Me.Controls.Add(Me.TxtShops)
            Me.Controls.Add(Me.BtnThieves)
            Me.Controls.Add(Me.BtnWeapons)
            Me.Controls.Add(Me.BtnGenStore)
            Me.Controls.Add(Me.BtnArmory)
            Me.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Margin = New Padding(4)
            Me.MaximizeBox = False
            Me.MaximumSize = New Size(348, 326)
            Me.MinimumSize = New Size(348, 326)
            Me.Name = "frmShops"
            Me.StartPosition = FormStartPosition.CenterScreen
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