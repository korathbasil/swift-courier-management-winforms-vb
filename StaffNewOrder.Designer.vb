<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffNewOrder
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
        Me.CheckPriceButton = New System.Windows.Forms.Button()
        Me.WeightInput = New System.Windows.Forms.NumericUpDown()
        Me.DaysInput = New System.Windows.Forms.NumericUpDown()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.PriceLabel = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.CreateOrderButton = New System.Windows.Forms.Button()
        Me.RPINInput = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.SPINInput = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.RA3Input = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.SA3Input = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.SA2Input = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.RA2Input = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.RA1Input = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SA1Input = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.RPInput = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SPInput = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.RNInput = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SNInput = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FragileInput = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ContentInput = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GoBackOrdersButton = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.WeightInput, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DaysInput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CheckPriceButton)
        Me.Panel1.Controls.Add(Me.WeightInput)
        Me.Panel1.Controls.Add(Me.DaysInput)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.PriceLabel)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.CreateOrderButton)
        Me.Panel1.Controls.Add(Me.RPINInput)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.SPINInput)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.RA3Input)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.SA3Input)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.SA2Input)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.RA2Input)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.RA1Input)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.SA1Input)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.RPInput)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.SPInput)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.RNInput)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.SNInput)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.FragileInput)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.ContentInput)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.GoBackOrdersButton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(642, 450)
        Me.Panel1.TabIndex = 0
        '
        'CheckPriceButton
        '
        Me.CheckPriceButton.Location = New System.Drawing.Point(343, 396)
        Me.CheckPriceButton.Name = "CheckPriceButton"
        Me.CheckPriceButton.Size = New System.Drawing.Size(98, 24)
        Me.CheckPriceButton.TabIndex = 38
        Me.CheckPriceButton.Text = "Check Price"
        Me.CheckPriceButton.UseVisualStyleBackColor = True
        '
        'WeightInput
        '
        Me.WeightInput.Location = New System.Drawing.Point(340, 61)
        Me.WeightInput.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.WeightInput.Name = "WeightInput"
        Me.WeightInput.Size = New System.Drawing.Size(101, 23)
        Me.WeightInput.TabIndex = 37
        '
        'DaysInput
        '
        Me.DaysInput.Location = New System.Drawing.Point(178, 349)
        Me.DaysInput.Name = "DaysInput"
        Me.DaysInput.Size = New System.Drawing.Size(85, 23)
        Me.DaysInput.TabIndex = 36
        Me.DaysInput.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(36, 351)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(136, 15)
        Me.Label18.TabIndex = 35
        Me.Label18.Text = "Estimated Time (In days)"
        '
        'PriceLabel
        '
        Me.PriceLabel.AutoSize = True
        Me.PriceLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.PriceLabel.Location = New System.Drawing.Point(120, 387)
        Me.PriceLabel.Name = "PriceLabel"
        Me.PriceLabel.Size = New System.Drawing.Size(19, 21)
        Me.PriceLabel.TabIndex = 34
        Me.PriceLabel.Text = "0"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(49, 390)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(65, 15)
        Me.Label17.TabIndex = 33
        Me.Label17.Text = "Price (Rs.) :"
        '
        'CreateOrderButton
        '
        Me.CreateOrderButton.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CreateOrderButton.Location = New System.Drawing.Point(468, 384)
        Me.CreateOrderButton.Name = "CreateOrderButton"
        Me.CreateOrderButton.Size = New System.Drawing.Size(131, 47)
        Me.CreateOrderButton.TabIndex = 32
        Me.CreateOrderButton.Text = "Create Order"
        Me.CreateOrderButton.UseVisualStyleBackColor = True
        '
        'RPINInput
        '
        Me.RPINInput.Location = New System.Drawing.Point(437, 300)
        Me.RPINInput.Name = "RPINInput"
        Me.RPINInput.Size = New System.Drawing.Size(166, 23)
        Me.RPINInput.TabIndex = 31
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(330, 308)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(78, 15)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "Recipient PIN"
        '
        'SPINInput
        '
        Me.SPINInput.Location = New System.Drawing.Point(134, 305)
        Me.SPINInput.Name = "SPINInput"
        Me.SPINInput.Size = New System.Drawing.Size(166, 23)
        Me.SPINInput.TabIndex = 29
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(36, 313)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(65, 15)
        Me.Label16.TabIndex = 28
        Me.Label16.Text = "Sender PIN"
        '
        'RA3Input
        '
        Me.RA3Input.Location = New System.Drawing.Point(437, 266)
        Me.RA3Input.Name = "RA3Input"
        Me.RA3Input.Size = New System.Drawing.Size(166, 23)
        Me.RA3Input.TabIndex = 27
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(330, 274)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(94, 15)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Recipient Addr 3"
        '
        'SA3Input
        '
        Me.SA3Input.Location = New System.Drawing.Point(134, 271)
        Me.SA3Input.Name = "SA3Input"
        Me.SA3Input.Size = New System.Drawing.Size(166, 23)
        Me.SA3Input.TabIndex = 25
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(36, 274)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(81, 15)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "Sender Addr 3"
        '
        'SA2Input
        '
        Me.SA2Input.Location = New System.Drawing.Point(134, 233)
        Me.SA2Input.Name = "SA2Input"
        Me.SA2Input.Size = New System.Drawing.Size(166, 23)
        Me.SA2Input.TabIndex = 23
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(36, 236)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 15)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Sender Addr 2"
        '
        'RA2Input
        '
        Me.RA2Input.Location = New System.Drawing.Point(437, 233)
        Me.RA2Input.Name = "RA2Input"
        Me.RA2Input.Size = New System.Drawing.Size(166, 23)
        Me.RA2Input.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(330, 236)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 15)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Recipient Addr2"
        '
        'RA1Input
        '
        Me.RA1Input.Location = New System.Drawing.Point(437, 194)
        Me.RA1Input.Name = "RA1Input"
        Me.RA1Input.Size = New System.Drawing.Size(166, 23)
        Me.RA1Input.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(330, 197)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 15)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Recipient Addr 1"
        '
        'SA1Input
        '
        Me.SA1Input.Location = New System.Drawing.Point(134, 194)
        Me.SA1Input.Name = "SA1Input"
        Me.SA1Input.Size = New System.Drawing.Size(166, 23)
        Me.SA1Input.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(36, 197)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 15)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Sender Addr 1"
        '
        'RPInput
        '
        Me.RPInput.Location = New System.Drawing.Point(437, 153)
        Me.RPInput.Name = "RPInput"
        Me.RPInput.Size = New System.Drawing.Size(166, 23)
        Me.RPInput.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(330, 156)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 15)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Recipient Phone"
        '
        'SPInput
        '
        Me.SPInput.Location = New System.Drawing.Point(134, 153)
        Me.SPInput.Name = "SPInput"
        Me.SPInput.Size = New System.Drawing.Size(166, 23)
        Me.SPInput.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(36, 156)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 15)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Sender Phone"
        '
        'RNInput
        '
        Me.RNInput.Location = New System.Drawing.Point(437, 114)
        Me.RNInput.Name = "RNInput"
        Me.RNInput.Size = New System.Drawing.Size(166, 23)
        Me.RNInput.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(330, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 15)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Recipient Name"
        '
        'SNInput
        '
        Me.SNInput.Location = New System.Drawing.Point(134, 111)
        Me.SNInput.Name = "SNInput"
        Me.SNInput.Size = New System.Drawing.Size(166, 23)
        Me.SNInput.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Sender Name"
        '
        'FragileInput
        '
        Me.FragileInput.FormattingEnabled = True
        Me.FragileInput.Items.AddRange(New Object() {"Yes", "No"})
        Me.FragileInput.Location = New System.Drawing.Point(528, 62)
        Me.FragileInput.Name = "FragileInput"
        Me.FragileInput.Size = New System.Drawing.Size(75, 23)
        Me.FragileInput.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(469, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Fragile"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(271, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Weight (g)"
        '
        'ContentInput
        '
        Me.ContentInput.Location = New System.Drawing.Point(98, 61)
        Me.ContentInput.Name = "ContentInput"
        Me.ContentInput.Size = New System.Drawing.Size(149, 23)
        Me.ContentInput.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Content"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(22, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "New Order"
        '
        'GoBackOrdersButton
        '
        Me.GoBackOrdersButton.Location = New System.Drawing.Point(532, 14)
        Me.GoBackOrdersButton.Name = "GoBackOrdersButton"
        Me.GoBackOrdersButton.Size = New System.Drawing.Size(96, 24)
        Me.GoBackOrdersButton.TabIndex = 0
        Me.GoBackOrdersButton.Text = "Go Back"
        Me.GoBackOrdersButton.UseVisualStyleBackColor = True
        '
        'StaffNewOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "StaffNewOrder"
        Me.Size = New System.Drawing.Size(642, 450)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.WeightInput, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DaysInput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GoBackOrdersButton As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents PriceLabel As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents CreateOrderButton As Button
    Friend WithEvents RPINInput As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents SPINInput As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents RA3Input As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents SA3Input As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents SA2Input As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents RA2Input As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents RA1Input As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents SA1Input As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents RPInput As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents SPInput As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents RNInput As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents SNInput As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents FragileInput As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ContentInput As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DaysInput As NumericUpDown
    Friend WithEvents WeightInput As NumericUpDown
    Friend WithEvents CheckPriceButton As Button
End Class
