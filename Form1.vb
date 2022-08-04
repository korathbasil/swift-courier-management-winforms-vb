Imports MySql.Data.MySqlClient

Public Class Form1
    Public DbConnection As MySqlConnection

    Public LoggedInusername As String
    Public SelectedId As Integer

    Public AddAdminPage As AddAdmin
    Public AdminLoginPage As AdminLogin
    Public AdminPage As Admin

    Public StaffLoginPage As StaffLogin
    Public StaffPage As Staff

    Public UserPage As User
    Public UserOrderDetailsPage As UserOrderDetails

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitDbConnection()
        LoadInitialPage()
    End Sub

    Private Sub InitDbConnection()
        Dim ConnectionString = "server=127.0.0.1;uid=root;pwd=admin;database=swiftcourier"
        DbConnection = New MySqlConnection With {
            .ConnectionString = ConnectionString
        }

        ' Create tables
        DbHelper.CreateTables()
    End Sub

    Private Sub LoadInitialPage()
        UserModule.IsUsersExists()
        If UserModule.UserExists = True Then
            LoadUserPage()
        Else
            LoadAddAdminPage()
        End If
    End Sub

    Public Sub LoadAddAdminPage()
        AddAdminPage = New AddAdmin With {
            .TopLevel = False,
            .FormBorderStyle = FormBorderStyle.None
        }

        AppPanel.Controls.Clear()
        AppPanel.Controls.Add(AddAdminPage)
        AddAdminPage.Show()
    End Sub

    Public Sub LoadAdminLoginPage()
        AdminLoginPage = New AdminLogin With {
            .TopLevel = False,
            .FormBorderStyle = FormBorderStyle.None
        }

        AppPanel.Controls.Clear()
        AppPanel.Controls.Add(AdminLoginPage)
        AdminLoginPage.Show()
    End Sub

    Public Sub LoadAdminPage()
        AdminPage = New Admin With {
            .TopLevel = False,
            .FormBorderStyle = FormBorderStyle.None
        }

        AppPanel.Controls.Clear()
        AppPanel.Controls.Add(AdminPage)
        AdminPage.Show()
    End Sub

    Public Sub LoadStaffLoginPage()
        StaffLoginPage = New StaffLogin With {
            .TopLevel = False,
            .FormBorderStyle = FormBorderStyle.None
        }

        AppPanel.Controls.Clear()
        AppPanel.Controls.Add(StaffLoginPage)
        StaffLoginPage.Show()
    End Sub

    Public Sub LoadStaffPage()
        StaffPage = New Staff With {
            .TopLevel = False,
            .FormBorderStyle = FormBorderStyle.None
        }

        AppPanel.Controls.Clear()
        AppPanel.Controls.Add(StaffPage)
        StaffPage.Show()
    End Sub

    Public Sub LoadUserPage()
        UserPage = New User With {
            .TopLevel = False,
            .FormBorderStyle = FormBorderStyle.None
        }

        AppPanel.Controls.Clear()
        AppPanel.Controls.Add(UserPage)
        UserPage.Show()
    End Sub

    Public Sub LoadUserDetailsPage()
        UserOrderDetailsPage = New UserOrderDetails With {
            .TopLevel = False,
            .FormBorderStyle = FormBorderStyle.None
        }

        AppPanel.Controls.Clear()
        AppPanel.Controls.Add(UserOrderDetailsPage)
        UserOrderDetailsPage.Show()
    End Sub
End Class
