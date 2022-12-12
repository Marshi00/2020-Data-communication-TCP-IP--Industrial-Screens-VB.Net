<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRobotArm
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
        Me.lblInfoX = New System.Windows.Forms.Label()
        Me.lblInfoZ = New System.Windows.Forms.Label()
        Me.lblInfoY = New System.Windows.Forms.Label()
        Me.txtCoordinationX = New System.Windows.Forms.TextBox()
        Me.txtCoordinationZ = New System.Windows.Forms.TextBox()
        Me.txtCoordinationY = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lsbResult = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lblInfoX
        '
        Me.lblInfoX.Location = New System.Drawing.Point(12, 31)
        Me.lblInfoX.Name = "lblInfoX"
        Me.lblInfoX.Size = New System.Drawing.Size(144, 23)
        Me.lblInfoX.TabIndex = 1
        Me.lblInfoX.Text = "Please enter X coordination"
        '
        'lblInfoZ
        '
        Me.lblInfoZ.Location = New System.Drawing.Point(12, 153)
        Me.lblInfoZ.Name = "lblInfoZ"
        Me.lblInfoZ.Size = New System.Drawing.Size(144, 23)
        Me.lblInfoZ.TabIndex = 2
        Me.lblInfoZ.Text = "Please enter Z coordination"
        '
        'lblInfoY
        '
        Me.lblInfoY.Location = New System.Drawing.Point(12, 93)
        Me.lblInfoY.Name = "lblInfoY"
        Me.lblInfoY.Size = New System.Drawing.Size(144, 23)
        Me.lblInfoY.TabIndex = 3
        Me.lblInfoY.Text = "Please enter Y coordination"
        '
        'txtCoordinationX
        '
        Me.txtCoordinationX.Location = New System.Drawing.Point(207, 28)
        Me.txtCoordinationX.Name = "txtCoordinationX"
        Me.txtCoordinationX.Size = New System.Drawing.Size(133, 20)
        Me.txtCoordinationX.TabIndex = 4
        '
        'txtCoordinationZ
        '
        Me.txtCoordinationZ.Location = New System.Drawing.Point(207, 153)
        Me.txtCoordinationZ.Name = "txtCoordinationZ"
        Me.txtCoordinationZ.Size = New System.Drawing.Size(133, 20)
        Me.txtCoordinationZ.TabIndex = 5
        '
        'txtCoordinationY
        '
        Me.txtCoordinationY.Location = New System.Drawing.Point(207, 93)
        Me.txtCoordinationY.Name = "txtCoordinationY"
        Me.txtCoordinationY.Size = New System.Drawing.Size(133, 20)
        Me.txtCoordinationY.TabIndex = 6
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(15, 243)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(141, 76)
        Me.btnCalculate.TabIndex = 8
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(207, 243)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(141, 76)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lsbResult
        '
        Me.lsbResult.FormattingEnabled = True
        Me.lsbResult.Location = New System.Drawing.Point(372, 25)
        Me.lsbResult.Name = "lsbResult"
        Me.lsbResult.Size = New System.Drawing.Size(375, 290)
        Me.lsbResult.TabIndex = 10
        '
        'frmRobotArm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 336)
        Me.Controls.Add(Me.lsbResult)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtCoordinationY)
        Me.Controls.Add(Me.txtCoordinationZ)
        Me.Controls.Add(Me.txtCoordinationX)
        Me.Controls.Add(Me.lblInfoY)
        Me.Controls.Add(Me.lblInfoZ)
        Me.Controls.Add(Me.lblInfoX)
        Me.Name = "frmRobotArm"
        Me.Text = "RobotArm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInfoX As Label
    Friend WithEvents lblInfoZ As Label
    Friend WithEvents lblInfoY As Label
    Friend WithEvents txtCoordinationX As TextBox
    Friend WithEvents txtCoordinationZ As TextBox
    Friend WithEvents txtCoordinationY As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lsbResult As ListBox
End Class
