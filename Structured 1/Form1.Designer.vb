<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdhesiveRobot
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
        Me.lblInfoDiameter = New System.Windows.Forms.Label()
        Me.txtCircleDiameter = New System.Windows.Forms.TextBox()
        Me.lblInfoNumberDots = New System.Windows.Forms.Label()
        Me.rdbDot2 = New System.Windows.Forms.RadioButton()
        Me.rdbDot4 = New System.Windows.Forms.RadioButton()
        Me.rdbDot8 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblInfoFirstDotLocation = New System.Windows.Forms.Label()
        Me.txtFirstDotLocation = New System.Windows.Forms.TextBox()
        Me.lblInfoYcord = New System.Windows.Forms.Label()
        Me.lblInfoXcord = New System.Windows.Forms.Label()
        Me.txtXcordCenterPoint = New System.Windows.Forms.TextBox()
        Me.txtYcordCenterPoint = New System.Windows.Forms.TextBox()
        Me.lsbResultDotCord = New System.Windows.Forms.ListBox()
        Me.lblInfoSkip = New System.Windows.Forms.Label()
        Me.chbSkipPlacement = New System.Windows.Forms.CheckBox()
        Me.cmbSkipPlacement = New System.Windows.Forms.ComboBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblInfoDiameter
        '
        Me.lblInfoDiameter.Location = New System.Drawing.Point(12, 29)
        Me.lblInfoDiameter.Name = "lblInfoDiameter"
        Me.lblInfoDiameter.Size = New System.Drawing.Size(237, 18)
        Me.lblInfoDiameter.TabIndex = 0
        Me.lblInfoDiameter.Text = "Please enter the patern circle diameter in mm"
        '
        'txtCircleDiameter
        '
        Me.txtCircleDiameter.Location = New System.Drawing.Point(255, 26)
        Me.txtCircleDiameter.Name = "txtCircleDiameter"
        Me.txtCircleDiameter.Size = New System.Drawing.Size(100, 20)
        Me.txtCircleDiameter.TabIndex = 1
        '
        'lblInfoNumberDots
        '
        Me.lblInfoNumberDots.Location = New System.Drawing.Point(12, 118)
        Me.lblInfoNumberDots.Name = "lblInfoNumberDots"
        Me.lblInfoNumberDots.Size = New System.Drawing.Size(231, 18)
        Me.lblInfoNumberDots.TabIndex = 2
        Me.lblInfoNumberDots.Text = "Pick the number of the adhesive to be placed"
        '
        'rdbDot2
        '
        Me.rdbDot2.AutoSize = True
        Me.rdbDot2.Location = New System.Drawing.Point(6, 18)
        Me.rdbDot2.Name = "rdbDot2"
        Me.rdbDot2.Size = New System.Drawing.Size(31, 17)
        Me.rdbDot2.TabIndex = 3
        Me.rdbDot2.TabStop = True
        Me.rdbDot2.Text = "2"
        Me.rdbDot2.UseVisualStyleBackColor = True
        '
        'rdbDot4
        '
        Me.rdbDot4.AutoSize = True
        Me.rdbDot4.Location = New System.Drawing.Point(6, 41)
        Me.rdbDot4.Name = "rdbDot4"
        Me.rdbDot4.Size = New System.Drawing.Size(31, 17)
        Me.rdbDot4.TabIndex = 4
        Me.rdbDot4.TabStop = True
        Me.rdbDot4.Text = "4"
        Me.rdbDot4.UseVisualStyleBackColor = True
        '
        'rdbDot8
        '
        Me.rdbDot8.AutoSize = True
        Me.rdbDot8.Location = New System.Drawing.Point(6, 64)
        Me.rdbDot8.Name = "rdbDot8"
        Me.rdbDot8.Size = New System.Drawing.Size(31, 17)
        Me.rdbDot8.TabIndex = 5
        Me.rdbDot8.TabStop = True
        Me.rdbDot8.Text = "8"
        Me.rdbDot8.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbDot2)
        Me.GroupBox1.Controls.Add(Me.rdbDot8)
        Me.GroupBox1.Controls.Add(Me.rdbDot4)
        Me.GroupBox1.Location = New System.Drawing.Point(249, 101)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(106, 100)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pick Adhesive"
        '
        'lblInfoFirstDotLocation
        '
        Me.lblInfoFirstDotLocation.Location = New System.Drawing.Point(12, 69)
        Me.lblInfoFirstDotLocation.Name = "lblInfoFirstDotLocation"
        Me.lblInfoFirstDotLocation.Size = New System.Drawing.Size(237, 18)
        Me.lblInfoFirstDotLocation.TabIndex = 7
        Me.lblInfoFirstDotLocation.Text = "Please enter the offset angle for the first dot"
        '
        'txtFirstDotLocation
        '
        Me.txtFirstDotLocation.Location = New System.Drawing.Point(255, 66)
        Me.txtFirstDotLocation.Name = "txtFirstDotLocation"
        Me.txtFirstDotLocation.Size = New System.Drawing.Size(100, 20)
        Me.txtFirstDotLocation.TabIndex = 8
        '
        'lblInfoYcord
        '
        Me.lblInfoYcord.Location = New System.Drawing.Point(12, 272)
        Me.lblInfoYcord.Name = "lblInfoYcord"
        Me.lblInfoYcord.Size = New System.Drawing.Size(237, 18)
        Me.lblInfoYcord.TabIndex = 9
        Me.lblInfoYcord.Text = "Please enter the Y position of center point in mm"
        '
        'lblInfoXcord
        '
        Me.lblInfoXcord.Location = New System.Drawing.Point(12, 216)
        Me.lblInfoXcord.Name = "lblInfoXcord"
        Me.lblInfoXcord.Size = New System.Drawing.Size(237, 18)
        Me.lblInfoXcord.TabIndex = 10
        Me.lblInfoXcord.Text = "Please enter the X position of center point in mm"
        '
        'txtXcordCenterPoint
        '
        Me.txtXcordCenterPoint.Location = New System.Drawing.Point(255, 216)
        Me.txtXcordCenterPoint.Name = "txtXcordCenterPoint"
        Me.txtXcordCenterPoint.Size = New System.Drawing.Size(100, 20)
        Me.txtXcordCenterPoint.TabIndex = 11
        '
        'txtYcordCenterPoint
        '
        Me.txtYcordCenterPoint.Location = New System.Drawing.Point(255, 269)
        Me.txtYcordCenterPoint.Name = "txtYcordCenterPoint"
        Me.txtYcordCenterPoint.Size = New System.Drawing.Size(100, 20)
        Me.txtYcordCenterPoint.TabIndex = 12
        '
        'lsbResultDotCord
        '
        Me.lsbResultDotCord.FormattingEnabled = True
        Me.lsbResultDotCord.Location = New System.Drawing.Point(467, 10)
        Me.lsbResultDotCord.Name = "lsbResultDotCord"
        Me.lsbResultDotCord.Size = New System.Drawing.Size(303, 511)
        Me.lsbResultDotCord.TabIndex = 13
        '
        'lblInfoSkip
        '
        Me.lblInfoSkip.Location = New System.Drawing.Point(12, 311)
        Me.lblInfoSkip.Name = "lblInfoSkip"
        Me.lblInfoSkip.Size = New System.Drawing.Size(237, 18)
        Me.lblInfoSkip.TabIndex = 14
        Me.lblInfoSkip.Text = "Please Select if you like to skip a placement"
        '
        'chbSkipPlacement
        '
        Me.chbSkipPlacement.AutoSize = True
        Me.chbSkipPlacement.Location = New System.Drawing.Point(255, 310)
        Me.chbSkipPlacement.Name = "chbSkipPlacement"
        Me.chbSkipPlacement.Size = New System.Drawing.Size(15, 14)
        Me.chbSkipPlacement.TabIndex = 15
        Me.chbSkipPlacement.UseVisualStyleBackColor = True
        '
        'cmbSkipPlacement
        '
        Me.cmbSkipPlacement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSkipPlacement.FormattingEnabled = True
        Me.cmbSkipPlacement.Location = New System.Drawing.Point(276, 303)
        Me.cmbSkipPlacement.Name = "cmbSkipPlacement"
        Me.cmbSkipPlacement.Size = New System.Drawing.Size(79, 21)
        Me.cmbSkipPlacement.TabIndex = 16
        Me.cmbSkipPlacement.Visible = False
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(35, 444)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(191, 82)
        Me.btnStart.TabIndex = 17
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnEnd
        '
        Me.btnEnd.Location = New System.Drawing.Point(255, 444)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(191, 82)
        Me.btnEnd.TabIndex = 18
        Me.btnEnd.Text = "End"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'frmAdhesiveRobot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 535)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.cmbSkipPlacement)
        Me.Controls.Add(Me.chbSkipPlacement)
        Me.Controls.Add(Me.lblInfoSkip)
        Me.Controls.Add(Me.lsbResultDotCord)
        Me.Controls.Add(Me.txtYcordCenterPoint)
        Me.Controls.Add(Me.txtXcordCenterPoint)
        Me.Controls.Add(Me.lblInfoXcord)
        Me.Controls.Add(Me.lblInfoYcord)
        Me.Controls.Add(Me.txtFirstDotLocation)
        Me.Controls.Add(Me.lblInfoFirstDotLocation)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblInfoNumberDots)
        Me.Controls.Add(Me.txtCircleDiameter)
        Me.Controls.Add(Me.lblInfoDiameter)
        Me.Name = "frmAdhesiveRobot"
        Me.Text = "Adhesive Robot"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInfoDiameter As Label
    Friend WithEvents txtCircleDiameter As TextBox
    Friend WithEvents lblInfoNumberDots As Label
    Friend WithEvents rdbDot2 As RadioButton
    Friend WithEvents rdbDot4 As RadioButton
    Friend WithEvents rdbDot8 As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblInfoFirstDotLocation As Label
    Friend WithEvents txtFirstDotLocation As TextBox
    Friend WithEvents lblInfoYcord As Label
    Friend WithEvents lblInfoXcord As Label
    Friend WithEvents txtXcordCenterPoint As TextBox
    Friend WithEvents txtYcordCenterPoint As TextBox
    Friend WithEvents lsbResultDotCord As ListBox
    Friend WithEvents lblInfoSkip As Label
    Friend WithEvents chbSkipPlacement As CheckBox
    Friend WithEvents cmbSkipPlacement As ComboBox
    Friend WithEvents btnStart As Button
    Friend WithEvents btnEnd As Button
End Class
