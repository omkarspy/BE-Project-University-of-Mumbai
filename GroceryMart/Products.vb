
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class Products

    Dim objConnection As New SqlConnection("Data Source=BHASWANTH-PC\SQLEXPRESS;Initial Catalog=Grocery_Mart;Integrated Security=True")
    Dim objConnection2 As New SqlConnection("Data Source=BHASWANTH-PC\SQLEXPRESS;Initial Catalog=ODS_Stage;Integrated Security=True")
    Dim objConnection3 As New SqlConnection("Data Source=BHASWANTH-PC\SQLEXPRESS;Initial Catalog=Metadata;Integrated Security=True")
    Dim objDataAdapter1 As New SqlDataAdapter("SELECT * from Category", objConnection)
    Dim objDataSet1 As DataSet
    Dim objDataView1 As DataView
    Dim objCurrencyManager1 As CurrencyManager


    Dim objDataAdapter2 As New SqlDataAdapter()
    Dim objDataSet2 As DataSet
    Dim objDataView2 As DataView
    Dim objCurrencyManager2 As CurrencyManager


    Dim str1 As String
    Dim chkn As Integer = 0
    Dim filename As String = "C:\BHAS\A_Sem7\proj\proj_work\Images\img1.png"

    Private Sub FillDataSetAndView1()
        ' Initialize a new instance of the DataSet object..
        objDataSet1 = New DataSet()
        ' Fill the DataSet object with data..
        objDataAdapter1.Fill(objDataSet1, "Category")
        ' Set the DataView object to the DataSet object..
        objDataView1 = New DataView(objDataSet1.Tables("Category"))
        ' Set our CurrencyManager object to the DataView object..
        objCurrencyManager1 = CType(Me.BindingContext(objDataView1), CurrencyManager)
    End Sub
    Private Sub BindFields1()
        txtCName.DataBindings.Clear()
        ' Add new bindings to the DataView object..
        txtCName.DataBindings.Add("Text", objDataView1, "Category_Name")
    End Sub
    Private Sub FillDataSetAndView2()
        Try
            ' Initialize a new instance of the DataSet object..
            objDataSet2 = New DataSet()
            ' Fill the DataSet object with data..
            objDataAdapter2.Fill(objDataSet2, "Products")
            ' Set the DataView object to the DataSet object..
            objDataView2 = New DataView(objDataSet2.Tables("Products"))
            ' Set our CurrencyManager object to the DataView object..
            objCurrencyManager2 = CType(Me.BindingContext(objDataView2), CurrencyManager)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Clear_Bindings()
        txtProdID.DataBindings.Clear()
        txtPName.DataBindings.Clear()
        txtBrand.DataBindings.Clear()
        txtPrice.DataBindings.Clear()
        txtWeight.DataBindings.Clear()
        txtSType.DataBindings.Clear()
        txtDType.DataBindings.Clear()
        txtExpPeriod.DataBindings.Clear()
        txtCreatedBy.DataBindings.Clear()
        txtCreatedDate.DataBindings.Clear()
        txtUpdatedBy.DataBindings.Clear()
        txtUpdatedDate.DataBindings.Clear()
    End Sub
    Private Sub BindFields2()
        Clear_Bindings()
        ' Add new bindings to the DataView object..
        Try
            txtProdID.DataBindings.Add("Text", objDataView2, "ProductID")
            txtPName.DataBindings.Add("Text", objDataView2, "Prod_Name")
            txtBrand.DataBindings.Add("Text", objDataView2, "Brand")
            txtPrice.DataBindings.Add("Text", objDataView2, "Price")
            txtWeight.DataBindings.Add("Text", objDataView2, "Weight")
            txtSType.DataBindings.Add("Text", objDataView2, "Storage_Type")
            txtDType.DataBindings.Add("Text", objDataView2, "Diet_Type")
            txtExpPeriod.DataBindings.Add("Text", objDataView2, "Exp_Period")
            txtCreatedBy.DataBindings.Add("Text", objDataView2, "Created_By")
            txtCreatedDate.DataBindings.Add("Text", objDataView2, "Created_Date")
            txtUpdatedBy.DataBindings.Add("Text", objDataView2, "Updated_By")
            txtUpdatedDate.DataBindings.Add("Text", objDataView2, "Updated_Date")
        Catch
        End Try
    End Sub
    Private Sub ImageDisp()
        Dim filenm As String
        Dim imgcmd As New SqlCommand("Select pic from Products where ProductID = @ProdID", objConnection)
        imgcmd.Parameters.AddWithValue("@ProdID", txtProdID.Text)
        Try
            objConnection.Open()
            filenm = imgcmd.ExecuteScalar()
            If (filenm = " " Or filenm.Length = 0) Then
                pictProd.Image = Image.FromFile(filename)
            Else
                pictProd.Image = Image.FromFile(filenm)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            objConnection.Close()
        End Try
    End Sub
    Private Sub EnableAll()
        txtPName.Enabled = True
        txtBrand.Enabled = True
        txtPrice.Enabled = True
        txtWeight.Enabled = True
        txtSType.Enabled = True
        txtDType.Enabled = True
        txtExpPeriod.Enabled = True
    End Sub
    Private Sub DisableAll()
        txtPName.Enabled = False
        txtBrand.Enabled = False
        txtPrice.Enabled = False
        txtWeight.Enabled = False
        txtSType.Enabled = False
        txtDType.Enabled = False
        txtExpPeriod.Enabled = False
    End Sub
    Private Sub Clear()
        txtPName.Text = " "
        txtBrand.Text = " "
        txtPrice.Text = " "
        txtWeight.Text = " "
        txtSType.Text = " "
        txtDType.Text = " "
        txtExpPeriod.Text = " "
        txtCreatedBy.Text = " "
        txtCreatedDate.Text = " "
        txtUpdatedBy.Text = " "
        txtUpdatedDate.Text = " "
        pictProd.ImageLocation = "C:\BHAS\A_Sem7\proj\proj_work\Images\img1.png"
        Clear_Bindings()
    End Sub

    Private Sub load_prod()
        Dim objCmd2 As SqlCommand
        Dim objCmdchk As New SqlCommand
        Dim count As Integer
        Try
            objCmdchk = New SqlCommand("SELECT count(*) from Products where Category_Name = '" & txtCName.Text & "'", objConnection)
            objConnection.Open()
            count = objCmdchk.ExecuteScalar
            objConnection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        If count = 0 Then
            Clear()
            txtProdID.Text = " "
            btnAddNew.Enabled = True
            btnUpdate.Enabled = False
            btnRemove.Enabled = False
            btnChangePic.Enabled = False
            btnFirst.Enabled = False
            btnNext.Enabled = False
            btnPrevious.Enabled = False
            btnLast.Enabled = False
            btnChkInv.Enabled = False
        Else
            btnAddNew.Enabled = True
            btnUpdate.Enabled = True
            btnRemove.Enabled = True
            btnChangePic.Enabled = True
            btnFirst.Enabled = True
            btnNext.Enabled = True
            btnPrevious.Enabled = True
            btnLast.Enabled = True
            btnChkInv.Enabled = True
            objCmd2 = New SqlCommand("SELECT * from Products where Category_Name = '" & txtCName.Text & "'", objConnection)
            objDataAdapter2.SelectCommand = objCmd2
            FillDataSetAndView2()
            BindFields2()
            ImageDisp()
            position_chk()
        End If
    End Sub
    Private Sub Products_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load


        Me.Refresh()

        Dim objCmd1 As New SqlCommand
        Dim adapter As New SqlDataAdapter()
        Dim ds As New DataSet()
        Dim i As Integer = 0

        Try
            objConnection.Open()
            objCmd1 = New SqlCommand("Select Category_ID From Category", objConnection)
            adapter.SelectCommand = objCmd1
            adapter.Fill(ds)
            adapter.Dispose()
            objCmd1.Dispose()
            objConnection.Close()

            cboCatID.DataSource = ds.Tables(0)
            cboCatID.ValueMember = "Category_ID"
            cboCatID.DisplayMember = "Category_ID"
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        FillDataSetAndView1()
        BindFields1()
        DisableAll()
        load_prod()
        Clear()
        txtProdID.Text = ""
        btnAddNew.Enabled = False
        btnUpdate.Enabled = False
        btnRemove.Enabled = False
        btnChangePic.Enabled = False
        btnFirst.Enabled = False
        btnNext.Enabled = False
        btnPrevious.Enabled = False
        btnLast.Enabled = False
        btnChkInv.Enabled = False
    End Sub
    Private Sub cboCatID_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboCatID.SelectedIndexChanged

        Try
            objCurrencyManager1.Position = cboCatID.SelectedIndex
        Catch
        End Try
        load_prod()

    End Sub
    Private Sub position_chk()
        If (objCurrencyManager2.Position = 0) Then
            btnFirst.Enabled = False
            btnPrevious.Enabled = False
            btnNext.Enabled = True
            btnLast.Enabled = True
        ElseIf (objCurrencyManager2.Position = objCurrencyManager2.Count - 1) Then
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
    Private Sub btnNext_Click(sender As System.Object, e As System.EventArgs) Handles btnNext.Click
    
        objCurrencyManager2.Position += 1
        position_chk()
            ImageDisp()

    End Sub

    Private Sub btnFirst_Click(sender As System.Object, e As System.EventArgs) Handles btnFirst.Click

        objCurrencyManager2.Position = 0
        position_chk()
        ImageDisp()
    End Sub

    Private Sub btnPrevious_Click(sender As System.Object, e As System.EventArgs) Handles btnPrevious.Click
      
        objCurrencyManager2.Position -= 1
        position_chk()
            ImageDisp()

    End Sub

    Private Sub btnLast_Click(sender As System.Object, e As System.EventArgs) Handles btnLast.Click
        objCurrencyManager2.Position = objCurrencyManager2.Count - 1
        position_chk()
        ImageDisp()
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
        cboCatID.Enabled = False
    End Sub
    Private Sub OpenFileDialog1_FileOk(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        filename = OpenFileDialog1.FileName.ToString()
    End Sub
    Private Sub btnBrowse_Click(sender As System.Object, e As System.EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.Title = "Please Select an Image."
        OpenFileDialog1.InitialDirectory = "C:\BHAS"
        OpenFileDialog1.Filter = "Image Files(*.bmp;*.jpg;*.gif;*.png)|*.bmp;*.jpg;*gif;*.png"
        OpenFileDialog1.ShowDialog()
        btnBrowse.Enabled = False
    End Sub
    Private Sub Update_ODS(prodid As String)
        Dim objCmdSU As New SqlCommand
        Try
            objCmdSU.Connection = objConnection2
            objCmdSU.CommandText = "Delete from ODS_Products where ProductID = '" & prodid & "'"
            objConnection2.Open()
            objCmdSU.ExecuteNonQuery()
            objConnection2.Close()
            objCmdSU.CommandText = "Insert into ODS_Stage.dbo.ODS_Products Select *, 'U' as Op from Grocery_Mart.dbo.Products where Grocery_Mart.dbo.Products.ProductID = '" & prodid & "'"
            objConnection2.Open()
            objCmdSU.ExecuteNonQuery()
            objConnection2.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Me.Close()
        End Try
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Dim prodid As String = txtProdID.Text
        If filename = "C:\BHAS\A_Sem7\proj\proj_work\Images\img1.png" Then
            MsgBox("Select the Employee's photo.")
        Else
            Dim objCmd6 As New SqlCommand

            Try
                objConnection.Open()
                objCmd6.Connection = objConnection
                objCmd6.CommandText = "Update Products Set Updated_By = @Updated_By, Updated_Date = @Updated_Date, pic = @pic where ProductID = @ProdID"
                objCmd6.Parameters.AddWithValue("@ProdID", txtProdID.Text)
                objCmd6.Parameters.AddWithValue("@Updated_By", MDIParent1.ToolStripStatusLabel3.Text)
                objCmd6.Parameters.AddWithValue("@Updated_Date", Date.Today)
                objCmd6.Parameters.AddWithValue("@pic", filename)
                objCmd6.ExecuteNonQuery()
                MsgBox("You have Successfully Changed the Image.")
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
                cboCatID.Enabled = True
                ImageDisp()

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
        Update_ODS(prodid)
    End Sub

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
        btnChkInv.Enabled = False
        cboCatID.Enabled = False
        EnableAll()

        Dim objCmdchk As New SqlCommand

        Dim prid As String = " "
        Try
            objCmdchk = New SqlCommand("SELECT ProductID from Products_Current_Log where SUBSTRING(ProductID, 1, 5) = '" & ("P" + cboCatID.Text.Substring(1, 4)) & "'", objConnection3)
            objConnection3.Open()
            prid = objCmdchk.ExecuteScalar
            objConnection3.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        If prid = Nothing Then
            txtProdID.Text = "P" + cboCatID.Text.Substring(1, 4) + "00001"
            chkn = 1
        Else

            Dim count As Integer
            count = objCurrencyManager2.Count + 1
            Dim temp = count.ToString()
            Dim temp2 = 5 - temp.Length

            Dim pid = "P" + cboCatID.Text.Substring(1, 4)
            While temp2 <> 0
                pid = pid + "0"
                temp2 = temp2 - 1
            End While
            pid = pid + temp
            txtProdID.Text = pid
        End If
        txtCreatedBy.Text = MDIParent1.ToolStripStatusLabel3.Text
        txtCreatedDate.Text = Date.Today
    End Sub
    Private Function Verify()
        If (txtPName.Text = " " Or txtBrand.Text = " " Or txtPrice.Text = " " Or txtWeight.Text = " " Or txtSType.Text = " " Or txtDType.Text = " " Or txtExpPeriod.Text = " ") Then
            Return False
        Else
            Return True
        End If
    End Function
    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        Dim prodid As String = txtProdID.Text
        If Verify() Then
            Dim objCmd3 As New SqlCommand
            Try
                objConnection.Open()
                objCmd3.Connection = objConnection
                objCmd3.CommandText = "Insert into Products Select @ProdID,@PName,@Brand,@CatID,@CName,@Price,@Weight,@SType,@DType,@Exp,@Created_By,@Created_Date,Null,Null,@pic"
                objCmd3.Parameters.AddWithValue("@ProdID", txtProdID.Text)
                objCmd3.Parameters.AddWithValue("@PName", txtPName.Text)
                objCmd3.Parameters.AddWithValue("@Brand", txtBrand.Text)
                objCmd3.Parameters.AddWithValue("@CatID", cboCatID.Text)
                objCmd3.Parameters.AddWithValue("@CName", txtCName.Text)
                objCmd3.Parameters.AddWithValue("@Price", txtPrice.Text)
                objCmd3.Parameters.AddWithValue("@Weight", txtWeight.Text)
                objCmd3.Parameters.AddWithValue("@Stype", txtSType.Text)
                objCmd3.Parameters.AddWithValue("@DType", txtDType.Text)
                objCmd3.Parameters.AddWithValue("@Exp", txtExpPeriod.Text)
                objCmd3.Parameters.AddWithValue("@Created_By", "E10004") 'MDIParent1.ToolStripStatusLabel3.Text
                objCmd3.Parameters.AddWithValue("@Created_Date", Date.Today)
                objCmd3.Parameters.AddWithValue("@pic", filename)
                objCmd3.ExecuteNonQuery()

                objConnection.Close()

                MsgBox("You have Successfully Added the Record")
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            btnClear.Visible = False
            btnAdd.Visible = False
            btnChangePic.Visible = True
            btnAddNew.Visible = True
            btnBrowse.Visible = False
            btnCancel.Visible = False
            btnFind.Enabled = True
            btnFind.Enabled = True
            btnFirst.Enabled = True
            btnNext.Enabled = True
            btnPrevious.Enabled = True
            btnLast.Enabled = True
            btnUpdate.Enabled = True
            btnRemove.Enabled = True
            btnChkInv.Enabled = True
            cboCatID.Enabled = True
            DisableAll()


            FillDataSetAndView2()
            BindFields2()
            ImageDisp()
        Else
            MessageBox.Show("Fields cannot be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Dim objCmdSI As New SqlCommand
        Try
            objCmdSI.Connection = objConnection2
            objCmdSI.CommandText = "Insert into ODS_Stage.dbo.ODS_Products Select *, 'I' as Op from Grocery_Mart.dbo.Products where Grocery_Mart.dbo.Products.ProductID = '" & prodid & "'"
            objConnection2.Open()
            objCmdSI.ExecuteNonQuery()
            objConnection2.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Me.Close()
        End Try

        Dim objCmdIA As New SqlCommand
        Try
            objCmdIA.Connection = objConnection
            objCmdIA.CommandText = "Insert into Inventory Select PID,0,null"
            objCmdIA.Parameters.AddWithValue("@PID", prodid)
            objConnection.Open()
            objCmdIA.ExecuteNonQuery()
            objConnection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Me.Close()
        End Try

        Dim objCmdCR As New SqlCommand
        Try
            objCmdCR.Connection = objConnection3
            objCmdCR.CommandText = "Delete from Products_Current_Log where SUBSTRING(ProductID, 1, 5) = '" & ("P" + cboCatID.Text.Substring(1, 4)) & "'"
            objConnection3.Open()
            objCmdCR.ExecuteNonQuery()
            objConnection3.Close()
            objCmdCR.CommandText = "Insert into Products_Current_Log Select count(SrNo) +1, '" & prodid & "' from Products_Current_Log"
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

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        load_prod()
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
        btnChkInv.Enabled = True
        cboCatID.Enabled = True
        DisableAll()
    End Sub

    Private Sub btnUpdate_Click(sender As System.Object, e As System.EventArgs) Handles btnUpdate.Click
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
        btnChkInv.Enabled = False
        cboCatID.Enabled = False
        EnableAll()
    End Sub

    Private Sub btnSaveChanges_Click(sender As System.Object, e As System.EventArgs) Handles btnSaveChanges.Click
        Dim prodid As String = txtProdID.Text
        Try
            Dim objCmd4 As New SqlCommand
            Dim Position = objCurrencyManager2.Position
            objCmd4.Connection = objConnection
            objCmd4.CommandText = "Update Products Set Prod_Name = @PName,Brand = @Brand,Price = @Price,Weight = @Weight,Exp_Period = @Exp,Updated_By = @Updated_By, Updated_Date = @Updated_Date where ProductID = @ProdID"
            objCmd4.Parameters.AddWithValue("@ProdID", txtProdID.Text)
            objCmd4.Parameters.AddWithValue("@PName", txtPName.Text)
            objCmd4.Parameters.AddWithValue("@Brand", txtBrand.Text)
            objCmd4.Parameters.AddWithValue("@Price", txtPrice.Text)
            objCmd4.Parameters.AddWithValue("@Weight", txtWeight.Text)
            objCmd4.Parameters.AddWithValue("@Exp", txtExpPeriod.Text)
            objCmd4.Parameters.AddWithValue("@Updated_By", MDIParent1.ToolStripStatusLabel3.Text)
            objCmd4.Parameters.AddWithValue("@Updated_Date", Date.Today)
            objConnection.Open()
            objCmd4.ExecuteNonQuery()
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
            btnChkInv.Enabled = True
            cboCatID.Enabled = True
            DisableAll()
            ' Fill the DataSet and bind the fields..
            FillDataSetAndView2()
            BindFields2()
            ' Set the record position to the one that you saved..
            objCurrencyManager2.Position = Position
            ImageDisp()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Update_ODS(prodid)
    End Sub
    Private Sub btnRemove_Click(sender As System.Object, e As System.EventArgs) Handles btnRemove.Click
        Dim prodid As String = txtProdID.Text
        Dim objCmd5 As New SqlCommand
        Dim Position = objCurrencyManager2.Position
        Try
            objConnection.Open()
            objCmd5.Connection = objConnection
            objCmd5.CommandText = "Delete from Products where ProductID = @ProdID"
            objCmd5.Parameters.AddWithValue("@ProdID", txtProdID.Text)
            objCmd5.ExecuteNonQuery()
            MsgBox("You have Successfully Deleted the Record")
            objConnection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Dim objCmdSD As New SqlCommand
        Try
            objCmdSD.Connection = objConnection3
            objCmdSD.CommandText = "Insert into Products_Delete_Log Select count(SrNo) +1, '" & prodid & "' from Products_Delete_Log"
            objConnection3.Open()
            objCmdSD.ExecuteNonQuery()
            objConnection3.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Me.Close()
        End Try
        Dim count As Integer
        Try
            Dim objCmdchk = New SqlCommand("SELECT count(*) from Products where Category_Name = '" & txtCName.Text & "'", objConnection)
            objConnection.Open()
            count = objCmdchk.ExecuteScalar
            objConnection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        If count = 0 Then
            load_prod()
        Else
            FillDataSetAndView2()
            BindFields2()
            objCurrencyManager2.Position = Position - 1
            ImageDisp()
        End If
        Dim objCmdIA As New SqlCommand
        Try
            objCmdIA.Connection = objConnection
            objCmdIA.CommandText = "Delete from Inventory where ProductID = @PID"
            objCmdIA.Parameters.AddWithValue("@PID", prodid)
            objConnection.Open()
            objCmdIA.ExecuteNonQuery()
            objConnection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Me.Close()
        End Try
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
                    objDataView2.Sort = "ProductID"
                Case 1
                    objDataView2.Sort = "Prod_Name"
            End Select


            intPosition = objDataView2.Find(Trim(txtSearchCriteria.Text))

            If intPosition = -1 Then
                MsgBox("Record Not Found.")
            Else
                MsgBox("Record Found.")
                objCurrencyManager2.Position = intPosition
                ImageDisp()
            End If

            cboField.Text = " "
            txtSearchCriteria.Text = " "

        End If
    End Sub

    Private Sub btnChkInv_Click(sender As System.Object, e As System.EventArgs) Handles btnChkInv.Click

        Inventory.Show()
        Inventory.txtProdID.Text = Me.txtProdID.Text
        Inventory.txtPName.Text = Me.txtPName.Text
    End Sub
    Private Sub txtPName_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtPName.Validating
        If txtPName.Text = " " Or txtPName.Text.Length = 0 Then
            MessageBox.Show("Product Name cannot be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPName.Focus()
        End If
        Dim x As Integer
        For x = 0 To (Len(txtPName.Text) - 1)
            If IsNumeric(txtPName.Text.Chars(x)) Then
                MessageBox.Show("Enter only alphabets!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPName.Text = " "
                txtPName.Focus()
                Exit For
            End If
        Next x
    End Sub

 

    Private Sub txtBrand_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtBrand.Validating
        If txtBrand.Text = " " Or txtBrand.Text.Length = 0 Then
            MessageBox.Show("Brand cannot be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtBrand.Focus()
        End If
        Dim x As Integer
        For x = 0 To (Len(txtBrand.Text) - 1)
            If IsNumeric(txtBrand.Text.Chars(x)) Then
                MessageBox.Show("Enter only alphabets!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtBrand.Text = " "
                txtBrand.Focus()
                Exit For
            End If
        Next x
    End Sub


    Private Sub txtPrice_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtPrice.Validating
        If Not IsNumeric(txtPrice.Text) Then
            MessageBox.Show("Enter only numberic values!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPrice.Text = " "
            txtPrice.Focus()
        End If
    End Sub


    Private Sub txtWeight_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtWeight.Validating
        If Not IsNumeric(txtWeight.Text) Then
            MessageBox.Show("Enter only numberic values!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtWeight.Text = " "
            txtWeight.Focus()
        End If
    End Sub


    Private Sub txtSType_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtSType.Validating
        If txtSType.Text = " " Or txtSType.Text.Length = 0 Then
            MessageBox.Show("Storage Type cannot be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSType.Focus()
        End If
        Dim x As Integer
        For x = 0 To (Len(txtSType.Text) - 1)
            If IsNumeric(txtSType.Text.Chars(x)) Then
                MessageBox.Show("Enter only alphabets!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtSType.Text = " "
                txtSType.Focus()
                Exit For
            End If
        Next x
    End Sub

    Private Sub txtDType_Validating(sender As System.Object, e As System.EventArgs) Handles txtDType.Validating
        If txtDType.Text = " " Or txtDType.Text.Length = 0 Then
            MessageBox.Show("Diet Type cannot be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDType.Focus()
        End If
        Dim x As Integer
        For x = 0 To (Len(txtDType.Text) - 1)
            If IsNumeric(txtDType.Text.Chars(x)) Then
                MessageBox.Show("Enter only alphabets!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtDType.Text = " "
                txtDType.Focus()
                Exit For
            End If
        Next x
    End Sub

    Private Sub txtExpPeriod_Validating(sender As System.Object, e As System.EventArgs) Handles txtExpPeriod.Validating
        If txtExpPeriod.Text = " " Or txtExpPeriod.Text.Length = 0 Then
            MessageBox.Show("Expiry Period cannot be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtExpPeriod.Focus()
        End If
    End Sub

    
End Class