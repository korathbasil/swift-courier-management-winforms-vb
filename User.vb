Public Class User
    Private Sub GoToStaffLoginButton_Click(sender As Object, e As EventArgs) Handles GoToStaffLoginButton.Click
        Form1.LoadStaffLoginPage()
    End Sub

    Private Sub CheckStatusButton_Click(sender As Object, e As EventArgs) Handles CheckStatusButton.Click
        Dim Id = IdInput.Text

        If (Id < 1) Then
            MessageBox.Show("Please enter a valid ortder id")
        Else
            OrderModule.GetOrderById(Id)
            If (OrderModule.OrderExists) Then
                Form1.SelectedId = Id
                Form1.LoadUserDetailsPage()
            Else
                MessageBox.Show("Please enter a valid ortder id")
            End If
        End If
    End Sub

    Private Sub User_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class