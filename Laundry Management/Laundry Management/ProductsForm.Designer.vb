<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductsForm
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
        Me.lblProductsTitle = New System.Windows.Forms.Label()
        Me.lblSearchProduct = New System.Windows.Forms.Label()
        Me.lblProductsDescription = New System.Windows.Forms.Label()
        Me.txtSearchProduct = New System.Windows.Forms.TextBox()
        Me.btnDeleteProduct = New System.Windows.Forms.Button()
        Me.btnSearchProduct = New System.Windows.Forms.Button()
        Me.btnUpdateProduct = New System.Windows.Forms.Button()
        Me.btnAddProduct = New System.Windows.Forms.Button()
        Me.dgvProducts = New System.Windows.Forms.DataGridView()
        Me.colProductID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colProductName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblProductName = New System.Windows.Forms.Label()
        Me.lblProductPrice = New System.Windows.Forms.Label()
        Me.lblProductCategory = New System.Windows.Forms.Label()
        Me.lblProductInformation = New System.Windows.Forms.Label()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.cmbProductCategory = New System.Windows.Forms.ComboBox()
        Me.txtProductPrice = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lblProductStatus = New System.Windows.Forms.Label()
        Me.cmbProductStatus = New System.Windows.Forms.ComboBox()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblProductsTitle
        '
        Me.lblProductsTitle.AutoSize = True
        Me.lblProductsTitle.Location = New System.Drawing.Point(64, 41)
        Me.lblProductsTitle.Name = "lblProductsTitle"
        Me.lblProductsTitle.Size = New System.Drawing.Size(83, 16)
        Me.lblProductsTitle.TabIndex = 0
        Me.lblProductsTitle.Text = "PRODUCTS"
        '
        'lblSearchProduct
        '
        Me.lblSearchProduct.AutoSize = True
        Me.lblSearchProduct.Location = New System.Drawing.Point(64, 110)
        Me.lblSearchProduct.Name = "lblSearchProduct"
        Me.lblSearchProduct.Size = New System.Drawing.Size(99, 16)
        Me.lblSearchProduct.TabIndex = 1
        Me.lblSearchProduct.Text = "Search Product"
        '
        'lblProductsDescription
        '
        Me.lblProductsDescription.AutoSize = True
        Me.lblProductsDescription.Location = New System.Drawing.Point(64, 69)
        Me.lblProductsDescription.Name = "lblProductsDescription"
        Me.lblProductsDescription.Size = New System.Drawing.Size(142, 16)
        Me.lblProductsDescription.TabIndex = 2
        Me.lblProductsDescription.Text = "lblProductsDescription"
        '
        'txtSearchProduct
        '
        Me.txtSearchProduct.Location = New System.Drawing.Point(67, 141)
        Me.txtSearchProduct.Name = "txtSearchProduct"
        Me.txtSearchProduct.Size = New System.Drawing.Size(100, 22)
        Me.txtSearchProduct.TabIndex = 3
        '
        'btnDeleteProduct
        '
        Me.btnDeleteProduct.Location = New System.Drawing.Point(442, 647)
        Me.btnDeleteProduct.Name = "btnDeleteProduct"
        Me.btnDeleteProduct.Size = New System.Drawing.Size(75, 23)
        Me.btnDeleteProduct.TabIndex = 4
        Me.btnDeleteProduct.Text = "DELETE"
        Me.btnDeleteProduct.UseVisualStyleBackColor = True
        '
        'btnSearchProduct
        '
        Me.btnSearchProduct.Location = New System.Drawing.Point(183, 140)
        Me.btnSearchProduct.Name = "btnSearchProduct"
        Me.btnSearchProduct.Size = New System.Drawing.Size(75, 23)
        Me.btnSearchProduct.TabIndex = 5
        Me.btnSearchProduct.Text = "SEARCH"
        Me.btnSearchProduct.UseVisualStyleBackColor = True
        '
        'btnUpdateProduct
        '
        Me.btnUpdateProduct.Location = New System.Drawing.Point(317, 647)
        Me.btnUpdateProduct.Name = "btnUpdateProduct"
        Me.btnUpdateProduct.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdateProduct.TabIndex = 6
        Me.btnUpdateProduct.Text = "UPDATE"
        Me.btnUpdateProduct.UseVisualStyleBackColor = True
        '
        'btnAddProduct
        '
        Me.btnAddProduct.Location = New System.Drawing.Point(198, 647)
        Me.btnAddProduct.Name = "btnAddProduct"
        Me.btnAddProduct.Size = New System.Drawing.Size(75, 23)
        Me.btnAddProduct.TabIndex = 7
        Me.btnAddProduct.Text = "ADD"
        Me.btnAddProduct.UseVisualStyleBackColor = True
        '
        'dgvProducts
        '
        Me.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProducts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colProductID, Me.colProductName, Me.colCategory, Me.colPrice, Me.colStatus})
        Me.dgvProducts.Location = New System.Drawing.Point(12, 199)
        Me.dgvProducts.Name = "dgvProducts"
        Me.dgvProducts.RowHeadersWidth = 51
        Me.dgvProducts.RowTemplate.Height = 24
        Me.dgvProducts.Size = New System.Drawing.Size(776, 177)
        Me.dgvProducts.TabIndex = 8
        '
        'colProductID
        '
        Me.colProductID.HeaderText = "Product ID"
        Me.colProductID.MinimumWidth = 6
        Me.colProductID.Name = "colProductID"
        Me.colProductID.Width = 125
        '
        'colProductName
        '
        Me.colProductName.HeaderText = "Product Name"
        Me.colProductName.MinimumWidth = 6
        Me.colProductName.Name = "colProductName"
        Me.colProductName.Width = 125
        '
        'colCategory
        '
        Me.colCategory.HeaderText = "Category"
        Me.colCategory.MinimumWidth = 6
        Me.colCategory.Name = "colCategory"
        Me.colCategory.Width = 125
        '
        'colPrice
        '
        Me.colPrice.HeaderText = "Price"
        Me.colPrice.MinimumWidth = 6
        Me.colPrice.Name = "colPrice"
        Me.colPrice.Width = 125
        '
        'colStatus
        '
        Me.colStatus.HeaderText = "Status"
        Me.colStatus.MinimumWidth = 6
        Me.colStatus.Name = "colStatus"
        Me.colStatus.Width = 125
        '
        'lblProductName
        '
        Me.lblProductName.AutoSize = True
        Me.lblProductName.Location = New System.Drawing.Point(82, 459)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Size = New System.Drawing.Size(93, 16)
        Me.lblProductName.TabIndex = 9
        Me.lblProductName.Text = "Product Name"
        '
        'lblProductPrice
        '
        Me.lblProductPrice.AutoSize = True
        Me.lblProductPrice.Location = New System.Drawing.Point(426, 459)
        Me.lblProductPrice.Name = "lblProductPrice"
        Me.lblProductPrice.Size = New System.Drawing.Size(38, 16)
        Me.lblProductPrice.TabIndex = 10
        Me.lblProductPrice.Text = "Price"
        '
        'lblProductCategory
        '
        Me.lblProductCategory.AutoSize = True
        Me.lblProductCategory.Location = New System.Drawing.Point(249, 459)
        Me.lblProductCategory.Name = "lblProductCategory"
        Me.lblProductCategory.Size = New System.Drawing.Size(62, 16)
        Me.lblProductCategory.TabIndex = 11
        Me.lblProductCategory.Text = "Category"
        '
        'lblProductInformation
        '
        Me.lblProductInformation.AutoSize = True
        Me.lblProductInformation.Location = New System.Drawing.Point(82, 405)
        Me.lblProductInformation.Name = "lblProductInformation"
        Me.lblProductInformation.Size = New System.Drawing.Size(170, 16)
        Me.lblProductInformation.TabIndex = 12
        Me.lblProductInformation.Text = "PRODUCT INFORMATION"
        '
        'txtProductName
        '
        Me.txtProductName.Location = New System.Drawing.Point(85, 496)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(100, 22)
        Me.txtProductName.TabIndex = 13
        '
        'cmbProductCategory
        '
        Me.cmbProductCategory.FormattingEnabled = True
        Me.cmbProductCategory.Items.AddRange(New Object() {"Detergent", "", "Fabcon"})
        Me.cmbProductCategory.Location = New System.Drawing.Point(252, 494)
        Me.cmbProductCategory.Name = "cmbProductCategory"
        Me.cmbProductCategory.Size = New System.Drawing.Size(121, 24)
        Me.cmbProductCategory.TabIndex = 14
        '
        'txtProductPrice
        '
        Me.txtProductPrice.Location = New System.Drawing.Point(451, 496)
        Me.txtProductPrice.Name = "txtProductPrice"
        Me.txtProductPrice.Size = New System.Drawing.Size(100, 22)
        Me.txtProductPrice.TabIndex = 15
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Detergent", "", "Fabcon"})
        Me.ComboBox1.Location = New System.Drawing.Point(396, 307)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox1.TabIndex = 16
        '
        'lblProductStatus
        '
        Me.lblProductStatus.AutoSize = True
        Me.lblProductStatus.Location = New System.Drawing.Point(82, 542)
        Me.lblProductStatus.Name = "lblProductStatus"
        Me.lblProductStatus.Size = New System.Drawing.Size(44, 16)
        Me.lblProductStatus.TabIndex = 17
        Me.lblProductStatus.Text = "Status"
        '
        'cmbProductStatus
        '
        Me.cmbProductStatus.FormattingEnabled = True
        Me.cmbProductStatus.Items.AddRange(New Object() {"Available", "", "Unavailable"})
        Me.cmbProductStatus.Location = New System.Drawing.Point(85, 571)
        Me.cmbProductStatus.Name = "cmbProductStatus"
        Me.cmbProductStatus.Size = New System.Drawing.Size(121, 24)
        Me.cmbProductStatus.TabIndex = 19
        '
        'ProductsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 682)
        Me.Controls.Add(Me.cmbProductStatus)
        Me.Controls.Add(Me.lblProductStatus)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.txtProductPrice)
        Me.Controls.Add(Me.cmbProductCategory)
        Me.Controls.Add(Me.txtProductName)
        Me.Controls.Add(Me.lblProductInformation)
        Me.Controls.Add(Me.lblProductCategory)
        Me.Controls.Add(Me.lblProductPrice)
        Me.Controls.Add(Me.lblProductName)
        Me.Controls.Add(Me.dgvProducts)
        Me.Controls.Add(Me.btnAddProduct)
        Me.Controls.Add(Me.btnUpdateProduct)
        Me.Controls.Add(Me.btnSearchProduct)
        Me.Controls.Add(Me.btnDeleteProduct)
        Me.Controls.Add(Me.txtSearchProduct)
        Me.Controls.Add(Me.lblProductsDescription)
        Me.Controls.Add(Me.lblSearchProduct)
        Me.Controls.Add(Me.lblProductsTitle)
        Me.Name = "ProductsForm"
        Me.Text = "PRODUCTS"
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblProductsTitle As Label
    Friend WithEvents lblSearchProduct As Label
    Friend WithEvents lblProductsDescription As Label
    Friend WithEvents txtSearchProduct As TextBox
    Friend WithEvents btnDeleteProduct As Button
    Friend WithEvents btnSearchProduct As Button
    Friend WithEvents btnUpdateProduct As Button
    Friend WithEvents btnAddProduct As Button
    Friend WithEvents dgvProducts As DataGridView
    Friend WithEvents colProductID As DataGridViewTextBoxColumn
    Friend WithEvents colProductName As DataGridViewTextBoxColumn
    Friend WithEvents colCategory As DataGridViewTextBoxColumn
    Friend WithEvents colPrice As DataGridViewTextBoxColumn
    Friend WithEvents colStatus As DataGridViewTextBoxColumn
    Friend WithEvents lblProductName As Label
    Friend WithEvents lblProductPrice As Label
    Friend WithEvents lblProductCategory As Label
    Friend WithEvents lblProductInformation As Label
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents cmbProductCategory As ComboBox
    Friend WithEvents txtProductPrice As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents lblProductStatus As Label
    Friend WithEvents cmbProductStatus As ComboBox
End Class
