<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddAdmin
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PasswordInput = New System.Windows.Forms.TextBox()
        Me.UsernameInput = New System.Windows.Forms.TextBox()
        Me.NameInput = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.PasswordInput)
        Me.Panel1.Controls.Add(Me.UsernameInput)
        Me.Panel1.Controls.Add(Me.NameInput)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 450)
        Me.Panel1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(285, 349)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 33)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Create Admin"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PasswordInput
        '
        Me.PasswordInput.Location = New System.Drawing.Point(285, 302)
        Me.PasswordInput.Name = "PasswordInput"
        Me.PasswordInput.Size = New System.Drawing.Size(230, 23)
        Me.PasswordInput.TabIndex = 16
        '
        'UsernameInput
        '
        Me.UsernameInput.Location = New System.Drawing.Point(285, 236)
        Me.UsernameInput.Name = "UsernameInput"
        Me.UsernameInput.Size = New System.Drawing.Size(230, 23)
        Me.UsernameInput.TabIndex = 15
        '
        'NameInput
        '
        Me.NameInput.Location = New System.Drawing.Point(285, 173)
        Me.NameInput.Name = "NameInput"
        Me.NameInput.Size = New System.Drawing.Size(230, 23)
        Me.NameInput.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(285, 284)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 15)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(285, 218)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 15)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(285, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 15)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(285, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(182, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Please add the admin details"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(285, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 21)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Welcome to Swift Courier"
        '
        'AddAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "AddAdmin"
        Me.Text = "AddAdmin"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents PasswordInput As TextBox
    Friend WithEvents UsernameInput As TextBox
    Friend WithEvents NameInput As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
