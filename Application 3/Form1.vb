Option Explicit On
Option Strict On
Imports System.IO
Imports System.Text.RegularExpressions
Public Class frmDataStorage
    Dim fileName, fileName2 As String
    Dim fileChooser As New OpenFileDialog
    Dim robotFileReader As StreamReader
    Dim robotFileWriter As StreamWriter
    Dim directoryTarget, newLocation As String
    'this part check if path has been not set before and set a new path
    Sub fileSet()
        'If fileName = "" Then
        Dim result As DialogResult = fileChooser.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            fileName = fileChooser.FileName
        End If
        'End If
    End Sub
    'this part check if path has been not set before and set a new path
    Sub fileSet2()
        'If fileName2 = "" Then
        Dim result As DialogResult = fileChooser.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            fileName2 = fileChooser.FileName
        End If
        'End If
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
    Sub read()
        Try
            fileSet()
            If fileName <> "" Then
                linkClose()
                lsbResult.Items.Clear()
                robotFileReader = New StreamReader(fileName)
                lsbResult.Items.Add(String.Format("--------- Opening {0} ------------", fileName))
                lsbResult.Items.Add(" ")
                Do While Not robotFileReader.EndOfStream
                    lsbResult.Items.Add(robotFileReader.ReadLine)
                Loop
                linkClose()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    'closing the program here
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    'when browse get clicked 
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        read()
    End Sub
    'this is where we create new directory 
    Private Sub btnDirectory_Click(sender As Object, e As EventArgs) Handles btnDirectory.Click
        Try
            directoryTarget = txtInputDirectoryName.Text
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        If directoryTarget <> "" Then
            Try
                My.Computer.FileSystem.CreateDirectory("C:\" & directoryTarget)
                newLocation = "C:\" & directoryTarget
                MsgBox("directory created")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            MsgBox("Please select a name for the new directory")
        End If
    End Sub
    'this is where we move old files to new directory
    Private Sub btnMove_Click(sender As Object, e As EventArgs) Handles btnMove.Click
        If newLocation <> "" Then
            Try
                My.Computer.FileSystem.MoveFile("C:\baseball.txt", newLocation & "\baseball.txt")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            MsgBox("Please make a new directory first")
        End If
    End Sub
    'this is where we analyse it
    Private Sub btnAnalyse_Click(sender As Object, e As EventArgs) Handles btnAnalyse.Click
        If fileName <> "" Then
            Try
                Dim text = File.ReadAllText(fileName)
                Dim countIn = Regex.Matches(text, "in").Count
                Dim countOut = Regex.Matches(text, "out").Count
                lblAnalyseResult.Text = String.Format("Anylysis Result: occurrences of Word 'in' : {0} and Word 'out' : {1}", countIn, countOut)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            MsgBox("Please open a file for analysis first")
        End If
    End Sub
    'this is where we save the analysis
    Private Sub SaveAnakysis_Click(sender As Object, e As EventArgs) Handles SaveAnakysis.Click
        Try
            If lblAnalyseResult.Text <> "" Then
                fileSet2()
                If fileName2 <> "" Then
                    linkClose()
                    robotFileWriter = New StreamWriter(fileName2, True)
                    robotFileWriter.WriteLine(lblAnalyseResult.Text)
                End If
            Else
                MsgBox("Please do the analysis first")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



End Class
