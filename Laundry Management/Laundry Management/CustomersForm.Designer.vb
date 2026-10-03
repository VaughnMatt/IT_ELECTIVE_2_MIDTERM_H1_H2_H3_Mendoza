<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomersForm
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
        Me.lblCustomersTitle = New System.Windows.Forms.Label()
        Me.btnSearchCustomer = New System.Windows.Forms.Button()
        Me.txtSearchCustomer = New System.Windows.Forms.TextBox()
        Me.btnAddCustomer = New System.Windows.Forms.Button()
        Me.btnUpdateCustomer = New System.Windows.Forms.Button()
        Me.btnDeleteCustomer = New System.Windows.Forms.Button()
        Me.lblSearchCustomer = New System.Windows.Forms.Label()
        Me.lblCustomersDescription = New System.Windows.Forms.Label()
        Me.dgvCustomers = New System.Windows.Forms.DataGridView()
        Me.colCustomerID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCustomerName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colContactNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTotalOrders = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDateRegistered = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCustomersTitle
        '
        Me.lblCustomersTitle.AutoSize = True
        Me.lblCustomersTitle.Location = New System.Drawing.Point(57, 34)
        Me.lblCustomersTitle.Name = "lblCustomersTitle"
        Me.lblCustomersTitle.Size = New System.Drawing.Size(93, 16)
        Me.lblCustomersTitle.TabIndex = 0
        Me.lblCustomersTitle.Text = "CUSTOMERS"
        '
        'btnSearchCustomer
        '
        Me.btnSearchCustomer.Location = New System.Drawing.Point(186, 140)
        Me.btnSearchCustomer.Name = "btnSearchCustomer"
        Me.btnSearchCustomer.Size = New System.Drawing.Size(75, 23)
        Me.btnSearchCustomer.TabIndex = 1
        Me.btnSearchCustomer.Text = "SEARCH"
        Me.btnSearchCustomer.UseVisualStyleBackColor = True
        '
        'txtSearchCustomer
        '
        Me.txtSearchCustomer.Location = New System.Drawing.Point(67, 140)
        Me.txtSearchCustomer.Name = "txtSearchCustomer"
        Me.txtSearchCustomer.Size = New System.Drawing.Size(100, 22)
        Me.txtSearchCustomer.TabIndex = 2
        '
        'btnAddCustomer
        '
        Me.btnAddCustomer.Location = New System.Drawing.Point(186, 541)
        Me.btnAddCustomer.Name = "btnAddCustomer"
        Me.btnAddCustomer.Size = New System.Drawing.Size(75, 23)
        Me.btnAddCustomer.TabIndex = 3
        Me.btnAddCustomer.Text = "ADD"
        Me.btnAddCustomer.UseVisualStyleBackColor = True
        '
        'btnUpdateCustomer
        '
        Me.btnUpdateCustomer.Location = New System.Drawing.Point(298, 541)
        Me.btnUpdateCustomer.Name = "btnUpdateCustomer"
        Me.btnUpdateCustomer.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdateCustomer.TabIndex = 4
        Me.btnUpdateCustomer.Text = "UPDATE"
        Me.btnUpdateCustomer.UseVisualStyleBackColor = True
        '
        'btnDeleteCustomer
        '
        Me.btnDeleteCustomer.Location = New System.Drawing.Point(418, 541)
        Me.btnDeleteCustomer.Name = "btnDeleteCustomer"
        Me.btnDeleteCustomer.Size = New System.Drawing.Size(75, 23)
        Me.btnDeleteCustomer.TabIndex = 5
        Me.btnDeleteCustomer.Text = "DELETE"
        Me.btnDeleteCustomer.UseVisualStyleBackColor = True
        '
        'lblSearchCustomer
        '
        Me.lblSearchCustomer.AutoSize = True
        Me.lblSearchCustomer.Location = New System.Drawing.Point(57, 99)
        Me.lblSearchCustomer.Name = "lblSearchCustomer"
        Me.lblSearchCustomer.Size = New System.Drawing.Size(110, 16)
        Me.lblSearchCustomer.TabIndex = 6
        Me.lblSearchCustomer.Text = "Search Customer"
        '
        'lblCustomersDescription
        '
        Me.lblCustomersDescription.AutoSize = True
        Me.lblCustomersDescription.Location = New System.Drawing.Point(57, 62)
        Me.lblCustomersDescription.Name = "lblCustomersDescription"
        Me.lblCustomersDescription.Size = New System.Drawing.Size(186, 16)
        Me.lblCustomersDescription.TabIndex = 7
        Me.lblCustomersDescription.Text = "Manage customer information."
        '
        'dgvCustomers
        '
        Me.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCustomerID, Me.colCustomerName, Me.colContactNumber, Me.colTotalOrders, Me.colDateRegistered})
        Me.dgvCustomers.Location = New System.Drawing.Point(12, 205)
        Me.dgvCustomers.Name = "dgvCustomers"
        Me.dgvCustomers.RowHeadersWidth = 51
        Me.dgvCustomers.RowTemplate.Height = 24
        Me.dgvCustomers.Size = New System.Drawing.Size(776, 150)
        Me.dgvCustomers.TabIndex = 8
        '
        'colCustomerID
        '
        Me.colCustomerID.HeaderText = "Customer ID"
        Me.colCustomerID.MinimumWidth = 6
        Me.colCustomerID.Name = "colCustomerID"
        Me.colCustomerID.Width = 125
        '
        'colCustomerName
        '
        Me.colCustomerName.HeaderText = "Customer Name"
        Me.colCustomerName.MinimumWidth = 6
        Me.colCustomerName.Name = "colCustomerName"
        Me.colCustomerName.Width = 125
        '
        'colContactNumber
        '
        Me.colContactNumber.HeaderText = "Contact Number"
        Me.colContactNumber.MinimumWidth = 6
        Me.colContactNumber.Name = "colContactNumber"
        Me.colContactNumber.Width = 125
        '
        'colTotalOrders
        '
        Me.colTotalOrders.HeaderText = "Total Orders"
        Me.colTotalOrders.MinimumWidth = 6
        Me.colTotalOrders.Name = "colTotalOrders"
        Me.colTotalOrders.Width = 125
        '
        'colDateRegistered
        '
        Me.colDateRegistered.HeaderText = "Date Registered"
        Me.colDateRegistered.MinimumWidth = 6
        Me.colDateRegistered.Name = "colDateRegistered"
        Me.colDateRegistered.Width = 125
        '
        'CustomersForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 624)
        Me.Controls.Add(Me.dgvCustomers)
        Me.Controls.Add(Me.lblCustomersDescription)
        Me.Controls.Add(Me.lblSearchCustomer)
        Me.Controls.Add(Me.btnDeleteCustomer)
        Me.Controls.Add(Me.btnUpdateCustomer)
        Me.Controls.Add(Me.btnAddCustomer)
        Me.Controls.Add(Me.txtSearchCustomer)
        Me.Controls.Add(Me.btnSearchCustomer)
        Me.Controls.Add(Me.lblCustomersTitle)
        Me.Name = "CustomersForm"
        Me.Text = "CUSTOMERS"
        CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCustomersTitle As Label
    Friend WithEvents btnSearchCustomer As Button
    Friend WithEvents txtSearchCustomer As TextBox
    Friend WithEvents btnAddCustomer As Button
    Friend WithEvents btnUpdateCustomer As Button
    Friend WithEvents btnDeleteCustomer As Button
    Friend WithEvents lblSearchCustomer As Label
    Friend WithEvents lblCustomersDescription As Label
    Friend WithEvents dgvCustomers As DataGridView
    Friend WithEvents colCustomerID As DataGridViewTextBoxColumn
    Friend WithEvents colCustomerName As DataGridViewTextBoxColumn
    Friend WithEvents colContactNumber As DataGridViewTextBoxColumn
    Friend WithEvents colTotalOrders As DataGridViewTextBoxColumn
    Friend WithEvents colDateRegistered As DataGridViewTextBoxColumn
End Class
