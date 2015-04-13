
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Text.RegularExpressions

Public Class Suppliers
    Dim objConnection As New SqlConnection("Data Source=BHASWANTH-PC\SQLEXPRESS;Initial Catalog=Grocery_Mart;Integrated Security=True")
    Dim objConnection2 As New SqlConnection("Data Source=BHASWANTH-PC\SQLEXPRESS;Initial Catalog=ODS_Stage;Integrated Security=True")
    Dim objConnection3 As New SqlConnection("Data Source=BHASWANTH-PC\SQLEXPRESS;Initial Catalog=Metadata;Integrated Security=True")
    Dim objDataAdapter As New SqlDataAdapter("SELECT * from Suppliers", objConnection)
    Dim objDataSet As DataSet
    Dim objDataView As DataView
    Dim objCurrencyManager As CurrencyManager

    Dim str1 As String
    Dim filename As String = "C:\BHAS\A_Sem7\proj\proj_work\Images\img1.png"
    Dim finfo As FileInfo
    Dim fStream As FileStream
    Dim chkn As Integer = 0

    Private Sub FillDataSetAndView()
        ' Initialize a new instance of the DataSet object..
        objDataSet = New DataSet()
        ' Fill the DataSet object with data..
        objDataAdapter.Fill(objDataSet, "Suppliers")
        ' Set the DataView object to the DataSet object..
        objDataView = New DataView(objDataSet.Tables("Suppliers"))
        ' Set our CurrencyManager object to the DataView object..
        objCurrencyManager = CType(Me.BindingContext(objDataView), CurrencyManager)
    End Sub
    Private Sub ImageDisp()
        Dim imgcmd As New SqlCommand("Select pic from Suppliers where SupplierID =@SuppID", objConnection)
        imgcmd.Parameters.AddWithValue("@SuppID", txtSuppId.Text)
        Try
            objConnection.Open()
            pictSupp.Image = Image.FromStream(New IO.MemoryStream(CType(imgcmd.ExecuteScalar, Byte())))
            ' or you can save in a file 
            'IO.File.WriteAllBytes("c:\backup\image3.jpg", CType(cmd.ExecuteScalar, Byte()))
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            objConnection.Close()
        End Try

    End Sub
    Private Sub Clear_Bindings()
        txtSuppId.DataBindings.Clear()
        txtCName.DataBindings.Clear()
        txtCtName.DataBindings.Clear()
        txtCTitle.DataBindings.Clear()
        txtAddress.DataBindings.Clear()
        txtCity.DataBindings.Clear()
        txtRegion.DataBindings.Clear()
        txtPCode.DataBindings.Clear()
        txtPhoneNo.DataBindings.Clear()
        txtEmail.DataBindings.Clear()
        txtCreatedBy.DataBindings.Clear()
        txtCreatedDate.DataBindings.Clear()
        txtUpdatedBy.DataBindings.Clear()
        txtUpdatedDate.DataBindings.Clear()
        pictSupp.DataBindings.Clear()
    End Sub
    Private Sub BindFields()
        ' Clear any previous bindings..
        Clear_Bindings()

        txtSuppId.DataBindings.Clear()
        txtCName.DataBindings.Clear()
        txtCtName.DataBindings.Clear()
        txtCTitle.DataBindings.Clear()
        txtAddress.DataBindings.Clear()
        txtCity.DataBindings.Clear()
        txtRegion.DataBindings.Clear()
        txtPCode.DataBindings.Clear()
        txtPhoneNo.DataBindings.Clear()
        txtEmail.DataBindings.Clear()
        txtCreatedBy.DataBindings.Clear()
        txtCreatedDate.DataBindings.Clear()
        txtUpdatedBy.DataBindings.Clear()
        txtUpdatedDate.DataBindings.Clear()
        pictSupp.DataBindings.Clear()

        ' Add new bindings to the DataView object..
        txtSuppId.DataBindings.Add("Text", objDataView, "SupplierID")
        txtCName.DataBindings.Add("Text", objDataView, "Name")
        txtCtName.DataBindings.Add("Text", objDataView, "Contact_Name")
        txtCTitle.DataBindings.Add("Text", objDataView, "Cont_Title")
        txtAddress.DataBindings.Add("Text", objDataView, "Address")
        txtCity.DataBindings.Add("Text", objDataView, "City")
        txtRegion.DataBindings.Add("Text", objDataView, "Region")
        txtPCode.DataBindings.Add("Text", objDataView, "Pcode")
        txtPhoneNo.DataBindings.Add("Text", objDataView, "Phone_no")
        txtEmail.DataBindings.Add("Text", objDataView, "Email_id")
        txtCreatedBy.DataBindings.Add("Text", objDataView, "Created_By")
        txtCreatedDate.DataBindings.Add("Text", objDataView, "Created_Date")
        txtUpdatedBy.DataBindings.Add("Text", objDataView, "Updated_By")
        txtUpdatedDate.DataBindings.Add("Text", objDataView, "Updated_Date")



    End Sub
    Private Sub Clear()
        txtCName.Text = " "
        txtCtName.Text = " "
        txtCTitle.Text = " "
        txtAddress.Text = " "
        txtCity.Text = " "
        txtRegion.Text = " "
        txtPCode.Text = " "
        txtPhoneNo.Text = " "
        txtEmail.Text = " "
        txtCreatedBy.Text = " "
        txtCreatedDate.Text = " "
        txtUpdatedBy.Text = " "
        txtUpdatedDate.Text = " "
        pictSupp.ImageLocation = "C:\BHAS\A_Sem7\proj\proj_work\Images\img1.png"
        Clear_Bindings()
    End Sub
    Private Sub EnableAll()
        txtCName.Enabled = True
        txtCtName.Enabled = True
        txtCTitle.Enabled = True
        txtAddress.Enabled = True
        txtCity.Enabled = True
        txtRegion.Enabled = True
        txtPCode.Enabled = True
        txtPhoneNo.Enabled = True
        txtEmail.Enabled = True
    End Sub
    Private Sub DisableAll()
        txtCName.Enabled = False
        txtCtName.Enabled = False
        txtCTitle.Enabled = False
        txtAddress.Enabled = False
        txtCity.Enabled = False
        txtRegion.Enabled = False
        txtPCode.Enabled = False
        txtPhoneNo.Enabled = False
        txtEmail.Enabled = False
    End Sub
    Private Sub suppliers_chk()
        Dim objCmdchk As New SqlCommand
        Dim count As Integer
        Try
            objCmdchk = New SqlCommand("SELECT count(*) from Suppliers", objConnection)
            objConnection.Open()
            count = objCmdchk.ExecuteScalar
            objConnection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        If count = 0 Then
            Clear()
            txtSuppId.Text = " "
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
            position_chk()
        End If
    End Sub
    Private Sub Suppliers_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Visible = True
        Me.Refresh()
        DisableAll()
        btnCancel.Visible = False
        btnClear.Visible = False
        btnSaveChanges.Visible = False
        suppliers_chk()
        btnFind.Focus()
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
        OpenFileDialog1.InitialDirectory = "C:\BHAS"
        OpenFileDialog1.Filter = "Image Files(*.bmp;*.jpg;*.gif;*.png)|*.bmp;*.jpg;*gif;*.png"
        OpenFileDialog1.ShowDialog()
        btnBrowse.Enabled = False
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Dim suppid As String = txtSuppId.Text
        If filename = "C:\BHAS\A_Sem7\proj\proj_work\Images\img1.png" Then
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
                objCmd4.CommandText = "Update Suppliers Set Updated_By = @Updated_By, Updated_Date = @Updated_Date, pic = @pic where SupplierID = @SupplierID"
                objCmd4.Parameters.AddWithValue("@SupplierID", txtSuppId.Text)
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
        Dim objCmdSU As New SqlCommand
        Try
            objCmdSU.Connection = objConnection2
            objCmdSU.CommandText = "Delete from ODS_Suppliers where SupplierID = '" & suppid & "'"
            objConnection2.Open()
            objCmdSU.ExecuteNonQuery()
            objConnection2.Close()
            objCmdSU.CommandText = "Insert into ODS_Stage.dbo.ODS_Suppliers Select *, 'U' as Op from Grocery_Mart.dbo.Suppliers where Grocery_Mart.dbo.Suppliers.SupplierID = '" & suppid & "'"
            objConnection2.Open()
            objCmdSU.ExecuteNonQuery()
            objConnection2.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Me.Close()
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        Dim suppid As String = txtSuppId.Text
        If Verify() Then


            Dim objCmd1 As New SqlCommand
            Try
                objConnection.Open()

                finfo = New FileInfo(filename)
                Dim btimage(finfo.Length) As Byte
                fStream = finfo.OpenRead()
                fStream.Read(btimage, 0, btimage.Length)
                fStream.Close()


                objCmd1.Connection = objConnection
                objCmd1.CommandText = "Insert into Suppliers Select @SupplierID,@CName,@CtName,@CTitle,@Address,@City,@Region,@PCode,@Phone_no,@EmailId,@Created_By,@Created_Date,Null,Null,@pic"
                objCmd1.Parameters.AddWithValue("@SupplierID", txtSuppId.Text)
                objCmd1.Parameters.AddWithValue("@CName", txtCName.Text)
                objCmd1.Parameters.AddWithValue("@CtName", txtCtName.Text)
                objCmd1.Parameters.AddWithValue("@CTitle", txtCTitle.Text)
                objCmd1.Parameters.AddWithValue("@Address", txtAddress.Text)
                objCmd1.Parameters.AddWithValue("@City", txtCity.Text)
                objCmd1.Parameters.AddWithValue("@Region", txtRegion.Text)
                objCmd1.Parameters.AddWithValue("@PCode", txtPCode.Text)
                objCmd1.Parameters.AddWithValue("@Phone_no", txtPhoneNo.Text)
                objCmd1.Parameters.AddWithValue("@EmailId", txtEmail.Text)
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
                btnCancel.Visible = False
                btnUpdate.Enabled = True
                btnRemove.Enabled = True
                btnFind.Enabled = True
                btnFind.Enabled = True
                btnFirst.Enabled = True
                btnNext.Enabled = True
                btnPrevious.Enabled = True
                btnLast.Enabled = True
                DisableAll()

            Catch ex As Exception
                MsgBox(ex.ToString)
                Me.Close()
            End Try

            FillDataSetAndView()
            BindFields()
            ImageDisp()
        Else
            MessageBox.Show("Fields cannot be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Dim objCmdSI As New SqlCommand
        Try
            objCmdSI.Connection = objConnection2
            objCmdSI.CommandText = "Insert into ODS_Stage.dbo.ODS_Suppliers Select *, 'I' as Op from Grocery_Mart.dbo.Suppliers where Grocery_Mart.dbo.Suppliers.SupplierID = '" & suppid & "'"
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
            objCmdCR.CommandText = "Delete from Suppliers_Current_Log"
            objConnection3.Open()
            objCmdCR.ExecuteNonQuery()
            objConnection3.Close()
            objCmdCR.CommandText = "Insert into Suppliers_Current_Log Select count(SrNo) +1, '" & suppid & "' from Suppliers_Current_Log"
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

    Private Sub btnUpdate_Click(sender As System.Object, e As System.EventArgs) Handles btnUpdate.Click
        Clear_Bindings()
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

    Private Sub btnRemove_Click(sender As System.Object, e As System.EventArgs) Handles btnRemove.Click
        Dim suppid As String = txtSuppId.Text
        Dim objCmd3 As New SqlCommand
        Dim Position = objCurrencyManager.Position
        Try
            objConnection.Open()
            objCmd3.Connection = objConnection
            objCmd3.CommandText = "Delete from Suppliers where SupplierID = @SupplierID"
            objCmd3.Parameters.AddWithValue("@SupplierID", txtSuppId.Text)
            objCmd3.ExecuteNonQuery()

            MsgBox("You have Successfully Deleted the Record")

            objConnection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Dim objCmdSD As New SqlCommand
        Try
            objCmdSD.Connection = objConnection3
            objCmdSD.CommandText = "Insert into Suppliers_Delete_Log Select count(SrNo) +1, '" & suppid & "' from Suppliers_Delete_Log"
            objConnection3.Open()
            objCmdSD.ExecuteNonQuery()
            objConnection3.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Me.Close()
        End Try
        Dim count As Integer
        Try
            Dim objCmdchk = New SqlCommand("SELECT count(*) from Suppliers", objConnection)
            objConnection.Open()
            count = objCmdchk.ExecuteScalar
            objConnection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        If count = 0 Then
            suppliers_chk()
        Else
            FillDataSetAndView()
            BindFields()
            objCurrencyManager.Position = Position - 1
            ImageDisp()
        End If
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        Clear()
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
    Private Sub btnFirst_Click(sender As System.Object, e As System.EventArgs) Handles btnFirst.Click
        ' Set the record position to the first record..
        objCurrencyManager.Position = 0
        position_chk()
        ImageDisp()
    End Sub

    Private Sub btnNext_Click(sender As System.Object, e As System.EventArgs) Handles btnNext.Click
        ' Move to the next record..
        objCurrencyManager.Position += 1
        position_chk()
        ImageDisp()
    End Sub

    Private Sub btnPrevious_Click(sender As System.Object, e As System.EventArgs) Handles btnPrevious.Click
        ' Move to the previous record..
        objCurrencyManager.Position -= 1
        position_chk()
        ImageDisp()
    End Sub

    Private Sub btnLast_Click(sender As System.Object, e As System.EventArgs) Handles btnLast.Click
        ' Set the record position to the last record..
        objCurrencyManager.Position = objCurrencyManager.Count - 1
        position_chk()
        ImageDisp()
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
                    objDataView.Sort = "SupplierID"
                Case 1
                    objDataView.Sort = "Name"
            End Select


            intPosition = objDataView.Find(Trim(txtSearchCriteria.Text))

            If intPosition = -1 Then
                MsgBox("Record Not Found.")
            Else
                MsgBox("Record Found.")
                objCurrencyManager.Position = intPosition
                ImageDisp()
            End If


            cboField.Text = " "
            txtSearchCriteria.Text = " "

        End If
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        filename = OpenFileDialog1.FileName.ToString()
    End Sub


    Private Sub btnSaveChanges_Click(sender As System.Object, e As System.EventArgs) Handles btnSaveChanges.Click
        Dim suppid As String = txtSuppId.Text
      
            Try
                Dim objCmd2 As New SqlCommand
                Dim Position = objCurrencyManager.Position
                objCmd2.Connection = objConnection
                objCmd2.CommandText = "Update Suppliers Set Name = @CName,Contact_Name = @CtName,Cont_Title = @CTitle,Address = @Address,City = @City,Region = @Region,PCode = @PCode,Phone_no = @Phone_no,Email_id = @EmailId,Updated_By = @Updated_By,Updated_Date = @Updated_Date where SupplierID = @SuppID"
                objCmd2.Parameters.AddWithValue("@SuppID", txtSuppId.Text)
                objCmd2.Parameters.AddWithValue("@CName", txtCName.Text)
                objCmd2.Parameters.AddWithValue("@CtName", txtCtName.Text)
                objCmd2.Parameters.AddWithValue("@CTitle", txtCTitle.Text)
                objCmd2.Parameters.AddWithValue("@Address", txtAddress.Text)
                objCmd2.Parameters.AddWithValue("@City", txtCity.Text)
                objCmd2.Parameters.AddWithValue("@Region", txtRegion.Text)
                objCmd2.Parameters.AddWithValue("@PCode", txtPCode.Text)
                objCmd2.Parameters.AddWithValue("@Phone_no", txtPhoneNo.Text)
                objCmd2.Parameters.AddWithValue("@EmailId", txtEmail.Text)
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

                ImageDisp()


            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        Dim objCmdSU As New SqlCommand
        Try
            objCmdSU.Connection = objConnection2
            objCmdSU.CommandText = "Delete from ODS_Suppliers where SupplierID = '" & suppid & "'"
            objConnection2.Open()
            objCmdSU.ExecuteNonQuery()
            objConnection2.Close()
            objCmdSU.CommandText = "Insert into ODS_Stage.dbo.ODS_Suppliers Select *, 'U' as Op from Grocery_Mart.dbo.Suppliers where Grocery_Mart.dbo.Suppliers.SupplierID = '" & suppid & "'"
            objConnection2.Open()
            objCmdSU.ExecuteNonQuery()
            objConnection2.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Me.Close()
        End Try
    End Sub
    Private Function Verify()
        If (txtCName.Text.Length = 0 Or txtCtName.Text.Length = 0 Or txtCTitle.Text.Length = 0 Or txtAddress.Text.Length = 0 Or txtCity.Text.Length = 0 Or txtRegion.Text.Length = 0 Or txtPCode.Text.Length = 0 Or txtPhoneNo.Text.Length = 0 Or txtEmail.Text.Length = 0) Then
            Return False
        Else
            Return True
        End If
    End Function
    Private Sub btnAddNew_Click(sender As System.Object, e As System.EventArgs) Handles btnAddNew.Click
        Clear()
        btnCancel.Visible = True
        btnAdd.Visible = True
        btnAddNew.Visible = False
        btnUpdate.Enabled = False
        btnRemove.Enabled = False
        btnBrowse.Visible = True
        btnClear.Visible = True
        btnChangePic.Visible = False
        btnFind.Enabled = False
        btnFirst.Enabled = False
        btnNext.Enabled = False
        btnPrevious.Enabled = False
        btnLast.Enabled = False
        EnableAll()


        Dim objcmdL As New SqlCommand
        Dim supid As String = " "
        Try

            objcmdL.Connection = objConnection3
            objcmdL.CommandText = "Select SupplierID from Suppliers_Current_Log"
            objConnection3.Open()
            supid = objcmdL.ExecuteScalar()
            objConnection3.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Try
            If supid = Nothing Then
                txtSuppId.Text = "S00001"
                chkn = 1
            Else
                Dim sid As String
                sid = "S" + (Val("1" + supid.Substring(1, 5)) + 1).ToString.Substring(1, 5)
                txtSuppId.Text = sid
            End If
        Catch ex As Exception
        End Try

        txtCreatedBy.Text = MDIParent1.ToolStripStatusLabel3.Text
        txtCreatedDate.Text = Date.Today
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs)
        FillDataSetAndView()
        BindFields()
        ImageDisp()

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

    End Sub

    Private Sub btnCancel_Click_1(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Dim Position = objCurrencyManager.Position
        FillDataSetAndView()
        BindFields()
        objCurrencyManager.Position = Position
        ImageDisp()

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

    End Sub



    Private Sub txtCName_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtCName.Validating
        If txtCName.Text = " " Or txtCName.Text.Length = 0 Then
            MessageBox.Show("Company Name cannot be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCName.Focus()
        End If
    End Sub



    Private Sub txtCtName_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtCtName.Validating
        If txtCtName.Text = " " Or txtCtName.Text.Length = 0 Then
            MessageBox.Show("Contact Name cannot be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCtName.Focus()
        End If
        Dim x As Integer
        For x = 0 To (Len(txtCtName.Text) - 1)
            If IsNumeric(txtCtName.Text.Chars(x)) Then
                MessageBox.Show("Enter only alphabets!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtCtName.Text = " "
                txtCtName.Focus()
                Exit For
            End If
        Next x
    End Sub

    Private Sub txtCTitle_Validating(sender As System.Object, e As System.EventArgs) Handles txtCTitle.Validating
        If txtCTitle.Text = " " Or txtCTitle.Text.Length = 0 Then
            MessageBox.Show("Contact Title cannot be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCTitle.Focus()
        End If
        Dim x As Integer
        For x = 0 To (Len(txtCTitle.Text) - 1)
            If IsNumeric(txtCTitle.Text.Chars(x)) Then
                MessageBox.Show("Enter only alphabets!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtCTitle.Text = " "
                txtCTitle.Focus()
                Exit For
            End If
        Next x
    End Sub


    Private Sub txtAddress_Validating(sender As System.Object, e As System.EventArgs) Handles txtAddress.Validating
        If txtAddress.Text = " " Or txtAddress.Text.Length = 0 Then
            MessageBox.Show("Address cannot be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtAddress.Focus()
        End If
    End Sub


    Private Sub txtCity_Validating(sender As System.Object, e As System.EventArgs) Handles txtCity.Validating
        If txtCity.Text = " " Or txtCity.Text.Length = 0 Then
            MessageBox.Show("Contact Name cannot be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCity.Focus()
        End If
        Dim x As Integer
        For x = 0 To (Len(txtCity.Text) - 1)
            If IsNumeric(txtCity.Text.Chars(x)) Then
                MessageBox.Show("Enter only alphabets!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtCity.Text = " "
                txtCity.Focus()
                Exit For
            End If
        Next x
    End Sub


    Private Sub txtRegion_Validating(sender As System.Object, e As System.EventArgs) Handles txtRegion.Validating
        If txtRegion.Text = " " Or txtRegion.Text.Length = 0 Then
            MessageBox.Show("Contact Name cannot be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtRegion.Focus()
        End If
        Dim x As Integer
        For x = 0 To (Len(txtRegion.Text) - 1)
            If IsNumeric(txtRegion.Text.Chars(x)) Then
                MessageBox.Show("Enter only alphabets!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtRegion.Text = " "
                txtRegion.Focus()
                Exit For
            End If
        Next x
    End Sub

    Private Sub txtPhoneNo_Validating(sender As System.Object, e As System.EventArgs) Handles txtPhoneNo.Validating
        If txtPhoneNo.Text.Length > 11 Or Not IsNumeric(txtPhoneNo.Text) Then
            MessageBox.Show("Enter correct Phone Number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPhoneNo.Text = " "
            txtPhoneNo.Focus()
        End If
    End Sub

    Private Sub txtPCode_Validating(sender As System.Object, e As System.EventArgs) Handles txtPCode.Validating
        If txtPCode.Text.Length <> 7 Or Not IsNumeric(txtPCode.Text) Then

            MessageBox.Show("Enter a 6 digit Pincode!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPCode.Text = " "
            txtPCode.Focus()
        End If
    End Sub

    Private Sub txtEmail_Validating(sender As System.Object, e As System.EventArgs) Handles txtEmail.Validating
        Dim rex As Match = Regex.Match(Trim(txtEmail.Text), "^([0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,3})$", RegexOptions.IgnoreCase)
        If Not rex.Success Then
            txtEmail.Text = " "
            txtEmail.Focus()
            MessageBox.Show("Enter correct Email id.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub



   
End Class