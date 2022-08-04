<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffOrders
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.OrdersList = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader()
        Me.NewOrderButton = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.OrdersList)
        Me.Panel1.Controls.Add(Me.NewOrderButton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(642, 450)
        Me.Panel1.TabIndex = 0
        '
        'OrdersList
        '
        Me.OrdersList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.OrdersList.Location = New System.Drawing.Point(10, 46)
        Me.OrdersList.Name = "OrdersList"
        Me.OrdersList.Size = New System.Drawing.Size(621, 392)
        Me.OrdersList.TabIndex = 1
        Me.OrdersList.UseCompatibleStateImageBehavior = False
        Me.OrdersList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Id"
        Me.ColumnHeader1.Width = 80
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Sender Name"
        Me.ColumnHeader8.Width = 120
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Recepient Name"
        Me.ColumnHeader9.Width = 120
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "R. Phone"
        Me.ColumnHeader2.Width = 120
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "R. Pin"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Weight"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Delivery"
        '
        'NewOrderButton
        '
        Me.NewOrderButton.Location = New System.Drawing.Point(504, 15)
        Me.NewOrderButton.Name = "NewOrderButton"
        Me.NewOrderButton.Size = New System.Drawing.Size(123, 24)
        Me.NewOrderButton.TabIndex = 0
        Me.NewOrderButton.Text = "New Order"
        Me.NewOrderButton.UseVisualStyleBackColor = True
        '
        'StaffOrders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "StaffOrders"
        Me.Size = New System.Drawing.Size(642, 450)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents OrdersList As ListView
    Protected Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents NewOrderButton As Button
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
End Class
