<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStringParsing
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
        Me.components = New System.ComponentModel.Container()
        Me.lblResultStationName = New System.Windows.Forms.Label()
        Me.lblInfoHolderStationName = New System.Windows.Forms.Label()
        Me.lblInfoHolderStartTime = New System.Windows.Forms.Label()
        Me.lblInfoHolderCurrentTime = New System.Windows.Forms.Label()
        Me.lblInfoHolderElapsedTime = New System.Windows.Forms.Label()
        Me.lblResultCurrentTime = New System.Windows.Forms.Label()
        Me.lblResultStartTime = New System.Windows.Forms.Label()
        Me.lblResultElapsedTime = New System.Windows.Forms.Label()
        Me.lblTitleProduction = New System.Windows.Forms.Label()
        Me.lblInfoHolderBadParts = New System.Windows.Forms.Label()
        Me.lblInfoHolderGoodParts = New System.Windows.Forms.Label()
        Me.lblInfoHolderTotalParts = New System.Windows.Forms.Label()
        Me.lblResultGoodParts = New System.Windows.Forms.Label()
        Me.lblResultBadParts = New System.Windows.Forms.Label()
        Me.lblResultTotalParts = New System.Windows.Forms.Label()
        Me.lblTitleSystem = New System.Windows.Forms.Label()
        Me.lblResultTesterStatus = New System.Windows.Forms.Label()
        Me.lblResultInFeedStatus = New System.Windows.Forms.Label()
        Me.lblResultRobotStatus = New System.Windows.Forms.Label()
        Me.lblInfoHolderTesterStatus = New System.Windows.Forms.Label()
        Me.lblInfoHolderRobotStatus = New System.Windows.Forms.Label()
        Me.lblInfoHolderInFeedStatus = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.elapsedTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblResultStationName
        '
        Me.lblResultStationName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResultStationName.Location = New System.Drawing.Point(164, 24)
        Me.lblResultStationName.Name = "lblResultStationName"
        Me.lblResultStationName.Size = New System.Drawing.Size(138, 20)
        Me.lblResultStationName.TabIndex = 0
        '
        'lblInfoHolderStationName
        '
        Me.lblInfoHolderStationName.AutoSize = True
        Me.lblInfoHolderStationName.Location = New System.Drawing.Point(12, 25)
        Me.lblInfoHolderStationName.Name = "lblInfoHolderStationName"
        Me.lblInfoHolderStationName.Size = New System.Drawing.Size(103, 13)
        Me.lblInfoHolderStationName.TabIndex = 1
        Me.lblInfoHolderStationName.Text = "Robot Station Name"
        '
        'lblInfoHolderStartTime
        '
        Me.lblInfoHolderStartTime.AutoSize = True
        Me.lblInfoHolderStartTime.Location = New System.Drawing.Point(12, 110)
        Me.lblInfoHolderStartTime.Name = "lblInfoHolderStartTime"
        Me.lblInfoHolderStartTime.Size = New System.Drawing.Size(55, 13)
        Me.lblInfoHolderStartTime.TabIndex = 2
        Me.lblInfoHolderStartTime.Text = "Start Time"
        '
        'lblInfoHolderCurrentTime
        '
        Me.lblInfoHolderCurrentTime.AutoSize = True
        Me.lblInfoHolderCurrentTime.Location = New System.Drawing.Point(12, 147)
        Me.lblInfoHolderCurrentTime.Name = "lblInfoHolderCurrentTime"
        Me.lblInfoHolderCurrentTime.Size = New System.Drawing.Size(67, 13)
        Me.lblInfoHolderCurrentTime.TabIndex = 3
        Me.lblInfoHolderCurrentTime.Text = "Current Time"
        '
        'lblInfoHolderElapsedTime
        '
        Me.lblInfoHolderElapsedTime.AutoSize = True
        Me.lblInfoHolderElapsedTime.Location = New System.Drawing.Point(12, 185)
        Me.lblInfoHolderElapsedTime.Name = "lblInfoHolderElapsedTime"
        Me.lblInfoHolderElapsedTime.Size = New System.Drawing.Size(71, 13)
        Me.lblInfoHolderElapsedTime.TabIndex = 4
        Me.lblInfoHolderElapsedTime.Text = "Elapsed Time"
        '
        'lblResultCurrentTime
        '
        Me.lblResultCurrentTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResultCurrentTime.Location = New System.Drawing.Point(164, 140)
        Me.lblResultCurrentTime.Name = "lblResultCurrentTime"
        Me.lblResultCurrentTime.Size = New System.Drawing.Size(138, 20)
        Me.lblResultCurrentTime.TabIndex = 5
        '
        'lblResultStartTime
        '
        Me.lblResultStartTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResultStartTime.Location = New System.Drawing.Point(164, 103)
        Me.lblResultStartTime.Name = "lblResultStartTime"
        Me.lblResultStartTime.Size = New System.Drawing.Size(138, 20)
        Me.lblResultStartTime.TabIndex = 6
        '
        'lblResultElapsedTime
        '
        Me.lblResultElapsedTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResultElapsedTime.Location = New System.Drawing.Point(164, 178)
        Me.lblResultElapsedTime.Name = "lblResultElapsedTime"
        Me.lblResultElapsedTime.Size = New System.Drawing.Size(138, 20)
        Me.lblResultElapsedTime.TabIndex = 7
        '
        'lblTitleProduction
        '
        Me.lblTitleProduction.AutoSize = True
        Me.lblTitleProduction.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleProduction.Location = New System.Drawing.Point(12, 63)
        Me.lblTitleProduction.Name = "lblTitleProduction"
        Me.lblTitleProduction.Size = New System.Drawing.Size(156, 24)
        Me.lblTitleProduction.TabIndex = 8
        Me.lblTitleProduction.Text = "Production Status"
        '
        'lblInfoHolderBadParts
        '
        Me.lblInfoHolderBadParts.AutoSize = True
        Me.lblInfoHolderBadParts.Location = New System.Drawing.Point(13, 254)
        Me.lblInfoHolderBadParts.Name = "lblInfoHolderBadParts"
        Me.lblInfoHolderBadParts.Size = New System.Drawing.Size(53, 13)
        Me.lblInfoHolderBadParts.TabIndex = 9
        Me.lblInfoHolderBadParts.Text = "Bad Parts"
        '
        'lblInfoHolderGoodParts
        '
        Me.lblInfoHolderGoodParts.AutoSize = True
        Me.lblInfoHolderGoodParts.Location = New System.Drawing.Point(13, 219)
        Me.lblInfoHolderGoodParts.Name = "lblInfoHolderGoodParts"
        Me.lblInfoHolderGoodParts.Size = New System.Drawing.Size(60, 13)
        Me.lblInfoHolderGoodParts.TabIndex = 10
        Me.lblInfoHolderGoodParts.Text = "Good Parts"
        '
        'lblInfoHolderTotalParts
        '
        Me.lblInfoHolderTotalParts.AutoSize = True
        Me.lblInfoHolderTotalParts.Location = New System.Drawing.Point(13, 292)
        Me.lblInfoHolderTotalParts.Name = "lblInfoHolderTotalParts"
        Me.lblInfoHolderTotalParts.Size = New System.Drawing.Size(58, 13)
        Me.lblInfoHolderTotalParts.TabIndex = 11
        Me.lblInfoHolderTotalParts.Text = "Total Parts"
        '
        'lblResultGoodParts
        '
        Me.lblResultGoodParts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResultGoodParts.Location = New System.Drawing.Point(164, 212)
        Me.lblResultGoodParts.Name = "lblResultGoodParts"
        Me.lblResultGoodParts.Size = New System.Drawing.Size(138, 20)
        Me.lblResultGoodParts.TabIndex = 12
        '
        'lblResultBadParts
        '
        Me.lblResultBadParts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResultBadParts.Location = New System.Drawing.Point(164, 247)
        Me.lblResultBadParts.Name = "lblResultBadParts"
        Me.lblResultBadParts.Size = New System.Drawing.Size(138, 20)
        Me.lblResultBadParts.TabIndex = 13
        '
        'lblResultTotalParts
        '
        Me.lblResultTotalParts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResultTotalParts.Location = New System.Drawing.Point(164, 285)
        Me.lblResultTotalParts.Name = "lblResultTotalParts"
        Me.lblResultTotalParts.Size = New System.Drawing.Size(138, 20)
        Me.lblResultTotalParts.TabIndex = 14
        '
        'lblTitleSystem
        '
        Me.lblTitleSystem.AutoSize = True
        Me.lblTitleSystem.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleSystem.Location = New System.Drawing.Point(468, 63)
        Me.lblTitleSystem.Name = "lblTitleSystem"
        Me.lblTitleSystem.Size = New System.Drawing.Size(126, 24)
        Me.lblTitleSystem.TabIndex = 15
        Me.lblTitleSystem.Text = "System Status"
        '
        'lblResultTesterStatus
        '
        Me.lblResultTesterStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResultTesterStatus.Location = New System.Drawing.Point(621, 178)
        Me.lblResultTesterStatus.Name = "lblResultTesterStatus"
        Me.lblResultTesterStatus.Size = New System.Drawing.Size(138, 20)
        Me.lblResultTesterStatus.TabIndex = 21
        '
        'lblResultInFeedStatus
        '
        Me.lblResultInFeedStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResultInFeedStatus.Location = New System.Drawing.Point(621, 103)
        Me.lblResultInFeedStatus.Name = "lblResultInFeedStatus"
        Me.lblResultInFeedStatus.Size = New System.Drawing.Size(138, 20)
        Me.lblResultInFeedStatus.TabIndex = 20
        '
        'lblResultRobotStatus
        '
        Me.lblResultRobotStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResultRobotStatus.Location = New System.Drawing.Point(621, 140)
        Me.lblResultRobotStatus.Name = "lblResultRobotStatus"
        Me.lblResultRobotStatus.Size = New System.Drawing.Size(138, 20)
        Me.lblResultRobotStatus.TabIndex = 19
        '
        'lblInfoHolderTesterStatus
        '
        Me.lblInfoHolderTesterStatus.AutoSize = True
        Me.lblInfoHolderTesterStatus.Location = New System.Drawing.Point(469, 185)
        Me.lblInfoHolderTesterStatus.Name = "lblInfoHolderTesterStatus"
        Me.lblInfoHolderTesterStatus.Size = New System.Drawing.Size(70, 13)
        Me.lblInfoHolderTesterStatus.TabIndex = 18
        Me.lblInfoHolderTesterStatus.Text = "Tester Status"
        '
        'lblInfoHolderRobotStatus
        '
        Me.lblInfoHolderRobotStatus.AutoSize = True
        Me.lblInfoHolderRobotStatus.Location = New System.Drawing.Point(469, 147)
        Me.lblInfoHolderRobotStatus.Name = "lblInfoHolderRobotStatus"
        Me.lblInfoHolderRobotStatus.Size = New System.Drawing.Size(66, 13)
        Me.lblInfoHolderRobotStatus.TabIndex = 17
        Me.lblInfoHolderRobotStatus.Text = "RobotStatus"
        '
        'lblInfoHolderInFeedStatus
        '
        Me.lblInfoHolderInFeedStatus.AutoSize = True
        Me.lblInfoHolderInFeedStatus.Location = New System.Drawing.Point(469, 110)
        Me.lblInfoHolderInFeedStatus.Name = "lblInfoHolderInFeedStatus"
        Me.lblInfoHolderInFeedStatus.Size = New System.Drawing.Size(76, 13)
        Me.lblInfoHolderInFeedStatus.TabIndex = 16
        Me.lblInfoHolderInFeedStatus.Text = "In Feed Status"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(621, 372)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(138, 56)
        Me.btnExit.TabIndex = 22
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmStringParsing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblResultTesterStatus)
        Me.Controls.Add(Me.lblResultInFeedStatus)
        Me.Controls.Add(Me.lblResultRobotStatus)
        Me.Controls.Add(Me.lblInfoHolderTesterStatus)
        Me.Controls.Add(Me.lblInfoHolderRobotStatus)
        Me.Controls.Add(Me.lblInfoHolderInFeedStatus)
        Me.Controls.Add(Me.lblTitleSystem)
        Me.Controls.Add(Me.lblResultTotalParts)
        Me.Controls.Add(Me.lblResultBadParts)
        Me.Controls.Add(Me.lblResultGoodParts)
        Me.Controls.Add(Me.lblInfoHolderTotalParts)
        Me.Controls.Add(Me.lblInfoHolderGoodParts)
        Me.Controls.Add(Me.lblInfoHolderBadParts)
        Me.Controls.Add(Me.lblTitleProduction)
        Me.Controls.Add(Me.lblResultElapsedTime)
        Me.Controls.Add(Me.lblResultStartTime)
        Me.Controls.Add(Me.lblResultCurrentTime)
        Me.Controls.Add(Me.lblInfoHolderElapsedTime)
        Me.Controls.Add(Me.lblInfoHolderCurrentTime)
        Me.Controls.Add(Me.lblInfoHolderStartTime)
        Me.Controls.Add(Me.lblInfoHolderStationName)
        Me.Controls.Add(Me.lblResultStationName)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmStringParsing"
        Me.Text = "String Parsing HMI"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblResultStationName As Label
    Friend WithEvents lblInfoHolderStationName As Label
    Friend WithEvents lblInfoHolderStartTime As Label
    Friend WithEvents lblInfoHolderCurrentTime As Label
    Friend WithEvents lblInfoHolderElapsedTime As Label
    Friend WithEvents lblResultCurrentTime As Label
    Friend WithEvents lblResultStartTime As Label
    Friend WithEvents lblResultElapsedTime As Label
    Friend WithEvents lblTitleProduction As Label
    Friend WithEvents lblInfoHolderBadParts As Label
    Friend WithEvents lblInfoHolderGoodParts As Label
    Friend WithEvents lblInfoHolderTotalParts As Label
    Friend WithEvents lblResultGoodParts As Label
    Friend WithEvents lblResultBadParts As Label
    Friend WithEvents lblResultTotalParts As Label
    Friend WithEvents lblTitleSystem As Label
    Friend WithEvents lblResultTesterStatus As Label
    Friend WithEvents lblResultInFeedStatus As Label
    Friend WithEvents lblResultRobotStatus As Label
    Friend WithEvents lblInfoHolderTesterStatus As Label
    Friend WithEvents lblInfoHolderRobotStatus As Label
    Friend WithEvents lblInfoHolderInFeedStatus As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents elapsedTimer As Timer
End Class
