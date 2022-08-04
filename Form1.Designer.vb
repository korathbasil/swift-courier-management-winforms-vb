<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.AppPanel = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'AppPanel
        '
        Me.AppPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AppPanel.Location = New System.Drawing.Point(0, 0)
        Me.AppPanel.Name = "AppPanel"
        Me.AppPanel.Size = New System.Drawing.Size(800, 450)
        Me.AppPanel.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.AppPanel)
        Me.Name = "Form1"
        Me.Text = "Swift Courier"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AppPanel As Panel
End Class
