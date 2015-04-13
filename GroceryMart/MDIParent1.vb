Imports System.Windows.Forms
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class MDIParent1
    Dim objConnection1 As New SqlConnection("Data Source=BHASWANTH-PC\SQLEXPRESS;Initial Catalog=ODS_Stage;Integrated Security=True")
    Dim objConnection2 As New SqlConnection("Data Source=BHASWANTH-PC\SQLEXPRESS;Initial Catalog=Grocery_Mart;Integrated Security=True")


    Private Sub MDIParent1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Hide()
        SplashScreen1.Show()
        SplashScreen1.Update()
        '5 second delay to show splash screen
        System.Threading.Thread.Sleep(5000)
        SplashScreen1.Close()
        Me.Visible = True
        ViewMenu.Enabled = False
        CustomersMenu.Enabled = False
        StoreMenu.Enabled = False
        ServicesMenu.Enabled = False
        TransactionsMenu.Enabled = False
        DWEntryMenu.Enabled = False

        LogoutMenuItem.Enabled = False
        Me.WindowState = FormWindowState.Maximized
        ToolStripStatusLabel4.Text = Date.Today
        Timer1.Start()

        Dim objCmd1 As New SqlCommand
        Try
            objCmd1.CommandText = "Update Login Set Logoff_Time = CURRENT_TIMESTAMP, Active = 'N' where Active = 'Y'"
            objCmd1.Connection = objConnection1
            objConnection1.Open()
            objCmd1.ExecuteNonQuery()
            objConnection1.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Dim objCmdCkd As New SqlCommand
        Try
            objCmdCkd.CommandText = "Update Inventory Set Quantity = 0,Expiry_Date = Null where (Expiry_Date = @ExpD Or Expiry_Date < @ExpD) And Expiry_Date != Null"
            objCmdCkd.Parameters.AddWithValue("@ExpD", Date.Today)
            objCmdCkd.Connection = objConnection2
            objConnection2.Open()
            objCmdCkd.ExecuteNonQuery()
            objConnection2.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Dim objCmdCdc As New SqlCommand
        Try
            objCmdCdc.CommandText = "Update Cards Set Card_Validity = 'No' where (Expiry_On = @Exp_D Or Expiry_On < @Exp_D) And Card_Validity != 'No'"
            objCmdCdc.Parameters.AddWithValue("@Exp_D", Date.Today)
            objCmdCdc.Connection = objConnection2
            objConnection2.Open()
            objCmdCdc.ExecuteNonQuery()
            objConnection2.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
       
    End Sub


    Private Sub ProductsMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ProductsMenuItem.Click
        Products.MdiParent = Me
        Products.Show()
    End Sub

    Private Sub SuppliersMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SuppliersMenuItem.Click
        Suppliers.MdiParent = Me
        Suppliers.Show()
    End Sub

    Private Sub OffersMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OffersMenuItem.Click
        Offers.MdiParent = Me
        Offers.Show()
    End Sub

    Private Sub LoginMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LoginMenuItem.Click
        LoginF.MdiParent = Me
        LoginF.Show()
    End Sub

    Private Sub ProfilesMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ProfilesMenuItem.Click
        Customers.MdiParent = Me
        Customers.Show()
    End Sub
    Private Sub EmployeesMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EmployeesMenuItem.Click
        Employees.MdiParent = Me
        Employees.Show()
    End Sub

    Private Sub AccountsMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AccountsMenuItem.Click
        Accounts.MdiParent = Me
        Accounts.Show()
    End Sub



    Private Sub EmplReportingMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EmplReportingMenuItem.Click
        Empl_Reporting.MdiParent = Me
        Empl_Reporting.Show()
    End Sub

    Private Sub CashierEntryMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CashierEntryMenuItem.Click
        Cashier_Entry.MdiParent = Me
        Cashier_Entry.Show()
    End Sub

    Private Sub PlaceOrderMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PlaceOrderMenuItem.Click
        Orders.MdiParent = Me
        Orders.Show()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel5.Text = TimeOfDay
    End Sub

    Private Sub ExitMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitMenuItem.Click
        Dim objCmd1 As New SqlCommand
        If Me.ToolStripStatusLabel3.Text Is Nothing Then
            End
        Else
            Try
                objCmd1.CommandText = "Update Login Set Logoff_Time = CURRENT_TIMESTAMP, Active = 'N' where Login_ID = @LoginID  And Active = 'Y'"
                objCmd1.Connection = objConnection1
                objCmd1.Parameters.AddWithValue("@LoginID", Me.ToolStripStatusLabel3.Text)
                objConnection1.Open()
                objCmd1.ExecuteNonQuery()
                objConnection1.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            End
        End If
    End Sub

    Private Sub LogoutMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LogoutMenuItem.Click

        Dim objCmd1 As New SqlCommand
        Try
            objCmd1.CommandText = "Update Login Set Logoff_Time = CURRENT_TIMESTAMP, Active = 'N' where Login_ID = @LoginID  And Active = 'Y'"
            objCmd1.Connection = objConnection1
            objCmd1.Parameters.AddWithValue("@LoginID", Me.ToolStripStatusLabel3.Text)
            objConnection1.Open()
            objCmd1.ExecuteNonQuery()
            objConnection1.Close()
            MsgBox("You have Successfully Logged Off")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


        ViewMenu.Enabled = False
        CustomersMenu.Enabled = False
        StoreMenu.Enabled = False
        ServicesMenu.Enabled = False
        TransactionsMenu.Enabled = False
        DWEntryMenu.Enabled = False
        LoginMenuItem.Enabled = True
        LogoutMenuItem.Enabled = False
    End Sub

   
    Private Sub EmpChkOutMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EmpChkOutMenuItem.Click
        Empl_Checkout.Show()
    End Sub

  

    Private Sub LoadToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LoadToolStripMenuItem.Click
        DW_Load.Show()
    End Sub

    Private Sub FileMenu_Click(sender As System.Object, e As System.EventArgs) Handles FileMenu.Click

    End Sub

    Private Sub AvailAGiftToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AvailAGiftMenuItem.Click
        Gift.Show()
    End Sub
End Class
