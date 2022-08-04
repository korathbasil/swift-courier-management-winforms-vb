Public Class AdminUserManagement
    Private Sub AdminUserManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserModule.LoadUserData()
        Dim CurrentItem = 0
        For Each User As UserModel In UserModule.Users
            UsersListView.Items.Add(User.Id)
            UsersListView.Items(CurrentItem).SubItems.Add(User.Name)
            CurrentItem += 1
        Next

        CurrentItem = 0
        For Each User As UserModel In UserModule.Users
            UsersListView.Items(CurrentItem).SubItems.Add(User.Username)
            CurrentItem += 1
        Next

        CurrentItem = 0
        For Each User As UserModel In UserModule.Users
            If User.IsAdmin Then
                UsersListView.Items(CurrentItem).SubItems.Add("Admin")
            Else
                UsersListView.Items(CurrentItem).SubItems.Add("Staff")
            End If
            CurrentItem += 1
        Next
    End Sub

    Private Sub GoToAddUserPageButton_Click(sender As Object, e As EventArgs) Handles GoToAddUserPageButton.Click
        Form1.AdminPage.LoadAddUserPage()
    End Sub

    Private Sub UsersListView_Click(sender As Object, e As EventArgs) Handles UsersListView.Click
        If (UsersListView.SelectedItems.Count > 0) Then
            MessageBox.Show(UsersListView.SelectedItems(0).SubItems(1).Text)
        End If
    End Sub
End Class
