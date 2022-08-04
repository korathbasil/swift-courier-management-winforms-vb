Public Class Admin
    Dim DashboardPage As AdminDashboard

    Dim OrdersPage As AdminOrders

    Dim UserManagementPage As AdminUserManagement
    Dim AddUserPage As AdminAddUser
    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadOrdersPage()
    End Sub

    Private Sub LoadDashboardPage()
        DashboardPage = New AdminDashboard

        AdminAppPanel.Controls.Clear()
        AdminAppPanel.Controls.Add(DashboardPage)
    End Sub

    Public Sub LoadOrdersPage()
        OrdersPage = New AdminOrders

        AdminAppPanel.Controls.Clear()
        AdminAppPanel.Controls.Add(OrdersPage)
    End Sub

    Public Sub LoadUserManagementPage()
        UserManagementPage = New AdminUserManagement

        AdminAppPanel.Controls.Clear()
        AdminAppPanel.Controls.Add(UserManagementPage)
    End Sub

    Public Sub LoadAddUserPage()
        AddUserPage = New AdminAddUser

        AdminAppPanel.Controls.Clear()
        AdminAppPanel.Controls.Add(AddUserPage)
    End Sub

    Private Sub DashboardLink_Click(sender As Object, e As EventArgs) 
        LoadDashboardPage()
    End Sub

    Private Sub OrdersLink_Click(sender As Object, e As EventArgs) Handles OrdersLink.Click
        LoadOrdersPage()
    End Sub

    Private Sub UsersLink_Click(sender As Object, e As EventArgs) Handles UsersLink.Click
        LoadUserManagementPage()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.LoadUserPage()
    End Sub
End Class