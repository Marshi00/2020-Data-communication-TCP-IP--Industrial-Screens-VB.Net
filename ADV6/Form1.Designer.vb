<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClass
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
        Me.lblInfoName = New System.Windows.Forms.Label()
        Me.txtInstanceName = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.InfoAge = New System.Windows.Forms.Label()
        Me.txtFirst = New System.Windows.Forms.TextBox()
        Me.txtLast = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lsbResult = New System.Windows.Forms.ListBox()
        Me.lblInfoCity = New System.Windows.Forms.Label()
        Me.lblInfoZip = New System.Windows.Forms.Label()
        Me.txtZipCode = New System.Windows.Forms.TextBox()
        Me.lblInfoStreet = New System.Windows.Forms.Label()
        Me.txtStreet = New System.Windows.Forms.TextBox()
        Me.btnShowHistory = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblInfoName
        '
        Me.lblInfoName.AutoSize = True
        Me.lblInfoName.Location = New System.Drawing.Point(12, 29)
        Me.lblInfoName.Name = "lblInfoName"
        Me.lblInfoName.Size = New System.Drawing.Size(270, 13)
        Me.lblInfoName.TabIndex = 0
        Me.lblInfoName.Text = "Please Enter the name for the new instance of the class"
        '
        'txtInstanceName
        '
        Me.txtInstanceName.Location = New System.Drawing.Point(321, 22)
        Me.txtInstanceName.Name = "txtInstanceName"
        Me.txtInstanceName.Size = New System.Drawing.Size(179, 20)
        Me.txtInstanceName.TabIndex = 1
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(356, 379)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(144, 52)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(12, 379)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(120, 52)
        Me.btnSubmit.TabIndex = 3
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(321, 82)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(179, 20)
        Me.txtAge.TabIndex = 4
        '
        'InfoAge
        '
        Me.InfoAge.AutoSize = True
        Me.InfoAge.Location = New System.Drawing.Point(12, 82)
        Me.InfoAge.Name = "InfoAge"
        Me.InfoAge.Size = New System.Drawing.Size(207, 13)
        Me.InfoAge.TabIndex = 5
        Me.InfoAge.Text = "Please Enter the age for the New instance"
        '
        'txtFirst
        '
        Me.txtFirst.Location = New System.Drawing.Point(321, 133)
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.Size = New System.Drawing.Size(179, 20)
        Me.txtFirst.TabIndex = 6
        '
        'txtLast
        '
        Me.txtLast.Location = New System.Drawing.Point(321, 186)
        Me.txtLast.Name = "txtLast"
        Me.txtLast.Size = New System.Drawing.Size(179, 20)
        Me.txtLast.TabIndex = 7
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(374, 238)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(70, 20)
        Me.txtCity.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 186)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Please Enter the Last Name for the New instance"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(239, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Please Enter the First Name for the New instance"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 238)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(227, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Please Enter the Address for the New instance"
        '
        'lsbResult
        '
        Me.lsbResult.FormattingEnabled = True
        Me.lsbResult.Location = New System.Drawing.Point(511, 12)
        Me.lsbResult.Name = "lsbResult"
        Me.lsbResult.Size = New System.Drawing.Size(603, 420)
        Me.lsbResult.TabIndex = 12
        '
        'lblInfoCity
        '
        Me.lblInfoCity.AutoSize = True
        Me.lblInfoCity.Location = New System.Drawing.Point(308, 241)
        Me.lblInfoCity.Name = "lblInfoCity"
        Me.lblInfoCity.Size = New System.Drawing.Size(27, 13)
        Me.lblInfoCity.TabIndex = 13
        Me.lblInfoCity.Text = "City:"
        '
        'lblInfoZip
        '
        Me.lblInfoZip.AutoSize = True
        Me.lblInfoZip.Location = New System.Drawing.Point(308, 276)
        Me.lblInfoZip.Name = "lblInfoZip"
        Me.lblInfoZip.Size = New System.Drawing.Size(55, 13)
        Me.lblInfoZip.TabIndex = 15
        Me.lblInfoZip.Text = "ZIP Code:"
        '
        'txtZipCode
        '
        Me.txtZipCode.Location = New System.Drawing.Point(374, 269)
        Me.txtZipCode.Name = "txtZipCode"
        Me.txtZipCode.Size = New System.Drawing.Size(70, 20)
        Me.txtZipCode.TabIndex = 14
        '
        'lblInfoStreet
        '
        Me.lblInfoStreet.AutoSize = True
        Me.lblInfoStreet.Location = New System.Drawing.Point(308, 320)
        Me.lblInfoStreet.Name = "lblInfoStreet"
        Me.lblInfoStreet.Size = New System.Drawing.Size(69, 13)
        Me.lblInfoStreet.TabIndex = 16
        Me.lblInfoStreet.Text = "Street Name:"
        '
        'txtStreet
        '
        Me.txtStreet.Location = New System.Drawing.Point(374, 313)
        Me.txtStreet.Name = "txtStreet"
        Me.txtStreet.Size = New System.Drawing.Size(126, 20)
        Me.txtStreet.TabIndex = 17
        '
        'btnShowHistory
        '
        Me.btnShowHistory.Location = New System.Drawing.Point(163, 379)
        Me.btnShowHistory.Name = "btnShowHistory"
        Me.btnShowHistory.Size = New System.Drawing.Size(172, 52)
        Me.btnShowHistory.TabIndex = 18
        Me.btnShowHistory.Text = "Show History"
        Me.btnShowHistory.UseVisualStyleBackColor = True
        '
        'frmClass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1126, 450)
        Me.Controls.Add(Me.btnShowHistory)
        Me.Controls.Add(Me.txtStreet)
        Me.Controls.Add(Me.lblInfoStreet)
        Me.Controls.Add(Me.lblInfoZip)
        Me.Controls.Add(Me.txtZipCode)
        Me.Controls.Add(Me.lblInfoCity)
        Me.Controls.Add(Me.lsbResult)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtLast)
        Me.Controls.Add(Me.txtFirst)
        Me.Controls.Add(Me.InfoAge)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtInstanceName)
        Me.Controls.Add(Me.lblInfoName)
        Me.Name = "frmClass"
        Me.Text = "Class Final Exam"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInfoName As Label
    Friend WithEvents txtInstanceName As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtAge As TextBox
    Friend WithEvents InfoAge As Label
    Friend WithEvents txtFirst As TextBox
    Friend WithEvents txtLast As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lsbResult As ListBox
    Friend WithEvents lblInfoCity As Label
    Friend WithEvents lblInfoZip As Label
    Friend WithEvents txtZipCode As TextBox
    Friend WithEvents lblInfoStreet As Label
    Friend WithEvents txtStreet As TextBox
    Friend WithEvents btnShowHistory As Button
End Class
