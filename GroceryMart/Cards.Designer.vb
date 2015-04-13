<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cards
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
        Me.txtIssuingAuth = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.txtCredits = New System.Windows.Forms.TextBox()
        Me.txtExpiryOn = New System.Windows.Forms.TextBox()
        Me.txtIssuedOn = New System.Windows.Forms.TextBox()
        Me.txtValidity = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCardNo = New System.Windows.Forms.TextBox()
        Me.txtCardType = New System.Windows.Forms.TextBox()
        Me.cboCardType = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtUpdatedDate = New System.Windows.Forms.TextBox()
        Me.txtUpdatedBy = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCreatedDate = New System.Windows.Forms.TextBox()
        Me.txtCreatedBy = New System.Windows.Forms.TextBox()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(291, 224)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(89, 25)
        Me.btnAdd.TabIndex = 196
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtIssuingAuth
        '
        Me.txtIssuingAuth.Location = New System.Drawing.Point(124, 217)
        Me.txtIssuingAuth.Name = "txtIssuingAuth"
        Me.txtIssuingAuth.Size = New System.Drawing.Size(63, 20)
        Me.txtIssuingAuth.TabIndex = 193
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 220)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 192
        Me.Label5.Text = "Issuing Authority"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(291, 255)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(89, 24)
        Me.btnUpdate.TabIndex = 179
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'txtCredits
        '
        Me.txtCredits.Enabled = False
        Me.txtCredits.Location = New System.Drawing.Point(124, 252)
        Me.txtCredits.Name = "txtCredits"
        Me.txtCredits.Size = New System.Drawing.Size(63, 20)
        Me.txtCredits.TabIndex = 165
        '
        'txtExpiryOn
        '
        Me.txtExpiryOn.Enabled = False
        Me.txtExpiryOn.Location = New System.Drawing.Point(317, 181)
        Me.txtExpiryOn.Name = "txtExpiryOn"
        Me.txtExpiryOn.Size = New System.Drawing.Size(63, 20)
        Me.txtExpiryOn.TabIndex = 164
        '
        'txtIssuedOn
        '
        Me.txtIssuedOn.Enabled = False
        Me.txtIssuedOn.Location = New System.Drawing.Point(124, 181)
        Me.txtIssuedOn.Name = "txtIssuedOn"
        Me.txtIssuedOn.Size = New System.Drawing.Size(63, 20)
        Me.txtIssuedOn.TabIndex = 163
        '
        'txtValidity
        '
        Me.txtValidity.Enabled = False
        Me.txtValidity.Location = New System.Drawing.Point(317, 144)
        Me.txtValidity.Name = "txtValidity"
        Me.txtValidity.Size = New System.Drawing.Size(63, 20)
        Me.txtValidity.TabIndex = 162
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(31, 255)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 156
        Me.Label7.Text = "Credits"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(224, 184)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 155
        Me.Label6.Text = "Expiry On"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 154
        Me.Label4.Text = "Issued On"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(224, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 153
        Me.Label3.Text = "Card Validity"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 152
        Me.Label2.Text = "Card Type"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 149)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 151
        Me.Label1.Text = "Card No."
        '
        'txtCardNo
        '
        Me.txtCardNo.Enabled = False
        Me.txtCardNo.Location = New System.Drawing.Point(124, 146)
        Me.txtCardNo.Name = "txtCardNo"
        Me.txtCardNo.Size = New System.Drawing.Size(63, 20)
        Me.txtCardNo.TabIndex = 199
        '
        'txtCardType
        '
        Me.txtCardType.Enabled = False
        Me.txtCardType.Location = New System.Drawing.Point(124, 105)
        Me.txtCardType.Name = "txtCardType"
        Me.txtCardType.Size = New System.Drawing.Size(63, 20)
        Me.txtCardType.TabIndex = 200
        Me.txtCardType.Visible = False
        '
        'cboCardType
        '
        Me.cboCardType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCardType.FormattingEnabled = True
        Me.cboCardType.Items.AddRange(New Object() {"Silver", "Gold", "Platinum"})
        Me.cboCardType.Location = New System.Drawing.Point(124, 105)
        Me.cboCardType.Name = "cboCardType"
        Me.cboCardType.Size = New System.Drawing.Size(121, 21)
        Me.cboCardType.TabIndex = 201
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(81, 32)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(245, 42)
        Me.Label14.TabIndex = 203
        Me.Label14.Text = "CARD ISSUE"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label16.Location = New System.Drawing.Point(316, 306)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(25, 15)
        Me.Label16.TabIndex = 211
        Me.Label16.Text = "UD"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label17.Location = New System.Drawing.Point(212, 306)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(24, 15)
        Me.Label17.TabIndex = 210
        Me.Label17.Text = "UB"
        '
        'txtUpdatedDate
        '
        Me.txtUpdatedDate.Enabled = False
        Me.txtUpdatedDate.Location = New System.Drawing.Point(345, 303)
        Me.txtUpdatedDate.Name = "txtUpdatedDate"
        Me.txtUpdatedDate.Size = New System.Drawing.Size(61, 20)
        Me.txtUpdatedDate.TabIndex = 209
        '
        'txtUpdatedBy
        '
        Me.txtUpdatedBy.Enabled = False
        Me.txtUpdatedBy.Location = New System.Drawing.Point(241, 303)
        Me.txtUpdatedBy.Name = "txtUpdatedBy"
        Me.txtUpdatedBy.Size = New System.Drawing.Size(68, 20)
        Me.txtUpdatedBy.TabIndex = 208
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.Location = New System.Drawing.Point(113, 306)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(24, 15)
        Me.Label13.TabIndex = 207
        Me.Label13.Text = "CD"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.Location = New System.Drawing.Point(9, 306)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(23, 15)
        Me.Label12.TabIndex = 206
        Me.Label12.Text = "CB"
        '
        'txtCreatedDate
        '
        Me.txtCreatedDate.Enabled = False
        Me.txtCreatedDate.Location = New System.Drawing.Point(142, 303)
        Me.txtCreatedDate.Name = "txtCreatedDate"
        Me.txtCreatedDate.Size = New System.Drawing.Size(61, 20)
        Me.txtCreatedDate.TabIndex = 205
        '
        'txtCreatedBy
        '
        Me.txtCreatedBy.Enabled = False
        Me.txtCreatedBy.Location = New System.Drawing.Point(38, 303)
        Me.txtCreatedBy.Name = "txtCreatedBy"
        Me.txtCreatedBy.Size = New System.Drawing.Size(68, 20)
        Me.txtCreatedBy.TabIndex = 204
        '
        'RectangleShape3
        '
        Me.RectangleShape3.BorderWidth = 2
        Me.RectangleShape3.Location = New System.Drawing.Point(22, 65)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.Size = New System.Drawing.Size(370, 222)
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = -106
        Me.LineShape1.X2 = 519
        Me.LineShape1.Y1 = 298
        Me.LineShape1.Y2 = 298
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BorderWidth = 3
        Me.RectangleShape2.Location = New System.Drawing.Point(79, 28)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(248, 54)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderWidth = 2
        Me.RectangleShape1.Location = New System.Drawing.Point(277, 217)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(115, 70)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1, Me.RectangleShape2, Me.LineShape1, Me.RectangleShape3})
        Me.ShapeContainer1.Size = New System.Drawing.Size(412, 326)
        Me.ShapeContainer1.TabIndex = 212
        Me.ShapeContainer1.TabStop = False
        '
        'Cards
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 326)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtUpdatedDate)
        Me.Controls.Add(Me.txtUpdatedBy)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtCreatedDate)
        Me.Controls.Add(Me.txtCreatedBy)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cboCardType)
        Me.Controls.Add(Me.txtCardType)
        Me.Controls.Add(Me.txtCardNo)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtIssuingAuth)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtCredits)
        Me.Controls.Add(Me.txtExpiryOn)
        Me.Controls.Add(Me.txtIssuedOn)
        Me.Controls.Add(Me.txtValidity)
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
        Me.Name = "Cards"
        Me.Text = "Cards"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtIssuingAuth As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents txtCredits As System.Windows.Forms.TextBox
    Friend WithEvents txtExpiryOn As System.Windows.Forms.TextBox
    Friend WithEvents txtIssuedOn As System.Windows.Forms.TextBox
    Friend WithEvents txtValidity As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCardNo As System.Windows.Forms.TextBox
    Friend WithEvents cboCardType As System.Windows.Forms.ComboBox
    Friend WithEvents txtCardType As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtUpdatedDate As System.Windows.Forms.TextBox
    Friend WithEvents txtUpdatedBy As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtCreatedDate As System.Windows.Forms.TextBox
    Friend WithEvents txtCreatedBy As System.Windows.Forms.TextBox
    Friend WithEvents RectangleShape3 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
End Class
