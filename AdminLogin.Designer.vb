<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminLogin))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GoToStaffLoginButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.PasswordInput = New System.Windows.Forms.TextBox()
        Me.UsernameInput = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GoToStaffLoginButton)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.LoginButton)
        Me.Panel1.Controls.Add(Me.PasswordInput)
        Me.Panel1.Controls.Add(Me.UsernameInput)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 450)
        Me.Panel1.TabIndex = 0
        '
        'GoToStaffLoginButton
        '
        Me.GoToStaffLoginButton.Location = New System.Drawing.Point(484, 409)
        Me.GoToStaffLoginButton.Name = "GoToStaffLoginButton"
        Me.GoToStaffLoginButton.Size = New System.Drawing.Size(131, 29)
        Me.GoToStaffLoginButton.TabIndex = 13
        Me.GoToStaffLoginButton.Text = "Go To Staff Login"
        Me.GoToStaffLoginButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(85, 69)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(318, 301)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'LoginButton
        '
        Me.LoginButton.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LoginButton.Location = New System.Drawing.Point(484, 269)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(75, 37)
        Me.LoginButton.TabIndex = 11
        Me.LoginButton.Text = "Login"
        Me.LoginButton.UseVisualStyleBackColor = True
        '
        'PasswordInput
        '
        Me.PasswordInput.Location = New System.Drawing.Point(484, 231)
        Me.PasswordInput.Name = "PasswordInput"
        Me.PasswordInput.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordInput.Size = New System.Drawing.Size(195, 23)
        Me.PasswordInput.TabIndex = 10
        '
        'UsernameInput
        '
        Me.UsernameInput.Location = New System.Drawing.Point(484, 168)
        Me.UsernameInput.Name = "UsernameInput"
        Me.UsernameInput.Size = New System.Drawing.Size(195, 23)
        Me.UsernameInput.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(484, 213)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(484, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Username"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(484, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 21)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Please login."
        '
        'AdminLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "AdminLogin"
        Me.Text = "AdminLogin"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LoginButton As Button
    Friend WithEvents PasswordInput As TextBox
    Friend WithEvents UsernameInput As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GoToStaffLoginButton As Button
End Class
