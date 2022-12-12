<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTemperatureConverter
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
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.txtTemperature = New System.Windows.Forms.TextBox()
        Me.lblTemperature = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(27, 87)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(87, 38)
        Me.btnConvert.TabIndex = 0
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'txtTemperature
        '
        Me.txtTemperature.BackColor = System.Drawing.SystemColors.Control
        Me.txtTemperature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTemperature.Location = New System.Drawing.Point(240, 31)
        Me.txtTemperature.Name = "txtTemperature"
        Me.txtTemperature.Size = New System.Drawing.Size(148, 20)
        Me.txtTemperature.TabIndex = 1
        '
        'lblTemperature
        '
        Me.lblTemperature.Location = New System.Drawing.Point(24, 31)
        Me.lblTemperature.Name = "lblTemperature"
        Me.lblTemperature.Size = New System.Drawing.Size(173, 13)
        Me.lblTemperature.TabIndex = 2
        Me.lblTemperature.Text = "Please enter the temperature"
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblResult.Location = New System.Drawing.Point(240, 87)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(201, 63)
        Me.lblResult.TabIndex = 3
        '
        'frmTemperatureConverter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lblTemperature)
        Me.Controls.Add(Me.txtTemperature)
        Me.Controls.Add(Me.btnConvert)
        Me.Name = "frmTemperatureConverter"
        Me.Text = "Temperature Converter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnConvert As Button
    Friend WithEvents txtTemperature As TextBox
    Friend WithEvents lblTemperature As Label
    Friend WithEvents lblResult As Label
End Class
