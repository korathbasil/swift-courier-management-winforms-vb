<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User
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
        Me.GoToStaffLoginButton = New System.Windows.Forms.Button()
        Me.CheckStatusButton = New System.Windows.Forms.Button()
        Me.IdInput = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GoToStaffLoginButton)
        Me.Panel1.Controls.Add(Me.CheckStatusButton)
        Me.Panel1.Controls.Add(Me.IdInput)
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
        Me.GoToStaffLoginButton.Location = New System.Drawing.Point(12, 408)
        Me.GoToStaffLoginButton.Name = "GoToStaffLoginButton"
        Me.GoToStaffLoginButton.Size = New System.Drawing.Size(144, 30)
        Me.GoToStaffLoginButton.TabIndex = 4
        Me.GoToStaffLoginButton.Text = "Go To Staff Login"
        Me.GoToStaffLoginButton.UseVisualStyleBackColor = True
        '
        'CheckStatusButton
        '
        Me.CheckStatusButton.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CheckStatusButton.Location = New System.Drawing.Point(448, 242)
        Me.CheckStatusButton.Name = "CheckStatusButton"
        Me.CheckStatusButton.Size = New System.Drawing.Size(136, 37)
        Me.CheckStatusButton.TabIndex = 3
        Me.CheckStatusButton.Text = "Check Status"
        Me.CheckStatusButton.UseVisualStyleBackColor = True
        '
        'IdInput
        '
        Me.IdInput.Location = New System.Drawing.Point(189, 198)
        Me.IdInput.Name = "IdInput"
        Me.IdInput.Size = New System.Drawing.Size(391, 23)
        Me.IdInput.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(189, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter your order id below"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(189, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Swift Courier"
        '
        'User
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "User"
        Me.Text = "User"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents CheckStatusButton As Button
    Friend WithEvents IdInput As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GoToStaffLoginButton As Button
End Class
