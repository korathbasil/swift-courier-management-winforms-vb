Public Class AdminOrders
    Private Sub AdminOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RenderOrderDataInListView()
    End Sub

    Private Sub RenderOrderDataInListView()
        OrderModule.GetOrderData()

        Dim CurrentItem = 0
        For Each Order As OrderModelMini In OrderModule.Orders
            OrdersList.Items.Add(Order.Id)
            OrdersList.Items(CurrentItem).SubItems.Add(Order.SName)
            CurrentItem += 1
        Next

        CurrentItem = 0
        For Each Order As OrderModelMini In OrderModule.Orders
            OrdersList.Items(CurrentItem).SubItems.Add(Order.RName)
            CurrentItem += 1
        Next

        CurrentItem = 0
        For Each Order As OrderModelMini In OrderModule.Orders
            OrdersList.Items(CurrentItem).SubItems.Add(Order.RPhone)
            CurrentItem += 1
        Next

        CurrentItem = 0
        For Each Order As OrderModelMini In OrderModule.Orders
            OrdersList.Items(CurrentItem).SubItems.Add(Order.RPin)
            CurrentItem += 1
        Next

        CurrentItem = 0
        For Each Order As OrderModelMini In OrderModule.Orders
            OrdersList.Items(CurrentItem).SubItems.Add(Order.Weight)
            CurrentItem += 1
        Next

        CurrentItem = 0
        For Each Order As OrderModelMini In OrderModule.Orders
            If Order.Delivered Then
                OrdersList.Items(CurrentItem).SubItems.Add("Completed")
            Else
                OrdersList.Items(CurrentItem).SubItems.Add(Order.Delivery.ToString("dd-MM-yy"))
            End If
            CurrentItem += 1
        Next
    End Sub

End Class
