Public Class Form1

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

    Dim username As String = txtUsername.Text.Trim()
    Dim password As String = txtPassword.Text

    If username = "owner" AndAlso password = "owner123" Then

        Dim dashboard As New MainDashboardForm()
        dashboard.UserRole = "Owner"
        dashboard.Show()

        Me.Hide()

    ElseIf username = "staff" AndAlso password = "staff123" Then

        Dim dashboard As New MainDashboardForm()
        dashboard.UserRole = "Staff"
        dashboard.Show()

        Me.Hide()

    Else

        lblMessage.Text = "Invalid username or password."

    End If

End Sub