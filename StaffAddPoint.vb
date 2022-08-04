Public Class StaffAddPoint
    Private Sub GoBackButton_Click(sender As Object, e As EventArgs) Handles GoBackButton.Click
        Form1.StaffPage.LoadEditOrderPage()
    End Sub

    Private Sub AddPointButton_Click(sender As Object, e As EventArgs) Handles AddPointButton.Click
        Dim Point = PointInput.Text

        OrderModule.GetOrderById(Form1.StaffPage.SelectedOrderId)
        OrderUpdatesModule.AddPointById(Form1.StaffPage.SelectedOrderId, Date.Now(), Point)
    End Sub
End Class
