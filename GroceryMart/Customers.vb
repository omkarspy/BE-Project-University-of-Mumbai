
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class Customers

    Dim objConnection As New SqlConnection("Data Source=OMKAR-PC\OMKAR;Initial Catalog=Grocery_Mart;Integrated Security=True")
    Dim objConnection2 As New SqlConnection("Data Source=OMKAR-PC\OMKAR;Initial Catalog=Grocery_Mart;Integrated Security=True")
    Dim objConnection3 As New SqlConnection("Data Source=OMKAR-PC\OMKAR;Initial Catalog=Grocery_Mart;Integrated Security=True")
    Dim objDataAdapter As New SqlDataAdapter("SELECT * from Customers", objConnection)
    Dim objDataSet As DataSet
    Dim objDataView As DataView
    Dim objCurrencyManager As CurrencyManager

    Public chkv As Integer
    Dim chkn As Integer = 0

    Dim str1 As String
    Dim filename As String = "D:\BEProject2012\eBEST Grocery_files\proj_work\Images\img1.png"
    Dim finfo As FileInfo
    Dim fStream As FileStream
    Private Sub FillDataSetAndView()
        ' Initialize a new instance of the DataSet object..
        objDataSet = New DataSet()
        ' Fill the DataSet object with data..
        objDataAdapter.Fill(objDataSet, "Customers")
        ' Set the DataView object to the DataSet object..
        objDataView = New DataView(objDataSet.Tables("Customers"))
        ' Set our CurrencyManager object to the DataView object..
        objCurrencyManager = CType(Me.BindingContext(objDataView), CurrencyManager)
    End Sub
    Private Sub ImageDisp()
        Dim imgcmd As New SqlCommand("Select pic from Customers where CustomerID =@CustID", objConnection)
        imgcmd.Parameters.AddWithValue("@CustID", txtCustId.Text)
        Try
            objConnection.Open()
            pictCust.Image = Image.FromStream(New IO.MemoryStream(CType(imgcmd.ExecuteScalar, Byte())))
            ' or you can save in a file 
            'IO.File.WriteAllBytes("c:\backup\image3.jpg", CType(cmd.ExecuteScalar, Byte()))
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            objConnection.Close()
        End Try

    End Sub
    Private Sub clear_BindFields()
        ' Clear any previous bindings..

        txtCustId.DataBindings.Clear()
        txtName.DataBindings.Clear()
        txtCardNo.DataBindings.Clear()
        txtDOB.DataBindings.Clear()
        txtGender.DataBindings.Clear()
        txtCat.DataBindings.Clear()
        txtAddress.DataBindings.Clear()
        txtPCode.DataBindings.Clear()
        txtOccupation.DataBindings.Clear()
        txtAnnIncome.DataBindings.Clear()
        txtPhoneNo.DataBindings.Clear()
        txtMobileNo.DataBindings.Clear()
        txtCreatedBy.DataBindings.Clear()
        txtCreatedDate.DataBindings.Clear()
        txtUpdatedBy.DataBindings.Clear()
        txtUpdatedDate.DataBindings.Clear()
        pictCust.DataBindings.Clear()
    End Sub

    Private Sub BindFields()

        clear_BindFields()

        ' Add new bindings to the DataView object..
        txtCustId.DataBindings.Add("Text", objDataView, "CustomerID")
        txtName.DataBindings.Add("Text", objDataView, "Name")
        txtCardNo.DataBindings.Add("Text", objDataView, "Card_Number")
        txtDOB.DataBindings.Add("Text", objDataView, "DOB")
        txtGender.DataBindings.Add("Text", objDataView, "Gender")
        txtCat.DataBindings.Add("Text", objDataView, "Category")
        txtAddress.DataBindings.Add("Text", objDataView, "Address")
        txtPCode.DataBindings.Add("Text", objDataView, "Pcode")
        txtOccupation.DataBindings.Add("Text", objDataView, "Occupation")
        txtAnnIncome.DataBindings.Add("Text", objDataView, "Annual_Income")
        txtPhoneNo.DataBindings.Add("Text", objDataView, "Phone_no")
        txtMobileNo.DataBindings.Add("Text", objDataView, "Mobile_no")
        txtCreatedBy.DataBindings.Add("Text", objDataView, "Created_By")
        txtCreatedDate.DataBindings.Add("Text", objDataView, "Created_Date")
        txtUpdatedBy.DataBindings.Add("Text", objDataView, "Updated_By")
        txtUpdatedDate.DataBindings.Add("Text", objDataView, "Updated_Date")



    End Sub
    Private Sub Gender_Chk()
        If txtGender.Text.ToString = "M" Then
            rdMale.Checked = True
        Else
            rdfemale.Checked = True
        End If
    End Sub
    Private Sub EnableAll()
        txtName.Enabled = True
        txtAddress.Enabled = True
        txtPCode.Enabled = True
        txtOccupation.Enabled = True
        txtAnnIncome.Enabled = True
        txtPhoneNo.Enabled = True
        txtMobileNo.Enabled = True
    End Sub

    Private Sub DisableAll()
        txtName.Enabled = False
        txtAddress.Enabled = False
        txtPCode.Enabled = False
        txtOccupation.Enabled = False
        txtAnnIncome.Enabled = False
        txtPhoneNo.Enabled = False
        txtMobileNo.Enabled = False
    End Sub
    Private Sub Clear()

        txtName.Text = " "
        txtCardNo.Text = " "
        txtDOB.Text = " "
        txtCat.Text = " "
        txtGender.Text = " "
        rdMale.Checked = False
        rdfemale.Checked = False
        txtAddress.Text = " "
        txtPCode.Text = " "
        txtOccupation.Text = " "
        txtAnnIncome.Text = " "
        txtPhoneNo.Text = " "
        txtMobileNo.Text = " "
        txtCreatedBy.Text = " "
        txtUpdatedBy.Text = " "
        txtUpdatedDate.Text = " "
        pictCust.ImageLocation = "D:\BEProject2012\eBEST Grocery_files\proj_work\Images\img1.png"
        clear_BindFields()
    End Sub
    Private Function Verify()
        If (txtName.Text = " " Or txtDOB.Text = " " Or txtAddress.Text = " " Or txtPCode.Text = " " Or txtOccupation.Text = " " Or txtAnnIncome.Text = " " Or txtMobileNo.Text = " ") Then
            Return False
        Else
            Return True
        End If
    End Function
    Private Sub customers_chk()
        Dim objCmdchk As New SqlCommand
        Dim count As Integer
        Try
            objCmdchk = New SqlCommand("SELECT count(*) from Customers", objConnection)
            objConnection.Open()
            count = objCmdchk.ExecuteScalar
            objConnection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        If count = 0 Then
            Clear()
            txtCustId.Text = " "
            btnAddNew.Enabled = True
            btnUpdate.Enabled = False
            btnRemove.Enabled = False
            btnChangePic.Enabled = False
            btnFirst.Enabled = False
            btnNext.Enabled = False
            btnPrevious.Enabled = False
            btnLast.Enabled = False
        Else
            btnAddNew.Enabled = True
            btnUpdate.Enabled = True
            btnRemove.Enabled = True
            btnChangePic.Enabled = True
            btnFirst.Enabled = True
            btnNext.Enabled = True
            btnPrevious.Enabled = True
            btnLast.Enabled = True
            FillDataSetAndView()
            BindFields()
            ImageDisp()
            Gender_Chk()
            CardChk()
            position_chk()
        End If
    End Sub
    Private Sub Customers_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Visible = True
        Me.Refresh()
        DisableAll()
        btnCancel.Visible = False
        btnClear.Visible = False
        btnSaveChanges.Visible = False
        customers_chk()
        txtGender.Visible = False
        txtDOB.Enabled = False
        rdMale.Enabled = False
        rdfemale.Enabled = False
        txtCat.Text = " "
        btnFind.Focus()
    End Sub
    Public Sub CardChk()
        If (txtCardNo.Text = " " Or txtCardNo.Text.Length = 0) Then
            btnIssueCard.Enabled = True
            btnReissueCard.Enabled = False
            btnRevoke.Enabled = False
            btnCheck.Enabled = False
        Else
            Dim ObjCmdCC As New SqlCommand
            Dim validity As String = "No"
            Try
                ObjCmdCC.CommandText = "Select Card_Validity from Cards c1, Customers c2  where c1.Card_No = c2.Card_Number and c2.CustomerID = @Cust_ID"
                ObjCmdCC.Parameters.AddWithValue("@Cust_ID", txtCustId.Text)
                ObjCmdCC.Connection = objConnection
                objConnection.Open()
                validity = ObjCmdCC.ExecuteScalar()
                objConnection.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            If validity = "Yes" Then
                btnIssueCard.Enabled = False
                btnReissueCard.Enabled = False
                btnCheck.Enabled = True
            Else
                btnIssueCard.Enabled = False
                btnReissueCard.Enabled = True
                btnRevoke.Enabled = True
                btnCheck.Enabled = True
            End If

        End If
    End Sub
    Private Sub position_chk()
        If (objCurrencyManager.Position = 0) Then
            btnFirst.Enabled = False
            btnPrevious.Enabled = False
            btnNext.Enabled = True
            btnLast.Enabled = True
        ElseIf (objCurrencyManager.Position = objCurrencyManager.Count - 1) Then
            btnLast.Enabled = False
            btnNext.Enabled = False
            btnPrevious.Enabled = True
            btnFirst.Enabled = True
        Else
            btnPrevious.Enabled = True
            btnNext.Enabled = True
            btnFirst.Enabled = True
            btnLast.Enabled = True
        End If
    End Sub
    Private Sub First_Click(sender As System.Object, e As System.EventArgs) Handles btnFirst.Click
        ' Set the record position to the first record..
        objCurrencyManager.Position = 0
        position_chk()
        Gender_Chk()
        ImageDisp()
        CardChk()
    End Sub

    Private Sub Next_Click(sender As System.Object, e As System.EventArgs) Handles btnNext.Click
        ' Move to the next record..
        objCurrencyManager.Position += 1
        position_chk()
        Gender_Chk()
        ImageDisp()
        CardChk()
    End Sub

    Private Sub Previous_Click(sender As System.Object, e As System.EventArgs) Handles btnPrevious.Click
        ' Move to the previous record..
        objCurrencyManager.Position -= 1
        position_chk()
        Gender_Chk()
        ImageDisp()
        CardChk()
    End Sub

    Private Sub Last_Click(sender As System.Object, e As System.EventArgs) Handles btnLast.Click
        ' Set the record position to the last record..
        objCurrencyManager.Position = objCurrencyManager.Count - 1
        position_chk()
        Gender_Chk()
        ImageDisp()
        CardChk()
    End Sub

    Private Sub btnUpdate_Click(sender As System.Object, e As System.EventArgs) Handles btnUpdate.Click
        clear_BindFields()
        btnSaveChanges.Visible = True
        btnUpdate.Visible = False
        btnAddNew.Enabled = False
        btnRemove.Enabled = False
        btnCancel.Visible = True

        btnFirst.Enabled = False
        btnNext.Enabled = False
        btnPrevious.Enabled = False
        btnLast.Enabled = False
        btnFind.Enabled = False

        EnableAll()

    End Sub


    Private Sub btnSaveChanges_Click(sender As System.Object, e As System.EventArgs) Handles btnSaveChanges.Click
        Dim custid As String = txtCustId.Text
        If Verify() Then
            Try
                Dim objCmd2 As New SqlCommand
                Dim Position = objCurrencyManager.Position
                objCmd2.Connection = objConnection
                objCmd2.CommandText = "Update Customers Set Name = @Name,Category = @Category,Address = @Address, PCode = @PCode,Occupation = @Occupation, Annual_Income = @AIncome, Phone_no = @Phone_no,Mobile_no = @Mobile_no, Updated_By = @Updated_By, Updated_Date = @Updated_Date where CustomerID = @CustID"
                objCmd2.Parameters.AddWithValue("@CustID", txtCustId.Text)
                objCmd2.Parameters.AddWithValue("@Name", txtName.Text)
                objCmd2.Parameters.AddWithValue("@Category", txtCat.Text)
                objCmd2.Parameters.AddWithValue("@Address", txtAddress.Text)
                objCmd2.Parameters.AddWithValue("@PCode", txtPCode.Text)
                objCmd2.Parameters.AddWithValue("@Occupation", txtOccupation.Text)
                objCmd2.Parameters.AddWithValue("@AIncome", txtAnnIncome.Text)
                objCmd2.Parameters.AddWithValue("@Phone_no", txtPhoneNo.Text)
                objCmd2.Parameters.AddWithValue("@Mobile_no", txtMobileNo.Text)
                objCmd2.Parameters.AddWithValue("@Updated_By", MDIParent1.ToolStripStatusLabel3.Text)
                objCmd2.Parameters.AddWithValue("@Updated_Date", Date.Today)
                objConnection.Open()
                objCmd2.ExecuteNonQuery()
                objConnection.Close()

                MsgBox("You have Successfully Updated this Record")
                btnSaveChanges.Visible = False
                btnUpdate.Visible = True
                btnAddNew.Enabled = True
                btnRemove.Enabled = True
                btnCancel.Visible = False
                btnFind.Enabled = True
                btnUpdate.Enabled = True

                btnFirst.Enabled = True
                btnNext.Enabled = True
                btnPrevious.Enabled = True
                btnLast.Enabled = True
                DisableAll()


                ' Fill the DataSet and bind the fields..
                FillDataSetAndView()
                BindFields()
                ' Set the record position to the one that you saved..
                objCurrencyManager.Position = Position
                Gender_Chk()
                ImageDisp()
                CardChk()
               
            Catch ex As Exception
            MsgBox(ex.ToString)
            End Try
        Else
            MessageBox.Show("Fields cannot be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
       Update_ODS(custid)

    End Sub

    Private Sub btnRemove_Click(sender As System.Object, e As System.EventArgs) Handles btnRemove.Click
        Dim objCmd3 As New SqlCommand
        Dim custid As String = txtCustId.Text
        Dim Position = objCurrencyManager.Position
        Try
            objConnection.Open()
            objCmd3.Connection = objConnection
            objCmd3.CommandText = "Delete from Customers where CustomerID = @CustID"
            objCmd3.Parameters.AddWithValue("@CustID", txtCustId.Text)
            objCmd3.ExecuteNonQuery()

            MsgBox("You have Successfully Deleted the Record.")

            objConnection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Dim objCmdSD As New SqlCommand
        Try
            objCmdSD.Connection = objConnection3
            objCmdSD.CommandText = "Insert into Customers_Delete_Log Select count(SrNo) +1, '" & custid & "' from Customers_Delete_Log"
            objConnection3.Open()
            objCmdSD.ExecuteNonQuery()
            objConnection3.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Me.Close()
        End Try
        Dim count As Integer
        Try
            Dim objCmdchk = New SqlCommand("SELECT count(*) from Customers", objConnection)
            objConnection.Open()
            count = objCmdchk.ExecuteScalar
            objConnection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        If count = 0 Then
            customers_chk()
        Else
            FillDataSetAndView()
            BindFields()
            objCurrencyManager.Position = Position - 1
            ImageDisp()
            Gender_Chk()
            CardChk()

        End If
    End Sub

    Private Sub btnAddNew_Click(sender As System.Object, e As System.EventArgs) Handles btnAddNew.Click
        Clear()
        btnCancel.Visible = True
        btnAdd.Visible = True
        btnAddNew.Visible = False
        btnUpdate.Enabled = False
        btnRemove.Enabled = False
        btnBrowse.Visible = True
        btnBrowse.Enabled = True
        btnSave.Enabled = True
        btnClear.Visible = True
        btnChangePic.Visible = False
        btnFind.Enabled = False
        btnFirst.Enabled = False
        btnNext.Enabled = False
        btnPrevious.Enabled = False
        btnLast.Enabled = False
        EnableAll()



        txtDOB.Enabled = True
        rdMale.Enabled = True
        rdfemale.Enabled = True
        rdMale.Checked = True

        Dim objcmdL As New SqlCommand
        Dim cusid As String = " "
        Try

            objcmdL.Connection = objConnection3
            objcmdL.CommandText = "Select CustomerID from Customers_Current_Log"
            objConnection3.Open()
            cusid = objcmdL.ExecuteScalar()
            objConnection3.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Try
            If cusid = Nothing Then
                txtCustId.Text = "C0000001"
                chkn = 1
            Else
                Dim cid As String
                cid = "C" + (Val("1" + cusid.Substring(1, 7)) + 1).ToString.Substring(1, 7)
                txtCustId.Text = cid
            End If
        Catch ex As Exception
        End Try
        txtCreatedBy.Text = MDIParent1.ToolStripStatusLabel3.Text
        txtCreatedDate.Text = Date.Today
        txtCat.Text = " "
    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click

        Dim custid As String = txtCustId.Text
        If Verify() Then

            Dim objCmd1 As New SqlCommand
            Try
                objConnection.Open()

                finfo = New FileInfo(filename)
                Dim btimage(finfo.Length) As Byte
                fStream = finfo.OpenRead()
                fStream.Read(btimage, 0, btimage.Length)
                fStream.Close()

                If rdMale.Checked = True Then
                    txtGender.Text = "M"
                Else
                    txtGender.Text = "F"
                End If

                objCmd1.Connection = objConnection
                objCmd1.CommandText = "Insert into Customers Select @CustomerID,@Name,Null,@DOB,@Gender,@Category,@Address,@PCode,@Occupation,@AIncome,@Phone_no,@Mobile_no,@Created_By,@Created_Date,Null,Null,@pic"
                objCmd1.Parameters.AddWithValue("@CustomerID", txtCustId.Text)
                objCmd1.Parameters.AddWithValue("@Name", txtName.Text)
                objCmd1.Parameters.Add(New SqlParameter("@DOB", SqlDbType.Date)).Value = txtDOB.Text
                objCmd1.Parameters.AddWithValue("@Gender", txtGender.Text)
                objCmd1.Parameters.AddWithValue("@Category", txtCat.Text)
                objCmd1.Parameters.AddWithValue("@Address", txtAddress.Text)
                objCmd1.Parameters.AddWithValue("@PCode", txtPCode.Text)
                objCmd1.Parameters.AddWithValue("@Occupation", txtOccupation.Text)
                objCmd1.Parameters.AddWithValue("@AIncome", txtAnnIncome.Text)
                objCmd1.Parameters.AddWithValue("@Phone_no", txtPhoneNo.Text)
                objCmd1.Parameters.AddWithValue("@Mobile_no", txtMobileNo.Text)
                objCmd1.Parameters.AddWithValue("@Created_By", MDIParent1.ToolStripStatusLabel3.Text)
                objCmd1.Parameters.AddWithValue("@Created_Date", Date.Today)
                objCmd1.Parameters.Add(New SqlParameter("@pic", SqlDbType.Image)).Value = btimage
                objCmd1.ExecuteNonQuery()

                objConnection.Close()

                MsgBox("You have Successfully Added the Record")

                btnClear.Visible = False
                btnAdd.Visible = False
                btnChangePic.Visible = True
                btnAddNew.Visible = True
                btnBrowse.Visible = False
                btnSave.Visible = False
                btnCancel.Visible = False
                btnFind.Enabled = True

                btnFirst.Enabled = True
                btnNext.Enabled = True
                btnPrevious.Enabled = True
                btnLast.Enabled = True
                btnUpdate.Enabled = True
                btnRemove.Enabled = True


                txtDOB.Enabled = False
                rdMale.Enabled = False
                rdfemale.Enabled = False

                DisableAll()


            Catch ex As Exception
                MsgBox(ex.ToString)
                Me.Close()
            End Try

            FillDataSetAndView()
            BindFields()
            ImageDisp()
            Gender_Chk()
            CardChk()

        Else
            MessageBox.Show("Fields cannot be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End If
        Dim objCmdSI As New SqlCommand
        Try
            objCmdSI.Connection = objConnection2
            objCmdSI.CommandText = "Insert into dbo.ODS_Customers Select *, 'I' as Op from dbo.Customers where dbo.Customers.CustomerID = '" & custid & "'"
            objConnection2.Open()
            objCmdSI.ExecuteNonQuery()
            objConnection2.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Me.Close()
        End Try
        Dim objCmdCR As New SqlCommand
        Try
            objCmdCR.Connection = objConnection3
            objCmdCR.CommandText = "Delete from Customers_Current_Log"
            objConnection3.Open()
            objCmdCR.ExecuteNonQuery()
            objConnection3.Close()
            objCmdCR.CommandText = "Insert into Customers_Current_Log Select count(SrNo) +1, '" & custid & "' from Customers_Current_Log"
            objConnection3.Open()
            objCmdCR.ExecuteNonQuery()
            objConnection3.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Me.Close()
        End Try
        If chkn = 1 Then
            Me.Close()
        End If
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        Clear()
    End Sub

    Private Sub btnChangePic_Click(sender As System.Object, e As System.EventArgs) Handles btnChangePic.Click
        btnBrowse.Visible = True
        btnSave.Visible = True
        btnChangePic.Enabled = False
        btnCancel.Visible = True
        btnAddNew.Enabled = False
        btnUpdate.Enabled = False
        btnRemove.Enabled = False
        btnFirst.Enabled = False
        btnNext.Enabled = False
        btnPrevious.Enabled = False
        btnLast.Enabled = False
        btnFind.Enabled = False

    End Sub

    Private Sub btnBrowse_Click(sender As System.Object, e As System.EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.Title = "Please Select an Image."
        OpenFileDialog1.InitialDirectory = "D:\BEProject2012\"
        OpenFileDialog1.Filter = "Image Files(*.bmp;*.jpg;*.gif;*.png)|*.bmp;*.jpg;*gif;*.png"
        OpenFileDialog1.ShowDialog()
        btnBrowse.Enabled = False
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Dim custid As String = txtCustId.Text
        If filename = "D:\BEProject2012\eBEST Grocery_files\proj_work\Images\img1.png" Then
            MsgBox("Select the Employee's photo.")
        Else
            Dim objCmd4 As New SqlCommand
            Try
                objConnection.Open()

                finfo = New FileInfo(filename)
                Dim btimage(finfo.Length) As Byte
                fStream = finfo.OpenRead()
                fStream.Read(btimage, 0, btimage.Length)
                fStream.Close()

                objCmd4.Connection = objConnection
                objCmd4.CommandText = "Update Customers Set Updated_By = @Updated_By, Updated_Date = @Updated_Date, pic = @pic where CustomerID = @CustomerID"
                objCmd4.Parameters.AddWithValue("@CustomerID", txtCustId.Text)
                objCmd4.Parameters.AddWithValue("@Updated_By", MDIParent1.ToolStripStatusLabel3.Text)
                objCmd4.Parameters.AddWithValue("@Updated_Date", Date.Today)
                objCmd4.Parameters.Add(New SqlParameter("@pic", SqlDbType.Image)).Value = btimage
                objCmd4.ExecuteNonQuery()

                MsgBox("You have Successfully Changed the Image")

                objConnection.Close()

                btnChangePic.Enabled = True

                btnBrowse.Visible = False
                btnSave.Visible = False
                btnCancel.Visible = False

                btnAddNew.Enabled = True
                btnUpdate.Enabled = True
                btnRemove.Enabled = True
                btnFirst.Enabled = True
                btnNext.Enabled = True
                btnPrevious.Enabled = True
                btnLast.Enabled = True
                btnFind.Enabled = True
                ImageDisp()

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
        Update_ODS(custid)
    End Sub
    Private Sub Update_ODS(custid As String)
        Dim objCmdSU As New SqlCommand
        Try
            objCmdSU.Connection = objConnection2
            objCmdSU.CommandText = "Delete from ODS_Customers where CustomerID = '" & custid & "'"
            objConnection2.Open()
            objCmdSU.ExecuteNonQuery()
            objConnection2.Close()
            objCmdSU.CommandText = "Insert into dbo.ODS_Customers Select *, 'U' as Op from dbo.Customers where dbo.Customers.CustomerID = '" & custid & "'"
            objConnection2.Open()
            objCmdSU.ExecuteNonQuery()
            objConnection2.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Me.Close()
        End Try
    End Sub
    Private Sub OpenFileDialog1_FileOk(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        filename = OpenFileDialog1.FileName.ToString()
    End Sub

    Private Sub btnFind_Click(sender As System.Object, e As System.EventArgs) Handles btnFind.Click
        If (cboField.Text.Length = 0) Then
            MsgBox("Select the Field to be Searched")

        ElseIf (txtSearchCriteria.Text.Length = 0) Then
            MsgBox("Select the Search Criteria to be Searched")
        Else

            Dim intPosition As Integer
            Select Case cboField.SelectedIndex
                Case 0
                    objDataView.Sort = "CustomerID"
                Case 1
                    objDataView.Sort = "Name"
                Case 2
                    objDataView.Sort = "Card_Number"
            End Select


            intPosition = objDataView.Find(Trim(txtSearchCriteria.Text))

            If intPosition = -1 Then
                MsgBox("Record Not Found.")
            Else
                MsgBox("Record Found.")
                objCurrencyManager.Position = intPosition
                Gender_Chk()
                ImageDisp()
                CardChk()
            End If



            cboField.Text = " "
            txtSearchCriteria.Text = " "
        End If
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Dim Position = objCurrencyManager.Position
        FillDataSetAndView()
        BindFields()
        objCurrencyManager.Position = Position
        Gender_Chk()
        ImageDisp()
        CardChk()

        btnSaveChanges.Visible = False
        btnSave.Visible = False
        btnBrowse.Visible = False
        btnChangePic.Visible = True
        btnChangePic.Enabled = True
        btnUpdate.Visible = True
        btnUpdate.Enabled = True
        btnAddNew.Enabled = True
        btnRemove.Enabled = True
        btnCancel.Visible = False
        btnClear.Visible = False
        btnAdd.Visible = False
        btnAddNew.Visible = True
        btnFirst.Enabled = True
        btnNext.Enabled = True
        btnPrevious.Enabled = True
        btnLast.Enabled = True
        btnFind.Enabled = True
        DisableAll()



        txtDOB.Enabled = False
        rdMale.Enabled = False
        rdfemale.Enabled = False

    End Sub


    Private Sub btnIssueCard_Click(sender As System.Object, e As System.EventArgs) Handles btnIssueCard.Click
        Dim custid As String = txtCustId.Text
        Cards.Show()
        Cards.txtCreatedBy.Text = MDIParent1.ToolStripStatusLabel3.Text
        Cards.txtCreatedDate.Text = Date.Today
        Cards.btnUpdate.Enabled = False
        Update_ODS(custid)

    End Sub

    Private Sub btnReissueCard_Click(sender As System.Object, e As System.EventArgs) Handles btnReissueCard.Click
        Dim custid As String = txtCustId.Text
        chkv = 1
        Cards.Show()
        Cards.Label4.Text = "Reissued On"
        Cards.cboCardType.Visible = False
        Cards.txtCardType.Visible = True
        Cards.btnAdd.Enabled = False
        Cards.txtUpdatedBy.Text = MDIParent1.ToolStripStatusLabel3.Text
        Cards.txtUpdatedDate.Text = Date.Today
        Update_ODS(custid)
    End Sub

    Private Sub btnRevoke_Click(sender As System.Object, e As System.EventArgs) Handles btnRevoke.Click
        Dim objCmd5 As New SqlCommand
        Dim objCmd6 As New SqlCommand
        Dim cardno As String = txtCardNo.Text
        Dim custid As String = txtCustId.Text
        Dim pos = objCurrencyManager.Position
        Try
            objConnection.Open()
            objCmd5.Connection = objConnection
            objCmd6.Connection = objConnection

            objCmd5.CommandText = "Delete from Cards where Card_No = @CardNo"
            objCmd5.Parameters.AddWithValue("@CardNo", cardno)
            objCmd5.ExecuteNonQuery()


            objCmd6.CommandText = "Update Customers Set Card_Number = Null,Updated_By = @Updated_By,Updated_Date = @Updated_Date where Card_Number = @CardNo"
            objCmd6.Parameters.AddWithValue("@CardNo", cardno)
            objCmd6.Parameters.AddWithValue("@Updated_By", MDIParent1.ToolStripStatusLabel3.Text)
            objCmd6.Parameters.AddWithValue("@Updated_Date", Date.Today)
            objCmd6.ExecuteNonQuery()
            objConnection.Close()


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        ' Fill the DataSet and bind the fields..
        FillDataSetAndView()
        BindFields()
        ' Set the record position to the one that you saved..
        objCurrencyManager.Position = pos
        Gender_Chk()
        ImageDisp()
        CardChk()
        Update_ODS(custid)
        Dim objCmdSD As New SqlCommand
        Try

            objCmdSD.Connection = objConnection3
            objCmdSD.CommandText = "Insert into Cards_Delete_Log Select count(SrNo) +1, '" & cardno & "' from Cards_Delete_Log"
            objConnection3.Open()
            objCmdSD.ExecuteNonQuery()
            objConnection3.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
            Me.Close()
        End Try
    End Sub

    Private Sub btnCheck_Click(sender As System.Object, e As System.EventArgs) Handles btnCheck.Click
        chkv = 1
        Cards.Show()
        Cards.cboCardType.Visible = False
        Cards.txtCardType.Visible = True
        Cards.btnUpdate.Enabled = False
        Cards.btnAdd.Enabled = False
    End Sub



    Private Sub txtName_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtName.Validating
        If txtName.Text.Length = 0 Or txtName.Text = " " Then
            MessageBox.Show("Name cannot be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtName.Focus()
        End If
        Dim x As Integer
        IsNumeric(txtName.Text)
        For x = 0 To (Len(txtName.Text) - 1)
            If IsNumeric(txtName.Text.Chars(x)) Then
                MessageBox.Show("Enter only alphabets!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtName.Text = " "
                txtName.Focus()
                Exit For
            End If
        Next x
    End Sub



    Private Sub txtDOB_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtDOB.Validating
        If Not IsDate(txtDOB.Text) Then
            MessageBox.Show("Enter appropriate date as dd-mm-yyyy!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDOB.Text = " "
            txtDOB.Focus()
        End If
    End Sub


    Private Sub txtAddress_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtAddress.Validating
        If txtAddress.Text = " " Or txtAddress.Text.Length = 0 Then
            MessageBox.Show("Address cannot be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtAddress.Focus()
        End If
    End Sub


    Private Sub txtPCode_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtPCode.Validating
        If txtPCode.Text.Length <> 7 Or Not IsNumeric(txtPCode.Text) Then
            MessageBox.Show("Enter a 6 digit Pincode!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPCode.Text = " "
            txtPCode.Focus()
        End If
    End Sub


    Private Sub txtOccupation_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtOccupation.Validating
        If txtOccupation.Text.Length = 0 Or txtOccupation.Text = " " Then
            MessageBox.Show("Occupation cannot be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtOccupation.Focus()
        End If
        Dim x As Integer
        IsNumeric(txtName.Text)
        For x = 0 To (Len(txtName.Text) - 1)
            If IsNumeric(txtName.Text.Chars(x)) Then
                MessageBox.Show("Enter only alphabets!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtOccupation.Text = " "
                txtOccupation.Focus()
                Exit For
            End If
        Next x
    End Sub

    Private Sub txtAnnIncome_Validating(sender As System.Object, e As System.EventArgs) Handles txtAnnIncome.Validating
        If Not IsNumeric(txtAnnIncome.Text) Then
            MessageBox.Show("Enter a valid income!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPCode.Text = " "
            txtPCode.Focus()
        End If
    End Sub
    Private Sub txtPhoneNo_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtPhoneNo.Validating

        If Not IsNumeric(txtPhoneNo.Text) Then
            MessageBox.Show("Enter a valid Phone Number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPhoneNo.Text = " "
            txtPhoneNo.Focus()
        End If
    End Sub
    Private Sub txtMobileNo_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtMobileNo.Validating

        If txtMobileNo.Text.Length > 11 Or Not IsNumeric(txtMobileNo.Text) Then
            MessageBox.Show("Enter a 10 digit Mobile Number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtMobileNo.Text = " "
            txtMobileNo.Focus()
        End If
    End Sub


 
    Private Sub txtAnnIncome_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtAnnIncome.TextChanged
        If Val(txtAnnIncome.Text) = 0 Then
            txtCat.Text = "C3"
        ElseIf Val(txtAnnIncome.Text) < 1000000 Then
            txtCat.Text = "C3"
        ElseIf Val(txtAnnIncome.Text) > 1000000 And Val(txtAnnIncome.Text) < 2000000 Then
            txtCat.Text = "C2"
        Else
            txtCat.Text = "C1"
        End If
    End Sub
End Class