<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrdersForm
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
        Me.lblOrdersTitle = New System.Windows.Forms.Label()
        Me.lblOrdersDescription = New System.Windows.Forms.Label()
        Me.lblSearchOrder = New System.Windows.Forms.Label()
        Me.txtSearchOrder = New System.Windows.Forms.TextBox()
        Me.btnSearchOrder = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.cmbOrderStatus = New System.Windows.Forms.ComboBox()
        Me.lblOrderFrom = New System.Windows.Forms.Label()
        Me.dtpOrderFrom = New System.Windows.Forms.DateTimePicker()
        Me.lblOrderTo = New System.Windows.Forms.Label()
        Me.dtpOrderTo = New System.Windows.Forms.DateTimePicker()
        Me.btnFilterOrders = New System.Windows.Forms.Button()
        Me.dgvOrders = New System.Windows.Forms.DataGridView()
        Me.btnCancelOrder = New System.Windows.Forms.Button()
        Me.btnViewOrder = New System.Windows.Forms.Button()
        Me.btnUpdateOrder = New System.Windows.Forms.Button()
        Me.colOrderNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCustomer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colService = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colWeight = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblOrdersTitle
        '
        Me.lblOrdersTitle.AutoSize = True
        Me.lblOrdersTitle.Location = New System.Drawing.Point(78, 38)
        Me.lblOrdersTitle.Name = "lblOrdersTitle"
        Me.lblOrdersTitle.Size = New System.Drawing.Size(68, 16)
        Me.lblOrdersTitle.TabIndex = 0
        Me.lblOrdersTitle.Text = " ORDERS"
        '
        'lblOrdersDescription
        '
        Me.lblOrdersDescription.AutoSize = True
        Me.lblOrdersDescription.Location = New System.Drawing.Point(78, 70)
        Me.lblOrdersDescription.Name = "lblOrdersDescription"
        Me.lblOrdersDescription.Size = New System.Drawing.Size(239, 16)
        Me.lblOrdersDescription.TabIndex = 1
        Me.lblOrdersDescription.Text = "Manage and monitor all laundry orders."
        '
        'lblSearchOrder
        '
        Me.lblSearchOrder.AutoSize = True
        Me.lblSearchOrder.Location = New System.Drawing.Point(84, 124)
        Me.lblSearchOrder.Name = "lblSearchOrder"
        Me.lblSearchOrder.Size = New System.Drawing.Size(90, 16)
        Me.lblSearchOrder.TabIndex = 2
        Me.lblSearchOrder.Text = " Search Order"
        '
        'txtSearchOrder
        '
        Me.txtSearchOrder.Location = New System.Drawing.Point(81, 143)
        Me.txtSearchOrder.Name = "txtSearchOrder"
        Me.txtSearchOrder.Size = New System.Drawing.Size(155, 22)
        Me.txtSearchOrder.TabIndex = 3
        '
        'btnSearchOrder
        '
        Me.btnSearchOrder.Location = New System.Drawing.Point(255, 142)
        Me.btnSearchOrder.Name = "btnSearchOrder"
        Me.btnSearchOrder.Size = New System.Drawing.Size(75, 23)
        Me.btnSearchOrder.TabIndex = 4
        Me.btnSearchOrder.Text = "SEARCH"
        Me.btnSearchOrder.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(84, 197)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(62, 16)
        Me.lblStatus.TabIndex = 5
        Me.lblStatus.Text = "STATUS"
        '
        'cmbOrderStatus
        '
        Me.cmbOrderStatus.FormattingEnabled = True
        Me.cmbOrderStatus.Items.AddRange(New Object() {"ALL STATUSES", "", "PENDING", "", "WASHING", "", "DRYING", "", "READY FOR PICKUP", "", "COMPLETED", "", "CANCELLED"})
        Me.cmbOrderStatus.Location = New System.Drawing.Point(87, 225)
        Me.cmbOrderStatus.Name = "cmbOrderStatus"
        Me.cmbOrderStatus.Size = New System.Drawing.Size(121, 24)
        Me.cmbOrderStatus.TabIndex = 6
        '
        'lblOrderFrom
        '
        Me.lblOrderFrom.AutoSize = True
        Me.lblOrderFrom.Location = New System.Drawing.Point(252, 197)
        Me.lblOrderFrom.Name = "lblOrderFrom"
        Me.lblOrderFrom.Size = New System.Drawing.Size(86, 16)
        Me.lblOrderFrom.TabIndex = 7
        Me.lblOrderFrom.Text = "FROM DATE"
        '
        'dtpOrderFrom
        '
        Me.dtpOrderFrom.Location = New System.Drawing.Point(255, 223)
        Me.dtpOrderFrom.Name = "dtpOrderFrom"
        Me.dtpOrderFrom.Size = New System.Drawing.Size(200, 22)
        Me.dtpOrderFrom.TabIndex = 8
        '
        'lblOrderTo
        '
        Me.lblOrderTo.AutoSize = True
        Me.lblOrderTo.Location = New System.Drawing.Point(525, 197)
        Me.lblOrderTo.Name = "lblOrderTo"
        Me.lblOrderTo.Size = New System.Drawing.Size(66, 16)
        Me.lblOrderTo.TabIndex = 9
        Me.lblOrderTo.Text = "TO DATE"
        '
        'dtpOrderTo
        '
        Me.dtpOrderTo.Location = New System.Drawing.Point(528, 223)
        Me.dtpOrderTo.Name = "dtpOrderTo"
        Me.dtpOrderTo.Size = New System.Drawing.Size(200, 22)
        Me.dtpOrderTo.TabIndex = 10
        '
        'btnFilterOrders
        '
        Me.btnFilterOrders.Location = New System.Drawing.Point(528, 272)
        Me.btnFilterOrders.Name = "btnFilterOrders"
        Me.btnFilterOrders.Size = New System.Drawing.Size(75, 23)
        Me.btnFilterOrders.TabIndex = 11
        Me.btnFilterOrders.Text = "FILTER"
        Me.btnFilterOrders.UseVisualStyleBackColor = True
        '
        'dgvOrders
        '
        Me.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOrders.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colOrderNumber, Me.colCustomer, Me.colService, Me.colWeight, Me.colTotal, Me.colStatus, Me.colDate})
        Me.dgvOrders.Location = New System.Drawing.Point(12, 310)
        Me.dgvOrders.Name = "dgvOrders"
        Me.dgvOrders.RowHeadersWidth = 51
        Me.dgvOrders.RowTemplate.Height = 24
        Me.dgvOrders.Size = New System.Drawing.Size(927, 237)
        Me.dgvOrders.TabIndex = 12
        '
        'btnCancelOrder
        '
        Me.btnCancelOrder.Location = New System.Drawing.Point(355, 624)
        Me.btnCancelOrder.Name = "btnCancelOrder"
        Me.btnCancelOrder.Size = New System.Drawing.Size(91, 32)
        Me.btnCancelOrder.TabIndex = 13
        Me.btnCancelOrder.Text = "CANCEL"
        Me.btnCancelOrder.UseVisualStyleBackColor = True
        '
        'btnViewOrder
        '
        Me.btnViewOrder.Location = New System.Drawing.Point(226, 624)
        Me.btnViewOrder.Name = "btnViewOrder"
        Me.btnViewOrder.Size = New System.Drawing.Size(91, 32)
        Me.btnViewOrder.TabIndex = 14
        Me.btnViewOrder.Text = "VIEW"
        Me.btnViewOrder.UseVisualStyleBackColor = True
        '
        'btnUpdateOrder
        '
        Me.btnUpdateOrder.Location = New System.Drawing.Point(481, 624)
        Me.btnUpdateOrder.Name = "btnUpdateOrder"
        Me.btnUpdateOrder.Size = New System.Drawing.Size(91, 32)
        Me.btnUpdateOrder.TabIndex = 15
        Me.btnUpdateOrder.Text = "UPDATE"
        Me.btnUpdateOrder.UseVisualStyleBackColor = True
        '
        'colOrderNumber
        '
        Me.colOrderNumber.HeaderText = "Order No."
        Me.colOrderNumber.MinimumWidth = 6
        Me.colOrderNumber.Name = "colOrderNumber"
        Me.colOrderNumber.Width = 125
        '
        'colCustomer
        '
        Me.colCustomer.HeaderText = "Customer"
        Me.colCustomer.MinimumWidth = 6
        Me.colCustomer.Name = "colCustomer"
        Me.colCustomer.Width = 125
        '
        'colService
        '
        Me.colService.HeaderText = "Service"
        Me.colService.MinimumWidth = 6
        Me.colService.Name = "colService"
        Me.colService.Width = 125
        '
        'colWeight
        '
        Me.colWeight.HeaderText = "Weight"
        Me.colWeight.MinimumWidth = 6
        Me.colWeight.Name = "colWeight"
        Me.colWeight.Width = 125
        '
        'colTotal
        '
        Me.colTotal.HeaderText = "Total"
        Me.colTotal.MinimumWidth = 6
        Me.colTotal.Name = "colTotal"
        Me.colTotal.Width = 125
        '
        'colStatus
        '
        Me.colStatus.HeaderText = "Status"
        Me.colStatus.MinimumWidth = 6
        Me.colStatus.Name = "colStatus"
        Me.colStatus.Width = 125
        '
        'colDate
        '
        Me.colDate.HeaderText = "Date"
        Me.colDate.MinimumWidth = 6
        Me.colDate.Name = "colDate"
        Me.colDate.Width = 125
        '
        'OrdersForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(967, 668)
        Me.Controls.Add(Me.btnUpdateOrder)
        Me.Controls.Add(Me.btnViewOrder)
        Me.Controls.Add(Me.btnCancelOrder)
        Me.Controls.Add(Me.dgvOrders)
        Me.Controls.Add(Me.btnFilterOrders)
        Me.Controls.Add(Me.dtpOrderTo)
        Me.Controls.Add(Me.lblOrderTo)
        Me.Controls.Add(Me.dtpOrderFrom)
        Me.Controls.Add(Me.lblOrderFrom)
        Me.Controls.Add(Me.cmbOrderStatus)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnSearchOrder)
        Me.Controls.Add(Me.txtSearchOrder)
        Me.Controls.Add(Me.lblSearchOrder)
        Me.Controls.Add(Me.lblOrdersDescription)
        Me.Controls.Add(Me.lblOrdersTitle)
        Me.Name = "OrdersForm"
        Me.Text = "Order"
        CType(Me.dgvOrders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblOrdersTitle As Label
    Friend WithEvents lblOrdersDescription As Label
    Friend WithEvents lblSearchOrder As Label
    Friend WithEvents txtSearchOrder As TextBox
    Friend WithEvents btnSearchOrder As Button
    Friend WithEvents lblStatus As Label
    Friend WithEvents cmbOrderStatus As ComboBox
    Friend WithEvents lblOrderFrom As Label
    Friend WithEvents dtpOrderFrom As DateTimePicker
    Friend WithEvents lblOrderTo As Label
    Friend WithEvents dtpOrderTo As DateTimePicker
    Friend WithEvents btnFilterOrders As Button
    Friend WithEvents dgvOrders As DataGridView
    Friend WithEvents btnCancelOrder As Button
    Friend WithEvents btnViewOrder As Button
    Friend WithEvents btnUpdateOrder As Button
    Friend WithEvents colOrderNumber As DataGridViewTextBoxColumn
    Friend WithEvents colCustomer As DataGridViewTextBoxColumn
    Friend WithEvents colService As DataGridViewTextBoxColumn
    Friend WithEvents colWeight As DataGridViewTextBoxColumn
    Friend WithEvents colTotal As DataGridViewTextBoxColumn
    Friend WithEvents colStatus As DataGridViewTextBoxColumn
    Friend WithEvents colDate As DataGridViewTextBoxColumn
End Class
