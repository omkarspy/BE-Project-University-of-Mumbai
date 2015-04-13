<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customers
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
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.rdfemale = New System.Windows.Forms.RadioButton()
        Me.rdMale = New System.Windows.Forms.RadioButton()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSearchCriteria = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
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
        Me.txtCustId = New System.Windows.Forms.TextBox()
        Me.btnSaveChanges = New System.Windows.Forms.Button()
        Me.btnChangePic = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.txtMobileNo = New System.Windows.Forms.TextBox()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtPhoneNo = New System.Windows.Forms.TextBox()
        Me.txtPCode = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.txtCat = New System.Windows.Forms.TextBox()
        Me.txtDOB = New System.Windows.Forms.TextBox()
        Me.txtCardNo = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.pictCust = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape7 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape6 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape5 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape4 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnIssueCard = New System.Windows.Forms.Button()
        Me.btnReissueCard = New System.Windows.Forms.Button()
        Me.btnRevoke = New System.Windows.Forms.Button()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtUpdatedDate = New System.Windows.Forms.TextBox()
        Me.txtUpdatedBy = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCreatedDate = New System.Windows.Forms.TextBox()
        Me.txtCreatedBy = New System.Windows.Forms.TextBox()
        Me.txtOccupation = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtAnnIncome = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictCust, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(483, 223)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(89, 25)
        Me.btnAdd.TabIndex = 148
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        Me.btnAdd.Visible = False
        '
        'rdfemale
        '
        Me.rdfemale.AutoSize = True
        Me.rdfemale.Location = New System.Drawing.Point(173, 264)
        Me.rdfemale.Name = "rdfemale"
        Me.rdfemale.Size = New System.Drawing.Size(59, 17)
        Me.rdfemale.TabIndex = 147
        Me.rdfemale.TabStop = True
        Me.rdfemale.Text = "Female"
        Me.rdfemale.UseVisualStyleBackColor = True
        '
        'rdMale
        '
        Me.rdMale.AutoSize = True
        Me.rdMale.Location = New System.Drawing.Point(119, 264)
        Me.rdMale.Name = "rdMale"
        Me.rdMale.Size = New System.Drawing.Size(48, 17)
        Me.rdMale.TabIndex = 146
        Me.rdMale.TabStop = True
        Me.rdMale.Text = "Male"
        Me.rdMale.UseVisualStyleBackColor = True
        '
        'txtGender
        '
        Me.txtGender.Location = New System.Drawing.Point(238, 264)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(24, 20)
        Me.txtGender.TabIndex = 145
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 267)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 144
        Me.Label5.Text = "Gender"
        '
        'txtSearchCriteria
        '
        Me.txtSearchCriteria.Location = New System.Drawing.Point(267, 521)
        Me.txtSearchCriteria.Name = "txtSearchCriteria"
        Me.txtSearchCriteria.Size = New System.Drawing.Size(100, 20)
        Me.txtSearchCriteria.TabIndex = 143
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(481, 147)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(90, 23)
        Me.btnBrowse.TabIndex = 132
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        Me.btnBrowse.Visible = False
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(483, 281)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(88, 23)
        Me.btnRemove.TabIndex = 131
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(483, 252)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(89, 24)
        Me.btnUpdate.TabIndex = 130
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(497, 385)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(75, 23)
        Me.btnLast.TabIndex = 129
        Me.btnLast.Text = "Last"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(416, 386)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(75, 23)
        Me.btnPrevious.TabIndex = 128
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(496, 357)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 127
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(416, 357)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(75, 23)
        Me.btnFirst.TabIndex = 126
        Me.btnFirst.Text = "First"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(484, 310)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(87, 23)
        Me.btnClear.TabIndex = 125
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        Me.btnClear.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(185, 524)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 13)
        Me.Label11.TabIndex = 142
        Me.Label11.Text = "Search Criteria"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(27, 524)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(29, 13)
        Me.Label10.TabIndex = 141
        Me.Label10.Text = "Field"
        '
        'cboField
        '
        Me.cboField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboField.FormattingEnabled = True
        Me.cboField.Items.AddRange(New Object() {"Customer ID", "Name", "Card Number"})
        Me.cboField.Location = New System.Drawing.Point(62, 520)
        Me.cboField.Name = "cboField"
        Me.cboField.Size = New System.Drawing.Size(105, 21)
        Me.cboField.TabIndex = 140
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(385, 518)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(88, 25)
        Me.btnFind.TabIndex = 139
        Me.btnFind.Text = "Find"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'txtCustId
        '
        Me.txtCustId.Enabled = False
        Me.txtCustId.Location = New System.Drawing.Point(119, 106)
        Me.txtCustId.Name = "txtCustId"
        Me.txtCustId.Size = New System.Drawing.Size(94, 20)
        Me.txtCustId.TabIndex = 138
        '
        'btnSaveChanges
        '
        Me.btnSaveChanges.Location = New System.Drawing.Point(483, 251)
        Me.btnSaveChanges.Name = "btnSaveChanges"
        Me.btnSaveChanges.Size = New System.Drawing.Size(88, 26)
        Me.btnSaveChanges.TabIndex = 137
        Me.btnSaveChanges.Text = "Save Changes"
        Me.btnSaveChanges.UseVisualStyleBackColor = True
        Me.btnSaveChanges.Visible = False
        '
        'btnChangePic
        '
        Me.btnChangePic.Location = New System.Drawing.Point(481, 116)
        Me.btnChangePic.Name = "btnChangePic"
        Me.btnChangePic.Size = New System.Drawing.Size(90, 25)
        Me.btnChangePic.TabIndex = 135
        Me.btnChangePic.Text = "Change Picture"
        Me.btnChangePic.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(481, 176)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(90, 24)
        Me.btnSave.TabIndex = 134
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        Me.btnSave.Visible = False
        '
        'btnAddNew
        '
        Me.btnAddNew.Location = New System.Drawing.Point(483, 222)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(88, 24)
        Me.btnAddNew.TabIndex = 133
        Me.btnAddNew.Text = "Add New"
        Me.btnAddNew.UseVisualStyleBackColor = True
        '
        'txtMobileNo
        '
        Me.txtMobileNo.Location = New System.Drawing.Point(297, 395)
        Me.txtMobileNo.Name = "txtMobileNo"
        Me.txtMobileNo.Size = New System.Drawing.Size(71, 20)
        Me.txtMobileNo.TabIndex = 120
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(204, 395)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(58, 13)
        Me.Label15.TabIndex = 119
        Me.Label15.Text = "Mobile No."
        '
        'txtPhoneNo
        '
        Me.txtPhoneNo.Location = New System.Drawing.Point(119, 393)
        Me.txtPhoneNo.Name = "txtPhoneNo"
        Me.txtPhoneNo.Size = New System.Drawing.Size(71, 20)
        Me.txtPhoneNo.TabIndex = 118
        '
        'txtPCode
        '
        Me.txtPCode.Location = New System.Drawing.Point(119, 329)
        Me.txtPCode.Name = "txtPCode"
        Me.txtPCode.Size = New System.Drawing.Size(63, 20)
        Me.txtPCode.TabIndex = 117
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(119, 296)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(249, 20)
        Me.txtAddress.TabIndex = 116
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txtCat
        '
        Me.txtCat.Enabled = False
        Me.txtCat.Location = New System.Drawing.Point(119, 235)
        Me.txtCat.Name = "txtCat"
        Me.txtCat.Size = New System.Drawing.Size(33, 20)
        Me.txtCat.TabIndex = 115
        '
        'txtDOB
        '
        Me.txtDOB.Location = New System.Drawing.Point(119, 203)
        Me.txtDOB.Name = "txtDOB"
        Me.txtDOB.Size = New System.Drawing.Size(63, 20)
        Me.txtDOB.TabIndex = 114
        '
        'txtCardNo
        '
        Me.txtCardNo.Enabled = False
        Me.txtCardNo.Location = New System.Drawing.Point(119, 170)
        Me.txtCardNo.Name = "txtCardNo"
        Me.txtCardNo.Size = New System.Drawing.Size(94, 20)
        Me.txtCardNo.TabIndex = 113
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(119, 138)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(121, 20)
        Me.txtName.TabIndex = 112
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(166, 23)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(257, 42)
        Me.Label14.TabIndex = 111
        Me.Label14.Text = "CUSTOMERS"
        '
        'pictCust
        '
        Me.pictCust.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pictCust.Location = New System.Drawing.Point(303, 106)
        Me.pictCust.Name = "pictCust"
        Me.pictCust.Size = New System.Drawing.Size(138, 129)
        Me.pictCust.TabIndex = 110
        Me.pictCust.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(26, 396)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 109
        Me.Label9.Text = "Phone No."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(26, 332)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 13)
        Me.Label8.TabIndex = 108
        Me.Label8.Text = "Postal Code"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(26, 296)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 107
        Me.Label7.Text = "Address"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 235)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 106
        Me.Label6.Text = "Category"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 105
        Me.Label4.Text = "DOB"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 104
        Me.Label3.Text = "Card Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 103
        Me.Label2.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "Customer ID"
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BorderWidth = 3
        Me.RectangleShape2.Location = New System.Drawing.Point(67, 14)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(468, 61)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape7, Me.RectangleShape1, Me.RectangleShape3, Me.RectangleShape6, Me.RectangleShape5, Me.RectangleShape4, Me.LineShape1, Me.RectangleShape2})
        Me.ShapeContainer1.Size = New System.Drawing.Size(600, 597)
        Me.ShapeContainer1.TabIndex = 149
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape7
        '
        Me.RectangleShape7.BorderWidth = 2
        Me.RectangleShape7.Location = New System.Drawing.Point(16, 453)
        Me.RectangleShape7.Name = "RectangleShape7"
        Me.RectangleShape7.Size = New System.Drawing.Size(413, 41)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderWidth = 2
        Me.RectangleShape1.Location = New System.Drawing.Point(17, 511)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(470, 41)
        '
        'RectangleShape3
        '
        Me.RectangleShape3.BorderWidth = 2
        Me.RectangleShape3.Location = New System.Drawing.Point(16, 94)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.Size = New System.Drawing.Size(369, 339)
        '
        'RectangleShape6
        '
        Me.RectangleShape6.BorderWidth = 2
        Me.RectangleShape6.Location = New System.Drawing.Point(469, 110)
        Me.RectangleShape6.Name = "RectangleShape6"
        Me.RectangleShape6.Size = New System.Drawing.Size(111, 96)
        '
        'RectangleShape5
        '
        Me.RectangleShape5.BorderWidth = 2
        Me.RectangleShape5.Location = New System.Drawing.Point(469, 214)
        Me.RectangleShape5.Name = "RectangleShape5"
        Me.RectangleShape5.Size = New System.Drawing.Size(111, 127)
        '
        'RectangleShape4
        '
        Me.RectangleShape4.BorderWidth = 2
        Me.RectangleShape4.Location = New System.Drawing.Point(405, 351)
        Me.RectangleShape4.Name = "RectangleShape4"
        Me.RectangleShape4.Size = New System.Drawing.Size(175, 66)
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = -16
        Me.LineShape1.X2 = 609
        Me.LineShape1.Y1 = 562
        Me.LineShape1.Y2 = 562
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(484, 282)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(87, 22)
        Me.btnCancel.TabIndex = 150
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        Me.btnCancel.Visible = False
        '
        'btnIssueCard
        '
        Me.btnIssueCard.Location = New System.Drawing.Point(29, 461)
        Me.btnIssueCard.Name = "btnIssueCard"
        Me.btnIssueCard.Size = New System.Drawing.Size(92, 23)
        Me.btnIssueCard.TabIndex = 151
        Me.btnIssueCard.Text = "Issue Card"
        Me.btnIssueCard.UseVisualStyleBackColor = True
        '
        'btnReissueCard
        '
        Me.btnReissueCard.Location = New System.Drawing.Point(128, 461)
        Me.btnReissueCard.Name = "btnReissueCard"
        Me.btnReissueCard.Size = New System.Drawing.Size(92, 23)
        Me.btnReissueCard.TabIndex = 152
        Me.btnReissueCard.Text = "Reissue Card"
        Me.btnReissueCard.UseVisualStyleBackColor = True
        '
        'btnRevoke
        '
        Me.btnRevoke.Location = New System.Drawing.Point(226, 461)
        Me.btnRevoke.Name = "btnRevoke"
        Me.btnRevoke.Size = New System.Drawing.Size(92, 23)
        Me.btnRevoke.TabIndex = 153
        Me.btnRevoke.Text = "Revoke Card"
        Me.btnRevoke.UseVisualStyleBackColor = True
        '
        'btnCheck
        '
        Me.btnCheck.Location = New System.Drawing.Point(324, 461)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(92, 23)
        Me.btnCheck.TabIndex = 154
        Me.btnCheck.Text = "Check"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label16.Location = New System.Drawing.Point(481, 574)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(25, 15)
        Me.Label16.TabIndex = 162
        Me.Label16.Text = "UD"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label17.Location = New System.Drawing.Point(377, 574)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(24, 15)
        Me.Label17.TabIndex = 161
        Me.Label17.Text = "UB"
        '
        'txtUpdatedDate
        '
        Me.txtUpdatedDate.Enabled = False
        Me.txtUpdatedDate.Location = New System.Drawing.Point(510, 571)
        Me.txtUpdatedDate.Name = "txtUpdatedDate"
        Me.txtUpdatedDate.Size = New System.Drawing.Size(61, 20)
        Me.txtUpdatedDate.TabIndex = 160
        '
        'txtUpdatedBy
        '
        Me.txtUpdatedBy.Enabled = False
        Me.txtUpdatedBy.Location = New System.Drawing.Point(406, 571)
        Me.txtUpdatedBy.Name = "txtUpdatedBy"
        Me.txtUpdatedBy.Size = New System.Drawing.Size(68, 20)
        Me.txtUpdatedBy.TabIndex = 159
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.Location = New System.Drawing.Point(128, 571)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(24, 15)
        Me.Label13.TabIndex = 158
        Me.Label13.Text = "CD"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.Location = New System.Drawing.Point(24, 571)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(23, 15)
        Me.Label12.TabIndex = 157
        Me.Label12.Text = "CB"
        '
        'txtCreatedDate
        '
        Me.txtCreatedDate.Enabled = False
        Me.txtCreatedDate.Location = New System.Drawing.Point(157, 568)
        Me.txtCreatedDate.Name = "txtCreatedDate"
        Me.txtCreatedDate.Size = New System.Drawing.Size(61, 20)
        Me.txtCreatedDate.TabIndex = 156
        '
        'txtCreatedBy
        '
        Me.txtCreatedBy.Enabled = False
        Me.txtCreatedBy.Location = New System.Drawing.Point(53, 568)
        Me.txtCreatedBy.Name = "txtCreatedBy"
        Me.txtCreatedBy.Size = New System.Drawing.Size(68, 20)
        Me.txtCreatedBy.TabIndex = 155
        '
        'txtOccupation
        '
        Me.txtOccupation.Enabled = False
        Me.txtOccupation.Location = New System.Drawing.Point(119, 364)
        Me.txtOccupation.Name = "txtOccupation"
        Me.txtOccupation.Size = New System.Drawing.Size(71, 20)
        Me.txtOccupation.TabIndex = 164
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(26, 367)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(62, 13)
        Me.Label18.TabIndex = 163
        Me.Label18.Text = "Occupation"
        '
        'txtAnnIncome
        '
        Me.txtAnnIncome.Enabled = False
        Me.txtAnnIncome.Location = New System.Drawing.Point(297, 364)
        Me.txtAnnIncome.Name = "txtAnnIncome"
        Me.txtAnnIncome.Size = New System.Drawing.Size(71, 20)
        Me.txtAnnIncome.TabIndex = 166
        Me.txtAnnIncome.Text = "0"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(204, 367)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(78, 13)
        Me.Label19.TabIndex = 165
        Me.Label19.Text = "Annual Income"
        '
        'Customers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 597)
        Me.Controls.Add(Me.txtAnnIncome)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtOccupation)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtUpdatedDate)
        Me.Controls.Add(Me.txtUpdatedBy)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtCreatedDate)
        Me.Controls.Add(Me.txtCreatedBy)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.btnRevoke)
        Me.Controls.Add(Me.btnReissueCard)
        Me.Controls.Add(Me.btnIssueCard)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.rdfemale)
        Me.Controls.Add(Me.rdMale)
        Me.Controls.Add(Me.txtGender)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtSearchCriteria)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.btnRemove)
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
        Me.Controls.Add(Me.txtCustId)
        Me.Controls.Add(Me.btnSaveChanges)
        Me.Controls.Add(Me.btnChangePic)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnAddNew)
        Me.Controls.Add(Me.txtMobileNo)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtPhoneNo)
        Me.Controls.Add(Me.txtPCode)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtCat)
        Me.Controls.Add(Me.txtDOB)
        Me.Controls.Add(Me.txtCardNo)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.pictCust)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Customers"
        Me.Text = "Customers"
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictCust, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents rdfemale As System.Windows.Forms.RadioButton
    Friend WithEvents rdMale As System.Windows.Forms.RadioButton
    Friend WithEvents txtGender As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSearchCriteria As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
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
    Friend WithEvents txtCustId As System.Windows.Forms.TextBox
    Friend WithEvents btnSaveChanges As System.Windows.Forms.Button
    Friend WithEvents btnChangePic As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnAddNew As System.Windows.Forms.Button
    Friend WithEvents txtMobileNo As System.Windows.Forms.TextBox
    Friend WithEvents FileSystemWatcher1 As System.IO.FileSystemWatcher
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtPhoneNo As System.Windows.Forms.TextBox
    Friend WithEvents txtPCode As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtCat As System.Windows.Forms.TextBox
    Friend WithEvents txtDOB As System.Windows.Forms.TextBox
    Friend WithEvents txtCardNo As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents pictCust As System.Windows.Forms.PictureBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents RectangleShape4 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape5 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape6 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnCheck As System.Windows.Forms.Button
    Friend WithEvents btnRevoke As System.Windows.Forms.Button
    Friend WithEvents btnReissueCard As System.Windows.Forms.Button
    Friend WithEvents btnIssueCard As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtUpdatedDate As System.Windows.Forms.TextBox
    Friend WithEvents txtUpdatedBy As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtCreatedDate As System.Windows.Forms.TextBox
    Friend WithEvents txtCreatedBy As System.Windows.Forms.TextBox
    Friend WithEvents txtAnnIncome As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtOccupation As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents RectangleShape3 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape7 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
End Class
