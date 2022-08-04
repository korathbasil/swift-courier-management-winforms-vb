Public Class StaffAddDelay
    Private Sub GoBackButton_Click(sender As Object, e As EventArgs) Handles GoBackButton.Click
        Form1.StaffPage.LoadEditOrderPage()
    End Sub

    Private Sub AddPointButton_Click(sender As Object, e As EventArgs) Handles AddDelayButton.Click
        Dim Memo = DaysInput.Value.ToString() + " days delay at " + PointInput.Text

        OrderModule.GetOrderById(Form1.StaffPage.SelectedOrderId)

        Dim CurrentDate = Date.Now()
        Dim NewDate = DateAdd("d", DaysInput.Value, OrderModule.Order.Delivery)
        OrderUpdatesModule.AddDelayById(Form1.StaffPage.SelectedOrderId, CurrentDate, Memo, NewDate)
    End Sub
End Class
