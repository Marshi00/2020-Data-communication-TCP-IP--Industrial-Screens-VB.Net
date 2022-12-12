<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExam
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
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lsbResult = New System.Windows.Forms.ListBox()
        Me.lblPartName = New System.Windows.Forms.Label()
        Me.lblDes = New System.Windows.Forms.Label()
        Me.txtPartName = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.cmbNumberParts = New System.Windows.Forms.ComboBox()
        Me.lblNumberParts = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(30, 363)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(102, 59)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnEnd
        '
        Me.btnEnd.Location = New System.Drawing.Point(170, 363)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(102, 59)
        Me.btnEnd.TabIndex = 1
        Me.btnEnd.Text = "End"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(299, 363)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(102, 59)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'lsbResult
        '
        Me.lsbResult.FormattingEnabled = True
        Me.lsbResult.Location = New System.Drawing.Point(421, 21)
        Me.lsbResult.Name = "lsbResult"
        Me.lsbResult.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lsbResult.Size = New System.Drawing.Size(308, 420)
        Me.lsbResult.TabIndex = 3
        '
        'lblPartName
        '
        Me.lblPartName.Location = New System.Drawing.Point(12, 21)
        Me.lblPartName.Name = "lblPartName"
        Me.lblPartName.Size = New System.Drawing.Size(189, 23)
        Me.lblPartName.TabIndex = 4
        Me.lblPartName.Text = "Please enter the name of part"
        '
        'lblDes
        '
        Me.lblDes.Location = New System.Drawing.Point(12, 72)
        Me.lblDes.Name = "lblDes"
        Me.lblDes.Size = New System.Drawing.Size(189, 17)
        Me.lblDes.TabIndex = 5
        Me.lblDes.Text = "Please enter the Description of parts"
        '
        'txtPartName
        '
        Me.txtPartName.Location = New System.Drawing.Point(247, 24)
        Me.txtPartName.Name = "txtPartName"
        Me.txtPartName.Size = New System.Drawing.Size(100, 20)
        Me.txtPartName.TabIndex = 6
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(247, 72)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(100, 20)
        Me.txtDescription.TabIndex = 7
        '
        'cmbNumberParts
        '
        Me.cmbNumberParts.FormattingEnabled = True
        Me.cmbNumberParts.Location = New System.Drawing.Point(247, 139)
        Me.cmbNumberParts.Name = "cmbNumberParts"
        Me.cmbNumberParts.Size = New System.Drawing.Size(121, 21)
        Me.cmbNumberParts.TabIndex = 8
        '
        'lblNumberParts
        '
        Me.lblNumberParts.Location = New System.Drawing.Point(12, 143)
        Me.lblNumberParts.Name = "lblNumberParts"
        Me.lblNumberParts.Size = New System.Drawing.Size(189, 17)
        Me.lblNumberParts.TabIndex = 9
        Me.lblNumberParts.Text = "Please Select the number of parts"
        '
        'frmExam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblNumberParts)
        Me.Controls.Add(Me.cmbNumberParts)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtPartName)
        Me.Controls.Add(Me.lblDes)
        Me.Controls.Add(Me.lblPartName)
        Me.Controls.Add(Me.lsbResult)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnStart)
        Me.Name = "frmExam"
        Me.Text = "Exam"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents btnEnd As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents lsbResult As ListBox
    Friend WithEvents lblPartName As Label
    Friend WithEvents lblDes As Label
    Friend WithEvents txtPartName As TextBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents cmbNumberParts As ComboBox
    Friend WithEvents lblNumberParts As Label
End Class
