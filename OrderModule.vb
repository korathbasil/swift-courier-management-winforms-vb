Imports MySql.Data.MySqlClient

Module OrderModule
    Public Order As OrderModelMini
    Public OrderExists As Boolean
    Public Orders As New List(Of OrderModelMini)
    Public Sub CraeteOrder(Order As OrderModel)
        Dim Sql = "insert into orders (content, weight, is_fragile, amount, sender_name, sender_phone, sender_addr1, sender_addr2, sender_addr3, sender_pin, recipient_name, recipient_phone, recipient_addr1, recipient_addr2, recipient_addr3, recipient_pin, created_at, delivery) values (@Content, @Weight, @IsFragile, @Amount,@SName, @SPhone, @SAddr1, @SAddr2, @SAddr3, @SPin, @RName, @RPhone, @RAddr1, @RAddr2, @RAddr3, @RPin, @CreatedAt, @Delivery)"

        Dim Cmd = New MySqlCommand(Sql, Form1.DbConnection)
        Cmd.Parameters.AddWithValue("@Content", Order.Content)
        Cmd.Parameters.AddWithValue("@Weight", Order.Weight)
        Cmd.Parameters.AddWithValue("@IsFragile", Order.IsFragile)
        Cmd.Parameters.AddWithValue("@Amount", Order.Amount)
        Cmd.Parameters.AddWithValue("@SName", Order.SName)
        Cmd.Parameters.AddWithValue("@SPhone", Order.SPhone)
        Cmd.Parameters.AddWithValue("@SAddr1", Order.SAddr1)
        Cmd.Parameters.AddWithValue("@SAddr2", Order.SAddr2)
        Cmd.Parameters.AddWithValue("@SAddr3", Order.SAddr3)
        Cmd.Parameters.AddWithValue("@SPin", Order.SPin)
        Cmd.Parameters.AddWithValue("@RName", Order.Rname)
        Cmd.Parameters.AddWithValue("@RPhone", Order.RPhone)
        Cmd.Parameters.AddWithValue("@RAddr1", Order.RAddr1)
        Cmd.Parameters.AddWithValue("@RAddr2", Order.RAddr2)
        Cmd.Parameters.AddWithValue("@RAddr3", Order.RAddr3)
        Cmd.Parameters.AddWithValue("@RPin", Order.RPin)
        Cmd.Parameters.AddWithValue("@CreatedAt", Order.CreatedAt)
        Cmd.Parameters.AddWithValue("@delivery", Order.Delivery)



        Try
            Form1.DbConnection.Open()
            Cmd.ExecuteNonQuery()

            Form1.DbConnection.Close()
            Form1.StaffPage.LoadOrdersPage()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Form1.DbConnection.Close()
        End Try
    End Sub

    Public Sub GetOrderData()
        Orders.Clear()
        Dim Sql = "select * from orders"
        Dim Cmd = New MySqlCommand(Sql, Form1.DbConnection)

        Try
            Form1.DbConnection.Open()

            Dim Reader = Cmd.ExecuteReader()

            If (Reader.HasRows) Then
                While Reader.Read()
                    Orders.Add(New OrderModelMini With {
                        .Id = Reader("id"),
                        .SName = Reader("sender_name"),
                        .SPhone = Reader("sender_phone"),
                        .RName = Reader("recipient_name"),
                        .RPhone = Reader("recipient_phone"),
                        .RPin = Reader("recipient_pin"),
                        .Weight = Reader("weight"),
                        .Delivery = Reader("delivery"),
                        .Delivered = Reader("has_delivered")
                    })
                End While
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Form1.DbConnection.Close()
        End Try
    End Sub

    Public Sub GetOrderById(Id As Integer)
        OrderExists = False
        Dim Sql = "select id, sender_name, sender_phone, recipient_name, recipient_phone,recipient_pin, weight, created_at,delivery, has_delivered from orders where id = @Id"

        Dim Cmd = New MySqlCommand(Sql, Form1.DbConnection)
        Cmd.Parameters.AddWithValue("@Id", Id)

        Try
            Form1.DbConnection.Open()

            Dim Reader = Cmd.ExecuteReader()

            Reader.Read()
            If Reader.HasRows Then
                OrderExists = True
                Order = New OrderModelMini With {
                            .Id = Reader("id"),
                            .SName = Reader("sender_name"),
                            .SPhone = Reader("sender_phone"),
                            .RName = Reader("recipient_name"),
                            .RPhone = Reader("recipient_phone"),
                            .RPin = Reader("recipient_pin"),
                            .Weight = Reader("weight"),
                            .Delivery = Reader("delivery"),
                            .CreatedAt = Reader("created_at"),
                            .Delivered = Reader("has_delivered")
                        }
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message + "sd")
        Finally
            Form1.DbConnection.Close()
        End Try
    End Sub

    Public Sub MarkAsDelivered(Id As Integer, Datee As Date)
        Dim Sql = "update orders set has_delivered = true, delivery = @Date"

        Dim Cmd = New MySqlCommand(Sql, Form1.DbConnection)
        Cmd.Parameters.AddWithValue("@Date", Datee)

        Try
            Form1.DbConnection.Open()
            Cmd.ExecuteNonQuery()

            Form1.StaffPage.LoadEditOrderPage()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Form1.DbConnection.Close()
        End Try
    End Sub
End Module

Public Class OrderModel
    Public Content As String
    Public Weight As Integer
    Public IsFragile As Boolean
    Public Amount As Integer

    Public SName As String
    Public SPhone As String
    Public SAddr1 As String
    Public SAddr2 As String
    Public SAddr3 As String
    Public SPin As String

    Public Rname As String
    Public RPhone As String
    Public RAddr1 As String
    Public RAddr2 As String
    Public RAddr3 As String
    Public RPin As String

    Public CreatedAt As Date
    Public Delivery As Date
    Public HasDelivered As Boolean

End Class


Public Class OrderModelMini
    Public Id As Integer
    Public SName As String
    Public SPhone As String
    Public RName As String
    Public RPhone As String
    Public RPin As String
    Public Weight As Integer
    Public Delivered As Boolean
    Public CreatedAt As Date
    Public Delivery As Date
End Class