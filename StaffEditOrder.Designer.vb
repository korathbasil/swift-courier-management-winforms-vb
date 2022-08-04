<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StaffEditOrder
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MarkDeliverButton = New System.Windows.Forms.Button()
        Me.AddDelayButton = New System.Windows.Forms.Button()
        Me.AddPointButton = New System.Windows.Forms.Button()
        Me.UpdatesList = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader()
        Me.IdLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GoBackButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.MarkDeliverButton)
        Me.Panel1.Controls.Add(Me.AddDelayButton)
        Me.Panel1.Controls.Add(Me.AddPointButton)
        Me.Panel1.Controls.Add(Me.UpdatesList)
        Me.Panel1.Controls.Add(Me.IdLabel)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.GoBackButton)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(642, 450)
        Me.Panel1.TabIndex = 0
        '
        'MarkDeliverButton
        '
        Me.MarkDeliverButton.Location = New System.Drawing.Point(515, 393)
        Me.MarkDeliverButton.Name = "MarkDeliverButton"
        Me.MarkDeliverButton.Size = New System.Drawing.Size(110, 41)
        Me.MarkDeliverButton.TabIndex = 9
        Me.MarkDeliverButton.Text = "Mark as Delivered"
        Me.MarkDeliverButton.UseVisualStyleBackColor = True
        '
        'AddDelayButton
        '
        Me.AddDelayButton.Location = New System.Drawing.Point(354, 393)
        Me.AddDelayButton.Name = "AddDelayButton"
        Me.AddDelayButton.Size = New System.Drawing.Size(110, 41)
        Me.AddDelayButton.TabIndex = 8
        Me.AddDelayButton.Text = "Add Delay"
        Me.AddDelayButton.UseVisualStyleBackColor = True
        '
        'AddPointButton
        '
        Me.AddPointButton.Location = New System.Drawing.Point(181, 393)
        Me.AddPointButton.Name = "AddPointButton"
        Me.AddPointButton.Size = New System.Drawing.Size(110, 41)
        Me.AddPointButton.TabIndex = 7
        Me.AddPointButton.Text = "Add Point"
        Me.AddPointButton.UseVisualStyleBackColor = True
        '
        'UpdatesList
        '
        Me.UpdatesList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.UpdatesList.Location = New System.Drawing.Point(19, 96)
        Me.UpdatesList.Name = "UpdatesList"
        Me.UpdatesList.Size = New System.Drawing.Size(606, 291)
        Me.UpdatesList.TabIndex = 6
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
        'IdLabel
        '
        Me.IdLabel.AutoSize = True
        Me.IdLabel.Location = New System.Drawing.Point(181, 68)
        Me.IdLabel.Name = "IdLabel"
        Me.IdLabel.Size = New System.Drawing.Size(41, 15)
        Me.IdLabel.TabIndex = 3
        Me.IdLabel.Text = "Label3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(152, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Id :"
        '
        'GoBackButton
        '
        Me.GoBackButton.Location = New System.Drawing.Point(498, 19)
        Me.GoBackButton.Name = "GoBackButton"
        Me.GoBackButton.Size = New System.Drawing.Size(121, 25)
        Me.GoBackButton.TabIndex = 1
        Me.GoBackButton.Text = "GoBack"
        Me.GoBackButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(17, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Update Order"
        '
        'StaffEditOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "StaffEditOrder"
        Me.Size = New System.Drawing.Size(642, 450)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents IdLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GoBackButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents AddDelayButton As Button
    Friend WithEvents AddPointButton As Button
    Friend WithEvents UpdatesList As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents MarkDeliverButton As Button
End Class
