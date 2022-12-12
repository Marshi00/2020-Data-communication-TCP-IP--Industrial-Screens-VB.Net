<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRobotDatabase
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
        Me.lblInfoS = New System.Windows.Forms.Label()
        Me.lblInfoMod = New System.Windows.Forms.Label()
        Me.lblInfoMu = New System.Windows.Forms.Label()
        Me.txtSerialNumber = New System.Windows.Forms.TextBox()
        Me.txtModelNumber = New System.Windows.Forms.TextBox()
        Me.txtManufacturer = New System.Windows.Forms.TextBox()
        Me.cmbYearOfPurchase = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpStatus = New System.Windows.Forms.GroupBox()
        Me.rdbDead = New System.Windows.Forms.RadioButton()
        Me.rdbGood = New System.Windows.Forms.RadioButton()
        Me.rdbNew = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnRobotList = New System.Windows.Forms.Button()
        Me.lsbResult = New System.Windows.Forms.ListBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblInfoS
        '
        Me.lblInfoS.Location = New System.Drawing.Point(12, 47)
        Me.lblInfoS.Name = "lblInfoS"
        Me.lblInfoS.Size = New System.Drawing.Size(197, 23)
        Me.lblInfoS.TabIndex = 0
        Me.lblInfoS.Text = "Please enter the robot serial number "
        '
        'lblInfoMod
        '
        Me.lblInfoMod.Location = New System.Drawing.Point(12, 116)
        Me.lblInfoMod.Name = "lblInfoMod"
        Me.lblInfoMod.Size = New System.Drawing.Size(197, 23)
        Me.lblInfoMod.TabIndex = 1
        Me.lblInfoMod.Text = "Please enter the robot model number"
        '
        'lblInfoMu
        '
        Me.lblInfoMu.Location = New System.Drawing.Point(12, 81)
        Me.lblInfoMu.Name = "lblInfoMu"
        Me.lblInfoMu.Size = New System.Drawing.Size(197, 23)
        Me.lblInfoMu.TabIndex = 2
        Me.lblInfoMu.Text = "Please enter the robot manufacturer "
        '
        'txtSerialNumber
        '
        Me.txtSerialNumber.Location = New System.Drawing.Point(247, 44)
        Me.txtSerialNumber.Name = "txtSerialNumber"
        Me.txtSerialNumber.Size = New System.Drawing.Size(221, 20)
        Me.txtSerialNumber.TabIndex = 3
        '
        'txtModelNumber
        '
        Me.txtModelNumber.Location = New System.Drawing.Point(247, 113)
        Me.txtModelNumber.Name = "txtModelNumber"
        Me.txtModelNumber.Size = New System.Drawing.Size(221, 20)
        Me.txtModelNumber.TabIndex = 4
        '
        'txtManufacturer
        '
        Me.txtManufacturer.Location = New System.Drawing.Point(247, 78)
        Me.txtManufacturer.Name = "txtManufacturer"
        Me.txtManufacturer.Size = New System.Drawing.Size(221, 20)
        Me.txtManufacturer.TabIndex = 5
        '
        'cmbYearOfPurchase
        '
        Me.cmbYearOfPurchase.FormattingEnabled = True
        Me.cmbYearOfPurchase.Location = New System.Drawing.Point(247, 155)
        Me.cmbYearOfPurchase.Name = "cmbYearOfPurchase"
        Me.cmbYearOfPurchase.Size = New System.Drawing.Size(121, 21)
        Me.cmbYearOfPurchase.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 158)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 23)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Please enter the year of purchase"
        '
        'grpStatus
        '
        Me.grpStatus.Controls.Add(Me.rdbDead)
        Me.grpStatus.Controls.Add(Me.rdbGood)
        Me.grpStatus.Controls.Add(Me.rdbNew)
        Me.grpStatus.Location = New System.Drawing.Point(247, 198)
        Me.grpStatus.Name = "grpStatus"
        Me.grpStatus.Size = New System.Drawing.Size(200, 133)
        Me.grpStatus.TabIndex = 8
        Me.grpStatus.TabStop = False
        '
        'rdbDead
        '
        Me.rdbDead.AutoSize = True
        Me.rdbDead.Location = New System.Drawing.Point(15, 101)
        Me.rdbDead.Name = "rdbDead"
        Me.rdbDead.Size = New System.Drawing.Size(51, 17)
        Me.rdbDead.TabIndex = 9
        Me.rdbDead.TabStop = True
        Me.rdbDead.Text = "Dead"
        Me.rdbDead.UseVisualStyleBackColor = True
        '
        'rdbGood
        '
        Me.rdbGood.AutoSize = True
        Me.rdbGood.Location = New System.Drawing.Point(15, 66)
        Me.rdbGood.Name = "rdbGood"
        Me.rdbGood.Size = New System.Drawing.Size(51, 17)
        Me.rdbGood.TabIndex = 1
        Me.rdbGood.TabStop = True
        Me.rdbGood.Text = "Good"
        Me.rdbGood.UseVisualStyleBackColor = True
        '
        'rdbNew
        '
        Me.rdbNew.AutoSize = True
        Me.rdbNew.Location = New System.Drawing.Point(15, 32)
        Me.rdbNew.Name = "rdbNew"
        Me.rdbNew.Size = New System.Drawing.Size(47, 17)
        Me.rdbNew.TabIndex = 0
        Me.rdbNew.Text = "New"
        Me.rdbNew.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 267)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(197, 23)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Please select the robot status"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(26, 360)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(183, 78)
        Me.btnAdd.TabIndex = 10
        Me.btnAdd.Text = "Add Robot"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnRobotList
        '
        Me.btnRobotList.Location = New System.Drawing.Point(285, 360)
        Me.btnRobotList.Name = "btnRobotList"
        Me.btnRobotList.Size = New System.Drawing.Size(183, 78)
        Me.btnRobotList.TabIndex = 11
        Me.btnRobotList.Text = "Display Robot List"
        Me.btnRobotList.UseVisualStyleBackColor = True
        '
        'lsbResult
        '
        Me.lsbResult.FormattingEnabled = True
        Me.lsbResult.Location = New System.Drawing.Point(498, 44)
        Me.lsbResult.Name = "lsbResult"
        Me.lsbResult.Size = New System.Drawing.Size(349, 316)
        Me.lsbResult.TabIndex = 12
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(581, 366)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(183, 78)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmRobotDatabase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lsbResult)
        Me.Controls.Add(Me.btnRobotList)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.grpStatus)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbYearOfPurchase)
        Me.Controls.Add(Me.txtManufacturer)
        Me.Controls.Add(Me.txtModelNumber)
        Me.Controls.Add(Me.txtSerialNumber)
        Me.Controls.Add(Me.lblInfoMu)
        Me.Controls.Add(Me.lblInfoMod)
        Me.Controls.Add(Me.lblInfoS)
        Me.Name = "frmRobotDatabase"
        Me.Text = "Robot Database "
        Me.grpStatus.ResumeLayout(False)
        Me.grpStatus.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInfoS As Label
    Friend WithEvents lblInfoMod As Label
    Friend WithEvents lblInfoMu As Label
    Friend WithEvents txtSerialNumber As TextBox
    Friend WithEvents txtModelNumber As TextBox
    Friend WithEvents txtManufacturer As TextBox
    Friend WithEvents cmbYearOfPurchase As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents grpStatus As GroupBox
    Friend WithEvents rdbDead As RadioButton
    Friend WithEvents rdbGood As RadioButton
    Friend WithEvents rdbNew As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnRobotList As Button
    Friend WithEvents lsbResult As ListBox
    Friend WithEvents btnExit As Button
End Class
