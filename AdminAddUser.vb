Public Class AdminAddUser
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Name = NameInput.Text
        Dim Username = UsernameInput.Text
        Dim Password = PasswordInput.Text
        Dim IsAdmin As Boolean

        If (IsAdminInput.Text = "Admin") Then
            IsAdmin = True
        Else
            IsAdmin = False
        End If

        UserModule.AddUser(Name, Username, Password, IsAdmin)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.AdminPage.LoadUserManagementPage()
    End Sub
End Class
