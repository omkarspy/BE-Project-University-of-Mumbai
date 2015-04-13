Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class Accounts
    Dim objConnection As New SqlConnection("Data Source=OMKAR-PC\OMKAR;Initial Catalog=Grocery_Mart;Integrated Security=True")
    Dim objConnection2 As New SqlConnection("Data Source=OMKAR-PC\OMKAR;Initial Catalog=Grocery_Mart;Integrated Security=True")
    Dim objConnection3 As New SqlConnection("Data Source=OMKAR-PC\OMKAR;Initial Catalog=Grocery_Mart;Integrated Security=True")

    Private Sub Accounts_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        btnAddNew.Focus()
        txtSetPassw.Visible = False
        txtConfirmPassw.Visible = False
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        cboLoginID.Visible = False
    End Sub

    Private Sub btnAddNew_Click(sender As System.Object, e As System.EventArgs) Handles btnAddNew.Click
        Me.Refresh()
        cboLoginID.Visible = True
        cboLoginID.Enabled = True
        btnAddNew.Visible = False
        btnAdd.Visible = True
        btnCancel.Visible = True
        btnClear.Visible = True
        btnChangePassw.Enabled = False
        btnRemove.Enabled = False
        txtSetPassw.Visible = True
        txtConfirmPassw.Visible = True
        Label1.Visible = True
        Label2.Visible = True
        Label3.Visible = True


        Dim objCmd1 As New SqlCommand


        Dim adapter As New SqlDataAdapter()
        Dim ds As New DataSet()
        Dim i As Integer = 0

        Try
            objConnection.Open()
            objCmd1 = New SqlCommand("Select EmployeeID From Employees where EmployeeID Not In (Select Login_ID from Account) and Level != 'L4'", objConnection)
            adapter.SelectCommand = objCmd1
            adapter.Fill(ds)
            adapter.Dispose()
            objCmd1.Dispose()
            objConnection.Close()

            cboLoginID.DataSource = ds.Tables(0)
            cboLoginID.ValueMember = "EmployeeID"
            cboLoginID.DisplayMember = "EmployeeID"
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click

        If (txtSetPassw.Text <> txtConfirmPassw.Text Or txtSetPassw.Text = " " Or txtConfirmPassw.Text = " ") Then
            MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSetPassw.Text = " "
            txtSetPassw.Text = " "
        Else
            Dim objCmd2 As New SqlCommand
            Dim loginid As String = cboLoginID.Text

            Try
                objConnection.Open()

                objCmd2.Connection = objConnection
                objCmd2.CommandText = "Insert into Account Select @LoginID,@Password,@Created_By,@Created_Date,Null,Null"
                objCmd2.Parameters.AddWithValue("@LoginID", cboLoginID.Text)
                objCmd2.Parameters.AddWithValue("@Password", txtConfirmPassw.Text)
                objCmd2.Parameters.AddWithValue("@Created_By", MDIParent1.ToolStripStatusLabel3.Text)
                objCmd2.Parameters.AddWithValue("@Created_Date", Date.Today)

                objCmd2.ExecuteNonQuery()


                objConnection.Close()


                MsgBox("You have Successfully Added the Record")
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

            Dim objCmdSI As New SqlCommand
            Try
                objCmdSI.Connection = objConnection2
                objCmdSI.CommandText = "Insert into dbo.ODS_Account Select *, 'I' as Op from dbo.Account where dbo.Account.Login_ID = '" & loginid & "'"
                objConnection2.Open()
                objCmdSI.ExecuteNonQuery()
                objConnection2.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
                Me.Close()
            End Try

            txtSetPassw.Text = " "
            txtConfirmPassw.Text = " "
            cboLoginID.Visible = False
            cboLoginID.Enabled = False
            btnAddNew.Visible = True
            btnAdd.Visible = False
            btnCancel.Visible = False
            btnClear.Visible = False
            btnChangePassw.Enabled = True
            btnRemove.Enabled = True
            txtSetPassw.Visible = False
            txtConfirmPassw.Visible = False
            Label1.Visible = False
            Label2.Visible = False
            Label3.Visible = False
        End If
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        txtSetPassw.Text = vbEmpty
        txtConfirmPassw.Text = vbEmpty
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click

        cboLoginID.Visible = False
        cboLoginID.Enabled = False
        btnAddNew.Visible = True
        btnAdd.Visible = False
        btnCancel.Visible = False
        btnClear.Visible = False
        btnChangePassw.Enabled = True
        btnRemove.Enabled = True
        txtSetPassw.Visible = False
        txtConfirmPassw.Visible = False
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        txtSetPassw.Text = " "
        txtConfirmPassw.Text = " "

    End Sub

    Private Sub btnChangePassw_Click(sender As System.Object, e As System.EventArgs) Handles btnChangePassw.Click

        Dim objCmd3 As New SqlCommand

        Dim adapter As New SqlDataAdapter()
        Dim ds As New DataSet()
        Dim i As Integer = 0

        Try
            objConnection.Open()
            objCmd3 = New SqlCommand("Select Login_ID From Account", objConnection)
            adapter.SelectCommand = objCmd3
            adapter.Fill(ds)
            adapter.Dispose()
            objCmd3.Dispose()
            objConnection.Close()

            cboLoginID.DataSource = ds.Tables(0)
            cboLoginID.ValueMember = "Login_ID"
            cboLoginID.DisplayMember = "Login_ID"
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        cboLoginID.Visible = True
        cboLoginID.Enabled = True
        btnAddNew.Enabled = False
        btnAdd.Visible = False
        btnCancel.Visible = True
        btnClear.Visible = True
        btnChangePassw.Visible = False
        btnRemove.Enabled = False
        txtSetPassw.Visible = True
        txtConfirmPassw.Visible = True
        Label1.Visible = True
        Label2.Visible = True
        Label3.Visible = True

    End Sub

    Private Sub btnSaveChanges_Click(sender As System.Object, e As System.EventArgs) Handles btnSaveChanges.Click
        If (txtSetPassw.Text <> txtConfirmPassw.Text Or txtSetPassw.Text = " " Or txtConfirmPassw.Text = " ") Then
            MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSetPassw.Text = " "
            txtSetPassw.Text = " "
        Else

            Dim objCmd4 As New SqlCommand
            Dim loginid As String = cboLoginID.Text
            Try
                objConnection.Open()

                objCmd4.Connection = objConnection
                objCmd4.CommandText = "Update Account Set Password = @Password, Updated_By = @Updated_By, Updated_Date = @Updated_Date where Login_ID =  @LoginID"
                objCmd4.Parameters.AddWithValue("@LoginID", cboLoginID.Text)
                objCmd4.Parameters.AddWithValue("@Password", txtConfirmPassw.Text)
                objCmd4.Parameters.AddWithValue("@Updated_By", MDIParent1.ToolStripStatusLabel3.Text)
                objCmd4.Parameters.AddWithValue("@Updated_Date", Date.Today)

                objCmd4.ExecuteNonQuery()


                objConnection.Close()


                MsgBox("You have Successfully Changed the Password")
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

            Dim objCmdSU As New SqlCommand
            Try
                objCmdSU.Connection = objConnection2
                objCmdSU.CommandText = "Delete from ODS_Account where Login_ID = '" & loginid & "'"
                objConnection2.Open()
                objCmdSU.ExecuteNonQuery()
                objConnection2.Close()
                objCmdSU.CommandText = "Insert into dbo.ODS_Account Select *, 'U' as Op from dbo.Account where dbo.Account.Login_ID = '" & loginid & "'"
                objConnection2.Open()
                objCmdSU.ExecuteNonQuery()
                objConnection2.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
                Me.Close()
            End Try

            txtSetPassw.Text = " "
            txtConfirmPassw.Text = " "
            cboLoginID.Visible = False
            cboLoginID.Enabled = False
            btnAddNew.Visible = True
            btnAddNew.Enabled = True
            btnCancel.Visible = False
            btnClear.Visible = False
            btnChangePassw.Enabled = True
            btnChangePassw.Visible = True
            btnRemove.Enabled = True
            txtSetPassw.Visible = False
            txtConfirmPassw.Visible = False
            Label1.Visible = False
            Label2.Visible = False
            Label3.Visible = False
        End If
    End Sub

    Private Sub btnRemove_Click(sender As System.Object, e As System.EventArgs) Handles btnRemove.Click
        Dim objCmd5 As New SqlCommand


        Dim adapter As New SqlDataAdapter()
        Dim ds As New DataSet()
        Dim i As Integer = 0

        Try
            objConnection.Open()
            objCmd5 = New SqlCommand("Select Login_ID From Account", objConnection)
            adapter.SelectCommand = objCmd5
            adapter.Fill(ds)
            adapter.Dispose()
            objCmd5.Dispose()
            objConnection.Close()

            cboLoginID.DataSource = ds.Tables(0)
            cboLoginID.ValueMember = "Login_ID"
            cboLoginID.DisplayMember = "Login_ID"
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        cboLoginID.Visible = True
        cboLoginID.Enabled = True
        btnAddNew.Enabled = False
        btnChangePassw.Enabled = False
        btnRemove.Visible = False
        Label1.Visible = True

    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        Dim objCmd6 As New SqlCommand
        Dim loginid As String = cboLoginID.Text

        Try
            objConnection.Open()

            objCmd6.Connection = objConnection
            objCmd6.CommandText = "Delete from Account where Login_ID =  @LoginID"
            objCmd6.Parameters.AddWithValue("@LoginID", cboLoginID.Text)
          

            objCmd6.ExecuteNonQuery()


            objConnection.Close()


            MsgBox("You have Successfully Deleted the Record")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Dim objCmdSD As New SqlCommand
        Try
            objCmdSD.Connection = objConnection3
            objCmdSD.CommandText = "Insert into Account_Delete_Log Select count(SrNo) +1, '" & loginid & "' from Account_Delete_Log"
            objConnection3.Open()
            objCmdSD.ExecuteNonQuery()
            objConnection3.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Me.Close()
        End Try
        cboLoginID.Visible = False
        cboLoginID.Enabled = False
        btnAddNew.Enabled = True
        btnChangePassw.Enabled = True
        btnRemove.Visible = True
        Label1.Visible = False
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class