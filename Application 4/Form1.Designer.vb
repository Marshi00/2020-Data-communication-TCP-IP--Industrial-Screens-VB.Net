<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArrays
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
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnSort = New System.Windows.Forms.Button()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.cmbLowerRange = New System.Windows.Forms.ComboBox()
        Me.cmbUpperRange = New System.Windows.Forms.ComboBox()
        Me.lblInfoLR = New System.Windows.Forms.Label()
        Me.lblInfoUR = New System.Windows.Forms.Label()
        Me.rdbOven1 = New System.Windows.Forms.RadioButton()
        Me.rdbOven2 = New System.Windows.Forms.RadioButton()
        Me.rdbAll = New System.Windows.Forms.RadioButton()
        Me.grpOven = New System.Windows.Forms.GroupBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lsbResult = New System.Windows.Forms.ListBox()
        Me.btnWriteData = New System.Windows.Forms.Button()
        Me.btnLogErrors = New System.Windows.Forms.Button()
        Me.grpOven.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(10, 288)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(137, 39)
        Me.btnDisplay.TabIndex = 0
        Me.btnDisplay.Text = "Display Data"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnSort
        '
        Me.btnSort.Location = New System.Drawing.Point(10, 342)
        Me.btnSort.Name = "btnSort"
        Me.btnSort.Size = New System.Drawing.Size(137, 39)
        Me.btnSort.TabIndex = 2
        Me.btnSort.Text = "Sort Data"
        Me.btnSort.UseVisualStyleBackColor = True
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Location = New System.Drawing.Point(7, 53)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(162, 13)
        Me.lblInfo.TabIndex = 3
        Me.lblInfo.Text = "Please Select the Display Range"
        '
        'cmbLowerRange
        '
        Me.cmbLowerRange.FormattingEnabled = True
        Me.cmbLowerRange.Location = New System.Drawing.Point(211, 127)
        Me.cmbLowerRange.Name = "cmbLowerRange"
        Me.cmbLowerRange.Size = New System.Drawing.Size(148, 21)
        Me.cmbLowerRange.TabIndex = 4
        '
        'cmbUpperRange
        '
        Me.cmbUpperRange.FormattingEnabled = True
        Me.cmbUpperRange.Location = New System.Drawing.Point(211, 199)
        Me.cmbUpperRange.Name = "cmbUpperRange"
        Me.cmbUpperRange.Size = New System.Drawing.Size(148, 21)
        Me.cmbUpperRange.TabIndex = 5
        '
        'lblInfoLR
        '
        Me.lblInfoLR.AutoSize = True
        Me.lblInfoLR.Location = New System.Drawing.Point(12, 130)
        Me.lblInfoLR.Name = "lblInfoLR"
        Me.lblInfoLR.Size = New System.Drawing.Size(157, 13)
        Me.lblInfoLR.TabIndex = 6
        Me.lblInfoLR.Text = "Please Select the Lower Range"
        '
        'lblInfoUR
        '
        Me.lblInfoUR.AutoSize = True
        Me.lblInfoUR.Location = New System.Drawing.Point(12, 202)
        Me.lblInfoUR.Name = "lblInfoUR"
        Me.lblInfoUR.Size = New System.Drawing.Size(157, 13)
        Me.lblInfoUR.TabIndex = 7
        Me.lblInfoUR.Text = "Please Select the Upper Range"
        '
        'rdbOven1
        '
        Me.rdbOven1.AutoSize = True
        Me.rdbOven1.Location = New System.Drawing.Point(26, 18)
        Me.rdbOven1.Name = "rdbOven1"
        Me.rdbOven1.Size = New System.Drawing.Size(60, 17)
        Me.rdbOven1.TabIndex = 8
        Me.rdbOven1.TabStop = True
        Me.rdbOven1.Text = "Oven 1"
        Me.rdbOven1.UseVisualStyleBackColor = True
        '
        'rdbOven2
        '
        Me.rdbOven2.AutoSize = True
        Me.rdbOven2.Location = New System.Drawing.Point(26, 41)
        Me.rdbOven2.Name = "rdbOven2"
        Me.rdbOven2.Size = New System.Drawing.Size(60, 17)
        Me.rdbOven2.TabIndex = 9
        Me.rdbOven2.TabStop = True
        Me.rdbOven2.Text = "Oven 2"
        Me.rdbOven2.UseVisualStyleBackColor = True
        '
        'rdbAll
        '
        Me.rdbAll.AutoSize = True
        Me.rdbAll.Location = New System.Drawing.Point(26, 64)
        Me.rdbAll.Name = "rdbAll"
        Me.rdbAll.Size = New System.Drawing.Size(36, 17)
        Me.rdbAll.TabIndex = 10
        Me.rdbAll.TabStop = True
        Me.rdbAll.Text = "All"
        Me.rdbAll.UseVisualStyleBackColor = True
        '
        'grpOven
        '
        Me.grpOven.Controls.Add(Me.rdbAll)
        Me.grpOven.Controls.Add(Me.rdbOven2)
        Me.grpOven.Controls.Add(Me.rdbOven1)
        Me.grpOven.Location = New System.Drawing.Point(211, 12)
        Me.grpOven.Name = "grpOven"
        Me.grpOven.Size = New System.Drawing.Size(138, 102)
        Me.grpOven.TabIndex = 11
        Me.grpOven.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(89, 399)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(137, 39)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lsbResult
        '
        Me.lsbResult.FormattingEnabled = True
        Me.lsbResult.Location = New System.Drawing.Point(380, 12)
        Me.lsbResult.Name = "lsbResult"
        Me.lsbResult.Size = New System.Drawing.Size(406, 407)
        Me.lsbResult.TabIndex = 13
        '
        'btnWriteData
        '
        Me.btnWriteData.Location = New System.Drawing.Point(192, 288)
        Me.btnWriteData.Name = "btnWriteData"
        Me.btnWriteData.Size = New System.Drawing.Size(137, 39)
        Me.btnWriteData.TabIndex = 14
        Me.btnWriteData.Text = "Write to Data Files "
        Me.btnWriteData.UseVisualStyleBackColor = True
        '
        'btnLogErrors
        '
        Me.btnLogErrors.Location = New System.Drawing.Point(192, 342)
        Me.btnLogErrors.Name = "btnLogErrors"
        Me.btnLogErrors.Size = New System.Drawing.Size(137, 39)
        Me.btnLogErrors.TabIndex = 15
        Me.btnLogErrors.Text = "Log Errors"
        Me.btnLogErrors.UseVisualStyleBackColor = True
        '
        'frmArrays
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnLogErrors)
        Me.Controls.Add(Me.btnWriteData)
        Me.Controls.Add(Me.lsbResult)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.grpOven)
        Me.Controls.Add(Me.lblInfoUR)
        Me.Controls.Add(Me.lblInfoLR)
        Me.Controls.Add(Me.cmbUpperRange)
        Me.Controls.Add(Me.cmbLowerRange)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.btnSort)
        Me.Controls.Add(Me.btnDisplay)
        Me.Name = "frmArrays"
        Me.Text = "Form1"
        Me.grpOven.ResumeLayout(False)
        Me.grpOven.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnSort As Button
    Friend WithEvents lblInfo As Label
    Friend WithEvents cmbLowerRange As ComboBox
    Friend WithEvents cmbUpperRange As ComboBox
    Friend WithEvents lblInfoLR As Label
    Friend WithEvents lblInfoUR As Label
    Friend WithEvents rdbOven1 As RadioButton
    Friend WithEvents rdbOven2 As RadioButton
    Friend WithEvents rdbAll As RadioButton
    Friend WithEvents grpOven As GroupBox
    Friend WithEvents btnExit As Button
    Friend WithEvents lsbResult As ListBox
    Friend WithEvents btnWriteData As Button
    Friend WithEvents btnLogErrors As Button
End Class
