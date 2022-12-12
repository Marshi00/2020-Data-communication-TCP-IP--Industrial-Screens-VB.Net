Option Explicit On
Option Strict On
Imports System.IO
Public Class frmExam1
    Dim fileName As String
    Dim fileChooser As New OpenFileDialog
    Dim robotFileReader As StreamReader
    Dim robotFileWriter As StreamWriter
    Dim operation As Integer

    ' checking the operation type here 
    Private Sub rdbAdd_CheckedChanged(sender As Object, e As EventArgs) Handles rdbAdd.CheckedChanged
        If rdbAdd.Checked = True Then
            operation = 2
        End If
    End Sub

    Private Sub rdbRemove_CheckedChanged(sender As Object, e As EventArgs) Handles rdbRemove.CheckedChanged
        If rdbRemove.Checked = True Then
            operation = 3
        End If
    End Sub

    'this part check if path has been not set before and set a new path
    Sub fileSet()
        If fileName = "" Then
            Dim result As DialogResult = fileChooser.ShowDialog()
            If result = Windows.Forms.DialogResult.OK Then
                fileName = fileChooser.FileName
            End If
        End If
    End Sub
    'this close active links 
    Sub linkClose()
        If robotFileWriter IsNot Nothing Then
            robotFileWriter.Close()
        End If
        If robotFileReader IsNot Nothing Then
            robotFileReader.Close()
        End If
    End Sub
    ' this is where we open the list
    Sub add()
        fileSet()
        If fileName <> "" Then
            linkClose()
            lsbResult.Items.Clear()
            robotFileReader = New StreamReader(fileName)
            'lsbResult.Items.Add(String.Format("--------- Opening {0} ------------", fileName))
            'lsbResult.Items.Add(" ")
            Do While Not robotFileReader.EndOfStream
                lsbResult.Items.Add(robotFileReader.ReadLine)
            Loop
            linkClose()
        End If
    End Sub
    'this 
    Sub write()
        robotFileWriter = New StreamWriter(fileName, True)
        robotFileWriter.WriteLine(txtInput.Text)
        linkClose()
        ' this is where where we runtime update
        add()
    End Sub
    ' this is where we open the list
    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        add()
    End Sub

    'this is where change button get clicked 
    Private Sub btnChangeList_Click(sender As Object, e As EventArgs) Handles btnChangeList.Click
        'this is where we are adding to the list 
        If operation = 2 Then
            fileSet()
            If fileName <> "" Then
                linkClose()
                If txtInput.Text <> "" Then
                    write()
                Else
                    MsgBox("Please enter what to add to the list in the text box  ")
                End If
            End If
            'this is wehre remove happen
        ElseIf operation = 3 Then
            fileSet()
            If fileName <> "" Then
                linkClose()
                Dim target As Integer = lsbResult.FindString(txtInput.Text)
                add()
                If target <> -1 Then

                    lsbResult.Items.RemoveAt(target)
                    Dim sb As New System.Text.StringBuilder()

                    For Each o As Object In lsbResult.Items
                        sb.AppendLine(CStr(o))
                    Next

                    System.IO.File.WriteAllText(fileName, sb.ToString())
                Else
                    MsgBox("there is no such item in the list , please check your spelling")
                End If
            End If

        Else
                MsgBox("Please Select the operation type from the radio buttons ")
            End If

    End Sub


    'closing the program here
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub


End Class
