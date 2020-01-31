Imports System.ComponentModel
Imports Microsoft.VisualBasic.CompilerServices

Namespace Forms
    <DesignerGenerated()> _
    Partial Class FrmHireHenchmen
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
            Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(frmHireHenchmen))
            Me.txtHire = New TextBox()
            Me.btnBack = New Button()
            Me.btnClear = New Button()
            Me.btnHire = New Button()
            Me.txtHenchmenLevel5 = New TextBox()
            Me.Label7 = New Label()
            Me.txtHenchmenLevel4 = New TextBox()
            Me.Label6 = New Label()
            Me.txtHenchmenLevel3 = New TextBox()
            Me.Label5 = New Label()
            Me.txtHenchmenLevel2 = New TextBox()
            Me.Label4 = New Label()
            Me.txtHenchmenLevel1 = New TextBox()
            Me.Label3 = New Label()
            Me.Label1 = New Label()
            Me.lblGold1 = New Label()
            Me.lblGoldOnHand = New Label()
            Me.lblGoldRemaining = New Label()
            Me.Label8 = New Label()
            Me.btn5P1 = New Button()
            Me.btn5M1 = New Button()
            Me.btn4P1 = New Button()
            Me.btn4M1 = New Button()
            Me.btn3P1 = New Button()
            Me.btn3M1 = New Button()
            Me.btn2P1 = New Button()
            Me.btn2M1 = New Button()
            Me.btn1P1 = New Button()
            Me.btn1M1 = New Button()
            Me.txtBuy1 = New TextBox()
            Me.txtBuy5 = New TextBox()
            Me.txtBuy4 = New TextBox()
            Me.txtBuy3 = New TextBox()
            Me.txtBuy2 = New TextBox()
            Me.Label2 = New Label()
            Me.Label9 = New Label()
            Me.btn5M5 = New Button()
            Me.btn4M5 = New Button()
            Me.btn3M5 = New Button()
            Me.btn2M5 = New Button()
            Me.btn1M5 = New Button()
            Me.btn5P5 = New Button()
            Me.btn4P5 = New Button()
            Me.btn3P5 = New Button()
            Me.btn2P5 = New Button()
            Me.btn1P5 = New Button()
            Me.SuspendLayout()
            '
            'txtHire
            '
            Me.txtHire.BorderStyle = BorderStyle.FixedSingle
            Me.txtHire.Location = New Point(426, 71)
            Me.txtHire.Multiline = True
            Me.txtHire.Name = "txtHire"
            Me.txtHire.ReadOnly = True
            Me.txtHire.Size = New Size(340, 257)
            Me.txtHire.TabIndex = 33
            Me.txtHire.Text = resources.GetString("txtHire.Text")
            '
            'btnBack
            '
            Me.btnBack.DialogResult = DialogResult.Cancel
            Me.btnBack.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnBack.Location = New Point(288, 298)
            Me.btnBack.Name = "btnBack"
            Me.btnBack.Size = New Size(100, 30)
            Me.btnBack.TabIndex = 22
            Me.btnBack.Text = "&Back"
            Me.btnBack.UseVisualStyleBackColor = True
            '
            'btnClear
            '
            Me.btnClear.Enabled = False
            Me.btnClear.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnClear.Location = New Point(150, 298)
            Me.btnClear.Name = "btnClear"
            Me.btnClear.Size = New Size(100, 30)
            Me.btnClear.TabIndex = 21
            Me.btnClear.Text = "&Clear"
            Me.btnClear.UseVisualStyleBackColor = True
            '
            'btnHire
            '
            Me.btnHire.Enabled = False
            Me.btnHire.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btnHire.Location = New Point(12, 298)
            Me.btnHire.Name = "btnHire"
            Me.btnHire.Size = New Size(100, 30)
            Me.btnHire.TabIndex = 20
            Me.btnHire.Text = "&Hire"
            Me.btnHire.UseVisualStyleBackColor = True
            '
            'txtHenchmenLevel5
            '
            Me.txtHenchmenLevel5.BorderStyle = BorderStyle.FixedSingle
            Me.txtHenchmenLevel5.Location = New Point(96, 232)
            Me.txtHenchmenLevel5.MaxLength = 3
            Me.txtHenchmenLevel5.Name = "txtHenchmenLevel5"
            Me.txtHenchmenLevel5.ReadOnly = True
            Me.txtHenchmenLevel5.Size = New Size(50, 26)
            Me.txtHenchmenLevel5.TabIndex = 31
            Me.txtHenchmenLevel5.TextAlign = HorizontalAlignment.Center
            '
            'Label7
            '
            Me.Label7.Location = New Point(12, 232)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New Size(85, 25)
            Me.Label7.TabIndex = 41
            Me.Label7.Text = "Lvl 5 (500):"
            Me.Label7.TextAlign = ContentAlignment.MiddleCenter
            '
            'txtHenchmenLevel4
            '
            Me.txtHenchmenLevel4.BorderStyle = BorderStyle.FixedSingle
            Me.txtHenchmenLevel4.Location = New Point(96, 198)
            Me.txtHenchmenLevel4.MaxLength = 3
            Me.txtHenchmenLevel4.Name = "txtHenchmenLevel4"
            Me.txtHenchmenLevel4.ReadOnly = True
            Me.txtHenchmenLevel4.Size = New Size(50, 26)
            Me.txtHenchmenLevel4.TabIndex = 29
            Me.txtHenchmenLevel4.TextAlign = HorizontalAlignment.Center
            '
            'Label6
            '
            Me.Label6.Location = New Point(12, 198)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New Size(85, 25)
            Me.Label6.TabIndex = 40
            Me.Label6.Text = "Lvl 4 (400):"
            Me.Label6.TextAlign = ContentAlignment.MiddleCenter
            '
            'txtHenchmenLevel3
            '
            Me.txtHenchmenLevel3.BorderStyle = BorderStyle.FixedSingle
            Me.txtHenchmenLevel3.Location = New Point(96, 164)
            Me.txtHenchmenLevel3.MaxLength = 3
            Me.txtHenchmenLevel3.Name = "txtHenchmenLevel3"
            Me.txtHenchmenLevel3.ReadOnly = True
            Me.txtHenchmenLevel3.Size = New Size(50, 26)
            Me.txtHenchmenLevel3.TabIndex = 27
            Me.txtHenchmenLevel3.TextAlign = HorizontalAlignment.Center
            '
            'Label5
            '
            Me.Label5.Location = New Point(12, 164)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New Size(85, 25)
            Me.Label5.TabIndex = 39
            Me.Label5.Text = "Lvl 3 (300):"
            Me.Label5.TextAlign = ContentAlignment.MiddleCenter
            '
            'txtHenchmenLevel2
            '
            Me.txtHenchmenLevel2.BorderStyle = BorderStyle.FixedSingle
            Me.txtHenchmenLevel2.Location = New Point(96, 130)
            Me.txtHenchmenLevel2.MaxLength = 3
            Me.txtHenchmenLevel2.Name = "txtHenchmenLevel2"
            Me.txtHenchmenLevel2.ReadOnly = True
            Me.txtHenchmenLevel2.Size = New Size(50, 26)
            Me.txtHenchmenLevel2.TabIndex = 25
            Me.txtHenchmenLevel2.TextAlign = HorizontalAlignment.Center
            '
            'Label4
            '
            Me.Label4.Location = New Point(12, 130)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New Size(85, 25)
            Me.Label4.TabIndex = 38
            Me.Label4.Text = "Lvl 2 (200):"
            Me.Label4.TextAlign = ContentAlignment.MiddleCenter
            '
            'txtHenchmenLevel1
            '
            Me.txtHenchmenLevel1.BorderStyle = BorderStyle.FixedSingle
            Me.txtHenchmenLevel1.Location = New Point(96, 96)
            Me.txtHenchmenLevel1.MaxLength = 3
            Me.txtHenchmenLevel1.Name = "txtHenchmenLevel1"
            Me.txtHenchmenLevel1.ReadOnly = True
            Me.txtHenchmenLevel1.Size = New Size(50, 26)
            Me.txtHenchmenLevel1.TabIndex = 23
            Me.txtHenchmenLevel1.TextAlign = HorizontalAlignment.Center
            '
            'Label3
            '
            Me.Label3.Location = New Point(12, 96)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New Size(85, 25)
            Me.Label3.TabIndex = 37
            Me.Label3.Text = "Lvl 1 (100):"
            Me.Label3.TextAlign = ContentAlignment.MiddleCenter
            '
            'Label1
            '
            Me.Label1.Font = New Font("Arial", 15.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New Point(12, 9)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New Size(382, 40)
            Me.Label1.TabIndex = 34
            Me.Label1.Text = "Hire Henchmen"
            Me.Label1.TextAlign = ContentAlignment.MiddleCenter
            '
            'lblGold1
            '
            Me.lblGold1.BorderStyle = BorderStyle.FixedSingle
            Me.lblGold1.Location = New Point(426, 9)
            Me.lblGold1.Name = "lblGold1"
            Me.lblGold1.Size = New Size(150, 25)
            Me.lblGold1.TabIndex = 42
            Me.lblGold1.Text = "Gold On Hand:"
            Me.lblGold1.TextAlign = ContentAlignment.MiddleCenter
            '
            'lblGoldOnHand
            '
            Me.lblGoldOnHand.BorderStyle = BorderStyle.FixedSingle
            Me.lblGoldOnHand.Location = New Point(426, 33)
            Me.lblGoldOnHand.Name = "lblGoldOnHand"
            Me.lblGoldOnHand.Size = New Size(150, 25)
            Me.lblGoldOnHand.TabIndex = 43
            Me.lblGoldOnHand.TextAlign = ContentAlignment.MiddleCenter
            '
            'lblGoldRemaining
            '
            Me.lblGoldRemaining.BorderStyle = BorderStyle.FixedSingle
            Me.lblGoldRemaining.Location = New Point(616, 33)
            Me.lblGoldRemaining.Name = "lblGoldRemaining"
            Me.lblGoldRemaining.Size = New Size(150, 25)
            Me.lblGoldRemaining.TabIndex = 45
            Me.lblGoldRemaining.TextAlign = ContentAlignment.MiddleCenter
            '
            'Label8
            '
            Me.Label8.BorderStyle = BorderStyle.FixedSingle
            Me.Label8.Location = New Point(616, 9)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New Size(150, 25)
            Me.Label8.TabIndex = 44
            Me.Label8.Text = "Gold Remaining:"
            Me.Label8.TextAlign = ContentAlignment.MiddleCenter
            '
            'btn5P1
            '
            Me.btn5P1.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btn5P1.Location = New Point(331, 232)
            Me.btn5P1.Margin = New Padding(4)
            Me.btn5P1.Name = "btn5P1"
            Me.btn5P1.Size = New Size(40, 25)
            Me.btn5P1.TabIndex = 18
            Me.btn5P1.Text = "+1"
            Me.btn5P1.TextAlign = ContentAlignment.BottomCenter
            Me.btn5P1.UseVisualStyleBackColor = True
            '
            'btn5M1
            '
            Me.btn5M1.Enabled = False
            Me.btn5M1.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btn5M1.Location = New Point(283, 232)
            Me.btn5M1.Margin = New Padding(4)
            Me.btn5M1.Name = "btn5M1"
            Me.btn5M1.Size = New Size(40, 25)
            Me.btn5M1.TabIndex = 17
            Me.btn5M1.Text = "-1"
            Me.btn5M1.TextAlign = ContentAlignment.BottomCenter
            Me.btn5M1.UseVisualStyleBackColor = True
            '
            'btn4P1
            '
            Me.btn4P1.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btn4P1.Location = New Point(331, 198)
            Me.btn4P1.Margin = New Padding(4)
            Me.btn4P1.Name = "btn4P1"
            Me.btn4P1.Size = New Size(40, 25)
            Me.btn4P1.TabIndex = 14
            Me.btn4P1.Text = "+1"
            Me.btn4P1.TextAlign = ContentAlignment.BottomCenter
            Me.btn4P1.UseVisualStyleBackColor = True
            '
            'btn4M1
            '
            Me.btn4M1.Enabled = False
            Me.btn4M1.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btn4M1.Location = New Point(283, 198)
            Me.btn4M1.Margin = New Padding(4)
            Me.btn4M1.Name = "btn4M1"
            Me.btn4M1.Size = New Size(40, 25)
            Me.btn4M1.TabIndex = 13
            Me.btn4M1.Text = "-1"
            Me.btn4M1.TextAlign = ContentAlignment.BottomCenter
            Me.btn4M1.UseVisualStyleBackColor = True
            '
            'btn3P1
            '
            Me.btn3P1.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btn3P1.Location = New Point(331, 164)
            Me.btn3P1.Margin = New Padding(4)
            Me.btn3P1.Name = "btn3P1"
            Me.btn3P1.Size = New Size(40, 25)
            Me.btn3P1.TabIndex = 10
            Me.btn3P1.Text = "+1"
            Me.btn3P1.TextAlign = ContentAlignment.BottomCenter
            Me.btn3P1.UseVisualStyleBackColor = True
            '
            'btn3M1
            '
            Me.btn3M1.Enabled = False
            Me.btn3M1.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btn3M1.Location = New Point(283, 164)
            Me.btn3M1.Margin = New Padding(4)
            Me.btn3M1.Name = "btn3M1"
            Me.btn3M1.Size = New Size(40, 25)
            Me.btn3M1.TabIndex = 9
            Me.btn3M1.Text = "-1"
            Me.btn3M1.TextAlign = ContentAlignment.BottomCenter
            Me.btn3M1.UseVisualStyleBackColor = True
            '
            'btn2P1
            '
            Me.btn2P1.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btn2P1.Location = New Point(331, 130)
            Me.btn2P1.Margin = New Padding(4)
            Me.btn2P1.Name = "btn2P1"
            Me.btn2P1.Size = New Size(40, 25)
            Me.btn2P1.TabIndex = 6
            Me.btn2P1.Text = "+1"
            Me.btn2P1.TextAlign = ContentAlignment.BottomCenter
            Me.btn2P1.UseVisualStyleBackColor = True
            '
            'btn2M1
            '
            Me.btn2M1.Enabled = False
            Me.btn2M1.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btn2M1.Location = New Point(283, 130)
            Me.btn2M1.Margin = New Padding(4)
            Me.btn2M1.Name = "btn2M1"
            Me.btn2M1.Size = New Size(40, 25)
            Me.btn2M1.TabIndex = 5
            Me.btn2M1.Text = "-1"
            Me.btn2M1.TextAlign = ContentAlignment.BottomCenter
            Me.btn2M1.UseVisualStyleBackColor = True
            '
            'btn1P1
            '
            Me.btn1P1.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btn1P1.Location = New Point(331, 96)
            Me.btn1P1.Margin = New Padding(4)
            Me.btn1P1.Name = "btn1P1"
            Me.btn1P1.Size = New Size(40, 25)
            Me.btn1P1.TabIndex = 2
            Me.btn1P1.Text = "+1"
            Me.btn1P1.TextAlign = ContentAlignment.BottomCenter
            Me.btn1P1.UseVisualStyleBackColor = True
            '
            'btn1M1
            '
            Me.btn1M1.Enabled = False
            Me.btn1M1.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btn1M1.Location = New Point(283, 96)
            Me.btn1M1.Margin = New Padding(4)
            Me.btn1M1.Name = "btn1M1"
            Me.btn1M1.Size = New Size(40, 25)
            Me.btn1M1.TabIndex = 1
            Me.btn1M1.Text = "-1"
            Me.btn1M1.TextAlign = ContentAlignment.BottomCenter
            Me.btn1M1.UseVisualStyleBackColor = True
            '
            'txtBuy1
            '
            Me.txtBuy1.BorderStyle = BorderStyle.FixedSingle
            Me.txtBuy1.Enabled = False
            Me.txtBuy1.Location = New Point(172, 96)
            Me.txtBuy1.MaxLength = 3
            Me.txtBuy1.Name = "txtBuy1"
            Me.txtBuy1.ReadOnly = True
            Me.txtBuy1.Size = New Size(50, 26)
            Me.txtBuy1.TabIndex = 24
            Me.txtBuy1.TextAlign = HorizontalAlignment.Center
            '
            'txtBuy5
            '
            Me.txtBuy5.BorderStyle = BorderStyle.FixedSingle
            Me.txtBuy5.Location = New Point(172, 232)
            Me.txtBuy5.MaxLength = 3
            Me.txtBuy5.Name = "txtBuy5"
            Me.txtBuy5.ReadOnly = True
            Me.txtBuy5.Size = New Size(50, 26)
            Me.txtBuy5.TabIndex = 32
            Me.txtBuy5.TextAlign = HorizontalAlignment.Center
            '
            'txtBuy4
            '
            Me.txtBuy4.BorderStyle = BorderStyle.FixedSingle
            Me.txtBuy4.Location = New Point(172, 198)
            Me.txtBuy4.MaxLength = 3
            Me.txtBuy4.Name = "txtBuy4"
            Me.txtBuy4.ReadOnly = True
            Me.txtBuy4.Size = New Size(50, 26)
            Me.txtBuy4.TabIndex = 30
            Me.txtBuy4.TextAlign = HorizontalAlignment.Center
            '
            'txtBuy3
            '
            Me.txtBuy3.BorderStyle = BorderStyle.FixedSingle
            Me.txtBuy3.Location = New Point(172, 164)
            Me.txtBuy3.MaxLength = 3
            Me.txtBuy3.Name = "txtBuy3"
            Me.txtBuy3.ReadOnly = True
            Me.txtBuy3.Size = New Size(50, 26)
            Me.txtBuy3.TabIndex = 28
            Me.txtBuy3.TextAlign = HorizontalAlignment.Center
            '
            'txtBuy2
            '
            Me.txtBuy2.BorderStyle = BorderStyle.FixedSingle
            Me.txtBuy2.Location = New Point(172, 130)
            Me.txtBuy2.MaxLength = 3
            Me.txtBuy2.Name = "txtBuy2"
            Me.txtBuy2.ReadOnly = True
            Me.txtBuy2.Size = New Size(50, 26)
            Me.txtBuy2.TabIndex = 26
            Me.txtBuy2.TextAlign = HorizontalAlignment.Center
            '
            'Label2
            '
            Me.Label2.Location = New Point(80, 58)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New Size(80, 25)
            Me.Label2.TabIndex = 35
            Me.Label2.Text = "Current:"
            Me.Label2.TextAlign = ContentAlignment.MiddleCenter
            '
            'Label9
            '
            Me.Label9.Location = New Point(161, 58)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New Size(80, 25)
            Me.Label9.TabIndex = 36
            Me.Label9.Text = "Purchase:"
            Me.Label9.TextAlign = ContentAlignment.MiddleCenter
            '
            'btn5M5
            '
            Me.btn5M5.Enabled = False
            Me.btn5M5.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btn5M5.Location = New Point(235, 233)
            Me.btn5M5.Margin = New Padding(4)
            Me.btn5M5.Name = "btn5M5"
            Me.btn5M5.Size = New Size(40, 25)
            Me.btn5M5.TabIndex = 16
            Me.btn5M5.Text = "-5"
            Me.btn5M5.TextAlign = ContentAlignment.BottomCenter
            Me.btn5M5.UseVisualStyleBackColor = True
            '
            'btn4M5
            '
            Me.btn4M5.Enabled = False
            Me.btn4M5.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btn4M5.Location = New Point(235, 199)
            Me.btn4M5.Margin = New Padding(4)
            Me.btn4M5.Name = "btn4M5"
            Me.btn4M5.Size = New Size(40, 25)
            Me.btn4M5.TabIndex = 12
            Me.btn4M5.Text = "-5"
            Me.btn4M5.TextAlign = ContentAlignment.BottomCenter
            Me.btn4M5.UseVisualStyleBackColor = True
            '
            'btn3M5
            '
            Me.btn3M5.Enabled = False
            Me.btn3M5.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btn3M5.Location = New Point(235, 165)
            Me.btn3M5.Margin = New Padding(4)
            Me.btn3M5.Name = "btn3M5"
            Me.btn3M5.Size = New Size(40, 25)
            Me.btn3M5.TabIndex = 8
            Me.btn3M5.Text = "-5"
            Me.btn3M5.TextAlign = ContentAlignment.BottomCenter
            Me.btn3M5.UseVisualStyleBackColor = True
            '
            'btn2M5
            '
            Me.btn2M5.Enabled = False
            Me.btn2M5.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btn2M5.Location = New Point(235, 131)
            Me.btn2M5.Margin = New Padding(4)
            Me.btn2M5.Name = "btn2M5"
            Me.btn2M5.Size = New Size(40, 25)
            Me.btn2M5.TabIndex = 4
            Me.btn2M5.Text = "-5"
            Me.btn2M5.TextAlign = ContentAlignment.BottomCenter
            Me.btn2M5.UseVisualStyleBackColor = True
            '
            'btn1M5
            '
            Me.btn1M5.Enabled = False
            Me.btn1M5.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btn1M5.Location = New Point(235, 97)
            Me.btn1M5.Margin = New Padding(4)
            Me.btn1M5.Name = "btn1M5"
            Me.btn1M5.Size = New Size(40, 25)
            Me.btn1M5.TabIndex = 0
            Me.btn1M5.Text = "-5"
            Me.btn1M5.TextAlign = ContentAlignment.BottomCenter
            Me.btn1M5.UseVisualStyleBackColor = True
            '
            'btn5P5
            '
            Me.btn5P5.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btn5P5.Location = New Point(379, 233)
            Me.btn5P5.Margin = New Padding(4)
            Me.btn5P5.Name = "btn5P5"
            Me.btn5P5.Size = New Size(40, 25)
            Me.btn5P5.TabIndex = 19
            Me.btn5P5.Text = "+5"
            Me.btn5P5.TextAlign = ContentAlignment.BottomCenter
            Me.btn5P5.UseVisualStyleBackColor = True
            '
            'btn4P5
            '
            Me.btn4P5.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btn4P5.Location = New Point(379, 199)
            Me.btn4P5.Margin = New Padding(4)
            Me.btn4P5.Name = "btn4P5"
            Me.btn4P5.Size = New Size(40, 25)
            Me.btn4P5.TabIndex = 15
            Me.btn4P5.Text = "+5"
            Me.btn4P5.TextAlign = ContentAlignment.BottomCenter
            Me.btn4P5.UseVisualStyleBackColor = True
            '
            'btn3P5
            '
            Me.btn3P5.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btn3P5.Location = New Point(379, 165)
            Me.btn3P5.Margin = New Padding(4)
            Me.btn3P5.Name = "btn3P5"
            Me.btn3P5.Size = New Size(40, 25)
            Me.btn3P5.TabIndex = 11
            Me.btn3P5.Text = "+5"
            Me.btn3P5.TextAlign = ContentAlignment.BottomCenter
            Me.btn3P5.UseVisualStyleBackColor = True
            '
            'btn2P5
            '
            Me.btn2P5.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btn2P5.Location = New Point(379, 131)
            Me.btn2P5.Margin = New Padding(4)
            Me.btn2P5.Name = "btn2P5"
            Me.btn2P5.Size = New Size(40, 25)
            Me.btn2P5.TabIndex = 7
            Me.btn2P5.Text = "+5"
            Me.btn2P5.TextAlign = ContentAlignment.BottomCenter
            Me.btn2P5.UseVisualStyleBackColor = True
            '
            'btn1P5
            '
            Me.btn1P5.Font = New Font("Arial", 12.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.btn1P5.Location = New Point(379, 97)
            Me.btn1P5.Margin = New Padding(4)
            Me.btn1P5.Name = "btn1P5"
            Me.btn1P5.Size = New Size(40, 25)
            Me.btn1P5.TabIndex = 3
            Me.btn1P5.Text = "+5"
            Me.btn1P5.TextAlign = ContentAlignment.BottomCenter
            Me.btn1P5.UseVisualStyleBackColor = True
            '
            'frmHireHenchmen
            '
            Me.AutoScaleDimensions = New SizeF(9.0!, 18.0!)
            Me.AutoScaleMode = AutoScaleMode.Font
            Me.CancelButton = Me.btnBack
            Me.ClientSize = New Size(778, 339)
            Me.Controls.Add(Me.btn5P5)
            Me.Controls.Add(Me.btn4P5)
            Me.Controls.Add(Me.btn3P5)
            Me.Controls.Add(Me.btn2P5)
            Me.Controls.Add(Me.btn1P5)
            Me.Controls.Add(Me.btn5M5)
            Me.Controls.Add(Me.btn4M5)
            Me.Controls.Add(Me.btn3M5)
            Me.Controls.Add(Me.btn2M5)
            Me.Controls.Add(Me.btn1M5)
            Me.Controls.Add(Me.Label9)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.txtBuy5)
            Me.Controls.Add(Me.txtBuy4)
            Me.Controls.Add(Me.txtBuy3)
            Me.Controls.Add(Me.txtBuy2)
            Me.Controls.Add(Me.txtBuy1)
            Me.Controls.Add(Me.btn5P1)
            Me.Controls.Add(Me.btn5M1)
            Me.Controls.Add(Me.btn4P1)
            Me.Controls.Add(Me.btn4M1)
            Me.Controls.Add(Me.btn3P1)
            Me.Controls.Add(Me.btn3M1)
            Me.Controls.Add(Me.btn2P1)
            Me.Controls.Add(Me.btn2M1)
            Me.Controls.Add(Me.btn1P1)
            Me.Controls.Add(Me.btn1M1)
            Me.Controls.Add(Me.lblGoldRemaining)
            Me.Controls.Add(Me.Label8)
            Me.Controls.Add(Me.lblGoldOnHand)
            Me.Controls.Add(Me.lblGold1)
            Me.Controls.Add(Me.txtHire)
            Me.Controls.Add(Me.btnBack)
            Me.Controls.Add(Me.btnClear)
            Me.Controls.Add(Me.btnHire)
            Me.Controls.Add(Me.txtHenchmenLevel5)
            Me.Controls.Add(Me.Label7)
            Me.Controls.Add(Me.txtHenchmenLevel4)
            Me.Controls.Add(Me.Label6)
            Me.Controls.Add(Me.txtHenchmenLevel3)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.txtHenchmenLevel2)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.txtHenchmenLevel1)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.Label1)
            Me.Font = New Font("Arial", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Margin = New Padding(4)
            Me.MaximizeBox = False
            Me.MaximumSize = New Size(794, 378)
            Me.MinimumSize = New Size(794, 378)
            Me.Name = "frmHireHenchmen"
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.Text = "Hire Henchmen"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents TxtHire As TextBox
        Friend WithEvents BtnBack As Button
        Friend WithEvents BtnClear As Button
        Friend WithEvents BtnHire As Button
        Friend WithEvents TxtHenchmenLevel5 As TextBox
        Friend WithEvents Label7 As Label
        Friend WithEvents TxtHenchmenLevel4 As TextBox
        Friend WithEvents Label6 As Label
        Friend WithEvents TxtHenchmenLevel3 As TextBox
        Friend WithEvents Label5 As Label
        Friend WithEvents TxtHenchmenLevel2 As TextBox
        Friend WithEvents Label4 As Label
        Friend WithEvents TxtHenchmenLevel1 As TextBox
        Friend WithEvents Label3 As Label
        Friend WithEvents Label1 As Label
        Friend WithEvents lblGold1 As Label
        Friend WithEvents lblGoldOnHand As Label
        Friend WithEvents lblGoldRemaining As Label
        Friend WithEvents Label8 As Label
        Friend WithEvents Btn5P1 As Button
        Friend WithEvents Btn5M1 As Button
        Friend WithEvents Btn4P1 As Button
        Friend WithEvents Btn4M1 As Button
        Friend WithEvents Btn3P1 As Button
        Friend WithEvents Btn3M1 As Button
        Friend WithEvents Btn2P1 As Button
        Friend WithEvents Btn2M1 As Button
        Friend WithEvents Btn1P1 As Button
        Friend WithEvents Btn1M1 As Button
        Friend WithEvents TxtBuy1 As TextBox
        Friend WithEvents TxtBuy5 As TextBox
        Friend WithEvents TxtBuy4 As TextBox
        Friend WithEvents TxtBuy3 As TextBox
        Friend WithEvents TxtBuy2 As TextBox
        Friend WithEvents Label2 As Label
        Friend WithEvents Label9 As Label
        Friend WithEvents Btn5M5 As Button
        Friend WithEvents Btn4M5 As Button
        Friend WithEvents Btn3M5 As Button
        Friend WithEvents Btn2M5 As Button
        Friend WithEvents Btn1M5 As Button
        Friend WithEvents Btn5P5 As Button
        Friend WithEvents Btn4P5 As Button
        Friend WithEvents Btn3P5 As Button
        Friend WithEvents Btn2P5 As Button
        Friend WithEvents Btn1P5 As Button
    End Class
End NameSpace