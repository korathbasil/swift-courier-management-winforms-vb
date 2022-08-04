<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.OrdersLink = New System.Windows.Forms.Label()
        Me.UsersLink = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AdminAppPanel = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.OrdersLink)
        Me.Panel1.Controls.Add(Me.UsersLink)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(158, 450)
        Me.Panel1.TabIndex = 0
        '
        'OrdersLink
        '
        Me.OrdersLink.AutoSize = True
        Me.OrdersLink.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.OrdersLink.Location = New System.Drawing.Point(12, 60)
        Me.OrdersLink.Name = "OrdersLink"
        Me.OrdersLink.Size = New System.Drawing.Size(49, 17)
        Me.OrdersLink.TabIndex = 5
        Me.OrdersLink.Text = "Orders"
        '
        'UsersLink
        '
        Me.UsersLink.AutoSize = True
        Me.UsersLink.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.UsersLink.Location = New System.Drawing.Point(12, 100)
        Me.UsersLink.Name = "UsersLink"
        Me.UsersLink.Size = New System.Drawing.Size(41, 17)
        Me.UsersLink.TabIndex = 4
        Me.UsersLink.Text = "Users"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(32, 413)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 22)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Logout"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(26, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Admin Panel"
        '
        'AdminAppPanel
        '
        Me.AdminAppPanel.BackColor = System.Drawing.SystemColors.Control
        Me.AdminAppPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AdminAppPanel.Location = New System.Drawing.Point(158, 0)
        Me.AdminAppPanel.Name = "AdminAppPanel"
        Me.AdminAppPanel.Size = New System.Drawing.Size(642, 450)
        Me.AdminAppPanel.TabIndex = 1
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.AdminAppPanel)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Admin"
        Me.Text = "Admin"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents UsersLink As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents AdminAppPanel As Panel
    Friend WithEvents OrdersLink As Label
End Class
