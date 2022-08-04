Public Class AdminLogin
    Private Sub GoToStaffLoginButton_Click(sender As Object, e As EventArgs) Handles GoToStaffLoginButton.Click
        Form1.LoadStaffLoginPage()
    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Dim Username = UsernameInput.Text
        Dim Password = PasswordInput.Text

        AdminModule.LoginAdmin(Username, Password)
    End Sub
End Class