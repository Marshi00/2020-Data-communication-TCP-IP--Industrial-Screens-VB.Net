<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCncMachine
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
        Me.lblInfoStockSize = New System.Windows.Forms.Label()
        Me.lblInfoMaxStockSize = New System.Windows.Forms.Label()
        Me.lblInfoSpindleSpeed = New System.Windows.Forms.Label()
        Me.lblInfoRpmReq = New System.Windows.Forms.Label()
        Me.cmbMinStockSize = New System.Windows.Forms.ComboBox()
        Me.cmbSpindleSpeed = New System.Windows.Forms.ComboBox()
        Me.cmbMaxStockSize = New System.Windows.Forms.ComboBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lsbResult = New System.Windows.Forms.ListBox()
        Me.rdbSize1 = New System.Windows.Forms.RadioButton()
        Me.rdbSize4 = New System.Windows.Forms.RadioButton()
        Me.rdbSize3 = New System.Windows.Forms.RadioButton()
        Me.rdbSize2 = New System.Windows.Forms.RadioButton()
        Me.grpSize = New System.Windows.Forms.GroupBox()
        Me.grpSize.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblInfoStockSize
        '
        Me.lblInfoStockSize.AutoSize = True
        Me.lblInfoStockSize.Location = New System.Drawing.Point(21, 26)
        Me.lblInfoStockSize.Name = "lblInfoStockSize"
        Me.lblInfoStockSize.Size = New System.Drawing.Size(142, 13)
        Me.lblInfoStockSize.TabIndex = 0
        Me.lblInfoStockSize.Text = "Minimum Stock Size(inches):"
        '
        'lblInfoMaxStockSize
        '
        Me.lblInfoMaxStockSize.AutoSize = True
        Me.lblInfoMaxStockSize.Location = New System.Drawing.Point(21, 90)
        Me.lblInfoMaxStockSize.Name = "lblInfoMaxStockSize"
        Me.lblInfoMaxStockSize.Size = New System.Drawing.Size(145, 13)
        Me.lblInfoMaxStockSize.TabIndex = 1
        Me.lblInfoMaxStockSize.Text = "Maximum Stock Size(inches):"
        '
        'lblInfoSpindleSpeed
        '
        Me.lblInfoSpindleSpeed.AutoSize = True
        Me.lblInfoSpindleSpeed.Location = New System.Drawing.Point(21, 148)
        Me.lblInfoSpindleSpeed.Name = "lblInfoSpindleSpeed"
        Me.lblInfoSpindleSpeed.Size = New System.Drawing.Size(112, 13)
        Me.lblInfoSpindleSpeed.TabIndex = 2
        Me.lblInfoSpindleSpeed.Text = "Spindle Speed (RPM):"
        '
        'lblInfoRpmReq
        '
        Me.lblInfoRpmReq.AutoSize = True
        Me.lblInfoRpmReq.Location = New System.Drawing.Point(21, 250)
        Me.lblInfoRpmReq.Name = "lblInfoRpmReq"
        Me.lblInfoRpmReq.Size = New System.Drawing.Size(268, 13)
        Me.lblInfoRpmReq.TabIndex = 5
        Me.lblInfoRpmReq.Text = "RPM required for various cutting speeds and diameters:"
        '
        'cmbMinStockSize
        '
        Me.cmbMinStockSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMinStockSize.FormattingEnabled = True
        Me.cmbMinStockSize.Location = New System.Drawing.Point(284, 26)
        Me.cmbMinStockSize.Name = "cmbMinStockSize"
        Me.cmbMinStockSize.Size = New System.Drawing.Size(146, 21)
        Me.cmbMinStockSize.TabIndex = 6
        '
        'cmbSpindleSpeed
        '
        Me.cmbSpindleSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSpindleSpeed.FormattingEnabled = True
        Me.cmbSpindleSpeed.Location = New System.Drawing.Point(284, 140)
        Me.cmbSpindleSpeed.Name = "cmbSpindleSpeed"
        Me.cmbSpindleSpeed.Size = New System.Drawing.Size(146, 21)
        Me.cmbSpindleSpeed.TabIndex = 7
        '
        'cmbMaxStockSize
        '
        Me.cmbMaxStockSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMaxStockSize.FormattingEnabled = True
        Me.cmbMaxStockSize.Location = New System.Drawing.Point(284, 87)
        Me.cmbMaxStockSize.Name = "cmbMaxStockSize"
        Me.cmbMaxStockSize.Size = New System.Drawing.Size(146, 21)
        Me.cmbMaxStockSize.TabIndex = 8
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(260, 176)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(170, 61)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(24, 176)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(184, 61)
        Me.btnCalculate.TabIndex = 10
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lsbResult
        '
        Me.lsbResult.FormattingEnabled = True
        Me.lsbResult.Location = New System.Drawing.Point(24, 279)
        Me.lsbResult.Name = "lsbResult"
        Me.lsbResult.Size = New System.Drawing.Size(764, 238)
        Me.lsbResult.TabIndex = 11
        '
        'rdbSize1
        '
        Me.rdbSize1.AutoSize = True
        Me.rdbSize1.Location = New System.Drawing.Point(6, 23)
        Me.rdbSize1.Name = "rdbSize1"
        Me.rdbSize1.Size = New System.Drawing.Size(57, 17)
        Me.rdbSize1.TabIndex = 12
        Me.rdbSize1.TabStop = True
        Me.rdbSize1.Text = "0.125"""
        Me.rdbSize1.UseVisualStyleBackColor = True
        '
        'rdbSize4
        '
        Me.rdbSize4.AutoSize = True
        Me.rdbSize4.Location = New System.Drawing.Point(6, 92)
        Me.rdbSize4.Name = "rdbSize4"
        Me.rdbSize4.Size = New System.Drawing.Size(57, 17)
        Me.rdbSize4.TabIndex = 13
        Me.rdbSize4.TabStop = True
        Me.rdbSize4.Text = "0.500"""
        Me.rdbSize4.UseVisualStyleBackColor = True
        '
        'rdbSize3
        '
        Me.rdbSize3.AutoSize = True
        Me.rdbSize3.Location = New System.Drawing.Point(6, 69)
        Me.rdbSize3.Name = "rdbSize3"
        Me.rdbSize3.Size = New System.Drawing.Size(57, 17)
        Me.rdbSize3.TabIndex = 14
        Me.rdbSize3.TabStop = True
        Me.rdbSize3.Text = "0.375"""
        Me.rdbSize3.UseVisualStyleBackColor = True
        '
        'rdbSize2
        '
        Me.rdbSize2.AutoSize = True
        Me.rdbSize2.Location = New System.Drawing.Point(6, 46)
        Me.rdbSize2.Name = "rdbSize2"
        Me.rdbSize2.Size = New System.Drawing.Size(57, 17)
        Me.rdbSize2.TabIndex = 15
        Me.rdbSize2.TabStop = True
        Me.rdbSize2.Text = "0.250"""
        Me.rdbSize2.UseVisualStyleBackColor = True
        '
        'grpSize
        '
        Me.grpSize.Controls.Add(Me.rdbSize1)
        Me.grpSize.Controls.Add(Me.rdbSize4)
        Me.grpSize.Controls.Add(Me.rdbSize3)
        Me.grpSize.Controls.Add(Me.rdbSize2)
        Me.grpSize.Location = New System.Drawing.Point(446, 45)
        Me.grpSize.Name = "grpSize"
        Me.grpSize.Size = New System.Drawing.Size(142, 127)
        Me.grpSize.TabIndex = 16
        Me.grpSize.TabStop = False
        Me.grpSize.Text = "Stock Size Increment"
        '
        'frmCncMachine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 536)
        Me.Controls.Add(Me.grpSize)
        Me.Controls.Add(Me.lsbResult)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.cmbMaxStockSize)
        Me.Controls.Add(Me.cmbSpindleSpeed)
        Me.Controls.Add(Me.cmbMinStockSize)
        Me.Controls.Add(Me.lblInfoRpmReq)
        Me.Controls.Add(Me.lblInfoSpindleSpeed)
        Me.Controls.Add(Me.lblInfoMaxStockSize)
        Me.Controls.Add(Me.lblInfoStockSize)
        Me.Name = "frmCncMachine"
        Me.Text = "CNC Machine"
        Me.grpSize.ResumeLayout(False)
        Me.grpSize.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInfoStockSize As Label
    Friend WithEvents lblInfoMaxStockSize As Label
    Friend WithEvents lblInfoSpindleSpeed As Label
    Friend WithEvents lblInfoRpmReq As Label
    Friend WithEvents cmbMinStockSize As ComboBox
    Friend WithEvents cmbSpindleSpeed As ComboBox
    Friend WithEvents cmbMaxStockSize As ComboBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lsbResult As ListBox
    Friend WithEvents rdbSize1 As RadioButton
    Friend WithEvents rdbSize4 As RadioButton
    Friend WithEvents rdbSize3 As RadioButton
    Friend WithEvents rdbSize2 As RadioButton
    Friend WithEvents grpSize As GroupBox
End Class
