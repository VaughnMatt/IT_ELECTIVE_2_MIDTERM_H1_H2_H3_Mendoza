<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainDashboardForm
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
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.lblSystemTitle = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblLoginUser = New System.Windows.Forms.Label()
        Me.lblUserRole = New System.Windows.Forms.Label()
        Me.lblDateandTime = New System.Windows.Forms.Label()
        Me.lblSystemLogo = New System.Windows.Forms.Label()
        Me.pnlContent = New System.Windows.Forms.Panel()
        Me.pnlDashboard = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlTodaysSales = New System.Windows.Forms.Panel()
        Me.lblTodaySalesValue = New System.Windows.Forms.Label()
        Me.lblTodaySalesTitle = New System.Windows.Forms.Label()
        Me.pnlTodaysCustomers = New System.Windows.Forms.Panel()
        Me.lblTodayCustomersValue = New System.Windows.Forms.Label()
        Me.lblTodayCustomersTitle = New System.Windows.Forms.Label()
        Me.pnlCompleteOrders = New System.Windows.Forms.Panel()
        Me.lblCompletedOrdersValue = New System.Windows.Forms.Label()
        Me.lblCompletedOrdersTitle = New System.Windows.Forms.Label()
        Me.pnlPendingOrders = New System.Windows.Forms.Panel()
        Me.lblPendingOrdersValue = New System.Windows.Forms.Label()
        Me.lblPendingOrdersTitle = New System.Windows.Forms.Label()
        Me.pnlTodaysOrders = New System.Windows.Forms.Panel()
        Me.lblTodayOrdersValue = New System.Windows.Forms.Label()
        Me.lblTodayOrdersTitle = New System.Windows.Forms.Label()
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.btnNewLaundry = New System.Windows.Forms.Button()
        Me.btnOrders = New System.Windows.Forms.Button()
        Me.btnCustomers = New System.Windows.Forms.Button()
        Me.btnProducts = New System.Windows.Forms.Button()
        Me.btnStaff = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.btnActivityLogs = New System.Windows.Forms.Button()
        Me.btnDryingOptions = New System.Windows.Forms.Button()
        Me.btnLogout1 = New System.Windows.Forms.Button()
        Me.btnLaundryPackages = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.pnlHeader.SuspendLayout()
        Me.pnlContent.SuspendLayout()
        Me.pnlDashboard.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTodaysSales.SuspendLayout()
        Me.pnlTodaysCustomers.SuspendLayout()
        Me.pnlCompleteOrders.SuspendLayout()
        Me.pnlPendingOrders.SuspendLayout()
        Me.pnlTodaysOrders.SuspendLayout()
        Me.pnlSidebar.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.Controls.Add(Me.btnLogout)
        Me.pnlHeader.Controls.Add(Me.lblSystemTitle)
        Me.pnlHeader.Controls.Add(Me.lblWelcome)
        Me.pnlHeader.Controls.Add(Me.lblLoginUser)
        Me.pnlHeader.Controls.Add(Me.lblUserRole)
        Me.pnlHeader.Controls.Add(Me.lblDateandTime)
        Me.pnlHeader.Controls.Add(Me.lblSystemLogo)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(957, 104)
        Me.pnlHeader.TabIndex = 1
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(799, 19)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(146, 46)
        Me.btnLogout.TabIndex = 6
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'lblSystemTitle
        '
        Me.lblSystemTitle.AutoSize = True
        Me.lblSystemTitle.Location = New System.Drawing.Point(137, 34)
        Me.lblSystemTitle.Name = "lblSystemTitle"
        Me.lblSystemTitle.Size = New System.Drawing.Size(213, 16)
        Me.lblSystemTitle.TabIndex = 5
        Me.lblSystemTitle.Text = "LAUNDRY SHOP MANAGEMENT"
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Location = New System.Drawing.Point(640, 34)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(65, 16)
        Me.lblWelcome.TabIndex = 4
        Me.lblWelcome.Text = "Welcome"
        '
        'lblLoginUser
        '
        Me.lblLoginUser.AutoSize = True
        Me.lblLoginUser.Location = New System.Drawing.Point(758, 65)
        Me.lblLoginUser.Name = "lblLoginUser"
        Me.lblLoginUser.Size = New System.Drawing.Size(36, 16)
        Me.lblLoginUser.TabIndex = 3
        Me.lblLoginUser.Text = "User"
        '
        'lblUserRole
        '
        Me.lblUserRole.AutoSize = True
        Me.lblUserRole.Location = New System.Drawing.Point(640, 79)
        Me.lblUserRole.Name = "lblUserRole"
        Me.lblUserRole.Size = New System.Drawing.Size(36, 16)
        Me.lblUserRole.TabIndex = 2
        Me.lblUserRole.Text = "Role"
        '
        'lblDateandTime
        '
        Me.lblDateandTime.AutoSize = True
        Me.lblDateandTime.Location = New System.Drawing.Point(557, 34)
        Me.lblDateandTime.Name = "lblDateandTime"
        Me.lblDateandTime.Size = New System.Drawing.Size(0, 16)
        Me.lblDateandTime.TabIndex = 1
        '
        'lblSystemLogo
        '
        Me.lblSystemLogo.AutoSize = True
        Me.lblSystemLogo.Location = New System.Drawing.Point(33, 34)
        Me.lblSystemLogo.Name = "lblSystemLogo"
        Me.lblSystemLogo.Size = New System.Drawing.Size(38, 16)
        Me.lblSystemLogo.TabIndex = 0
        Me.lblSystemLogo.Text = "Logo"
        '
        'pnlContent
        '
        Me.pnlContent.Controls.Add(Me.pnlDashboard)
        Me.pnlContent.Controls.Add(Me.pnlSidebar)
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.Location = New System.Drawing.Point(0, 104)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(957, 556)
        Me.pnlContent.TabIndex = 2
        '
        'pnlDashboard
        '
        Me.pnlDashboard.Controls.Add(Me.DataGridView1)
        Me.pnlDashboard.Controls.Add(Me.pnlTodaysSales)
        Me.pnlDashboard.Controls.Add(Me.pnlTodaysCustomers)
        Me.pnlDashboard.Controls.Add(Me.pnlCompleteOrders)
        Me.pnlDashboard.Controls.Add(Me.pnlPendingOrders)
        Me.pnlDashboard.Controls.Add(Me.pnlTodaysOrders)
        Me.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDashboard.Location = New System.Drawing.Point(183, 0)
        Me.pnlDashboard.Name = "pnlDashboard"
        Me.pnlDashboard.Size = New System.Drawing.Size(774, 556)
        Me.pnlDashboard.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.DataGridView1.Location = New System.Drawing.Point(4, 297)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(765, 247)
        Me.DataGridView1.TabIndex = 7
        '
        'Column1
        '
        Me.Column1.HeaderText = "Order Number"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "Customer Name"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "Service"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "Status"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 125
        '
        'Column5
        '
        Me.Column5.HeaderText = "Contact Number"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 125
        '
        'Column6
        '
        Me.Column6.HeaderText = "Date"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 125
        '
        'pnlTodaysSales
        '
        Me.pnlTodaysSales.Controls.Add(Me.lblTodaySalesValue)
        Me.pnlTodaysSales.Controls.Add(Me.lblTodaySalesTitle)
        Me.pnlTodaysSales.Location = New System.Drawing.Point(252, 202)
        Me.pnlTodaysSales.Name = "pnlTodaysSales"
        Me.pnlTodaysSales.Size = New System.Drawing.Size(235, 71)
        Me.pnlTodaysSales.TabIndex = 6
        '
        'lblTodaySalesValue
        '
        Me.lblTodaySalesValue.AutoSize = True
        Me.lblTodaySalesValue.Location = New System.Drawing.Point(106, 38)
        Me.lblTodaySalesValue.Name = "lblTodaySalesValue"
        Me.lblTodaySalesValue.Size = New System.Drawing.Size(14, 16)
        Me.lblTodaySalesValue.TabIndex = 4
        Me.lblTodaySalesValue.Text = "0"
        '
        'lblTodaySalesTitle
        '
        Me.lblTodaySalesTitle.AutoSize = True
        Me.lblTodaySalesTitle.Location = New System.Drawing.Point(61, 7)
        Me.lblTodaySalesTitle.Name = "lblTodaySalesTitle"
        Me.lblTodaySalesTitle.Size = New System.Drawing.Size(109, 16)
        Me.lblTodaySalesTitle.TabIndex = 5
        Me.lblTodaySalesTitle.Text = "TODAYS SALES"
        '
        'pnlTodaysCustomers
        '
        Me.pnlTodaysCustomers.Controls.Add(Me.lblTodayCustomersValue)
        Me.pnlTodaysCustomers.Controls.Add(Me.lblTodayCustomersTitle)
        Me.pnlTodaysCustomers.Location = New System.Drawing.Point(422, 119)
        Me.pnlTodaysCustomers.Name = "pnlTodaysCustomers"
        Me.pnlTodaysCustomers.Size = New System.Drawing.Size(235, 75)
        Me.pnlTodaysCustomers.TabIndex = 1
        '
        'lblTodayCustomersValue
        '
        Me.lblTodayCustomersValue.AutoSize = True
        Me.lblTodayCustomersValue.Location = New System.Drawing.Point(107, 42)
        Me.lblTodayCustomersValue.Name = "lblTodayCustomersValue"
        Me.lblTodayCustomersValue.Size = New System.Drawing.Size(14, 16)
        Me.lblTodayCustomersValue.TabIndex = 4
        Me.lblTodayCustomersValue.Text = "0"
        '
        'lblTodayCustomersTitle
        '
        Me.lblTodayCustomersTitle.AutoSize = True
        Me.lblTodayCustomersTitle.Location = New System.Drawing.Point(46, 9)
        Me.lblTodayCustomersTitle.Name = "lblTodayCustomersTitle"
        Me.lblTodayCustomersTitle.Size = New System.Drawing.Size(143, 16)
        Me.lblTodayCustomersTitle.TabIndex = 5
        Me.lblTodayCustomersTitle.Text = "CUSTOMERS TODAY"
        '
        'pnlCompleteOrders
        '
        Me.pnlCompleteOrders.Controls.Add(Me.lblCompletedOrdersValue)
        Me.pnlCompleteOrders.Controls.Add(Me.lblCompletedOrdersTitle)
        Me.pnlCompleteOrders.Location = New System.Drawing.Point(88, 119)
        Me.pnlCompleteOrders.Name = "pnlCompleteOrders"
        Me.pnlCompleteOrders.Size = New System.Drawing.Size(235, 75)
        Me.pnlCompleteOrders.TabIndex = 1
        '
        'lblCompletedOrdersValue
        '
        Me.lblCompletedOrdersValue.AutoSize = True
        Me.lblCompletedOrdersValue.Location = New System.Drawing.Point(111, 42)
        Me.lblCompletedOrdersValue.Name = "lblCompletedOrdersValue"
        Me.lblCompletedOrdersValue.Size = New System.Drawing.Size(14, 16)
        Me.lblCompletedOrdersValue.TabIndex = 2
        Me.lblCompletedOrdersValue.Text = "0"
        '
        'lblCompletedOrdersTitle
        '
        Me.lblCompletedOrdersTitle.AutoSize = True
        Me.lblCompletedOrdersTitle.Location = New System.Drawing.Point(44, 9)
        Me.lblCompletedOrdersTitle.Name = "lblCompletedOrdersTitle"
        Me.lblCompletedOrdersTitle.Size = New System.Drawing.Size(151, 16)
        Me.lblCompletedOrdersTitle.TabIndex = 3
        Me.lblCompletedOrdersTitle.Text = "COMPLETED ORDERS"
        '
        'pnlPendingOrders
        '
        Me.pnlPendingOrders.Controls.Add(Me.lblPendingOrdersValue)
        Me.pnlPendingOrders.Controls.Add(Me.lblPendingOrdersTitle)
        Me.pnlPendingOrders.Location = New System.Drawing.Point(422, 31)
        Me.pnlPendingOrders.Name = "pnlPendingOrders"
        Me.pnlPendingOrders.Size = New System.Drawing.Size(235, 75)
        Me.pnlPendingOrders.TabIndex = 1
        '
        'lblPendingOrdersValue
        '
        Me.lblPendingOrdersValue.AutoSize = True
        Me.lblPendingOrdersValue.Location = New System.Drawing.Point(107, 45)
        Me.lblPendingOrdersValue.Name = "lblPendingOrdersValue"
        Me.lblPendingOrdersValue.Size = New System.Drawing.Size(14, 16)
        Me.lblPendingOrdersValue.TabIndex = 6
        Me.lblPendingOrdersValue.Text = "0"
        '
        'lblPendingOrdersTitle
        '
        Me.lblPendingOrdersTitle.AutoSize = True
        Me.lblPendingOrdersTitle.Location = New System.Drawing.Point(60, 14)
        Me.lblPendingOrdersTitle.Name = "lblPendingOrdersTitle"
        Me.lblPendingOrdersTitle.Size = New System.Drawing.Size(129, 16)
        Me.lblPendingOrdersTitle.TabIndex = 7
        Me.lblPendingOrdersTitle.Text = "PENDING ORDERS"
        '
        'pnlTodaysOrders
        '
        Me.pnlTodaysOrders.Controls.Add(Me.lblTodayOrdersValue)
        Me.pnlTodaysOrders.Controls.Add(Me.lblTodayOrdersTitle)
        Me.pnlTodaysOrders.Location = New System.Drawing.Point(88, 31)
        Me.pnlTodaysOrders.Name = "pnlTodaysOrders"
        Me.pnlTodaysOrders.Size = New System.Drawing.Size(235, 75)
        Me.pnlTodaysOrders.TabIndex = 0
        '
        'lblTodayOrdersValue
        '
        Me.lblTodayOrdersValue.AutoSize = True
        Me.lblTodayOrdersValue.Location = New System.Drawing.Point(111, 44)
        Me.lblTodayOrdersValue.Name = "lblTodayOrdersValue"
        Me.lblTodayOrdersValue.Size = New System.Drawing.Size(14, 16)
        Me.lblTodayOrdersValue.TabIndex = 1
        Me.lblTodayOrdersValue.Text = "0"
        '
        'lblTodayOrdersTitle
        '
        Me.lblTodayOrdersTitle.AutoSize = True
        Me.lblTodayOrdersTitle.Location = New System.Drawing.Point(57, 14)
        Me.lblTodayOrdersTitle.Name = "lblTodayOrdersTitle"
        Me.lblTodayOrdersTitle.Size = New System.Drawing.Size(124, 16)
        Me.lblTodayOrdersTitle.TabIndex = 0
        Me.lblTodayOrdersTitle.Text = "TODAYS ORDERS"
        '
        'pnlSidebar
        '
        Me.pnlSidebar.Controls.Add(Me.btnNewLaundry)
        Me.pnlSidebar.Controls.Add(Me.btnOrders)
        Me.pnlSidebar.Controls.Add(Me.btnCustomers)
        Me.pnlSidebar.Controls.Add(Me.btnProducts)
        Me.pnlSidebar.Controls.Add(Me.btnStaff)
        Me.pnlSidebar.Controls.Add(Me.btnReports)
        Me.pnlSidebar.Controls.Add(Me.btnActivityLogs)
        Me.pnlSidebar.Controls.Add(Me.btnDryingOptions)
        Me.pnlSidebar.Controls.Add(Me.btnLogout1)
        Me.pnlSidebar.Controls.Add(Me.btnLaundryPackages)
        Me.pnlSidebar.Controls.Add(Me.btnDashboard)
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(183, 556)
        Me.pnlSidebar.TabIndex = 0
        '
        'btnNewLaundry
        '
        Me.btnNewLaundry.Location = New System.Drawing.Point(12, 73)
        Me.btnNewLaundry.Name = "btnNewLaundry"
        Me.btnNewLaundry.Size = New System.Drawing.Size(157, 23)
        Me.btnNewLaundry.TabIndex = 11
        Me.btnNewLaundry.Text = "NEW LAUNDRY"
        Me.btnNewLaundry.UseVisualStyleBackColor = True
        '
        'btnOrders
        '
        Me.btnOrders.Location = New System.Drawing.Point(12, 119)
        Me.btnOrders.Name = "btnOrders"
        Me.btnOrders.Size = New System.Drawing.Size(157, 23)
        Me.btnOrders.TabIndex = 10
        Me.btnOrders.Text = "ORDERS"
        Me.btnOrders.UseVisualStyleBackColor = True
        '
        'btnCustomers
        '
        Me.btnCustomers.Location = New System.Drawing.Point(12, 163)
        Me.btnCustomers.Name = "btnCustomers"
        Me.btnCustomers.Size = New System.Drawing.Size(157, 23)
        Me.btnCustomers.TabIndex = 8
        Me.btnCustomers.Text = "CUSTOMERS"
        Me.btnCustomers.UseVisualStyleBackColor = True
        '
        'btnProducts
        '
        Me.btnProducts.Location = New System.Drawing.Point(12, 208)
        Me.btnProducts.Name = "btnProducts"
        Me.btnProducts.Size = New System.Drawing.Size(157, 23)
        Me.btnProducts.TabIndex = 7
        Me.btnProducts.Text = "PRODUCTS"
        Me.btnProducts.UseVisualStyleBackColor = True
        '
        'btnStaff
        '
        Me.btnStaff.Location = New System.Drawing.Point(12, 343)
        Me.btnStaff.Name = "btnStaff"
        Me.btnStaff.Size = New System.Drawing.Size(157, 23)
        Me.btnStaff.TabIndex = 6
        Me.btnStaff.Text = "STAFF"
        Me.btnStaff.UseVisualStyleBackColor = True
        '
        'btnReports
        '
        Me.btnReports.Location = New System.Drawing.Point(12, 392)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(157, 23)
        Me.btnReports.TabIndex = 5
        Me.btnReports.Text = "REPORTS"
        Me.btnReports.UseVisualStyleBackColor = True
        '
        'btnActivityLogs
        '
        Me.btnActivityLogs.Location = New System.Drawing.Point(12, 440)
        Me.btnActivityLogs.Name = "btnActivityLogs"
        Me.btnActivityLogs.Size = New System.Drawing.Size(157, 23)
        Me.btnActivityLogs.TabIndex = 4
        Me.btnActivityLogs.Text = "ACTIVITY LOGS"
        Me.btnActivityLogs.UseVisualStyleBackColor = True
        '
        'btnDryingOptions
        '
        Me.btnDryingOptions.Location = New System.Drawing.Point(12, 297)
        Me.btnDryingOptions.Name = "btnDryingOptions"
        Me.btnDryingOptions.Size = New System.Drawing.Size(157, 23)
        Me.btnDryingOptions.TabIndex = 3
        Me.btnDryingOptions.Text = "DRYING OPTIONS"
        Me.btnDryingOptions.UseVisualStyleBackColor = True
        '
        'btnLogout1
        '
        Me.btnLogout1.Location = New System.Drawing.Point(36, 514)
        Me.btnLogout1.Name = "btnLogout1"
        Me.btnLogout1.Size = New System.Drawing.Size(119, 23)
        Me.btnLogout1.TabIndex = 2
        Me.btnLogout1.Text = "LOGOUT"
        Me.btnLogout1.UseVisualStyleBackColor = True
        '
        'btnLaundryPackages
        '
        Me.btnLaundryPackages.Location = New System.Drawing.Point(12, 251)
        Me.btnLaundryPackages.Name = "btnLaundryPackages"
        Me.btnLaundryPackages.Size = New System.Drawing.Size(157, 22)
        Me.btnLaundryPackages.TabIndex = 1
        Me.btnLaundryPackages.Text = "LAUNDRY PACKAGES"
        Me.btnLaundryPackages.UseVisualStyleBackColor = True
        '
        'btnDashboard
        '
        Me.btnDashboard.Location = New System.Drawing.Point(12, 28)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(157, 23)
        Me.btnDashboard.TabIndex = 0
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.UseVisualStyleBackColor = True
        '
        'MainDashboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(957, 660)
        Me.Controls.Add(Me.pnlContent)
        Me.Controls.Add(Me.pnlHeader)
        Me.Name = "MainDashboardForm"
        Me.Text = "Laundry Shop Management - Dashboard"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlContent.ResumeLayout(False)
        Me.pnlDashboard.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTodaysSales.ResumeLayout(False)
        Me.pnlTodaysSales.PerformLayout()
        Me.pnlTodaysCustomers.ResumeLayout(False)
        Me.pnlTodaysCustomers.PerformLayout()
        Me.pnlCompleteOrders.ResumeLayout(False)
        Me.pnlCompleteOrders.PerformLayout()
        Me.pnlPendingOrders.ResumeLayout(False)
        Me.pnlPendingOrders.PerformLayout()
        Me.pnlTodaysOrders.ResumeLayout(False)
        Me.pnlTodaysOrders.PerformLayout()
        Me.pnlSidebar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents pnlContent As Panel
    Friend WithEvents lblSystemTitle As Label
    Friend WithEvents lblWelcome As Label
    Friend WithEvents lblLoginUser As Label
    Friend WithEvents lblUserRole As Label
    Friend WithEvents lblDateandTime As Label
    Friend WithEvents lblSystemLogo As Label
    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnNewLaundry As Button
    Friend WithEvents btnOrders As Button
    Friend WithEvents btnCustomers As Button
    Friend WithEvents btnProducts As Button
    Friend WithEvents btnStaff As Button
    Friend WithEvents btnReports As Button
    Friend WithEvents btnActivityLogs As Button
    Friend WithEvents btnDryingOptions As Button
    Friend WithEvents btnLogout1 As Button
    Friend WithEvents btnLaundryPackages As Button
    Friend WithEvents btnDashboard As Button
    Friend WithEvents pnlDashboard As Panel
    Friend WithEvents pnlTodaysCustomers As Panel
    Friend WithEvents lblPendingOrdersTitle As Label
    Friend WithEvents lblPendingOrdersValue As Label
    Friend WithEvents lblTodayCustomersValue As Label
    Friend WithEvents lblTodayCustomersTitle As Label
    Friend WithEvents pnlCompleteOrders As Panel
    Friend WithEvents lblCompletedOrdersValue As Label
    Friend WithEvents pnlPendingOrders As Panel
    Friend WithEvents pnlTodaysOrders As Panel
    Friend WithEvents lblTodayOrdersValue As Label
    Friend WithEvents lblTodayOrdersTitle As Label
    Protected Friend WithEvents lblCompletedOrdersTitle As Label
    Friend WithEvents pnlTodaysSales As Panel
    Friend WithEvents lblTodaySalesValue As Label
    Friend WithEvents lblTodaySalesTitle As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
End Class
