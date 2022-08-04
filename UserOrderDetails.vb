Public Class UserOrderDetails

    Private Sub UserOrderDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OrderModule.GetOrderById(Form1.SelectedId)

        OrderUpdatesModule.GetUpdatesById(Form1.SelectedId)

        OrderUpdatesModule.GetUpdatesById(Form1.SelectedId)

        IDLabel.Text = Form1.SelectedId

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.LoadUserPage()
    End Sub
End Class