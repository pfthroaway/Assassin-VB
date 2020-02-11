Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

Namespace Forms.Shopping
    <DesignerGenerated()>
    Partial Class FrmThievesGuild
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmThievesGuild))
            Me.LblGold = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.TxtThievesGuild = New System.Windows.Forms.TextBox()
            Me.LblLockpicks = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.BtnPurchase = New System.Windows.Forms.Button()
            Me.BtnBack = New System.Windows.Forms.Button()
            Me.SuspendLayout()
            '
            'LblGold
            '
            Me.LblGold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblGold.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblGold.Location = New System.Drawing.Point(12, 180)
            Me.LblGold.Name = "LblGold"
            Me.LblGold.Size = New System.Drawing.Size(150, 25)
            Me.LblGold.TabIndex = 4
            Me.LblGold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label1
            '
            Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(12, 158)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(150, 25)
            Me.Label1.TabIndex = 3
            Me.Label1.Text = "Current Gold:"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'TxtThievesGuild
            '
            Me.TxtThievesGuild.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.TxtThievesGuild.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TxtThievesGuild.Location = New System.Drawing.Point(12, 12)
            Me.TxtThievesGuild.Multiline = True
            Me.TxtThievesGuild.Name = "TxtThievesGuild"
            Me.TxtThievesGuild.ReadOnly = True
            Me.TxtThievesGuild.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.TxtThievesGuild.Size = New System.Drawing.Size(402, 143)
            Me.TxtThievesGuild.TabIndex = 2
            Me.TxtThievesGuild.Text = resources.GetString("TxtThievesGuild.Text")
            '
            'LblLockpicks
            '
            Me.LblLockpicks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblLockpicks.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblLockpicks.Location = New System.Drawing.Point(264, 180)
            Me.LblLockpicks.Name = "LblLockpicks"
            Me.LblLockpicks.Size = New System.Drawing.Size(150, 25)
            Me.LblLockpicks.TabIndex = 6
            Me.LblLockpicks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label3
            '
            Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(264, 158)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(150, 25)
            Me.Label3.TabIndex = 5
            Me.Label3.Text = "Lockpicks Owned:"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'BtnPurchase
            '
            Me.BtnPurchase.Enabled = False
            Me.BtnPurchase.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnPurchase.Location = New System.Drawing.Point(129, 208)
            Me.BtnPurchase.Name = "BtnPurchase"
            Me.BtnPurchase.Size = New System.Drawing.Size(150, 35)
            Me.BtnPurchase.TabIndex = 0
            Me.BtnPurchase.Text = "&Purchase"
            Me.BtnPurchase.UseVisualStyleBackColor = True
            '
            'BtnBack
            '
            Me.BtnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.BtnBack.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnBack.Location = New System.Drawing.Point(129, 249)
            Me.BtnBack.Name = "BtnBack"
            Me.BtnBack.Size = New System.Drawing.Size(150, 35)
            Me.BtnBack.TabIndex = 1
            Me.BtnBack.Text = "&Back"
            Me.BtnBack.UseVisualStyleBackColor = True
            '
            'FrmThievesGuild
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.BtnBack
            Me.ClientSize = New System.Drawing.Size(426, 296)
            Me.Controls.Add(Me.BtnBack)
            Me.Controls.Add(Me.BtnPurchase)
            Me.Controls.Add(Me.LblLockpicks)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.TxtThievesGuild)
            Me.Controls.Add(Me.LblGold)
            Me.Controls.Add(Me.Label1)
            Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Margin = New System.Windows.Forms.Padding(4)
            Me.MaximizeBox = False
            Me.MaximumSize = New System.Drawing.Size(442, 335)
            Me.MinimumSize = New System.Drawing.Size(442, 335)
            Me.Name = "FrmThievesGuild"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Thieves' Guild"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents LblGold As Label
        Friend WithEvents Label1 As Label
        Friend WithEvents TxtThievesGuild As TextBox
        Friend WithEvents LblLockpicks As Label
        Friend WithEvents Label3 As Label
        Friend WithEvents BtnPurchase As Button
        Friend WithEvents BtnBack As Button
    End Class
End Namespace