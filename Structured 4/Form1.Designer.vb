<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStringManipulation
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
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.txtUserInfo = New System.Windows.Forms.TextBox()
        Me.btnConvertUpper = New System.Windows.Forms.Button()
        Me.btnReverse = New System.Windows.Forms.Button()
        Me.btnWordNumber = New System.Windows.Forms.Button()
        Me.btnStudentNumber = New System.Windows.Forms.Button()
        Me.btnAge = New System.Windows.Forms.Button()
        Me.btnSwap = New System.Windows.Forms.Button()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblInfo
        '
        Me.lblInfo.Location = New System.Drawing.Point(45, 29)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(152, 21)
        Me.lblInfo.TabIndex = 0
        Me.lblInfo.Text = "Please enter your information"
        '
        'txtUserInfo
        '
        Me.txtUserInfo.Location = New System.Drawing.Point(200, 26)
        Me.txtUserInfo.Name = "txtUserInfo"
        Me.txtUserInfo.Size = New System.Drawing.Size(279, 20)
        Me.txtUserInfo.TabIndex = 1
        '
        'btnConvertUpper
        '
        Me.btnConvertUpper.Location = New System.Drawing.Point(48, 120)
        Me.btnConvertUpper.Name = "btnConvertUpper"
        Me.btnConvertUpper.Size = New System.Drawing.Size(149, 62)
        Me.btnConvertUpper.TabIndex = 3
        Me.btnConvertUpper.Text = "Uppercase Convert"
        Me.btnConvertUpper.UseVisualStyleBackColor = True
        '
        'btnReverse
        '
        Me.btnReverse.Location = New System.Drawing.Point(330, 120)
        Me.btnReverse.Name = "btnReverse"
        Me.btnReverse.Size = New System.Drawing.Size(149, 62)
        Me.btnReverse.TabIndex = 4
        Me.btnReverse.Text = "Reverse  Convert"
        Me.btnReverse.UseVisualStyleBackColor = True
        '
        'btnWordNumber
        '
        Me.btnWordNumber.Location = New System.Drawing.Point(330, 293)
        Me.btnWordNumber.Name = "btnWordNumber"
        Me.btnWordNumber.Size = New System.Drawing.Size(149, 62)
        Me.btnWordNumber.TabIndex = 5
        Me.btnWordNumber.Text = "Number of words"
        Me.btnWordNumber.UseVisualStyleBackColor = True
        '
        'btnStudentNumber
        '
        Me.btnStudentNumber.Location = New System.Drawing.Point(330, 207)
        Me.btnStudentNumber.Name = "btnStudentNumber"
        Me.btnStudentNumber.Size = New System.Drawing.Size(149, 62)
        Me.btnStudentNumber.TabIndex = 6
        Me.btnStudentNumber.Text = "Student Number"
        Me.btnStudentNumber.UseVisualStyleBackColor = True
        '
        'btnAge
        '
        Me.btnAge.Location = New System.Drawing.Point(48, 207)
        Me.btnAge.Name = "btnAge"
        Me.btnAge.Size = New System.Drawing.Size(149, 62)
        Me.btnAge.TabIndex = 7
        Me.btnAge.Text = "Age"
        Me.btnAge.UseVisualStyleBackColor = True
        '
        'btnSwap
        '
        Me.btnSwap.Location = New System.Drawing.Point(48, 293)
        Me.btnSwap.Name = "btnSwap"
        Me.btnSwap.Size = New System.Drawing.Size(149, 62)
        Me.btnSwap.TabIndex = 8
        Me.btnSwap.Text = "NameSwap"
        Me.btnSwap.UseVisualStyleBackColor = True
        '
        'btnTotal
        '
        Me.btnTotal.Location = New System.Drawing.Point(48, 376)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(149, 62)
        Me.btnTotal.TabIndex = 9
        Me.btnTotal.Text = "Total  numerical values "
        Me.btnTotal.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(77, 68)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(347, 32)
        Me.lblResult.TabIndex = 10
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(330, 376)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(149, 62)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmStringManipulation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnTotal)
        Me.Controls.Add(Me.btnSwap)
        Me.Controls.Add(Me.btnAge)
        Me.Controls.Add(Me.btnStudentNumber)
        Me.Controls.Add(Me.btnWordNumber)
        Me.Controls.Add(Me.btnReverse)
        Me.Controls.Add(Me.btnConvertUpper)
        Me.Controls.Add(Me.txtUserInfo)
        Me.Controls.Add(Me.lblInfo)
        Me.Name = "frmStringManipulation"
        Me.Text = "String Manipulation "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInfo As Label
    Friend WithEvents txtUserInfo As TextBox
    Friend WithEvents btnConvertUpper As Button
    Friend WithEvents btnReverse As Button
    Friend WithEvents btnWordNumber As Button
    Friend WithEvents btnStudentNumber As Button
    Friend WithEvents btnAge As Button
    Friend WithEvents btnSwap As Button
    Friend WithEvents btnTotal As Button
    Friend WithEvents lblResult As Label
    Friend WithEvents btnExit As Button
End Class
