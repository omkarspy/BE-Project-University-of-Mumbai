Imports System.Data
Imports System.Data.SqlClient
Imports System.IO


Public Class Cashier_Entry

    Dim objConnection As New SqlConnection("Data Source=OMKAR-PC\OMKAR;Initial Catalog=Grocery_Mart;Integrated Security=True")
    Dim objConnection2 As New SqlConnection("Data Source=OMKAR-PC\OMKAR;Initial Catalog=Grocery_Mart;Integrated Security=True")
    Dim objConnection3 As New SqlConnection("Data Source=OMKAR-PC\OMKAR;Initial Catalog=Grocery_Mart;Integrated Security=True")
    Dim rowcellval As String
    Dim cardtype As String = " "

    Private Sub Cashier_Entry_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Refresh()
      
        Me.MaximizeBox = False

        Dim objCmd1 As New SqlCommand
        Dim objCmd2 As New SqlCommand
        Dim objCmdLT As New SqlCommand
        Dim trno As Integer
        Dim adapter1 As New SqlDataAdapter()
        Dim ds1 As New DataSet()

        Try
            objConnection.Open()

            objCmd1 = New SqlCommand("Select Category_Name From Category", objConnection)
            adapter1.SelectCommand = objCmd1
            adapter1.Fill(ds1)
            adapter1.Dispose()
            objCmd1.Dispose()
            objConnection.Close()
            cboCName.DataSource = ds1.Tables(0)
            cboCName.ValueMember = "Category_Name"
            cboCName.DisplayMember = "Category_Name"

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Try

            objConnection.Open()
            objCmd2 = New SqlCommand("Delete from Temp_Sales", objConnection)
            objCmd2.ExecuteNonQuery()
            objConnection.Close()

            objConnection.Open()
            objCmd2 = New SqlCommand("Delete from Temp_Inventory", objConnection)
            objCmd2.ExecuteNonQuery()
            objConnection.Close()

            objConnection.Open()
            objCmd2 = New SqlCommand("Insert Into Temp_Inventory Select * from Inventory", objConnection)
            objCmd2.ExecuteNonQuery()
            objConnection.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Try
            objCmdLT = New SqlCommand("Select LTrnNo From Last_Trn", objConnection3)
            objConnection3.Open()
            trno = objCmdLT.ExecuteScalar
            objConnection3.Close()

            txtTRNo.Text = trno + 1
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        txtCID.Text = MDIParent1.ToolStripStatusLabel3.Text

        rdNo.Checked = True
        cboCardNo.Enabled = False


        DataGridView1.ColumnCount = 5
        DataGridView1.Columns(0).Name = "Product ID"
        DataGridView1.Columns(1).Name = "Product Name"
        DataGridView1.Columns(2).Name = "Unit Price"
        DataGridView1.Columns(3).Name = "Qty"
        DataGridView1.Columns(4).Name = "Total Price"

        txtTD.Text = Date.Today
        Timer1.Start()
     
    End Sub

    Private Sub cboCName_Click(sender As Object, e As System.EventArgs) Handles cboCName.Click
        cboPName.Enabled = True
    End Sub

    Private Sub cboCName_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboCName.SelectedIndexChanged



        Dim objCmd3 As SqlCommand

        Dim adapter2 As New SqlDataAdapter()
        Dim ds2 As New DataSet()

        Try
          
            objCmd3 = New SqlCommand("SELECT p.Prod_Name FROM Products AS p INNER JOIN Temp_Inventory AS i ON p.ProductID = i.ProductID where i.Quantity>0 and p.Category_Name = @CName", objConnection)
            objCmd3.Parameters.AddWithValue("@CName", cboCName.Text)
            objConnection.Open()
            adapter2.SelectCommand = objCmd3
            adapter2.Fill(ds2)
            adapter2.Dispose()
            objCmd3.Dispose()
            objConnection.Close()

            cboPName.DataSource = ds2.Tables(0)
            cboPName.ValueMember = "Prod_Name"
            cboPName.DisplayMember = "Prod_Name"

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        txtProdID.Text = " "
        txtUPrice.Text = " "
    End Sub

    Private Sub cboPName_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboPName.SelectedIndexChanged

        Try

            Dim objCmd7 As SqlCommand

            objCmd7 = New SqlCommand("SELECT ProductID, Price from Products where Prod_Name = '" & cboPName.Text & "'", objConnection)

            objConnection.Open()
            Dim objReader As SqlDataReader = objCmd7.ExecuteReader

            objReader.Read()

            txtProdID.Text = objReader("ProductID")
            txtUPrice.Text = objReader("Price")
            objReader.Close()
            objConnection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub

    

    Private Sub rdYes_Click(sender As Object, e As System.EventArgs) Handles rdYes.Click
        cboCardNo.Enabled = True

        Dim objCmd5 As SqlCommand


        Dim adapter3 As New SqlDataAdapter()
        Dim ds3 As New DataSet()

        Try
            objCmd5 = New SqlCommand("SELECT Card_Number from Customers where Card_Number != ' ' or Card_Number != Null ", objConnection)
            objConnection.Open()
            adapter3.SelectCommand = objCmd5
            adapter3.Fill(ds3)
            adapter3.Dispose()
            objCmd5.Dispose()
            objConnection.Close()

            cboCardNo.DataSource = ds3.Tables(0)
            cboCardNo.ValueMember = "Card_Number"
            cboCardNo.DisplayMember = "Card_Number"

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        txtCustomerID.Text = " "
    End Sub

    Private Sub rdNo_Click(sender As Object, e As System.EventArgs) Handles rdNo.Click
        cboCardNo.Enabled = False
    End Sub

    Private Sub cboCardNo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboCardNo.SelectedIndexChanged
        Dim objCmd6 As SqlCommand
        objCmd6 = New SqlCommand("SELECT CustomerID from Customers where Card_Number = '" & cboCardNo.Text & "'", objConnection)
        Try

            objConnection.Open()
            txtCustomerID.Text = objCmd6.ExecuteScalar
            objConnection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Dim objCmdCT As SqlCommand
        objCmdCT = New SqlCommand("SELECT Card_Type from Cards where Card_No = '" & cboCardNo.Text & "'", objConnection)
        Try

            objConnection.Open()
            cardtype = objCmdCT.ExecuteScalar
            objConnection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Dim objCmdCC As SqlCommand
        objCmdCC = New SqlCommand("SELECT Credits from Cards where Card_No = '" & cboCardNo.Text & "'", objConnection)
        Try
            objConnection.Open()
            txtCredits.Text = objCmdCC.ExecuteScalar
            objConnection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub



    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click

        Dim tprice As Integer
        tprice = Integer.Parse(txtQty.Text) * Integer.Parse(txtUPrice.Text)
        Dim row As String() = New String() {txtProdID.Text, cboPName.Text, txtUPrice.Text, txtQty.Text, tprice.ToString}
        DataGridView1.Rows.Add(row)


        DataGridView1.Rows(1).ReadOnly = True


        Dim objCmd8 As New SqlCommand
        Try
            objConnection.Open()
            objCmd8.Connection = objConnection
            objCmd8.CommandText = "Insert into Temp_Sales Select @ProdID,@PName,@UPrice,@Qty,@TPrice"
            objCmd8.Parameters.AddWithValue("@ProdID", txtProdID.Text)
            objCmd8.Parameters.AddWithValue("@PName", cboPName.Text)
            objCmd8.Parameters.AddWithValue("@UPrice", txtUPrice.Text)
            objCmd8.Parameters.AddWithValue("@Qty", txtQty.Text)
            objCmd8.Parameters.AddWithValue("@Tprice", tprice)
            objCmd8.ExecuteNonQuery()

            objConnection.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Try
            objConnection.Open()
            objCmd8.Connection = objConnection
            objCmd8.CommandText = "Update Temp_Inventory set Quantity = (select i.Quantity - t.Quantity from Temp_Inventory i inner join Temp_Sales t on i.ProductID = t.Prod_ID where t.Prod_ID = @Prod_ID) where ProductID = @Prod_ID"
            objCmd8.Parameters.AddWithValue("@Prod_ID", txtProdID.Text)
            objCmd8.ExecuteNonQuery()
            objConnection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        txtTotalNo.Text = Val(txtTotalNo.Text) + Val(txtQty.Text)
        txtTPrice.Text = Double.Parse(txtTPrice.Text) + Double.Parse(txtUPrice.Text) * Val(txtQty.Text)

        txtQty.Text = 0
        btnAdd.Enabled = False
    End Sub


    Private Sub DataGridView1_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        rowcellval = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString()
    End Sub
    Private Sub DataGridView1_UserDeletingRow(sender As Object, e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles DataGridView1.UserDeletingRow
        If (Not e.Row.IsNewRow) Then
            Dim response As DialogResult = MessageBox.Show("Are you sure you want to delete this row?", "Delete row?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If (response = DialogResult.No) Then
                e.Cancel = True
            End If
            If (response = DialogResult.Yes) Then
                Dim objCmd9 As SqlCommand

                Try

                    objConnection.Open()
                    objCmd9 = New SqlCommand("Delete from Temp_Sales where Prod_ID = '" & rowcellval & "'", objConnection)
                    objCmd9.ExecuteNonQuery()
                    objConnection.Close()

                    objConnection.Open()
                    objCmd9 = New SqlCommand("Delete from Temp_Inventory where ProductID = '" & rowcellval & "'", objConnection)
                    objCmd9.ExecuteNonQuery()
                    objConnection.Close()

                    objConnection.Open()
                    objCmd9 = New SqlCommand("Insert into Temp_Inventory Select * from Inventory where ProductID = '" & rowcellval & "'", objConnection)
                    objCmd9.ExecuteNonQuery()
                    objConnection.Close()

                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try

            End If
        End If
    End Sub


    Private Sub txtQty_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtQty.TextChanged
        btnAdd.Enabled = True
    End Sub

    Private Sub txtRecv_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtRecv.TextChanged
        btnCalChange.Enabled = True
    End Sub

    Private Sub btnCalAmt_Click(sender As System.Object, e As System.EventArgs) Handles btnCalAmt.Click
        txtPAmt.Text = Double.Parse(txtTPrice.Text) - Double.Parse(txtDisc.Text)
        txtRecv.Enabled = True
    End Sub

    Private Sub btnCalChange_Click(sender As System.Object, e As System.EventArgs) Handles btnCalChange.Click
        txtChange.Text = Double.Parse(txtRecv.Text) - Double.Parse(txtPAmt.Text)
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        txtTT.Text = TimeOfDay
    End Sub

    Private Sub btnAvailDisc_Click(sender As System.Object, e As System.EventArgs) Handles btnAvailDisc.Click
        Dim objCmdCD As New SqlCommand
        Dim pmg As Integer
        Dim disc As Double
        Try
            objConnection.Open()
            objCmdCD.Connection = objConnection
            objCmdCD.CommandText = "Select Price_Margin, Discount from Offers"
            Dim objReader As SqlDataReader = objCmdCD.ExecuteReader
            objReader.Read()
            pmg = objReader("Price_Margin")
            disc = Double.Parse(objReader("Discount"))
            objConnection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        If (Val(txtTPrice.Text) > pmg) Then
            txtDisc.Text = disc
        End If
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Dim objCmdTSD As New SqlCommand
        Dim objCmdTID As New SqlCommand
        Try
            objCmdTSD.Connection = objConnection
            objCmdTSD.CommandText = "Delete from Temp_Sales"
            objConnection.Open()
            objCmdTSD.ExecuteNonQuery()
            objConnection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Me.Close()
        End Try
        Try
            objCmdTID.Connection = objConnection
            objCmdTID.CommandText = "Delete from Temp_Inventory"
            objConnection.Open()
            objCmdTID.ExecuteNonQuery()
            objConnection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Me.Close()
        End Try
        Me.Close()
    End Sub

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        Dim credits As Integer
        Dim objCmdSI As New SqlCommand
        Dim objCmdCI As New SqlCommand
        Dim objCmdCU As New SqlCommand
        Dim objCmdIU As New SqlCommand
        Dim objCmdBI As New SqlCommand
        Dim objCmdTSD As New SqlCommand
        Dim objCmdTID As New SqlCommand
        Dim objCmdTU As New SqlCommand
        Try
            objCmdSI.Connection = objConnection2
            objCmdSI.CommandText = "Insert into dbo.ODS_Sales Select @Trno,@CustID,*,@CashierID,@TD,@TT from dbo.Temp_Sales"
            objCmdSI.Parameters.AddWithValue("@Trno", txtTRNo.Text)
            objCmdSI.Parameters.AddWithValue("@CustID", txtCustomerID.Text)
            objCmdSI.Parameters.AddWithValue("@CashierID", txtCID.Text)
            objCmdSI.Parameters.AddWithValue("@TD", Date.Today)
            objCmdSI.Parameters.AddWithValue("@TT", DateTime.Now)
            objConnection2.Open()
            objCmdSI.ExecuteNonQuery()
            objConnection2.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Me.Close()
        End Try
        credits = Val(txtCredits.Text) + Integer.Parse(txtTPrice.Text) / 20
        If txtCustomerID.Text <> " " Or txtCustomerID.Text.Length <> 0 Then
            Try
                objCmdCI.Connection = objConnection2
                objCmdCI.CommandText = "Insert into ODS_Credits Select @CustID,@Cardno,@Credits,@TD,@TT"
                objCmdCI.Parameters.AddWithValue("@CustID", txtCustomerID.Text)
                objCmdCI.Parameters.AddWithValue("@Cardno", cboCardNo.Text)
                objCmdCI.Parameters.AddWithValue("@Credits", credits)
                objCmdCI.Parameters.AddWithValue("@TD", Date.Today)
                objCmdCI.Parameters.AddWithValue("@TT", DateTime.Now)
                objConnection2.Open()
                objCmdCI.ExecuteNonQuery()
                objConnection2.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
                Me.Close()
            End Try

            Try
                objCmdCU.Connection = objConnection
                objCmdCU.CommandText = "Update Cards Set Credits = @Credits where Card_No = @Cardno"
                objCmdCU.Parameters.AddWithValue("@Cardno", cboCardNo.Text)
                objCmdCU.Parameters.AddWithValue("@Credits", credits)
                objConnection.Open()
                objCmdCU.ExecuteNonQuery()
                objConnection.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
                Me.Close()
            End Try
        End If
        Try
            objCmdCI.Connection = objConnection
            objConnection.Open()
            objCmdCI.CommandText = "Delete from Inventory"
            objCmdCI.ExecuteNonQuery()
            objConnection.Close()
            objConnection.Open()
            objCmdCI.CommandText = "Insert into Inventory Select * from Temp_Inventory"
            objCmdCI.ExecuteNonQuery()
            objConnection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Me.Close()
        End Try

        Try
            objCmdBI.Connection = objConnection2
            objCmdBI.CommandText = "Insert Into ODS_Bill Select @Trno,@CustID,@TPrice,@Disc,@PAmt,@CashierID,@TD,@TT"
            objCmdBI.Parameters.AddWithValue("@Trno", txtTRNo.Text)
            objCmdBI.Parameters.AddWithValue("@CustID", txtCustomerID.Text)
            objCmdBI.Parameters.AddWithValue("@TPrice", txtTPrice.Text)
            objCmdBI.Parameters.AddWithValue("@Disc", txtDisc.Text)
            objCmdBI.Parameters.AddWithValue("@PAmt", txtPAmt.Text)
            objCmdBI.Parameters.AddWithValue("@CashierID", txtCID.Text)
            objCmdBI.Parameters.AddWithValue("@TD", Date.Today)
            objCmdBI.Parameters.AddWithValue("@TT", DateTime.Now)
            objConnection2.Open()
            objCmdBI.ExecuteNonQuery()
            objConnection2.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Me.Close()
        End Try
        Try
            objCmdTSD.Connection = objConnection
            objCmdTSD.CommandText = "Delete from Temp_Sales"
            objConnection.Open()
            objCmdTSD.ExecuteNonQuery()
            objConnection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Me.Close()
        End Try
        Try
            objCmdTID.Connection = objConnection
            objCmdTID.CommandText = "Delete from Temp_Inventory"
            objConnection.Open()
            objCmdTID.ExecuteNonQuery()
            objConnection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Me.Close()
        End Try

        Try
            objCmdTU.Connection = objConnection3
            objCmdTU.CommandText = "Delete from Last_Trn"
            objConnection3.Open()
            objCmdTU.ExecuteNonQuery()
            objConnection3.Close()
            objCmdTU.Connection = objConnection3
            objCmdTU.CommandText = "Insert into Last_Trn Select @Trno, @TD"
            objCmdTU.Parameters.AddWithValue("@Trno", txtTRNo.Text)
            objCmdTU.Parameters.AddWithValue("@TD", Date.Today)
            objConnection3.Open()
            objCmdTU.ExecuteNonQuery()
            objConnection3.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Me.Close()
        End Try

        Me.Close()
    End Sub


End Class