Imports MySql.Data.MySqlClient

Module OrderUpdatesModule
    Public Updates As New List(Of OrderUpdatesModel)

    Public Sub GetUpdatesById(Id As Integer)
        Updates.Clear()
        Dim Sql = "select * from order_updates where rel = @Id"
        Dim Cmd = New MySqlCommand(Sql, Form1.DbConnection)
        Cmd.Parameters.AddWithValue("@Id", Id)

        Try
            Form1.DbConnection.Open()
            Dim Reader = Cmd.ExecuteReader()

            If (Reader.HasRows) Then
                While Reader.Read()
                    Updates.Add(New OrderUpdatesModel With {
                        .Datee = Reader("date"),
                        .Memo = Reader("memo")
                    })
                End While
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Form1.DbConnection.Close()
        End Try
    End Sub

    Public Sub AddPointById(Id As Integer, Datee As Date, Memo As String)
        Dim Sql = "insert into order_updates (date, memo, rel) values (@Datee, @Memo, @Id)"

        Dim Cmd = New MySqlCommand(Sql, Form1.DbConnection)
        Cmd.Parameters.AddWithValue("@Datee", Datee)
        Cmd.Parameters.AddWithValue("@Memo", Memo)
        Cmd.Parameters.AddWithValue("@Id", Id)

        Try
            Form1.DbConnection.Open()
            Cmd.ExecuteNonQuery()

            Form1.DbConnection.Close()

            Form1.StaffPage.LoadEditOrderPage()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Form1.DbConnection.Close()
        End Try
    End Sub

    Public Sub AddDelayById(Id As Integer, Datee As Date, Memo As String, UpdatedDate As Date)
        Dim Sql = "insert into order_updates (date, memo, rel) values (@Datee, @Memo, @Id)"
        Dim Sql2 = "update orders set delivery = @UpdatedDate"

        Dim Cmd = New MySqlCommand(Sql, Form1.DbConnection)
        Cmd.Parameters.AddWithValue("@Datee", Datee)
        Cmd.Parameters.AddWithValue("@Memo", Memo)
        Cmd.Parameters.AddWithValue("@Id", Id)

        Dim Cmd2 = New MySqlCommand(Sql2, Form1.DbConnection)
        Cmd2.Parameters.AddWithValue("@UpdatedDate", UpdatedDate)

        Try
            Form1.DbConnection.Open()
            Cmd.ExecuteNonQuery()
            Cmd2.ExecuteNonQuery()

            Form1.DbConnection.Close()

            Form1.StaffPage.LoadEditOrderPage()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Form1.DbConnection.Close()
        End Try
    End Sub
End Module

Public Class OrderUpdatesModel
    Public Datee As Date
    Public Memo As String
End Class