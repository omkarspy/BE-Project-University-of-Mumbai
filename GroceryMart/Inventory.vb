
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class Inventory

    Dim objConnection As New SqlConnection("Data Source=BHASWANTH-PC\SQLEXPRESS;Initial Catalog=Grocery_Mart;Integrated Security=True")
    Dim objDataAdapter As New SqlDataAdapter()
    Dim objDataSet As DataSet
    Dim objDataView As DataView
    Dim objCurrencyManager As CurrencyManager

    Private Sub FillDataSetAndView()
        ' Initialize a new instance of the DataSet object..
        objDataSet = New DataSet()
        ' Fill the DataSet object with data..
        objDataAdapter.Fill(objDataSet, "Inventory")
        ' Set the DataView object to the DataSet object..
        objDataView = New DataView(objDataSet.Tables("Inventory"))

        objCurrencyManager = CType(Me.BindingContext(objDataView), CurrencyManager)
    End Sub
    Private Sub BindFields()
        ' Clear any previous bindings..


        txtQty.DataBindings.Clear()
       
        txtExpDate.DataBindings.Clear()
      
        ' Add new bindings to the DataView object..

        txtQty.DataBindings.Add("Text", objDataView, "Quantity")
     
        txtExpDate.DataBindings.Add("Text", objDataView, "Expiry_Date")
       
    End Sub

    Private Sub Inventory_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim objCmd As New SqlCommand
        objCmd.Connection = objConnection

        objCmd.CommandText = "Select * from Inventory where ProductID = @ProdID"
        objCmd.Parameters.AddWithValue("@ProdID", Products.txtProdID.Text)
        objDataAdapter.SelectCommand = objCmd
        FillDataSetAndView()
        BindFields()

    End Sub



End Class