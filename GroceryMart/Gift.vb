Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class Gift

    Dim objConnection As New SqlConnection("Data Source=BHASWANTH-PC\SQLEXPRESS;Initial Catalog=Grocery_Mart;Integrated Security=True")

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub Gift_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Refresh()

        Dim objCmd1 As New SqlCommand
        Dim adapter1 As New SqlDataAdapter()
        Dim ds1 As New DataSet()

        Try
            objConnection.Open()

            objCmd1 = New SqlCommand("Select c1.CustomerID from Customers c1,Cards c2 where c1.Card_Number = c2.Card_No and c2.Credits >= 1000", objConnection)
            adapter1.SelectCommand = objCmd1
            adapter1.Fill(ds1)
            adapter1.Dispose()
            objCmd1.Dispose()
            objConnection.Close()
            cboCustID.DataSource = ds1.Tables(0)
            cboCustID.ValueMember = "CustomerID"
            cboCustID.DisplayMember = "CustomerID"
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        txtCardNo.Text = " "
        txtCredits.Text = " "
    End Sub

    Private Sub btnSubmit_Click(sender As System.Object, e As System.EventArgs) Handles btnSubmit.Click
        Dim credits As Integer
        credits = Val(txtCredits.Text) - 1000
        Try
            Dim objCmd3 As SqlCommand
            objCmd3 = New SqlCommand("Update Cards Set Credits = @credits where Card_No =  @Card_NO", objConnection)
            objCmd3.Parameters.AddWithValue("@Credits", credits)
            objCmd3.Parameters.AddWithValue("@Card_No", txtCardNo.Text)
            objConnection.Open()
            txtCardNo.Text = objCmd3.ExecuteScalar
            objConnection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.Close()
    End Sub

    Private Sub cboCustID_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboCustID.SelectedIndexChanged
        Try
            Dim objCmd2 As SqlCommand
            objCmd2 = New SqlCommand("SELECT Card_Number from Customers where CustomerID = @CustID", objConnection)
            objCmd2.Parameters.AddWithValue("@CustID", cboCustID.Text)
            objConnection.Open()
            txtCardNo.Text = objCmd2.ExecuteScalar
            objConnection.Close()
            objCmd2 = New SqlCommand("SELECT Credits from Cards where Card_No = @CardNo", objConnection)
            objCmd2.Parameters.AddWithValue("@CardNo", txtCardNo.Text)
            objConnection.Open()
            txtCredits.Text = objCmd2.ExecuteScalar
            objConnection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class