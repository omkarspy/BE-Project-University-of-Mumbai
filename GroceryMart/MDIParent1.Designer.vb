<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIParent1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIParent1))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ViewMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductsMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.SuppliersMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.OffersMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomersMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfilesMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StoreMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeesMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.AccountsMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.ServicesMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmplReportingMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpChkOutMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.TransactionsMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CashierEntryMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.PlaceOrderMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.AvailAGiftMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.DWEntryMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripSeparator15 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripSeparator16 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.ToolStripSeparator5, Me.ViewMenu, Me.CustomersMenu, Me.StoreMenu, Me.ToolStripSeparator9, Me.ServicesMenu, Me.ToolStripSeparator8, Me.TransactionsMenu, Me.ToolStripSeparator12, Me.DWEntryMenu, Me.ToolStripSeparator13})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.MdiWindowListItem = Me.StoreMenu
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(652, 27)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginMenuItem, Me.LogoutMenuItem, Me.ToolStripSeparator3, Me.ExitMenuItem})
        Me.FileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(37, 23)
        Me.FileMenu.Text = "&File"
        '
        'LoginMenuItem
        '
        Me.LoginMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.LoginMenuItem.Image = CType(resources.GetObject("LoginMenuItem.Image"), System.Drawing.Image)
        Me.LoginMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.LoginMenuItem.Name = "LoginMenuItem"
        Me.LoginMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.LoginMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.LoginMenuItem.Text = "Login"
        '
        'LogoutMenuItem
        '
        Me.LogoutMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.LogoutMenuItem.Image = CType(resources.GetObject("LogoutMenuItem.Image"), System.Drawing.Image)
        Me.LogoutMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.LogoutMenuItem.Name = "LogoutMenuItem"
        Me.LogoutMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.LogoutMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.LogoutMenuItem.Text = "Logout"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(150, 6)
        '
        'ExitMenuItem
        '
        Me.ExitMenuItem.Name = "ExitMenuItem"
        Me.ExitMenuItem.ShortcutKeyDisplayString = ""
        Me.ExitMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.ExitMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.ExitMenuItem.Text = "E&xit"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 23)
        '
        'ViewMenu
        '
        Me.ViewMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductsMenuItem, Me.ToolStripSeparator6, Me.SuppliersMenuItem, Me.ToolStripSeparator7, Me.OffersMenuItem})
        Me.ViewMenu.Name = "ViewMenu"
        Me.ViewMenu.Size = New System.Drawing.Size(44, 23)
        Me.ViewMenu.Text = "&View"
        '
        'ProductsMenuItem
        '
        Me.ProductsMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ProductsMenuItem.Image = CType(resources.GetObject("ProductsMenuItem.Image"), System.Drawing.Image)
        Me.ProductsMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.ProductsMenuItem.Name = "ProductsMenuItem"
        Me.ProductsMenuItem.ShortcutKeyDisplayString = ""
        Me.ProductsMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.ProductsMenuItem.Text = "Products   "
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(127, 6)
        '
        'SuppliersMenuItem
        '
        Me.SuppliersMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SuppliersMenuItem.Image = CType(resources.GetObject("SuppliersMenuItem.Image"), System.Drawing.Image)
        Me.SuppliersMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.SuppliersMenuItem.Name = "SuppliersMenuItem"
        Me.SuppliersMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.SuppliersMenuItem.Text = "Suppliers"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(127, 6)
        '
        'OffersMenuItem
        '
        Me.OffersMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.OffersMenuItem.Name = "OffersMenuItem"
        Me.OffersMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.OffersMenuItem.Text = "Offers"
        '
        'CustomersMenu
        '
        Me.CustomersMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProfilesMenuItem})
        Me.CustomersMenu.Name = "CustomersMenu"
        Me.CustomersMenu.Size = New System.Drawing.Size(76, 23)
        Me.CustomersMenu.Text = "&Customers"
        '
        'ProfilesMenuItem
        '
        Me.ProfilesMenuItem.Name = "ProfilesMenuItem"
        Me.ProfilesMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.ProfilesMenuItem.Text = "Profiles"
        '
        'StoreMenu
        '
        Me.StoreMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmployeesMenuItem, Me.ToolStripSeparator10, Me.AccountsMenuItem})
        Me.StoreMenu.Name = "StoreMenu"
        Me.StoreMenu.Size = New System.Drawing.Size(46, 23)
        Me.StoreMenu.Text = "&Store"
        '
        'EmployeesMenuItem
        '
        Me.EmployeesMenuItem.Name = "EmployeesMenuItem"
        Me.EmployeesMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.EmployeesMenuItem.Text = "Employees"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(128, 6)
        '
        'AccountsMenuItem
        '
        Me.AccountsMenuItem.Name = "AccountsMenuItem"
        Me.AccountsMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.AccountsMenuItem.Text = "Accounts"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 23)
        '
        'ServicesMenu
        '
        Me.ServicesMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmplReportingMenuItem, Me.EmpChkOutMenuItem})
        Me.ServicesMenu.Name = "ServicesMenu"
        Me.ServicesMenu.Size = New System.Drawing.Size(61, 23)
        Me.ServicesMenu.Text = "Services"
        '
        'EmplReportingMenuItem
        '
        Me.EmplReportingMenuItem.Name = "EmplReportingMenuItem"
        Me.EmplReportingMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.EmplReportingMenuItem.Text = "Employee Reporting"
        '
        'EmpChkOutMenuItem
        '
        Me.EmpChkOutMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.EmpChkOutMenuItem.Image = CType(resources.GetObject("EmpChkOutMenuItem.Image"), System.Drawing.Image)
        Me.EmpChkOutMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.EmpChkOutMenuItem.Name = "EmpChkOutMenuItem"
        Me.EmpChkOutMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.EmpChkOutMenuItem.Text = "Employee Checkout"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 23)
        '
        'TransactionsMenu
        '
        Me.TransactionsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CashierEntryMenuItem, Me.ToolStripSeparator11, Me.PlaceOrderMenuItem, Me.ToolStripSeparator4, Me.AvailAGiftMenuItem})
        Me.TransactionsMenu.Name = "TransactionsMenu"
        Me.TransactionsMenu.Size = New System.Drawing.Size(86, 23)
        Me.TransactionsMenu.Text = "Transactions"
        '
        'CashierEntryMenuItem
        '
        Me.CashierEntryMenuItem.Name = "CashierEntryMenuItem"
        Me.CashierEntryMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.CashierEntryMenuItem.Text = "Cashier Entry"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(140, 6)
        '
        'PlaceOrderMenuItem
        '
        Me.PlaceOrderMenuItem.Name = "PlaceOrderMenuItem"
        Me.PlaceOrderMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.PlaceOrderMenuItem.Text = "Place Order"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(140, 6)
        '
        'AvailAGiftMenuItem
        '
        Me.AvailAGiftMenuItem.Name = "AvailAGiftMenuItem"
        Me.AvailAGiftMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.AvailAGiftMenuItem.Text = "Avail a Gift"
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(6, 23)
        '
        'DWEntryMenu
        '
        Me.DWEntryMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadToolStripMenuItem})
        Me.DWEntryMenu.Name = "DWEntryMenu"
        Me.DWEntryMenu.Size = New System.Drawing.Size(68, 23)
        Me.DWEntryMenu.Text = "DW Entry"
        '
        'LoadToolStripMenuItem
        '
        Me.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem"
        Me.LoadToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.LoadToolStripMenuItem.Text = "Load"
        '
        'ToolStripSeparator13
        '
        Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
        Me.ToolStripSeparator13.Size = New System.Drawing.Size(6, 23)
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel, Me.ToolStripSeparator15, Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.ToolStripSeparator1, Me.ToolStripStatusLabel4, Me.ToolStripSeparator2, Me.ToolStripStatusLabel5, Me.ToolStripSeparator16})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 463)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(652, 23)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(39, 18)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'ToolStripSeparator15
        '
        Me.ToolStripSeparator15.Name = "ToolStripSeparator15"
        Me.ToolStripSeparator15.Size = New System.Drawing.Size(6, 23)
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(63, 18)
        Me.ToolStripStatusLabel1.Text = "Logged In:"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(0, 18)
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(0, 18)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 23)
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(121, 18)
        Me.ToolStripStatusLabel4.Text = "ToolStripStatusLabel4"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 23)
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(121, 18)
        Me.ToolStripStatusLabel5.Text = "ToolStripStatusLabel5"
        '
        'ToolStripSeparator16
        '
        Me.ToolStripSeparator16.Name = "ToolStripSeparator16"
        Me.ToolStripSeparator16.Size = New System.Drawing.Size(6, 23)
        '
        'Timer1
        '
        '
        'MDIParent1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(652, 486)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MDIParent1"
        Me.Text = "Green Joy"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EmplReportingMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ServicesMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpChkOutMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeesMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StoreMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AccountsMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ExitMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoginMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ViewMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductsMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SuppliersMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents OffersMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransactionsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CustomersMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProfilesMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CashierEntryMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PlaceOrderMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator12 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DWEntryMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator13 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripSeparator15 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ToolStripSeparator16 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AvailAGiftMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
