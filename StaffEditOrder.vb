Public Class StaffEditOrder
    Private Sub StaffEditOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IdLabel.Text = Form1.StaffPage.SelectedOrderId

        OrderModule.GetOrderById(Form1.StaffPage.SelectedOrderId)

        OrderUpdatesModule.GetUpdatesById(Form1.StaffPage.SelectedOrderId)

        OrderUpdatesModule.GetUpdatesById(Form1.StaffPage.SelectedOrderId)

        UpdatesList.Items.Add(OrderModule.Order.CreatedAt.ToString("dd-MM-yy"))
        UpdatesList.Items(0).SubItems.Add("Dispatched")
        Dim CurrentItem = 1
        For Each Update As OrderUpdatesModel In OrderUpdatesModule.Updates
            UpdatesList.Items.Add(Update.Datee.ToString("dd-MM-yy"))
            UpdatesList.Items(CurrentItem).SubItems.Add(Update.Memo)
            CurrentItem += 1
        Next

        If (OrderModule.Order.Delivered = True) Then
            UpdatesList.Items.Add(OrderModule.Order.Delivery.ToString("dd-MM-yy"))
            UpdatesList.Items(CurrentItem).SubItems.Add("Delivered")
        Else
            UpdatesList.Items.Add(OrderModule.Order.Delivery.ToString("dd-MM-yy"))
            UpdatesList.Items(CurrentItem).SubItems.Add("Expected delivery")
        End If
    End Sub

    Private Sub AddPointButton_Click(sender As Object, e As EventArgs) Handles AddPointButton.Click
        Form1.StaffPage.LoadAddPointPage()
    End Sub

    Private Sub AddDelayButton_Click(sender As Object, e As EventArgs) Handles AddDelayButton.Click
        Form1.StaffPage.LoadAddDelayPage()
    End Sub

    Private Sub GoBackButton_Click(sender As Object, e As EventArgs) Handles GoBackButton.Click
        Form1.StaffPage.LoadOrdersPage()
    End Sub

    Private Sub MarkDeliverButton_Click(sender As Object, e As EventArgs) Handles MarkDeliverButton.Click
        OrderModule.MarkAsDelivered(Form1.StaffPage.SelectedOrderId, Date.Now())
    End Sub
End Class
