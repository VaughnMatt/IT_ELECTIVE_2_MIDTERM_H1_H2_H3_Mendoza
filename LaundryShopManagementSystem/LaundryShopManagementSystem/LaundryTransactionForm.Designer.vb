<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLaundryTransactionForm
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
        Me.pnlStepIndicator = New System.Windows.Forms.Panel()
        Me.txtCustomerName = New System.Windows.Forms.Panel()
        Me.lblCustomerTitle = New System.Windows.Forms.Label()
        Me.lblCustomerSubtitle = New System.Windows.Forms.Label()
        Me.lblOrderNumber = New System.Windows.Forms.Label()
        Me.lblOrderNumberValue = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblDateValue = New System.Windows.Forms.Label()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblContactNumber = New System.Windows.Forms.Label()
        Me.txtContactNumber = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.txtCustomerName.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlStepIndicator
        '
        Me.pnlStepIndicator.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlStepIndicator.Location = New System.Drawing.Point(0, 0)
        Me.pnlStepIndicator.Name = "pnlStepIndicator"
        Me.pnlStepIndicator.Size = New System.Drawing.Size(800, 61)
        Me.pnlStepIndicator.TabIndex = 0
        '
        'txtCustomerName
        '
        Me.txtCustomerName.BackColor = System.Drawing.Color.White
        Me.txtCustomerName.Controls.Add(Me.btnNext)
        Me.txtCustomerName.Controls.Add(Me.btnCancel)
        Me.txtCustomerName.Controls.Add(Me.txtContactNumber)
        Me.txtCustomerName.Controls.Add(Me.lblContactNumber)
        Me.txtCustomerName.Controls.Add(Me.TextBox1)
        Me.txtCustomerName.Controls.Add(Me.lblCustomerName)
        Me.txtCustomerName.Controls.Add(Me.lblDateValue)
        Me.txtCustomerName.Controls.Add(Me.lblDate)
        Me.txtCustomerName.Controls.Add(Me.lblOrderNumberValue)
        Me.txtCustomerName.Controls.Add(Me.lblOrderNumber)
        Me.txtCustomerName.Controls.Add(Me.lblCustomerSubtitle)
        Me.txtCustomerName.Controls.Add(Me.lblCustomerTitle)
        Me.txtCustomerName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCustomerName.Location = New System.Drawing.Point(0, 61)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Padding = New System.Windows.Forms.Padding(40, 30, 40, 30)
        Me.txtCustomerName.Size = New System.Drawing.Size(800, 579)
        Me.txtCustomerName.TabIndex = 1
        '
        'lblCustomerTitle
        '
        Me.lblCustomerTitle.AutoSize = True
        Me.lblCustomerTitle.Location = New System.Drawing.Point(12, 15)
        Me.lblCustomerTitle.Name = "lblCustomerTitle"
        Me.lblCustomerTitle.Size = New System.Drawing.Size(159, 16)
        Me.lblCustomerTitle.TabIndex = 0
        Me.lblCustomerTitle.Text = "NEW LAUNDRY ORDER"
        '
        'lblCustomerSubtitle
        '
        Me.lblCustomerSubtitle.AutoSize = True
        Me.lblCustomerSubtitle.Location = New System.Drawing.Point(12, 50)
        Me.lblCustomerSubtitle.Name = "lblCustomerSubtitle"
        Me.lblCustomerSubtitle.Size = New System.Drawing.Size(180, 16)
        Me.lblCustomerSubtitle.TabIndex = 1
        Me.lblCustomerSubtitle.Text = "CUSTOMER INFORMATION"
        '
        'lblOrderNumber
        '
        Me.lblOrderNumber.AutoSize = True
        Me.lblOrderNumber.Location = New System.Drawing.Point(12, 87)
        Me.lblOrderNumber.Name = "lblOrderNumber"
        Me.lblOrderNumber.Size = New System.Drawing.Size(92, 16)
        Me.lblOrderNumber.TabIndex = 2
        Me.lblOrderNumber.Text = "Order Number"
        '
        'lblOrderNumberValue
        '
        Me.lblOrderNumberValue.AutoSize = True
        Me.lblOrderNumberValue.Location = New System.Drawing.Point(12, 125)
        Me.lblOrderNumberValue.Name = "lblOrderNumberValue"
        Me.lblOrderNumberValue.Size = New System.Drawing.Size(76, 16)
        Me.lblOrderNumberValue.TabIndex = 3
        Me.lblOrderNumberValue.Text = "ORD-00001"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(12, 165)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(36, 16)
        Me.lblDate.TabIndex = 4
        Me.lblDate.Text = "Date"
        '
        'lblDateValue
        '
        Me.lblDateValue.AutoSize = True
        Me.lblDateValue.Location = New System.Drawing.Point(12, 196)
        Me.lblDateValue.Name = "lblDateValue"
        Me.lblDateValue.Size = New System.Drawing.Size(182, 16)
        Me.lblDateValue.TabIndex = 5
        Me.lblDateValue.Text = "September 20, 2026 - 4:30 PM"
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Location = New System.Drawing.Point(12, 231)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(104, 16)
        Me.lblCustomerName.TabIndex = 6
        Me.lblCustomerName.Text = "Customer Name"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(15, 250)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(176, 22)
        Me.TextBox1.TabIndex = 7
        '
        'lblContactNumber
        '
        Me.lblContactNumber.AutoSize = True
        Me.lblContactNumber.Location = New System.Drawing.Point(12, 284)
        Me.lblContactNumber.Name = "lblContactNumber"
        Me.lblContactNumber.Size = New System.Drawing.Size(106, 16)
        Me.lblContactNumber.TabIndex = 8
        Me.lblContactNumber.Text = "Contact  Number"
        '
        'txtContactNumber
        '
        Me.txtContactNumber.Location = New System.Drawing.Point(15, 303)
        Me.txtContactNumber.Name = "txtContactNumber"
        Me.txtContactNumber.Size = New System.Drawing.Size(176, 22)
        Me.txtContactNumber.TabIndex = 9
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(15, 384)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(116, 384)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 11
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'frmLaundryTransactionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 640)
        Me.Controls.Add(Me.txtCustomerName)
        Me.Controls.Add(Me.pnlStepIndicator)
        Me.Name = "frmLaundryTransactionForm"
        Me.Text = "LaundryTransactionForm"
        Me.txtCustomerName.ResumeLayout(False)
        Me.txtCustomerName.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlStepIndicator As Panel
    Friend WithEvents txtCustomerName As Panel
    Friend WithEvents lblOrderNumberValue As Label
    Friend WithEvents lblOrderNumber As Label
    Friend WithEvents lblCustomerSubtitle As Label
    Friend WithEvents lblCustomerTitle As Label
    Friend WithEvents lblDateValue As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblCustomerName As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtContactNumber As TextBox
    Friend WithEvents lblContactNumber As Label
End Class
