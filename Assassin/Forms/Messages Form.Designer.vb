Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

Namespace Forms
    <DesignerGenerated()> _
    Partial Class FrmMessages
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
            Me.TxtMessage = New System.Windows.Forms.TextBox()
            Me.BtnPrev = New System.Windows.Forms.Button()
            Me.BtnNext = New System.Windows.Forms.Button()
            Me.BtnDelete = New System.Windows.Forms.Button()
            Me.BtnBack = New System.Windows.Forms.Button()
            Me.BtnReply = New System.Windows.Forms.Button()
            Me.LblMessages = New System.Windows.Forms.Label()
            Me.LblFrom = New System.Windows.Forms.Label()
            Me.LblCount = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.TxtDate = New System.Windows.Forms.TextBox()
            Me.BtnNew = New System.Windows.Forms.Button()
            Me.CmbNames = New System.Windows.Forms.ComboBox()
            Me.SuspendLayout()
            '
            'TxtMessage
            '
            Me.TxtMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.TxtMessage.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TxtMessage.Location = New System.Drawing.Point(13, 116)
            Me.TxtMessage.Margin = New System.Windows.Forms.Padding(4)
            Me.TxtMessage.MaxLength = 255
            Me.TxtMessage.Multiline = True
            Me.TxtMessage.Name = "TxtMessage"
            Me.TxtMessage.ReadOnly = True
            Me.TxtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.TxtMessage.Size = New System.Drawing.Size(250, 100)
            Me.TxtMessage.TabIndex = 1
            '
            'BtnPrev
            '
            Me.BtnPrev.Enabled = False
            Me.BtnPrev.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnPrev.Location = New System.Drawing.Point(13, 223)
            Me.BtnPrev.Name = "BtnPrev"
            Me.BtnPrev.Size = New System.Drawing.Size(80, 30)
            Me.BtnPrev.TabIndex = 0
            Me.BtnPrev.Text = "&Prev"
            Me.BtnPrev.UseVisualStyleBackColor = True
            '
            'BtnNext
            '
            Me.BtnNext.Enabled = False
            Me.BtnNext.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnNext.Location = New System.Drawing.Point(184, 223)
            Me.BtnNext.Name = "BtnNext"
            Me.BtnNext.Size = New System.Drawing.Size(80, 30)
            Me.BtnNext.TabIndex = 1
            Me.BtnNext.Text = "&Next"
            Me.BtnNext.UseVisualStyleBackColor = True
            '
            'BtnDelete
            '
            Me.BtnDelete.Enabled = False
            Me.BtnDelete.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnDelete.Location = New System.Drawing.Point(76, 331)
            Me.BtnDelete.Name = "BtnDelete"
            Me.BtnDelete.Size = New System.Drawing.Size(125, 30)
            Me.BtnDelete.TabIndex = 3
            Me.BtnDelete.Text = "&Delete"
            Me.BtnDelete.UseVisualStyleBackColor = True
            '
            'BtnBack
            '
            Me.BtnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.BtnBack.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnBack.Location = New System.Drawing.Point(76, 367)
            Me.BtnBack.Name = "BtnBack"
            Me.BtnBack.Size = New System.Drawing.Size(125, 30)
            Me.BtnBack.TabIndex = 4
            Me.BtnBack.Text = "&Back"
            Me.BtnBack.UseVisualStyleBackColor = True
            '
            'BtnReply
            '
            Me.BtnReply.Enabled = False
            Me.BtnReply.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnReply.Location = New System.Drawing.Point(76, 295)
            Me.BtnReply.Name = "BtnReply"
            Me.BtnReply.Size = New System.Drawing.Size(125, 30)
            Me.BtnReply.TabIndex = 2
            Me.BtnReply.Text = "&Reply"
            Me.BtnReply.UseVisualStyleBackColor = True
            '
            'LblMessages
            '
            Me.LblMessages.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblMessages.Location = New System.Drawing.Point(12, 9)
            Me.LblMessages.Name = "LblMessages"
            Me.LblMessages.Size = New System.Drawing.Size(252, 35)
            Me.LblMessages.TabIndex = 14
            Me.LblMessages.Text = "Messages"
            Me.LblMessages.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'LblFrom
            '
            Me.LblFrom.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblFrom.Location = New System.Drawing.Point(15, 50)
            Me.LblFrom.Name = "LblFrom"
            Me.LblFrom.Size = New System.Drawing.Size(50, 20)
            Me.LblFrom.TabIndex = 15
            Me.LblFrom.Text = "From:"
            Me.LblFrom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'LblCount
            '
            Me.LblCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LblCount.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblCount.Location = New System.Drawing.Point(108, 223)
            Me.LblCount.Name = "LblCount"
            Me.LblCount.Size = New System.Drawing.Size(60, 30)
            Me.LblCount.TabIndex = 16
            Me.LblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label1
            '
            Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(15, 83)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(50, 20)
            Me.Label1.TabIndex = 18
            Me.Label1.Text = "Date:"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'TxtDate
            '
            Me.TxtDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.TxtDate.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TxtDate.Location = New System.Drawing.Point(71, 82)
            Me.TxtDate.Margin = New System.Windows.Forms.Padding(4)
            Me.TxtDate.MaxLength = 30
            Me.TxtDate.Name = "TxtDate"
            Me.TxtDate.ReadOnly = True
            Me.TxtDate.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.TxtDate.Size = New System.Drawing.Size(192, 26)
            Me.TxtDate.TabIndex = 17
            Me.TxtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'BtnNew
            '
            Me.BtnNew.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnNew.Location = New System.Drawing.Point(76, 259)
            Me.BtnNew.Name = "BtnNew"
            Me.BtnNew.Size = New System.Drawing.Size(125, 30)
            Me.BtnNew.TabIndex = 19
            Me.BtnNew.Text = "N&ew"
            Me.BtnNew.UseVisualStyleBackColor = True
            '
            'CmbNames
            '
            Me.CmbNames.Enabled = False
            Me.CmbNames.FormattingEnabled = True
            Me.CmbNames.Location = New System.Drawing.Point(71, 48)
            Me.CmbNames.Name = "CmbNames"
            Me.CmbNames.Size = New System.Drawing.Size(192, 26)
            Me.CmbNames.TabIndex = 20
            '
            'FrmMessages
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.BtnBack
            Me.ClientSize = New System.Drawing.Size(276, 407)
            Me.Controls.Add(Me.CmbNames)
            Me.Controls.Add(Me.BtnNew)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.TxtDate)
            Me.Controls.Add(Me.LblCount)
            Me.Controls.Add(Me.LblFrom)
            Me.Controls.Add(Me.LblMessages)
            Me.Controls.Add(Me.BtnReply)
            Me.Controls.Add(Me.BtnBack)
            Me.Controls.Add(Me.BtnDelete)
            Me.Controls.Add(Me.BtnNext)
            Me.Controls.Add(Me.BtnPrev)
            Me.Controls.Add(Me.TxtMessage)
            Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Margin = New System.Windows.Forms.Padding(4)
            Me.MaximizeBox = False
            Me.MaximumSize = New System.Drawing.Size(292, 447)
            Me.MinimumSize = New System.Drawing.Size(292, 447)
            Me.Name = "FrmMessages"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Az"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents TxtMessage As TextBox
        Friend WithEvents BtnPrev As Button
        Friend WithEvents BtnNext As Button
        Friend WithEvents BtnDelete As Button
        Friend WithEvents BtnBack As Button
        Friend WithEvents BtnReply As Button
        Friend WithEvents LblMessages As Label
        Friend WithEvents LblFrom As Label
        Friend WithEvents LblCount As Label
        Friend WithEvents Label1 As Label
        Friend WithEvents TxtDate As TextBox
        Friend WithEvents BtnNew As Button
        Friend WithEvents CmbNames As ComboBox
    End Class
End NameSpace