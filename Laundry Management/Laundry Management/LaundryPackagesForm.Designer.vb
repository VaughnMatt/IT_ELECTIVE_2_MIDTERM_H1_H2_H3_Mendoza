<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LaundryPackagesForm
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
        Me.lblPackagesDescription = New System.Windows.Forms.Label()
        Me.lblPackageStatus = New System.Windows.Forms.Label()
        Me.lblPackagePrice = New System.Windows.Forms.Label()
        Me.lblPackageWeight = New System.Windows.Forms.Label()
        Me.lblPackageName = New System.Windows.Forms.Label()
        Me.lblPackageInformation = New System.Windows.Forms.Label()
        Me.lblSearchPackage = New System.Windows.Forms.Label()
        Me.lblPackagesTitle = New System.Windows.Forms.Label()
        Me.txtSearchPackage = New System.Windows.Forms.TextBox()
        Me.txtPackageWeight = New System.Windows.Forms.TextBox()
        Me.txtPackageName = New System.Windows.Forms.TextBox()
        Me.btnSearchPackage = New System.Windows.Forms.Button()
        Me.btnDeletePackage = New System.Windows.Forms.Button()
        Me.btnUpdatePackage = New System.Windows.Forms.Button()
        Me.btnAddPackage = New System.Windows.Forms.Button()
        Me.dgvPackages = New System.Windows.Forms.DataGridView()
        Me.colPackageID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPackageName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colWeight = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtPackagePrice = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        CType(Me.dgvPackages, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPackagesDescription
        '
        Me.lblPackagesDescription.AutoSize = True
        Me.lblPackagesDescription.Location = New System.Drawing.Point(34, 34)
        Me.lblPackagesDescription.Name = "lblPackagesDescription"
        Me.lblPackagesDescription.Size = New System.Drawing.Size(281, 16)
        Me.lblPackagesDescription.TabIndex = 0
        Me.lblPackagesDescription.Text = "Manage laundry weight packages and pricing."
        '
        'lblPackageStatus
        '
        Me.lblPackageStatus.AutoSize = True
        Me.lblPackageStatus.Location = New System.Drawing.Point(34, 478)
        Me.lblPackageStatus.Name = "lblPackageStatus"
        Me.lblPackageStatus.Size = New System.Drawing.Size(44, 16)
        Me.lblPackageStatus.TabIndex = 1
        Me.lblPackageStatus.Text = "Status"
        '
        'lblPackagePrice
        '
        Me.lblPackagePrice.AutoSize = True
        Me.lblPackagePrice.Location = New System.Drawing.Point(520, 386)
        Me.lblPackagePrice.Name = "lblPackagePrice"
        Me.lblPackagePrice.Size = New System.Drawing.Size(38, 16)
        Me.lblPackagePrice.TabIndex = 2
        Me.lblPackagePrice.Text = "Price"
        '
        'lblPackageWeight
        '
        Me.lblPackageWeight.AutoSize = True
        Me.lblPackageWeight.Location = New System.Drawing.Point(270, 386)
        Me.lblPackageWeight.Name = "lblPackageWeight"
        Me.lblPackageWeight.Size = New System.Drawing.Size(78, 16)
        Me.lblPackageWeight.TabIndex = 3
        Me.lblPackageWeight.Text = "Weight (KG)"
        '
        'lblPackageName
        '
        Me.lblPackageName.AutoSize = True
        Me.lblPackageName.Location = New System.Drawing.Point(34, 386)
        Me.lblPackageName.Name = "lblPackageName"
        Me.lblPackageName.Size = New System.Drawing.Size(102, 16)
        Me.lblPackageName.TabIndex = 4
        Me.lblPackageName.Text = "Package Name"
        '
        'lblPackageInformation
        '
        Me.lblPackageInformation.AutoSize = True
        Me.lblPackageInformation.Location = New System.Drawing.Point(34, 352)
        Me.lblPackageInformation.Name = "lblPackageInformation"
        Me.lblPackageInformation.Size = New System.Drawing.Size(166, 16)
        Me.lblPackageInformation.TabIndex = 5
        Me.lblPackageInformation.Text = "PACKAGE INFORMATION"
        '
        'lblSearchPackage
        '
        Me.lblSearchPackage.AutoSize = True
        Me.lblSearchPackage.Location = New System.Drawing.Point(34, 62)
        Me.lblSearchPackage.Name = "lblSearchPackage"
        Me.lblSearchPackage.Size = New System.Drawing.Size(108, 16)
        Me.lblSearchPackage.TabIndex = 6
        Me.lblSearchPackage.Text = "Search Package"
        '
        'lblPackagesTitle
        '
        Me.lblPackagesTitle.AutoSize = True
        Me.lblPackagesTitle.Location = New System.Drawing.Point(34, 18)
        Me.lblPackagesTitle.Name = "lblPackagesTitle"
        Me.lblPackagesTitle.Size = New System.Drawing.Size(147, 16)
        Me.lblPackagesTitle.TabIndex = 7
        Me.lblPackagesTitle.Text = "LAUNDRY PACKAGES"
        '
        'txtSearchPackage
        '
        Me.txtSearchPackage.Location = New System.Drawing.Point(37, 92)
        Me.txtSearchPackage.Name = "txtSearchPackage"
        Me.txtSearchPackage.Size = New System.Drawing.Size(100, 22)
        Me.txtSearchPackage.TabIndex = 8
        '
        'txtPackageWeight
        '
        Me.txtPackageWeight.Location = New System.Drawing.Point(273, 405)
        Me.txtPackageWeight.Name = "txtPackageWeight"
        Me.txtPackageWeight.Size = New System.Drawing.Size(100, 22)
        Me.txtPackageWeight.TabIndex = 9
        '
        'txtPackageName
        '
        Me.txtPackageName.Location = New System.Drawing.Point(37, 405)
        Me.txtPackageName.Name = "txtPackageName"
        Me.txtPackageName.Size = New System.Drawing.Size(100, 22)
        Me.txtPackageName.TabIndex = 10
        '
        'btnSearchPackage
        '
        Me.btnSearchPackage.Location = New System.Drawing.Point(164, 92)
        Me.btnSearchPackage.Name = "btnSearchPackage"
        Me.btnSearchPackage.Size = New System.Drawing.Size(75, 23)
        Me.btnSearchPackage.TabIndex = 11
        Me.btnSearchPackage.Text = "SEARCH"
        Me.btnSearchPackage.UseVisualStyleBackColor = True
        '
        'btnDeletePackage
        '
        Me.btnDeletePackage.Location = New System.Drawing.Point(366, 614)
        Me.btnDeletePackage.Name = "btnDeletePackage"
        Me.btnDeletePackage.Size = New System.Drawing.Size(75, 23)
        Me.btnDeletePackage.TabIndex = 12
        Me.btnDeletePackage.Text = "DELETE"
        Me.btnDeletePackage.UseVisualStyleBackColor = True
        '
        'btnUpdatePackage
        '
        Me.btnUpdatePackage.Location = New System.Drawing.Point(259, 614)
        Me.btnUpdatePackage.Name = "btnUpdatePackage"
        Me.btnUpdatePackage.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdatePackage.TabIndex = 13
        Me.btnUpdatePackage.Text = "UPDATE"
        Me.btnUpdatePackage.UseVisualStyleBackColor = True
        '
        'btnAddPackage
        '
        Me.btnAddPackage.Location = New System.Drawing.Point(164, 614)
        Me.btnAddPackage.Name = "btnAddPackage"
        Me.btnAddPackage.Size = New System.Drawing.Size(75, 23)
        Me.btnAddPackage.TabIndex = 14
        Me.btnAddPackage.Text = "ADD"
        Me.btnAddPackage.UseVisualStyleBackColor = True
        '
        'dgvPackages
        '
        Me.dgvPackages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPackages.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colPackageID, Me.colPackageName, Me.colWeight, Me.colPrice, Me.colStatus})
        Me.dgvPackages.Location = New System.Drawing.Point(37, 128)
        Me.dgvPackages.Name = "dgvPackages"
        Me.dgvPackages.RowHeadersWidth = 51
        Me.dgvPackages.RowTemplate.Height = 24
        Me.dgvPackages.Size = New System.Drawing.Size(453, 150)
        Me.dgvPackages.TabIndex = 15
        '
        'colPackageID
        '
        Me.colPackageID.HeaderText = "Package ID"
        Me.colPackageID.MinimumWidth = 6
        Me.colPackageID.Name = "colPackageID"
        Me.colPackageID.Width = 125
        '
        'colPackageName
        '
        Me.colPackageName.HeaderText = "Package"
        Me.colPackageName.MinimumWidth = 6
        Me.colPackageName.Name = "colPackageName"
        Me.colPackageName.Width = 125
        '
        'colWeight
        '
        Me.colWeight.HeaderText = "Weight"
        Me.colWeight.MinimumWidth = 6
        Me.colWeight.Name = "colWeight"
        Me.colWeight.Width = 125
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
        'txtPackagePrice
        '
        Me.txtPackagePrice.Location = New System.Drawing.Point(518, 405)
        Me.txtPackagePrice.Name = "txtPackagePrice"
        Me.txtPackagePrice.Size = New System.Drawing.Size(100, 22)
        Me.txtPackagePrice.TabIndex = 16
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Available", "", "Unavailable"})
        Me.ComboBox1.Location = New System.Drawing.Point(37, 497)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(112, 24)
        Me.ComboBox1.TabIndex = 17
        '
        'LaundryPackagesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 694)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.txtPackagePrice)
        Me.Controls.Add(Me.dgvPackages)
        Me.Controls.Add(Me.btnAddPackage)
        Me.Controls.Add(Me.btnUpdatePackage)
        Me.Controls.Add(Me.btnDeletePackage)
        Me.Controls.Add(Me.btnSearchPackage)
        Me.Controls.Add(Me.txtPackageName)
        Me.Controls.Add(Me.txtPackageWeight)
        Me.Controls.Add(Me.txtSearchPackage)
        Me.Controls.Add(Me.lblPackagesTitle)
        Me.Controls.Add(Me.lblSearchPackage)
        Me.Controls.Add(Me.lblPackageInformation)
        Me.Controls.Add(Me.lblPackageName)
        Me.Controls.Add(Me.lblPackageWeight)
        Me.Controls.Add(Me.lblPackagePrice)
        Me.Controls.Add(Me.lblPackageStatus)
        Me.Controls.Add(Me.lblPackagesDescription)
        Me.Name = "LaundryPackagesForm"
        Me.Text = "LAUNDRY PACKAGES"
        CType(Me.dgvPackages, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPackagesDescription As Label
    Friend WithEvents lblPackageStatus As Label
    Friend WithEvents lblPackagePrice As Label
    Friend WithEvents lblPackageWeight As Label
    Friend WithEvents lblPackageName As Label
    Friend WithEvents lblPackageInformation As Label
    Friend WithEvents lblSearchPackage As Label
    Friend WithEvents lblPackagesTitle As Label
    Friend WithEvents txtSearchPackage As TextBox
    Friend WithEvents txtPackageWeight As TextBox
    Friend WithEvents txtPackageName As TextBox
    Friend WithEvents btnSearchPackage As Button
    Friend WithEvents btnDeletePackage As Button
    Friend WithEvents btnUpdatePackage As Button
    Friend WithEvents btnAddPackage As Button
    Friend WithEvents dgvPackages As DataGridView
    Friend WithEvents colPackageID As DataGridViewTextBoxColumn
    Friend WithEvents colPackageName As DataGridViewTextBoxColumn
    Friend WithEvents colWeight As DataGridViewTextBoxColumn
    Friend WithEvents colPrice As DataGridViewTextBoxColumn
    Friend WithEvents colStatus As DataGridViewTextBoxColumn
    Friend WithEvents txtPackagePrice As TextBox
    Friend WithEvents ComboBox1 As ComboBox
End Class
