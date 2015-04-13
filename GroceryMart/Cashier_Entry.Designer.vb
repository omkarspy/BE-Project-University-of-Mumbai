<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cashier_Entry
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
        Me.components = New System.ComponentModel.Container()
        Me.txtPAmt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDisc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRecv = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnCalAmt = New System.Windows.Forms.Button()
        Me.txtTPrice = New System.Windows.Forms.TextBox()
        Me.txtTotalNo = New System.Windows.Forms.TextBox()
        Me.txtTRNo = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape6 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape5 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape4 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboCardNo = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtProdID = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboCName = New System.Windows.Forms.ComboBox()
        Me.cboPName = New System.Windows.Forms.ComboBox()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtUPrice = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.rdYes = New System.Windows.Forms.RadioButton()
        Me.rdNo = New System.Windows.Forms.RadioButton()
        Me.txtChange = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtTD = New System.Windows.Forms.TextBox()
        Me.txtCID = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtTT = New System.Windows.Forms.TextBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnCalChange = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnAvailDisc = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtCredits = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPAmt
        '
        Me.txtPAmt.Enabled = False
        Me.txtPAmt.Location = New System.Drawing.Point(709, 395)
        Me.txtPAmt.Name = "txtPAmt"
        Me.txtPAmt.Size = New System.Drawing.Size(46, 20)
        Me.txtPAmt.TabIndex = 270
        Me.txtPAmt.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(635, 398)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 269
        Me.Label2.Text = "Payment Amt."
        '
        'txtDisc
        '
        Me.txtDisc.Enabled = False
        Me.txtDisc.Location = New System.Drawing.Point(709, 363)
        Me.txtDisc.Name = "txtDisc"
        Me.txtDisc.Size = New System.Drawing.Size(46, 20)
        Me.txtDisc.TabIndex = 268
        Me.txtDisc.Text = "0.0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(635, 368)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 267
        Me.Label1.Text = "Discount"
        '
        'txtRecv
        '
        Me.txtRecv.Enabled = False
        Me.txtRecv.Location = New System.Drawing.Point(709, 427)
        Me.txtRecv.Name = "txtRecv"
        Me.txtRecv.Size = New System.Drawing.Size(46, 20)
        Me.txtRecv.TabIndex = 266
        Me.txtRecv.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(635, 430)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(42, 13)
        Me.Label13.TabIndex = 265
        Me.Label13.Text = "Recvd."
        '
        'btnCalAmt
        '
        Me.btnCalAmt.Location = New System.Drawing.Point(621, 521)
        Me.btnCalAmt.Name = "btnCalAmt"
        Me.btnCalAmt.Size = New System.Drawing.Size(98, 25)
        Me.btnCalAmt.TabIndex = 264
        Me.btnCalAmt.Text = "Calculate Amount"
        Me.btnCalAmt.UseVisualStyleBackColor = True
        '
        'txtTPrice
        '
        Me.txtTPrice.Enabled = False
        Me.txtTPrice.Location = New System.Drawing.Point(709, 329)
        Me.txtTPrice.Name = "txtTPrice"
        Me.txtTPrice.Size = New System.Drawing.Size(46, 20)
        Me.txtTPrice.TabIndex = 263
        Me.txtTPrice.Text = "0"
        '
        'txtTotalNo
        '
        Me.txtTotalNo.Enabled = False
        Me.txtTotalNo.Location = New System.Drawing.Point(709, 298)
        Me.txtTotalNo.Name = "txtTotalNo"
        Me.txtTotalNo.Size = New System.Drawing.Size(46, 20)
        Me.txtTotalNo.TabIndex = 262
        Me.txtTotalNo.Text = "0"
        '
        'txtTRNo
        '
        Me.txtTRNo.Enabled = False
        Me.txtTRNo.Location = New System.Drawing.Point(162, 128)
        Me.txtTRNo.Name = "txtTRNo"
        Me.txtTRNo.Size = New System.Drawing.Size(74, 20)
        Me.txtTRNo.TabIndex = 261
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(351, 29)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(159, 42)
        Me.Label14.TabIndex = 260
        Me.Label14.Text = "BILLING"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(635, 332)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 259
        Me.Label7.Text = "Total Price"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(635, 301)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 258
        Me.Label4.Text = "Total Items"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(66, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 257
        Me.Label3.Text = "Transaction No."
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BorderWidth = 3
        Me.RectangleShape2.Location = New System.Drawing.Point(119, 20)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(591, 59)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape6, Me.RectangleShape5, Me.RectangleShape3, Me.RectangleShape1, Me.RectangleShape4, Me.LineShape1, Me.RectangleShape2})
        Me.ShapeContainer1.Size = New System.Drawing.Size(856, 660)
        Me.ShapeContainer1.TabIndex = 271
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape6
        '
        Me.RectangleShape6.BorderWidth = 2
        Me.RectangleShape6.Location = New System.Drawing.Point(625, 559)
        Me.RectangleShape6.Name = "RectangleShape6"
        Me.RectangleShape6.Size = New System.Drawing.Size(192, 45)
        '
        'RectangleShape5
        '
        Me.RectangleShape5.BorderWidth = 2
        Me.RectangleShape5.Location = New System.Drawing.Point(601, 278)
        Me.RectangleShape5.Name = "RectangleShape5"
        Me.RectangleShape5.Size = New System.Drawing.Size(239, 281)
        '
        'RectangleShape3
        '
        Me.RectangleShape3.BorderWidth = 2
        Me.RectangleShape3.Location = New System.Drawing.Point(40, 117)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.Size = New System.Drawing.Size(222, 44)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderWidth = 2
        Me.RectangleShape1.Location = New System.Drawing.Point(12, 198)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(829, 57)
        '
        'RectangleShape4
        '
        Me.RectangleShape4.BorderWidth = 2
        Me.RectangleShape4.Location = New System.Drawing.Point(276, 106)
        Me.RectangleShape4.Name = "RectangleShape4"
        Me.RectangleShape4.Size = New System.Drawing.Size(463, 67)
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = -1
        Me.LineShape1.X2 = 872
        Me.LineShape1.Y1 = 617
        Me.LineShape1.Y2 = 617
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(292, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 272
        Me.Label5.Text = "Card Number"
        '
        'txtCustomerID
        '
        Me.txtCustomerID.Enabled = False
        Me.txtCustomerID.Location = New System.Drawing.Point(609, 142)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.Size = New System.Drawing.Size(106, 20)
        Me.txtCustomerID.TabIndex = 275
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(516, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 274
        Me.Label6.Text = "Customer ID"
        '
        'cboCardNo
        '
        Me.cboCardNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCardNo.Enabled = False
        Me.cboCardNo.FormattingEnabled = True
        Me.cboCardNo.Location = New System.Drawing.Point(385, 142)
        Me.cboCardNo.Name = "cboCardNo"
        Me.cboCardNo.Size = New System.Drawing.Size(106, 21)
        Me.cboCardNo.TabIndex = 276
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(184, 222)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 13)
        Me.Label8.TabIndex = 277
        Me.Label8.Text = "Product Name"
        '
        'txtProdID
        '
        Me.txtProdID.Enabled = False
        Me.txtProdID.Location = New System.Drawing.Point(477, 218)
        Me.txtProdID.Name = "txtProdID"
        Me.txtProdID.Size = New System.Drawing.Size(81, 20)
        Me.txtProdID.TabIndex = 280
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(413, 223)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 279
        Me.Label9.Text = "Product ID"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 190)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 13)
        Me.Label10.TabIndex = 281
        Me.Label10.Text = "Select Product"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(15, 222)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 13)
        Me.Label11.TabIndex = 282
        Me.Label11.Text = "Category"
        '
        'cboCName
        '
        Me.cboCName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCName.FormattingEnabled = True
        Me.cboCName.Location = New System.Drawing.Point(70, 218)
        Me.cboCName.Name = "cboCName"
        Me.cboCName.Size = New System.Drawing.Size(100, 21)
        Me.cboCName.TabIndex = 283
        '
        'cboPName
        '
        Me.cboPName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPName.Enabled = False
        Me.cboPName.FormattingEnabled = True
        Me.cboPName.Location = New System.Drawing.Point(265, 218)
        Me.cboPName.Name = "cboPName"
        Me.cboPName.Size = New System.Drawing.Size(134, 21)
        Me.cboPName.TabIndex = 285
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(601, 220)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(27, 20)
        Me.txtQty.TabIndex = 287
        Me.txtQty.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(572, 223)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(23, 13)
        Me.Label12.TabIndex = 286
        Me.Label12.Text = "Qty"
        '
        'txtUPrice
        '
        Me.txtUPrice.Enabled = False
        Me.txtUPrice.Location = New System.Drawing.Point(699, 220)
        Me.txtUPrice.Name = "txtUPrice"
        Me.txtUPrice.Size = New System.Drawing.Size(46, 20)
        Me.txtUPrice.TabIndex = 289
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(635, 223)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(53, 13)
        Me.Label15.TabIndex = 288
        Me.Label15.Text = "Unit Price"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(292, 118)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(60, 13)
        Me.Label16.TabIndex = 290
        Me.Label16.Text = "Subscribed"
        '
        'rdYes
        '
        Me.rdYes.AutoSize = True
        Me.rdYes.Location = New System.Drawing.Point(358, 116)
        Me.rdYes.Name = "rdYes"
        Me.rdYes.Size = New System.Drawing.Size(43, 17)
        Me.rdYes.TabIndex = 291
        Me.rdYes.TabStop = True
        Me.rdYes.Text = "Yes"
        Me.rdYes.UseVisualStyleBackColor = True
        '
        'rdNo
        '
        Me.rdNo.AutoSize = True
        Me.rdNo.Location = New System.Drawing.Point(407, 116)
        Me.rdNo.Name = "rdNo"
        Me.rdNo.Size = New System.Drawing.Size(39, 17)
        Me.rdNo.TabIndex = 292
        Me.rdNo.TabStop = True
        Me.rdNo.Text = "No"
        Me.rdNo.UseVisualStyleBackColor = True
        '
        'txtChange
        '
        Me.txtChange.Enabled = False
        Me.txtChange.Location = New System.Drawing.Point(709, 460)
        Me.txtChange.Name = "txtChange"
        Me.txtChange.Size = New System.Drawing.Size(46, 20)
        Me.txtChange.TabIndex = 295
        Me.txtChange.Text = "0"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(635, 463)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(44, 13)
        Me.Label17.TabIndex = 294
        Me.Label17.Text = "Change"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label18.Location = New System.Drawing.Point(612, 633)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(24, 15)
        Me.Label18.TabIndex = 299
        Me.Label18.Text = "TD"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label19.Location = New System.Drawing.Point(12, 633)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(58, 15)
        Me.Label19.TabIndex = 298
        Me.Label19.Text = "Cashier ID"
        '
        'txtTD
        '
        Me.txtTD.Enabled = False
        Me.txtTD.Location = New System.Drawing.Point(641, 630)
        Me.txtTD.Name = "txtTD"
        Me.txtTD.Size = New System.Drawing.Size(61, 20)
        Me.txtTD.TabIndex = 297
        '
        'txtCID
        '
        Me.txtCID.Enabled = False
        Me.txtCID.Location = New System.Drawing.Point(81, 630)
        Me.txtCID.Name = "txtCID"
        Me.txtCID.Size = New System.Drawing.Size(68, 20)
        Me.txtCID.TabIndex = 296
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label21.Location = New System.Drawing.Point(710, 633)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(23, 15)
        Me.Label21.TabIndex = 302
        Me.Label21.Text = "TT"
        '
        'txtTT
        '
        Me.txtTT.Enabled = False
        Me.txtTT.Location = New System.Drawing.Point(739, 630)
        Me.txtTT.Name = "txtTT"
        Me.txtTT.Size = New System.Drawing.Size(68, 20)
        Me.txtTT.TabIndex = 300
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(638, 570)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(82, 25)
        Me.btnPrint.TabIndex = 303
        Me.btnPrint.Text = "Print Bill"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(725, 570)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(82, 25)
        Me.btnClose.TabIndex = 304
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnCalChange
        '
        Me.btnCalChange.Enabled = False
        Me.btnCalChange.Location = New System.Drawing.Point(725, 522)
        Me.btnCalChange.Name = "btnCalChange"
        Me.btnCalChange.Size = New System.Drawing.Size(98, 24)
        Me.btnCalChange.TabIndex = 305
        Me.btnCalChange.Text = "Cal. Change "
        Me.btnCalChange.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Enabled = False
        Me.btnAdd.Location = New System.Drawing.Point(761, 216)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(70, 25)
        Me.btnAdd.TabIndex = 306
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(18, 276)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(549, 329)
        Me.DataGridView1.TabIndex = 307
        '
        'btnAvailDisc
        '
        Me.btnAvailDisc.Location = New System.Drawing.Point(761, 360)
        Me.btnAvailDisc.Name = "btnAvailDisc"
        Me.btnAvailDisc.Size = New System.Drawing.Size(62, 25)
        Me.btnAvailDisc.TabIndex = 308
        Me.btnAvailDisc.Text = "Avail"
        Me.btnAvailDisc.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'txtCredits
        '
        Me.txtCredits.Enabled = False
        Me.txtCredits.Location = New System.Drawing.Point(709, 492)
        Me.txtCredits.Name = "txtCredits"
        Me.txtCredits.Size = New System.Drawing.Size(46, 20)
        Me.txtCredits.TabIndex = 310
        Me.txtCredits.Text = "0"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(638, 495)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(39, 13)
        Me.Label20.TabIndex = 309
        Me.Label20.Text = "Credits"
        '
        'Cashier_Entry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 660)
        Me.Controls.Add(Me.txtCredits)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.btnAvailDisc)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnCalChange)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.txtTT)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtTD)
        Me.Controls.Add(Me.txtCID)
        Me.Controls.Add(Me.txtChange)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.rdNo)
        Me.Controls.Add(Me.rdYes)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtUPrice)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cboPName)
        Me.Controls.Add(Me.cboCName)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtProdID)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cboCardNo)
        Me.Controls.Add(Me.txtCustomerID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPAmt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDisc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtRecv)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.btnCalAmt)
        Me.Controls.Add(Me.txtTPrice)
        Me.Controls.Add(Me.txtTotalNo)
        Me.Controls.Add(Me.txtTRNo)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Cashier_Entry"
        Me.Text = "Cashier Entry"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPAmt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDisc As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtRecv As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnCalAmt As System.Windows.Forms.Button
    Friend WithEvents txtTPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalNo As System.Windows.Forms.TextBox
    Friend WithEvents txtTRNo As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerID As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboCardNo As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtProdID As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cboCName As System.Windows.Forms.ComboBox
    Friend WithEvents cboPName As System.Windows.Forms.ComboBox
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtUPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents rdYes As System.Windows.Forms.RadioButton
    Friend WithEvents rdNo As System.Windows.Forms.RadioButton
    Friend WithEvents txtChange As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtTD As System.Windows.Forms.TextBox
    Friend WithEvents txtCID As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtTT As System.Windows.Forms.TextBox
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnCalChange As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents RectangleShape4 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape3 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents btnAvailDisc As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents RectangleShape6 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape5 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents txtCredits As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
End Class
