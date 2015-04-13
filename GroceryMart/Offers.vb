Imports System.Data
Imports System.Data.SqlClient
Imports System.IO


Public Class Offers
    Dim objConnection As New SqlConnection("Data Source=BHASWANTH-PC\SQLEXPRESS;Initial Catalog=Grocery_Mart;Integrated Security=True")
    Dim objConnection2 As New SqlConnection("Data Source=BHASWANTH-PC\SQLEXPRESS;Initial Catalog=ODS_Stage;Integrated Security=True")
    Dim objConnection3 As New SqlConnection("Data Source=BHASWANTH-PC\SQLEXPRESS;Initial Catalog=Metadata;Integrated Security=True")
    Dim objDataAdapter As New SqlDataAdapter("SELECT * from Offers", objConnection)
    Dim objDataSet As DataSet
    Dim objDataView As DataView
    Dim objCurrencyManager As CurrencyManager
    Private Sub FillDataSetAndView()
        ' Initialize a new instance of the DataSet object..
        objDataSet = New DataSet()
        ' Fill the DataSet object with data..
        objDataAdapter.Fill(objDataSet, "Offers")
        ' Set the DataView object to the DataSet object..
        objDataView = New DataView(objDataSet.Tables("Offers"))
        ' Set our CurrencyManager object to the DataView object..
        objCurrencyManager = CType(Me.BindingContext(objDataView), CurrencyManager)
    End Sub
    Private Sub clear_bindings()
        ' Clear any previous bindings..
        txtOfferNo.DataBindings.Clear()
        txtOName.DataBindings.Clear()
        txtPMargin.DataBindings.Clear()
        txtDiscount.DataBindings.Clear()
        txtSDate.DataBindings.Clear()
        txtEDate.DataBindings.Clear()
        txtCreatedBy.DataBindings.Clear()
        txtCreatedDate.DataBindings.Clear()
        txtUpdatedBy.DataBindings.Clear()
        txtUpdatedDate.DataBindings.Clear()

    End Sub
    Private Sub BindFields()

        clear_bindings()
        ' Add new bindings to the DataView object..
        txtOfferNo.DataBindings.Add("Text", objDataView, "Offer_No")
        txtOName.DataBindings.Add("Text", objDataView, "Offer_Name")
        txtPMargin.DataBindings.Add("Text", objDataView, "Price_Margin")
        txtDiscount.DataBindings.Add("Text", objDataView, "Discount")
        txtSDate.DataBindings.Add("Text", objDataView, "Start_Date")
        txtEDate.DataBindings.Add("Text", objDataView, "End_Date")
        txtCreatedBy.DataBindings.Add("Text", objDataView, "Created_By")
        txtCreatedDate.DataBindings.Add("Text", objDataView, "Created_Date")
        txtUpdatedBy.DataBindings.Add("Text", objDataView, "Updated_By")
        txtUpdatedDate.DataBindings.Add("Text", objDataView, "Updated_Date")

    End Sub


    Private Sub Clear()
        clear_bindings()
        txtOName.Text = " "
        txtPMargin.Text = " "
        txtDiscount.Text = " "
        txtSDate.Text = " "
        txtEDate.Text = ""
    End Sub

    Private Sub Offers_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Visible = True
        Me.Refresh()
        Dim objCmdchk As New SqlCommand
        Dim count As Integer
        Try
            objCmdchk = New SqlCommand("SELECT count(*) from Offers", objConnection)
            objConnection.Open()
            count = objCmdchk.ExecuteScalar
            objConnection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        If count = 0 Then
            Clear()
            txtOfferNo.Text = " "
            btnAddNew.Visible = True
            btnUpdate.Visible = False
            btnRemove.Visible = False
        Else
            btnAddNew.Visible = False
            btnAdd.Visible = False
            btnUpdate.Visible = True
            btnRemove.Visible = True
            FillDataSetAndView()
            BindFields()
        End If
    End Sub

    Private Sub btnAddNew_Click(sender As System.Object, e As System.EventArgs) Handles btnAddNew.Click
        Clear()

        btnAdd.Visible = True

        btnAddNew.Visible = False
        btnUpdate.Visible = False
        btnRemove.Visible = False
        btnCancel.Enabled = True
        txtOName.Enabled = True
        txtPMargin.Enabled = True
        txtDiscount.Enabled = True
        txtSDate.Enabled = True
        txtEDate.Enabled = True

        Dim objcmdL As New SqlCommand
        Dim offerno As String = " "
        Dim len As Integer = 0
        Try

            objcmdL.Connection = objConnection3
            objcmdL.CommandText = "Select OfferNo from Offers_Current_Log"
            objConnection3.Open()
            offerno = objcmdL.ExecuteScalar()
            objConnection3.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Try
            If offerno = Nothing Then
                txtOfferNo.Text = "O" + "0001"
            Else
                len = Val(offerno.Substring(1, 4)).ToString.Length
                Dim ono As String
                If len = 1 Then
                    ono = "O000" + (Val(offerno.Substring(1, 4)) + 1).ToString
                ElseIf len = 2 Then
                    ono = "O00" + (Val(offerno.Substring(1, 4)) + 1).ToString

                elseif len = 3 then
                ono = "O0" + (Val(offerno.Substring(1, 4)) + 1).ToString
                Else
                    ono = "O" + (Val(offerno.Substring(1, 4)) + 1).ToString
                End If
                txtOfferNo.Text = ono
            End If
        Catch ex As Exception
        End Try


        txtCreatedBy.Text = MDIParent1.ToolStripStatusLabel3.Text
        txtCreatedDate.Text = Date.Today
    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        Dim objCmd1 As New SqlCommand
        Dim offerno As String = txtOfferNo.Text
        Try
            objConnection.Open()

            objCmd1.Connection = objConnection
            objCmd1.CommandText = "Insert into Offers Select @OfferNo,@OName,@PMargin,@Discount,@SD,@ED,@Created_By,@Created_Date,Null,Null"
            objCmd1.Parameters.AddWithValue("@OfferNo", txtOfferNo.Text)
            objCmd1.Parameters.AddWithValue("@OName", txtOName.Text)
            objCmd1.Parameters.AddWithValue("@PMargin", txtPMargin.Text)
            objCmd1.Parameters.AddWithValue("@Discount", txtDiscount.Text)
            objCmd1.Parameters.Add(New SqlParameter("@SD", SqlDbType.Date)).Value = txtSDate.Text
            objCmd1.Parameters.Add(New SqlParameter("@ED", SqlDbType.Date)).Value = txtEDate.Text
            objCmd1.Parameters.AddWithValue("@Created_By", MDIParent1.ToolStripStatusLabel3.Text)
            objCmd1.Parameters.AddWithValue("@Created_Date", Date.Today)
            objCmd1.ExecuteNonQuery()

            objConnection.Close()

            MsgBox("You have Successfully Added the Record")

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Dim objCmdSI As New SqlCommand
        Try
            objCmdSI.Connection = objConnection2
            objCmdSI.CommandText = "Insert into ODS_Stage.dbo.ODS_Offers Select *, 'I' as Op from Grocery_Mart.dbo.Offers where Grocery_Mart.dbo.Offers.Offer_No = '" & offerno & "'"
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
            objCmdCR.CommandText = "Delete from Offers_Current_Log"
            objConnection3.Open()
            objCmdCR.ExecuteNonQuery()
            objConnection3.Close()
            objCmdCR.CommandText = "Insert into Offers_Current_Log Select 1, '" & offerno & "'"
            objConnection3.Open()
            objCmdCR.ExecuteNonQuery()
            objConnection3.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Me.Close()
        End Try
       Me.Close()

    End Sub

    Private Sub btnUpdate_Click(sender As System.Object, e As System.EventArgs) Handles btnUpdate.Click
        btnSaveChanges.Visible = True
        btnUpdate.Visible = False
        btnAddNew.Visible = False
        btnRemove.Visible = False
        btnCancel.Visible = True
        txtOName.Enabled = True
        txtPMargin.Enabled = True
        txtDiscount.Enabled = True
        txtSDate.Enabled = True
        txtEDate.Enabled = True
    End Sub

    Private Sub btnSaveChanges_Click(sender As System.Object, e As System.EventArgs) Handles btnSaveChanges.Click
        Dim offerno As String = txtOfferNo.Text
        Try
            Dim objCmd2 As New SqlCommand
            Dim Position = objCurrencyManager.Position
            objCmd2.Connection = objConnection
            objCmd2.CommandText = "Update Offers Set Offer_Name = @OName,Price_Margin = @PMargin, Discount = @Discount,Start_Date = @SD, End_Date = @ED, Updated_By = @Updated_By, Updated_Date = @Updated_Date where Offer_No = @OfferNo"
            objCmd2.Parameters.AddWithValue("@OfferNo", txtOfferNo.Text)
            objCmd2.Parameters.AddWithValue("@OName", txtOName.Text)
            objCmd2.Parameters.AddWithValue("@PMargin", txtPMargin.Text)
            objCmd2.Parameters.AddWithValue("@Discount", txtDiscount.Text)
            objCmd2.Parameters.Add(New SqlParameter("@SD", SqlDbType.Date)).Value = txtSDate.Text
            objCmd2.Parameters.Add(New SqlParameter("@ED", SqlDbType.Date)).Value = txtEDate.Text
            objCmd2.Parameters.AddWithValue("@Updated_By", MDIParent1.ToolStripStatusLabel3.Text)
            objCmd2.Parameters.AddWithValue("@Updated_Date", Date.Today)
            objConnection.Open()
            objCmd2.ExecuteNonQuery()
            objConnection.Close()

            MsgBox("You have Successfully Updated this Record")

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Dim objCmdSU As New SqlCommand
        Try
            objCmdSU.Connection = objConnection2
            objCmdSU.CommandText = "Delete from ODS_Offers where Offer_No = '" & offerno & "'"
            objConnection2.Open()
            objCmdSU.ExecuteNonQuery()
            objConnection2.Close()
            objCmdSU.CommandText = "Insert into ODS_Stage.dbo.ODS_Offers Select *, 'U' as Op from Grocery_Mart.dbo.Offers where Grocery_Mart.dbo.Offers.Offer_NO = '" & offerno & "'"
            objConnection2.Open()
            objCmdSU.ExecuteNonQuery()
            objConnection2.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.Close()
    End Sub

    Private Sub btnRemove_Click(sender As System.Object, e As System.EventArgs) Handles btnRemove.Click
        Dim offers As String = txtOfferNo.Text
        Dim objCmd3 As New SqlCommand
        Dim Position = objCurrencyManager.Position
        Try
            objConnection.Open()
            objCmd3.Connection = objConnection
            objCmd3.CommandText = "Delete from Offers where Offer_No = @OfferNo"
            objCmd3.Parameters.AddWithValue("@OfferNo", txtOfferNo.Text)
            objCmd3.ExecuteNonQuery()

            MsgBox("You have Successfully Deleted the Record")

            objConnection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Dim objCmdSD As New SqlCommand
        Try
            objCmdSD.Connection = objConnection3
            objCmdSD.CommandText = "Insert into Offers_Delete_Log Select 1,'" & offers & "' from Offers_Delete_Log"
            objConnection3.Open()
            objCmdSD.ExecuteNonQuery()
            objConnection3.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        btnAddNew.Visible = True
        btnUpdate.Visible = False
        btnRemove.Visible = False
    End Sub

   
    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Clear()
    End Sub

    Private Sub txtOName_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtOName.Validating
        If txtOName.Text = " " Or txtOName.Text.Length = 0 Then
            MessageBox.Show("Offer Name cannot be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtOName.Text = " "
            txtOName.Focus()
        End If
    End Sub
    Private Sub txtPMargin_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtPMargin.Validating
        If Not IsNumeric(txtPMargin.Text) Then
            MessageBox.Show("Enter only Numberic Value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPMargin.Text = " "
            txtPMargin.Focus()
        End If
    End Sub

    Private Sub txtDiscount_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDiscount.TextChanged
        If Not IsNumeric(txtDiscount.Text) Then
            MessageBox.Show("Enter only Numberic Value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDiscount.Text = " "
            txtDiscount.Focus()
        End If
    End Sub
    Private Sub txtSDate_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtSDate.Validating
        If Not IsDate(txtSDate.Text) Then
            MessageBox.Show("Enter appropriate date as dd-mm-yyyy!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSDate.Text = " "
            txtSDate.Focus()
        End If
    End Sub

    Private Sub txtEDate_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtEDate.Validating
        If Not IsDate(txtEDate.Text) Then
            MessageBox.Show("Enter appropriate date as dd-mm-yyyy!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtEDate.Text = " "
            txtEDate.Focus()
        End If
    End Sub
End Class