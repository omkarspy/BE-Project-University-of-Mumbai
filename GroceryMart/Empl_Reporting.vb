

Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class Empl_Reporting
    Dim objConnection As New SqlConnection("Data Source=OMKAR-PC\OMKAR;Initial Catalog=Grocery_Mart;Integrated Security=True")
    Dim objConnection2 As New SqlConnection("Data Source=OMKAR-PC\OMKAR;Initial Catalog=Grocery_Mart;Integrated Security=True")
    


    Private Sub Empl_Reporting_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Me.Refresh()

        Dim objCmd1 As New SqlCommand
        Dim objCmd2 As New SqlCommand


        Dim adapter As New SqlDataAdapter()
        Dim ds As New DataSet()
        Dim i As Integer = 0

        Try
            objConnection.Open()
            objCmd1 = New SqlCommand("Select EmployeeID from Employees where EmployeeID Not In (Select EmpID From dbo.Emp_Reporting)", objConnection)
            adapter.SelectCommand = objCmd1
            adapter.Fill(ds)
            adapter.Dispose()
            objCmd1.Dispose()
            objConnection.Close()

            cboEmpID.DataSource = ds.Tables(0)
            cboEmpID.ValueMember = "EmployeeID"
            cboEmpID.DisplayMember = "EmployeeID"

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        cboEmpID.Text = " "
        txtName.Text = " "
        txtRTime.Text = " "
        txtCreatedBy.Text = " "
        txtCreatedDate.Text = " "

    End Sub

    Private Sub cboEmpID_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboEmpID.SelectedIndexChanged


        Try
            Dim objCmd2 As New SqlCommand

            Dim Ename As String
            objCmd2 = New SqlCommand("Select FName + ' ' + LName  from Employees where EmployeeID = @EmpID", objConnection)
            objCmd2.Parameters.AddWithValue("@EmpID", cboEmpID.Text)
            objConnection.Open()
            Ename = objCmd2.ExecuteScalar
            txtName.Text = Ename
            objConnection.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        txtRTime.Text = TimeOfDay
        txtCreatedBy.Text = MDIParent1.ToolStripStatusLabel3.Text
        txtCreatedDate.Text = DateTime.Now

    End Sub

 
    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnSubmit_Click(sender As System.Object, e As System.EventArgs) Handles btnSubmit.Click
        Try
            Dim objCmd3 As New SqlCommand


            objCmd3 = New SqlCommand("Insert Into Emp_Reporting Select @EmpID,@RTime,Null,'A',@CreatedBy,@CreatedDate", objConnection2)
            objCmd3.Parameters.AddWithValue("@EmpID", cboEmpID.Text)
            objCmd3.Parameters.AddWithValue("@RTime", DateTime.Now)
            objCmd3.Parameters.AddWithValue("@CreatedBy", txtCreatedBy.Text)
            objCmd3.Parameters.AddWithValue("@CreatedDate", Date.Today)

            objConnection2.Open()
            objCmd3.ExecuteNonQuery()
            objConnection2.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Me.Close()
    End Sub
End Class