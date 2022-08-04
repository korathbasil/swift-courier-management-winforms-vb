Public Class Staff
    Dim DashboardPage As StaffDashboard

    Public SelectedOrderId As Integer
    Dim OrdersPage As StaffOrders
    Dim NewOrderPage As StaffNewOrder
    Dim EditOrderPage As StaffEditOrder
    Dim AddPointPage As StaffAddPoint
    Dim AddDelayPage As StaffAddDelay
    Private Sub Staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadOrdersPage()
    End Sub

    Private Sub LoadDashboardPage()
        DashboardPage = New StaffDashboard

        StaffAppPanel.Controls.Clear()
        StaffAppPanel.Controls.Add(DashboardPage)
    End Sub

    Public Sub LoadOrdersPage()
        OrdersPage = New StaffOrders

        StaffAppPanel.Controls.Clear()
        StaffAppPanel.Controls.Add(OrdersPage)
    End Sub

    Public Sub LoadEditOrderPage()
        EditOrderPage = New StaffEditOrder

        StaffAppPanel.Controls.Clear()
        StaffAppPanel.Controls.Add(EditOrderPage)
    End Sub
    Public Sub LoadAddPointPage()
        AddPointPage = New StaffAddPoint

        StaffAppPanel.Controls.Clear()
        StaffAppPanel.Controls.Add(AddPointPage)
    End Sub
    Public Sub LoadAddDelayPage()
        AddDelayPage = New StaffAddDelay

        StaffAppPanel.Controls.Clear()
        StaffAppPanel.Controls.Add(AddDelayPage)
    End Sub
    Public Sub LoadNewOrderPage()
        NewOrderPage = New StaffNewOrder

        StaffAppPanel.Controls.Clear()
        StaffAppPanel.Controls.Add(NewOrderPage)
    End Sub

    Private Sub OrdersLink_Click(sender As Object, e As EventArgs) Handles OrdersLink.Click
        LoadOrdersPage()
    End Sub

    Private Sub DashboardLink_Click(sender As Object, e As EventArgs)
        LoadDashboardPage()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.LoadUserPage()
    End Sub
End Class