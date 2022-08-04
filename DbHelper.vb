Imports MySql.Data.MySqlClient

Module DbHelper
    Sub CreateTables()
        Dim UsersTableSchema = "create table if not exists users (id int not null auto_increment primary key, name varchar(25) not null, username varchar(25) not null, password varchar(20) not null, is_admin bool not null )"
        Dim OrdersTableSchema = "create table if not exists orders (id int not null auto_increment primary key, content varchar(50) not null, weight int not null, amount int not null, is_fragile boolean,sender_name varchar(25) not null, sender_phone varchar(12) not null, sender_addr1 varchar(50) not null, sender_addr2 varchar(50) not null, sender_addr3 varchar(50) not null, sender_pin varchar(20) not null
, recipient_name varchar(25) not null, recipient_phone varchar(12) not null, recipient_addr1 varchar(50) not null, recipient_addr2 varchar(50) not null, recipient_addr3 varchar(50) not null, recipient_pin varchar(20) not null, created_at datetime not null, delivery datetime not null,has_delivered boolean default false)"

        Dim OrderUpdatesTableSchema = "create table if not exists order_updates(id int not null auto_increment primary key,date datetime not null, memo varchar(100) not null, rel int)"
        Try
            Form1.DbConnection.Open()
            Dim cmd = New MySqlCommand(UsersTableSchema, Form1.DbConnection)
            Dim Cmd2 = New MySqlCommand(OrdersTableSchema, Form1.DbConnection)
            Dim Cmd3 = New MySqlCommand(OrderUpdatesTableSchema, Form1.DbConnection)

            cmd.ExecuteNonQuery()
            Cmd2.ExecuteNonQuery()
            Cmd3.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Form1.DbConnection.Close()
            Form1.DbConnection.Dispose()
        End Try
    End Sub
End Module