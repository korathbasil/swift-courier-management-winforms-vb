Public Class StaffLogin
    Private Sub GoToAdminLoginButton_Click(sender As Object, e As EventArgs) Handles GoToAdminLoginButton.Click
        Form1.LoadAdminLoginPage()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Username = UsernameInput.Text
        Dim Password = PasswordInput.Text

        StaffModule.StaffLogin(Username, Password)
    End Sub

    Private Sub GoToUserPageButton_Click(sender As Object, e As EventArgs) Handles GoToUserPageButton.Click
        Form1.LoadUserPage()
    End Sub
End Class