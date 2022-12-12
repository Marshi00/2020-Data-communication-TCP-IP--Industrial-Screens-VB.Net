<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDataStorage
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
        Me.lblInfoDirectory = New System.Windows.Forms.Label()
        Me.txtInputDirectoryName = New System.Windows.Forms.TextBox()
        Me.btnDirectory = New System.Windows.Forms.Button()
        Me.btnMove = New System.Windows.Forms.Button()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.lsbResult = New System.Windows.Forms.ListBox()
        Me.btnAnalyse = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblAnalyseResult = New System.Windows.Forms.Label()
        Me.SaveAnakysis = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblInfoDirectory
        '
        Me.lblInfoDirectory.AutoSize = True
        Me.lblInfoDirectory.Location = New System.Drawing.Point(22, 22)
        Me.lblInfoDirectory.Name = "lblInfoDirectory"
        Me.lblInfoDirectory.Size = New System.Drawing.Size(280, 13)
        Me.lblInfoDirectory.TabIndex = 0
        Me.lblInfoDirectory.Text = "Please enter the name of directory that you want to create"
        '
        'txtInputDirectoryName
        '
        Me.txtInputDirectoryName.Location = New System.Drawing.Point(324, 15)
        Me.txtInputDirectoryName.Name = "txtInputDirectoryName"
        Me.txtInputDirectoryName.Size = New System.Drawing.Size(235, 20)
        Me.txtInputDirectoryName.TabIndex = 2
        '
        'btnDirectory
        '
        Me.btnDirectory.Location = New System.Drawing.Point(578, 8)
        Me.btnDirectory.Name = "btnDirectory"
        Me.btnDirectory.Size = New System.Drawing.Size(96, 41)
        Me.btnDirectory.TabIndex = 3
        Me.btnDirectory.Text = "Create Directory"
        Me.btnDirectory.UseVisualStyleBackColor = True
        '
        'btnMove
        '
        Me.btnMove.Location = New System.Drawing.Point(692, 8)
        Me.btnMove.Name = "btnMove"
        Me.btnMove.Size = New System.Drawing.Size(96, 41)
        Me.btnMove.TabIndex = 4
        Me.btnMove.Text = "Move Files "
        Me.btnMove.UseVisualStyleBackColor = True
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(25, 69)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(96, 41)
        Me.btnBrowse.TabIndex = 5
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'lsbResult
        '
        Me.lsbResult.FormattingEnabled = True
        Me.lsbResult.Location = New System.Drawing.Point(25, 117)
        Me.lsbResult.Name = "lsbResult"
        Me.lsbResult.Size = New System.Drawing.Size(759, 316)
        Me.lsbResult.TabIndex = 6
        '
        'btnAnalyse
        '
        Me.btnAnalyse.Location = New System.Drawing.Point(152, 70)
        Me.btnAnalyse.Name = "btnAnalyse"
        Me.btnAnalyse.Size = New System.Drawing.Size(96, 41)
        Me.btnAnalyse.TabIndex = 7
        Me.btnAnalyse.Text = "Analyse"
        Me.btnAnalyse.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(692, 69)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(96, 41)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblAnalyseResult
        '
        Me.lblAnalyseResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAnalyseResult.Location = New System.Drawing.Point(254, 82)
        Me.lblAnalyseResult.Name = "lblAnalyseResult"
        Me.lblAnalyseResult.Size = New System.Drawing.Size(318, 26)
        Me.lblAnalyseResult.TabIndex = 9
        '
        'SaveAnakysis
        '
        Me.SaveAnakysis.Location = New System.Drawing.Point(578, 70)
        Me.SaveAnakysis.Name = "SaveAnakysis"
        Me.SaveAnakysis.Size = New System.Drawing.Size(96, 41)
        Me.SaveAnakysis.TabIndex = 10
        Me.SaveAnakysis.Text = "Save Analysis"
        Me.SaveAnakysis.UseVisualStyleBackColor = True
        '
        'frmDataStorage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SaveAnakysis)
        Me.Controls.Add(Me.lblAnalyseResult)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAnalyse)
        Me.Controls.Add(Me.lsbResult)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.btnMove)
        Me.Controls.Add(Me.btnDirectory)
        Me.Controls.Add(Me.txtInputDirectoryName)
        Me.Controls.Add(Me.lblInfoDirectory)
        Me.Name = "frmDataStorage"
        Me.Text = "Data Storage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInfoDirectory As Label
    Friend WithEvents txtInputDirectoryName As TextBox
    Friend WithEvents btnDirectory As Button
    Friend WithEvents btnMove As Button
    Friend WithEvents btnBrowse As Button
    Friend WithEvents lsbResult As ListBox
    Friend WithEvents btnAnalyse As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblAnalyseResult As Label
    Friend WithEvents SaveAnakysis As Button
End Class
