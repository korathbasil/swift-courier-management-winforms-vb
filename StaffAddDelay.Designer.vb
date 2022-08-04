<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffAddDelay
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
        Me.PointInput = New System.Windows.Forms.TextBox()
        Me.AddDelayButton = New System.Windows.Forms.Button()
        Me.GoBackButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DaysInput = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DaysInput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PointInput
        '
        Me.PointInput.Location = New System.Drawing.Point(105, 166)
        Me.PointInput.Name = "PointInput"
        Me.PointInput.Size = New System.Drawing.Size(197, 23)
        Me.PointInput.TabIndex = 8
        '
        'AddDelayButton
        '
        Me.AddDelayButton.Location = New System.Drawing.Point(253, 226)
        Me.AddDelayButton.Name = "AddDelayButton"
        Me.AddDelayButton.Size = New System.Drawing.Size(110, 41)
        Me.AddDelayButton.TabIndex = 7
        Me.AddDelayButton.Text = "Add Delay"
        Me.AddDelayButton.UseVisualStyleBackColor = True
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
        Me.Label1.Size = New System.Drawing.Size(85, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Add Delay"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(642, 450)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DaysInput)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.PointInput)
        Me.Panel2.Controls.Add(Me.AddDelayButton)
        Me.Panel2.Controls.Add(Me.GoBackButton)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(642, 450)
        Me.Panel2.TabIndex = 1
        '
        'DaysInput
        '
        Me.DaysInput.Location = New System.Drawing.Point(322, 167)
        Me.DaysInput.Name = "DaysInput"
        Me.DaysInput.Size = New System.Drawing.Size(195, 23)
        Me.DaysInput.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(322, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 15)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Delay (Days)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(102, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 15)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Place"
        '
        'StaffAddDelay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "StaffAddDelay"
        Me.Size = New System.Drawing.Size(642, 450)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DaysInput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PointInput As TextBox
    Friend WithEvents AddDelayButton As Button
    Friend WithEvents GoBackButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DaysInput As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
