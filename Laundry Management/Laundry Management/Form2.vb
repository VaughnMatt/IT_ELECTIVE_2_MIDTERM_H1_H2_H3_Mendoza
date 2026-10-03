Public Class MainDashboardForm

    'This receives the role from LoginForm
    Public UserRole As String

    Private Sub MainDashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Display user's name/role
        lblWelcome.Text = "Welcome, " & UserRole
        lblUserRole.Text = UserRole

        'Owner and Staff permissions
        If UserRole = "Owner" Then

            'Owner can see Today's Sales
            pnlTodaySales.Visible = True

        ElseIf UserRole = "Staff" Then

            'Staff cannot see Today's Sales
            pnlTodaySales.Visible = False

        End If

        'Temporary dashboard values
        lblTodayOrdersValue.Text = "12"
        lblPendingOrdersValue.Text = "5"
        lblCompletedOrdersValue.Text = "7"
        lblCustomersTodayValue.Text = "10"

        'Load sample recent orders
        LoadRecentOrders()

    End Sub


    '========================================================
    ' RECENT LAUNDRY ORDERS
    '========================================================

    Private Sub LoadRecentOrders()

        dgvRecentOrders.Rows.Clear()

        dgvRecentOrders.Rows.Add(
            "ORD-00001",
            "Juan Dela Cruz",
            "Regular",
            "Washing"
        )

        dgvRecentOrders.Rows.Add(
            "ORD-00002",
            "Maria Santos",
            "Premium",
            "Drying"
        )

        dgvRecentOrders.Rows.Add(
            "ORD-00003",
            "Pedro Reyes",
            "Regular",
            "Completed"
        )

    End Sub


    '========================================================
    ' NEW LAUNDRY
    '========================================================

    Private Sub btnNewLaundry_Click(sender As Object, e As EventArgs) Handles btnNewLaundry.Click

        Dim laundryForm As New LaundryTransactionForm()

        laundryForm.ShowDialog()

    End Sub


    '========================================================
    ' DASHBOARD BUTTON
    '========================================================

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click

        'Already on Dashboard
        MessageBox.Show("You are already on the Dashboard.")

    End Sub


    '========================================================
    ' ORDERS
    '========================================================

    Private Sub btnOrders_Click(sender As Object, e As EventArgs) Handles btnOrders.Click

        MessageBox.Show("Orders form will be added next.")

    End Sub


    '========================================================
    ' CUSTOMERS
    '========================================================

    Private Sub btnCustomers_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click

        MessageBox.Show("Customers form will be added next.")

    End Sub


    '========================================================
    ' PRODUCTS
    '========================================================

    Private Sub btnProducts_Click(sender As Object, e As EventArgs) Handles btnProducts.Click

        MessageBox.Show("Products form will be added next.")

    End Sub


    '========================================================
    ' LAUNDRY PACKAGES
    '========================================================

    Private Sub btnPackages_Click(sender As Object, e As EventArgs) Handles btnPackages.Click

        MessageBox.Show("Laundry Packages form will be added next.")

    End Sub


    '========================================================
    ' DRYING
    '========================================================

    Private Sub btnDrying_Click(sender As Object, e As EventArgs) Handles btnDrying.Click

        MessageBox.Show("Drying Options form will be added next.")

    End Sub


    '========================================================
    ' STAFF
    '========================================================

    Private Sub btnStaff_Click(sender As Object, e As EventArgs) Handles btnStaff.Click

        'Only Owner should manage staff
        If UserRole = "Owner" Then

            MessageBox.Show("Staff Management form will be added next.")

        Else

            MessageBox.Show("Only the Owner can access Staff Management.")

        End If

    End Sub


    '========================================================
    ' REPORTS
    '========================================================

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click

        If UserRole = "Owner" Then

            MessageBox.Show("Reports form will be added next.")

        Else

            MessageBox.Show("Only the Owner can access Reports.")

        End If

    End Sub


    '========================================================
    ' ACTIVITY LOGS
    '========================================================

    Private Sub btnActivityLogs_Click(sender As Object, e As EventArgs) Handles btnActivityLogs.Click

        If UserRole = "Owner" Then

            MessageBox.Show("Activity Logs form will be added next.")

        Else

            MessageBox.Show("Only the Owner can access Activity Logs.")

        End If

    End Sub


    '========================================================
    ' SETTINGS
    '========================================================

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click

        MessageBox.Show("Settings form will be added next.")

    End Sub


    '========================================================
    ' LOGOUT
    '========================================================

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        Dim result As DialogResult

        result = MessageBox.Show(
            "Are you sure you want to logout?",
            "Logout",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If result = DialogResult.Yes Then

            LoginForm.Show()

            Me.Close()

        End If

    End Sub

End Class