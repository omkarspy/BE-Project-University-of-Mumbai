
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class Cards

    Dim objConnection As New SqlConnection("Data Source=OMKAR-PC\OMKAR;Initial Catalog=Grocery_Mart;Integrated Security=True")
    Dim objConnection2 As New SqlConnection("Data Source=OMKAR-PC\OMKAR;Initial Catalog=Grocery_Mart;Integrated Security=True")
    Dim objConnection3 As New SqlConnection("Data Source=OMKAR-PC\OMKAR;Initial Catalog=Grocery_Mart;Integrated Security=True")
    Dim objDataAdapter As New SqlDataAdapter()
    Dim objDataSet As DataSet
    Dim objDataView As DataView
    Dim objCurrencyManager As CurrencyManager

    Private Sub FillDataSetAndView()
        ' Initialize a new instance of the DataSet object..
        objDataSet = New DataSet()
        ' Fill the DataSet object with data..
        objDataAdapter.Fill(objDataSet, "Cards")
        ' Set the DataView object to the DataSet object..
        objDataView = New DataView(objDataSet.Tables("Cards"))

        objCurrencyManager = CType(Me.BindingContext(objDataView), CurrencyManager)
    End Sub
    Private Sub Clear_Bindings()
        txtCardType.DataBindings.Clear()
        txtCardNo.DataBindings.Clear()
        txtValidity.DataBindings.Clear()
        txtIssuedOn.DataBindings.Clear()
        txtExpiryOn.DataBindings.Clear()
        txtIssuingAuth.DataBindings.Clear()
        txtCredits.DataBindings.Clear()
        txtCreatedBy.DataBindings.Clear()
        txtCreatedDate.DataBindings.Clear()
        txtUpdatedBy.DataBindings.Clear()
        txtUpdatedDate.DataBindings.Clear()
    End Sub

    Private Sub BindFields()
        ' Clear any previous bindings..

        Clear_Bindings()
        ' Add new bindings to the DataView object..
        txtCardType.DataBindings.Add("Text", objDataView, "Card_Type")
        txtCardNo.DataBindings.Add("Text", objDataView, "Card_No")
        txtValidity.DataBindings.Add("Text", objDataView, "Card_Validity")
        txtIssuedOn.DataBindings.Add("Text", objDataView, "Issued_On")
        txtExpiryOn.DataBindings.Add("Text", objDataView, "Expiry_On")
        txtIssuingAuth.DataBindings.Add("Text", objDataView, "Issuing_Authority")
        txtCredits.DataBindings.Add("Text", objDataView, "Credits")
        txtCreatedBy.DataBindings.Add("Text", objDataView, "Created_By")
        txtCreatedDate.DataBindings.Add("Text", objDataView, "Created_Date")
        txtUpdatedBy.DataBindings.Add("Text", objDataView, "Updated_By")
        txtUpdatedDate.DataBindings.Add("Text", objDataView, "Updated_Date")



    End Sub

    Private Sub Cards_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        If Customers.chkv = 1 Then
            Dim objCmd0 As New SqlCommand
            objCmd0.Connection = objConnection
            objCmd0.CommandText = "Select * from Cards where Card_No = @CardNo"
            objCmd0.Parameters.AddWithValue("@CardNo", Customers.txtCardNo.Text)
            objDataAdapter.SelectCommand = objCmd0
            FillDataSetAndView()
            BindFields()
            txtIssuingAuth.Enabled = False

        End If

    End Sub



    Private Sub cboCardType_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboCardType.SelectedIndexChanged
        Dim cardtype As String = cboCardType.Text
     Dim objcmdL As New SqlCommand
        Dim cdno As String = " "
        Try

            objcmdL.Connection = objConnection3
            objcmdL.CommandText = "Select Card_No from Cards_Current_Log where Card_Type = '" & cardtype & "'"
            objConnection3.Open()
            cdno = objcmdL.ExecuteScalar()
            objConnection3.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Try
            If cdno = Nothing Then
                txtCardNo.Text = cboCardType.Text.Substring(0, 1) + "0000001"
            Else
                Dim cid As String
                cid = cboCardType.Text.Substring(0, 1) + (Val("1" + cdno.Substring(1, 7)) + 1).ToString.Substring(1, 7)
                txtCardNo.Text = cid
            End If
        Catch ex As Exception
        End Try

        txtIssuedOn.Text = Date.Today
        txtValidity.Text = "Yes"
        If cboCardType.SelectedItem = "Silver" Then
            txtCredits.Text = 200
            txtExpiryOn.Text = DateAdd(DateInterval.Year, 1, Date.Today)
        ElseIf cboCardType.SelectedItem = "Gold" Then
            txtCredits.Text = 500
            txtExpiryOn.Text = DateAdd(DateInterval.Year, 2, Date.Today)
        Else
            txtCredits.Text = 1000
            txtExpiryOn.Text = DateAdd(DateInterval.Year, 3, Date.Today)
        End If

    End Sub
    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        Dim cardno As String = txtCardNo.Text
        Dim cardtype As String = cboCardType.Text
        If txtIssuingAuth.Text = " " Then
            MessageBox.Show("Issuing Authority cannot be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim objCmd2 As New SqlCommand
            Dim objCmd3 As New SqlCommand
            Try
                objConnection.Open()

                objCmd2.Connection = objConnection
                objCmd2.CommandText = "Insert into Cards Select @CardNo,@CardType,@Validity,@IssuedOn,@ExpiryOn,@IA,@Credits,@Created_By,@Created_Date,Null,Null"
                objCmd2.Parameters.AddWithValue("@CardNo", txtCardNo.Text)
                objCmd2.Parameters.AddWithValue("@CardType", cboCardType.Text)
                objCmd2.Parameters.AddWithValue("@Validity", txtValidity.Text)
                objCmd2.Parameters.Add(New SqlParameter("@IssuedOn", SqlDbType.Date)).Value = txtIssuedOn.Text
                objCmd2.Parameters.Add(New SqlParameter("@ExpiryOn", SqlDbType.Date)).Value = txtExpiryOn.Text
                objCmd2.Parameters.AddWithValue("@IA", txtIssuingAuth.Text)
                objCmd2.Parameters.AddWithValue("@Credits", txtCredits.Text)
                objCmd2.Parameters.AddWithValue("@Created_By", txtCreatedBy.Text)
                objCmd2.Parameters.Add(New SqlParameter("@Created_Date", SqlDbType.Date)).Value = txtCreatedDate.Text

                objCmd2.ExecuteNonQuery()

                objCmd3.Connection = objConnection
                objCmd3.CommandText = "Update Customers Set Card_Number = @CardNo,Updated_By = @Updated_By,Updated_Date= @Updated_Date where CustomerID = @CustID"
                objCmd3.Parameters.AddWithValue("@CustID", Customers.txtCustId.Text)
                objCmd3.Parameters.AddWithValue("@CardNo", txtCardNo.Text)
                objCmd3.Parameters.AddWithValue("@Updated_By", txtCreatedBy.Text)
                objCmd3.Parameters.Add(New SqlParameter("@Updated_Date", SqlDbType.Date)).Value = txtCreatedDate.Text

                objCmd3.ExecuteNonQuery()

                objConnection.Close()


                MsgBox("You have Successfully Added the Record")
            Catch ex As Exception
                MsgBox(ex.ToString)
                Me.Close()
            End Try


            Customers.txtCardNo.Text = Me.txtCardNo.Text
            Customers.txtUpdatedBy.Text = Me.txtCreatedBy.Text
            Customers.txtUpdatedDate.Text = Me.txtCreatedDate.Text
            Customers.btnIssueCard.Enabled = False
            Customers.btnReissueCard.Enabled = True
            Customers.btnRevoke.Enabled = True
            Customers.btnCheck.Enabled = True
        End If
        Dim objCmdSI As New SqlCommand
        Try
            objCmdSI.Connection = objConnection2
            objCmdSI.CommandText = "Insert into dbo.ODS_Cards Select Card_No,Card_Type,Card_Validity,Issued_On,Expiry_On,Issuing_Authority,Created_By,Created_Date,Updated_By,Updated_Date, 'I' as Op from dbo.Cards where dbo.Cards.Card_No = '" & cardno & "'"
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
            objCmdCR.CommandText = "Delete from Cards_Current_Log where Card_Type = '" & cardtype & "'"
            objConnection3.Open()
            objCmdCR.ExecuteNonQuery()
            objConnection3.Close()
            objCmdCR.CommandText = "Insert into Cards_Current_Log Select count(SrNo) + 1,'" & cardtype & "','" & cardno & "' from Cards_Current_Log"
            objConnection3.Open()
            objCmdCR.ExecuteNonQuery()
            objConnection3.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Me.Close()
        End Try
        Customers.Enabled = True
        Customers.CardChk()
        Me.Close()
    End Sub

    Private Sub btnUpdate_Click(sender As System.Object, e As System.EventArgs) Handles btnUpdate.Click
        Dim objCmd4 As New SqlCommand
        Dim objCmd5 As New SqlCommand
        Dim cardno = txtCardNo.Text
        Customers.Enabled = True
        If txtIssuingAuth.Text = " " Then
            MessageBox.Show("Issuing Authority cannot be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else


            Try
                objConnection.Open()

                objCmd4.Connection = objConnection

                objCmd4.Connection = objConnection
                objCmd4.CommandText = "Update Cards Set Issuing_Authority = @IA, Issued_On = @IssuedOn,Expiry_On = @ExpiryOn,Updated_By = @Updated_By,@Updated_Date = @Updated_Date where Card_No = @CardNo"
                objCmd4.Parameters.AddWithValue("@CardNo", txtCardNo.Text)
                objCmd4.Parameters.AddWithValue("@IA", txtIssuingAuth.Text)
                objCmd4.Parameters.Add(New SqlParameter("@IssuedOn", SqlDbType.Date)).Value = txtIssuedOn.Text
                objCmd4.Parameters.Add(New SqlParameter("@ExpiryOn", SqlDbType.Date)).Value = txtExpiryOn.Text
                objCmd4.Parameters.AddWithValue("@Updated_By", txtUpdatedBy.Text)
                objCmd4.Parameters.Add(New SqlParameter("@Updated_Date", SqlDbType.Date)).Value = txtUpdatedDate.Text
                objCmd4.ExecuteNonQuery()
                objConnection.Close()

                MsgBox("You have Successfully Updated the Record")
                objConnection.Open()
                objCmd5.Connection = objConnection
                objCmd5.CommandText = "Update Customers Set Updated_By = @Updated_By,Updated_Date= @Updated_Date where Card_Number = @CardNo"
                objCmd5.Parameters.AddWithValue("@CardNo", txtCardNo.Text)
                objCmd5.Parameters.AddWithValue("@Updated_By", txtUpdatedBy.Text)
                objCmd5.Parameters.Add(New SqlParameter("@Updated_Date", SqlDbType.Date)).Value = txtUpdatedDate.Text
                objCmd5.ExecuteNonQuery()
                objConnection.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
                Me.Close()
            End Try
            Customers.txtUpdatedBy.Text = Me.txtUpdatedBy.Text
            Customers.txtUpdatedDate.Text = Me.txtUpdatedDate.Text
        End If
        Dim objCmdSU As New SqlCommand
        Try
            objCmdSU.Connection = objConnection2
            objCmdSU.CommandText = "Delete from ODS_Cards where CustomerID = '" & cardno & "'"
            objConnection2.Open()
            objCmdSU.ExecuteNonQuery()
            objConnection2.Close()
            objCmdSU.Connection = objConnection2
            objCmdSU.CommandText = "Insert into dbo.ODS_Cards Select Card_No,Card_Type,Card_Validity,Issued_On,Expiry_On,Issuing_Authority,Created_By,Created_Date,Updated_By,Updated_Date, 'U' as Op from dbo.Cards where dbo.Cards.Card_No = '" & cardno & "'"
            objConnection2.Open()
            objCmdSU.ExecuteNonQuery()
            objConnection2.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Me.Close()
        End Try

        Me.Close()
    End Sub

End Class