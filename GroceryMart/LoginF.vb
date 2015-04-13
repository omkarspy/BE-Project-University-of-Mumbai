

Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class LoginF
    Dim objConnection As New SqlConnection("Data Source=BHASWANTH-PC\SQLEXPRESS;Initial Catalog=Grocery_Mart;Integrated Security=True")
    Dim objConnection2 As New SqlConnection("Data Source=BHASWANTH-PC\SQLEXPRESS;Initial Catalog=ODS_Stage;Integrated Security=True")

    Dim objDataAdapter As New SqlDataAdapter()
    Dim objDataSet As DataSet
    Dim objDataView As DataView
    Dim objCurrencyManager As CurrencyManager
    Private Sub FillDataSetAndView()
        ' Initialize a new instance of the DataSet object..
        objDataSet = New DataSet()
        ' Fill the DataSet object with data..
        objDataAdapter.Fill(objDataSet, "Account")
        ' Set the DataView object to the DataSet object..
        objDataView = New DataView(objDataSet.Tables("Account"))

        objCurrencyManager = CType(Me.BindingContext(objDataView), CurrencyManager)
    End Sub
    Private Sub Login_Load(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Cancel_Click(sender As System.Object, e As System.EventArgs) Handles Cancel.Click
        Me.Close()

    End Sub

    Private Sub OK_Click(sender As System.Object, e As System.EventArgs) Handles OK.Click
        Dim objCmd1 As New SqlCommand
        Dim objCmd2 As New SqlCommand
        Dim objCmd3 As New SqlCommand
        Dim objCmd4 As New SqlCommand

        Dim loginid As String = txtLoginID.Text
        Try



            objCmd1.Connection = objConnection
            objCmd1.CommandText = "Select count(*) from Account where Login_ID = @LoginID and Password = @Password"
            objCmd1.Parameters.AddWithValue("@LoginID", txtLoginID.Text)
            objCmd1.Parameters.AddWithValue("@Password", txtPassword.Text)


            Dim count As Integer
            objConnection.Open()
            count = objCmd1.ExecuteScalar()
            objConnection.Close()
            If (count = 0) Then
                MessageBox.Show("Enter correct LoginID and Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else

                objCmd2.CommandText = "Select count(*) from Login"
                objCmd2.Connection = objConnection2
                Dim count2 As Integer
                objConnection2.Open()
                count2 = objCmd2.ExecuteScalar()
                objConnection2.Close()
                count2 = count2 + 1

                objCmd3.CommandText = "Insert into Login Select @Lno,@LoginID,@LDate,@LoginTime,Null,'Y'"
                objCmd3.Connection = objConnection2
                objCmd3.Parameters.AddWithValue("@LNo", count2)
                objCmd3.Parameters.AddWithValue("@LoginID", txtLoginID.Text)
                objCmd3.Parameters.AddWithValue("@LDate", Date.Today)
                objCmd3.Parameters.AddWithValue("@LoginTime", DateTime.Now)


                objConnection2.Open()
                objCmd3.ExecuteNonQuery()
                objConnection2.Close()


                MsgBox("You have Successfully Logged In")
                Dim desg As String
                objCmd4.CommandText = "Select Designation from Employees where EmployeeID = @EID"
                objCmd4.Connection = objConnection
                objCmd4.Parameters.AddWithValue("@EID", txtLoginID.Text)
                objConnection.Open()
                desg = objCmd4.ExecuteScalar()
                objConnection.Close()
                MDIParent1.ToolStripStatusLabel3.Text = loginid
                If desg = "ADMIN" Then
                    MDIParent1.ViewMenu.Enabled = True
                    MDIParent1.CustomersMenu.Enabled = True
                    MDIParent1.StoreMenu.Enabled = True
                    MDIParent1.ServicesMenu.Enabled = True
                    MDIParent1.TransactionsMenu.Enabled = True
                    MDIParent1.DWEntryMenu.Enabled = True
                ElseIf desg = "Store Manager" Or desg = "Asst. Manager" Or desg = "Data Analyst" Then
                    MDIParent1.ViewMenu.Enabled = True
                    MDIParent1.CustomersMenu.Enabled = True
                    MDIParent1.StoreMenu.Enabled = True
                    MDIParent1.ServicesMenu.Enabled = True
                    MDIParent1.TransactionsMenu.Enabled = True
                Else
                    MDIParent1.TransactionsMenu.Enabled = True
                    MDIParent1.PlaceOrderMenuItem.Enabled = False

                End If

                MDIParent1.LogoutMenuItem.Enabled = True
                MDIParent1.LoginMenuItem.Enabled = False
                Me.Close()
                End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Private Sub LoginF_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
