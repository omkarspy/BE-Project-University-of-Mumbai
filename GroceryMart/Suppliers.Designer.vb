<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Suppliers
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
        Me.txtRegion = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtSearchCriteria = New System.Windows.Forms.TextBox()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboField = New System.Windows.Forms.ComboBox()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.txtSuppId = New System.Windows.Forms.TextBox()
        Me.btnSaveChanges = New System.Windows.Forms.Button()
        Me.btnChangePic = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtPhoneNo = New System.Windows.Forms.TextBox()
        Me.txtPCode = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtCTitle = New System.Windows.Forms.TextBox()
        Me.txtCtName = New System.Windows.Forms.TextBox()
        Me.txtCName = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.pictSupp = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.RectangleShape5 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape4 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape6 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtUpdatedDate = New System.Windows.Forms.TextBox()
        Me.txtUpdatedBy = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCreatedDate = New System.Windows.Forms.TextBox()
        Me.txtCreatedBy = New System.Windows.Forms.TextBox()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictSupp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtRegion
        '
        Me.txtRegion.Location = New System.Drawing.Point(125, 314)
        Me.txtRegion.Name = "txtRegion"
        Me.txtRegion.Size = New System.Drawing.Size(71, 20)
        Me.txtRegion.TabIndex = 198
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(125, 283)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(71, 20)
        Me.txtCity.TabIndex = 197
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 317)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 196
        Me.Label5.Text = "Region"
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(32, 286)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(24, 13)
        Me.lblCity.TabIndex = 195
        Me.lblCity.Text = "City"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(493, 228)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(89, 25)
        Me.btnAdd.TabIndex = 194
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        Me.btnAdd.Visible = False
        '
        'txtSearchCriteria
        '
        Me.txtSearchCriteria.Location = New System.Drawing.Point(275, 470)
        Me.txtSearchCriteria.Name = "txtSearchCriteria"
        Me.txtSearchCriteria.Size = New System.Drawing.Size(100, 20)
        Me.txtSearchCriteria.TabIndex = 193
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(493, 145)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(88, 23)
        Me.btnBrowse.TabIndex = 182
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        Me.btnBrowse.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(493, 258)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(89, 24)
        Me.btnUpdate.TabIndex = 180
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(507, 391)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(75, 23)
        Me.btnLast.TabIndex = 179
        Me.btnLast.Text = "Last"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(426, 391)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(75, 23)
        Me.btnPrevious.TabIndex = 178
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(505, 362)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 177
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(426, 362)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(75, 23)
        Me.btnFirst.TabIndex = 176
        Me.btnFirst.Text = "First"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(494, 316)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(87, 23)
        Me.btnClear.TabIndex = 175
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        Me.btnClear.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(193, 473)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 13)
        Me.Label11.TabIndex = 192
        Me.Label11.Text = "Search Criteria"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(33, 473)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(29, 13)
        Me.Label10.TabIndex = 191
        Me.Label10.Text = "Field"
        '
        'cboField
        '
        Me.cboField.FormattingEnabled = True
        Me.cboField.Items.AddRange(New Object() {"Supplier ID", "Name"})
        Me.cboField.Location = New System.Drawing.Point(68, 470)
        Me.cboField.Name = "cboField"
        Me.cboField.Size = New System.Drawing.Size(105, 21)
        Me.cboField.TabIndex = 190
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(393, 467)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(88, 25)
        Me.btnFind.TabIndex = 189
        Me.btnFind.Text = "Find"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'txtSuppId
        '
        Me.txtSuppId.Enabled = False
        Me.txtSuppId.Location = New System.Drawing.Point(125, 114)
        Me.txtSuppId.Name = "txtSuppId"
        Me.txtSuppId.Size = New System.Drawing.Size(94, 20)
        Me.txtSuppId.TabIndex = 188
        '
        'btnSaveChanges
        '
        Me.btnSaveChanges.Location = New System.Drawing.Point(493, 257)
        Me.btnSaveChanges.Name = "btnSaveChanges"
        Me.btnSaveChanges.Size = New System.Drawing.Size(88, 26)
        Me.btnSaveChanges.TabIndex = 187
        Me.btnSaveChanges.Text = "Save Changes"
        Me.btnSaveChanges.UseVisualStyleBackColor = True
        Me.btnSaveChanges.Visible = False
        '
        'btnChangePic
        '
        Me.btnChangePic.Location = New System.Drawing.Point(493, 114)
        Me.btnChangePic.Name = "btnChangePic"
        Me.btnChangePic.Size = New System.Drawing.Size(88, 25)
        Me.btnChangePic.TabIndex = 185
        Me.btnChangePic.Text = "Change Picture"
        Me.btnChangePic.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(493, 174)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 24)
        Me.btnSave.TabIndex = 184
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        Me.btnSave.Visible = False
        '
        'btnAddNew
        '
        Me.btnAddNew.Location = New System.Drawing.Point(493, 228)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(88, 24)
        Me.btnAddNew.TabIndex = 183
        Me.btnAddNew.Text = "Add New"
        Me.btnAddNew.UseVisualStyleBackColor = True
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(125, 412)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(121, 20)
        Me.txtEmail.TabIndex = 170
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(32, 415)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 13)
        Me.Label15.TabIndex = 169
        Me.Label15.Text = "Email ID"
        '
        'txtPhoneNo
        '
        Me.txtPhoneNo.Location = New System.Drawing.Point(125, 380)
        Me.txtPhoneNo.Name = "txtPhoneNo"
        Me.txtPhoneNo.Size = New System.Drawing.Size(71, 20)
        Me.txtPhoneNo.TabIndex = 168
        '
        'txtPCode
        '
        Me.txtPCode.Location = New System.Drawing.Point(125, 349)
        Me.txtPCode.Name = "txtPCode"
        Me.txtPCode.Size = New System.Drawing.Size(63, 20)
        Me.txtPCode.TabIndex = 167
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(125, 248)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(188, 20)
        Me.txtAddress.TabIndex = 166
        '
        'txtCTitle
        '
        Me.txtCTitle.Location = New System.Drawing.Point(125, 214)
        Me.txtCTitle.Name = "txtCTitle"
        Me.txtCTitle.Size = New System.Drawing.Size(94, 20)
        Me.txtCTitle.TabIndex = 165
        '
        'txtCtName
        '
        Me.txtCtName.Location = New System.Drawing.Point(125, 181)
        Me.txtCtName.Name = "txtCtName"
        Me.txtCtName.Size = New System.Drawing.Size(121, 20)
        Me.txtCtName.TabIndex = 164
        '
        'txtCName
        '
        Me.txtCName.Location = New System.Drawing.Point(125, 149)
        Me.txtCName.Name = "txtCName"
        Me.txtCName.Size = New System.Drawing.Size(121, 20)
        Me.txtCName.TabIndex = 163
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(199, 25)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(227, 42)
        Me.Label14.TabIndex = 162
        Me.Label14.Text = "SUPPLIERS"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pictSupp
        '
        Me.pictSupp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pictSupp.Location = New System.Drawing.Point(313, 113)
        Me.pictSupp.Name = "pictSupp"
        Me.pictSupp.Size = New System.Drawing.Size(138, 129)
        Me.pictSupp.TabIndex = 161
        Me.pictSupp.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(32, 383)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 160
        Me.Label9.Text = "Phone No."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(32, 352)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 13)
        Me.Label8.TabIndex = 159
        Me.Label8.Text = "Postal Code"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(32, 251)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 158
        Me.Label7.Text = "Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 217)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 157
        Me.Label4.Text = "Contact Title"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 156
        Me.Label3.Text = "Contact Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 155
        Me.Label2.Text = "Company Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 154
        Me.Label1.Text = "Supplier ID"
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(493, 287)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(88, 23)
        Me.btnRemove.TabIndex = 199
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(494, 288)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(87, 22)
        Me.btnCancel.TabIndex = 200
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        Me.btnCancel.Visible = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape2, Me.LineShape1, Me.RectangleShape5, Me.RectangleShape4, Me.RectangleShape1, Me.RectangleShape6, Me.RectangleShape3})
        Me.ShapeContainer1.Size = New System.Drawing.Size(616, 559)
        Me.ShapeContainer1.TabIndex = 201
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BorderWidth = 3
        Me.RectangleShape2.Location = New System.Drawing.Point(76, 16)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(466, 59)
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = -13
        Me.LineShape1.X2 = 612
        Me.LineShape1.Y1 = 522
        Me.LineShape1.Y2 = 522
        '
        'RectangleShape5
        '
        Me.RectangleShape5.BorderWidth = 2
        Me.RectangleShape5.Location = New System.Drawing.Point(23, 459)
        Me.RectangleShape5.Name = "RectangleShape5"
        Me.RectangleShape5.Size = New System.Drawing.Size(470, 41)
        '
        'RectangleShape4
        '
        Me.RectangleShape4.BorderWidth = 2
        Me.RectangleShape4.Location = New System.Drawing.Point(414, 357)
        Me.RectangleShape4.Name = "RectangleShape4"
        Me.RectangleShape4.Size = New System.Drawing.Size(179, 63)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderWidth = 2
        Me.RectangleShape1.Location = New System.Drawing.Point(482, 221)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(111, 124)
        '
        'RectangleShape6
        '
        Me.RectangleShape6.BorderWidth = 2
        Me.RectangleShape6.Location = New System.Drawing.Point(482, 108)
        Me.RectangleShape6.Name = "RectangleShape6"
        Me.RectangleShape6.Size = New System.Drawing.Size(111, 96)
        '
        'RectangleShape3
        '
        Me.RectangleShape3.BorderWidth = 2
        Me.RectangleShape3.Location = New System.Drawing.Point(23, 99)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.Size = New System.Drawing.Size(366, 345)
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label16.Location = New System.Drawing.Point(488, 534)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(25, 15)
        Me.Label16.TabIndex = 209
        Me.Label16.Text = "UD"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label17.Location = New System.Drawing.Point(384, 534)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(24, 15)
        Me.Label17.TabIndex = 208
        Me.Label17.Text = "UB"
        '
        'txtUpdatedDate
        '
        Me.txtUpdatedDate.Enabled = False
        Me.txtUpdatedDate.Location = New System.Drawing.Point(517, 531)
        Me.txtUpdatedDate.Name = "txtUpdatedDate"
        Me.txtUpdatedDate.Size = New System.Drawing.Size(61, 20)
        Me.txtUpdatedDate.TabIndex = 207
        '
        'txtUpdatedBy
        '
        Me.txtUpdatedBy.Enabled = False
        Me.txtUpdatedBy.Location = New System.Drawing.Point(413, 531)
        Me.txtUpdatedBy.Name = "txtUpdatedBy"
        Me.txtUpdatedBy.Size = New System.Drawing.Size(68, 20)
        Me.txtUpdatedBy.TabIndex = 206
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.Location = New System.Drawing.Point(135, 531)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(24, 15)
        Me.Label13.TabIndex = 205
        Me.Label13.Text = "CD"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.Location = New System.Drawing.Point(31, 531)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(23, 15)
        Me.Label12.TabIndex = 204
        Me.Label12.Text = "CB"
        '
        'txtCreatedDate
        '
        Me.txtCreatedDate.Enabled = False
        Me.txtCreatedDate.Location = New System.Drawing.Point(164, 528)
        Me.txtCreatedDate.Name = "txtCreatedDate"
        Me.txtCreatedDate.Size = New System.Drawing.Size(61, 20)
        Me.txtCreatedDate.TabIndex = 203
        '
        'txtCreatedBy
        '
        Me.txtCreatedBy.Enabled = False
        Me.txtCreatedBy.Location = New System.Drawing.Point(60, 528)
        Me.txtCreatedBy.Name = "txtCreatedBy"
        Me.txtCreatedBy.Size = New System.Drawing.Size(68, 20)
        Me.txtCreatedBy.TabIndex = 202
        '
        'Suppliers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 559)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtUpdatedDate)
        Me.Controls.Add(Me.txtUpdatedBy)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtCreatedDate)
        Me.Controls.Add(Me.txtCreatedBy)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.txtRegion)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblCity)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtSearchCriteria)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cboField)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.txtSuppId)
        Me.Controls.Add(Me.btnSaveChanges)
        Me.Controls.Add(Me.btnChangePic)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnAddNew)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtPhoneNo)
        Me.Controls.Add(Me.txtPCode)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtCTitle)
        Me.Controls.Add(Me.txtCtName)
        Me.Controls.Add(Me.txtCName)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.pictSupp)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Suppliers"
        Me.Text = "Suppliers"
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictSupp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtRegion As System.Windows.Forms.TextBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtSearchCriteria As System.Windows.Forms.TextBox
    Friend WithEvents FileSystemWatcher1 As System.IO.FileSystemWatcher
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cboField As System.Windows.Forms.ComboBox
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents txtSuppId As System.Windows.Forms.TextBox
    Friend WithEvents btnSaveChanges As System.Windows.Forms.Button
    Friend WithEvents btnChangePic As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnAddNew As System.Windows.Forms.Button
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtPhoneNo As System.Windows.Forms.TextBox
    Friend WithEvents txtPCode As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtCTitle As System.Windows.Forms.TextBox
    Friend WithEvents txtCtName As System.Windows.Forms.TextBox
    Friend WithEvents txtCName As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents pictSupp As System.Windows.Forms.PictureBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape3 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape4 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape6 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape5 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtUpdatedDate As System.Windows.Forms.TextBox
    Friend WithEvents txtUpdatedBy As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtCreatedDate As System.Windows.Forms.TextBox
    Friend WithEvents txtCreatedBy As System.Windows.Forms.TextBox
End Class
