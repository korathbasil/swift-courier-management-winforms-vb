<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserOrderDetails
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
        Me.UpdatesList = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader()
        Me.IDLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.UpdatesList)
        Me.Panel1.Controls.Add(Me.IDLabel)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 450)
        Me.Panel1.TabIndex = 0
        '
        'UpdatesList
        '
        Me.UpdatesList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.UpdatesList.Location = New System.Drawing.Point(102, 105)
        Me.UpdatesList.Name = "UpdatesList"
        Me.UpdatesList.Size = New System.Drawing.Size(606, 312)
        Me.UpdatesList.TabIndex = 7
        Me.UpdatesList.UseCompatibleStateImageBehavior = False
        Me.UpdatesList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Date"
        Me.ColumnHeader1.Width = 150
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Memo"
        Me.ColumnHeader2.Width = 250
        '
        'IDLabel
        '
        Me.IDLabel.AutoSize = True
        Me.IDLabel.Location = New System.Drawing.Point(140, 69)
        Me.IDLabel.Name = "IDLabel"
        Me.IDLabel.Size = New System.Drawing.Size(41, 15)
        Me.IDLabel.TabIndex = 3
        Me.IDLabel.Text = "Label4"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(111, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Id :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(339, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Order Details"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Swift Courier"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(663, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 28)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Go Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'UserOrderDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "UserOrderDetails"
        Me.Text = "UserOrderDetails"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents IDLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents UpdatesList As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents Button1 As Button
End Class
