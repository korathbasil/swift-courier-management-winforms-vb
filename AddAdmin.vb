Public Class AddAdmin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Name = NameInput.Text
        Dim Username = UsernameInput.Text
        Dim Password = PasswordInput.Text

        AdminModule.AddAdmin(Name, Username, Password)
    End Sub
End Class