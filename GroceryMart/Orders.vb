Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class Orders

    Dim objConnection As New SqlConnection("Data Source=BHASWANTH-PC\SQLEXPRESS;Initial Catalog=Grocery_Mart;Integrated Security=True")
    Dim objConnection2 As New SqlConnection("Data Source=BHASWANTH-PC\SQLEXPRESS;Initial Catalog=ODS_Stage;Integrated Security=True")
    Dim objConnection3 As New SqlConnection("Data Source=BHASWANTH-PC\SQLEXPRESS;Initial Catalog=Metadata;Integrated Security=True")

    Dim uprice As Integer = 0

    Private Sub Orders_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Refresh()

        Dim objCmd1 As New SqlCommand
        Dim objCmd2 As New SqlCommand
        Dim objCmd3 As New SqlCommand

        Dim adapter1 As New SqlDataAdapter()
        Dim ds1 As New DataSet()
        Dim adapter2 As New SqlDataAdapter()
        Dim ds2 As New DataSet()
        Dim adapter3 As New SqlDataAdapter()
        Dim ds3 As New DataSet()

        Try
            objConnection.Open()

            objCmd1 = New SqlCommand("Select c.Category_Name from Category c,Inventory i,Products p where i.ProductID = p.ProductID and p.Category_Name = c.Category_Name and i.Quantity = 0", objConnection)
            adapter1.SelectCommand = objCmd1
            adapter1.Fill(ds1)
            adapter1.Dispose()
            objCmd1.Dispose()
            objConnection.Close()

            cboCName.DataSource = ds1.Tables(0)
            cboCName.ValueMember = "Category_Name"
            cboCName.DisplayMember = "Category_Name"

            objConnection.Open()
            objCmd2 = New SqlCommand("Select p.Prod_Name From Products p inner join Inventory i on p.ProductID = i.ProductID where i.Quantity = 0", objConnection)
            adapter2.SelectCommand = objCmd2
            adapter2.Fill(ds2)
            adapter2.Dispose()
            objCmd2.Dispose()
            objConnection.Close()

            cboPName.DataSource = ds2.Tables(0)
            cboPName.ValueMember = "Prod_Name"
            cboPName.DisplayMember = "Prod_Name"

            objConnection.Open()
            objCmd3 = New SqlCommand("Select Name From Suppliers", objConnection)
            adapter3.SelectCommand = objCmd3
            adapter3.Fill(ds3)
            adapter3.Dispose()
            objCmd3.Dispose()
            objConnection.Close()

            cboSName.DataSource = ds3.Tables(0)
            cboSName.ValueMember = "Name"
            cboSName.DisplayMember = "Name"

            Dim count1 As Integer
            Dim count2 As Integer
            Dim objCmd6 As SqlCommand
            Dim objCmd7 As SqlCommand
            objCmd6 = New SqlCommand("SELECT TOP 1(OrderNo) FROM Orders ORDER BY OrderNo DESC", objConnection2)
        objConnection2.Open()
        count1 = objCmd6.ExecuteScalar
            objConnection2.Close()
            If count1 <> 0 Then
                txtOrderNo.Text = count1 + 1
            Else
                objCmd7 = New SqlCommand("SELECT LOrdNo FROM Last_Ord", objConnection3)
                objConnection3.Open()
                count2 = objCmd7.ExecuteScalar
                objConnection3.Close()
                txtOrderNo.Text = count1 + 1
            End If



        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        txtProdID.Text = " "
        txtSuppID.Text = " "
        txtPayment.Text = " "
        txtOrdDate.Text = Date.Today
        txtCreatedBy.Text = MDIParent1.ToolStripStatusLabel3.Text
        txtCreatedDate.Text = Date.Today
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        End
    End Sub

    Private Sub cboPName_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboPName.SelectedIndexChanged
        Dim objCmd4 As SqlCommand
        objCmd4 = New SqlCommand("SELECT ProductID from Products where Prod_Name = '" & cboPName.Text & "'", objConnection)
        Try
            objConnection.Open()

            txtProdID.Text = objCmd4.ExecuteScalar
            objConnection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        objCmd4 = New SqlCommand("SELECT Price from Products where Prod_Name = '" & cboPName.Text & "'", objConnection)
        Try
            objConnection.Open()

            uprice = objCmd4.ExecuteScalar
            objConnection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub cboSName_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboSName.SelectedIndexChanged
        Dim objCmd5 As SqlCommand

        objCmd5 = New SqlCommand("SELECT SupplierID from Suppliers where Name = '" & cboSName.Text & "'", objConnection)

        Try
            objConnection.Open()
            txtSuppID.Text = objCmd5.ExecuteScalar
            objConnection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

 
    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        txtProdID.Text = " "
        txtSuppID.Text = " "
        txtQty.Text = " "
        txtPayment.Text = " "
        txtOrdDate.Text = " "
    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click

        If Not (txtProdID.Text.Length = 0 Or txtSuppID.Text.Length = 0 Or txtQty.Text.Length = 0 Or txtPayment.Text.Length = 0 Or
     Not IsNumeric(txtQty.Text) Or
Not IsNumeric(txtPayment.Text)) Then
            Dim objCmd8 As SqlCommand
            objCmd8 = New SqlCommand("Insert Into Orders Select OrderNo = @OrderNo, ProductID = @PID, SupplierID = @SID, Quantity = @Qty, Payment = @Payment, Ord_Date = @ODate, Created_By = @Created_By, Created_Date = @Created_Date ", objConnection2)
            objCmd8.Parameters.AddWithValue("@OrderNo", txtOrderNo.Text)
            objCmd8.Parameters.AddWithValue("@PID", txtProdID.Text)
            objCmd8.Parameters.AddWithValue("@SID", txtSuppID.Text)
            objCmd8.Parameters.AddWithValue("@Qty", txtQty.Text)
            objCmd8.Parameters.AddWithValue("@Payment", txtPayment.Text)
            objCmd8.Parameters.Add(New SqlParameter("@ODate", SqlDbType.Date)).Value = txtOrdDate.Text
            objCmd8.Parameters.AddWithValue("@Created_By", txtCreatedBy.Text)
            objCmd8.Parameters.AddWithValue("@Created_Date", Date.Today)
            Try
                objConnection2.Open()
                objCmd8.ExecuteNonQuery()
                objConnection2.Close()
                MsgBox("Order Sent.")
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

            Dim exp As String = " "
            Dim cnt1 As String = " "
            Dim cnt2 As String = " "

            Dim objCmdExp As SqlCommand
            objCmdExp = New SqlCommand("Select Exp_Period from Products where ProductID = @PrID", objConnection)
            objCmdExp.Parameters.AddWithValue("@PrID", txtProdID.Text)
            Try
                objConnection.Open()
                exp = objCmdExp.ExecuteScalar()
                objConnection.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

            Dim x As Integer
            For x = 0 To (Len(Trim(exp)) - 1)
                If IsNumeric(exp.Chars(x)) Then
                    cnt1 = cnt1 + exp.Chars(x)
                Else
                    cnt2 = exp.Chars(x + 1)
                    Exit For
                End If
            Next x

            Dim objCmdUI As SqlCommand
            Try
                objCmdUI = New SqlCommand("Update Inventory Set Quantity = @Qty, Expiry_Date = @ExpD where ProductId = @Prod_ID", objConnection)
                objCmdUI.Parameters.AddWithValue("@Qty", txtQty.Text)
                objCmdUI.Parameters.AddWithValue("@Prod_ID", txtProdID.Text)
                If cnt2 = "d" Or cnt2 = "D" Then
                    objCmdUI.Parameters.AddWithValue("@ExpD", DateAdd(DateInterval.Day, Integer.Parse(cnt1), Date.Now))
                ElseIf cnt2 = "m" Or cnt2 = "M" Then
                    objCmdUI.Parameters.AddWithValue("@ExpD", DateAdd(DateInterval.Month, Integer.Parse(cnt1), Date.Now))
                Else
                    objCmdUI.Parameters.AddWithValue("@ExpD", DateAdd(DateInterval.Year, Integer.Parse(cnt1), Date.Now))
                End If
                objConnection.Open()
                objCmdUI.ExecuteNonQuery()
                objConnection.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            End

        Else
            MessageBox.Show("Fields should not be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub txtQty_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtQty.TextChanged
        txtPayment.Text = Val(txtQty.Text) * uprice
    End Sub
End Class