<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StaffLogin))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GoToUserPageButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GoToAdminLoginButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PasswordInput = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.UsernameInput = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 450)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GoToUserPageButton)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.GoToAdminLoginButton)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.PasswordInput)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.UsernameInput)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 450)
        Me.Panel2.TabIndex = 1
        '
        'GoToUserPageButton
        '
        Me.GoToUserPageButton.Location = New System.Drawing.Point(267, 409)
        Me.GoToUserPageButton.Name = "GoToUserPageButton"
        Me.GoToUserPageButton.Size = New System.Drawing.Size(131, 29)
        Me.GoToUserPageButton.TabIndex = 8
        Me.GoToUserPageButton.Text = "Go To User Page"
        Me.GoToUserPageButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(415, 66)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(313, 286)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'GoToAdminLoginButton
        '
        Me.GoToAdminLoginButton.Location = New System.Drawing.Point(120, 409)
        Me.GoToAdminLoginButton.Name = "GoToAdminLoginButton"
        Me.GoToAdminLoginButton.Size = New System.Drawing.Size(131, 29)
        Me.GoToAdminLoginButton.TabIndex = 6
        Me.GoToAdminLoginButton.Text = "Go To Admin Login"
        Me.GoToAdminLoginButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(120, 269)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 34)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PasswordInput
        '
        Me.PasswordInput.Location = New System.Drawing.Point(120, 228)
        Me.PasswordInput.Name = "PasswordInput"
        Me.PasswordInput.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordInput.Size = New System.Drawing.Size(188, 23)
        Me.PasswordInput.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(120, 210)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Pssword"
        '
        'UsernameInput
        '
        Me.UsernameInput.Location = New System.Drawing.Point(120, 173)
        Me.UsernameInput.Name = "UsernameInput"
        Me.UsernameInput.Size = New System.Drawing.Size(188, 23)
        Me.UsernameInput.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(120, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Username"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(120, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Staff Login"
        '
        'StaffLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "StaffLogin"
        Me.Text = "StaffLogin"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GoToAdminLoginButton As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PasswordInput As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents UsernameInput As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GoToUserPageButton As Button
End Class
