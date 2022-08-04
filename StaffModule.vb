Imports MySql.Data.MySqlClient

Module StaffModule
    Public Sub StaffLogin(Username As String, Password As String)
        Dim Sql = "select name, username, password, is_admin from users where username=@Username and is_admin=false"
        Try
            Form1.DbConnection.Open()
            Dim Cmd = New MySqlCommand(Sql, Form1.DbConnection)
            Cmd.Parameters.AddWithValue("@Username", Username)

            Dim Reader = Cmd.ExecuteReader

            If Reader.Read() = True Then
                If Reader("password") = Password Then
                    Form1.LoggedInusername = Reader("name")
                    Form1.DbConnection.Close()
                    Form1.LoadStaffPage()
                Else
                    MessageBox.Show("Invalid password")
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
