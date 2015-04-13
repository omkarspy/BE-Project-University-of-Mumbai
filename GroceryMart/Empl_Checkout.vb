
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class Empl_Checkout
    Dim objConnection As New SqlConnection("Data Source=OMKAR-PC\OMKAR;Initial Catalog=Grocery_Mart;Integrated Security=True")
    Dim objConnection2 As New SqlConnection("Data Source=OMKAR-PC\OMKAR;Initial Catalog=Grocery_Mart;Integrated Security=True")
    Private Sub Empl_Checkout_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Refresh()

        Dim objCmd1 As New SqlCommand
        Dim objCmd2 As New SqlCommand


        Dim adapter As New SqlDataAdapter()
        Dim ds As New DataSet()
        Dim i As Integer = 0

        Try
            objConnection.Open()
            objCmd1 = New SqlCommand("Select EmpID from Emp_Reporting where Status = 'A'", objConnection)
            adapter.SelectCommand = objCmd1
            adapter.Fill(ds)
            adapter.Dispose()
            objCmd1.Dispose()
            objConnection.Close()

            cboEmpID.DataSource = ds.Tables(0)
            cboEmpID.ValueMember = "EmpID"
            cboEmpID.DisplayMember = "EmpID"

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        txtName.Text = " "
        txtCTime.Text = " "
    End Sub

    Private Sub cboEmpID_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboEmpID.SelectedIndexChanged
        Try
            Dim objCmd2 As New SqlCommand

            Dim Ename As String
            objCmd2 = New SqlCommand("Select FName + ' ' + LName  from Employees where EmployeeID = @EmpID", objConnection2)
            objCmd2.Parameters.AddWithValue("@EmpID", cboEmpID.Text)
            objConnection2.Open()
            Ename = objCmd2.ExecuteScalar
            txtName.Text = Ename
            objConnection2.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        txtCTime.Text = TimeOfDay
    End Sub

    Private Sub btnSubmit_Click(sender As System.Object, e As System.EventArgs) Handles btnSubmit.Click
        Try
            Dim objCmd3 As New SqlCommand


            objCmd3 = New SqlCommand("Update Emp_Reporting Set Leaving_Time = @CTime, Status = 'IA' where EmpID = @EmpID", objConnection)
            objCmd3.Parameters.AddWithValue("@EmpID", cboEmpID.Text)
            objCmd3.Parameters.AddWithValue("@CTime", DateTime.Now)
        
            objConnection.Open()
            objCmd3.ExecuteNonQuery()
            objConnection.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.Close()
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class