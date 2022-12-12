<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmExam1
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
        Me.btnImport = New System.Windows.Forms.Button()
        Me.btnChangeList = New System.Windows.Forms.Button()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.lblInfo1 = New System.Windows.Forms.Label()
        Me.rdbAdd = New System.Windows.Forms.RadioButton()
        Me.rdbRemove = New System.Windows.Forms.RadioButton()
        Me.lblInfo2 = New System.Windows.Forms.Label()
        Me.lsbResult = New System.Windows.Forms.ListBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnImport
        '
        Me.btnImport.Location = New System.Drawing.Point(136, 75)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(132, 24)
        Me.btnImport.TabIndex = 0
        Me.btnImport.Text = "Import File"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'btnChangeList
        '
        Me.btnChangeList.Location = New System.Drawing.Point(136, 105)
        Me.btnChangeList.Name = "btnChangeList"
        Me.btnChangeList.Size = New System.Drawing.Size(132, 24)
        Me.btnChangeList.TabIndex = 1
        Me.btnChangeList.Text = "Change List"
        Me.btnChangeList.UseVisualStyleBackColor = True
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(136, 35)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(132, 20)
        Me.txtInput.TabIndex = 2
        '
        'lblInfo1
        '
        Me.lblInfo1.AutoSize = True
        Me.lblInfo1.Location = New System.Drawing.Point(12, 38)
        Me.lblInfo1.Name = "lblInfo1"
        Me.lblInfo1.Size = New System.Drawing.Size(39, 13)
        Me.lblInfo1.TabIndex = 3
        Me.lblInfo1.Text = "Label1"
        '
        'rdbAdd
        '
        Me.rdbAdd.AutoSize = True
        Me.rdbAdd.Location = New System.Drawing.Point(136, 170)
        Me.rdbAdd.Name = "rdbAdd"
        Me.rdbAdd.Size = New System.Drawing.Size(44, 17)
        Me.rdbAdd.TabIndex = 4
        Me.rdbAdd.TabStop = True
        Me.rdbAdd.Text = "Add"
        Me.rdbAdd.UseVisualStyleBackColor = True
        '
        'rdbRemove
        '
        Me.rdbRemove.AutoSize = True
        Me.rdbRemove.Location = New System.Drawing.Point(136, 193)
        Me.rdbRemove.Name = "rdbRemove"
        Me.rdbRemove.Size = New System.Drawing.Size(65, 17)
        Me.rdbRemove.TabIndex = 5
        Me.rdbRemove.TabStop = True
        Me.rdbRemove.Text = "Remove"
        Me.rdbRemove.UseVisualStyleBackColor = True
        '
        'lblInfo2
        '
        Me.lblInfo2.AutoSize = True
        Me.lblInfo2.Location = New System.Drawing.Point(12, 190)
        Me.lblInfo2.Name = "lblInfo2"
        Me.lblInfo2.Size = New System.Drawing.Size(39, 13)
        Me.lblInfo2.TabIndex = 6
        Me.lblInfo2.Text = "Label1"
        '
        'lsbResult
        '
        Me.lsbResult.FormattingEnabled = True
        Me.lsbResult.Location = New System.Drawing.Point(274, 20)
        Me.lsbResult.Name = "lsbResult"
        Me.lsbResult.Size = New System.Drawing.Size(562, 420)
        Me.lsbResult.TabIndex = 7
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(15, 382)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(132, 58)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmExam1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lsbResult)
        Me.Controls.Add(Me.lblInfo2)
        Me.Controls.Add(Me.rdbRemove)
        Me.Controls.Add(Me.rdbAdd)
        Me.Controls.Add(Me.lblInfo1)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.btnChangeList)
        Me.Controls.Add(Me.btnImport)
        Me.Name = "frmExam1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnImport As Button
    Friend WithEvents btnChangeList As Button
    Friend WithEvents txtInput As TextBox
    Friend WithEvents lblInfo1 As Label
    Friend WithEvents rdbAdd As RadioButton
    Friend WithEvents rdbRemove As RadioButton
    Friend WithEvents lblInfo2 As Label
    Friend WithEvents lsbResult As ListBox
    Friend WithEvents btnExit As Button
End Class
