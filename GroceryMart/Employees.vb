

Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class Employees

    Dim objConnection As New SqlConnection("Data Source=OMKAR-PC\OMKAR;Initial Catalog=Grocery_Mart;Integrated Security=True")
    Dim objConnection2 As New SqlConnection("Data Source=OMKAR-PC\OMKAR;Initial Catalog=Grocery_Mart;Integrated Security=True")
    Dim objConnection3 As New SqlConnection("Data Source=OMKAR-PC\OMKAR;Initial Catalog=Grocery_Mart;Integrated Security=True")
    Dim objDataAdapter As New SqlDataAdapter("SELECT * from Employees", objConnection)
    Dim objDataSet As DataSet
    Dim objDataView As DataView
    Dim objCurrencyManager As CurrencyManager

    Dim str1 As String
    Dim filename As String = "D:\BEProject2012\eBEST Grocery_files\proj_work\Images\img1.png"
    Dim finfo As FileInfo
    Dim fStream As FileStream
    Dim chkn As Integer = 0


    Private Sub FillDataSetAndView()
        ' Initialize a new instance of the DataSet object..
        objDataSet = New DataSet()
        ' Fill the DataSet object with data..
        objDataAdapter.Fill(objDataSet, "Employees")
        ' Set the DataView object to the DataSet object..
        objDataView = New DataView(objDataSet.Tables("Employees"))
        ' Set our CurrencyManager object to the DataView object..
        objCurrencyManager = CType(Me.BindingContext(objDataView), CurrencyManager)
    End Sub
    Private Sub ImageDisp()
        Dim imgcmd As New SqlCommand("Select pic from Employees where EmployeeID=@EmployeeID", objConnection)
        imgcmd.Parameters.AddWithValue("@EmployeeID", txtEmpId.Text)
        Try
            objConnection.Open()
            pictEmp.Image = Image.FromStream(New IO.MemoryStream(CType(imgcmd.ExecuteScalar, Byte())))
            ' or you can save in a file 
            'IO.File.WriteAllBytes("c:\backup\image3.jpg", CType(cmd.ExecuteScalar, Byte()))
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            objConnection.Close()
        End Try

    End Sub

    Private Sub clear_BindFields()
        txtEmpId.DataBindings.Clear()
        txtFName.DataBindings.Clear()
        txtLName.DataBindings.Clear()
        txtDOB.DataBindings.Clear()
        txtGender.DataBindings.Clear()
        txtHDate.DataBindings.Clear()
        txtDesignation.DataBindings.Clear()
        txtAddress.DataBindings.Clear()
        txtPCode.DataBindings.Clear()
        txtPhoneNo.DataBindings.Clear()
        txtReportsTo.DataBindings.Clear()
        txtLevel.DataBindings.Clear()
        txtCreatedBy.DataBindings.Clear()
        txtCreatedDate.DataBindings.Clear()
        txtUpdatedBy.DataBindings.Clear()
        txtUpdatedDate.DataBindings.Clear()
        pictEmp.DataBindings.Clear()
    End Sub
    Private Sub BindFields()
        ' Clear any previous bindings..
        clear_BindFields()
        ' Add new bindings to the DataView object..
        txtEmpId.DataBindings.Add("Text", objDataView, "EmployeeID")
        txtFName.DataBindings.Add("Text", objDataView, "FName")
        txtLName.DataBindings.Add("Text", objDataView, "LName")
        txtDOB.DataBindings.Add("Text", objDataView, "DOB")
        txtGender.DataBindings.Add("Text", objDataView, "Gender")

        txtHDate.DataBindings.Add("Text", objDataView, "Hiredate")
        txtDesignation.DataBindings.Add("Text", objDataView, "Designation")
        txtAddress.DataBindings.Add("Text", objDataView, "Address")
        txtPCode.DataBindings.Add("Text", objDataView, "Pcode")
        txtPhoneNo.DataBindings.Add("Text", objDataView, "Phone_no")
        txtReportsTo.DataBindings.Add("Text", objDataView, "Reports_To")
        txtLevel.DataBindings.Add("Text", objDataView, "Level")
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

        txtFName.Enabled = True
        txtLName.Enabled = True
        txtDesignation.Enabled = True
        txtAddress.Enabled = True
        txtPCode.Enabled = True
        txtPhoneNo.Enabled = True
        txtReportsTo.Enabled = True
    End Sub

    Private Sub DisableAll()

        txtFName.Enabled = False
        txtLName.Enabled = False

        txtDesignation.Enabled = False
        txtAddress.Enabled = False
        txtPCode.Enabled = False
        txtPhoneNo.Enabled = False
        txtReportsTo.Enabled = False
    End Sub
    Private Sub Clear()

        txtFName.Text = " "
        txtLName.Text = " "
        txtDOB.Text = " "
        txtGender.Text = " "
        txtHDate.Text = " "
        txtDesignation.Text = " "
        txtAddress.Text = " "
        txtPCode.Text = " "
        txtPhoneNo.Text = " "
        txtReportsTo.Text = " "
        txtLevel.Text = " "
        txtCreatedBy.Text = " "
        txtUpdatedBy.Text = " "
        txtUpdatedDate.Text = " "
        pictEmp.ImageLocation = "D:\BEProject2012\eBEST Grocery_files\proj_work\Images\img1.png"
        clear_BindFields()
    End Sub

    Private Sub employees_chk()
        Dim objCmdchk As New SqlCommand
        Dim count As Integer
        Try
            objCmdchk = New SqlCommand("SELECT count(*) from Employees", objConnection)
            objConnection.Open()
            count = objCmdchk.ExecuteScalar
            objConnection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        If count = 0 Then
            Clear()
            txtEmpId.Text = " "
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
            position_chk()
        End If
    End Sub

    Private Sub Employees_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Me.Visible = True
        Me.Refresh()
        
        employees_chk()
        btnCancel.Visible = False
        btnClear.Visible = False
        btnSaveChanges.Visible = False

        ' Fill the DataSet and bind the fields..

        txtEmpId.Enabled = False
        txtDOB.Enabled = False
        txtHDate.Enabled = False
        rdMale.Enabled = False
        rdfemale.Enabled = False
        txtCreatedBy.Enabled = False
        txtCreatedDate.Enabled = False
        txtUpdatedBy.Enabled = False
        txtUpdatedDate.Enabled = False



        txtGender.Visible = False
        DisableAll()

        btnFind.Focus()

    End Sub
    Private Function Verify()
        If (txtFName.Text = " " Or txtLName.Text = " " Or txtDOB.Text = " " Or txtDesignation.Text = " " Or txtAddress.Text = " " Or txtPCode.Text = " " Or txtPhoneNo.Text = " ") Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub Add_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        Dim empid As String = txtEmpId.Text
        If Verify() Then

            Dim objCmd As New SqlCommand

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


                objCmd.Connection = objConnection
                objCmd.CommandText = "Insert into Employees Select @EmployeeID,@FName,@Lname,@DOB,@Gender,@Hiredate,@Designation,@Address,@PCode,@Phone_no,@Reports_To,@Level,@Created_By,@Created_Date,Null,Null,@pic"
                objCmd.Parameters.AddWithValue("@EmployeeID", txtEmpId.Text)
                objCmd.Parameters.AddWithValue("@FName", txtFName.Text)
                objCmd.Parameters.AddWithValue("@LName", txtLName.Text)
                objCmd.Parameters.Add(New SqlParameter("@DOB", SqlDbType.Date)).Value = txtDOB.Text
                objCmd.Parameters.AddWithValue("@Gender", txtGender.Text)
                objCmd.Parameters.Add(New SqlParameter("@Hiredate", SqlDbType.Date)).Value = txtHDate.Text
                objCmd.Parameters.AddWithValue("@Designation", txtDesignation.Text)
                objCmd.Parameters.AddWithValue("@Address", txtAddress.Text)
                objCmd.Parameters.AddWithValue("@PCode", txtPCode.Text)
                objCmd.Parameters.AddWithValue("@Phone_no", txtPhoneNo.Text)
                objCmd.Parameters.AddWithValue("@Reports_To", txtReportsTo.Text)
                objCmd.Parameters.AddWithValue("@Level", cboLevel.Text)
                objCmd.Parameters.AddWithValue("@Created_By", MDIParent1.ToolStripStatusLabel3.Text)
                objCmd.Parameters.Add(New SqlParameter("@Created_Date", SqlDbType.Date)).Value = txtCreatedDate.Text

                objCmd.Parameters.Add(New SqlParameter("@pic", SqlDbType.Image)).Value = btimage
                objCmd.ExecuteNonQuery()

                objConnection.Close()

                MsgBox("You have Successfully Added the Record")



                btnClear.Visible = False
                btnAdd.Visible = False
                btnChangePic.Visible = True
                btnAddNew.Visible = True
                btnBrowse.Visible = False
                btnCancel.Visible = False

                txtEmpId.Enabled = False
                txtDOB.Enabled = False
                txtHDate.Enabled = False
                rdMale.Enabled = False
                rdfemale.Enabled = False
                txtLevel.Visible = True
                cboLevel.Visible = False
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
            Gender_Chk()

        Else
            MessageBox.Show("Fields cannot be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End If

        Dim objCmdSI As New SqlCommand
        Try
            objCmdSI.Connection = objConnection2
            objCmdSI.CommandText = "Insert into ODS_Stage.dbo.ODS_Employees Select *, 'I' as Op from dbo.Employees where dbo.Employees.EmployeeID = '" & empid & "'"
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
            objCmdCR.CommandText = "Delete from Employees_Current_Log where SUBSTRING(EmployeeID, 1, 3) = '" & empid.Substring(1, 2) & "'"
            objConnection3.Open()
            objCmdCR.ExecuteNonQuery()
            objConnection3.Close()
            objCmdCR.CommandText = "Insert into Employees_Current_Log Select count(SrNo) +1, '" & cboLevel.Text & "','" & empid & "' from Employees_Current_Log"
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

    End Sub

    Private Sub Next_Click(sender As System.Object, e As System.EventArgs) Handles btnNext.Click
        ' Move to the next record..

        objCurrencyManager.Position += 1
        position_chk()
            Gender_Chk()
            ImageDisp()

    End Sub

    Private Sub Previous_Click(sender As System.Object, e As System.EventArgs) Handles btnPrevious.Click

        ' Move to the previous record..

        objCurrencyManager.Position -= 1
        position_chk()
            Gender_Chk()
            ImageDisp()

    End Sub

    Private Sub Last_Click(sender As System.Object, e As System.EventArgs) Handles btnLast.Click
        ' Set the record position to the last record..

        objCurrencyManager.Position = objCurrencyManager.Count - 1
        position_chk()
        Gender_Chk()
        ImageDisp()

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
        EnableAll()

    End Sub


    Private Sub btnRemove_Click(sender As System.Object, e As System.EventArgs) Handles btnRemove.Click

        Dim empid As String = txtEmpId.Text
        Dim objCmd3 As New SqlCommand
        Dim Position = objCurrencyManager.Position
        Try
            objConnection.Open()
            objCmd3.Connection = objConnection
            objCmd3.CommandText = "Delete from Employees where EmployeeId = @EmployeeID"
            objCmd3.Parameters.AddWithValue("@EmployeeID", txtEmpId.Text)
            objCmd3.ExecuteNonQuery()

            MsgBox("You have Successfully Deleted the record")

            objConnection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Dim objCmdSD As New SqlCommand
        Try
            objCmdSD.Connection = objConnection3
            objCmdSD.CommandText = "Insert into Employees_Delete_Log Select count(SrNo) +1, '" & empid & "' from Employees_Delete_Log"
            objConnection3.Open()
            objCmdSD.ExecuteNonQuery()
            objConnection3.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Me.Close()
        End Try
        Dim count As Integer
        Try
            Dim objCmdchk = New SqlCommand("SELECT count(*) from Employees", objConnection)
            objConnection.Open()
            count = objCmdchk.ExecuteScalar
            objConnection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        If count = 0 Then
            employees_chk()
        Else
            FillDataSetAndView()
            BindFields()
            objCurrencyManager.Position = Position - 1
            Gender_Chk()
            ImageDisp()
        End If
    End Sub


    Private Sub btnBrowse_Click_1(sender As System.Object, e As System.EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.Title = "Please Select an Image."
        OpenFileDialog1.InitialDirectory = "D:\BEProject2012\"
        OpenFileDialog1.Filter = "Image Files(*.bmp;*.jpg;*.gif;*.png)|*.bmp;*.jpg;*gif;*.png"
        OpenFileDialog1.ShowDialog()
    End Sub


    Private Sub OpenFileDialog1_FileOk(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        filename = OpenFileDialog1.FileName.ToString()
    End Sub
    Private Sub btnAddNew_Click(sender As System.Object, e As System.EventArgs) Handles btnAddNew.Click
        Clear()

        btnAddNew.Visible = False
        btnUpdate.Enabled = False
        btnRemove.Enabled = False
        btnBrowse.Visible = True
        btnClear.Visible = True
        btnCancel.Visible = True
        btnCancel.Enabled = True
        btnChangePic.Visible = False
        txtLevel.Visible = False
        cboLevel.Visible = True
        btnFirst.Enabled = False
        btnNext.Enabled = False
        btnPrevious.Enabled = False
        btnLast.Enabled = False
        txtEmpId.Text = " "
        rdMale.Enabled = True
        rdfemale.Enabled = True
        rdMale.Checked = True
        MsgBox("Select the Employee Level.")
    End Sub
    Private Sub cboLevel_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboLevel.SelectedIndexChanged
        EnableAll()
        btnAdd.Visible = True
        txtDOB.Enabled = True
        txtHDate.Enabled = True
        txtHDate.Text = Date.Today


        Dim objcmdL As New SqlCommand
        Dim emid As String = " "
        Try

            objcmdL.Connection = objConnection3
            objcmdL.CommandText = "Select EmployeeID from Employees_Current_Log where Level = '" & cboLevel.Text & "'"
            objConnection3.Open()
            emid = objcmdL.ExecuteScalar()
            objConnection3.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Try
            If emid = Nothing Then
                txtEmpId.Text = "E" + cboLevel.Text.Chars(1) + "0001"
                chkn = 1
            Else
                Dim eid As String
                eid = "E" + (Val(emid.Substring(1, 5)) + 1).ToString
                txtEmpId.Text = eid
            End If
        Catch ex As Exception
        End Try
        rdMale.Enabled = True
        rdfemale.Enabled = True
        txtCreatedBy.Text = MDIParent1.ToolStripStatusLabel3.Text
        txtCreatedDate.Text = Date.Today
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
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Dim empid As String = txtEmpId.Text
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
                objCmd4.CommandText = "Update Employees Set Updated_By = @Updated_By, Updated_Date = @Updated_Date, pic = @pic where EmployeeID = @EmployeeID"
                objCmd4.Parameters.AddWithValue("@EmployeeID", txtEmpId.Text)
                objCmd4.Parameters.AddWithValue("@Updated_By", MDIParent1.ToolStripStatusLabel3.Text)
                objCmd4.Parameters.AddWithValue("@Updated_Date", Date.Today)
                objCmd4.Parameters.Add(New SqlParameter("@pic", SqlDbType.Image)).Value = btimage
                objCmd4.ExecuteNonQuery()

                MsgBox("You have Successfully Changed the Image")

                objConnection.Close()

                btnChangePic.Enabled = True

                btnAddNew.Enabled = True
                btnUpdate.Enabled = True
                btnRemove.Enabled = True
                btnBrowse.Visible = False
                btnSave.Visible = False
                btnCancel.Visible = False

                btnFirst.Enabled = True
                btnNext.Enabled = True
                btnPrevious.Enabled = True
                btnLast.Enabled = True

                ImageDisp()

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
        Dim objCmdSU As New SqlCommand
        Try
            objCmdSU.Connection = objConnection2
            objCmdSU.CommandText = "Delete from ODS_Employees where EmployeeID = '" & empid & "'"
            objConnection2.Open()
            objCmdSU.ExecuteNonQuery()
            objConnection2.Close()
            objCmdSU.CommandText = "Insert into dbo.ODS_Employees Select *, 'U' as Op from dbo.Employees where dbo.Employees.EmployeeID = '" & empid & "'"
            objConnection2.Open()
            objCmdSU.ExecuteNonQuery()
            objConnection2.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Me.Close()
        End Try
    End Sub

    Private Sub btnSaveChanges_Click(sender As System.Object, e As System.EventArgs) Handles btnSaveChanges.Click
        Dim empid As String = txtEmpId.Text
        If Verify() Then
            Dim objCmd2 As New SqlCommand
            Dim Position = objCurrencyManager.Position
            Try
                objConnection.Open()

                objCmd2.Connection = objConnection
                objCmd2.CommandText = "Update Employees Set Fname = @FName,LName = @Lname,Designation = @Designation,Address = @Address, PCode = @PCode,Phone_no = @Phone_no,Reports_To = @Reports_To, Updated_By = @Updated_By, Updated_Date = @Updated_Date where EmployeeID = @EmplID"
                objCmd2.Parameters.AddWithValue("@EmplID", txtEmpId.Text)
                objCmd2.Parameters.AddWithValue("@FName", txtFName.Text)
                objCmd2.Parameters.AddWithValue("@LName", txtLName.Text)
                objCmd2.Parameters.AddWithValue("@Designation", txtDesignation.Text)
                objCmd2.Parameters.AddWithValue("@Address", txtAddress.Text)
                objCmd2.Parameters.AddWithValue("@PCode", txtPCode.Text)
                objCmd2.Parameters.AddWithValue("@Phone_no", txtPhoneNo.Text)
                objCmd2.Parameters.AddWithValue("@Reports_To", txtReportsTo.Text)
                objCmd2.Parameters.AddWithValue("@Updated_By", MDIParent1.ToolStripStatusLabel3.Text)
                objCmd2.Parameters.AddWithValue("@Updated_Date", Date.Today)
                objCmd2.ExecuteNonQuery()
                objConnection.Close()

                MsgBox("You have Successfully Updated this Record")

                btnSaveChanges.Visible = False
                btnUpdate.Visible = True
                btnAddNew.Enabled = True
                btnRemove.Enabled = True
                btnCancel.Visible = False

                btnUpdate.Enabled = True

                btnFirst.Enabled = True
                btnNext.Enabled = True
                btnPrevious.Enabled = True
                btnLast.Enabled = True
                DisableAll()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

            FillDataSetAndView()
            BindFields()
            objCurrencyManager.Position = Position
            ImageDisp()
            Gender_Chk()

        Else
            MessageBox.Show("Fields cannot be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Dim objCmdSU As New SqlCommand
        Try
            objCmdSU.Connection = objConnection2
            objCmdSU.CommandText = "Delete from ODS_Employees where EmployeeID = '" & empid & "'"
            objConnection2.Open()
            objCmdSU.ExecuteNonQuery()
            objConnection2.Close()
            objCmdSU.CommandText = "Insert into dbo.ODS_Employees Select *, 'U' as Op from dbo.Employees where dbo.Employees.EmployeeID = '" & empid & "'"
            objConnection2.Open()
            objCmdSU.ExecuteNonQuery()
            objConnection2.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Me.Close()
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Dim objCmdchk As New SqlCommand
        Dim count As Integer
        Try
            objCmdchk = New SqlCommand("SELECT count(*) from Employees", objConnection)
            objConnection.Open()
            count = objCmdchk.ExecuteScalar
            objConnection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        If count = 0 Then
            Me.Close()
        Else

            Dim Position = objCurrencyManager.Position
            FillDataSetAndView()
            BindFields()
            objCurrencyManager.Position = Position
            ImageDisp()
            Gender_Chk()

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
            txtLevel.Visible = True
            cboLevel.Visible = False

            DisableAll()
            txtEmpId.Enabled = False
            txtDOB.Enabled = False
            txtHDate.Enabled = False
        End If
    End Sub





    Private Sub btnFind_Click(sender As System.Object, e As System.EventArgs) Handles btnFind.Click
        If (cboField.Text.Length = 0) Then
            MsgBox("Select the Field to be Searched")

        ElseIf (txtSearchCriteria.Text.Length = 0 or txtSearchCriteria.Text = " ") Then
            MsgBox("Select the Search Criteria to be Searched")
        Else

            Dim intPosition As Integer
            Select Case cboField.SelectedIndex
                Case 0
                    objDataView.Sort = "EmployeeID"
                Case 1
                    objDataView.Sort = "FName"
                Case 2
                    objDataView.Sort = "LName"
            End Select


            intPosition = objDataView.Find(Trim(txtSearchCriteria.Text))

            If intPosition = -1 Then
                MsgBox("Record Not Found.")
            Else
                MsgBox("Record Found.")

                objCurrencyManager.Position = intPosition
                ImageDisp()
                Gender_Chk()


            End If


            cboField.Text = " "
            txtSearchCriteria.Text = " "

        End If
    End Sub






    Private Sub txtFName_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtFName.Validating
        If txtFName.Text = " " Or txtFName.Text.Length = 0 Then
            MessageBox.Show("First Name cannot be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtFName.Focus()
        End If
        Dim x As Integer
        For x = 0 To (Len(txtFName.Text) - 1)
            If IsNumeric(txtFName.Text.Chars(x)) Then
                MessageBox.Show("Enter only alphabets!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtFName.Text = " "
                txtFName.Focus()
                Exit For
            End If
        Next x
    End Sub

    Private Sub txtLName_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtLName.Validating
        If txtLName.Text = " " Or txtLName.Text.Length = 0 Then
            MessageBox.Show("Last Name cannot be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtLName.Focus()
        End If
        Dim x As Integer
        For x = 0 To (Len(txtLName.Text) - 1)
            If IsNumeric(txtLName.Text.Chars(x)) Then
                MessageBox.Show("Enter only alphabets!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtLName.Text = " "
                txtLName.Focus()
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

    Private Sub txtDesignation_Validating(sender As System.Object, e As System.EventArgs) Handles txtDesignation.Validating
        If txtDesignation.Text = " " Or txtDesignation.Text.Length = 0 Then
            MessageBox.Show("Destination cannot be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDesignation.Focus()
        End If
        Dim x As Integer
        For x = 0 To (Len(txtDesignation.Text) - 1)
            If IsNumeric(txtDesignation.Text.Chars(x)) Then
                MessageBox.Show("Enter only alphabets!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtDesignation.Text = " "
                txtDesignation.Focus()
                Exit For
            End If
        Next x
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

    Private Sub txtPhoneNo_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtPhoneNo.Validating

        If txtPhoneNo.Text.Length <> 11 Or Not IsNumeric(txtPhoneNo.Text) Then
            MessageBox.Show("Enter a 10 digit Mobile Number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPhoneNo.Text = " "
            txtPhoneNo.Focus()
        End If
    End Sub


    Private Sub cboField_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboField.SelectedIndexChanged
       
    End Sub
End Class



