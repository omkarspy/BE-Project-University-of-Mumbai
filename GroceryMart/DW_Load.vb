Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class DW_Load
    Dim objConnection As New SqlConnection("Data Source=OMKAR-PC\OMKAR;Initial Catalog=Grocery_Mart;Integrated Security=True")
    Dim objConnection2 As New SqlConnection("Data Source=OMKAR-PC\OMKAR;Initial Catalog=Grocery_Mart;Integrated Security=True")
    Dim objConnection3 As New SqlConnection("Data Source=OMKAR-PC\OMKAR;Initial Catalog=Grocery_Mart;Integrated Security=True")
    Dim objConnection4 As New SqlConnection("Data Source=OMKAR-PC\OMKAR;Initial Catalog=Grocery_Mart;Integrated Security=True")
    Private Sub DW_Load_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        txtAD.Text = Date.Today
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        txtAT.Text = TimeOfDay
    End Sub
    Private Sub btnLoad_Click(sender As System.Object, e As System.EventArgs) Handles btnLoad.Click
        Dim objcmdIA As New SqlCommand
        Try

            objConnection4.Open()
            objcmdIA.Connection = objConnection4
            objcmdIA.CommandText = "Insert into Dim_Account Select Login_ID,Password,Created_By,Created_Date,Updated_By,Updated_Date,@ADate,@ATime,'V' from ODS_Stage.dbo.ODS_Account where Op = 'I'"
            objcmdIA.Parameters.AddWithValue("@ADate", Date.Today)
            objcmdIA.Parameters.AddWithValue("@ATime", DateTime.Now)
            objcmdIA.ExecuteNonQuery()
            objConnection4.Close()

            objConnection4.Open()
            objcmdIA.Connection = objConnection4
            objcmdIA.CommandText = "Insert into Dim_Account Select Login_ID,Password,Created_By,Created_Date,Updated_By,Updated_Date,@A_Date,@A_Time,'V' from dbo.ODS_Account where Op = 'U'"
            objcmdIA.Parameters.AddWithValue("@A_Date", Date.Today)
            objcmdIA.Parameters.AddWithValue("@A_Time", DateTime.Now)
            objcmdIA.ExecuteNonQuery()
            objConnection4.Close()
            objConnection4.Open()
            objcmdIA.Connection = objConnection4
            objcmdIA.CommandText = "Update a Set Status = 'IN' from Dim_Account a joiN dbo.ODS_Account b on a.Login_ID = b.Login_ID where a.Added_Date != @Add_Date"
            objcmdIA.Parameters.AddWithValue("@Add_Date", Date.Today)
            objcmdIA.ExecuteNonQuery()
            objConnection4.Close()
            objConnection4.Open()
            objcmdIA.Connection = objConnection4
            objcmdIA.CommandText = "Update Dim_Account Set Status = 'IN' from Dim_Account a join dbo.Account_Delete_Log b on a.Login_ID = b.LoginID"
            objcmdIA.ExecuteNonQuery()
            objConnection4.Close()
            objConnection2.Open()
            objcmdIA.Connection = objConnection2
            objcmdIA.CommandText = "Delete from ODS_Account"

            objcmdIA.ExecuteNonQuery()
            objConnection2.Close()
            objConnection3.Open()
            objcmdIA.Connection = objConnection3
            objcmdIA.CommandText = "Delete from Account_Delete_Log"
            objcmdIA.ExecuteNonQuery()
            objConnection3.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.Close()


        Dim objcmdL As New SqlCommand
        Try

            objConnection4.Open()
            objcmdL.Connection = objConnection4
            objcmdL.CommandText = "Insert into Login_Fact Select LNo,Login_ID,Login_Date,Login_Time,Logoff_Time,@ADate,@ATime from dbo.Login where Active = 'N'"
            objcmdL.Parameters.AddWithValue("@ADate", Date.Today)
            objcmdL.Parameters.AddWithValue("@ATime", DateTime.Now)
            objcmdL.ExecuteNonQuery()
            objConnection4.Close()
            objConnection2.Open()
            objcmdL.Connection = objConnection2
            objcmdL.CommandText = "Delete from Login"
            objcmdL.ExecuteNonQuery()
            objConnection2.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.Close()




        Dim objcmdE As New SqlCommand
        Try

            objConnection4.Open()
            objcmdE.Connection = objConnection4
            objcmdE.CommandText = "Insert into Dim_Employees Select EmployeeID,FName,LName,DOB,Gender,Hiredate,Designation,Address,PCode,Phone_no,Reports_To,Level,Created_By,Created_Date,Updated_By,Updated_Date,pic,@ADate,@ATime,'V' from dbo.ODS_Employees where Op = 'I'"
            objcmdE.Parameters.AddWithValue("@ADate", Date.Today)
            objcmdE.Parameters.AddWithValue("@ATime", DateTime.Now)
            objcmdE.ExecuteNonQuery()
            objConnection4.Close()

            objConnection4.Open()
            objcmdE.Connection = objConnection4
            objcmdE.CommandText = "Insert into Dim_Employees Select EmployeeID,FName,LName,DOB,Gender,Hiredate,Designation,Address,PCode,Phone_no,Reports_To,Level,Created_By,Created_Date,Updated_By,Updated_Date,pic,@A_Date,@A_Time,'V' from dbo.ODS_Employees where Op = 'U'"
            objcmdE.Parameters.AddWithValue("@A_Date", Date.Today)
            objcmdE.Parameters.AddWithValue("@A_Time", DateTime.Now)
            objcmdE.ExecuteNonQuery()
            objConnection4.Close()

            objConnection4.Open()
            objcmdE.Connection = objConnection4
            objcmdE.CommandText = "Update a Set Status = 'IN' from Dim_Employees a join ods_stage.dbo.ODS_Employees b on a.EmployeeID = b.EmployeeID where a.Added_Date != @Add_Date"
            objcmdE.Parameters.AddWithValue("@Add_Date", Date.Today)
            objcmdE.ExecuteNonQuery()
            objConnection4.Close()
            objConnection4.Open()

            objcmdE.Connection = objConnection4
            objcmdE.CommandText = "Update Dim_Employees Set Status = 'IN' from Dim_Employees a join dbo.Employees_Delete_Log b on a.EmployeeID = b.EmpID"
            objcmdE.ExecuteNonQuery()
            objConnection4.Close()
            objConnection2.Open()
            objcmdE.Connection = objConnection2
            objcmdE.CommandText = "Delete from ODS_Employees"
            objcmdE.ExecuteNonQuery()
            objConnection2.Close()
            objConnection3.Open()
            objcmdE.Connection = objConnection3
            objcmdE.CommandText = "Delete from Employees_Delete_Log"
            objcmdE.ExecuteNonQuery()
            objConnection3.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.Close()



        Dim objcmdC As New SqlCommand
        Try

            objConnection4.Open()
            objcmdC.Connection = objConnection4
            objcmdC.CommandText = "Insert into Dim_Customers Select CustomerID,Name,Card_Number,DOB,Gender,Category,Address,PCode,Occupation,Annual_Income,Phone_no,Mobile_no,Created_By,Created_Date,Updated_By,Updated_Date,pic,@ADate,@ATime,'V' from dbo.ODS_Customers where Op = 'I'"
            objcmdC.Parameters.AddWithValue("@ADate", Date.Today)
            objcmdC.Parameters.AddWithValue("@ATime", DateTime.Now)
            objcmdC.ExecuteNonQuery()
            objConnection4.Close()

            objConnection4.Open()
            objcmdC.Connection = objConnection4
            objcmdC.CommandText = "Insert into Dim_Customers Select CustomerID,Name,Card_Number,DOB,Gender,Category,Address,PCode,Occupation,Annual_Income,Phone_no,Mobile_no,Created_By,Created_Date,Updated_By,Updated_Date,pic,@A_Date,@A_Time,'V' from dbo.ODS_Customers where Op = 'U'"
            objcmdC.Parameters.AddWithValue("@A_Date", Date.Today)
            objcmdC.Parameters.AddWithValue("@A_Time", DateTime.Now)
            objcmdC.ExecuteNonQuery()
            objConnection4.Close()

            objConnection4.Open()
            objcmdC.Connection = objConnection4
            objcmdC.CommandText = "Update a Set Status = 'IN' from Dim_Customers a join ODS_Stage.dbo.ODS_Customers b on a.CustomerID = b.CustomerID where a.Added_Date != @Add_Date"
            objcmdC.Parameters.AddWithValue("@Add_Date", Date.Today)
            objcmdC.ExecuteNonQuery()
            objConnection4.Close()
            objConnection4.Open()

            objcmdC.Connection = objConnection4
            objcmdC.CommandText = "Update Dim_Customers Set Status = 'IN' from Dim_Customers a join dbo.Customers_Delete_Log b on a.CustomerID = b.CustID"
            objcmdC.ExecuteNonQuery()
            objConnection4.Close()
            objConnection2.Open()
            objcmdC.Connection = objConnection2
            objcmdC.CommandText = "Delete from ODS_Customers"
            objcmdC.ExecuteNonQuery()
            objConnection2.Close()
            objConnection3.Open()
            objcmdC.Connection = objConnection3
            objcmdC.CommandText = "Delete from Customers_Delete_Log"
            objcmdC.ExecuteNonQuery()
            objConnection3.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.Close()



        Dim objcmdS As New SqlCommand
        Try

            objConnection4.Open()
            objcmdS.Connection = objConnection4
            objcmdS.CommandText = "Insert into Dim_Suppliers Select SupplierID,Name,Contact_Name,Cont_Title,Address,City,Region,PCode,Phone_no,Email_id,Created_By,Created_Date,Updated_By,Updated_Date,pic,@ADate,@ATime,'V' from dbo.ODS_Suppliers where Op = 'I'"
            objcmdS.Parameters.AddWithValue("@ADate", Date.Today)
            objcmdS.Parameters.AddWithValue("@ATime", DateTime.Now)
            objcmdS.ExecuteNonQuery()
            objConnection4.Close()

            objConnection4.Open()
            objcmdS.Connection = objConnection4
            objcmdS.CommandText = "Insert into Dim_Suppliers Select SupplierID,Name,Contact_Name,Cont_Title,Address,City,Region,PCode,Phone_no,Email_id,Created_By,Created_Date,Updated_By,Updated_Date,pic,@A_Date,@A_Time,'V' from dbo.ODS_Suppliers where Op = 'U'"
            objcmdS.Parameters.AddWithValue("@A_Date", Date.Today)
            objcmdS.Parameters.AddWithValue("@A_Time", DateTime.Now)
            objcmdS.ExecuteNonQuery()
            objConnection4.Close()

            objConnection4.Open()
            objcmdS.Connection = objConnection4
            objcmdS.CommandText = "Update a Set Status = 'IN' from Dim_Suppliers a join dbo.ODS_Suppliers b on a.SupplierID = b.SupplierID where a.Added_Date != @Add_Date"
            objcmdS.Parameters.AddWithValue("@Add_Date", Date.Today)
            objcmdS.ExecuteNonQuery()
            objConnection4.Close()
            objConnection4.Open()

            objcmdS.Connection = objConnection4
            objcmdS.CommandText = "Update Dim_Suppliers Set Status = 'IN' from Dim_Suppliers a join dbo.Suppliers_Delete_Log b on a.SupplierID = b.SuppID"
            objcmdS.ExecuteNonQuery()
            objConnection4.Close()
            objConnection2.Open()
            objcmdS.Connection = objConnection2
            objcmdS.CommandText = "Delete from ODS_Suppliers"
            objcmdS.ExecuteNonQuery()
            objConnection2.Close()
            objConnection3.Open()
            objcmdS.Connection = objConnection3
            objcmdS.CommandText = "Delete from Suppliers_Delete_Log"
            objcmdS.ExecuteNonQuery()
            objConnection3.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.Close()
        Dim objcmdCD As New SqlCommand
        Try

            objConnection4.Open()
            objcmdCD.Connection = objConnection4
            objcmdCD.CommandText = "Insert into Dim_Cards Select Card_No,Card_Type,Card_Validity,Issued_On,Expiry_On,Issuing_Authority,Created_By,Created_Date,Updated_By,Updated_Date,@ADate,@ATime,'V' from dbo.ODS_Cards where Op = 'I'"
            objcmdCD.Parameters.AddWithValue("@ADate", Date.Today)
            objcmdCD.Parameters.AddWithValue("@ATime", DateTime.Now)
            objcmdCD.ExecuteNonQuery()
            objConnection4.Close()

            objConnection4.Open()
            objcmdCD.Connection = objConnection4
            objcmdCD.CommandText = "Insert into Dim_Cards Select Card_No,Card_Type,Card_Validity,Issued_On,Expiry_On,Issuing_Authority,Created_By,Created_Date,Updated_By,Updated_Date,@ADate,@ATime,'V' from dbo.ODS_Cards where Op = 'U'"
            objcmdCD.Parameters.AddWithValue("@A_Date", Date.Today)
            objcmdCD.Parameters.AddWithValue("@A_Time", DateTime.Now)
            objcmdCD.ExecuteNonQuery()
            objConnection4.Close()

            objConnection4.Open()
            objcmdCD.Connection = objConnection4
            objcmdCD.CommandText = "Update a Set Status = 'IN' from Dim_Cards a join dbo.ODS_Cards b on a.Card_No = b.Card_No where a.Added_Date != @Add_Date"
            objcmdCD.Parameters.AddWithValue("@Add_Date", Date.Today)
            objcmdCD.ExecuteNonQuery()
            objConnection4.Close()
            objConnection4.Open()

            objcmdCD.Connection = objConnection4
            objcmdCD.CommandText = "Update Dim_Cards Set Status = 'IN' from Dim_Cards a join dbo.Cards_Delete_Log b on a.Card_No = b.CardNo"
            objcmdCD.ExecuteNonQuery()
            objConnection4.Close()
            objConnection2.Open()
            objcmdCD.Connection = objConnection2
            objcmdCD.CommandText = "Delete from ODS_Cards"
            objcmdCD.ExecuteNonQuery()
            objConnection2.Close()
            objConnection3.Open()
            objcmdCD.Connection = objConnection3
            objcmdCD.CommandText = "Delete from Cards_Delete_Log"
            objcmdCD.ExecuteNonQuery()
            objConnection3.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.Close()



        Dim objcmdP As New SqlCommand
        Try

            objConnection4.Open()
            objcmdP.Connection = objConnection4
            objcmdP.CommandText = "Insert into Dim_Products Select ProductID,Prod_Name,Brand,Category_ID,Category_Name,Price,Weight,Storage_Type,Diet_Type,Exp_Period,Created_By,Created_Date,Updated_By,Updated_Date,pic,@ADate,@ATime,'V' from dbo.ODS_Products where Op = 'I'"
            objcmdP.Parameters.AddWithValue("@ADate", Date.Today)
            objcmdP.Parameters.AddWithValue("@ATime", DateTime.Now)
            objcmdP.ExecuteNonQuery()
            objConnection4.Close()

            objConnection4.Open()
            objcmdP.Connection = objConnection4
            objcmdP.CommandText = "Insert into Dim_Products Select ProductID,Prod_Name,Brand,Category_ID,Category_Name,Price,Weight,Storage_Type,Diet_Type,Exp_Period,Created_By,Created_Date,Updated_By,Updated_Date,pic,@A_Date,@A_Time,'V' from dbo.ODS_Products where Op = 'U'"
            objcmdP.Parameters.AddWithValue("@A_Date", Date.Today)
            objcmdP.Parameters.AddWithValue("@A_Time", DateTime.Now)
            objcmdP.ExecuteNonQuery()
            objConnection4.Close()

            objConnection4.Open()
            objcmdP.Connection = objConnection4
            objcmdP.CommandText = "Update a Set Status = 'IN' from Dim_Products a join dbo.ODS_Products b on a.ProductID = b.ProductID where a.Added_Date != @Add_Date"
            objcmdP.Parameters.AddWithValue("@Add_Date", Date.Today)
            objcmdP.ExecuteNonQuery()
            objConnection4.Close()

            objConnection4.Open()
            objcmdP.Connection = objConnection4
            objcmdP.CommandText = "Update Dim_Products Set Status = 'IN' from Dim_Products a join dbo.Products_Delete_Log b on a.ProductID= b.ProdID"
            objcmdP.ExecuteNonQuery()
            objConnection4.Close()

            objConnection2.Open()
            objcmdP.Connection = objConnection2
            objcmdP.CommandText = "Delete from ODS_Products"
            objcmdP.ExecuteNonQuery()
            objConnection2.Close()

            objConnection3.Open()
            objcmdP.Connection = objConnection3
            objcmdP.CommandText = "Delete from Products_Delete_Log"
            objcmdP.ExecuteNonQuery()
            objConnection3.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.Close()

        Dim objcmdO As New SqlCommand
        Try

            objConnection4.Open()
            objcmdO.Connection = objConnection4
            objcmdO.CommandText = "Insert into Dim_Offers Select Offer_No,Offer_Name,Price_Margin,Discount,Start_Date,End_Date,Created_By,Created_Date,Updated_By,Updated_Date,@ADate,@ATime,'V' from dbo.ODS_Offers where Op = 'I'"
            objcmdO.Parameters.AddWithValue("@ADate", Date.Today)
            objcmdO.Parameters.AddWithValue("@ATime", DateTime.Now)
            objcmdO.ExecuteNonQuery()
            objConnection4.Close()

            objConnection4.Open()
            objcmdO.Connection = objConnection4
            objcmdO.CommandText = "Insert into Dim_Offers Select Offer_No,Offer_Name,Price_Margin,Discount,Start_Date,End_Date,Created_By,Created_Date,Updated_By,Updated_Date,@A_Date,@A_Time,'V' from dbo.ODS_offers where Op = 'I'"
            objcmdO.Parameters.AddWithValue("@A_Date", Date.Today)
            objcmdO.Parameters.AddWithValue("@A_Time", DateTime.Now)
            objcmdO.ExecuteNonQuery()
            objConnection4.Close()

            objConnection4.Open()
            objcmdO.Connection = objConnection4
            objcmdO.CommandText = "Update b Set Status = 'IN' from Dim_Offers a join Dim_Offers b on a.Offer_No = b.Offer_No where b.Added_Date != @Add_Date"
            objcmdO.Parameters.AddWithValue("@Add_Date", Date.Today)
            objcmdO.ExecuteNonQuery()
            objConnection4.Close()

            objConnection4.Open()
            objcmdO.Connection = objConnection4
            objcmdO.CommandText = "Update Dim_Products Set Status = 'IN' from Dim_Offers a join dbo.Offers_Delete_Log b on a.Offer_No= b.OfferNo"
            objcmdO.ExecuteNonQuery()
            objConnection4.Close()

            objConnection2.Open()
            objcmdO.Connection = objConnection2
            objcmdO.CommandText = "Delete from ODS_Offers"
            objcmdO.ExecuteNonQuery()
            objConnection2.Close()

            objConnection3.Open()
            objcmdO.Connection = objConnection3
            objcmdO.CommandText = "Delete from Offers_Delete_Log"
            objcmdO.ExecuteNonQuery()
            objConnection3.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.Close()


        Dim objcmdSF As New SqlCommand
        Try

            objConnection4.Open()
            objcmdSF.Connection = objConnection4
            objcmdSF.CommandText = "Insert into Sales_Fact Select *,@ADate,@ATime from dbo.ODS_Sales"
            objcmdSF.Parameters.AddWithValue("@ADate", Date.Today)
            objcmdSF.Parameters.AddWithValue("@ATime", DateTime.Now)
            objcmdSF.ExecuteNonQuery()
            objConnection4.Close()
            objConnection2.Open()
            objcmdSF.Connection = objConnection2
            objcmdSF.CommandText = "Delete from ODS_Sales"
            objcmdSF.ExecuteNonQuery()
            objConnection2.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.Close()




        Dim objcmdB As New SqlCommand
        Try

            objConnection4.Open()
            objcmdB.Connection = objConnection4
            objcmdB.CommandText = "Insert into Bill_Fact Select *,@ADate,@ATime from dbo.ODS_Bill"
            objcmdB.Parameters.AddWithValue("@ADate", Date.Today)
            objcmdB.Parameters.AddWithValue("@ATime", DateTime.Now)
            objcmdB.ExecuteNonQuery()
            objConnection4.Close()
            objConnection2.Open()
            objcmdB.Connection = objConnection2
            objcmdB.CommandText = "Delete from ODS_Bill"
            objcmdB.ExecuteNonQuery()
            objConnection2.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.Close()


        Dim objcmdCF As New SqlCommand
        Try

            objConnection4.Open()
            objcmdCF.Connection = objConnection4
            objcmdCF.CommandText = "Insert into Credits_Fact Select *,@ADate,@ATime from dbo.ODS_Credits"
            objcmdCF.Parameters.AddWithValue("@ADate", Date.Today)
            objcmdCF.Parameters.AddWithValue("@ATime", DateTime.Now)
            objcmdCF.ExecuteNonQuery()
            objConnection4.Close()
            objConnection2.Open()
            objcmdCF.Connection = objConnection2
            objcmdCF.CommandText = "Delete from ODS_Credits"
            objcmdCF.ExecuteNonQuery()
            objConnection2.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.Close()



        Dim objcmdOF As New SqlCommand
        Try

            objConnection4.Open()
            objcmdOF.Connection = objConnection4
            objcmdOF.CommandText = "Insert into Orders_Fact Select *,@ADate,@ATime from dbo.Orders"
            objcmdOF.Parameters.AddWithValue("@ADate", Date.Today)
            objcmdOF.Parameters.AddWithValue("@ATime", DateTime.Now)
            objcmdOF.ExecuteNonQuery()
            objConnection4.Close()
            objConnection2.Open()
            objcmdOF.Connection = objConnection2
            objcmdOF.CommandText = "Delete from Orders"
            objcmdOF.ExecuteNonQuery()
            objConnection2.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.Close()

        Dim objcmdER As New SqlCommand
        Try

            objConnection4.Open()
            objcmdER.Connection = objConnection4
            objcmdER.CommandText = "Insert into EmpRep_Fact Select EmpID, Report_Time, Leaving_Time, Created_By, Created_Date,@ADate,@ATime from dbo.Emp_Reporting"
            objcmdER.Parameters.AddWithValue("@ADate", Date.Today)
            objcmdER.Parameters.AddWithValue("@ATime", DateTime.Now)
            objcmdER.ExecuteNonQuery()
            objConnection4.Close()
            objConnection2.Open()
            objcmdER.Connection = objConnection2
            objcmdER.CommandText = "Delete from Emp_Reporting"
            objcmdER.ExecuteNonQuery()
            objConnection2.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.Close()


    End Sub
End Class

