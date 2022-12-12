<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGearCalculator
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
        Me.lblInfoA = New System.Windows.Forms.Label()
        Me.lblInfoB = New System.Windows.Forms.Label()
        Me.lblInfoC = New System.Windows.Forms.Label()
        Me.lblInfoD = New System.Windows.Forms.Label()
        Me.txtGearTeethA = New System.Windows.Forms.TextBox()
        Me.txtGearTeethB = New System.Windows.Forms.TextBox()
        Me.txtGearTeethC = New System.Windows.Forms.TextBox()
        Me.txtGearTeethD = New System.Windows.Forms.TextBox()
        Me.lblGearTotalInfo = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblInfoTorque = New System.Windows.Forms.Label()
        Me.nudInputTorque = New System.Windows.Forms.NumericUpDown()
        Me.lblSpeedInfo = New System.Windows.Forms.Label()
        Me.cmbInputSpeed = New System.Windows.Forms.ComboBox()
        Me.btnGearTorqueRatioCalculator = New System.Windows.Forms.Button()
        Me.btnSpeedCalculator = New System.Windows.Forms.Button()
        Me.lblRatioTotalResult = New System.Windows.Forms.Label()
        Me.lblOutputTorqueResult = New System.Windows.Forms.Label()
        Me.lblInfoOutputTorque = New System.Windows.Forms.Label()
        Me.lblOutputSpeedResult = New System.Windows.Forms.Label()
        Me.lblInfoOutputSpeed = New System.Windows.Forms.Label()
        CType(Me.nudInputTorque, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblInfoA
        '
        Me.lblInfoA.AutoSize = True
        Me.lblInfoA.Location = New System.Drawing.Point(12, 27)
        Me.lblInfoA.Name = "lblInfoA"
        Me.lblInfoA.Size = New System.Drawing.Size(215, 13)
        Me.lblInfoA.TabIndex = 0
        Me.lblInfoA.Text = "Please enter the number of teeth for Gear A "
        '
        'lblInfoB
        '
        Me.lblInfoB.AutoSize = True
        Me.lblInfoB.Location = New System.Drawing.Point(12, 61)
        Me.lblInfoB.Name = "lblInfoB"
        Me.lblInfoB.Size = New System.Drawing.Size(212, 13)
        Me.lblInfoB.TabIndex = 1
        Me.lblInfoB.Text = "Please enter the number of teeth for Gear B"
        '
        'lblInfoC
        '
        Me.lblInfoC.AutoSize = True
        Me.lblInfoC.Location = New System.Drawing.Point(12, 98)
        Me.lblInfoC.Name = "lblInfoC"
        Me.lblInfoC.Size = New System.Drawing.Size(215, 13)
        Me.lblInfoC.TabIndex = 2
        Me.lblInfoC.Text = "Please enter the number of teeth for Gear C "
        '
        'lblInfoD
        '
        Me.lblInfoD.AutoSize = True
        Me.lblInfoD.Location = New System.Drawing.Point(11, 134)
        Me.lblInfoD.Name = "lblInfoD"
        Me.lblInfoD.Size = New System.Drawing.Size(216, 13)
        Me.lblInfoD.TabIndex = 3
        Me.lblInfoD.Text = "Please enter the number of teeth for Gear D "
        '
        'txtGearTeethA
        '
        Me.txtGearTeethA.Location = New System.Drawing.Point(273, 27)
        Me.txtGearTeethA.Name = "txtGearTeethA"
        Me.txtGearTeethA.Size = New System.Drawing.Size(135, 20)
        Me.txtGearTeethA.TabIndex = 4
        '
        'txtGearTeethB
        '
        Me.txtGearTeethB.Location = New System.Drawing.Point(273, 61)
        Me.txtGearTeethB.Name = "txtGearTeethB"
        Me.txtGearTeethB.Size = New System.Drawing.Size(135, 20)
        Me.txtGearTeethB.TabIndex = 5
        '
        'txtGearTeethC
        '
        Me.txtGearTeethC.Location = New System.Drawing.Point(273, 91)
        Me.txtGearTeethC.Name = "txtGearTeethC"
        Me.txtGearTeethC.Size = New System.Drawing.Size(135, 20)
        Me.txtGearTeethC.TabIndex = 6
        '
        'txtGearTeethD
        '
        Me.txtGearTeethD.Location = New System.Drawing.Point(273, 127)
        Me.txtGearTeethD.Name = "txtGearTeethD"
        Me.txtGearTeethD.Size = New System.Drawing.Size(135, 20)
        Me.txtGearTeethD.TabIndex = 7
        '
        'lblGearTotalInfo
        '
        Me.lblGearTotalInfo.AutoSize = True
        Me.lblGearTotalInfo.Location = New System.Drawing.Point(431, 46)
        Me.lblGearTotalInfo.Name = "lblGearTotalInfo"
        Me.lblGearTotalInfo.Size = New System.Drawing.Size(85, 13)
        Me.lblGearTotalInfo.TabIndex = 10
        Me.lblGearTotalInfo.Text = "Total Gear Ratio"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(627, 364)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(134, 60)
        Me.btnExit.TabIndex = 16
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblInfoTorque
        '
        Me.lblInfoTorque.AutoSize = True
        Me.lblInfoTorque.Location = New System.Drawing.Point(12, 193)
        Me.lblInfoTorque.Name = "lblInfoTorque"
        Me.lblInfoTorque.Size = New System.Drawing.Size(151, 13)
        Me.lblInfoTorque.TabIndex = 17
        Me.lblInfoTorque.Text = "Please select the input Torque"
        '
        'nudInputTorque
        '
        Me.nudInputTorque.Location = New System.Drawing.Point(273, 186)
        Me.nudInputTorque.Name = "nudInputTorque"
        Me.nudInputTorque.Size = New System.Drawing.Size(135, 20)
        Me.nudInputTorque.TabIndex = 18
        '
        'lblSpeedInfo
        '
        Me.lblSpeedInfo.AutoSize = True
        Me.lblSpeedInfo.Location = New System.Drawing.Point(12, 253)
        Me.lblSpeedInfo.Name = "lblSpeedInfo"
        Me.lblSpeedInfo.Size = New System.Drawing.Size(148, 13)
        Me.lblSpeedInfo.TabIndex = 19
        Me.lblSpeedInfo.Text = "Please select the input Speed"
        '
        'cmbInputSpeed
        '
        Me.cmbInputSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbInputSpeed.FormattingEnabled = True
        Me.cmbInputSpeed.Location = New System.Drawing.Point(273, 245)
        Me.cmbInputSpeed.Name = "cmbInputSpeed"
        Me.cmbInputSpeed.Size = New System.Drawing.Size(134, 21)
        Me.cmbInputSpeed.TabIndex = 20
        '
        'btnGearTorqueRatioCalculator
        '
        Me.btnGearTorqueRatioCalculator.Location = New System.Drawing.Point(15, 336)
        Me.btnGearTorqueRatioCalculator.Name = "btnGearTorqueRatioCalculator"
        Me.btnGearTorqueRatioCalculator.Size = New System.Drawing.Size(159, 78)
        Me.btnGearTorqueRatioCalculator.TabIndex = 22
        Me.btnGearTorqueRatioCalculator.Text = "Gear Torque/Ratio Calculator"
        Me.btnGearTorqueRatioCalculator.UseVisualStyleBackColor = True
        '
        'btnSpeedCalculator
        '
        Me.btnSpeedCalculator.Location = New System.Drawing.Point(248, 336)
        Me.btnSpeedCalculator.Name = "btnSpeedCalculator"
        Me.btnSpeedCalculator.Size = New System.Drawing.Size(159, 78)
        Me.btnSpeedCalculator.TabIndex = 23
        Me.btnSpeedCalculator.Text = "Speed Calculator"
        Me.btnSpeedCalculator.UseVisualStyleBackColor = True
        '
        'lblRatioTotalResult
        '
        Me.lblRatioTotalResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRatioTotalResult.Location = New System.Drawing.Point(567, 39)
        Me.lblRatioTotalResult.Name = "lblRatioTotalResult"
        Me.lblRatioTotalResult.Size = New System.Drawing.Size(121, 20)
        Me.lblRatioTotalResult.TabIndex = 14
        '
        'lblOutputTorqueResult
        '
        Me.lblOutputTorqueResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOutputTorqueResult.Location = New System.Drawing.Point(567, 106)
        Me.lblOutputTorqueResult.Name = "lblOutputTorqueResult"
        Me.lblOutputTorqueResult.Size = New System.Drawing.Size(121, 20)
        Me.lblOutputTorqueResult.TabIndex = 11
        '
        'lblInfoOutputTorque
        '
        Me.lblInfoOutputTorque.AutoSize = True
        Me.lblInfoOutputTorque.Location = New System.Drawing.Point(432, 113)
        Me.lblInfoOutputTorque.Name = "lblInfoOutputTorque"
        Me.lblInfoOutputTorque.Size = New System.Drawing.Size(76, 13)
        Me.lblInfoOutputTorque.TabIndex = 8
        Me.lblInfoOutputTorque.Text = "Output Torque"
        '
        'lblOutputSpeedResult
        '
        Me.lblOutputSpeedResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOutputSpeedResult.Location = New System.Drawing.Point(567, 210)
        Me.lblOutputSpeedResult.Name = "lblOutputSpeedResult"
        Me.lblOutputSpeedResult.Size = New System.Drawing.Size(121, 20)
        Me.lblOutputSpeedResult.TabIndex = 15
        '
        'lblInfoOutputSpeed
        '
        Me.lblInfoOutputSpeed.AutoSize = True
        Me.lblInfoOutputSpeed.Location = New System.Drawing.Point(432, 217)
        Me.lblInfoOutputSpeed.Name = "lblInfoOutputSpeed"
        Me.lblInfoOutputSpeed.Size = New System.Drawing.Size(73, 13)
        Me.lblInfoOutputSpeed.TabIndex = 9
        Me.lblInfoOutputSpeed.Text = "Output Speed"
        '
        'frmGearCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSpeedCalculator)
        Me.Controls.Add(Me.btnGearTorqueRatioCalculator)
        Me.Controls.Add(Me.cmbInputSpeed)
        Me.Controls.Add(Me.lblSpeedInfo)
        Me.Controls.Add(Me.nudInputTorque)
        Me.Controls.Add(Me.lblInfoTorque)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblOutputSpeedResult)
        Me.Controls.Add(Me.lblRatioTotalResult)
        Me.Controls.Add(Me.lblOutputTorqueResult)
        Me.Controls.Add(Me.lblGearTotalInfo)
        Me.Controls.Add(Me.lblInfoOutputSpeed)
        Me.Controls.Add(Me.lblInfoOutputTorque)
        Me.Controls.Add(Me.txtGearTeethD)
        Me.Controls.Add(Me.txtGearTeethC)
        Me.Controls.Add(Me.txtGearTeethB)
        Me.Controls.Add(Me.txtGearTeethA)
        Me.Controls.Add(Me.lblInfoD)
        Me.Controls.Add(Me.lblInfoC)
        Me.Controls.Add(Me.lblInfoB)
        Me.Controls.Add(Me.lblInfoA)
        Me.Name = "frmGearCalculator"
        Me.Text = "Gear Calculator-Mohammad Arshian"
        CType(Me.nudInputTorque, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInfoA As Label
    Friend WithEvents lblInfoB As Label
    Friend WithEvents lblInfoC As Label
    Friend WithEvents lblInfoD As Label
    Friend WithEvents txtGearTeethA As TextBox
    Friend WithEvents txtGearTeethB As TextBox
    Friend WithEvents txtGearTeethC As TextBox
    Friend WithEvents txtGearTeethD As TextBox
    Friend WithEvents lblGearTotalInfo As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents lblInfoTorque As Label
    Friend WithEvents nudInputTorque As NumericUpDown
    Friend WithEvents lblSpeedInfo As Label
    Friend WithEvents cmbInputSpeed As ComboBox
    Friend WithEvents btnGearTorqueRatioCalculator As Button
    Friend WithEvents btnSpeedCalculator As Button
    Friend WithEvents lblRatioTotalResult As Label
    Friend WithEvents lblOutputTorqueResult As Label
    Friend WithEvents lblInfoOutputTorque As Label
    Friend WithEvents lblOutputSpeedResult As Label
    Friend WithEvents lblInfoOutputSpeed As Label
End Class
