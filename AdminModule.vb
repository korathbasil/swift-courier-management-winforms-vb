Imports MySql.Data.MySqlClient

Module AdminModule
    Sub AddAdmin(Name As String, Username As String, Password As String)
        Dim Sql = "insert into users (name, username, password, is_admin) values(@Name, @Username, @Password, true)"
        Try
            Form1.DbConnection.Open()
            Dim Cmd = New MySqlCommand(Sql, Form1.DbConnection)

            Cmd.Parameters.AddWithValue("@Name", Name)
            Cmd.Parameters.AddWithValue("@Username", Username)
            Cmd.Parameters.AddWithValue("@Password", Password)

            Dim Res = Cmd.ExecuteScalar()

            ' Navigate to admin page
            Form1.LoadAdminPage()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Form1.DbConnection.Close()
        End Try
    End Sub

    Sub LoginAdmin(Username As String, password As String)
        Dim Sql = "select name, username, password, is_admin from users where username=@Username"
        Try
            Form1.DbConnection.Open()
            Dim Cmd = New MySqlCommand(Sql, Form1.DbConnection)
            Cmd.Parameters.AddWithValue("@Username", Username)

            Dim Reader = Cmd.ExecuteReader

            If Reader.Read() = True Then
                If Reader("is_admin") = True Then
                    If Reader("password") = password Then
                        Dim Name = Reader("name")
                        Form1.LoggedInusername = Name

                        Form1.DbConnection.Close()
                        Form1.LoadAdminPage()
                    Else
                        MessageBox.Show("Invalid password")
                    End If
                Else
                    MessageBox.Show("Invalid username")
                End If
            Else
                MessageBox.Show("Invalid username")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Form1.DbConnection.Close()
        End Try
    End Sub
End Module
