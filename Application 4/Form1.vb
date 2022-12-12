Option Explicit On
Option Strict On
Imports System.IO
Public Class frmArrays
    Dim lowerRange, upperRange As Integer
    Dim displayTarget As Integer = 0
    Dim i As Integer = 0
    Dim k As Integer = 0
    Dim z As Integer = 0
    Dim fileChooser As New OpenFileDialog
    Dim folderChooser As New FolderBrowserDialog
    Dim robotFileReader As StreamReader
    Dim robotFileWriter As StreamWriter
    Dim fileName, saveLocation, errorSaveLocation As String
    Dim ovenOneArray(), ovenTwoArray(), allArray() As String
    'this is where we select the lower Range / Combo boxes update base on each other
    Private Sub cmbLowerRange_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLowerRange.Click
        cmbLowerRange.Items.Clear()
        If cmbUpperRange.Text <> "" Then
            For q = 0 To CDbl(cmbUpperRange.SelectedItem) - 100 Step 100
                cmbLowerRange.Items.Add(q)
            Next
        Else
            For t = 0 To 999 Step 100
                cmbLowerRange.Items.Add(t)
            Next
        End If
    End Sub
    'this is where we select the higher range / COmbo boxes update base on each other
    Private Sub cmbUpperRange_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbUpperRange.Click
        cmbUpperRange.Items.Clear()
        If cmbLowerRange.Text <> "" Then
            For p = CDbl(cmbLowerRange.SelectedItem) + 100 To 1000 Step 100
                cmbUpperRange.Items.Add(p)
            Next
        Else
            For f = 100 To 1000 Step 100
                cmbUpperRange.Items.Add(f)
            Next
        End If
    End Sub
    'this is the form load ( not allowing the form to run untill temp file is selected ) 
    Private Sub frmArrays_Load(sender As Object, e As EventArgs) Handles Me.Load
        Do While fileName = ""
            MsgBox("Please locate the Temps file to run to form")
            fileSet()
        Loop
        Try
            'putting every single line into an array
            linkClose()
            robotFileReader = New StreamReader(fileName)
            Do While Not robotFileReader.EndOfStream
                ReDim Preserve allArray(i)
                allArray(i) = robotFileReader.ReadLine
                i += 1
            Loop
            linkClose()
            'putting the lines that start with 1 in oven 1 array
            For j = 0 To allArray.GetUpperBound(0)
                Dim numberOfNumbers() As Char = Trim(allArray(j)).ToCharArray
                If numberOfNumbers(0) = "1" Then
                    ReDim Preserve ovenOneArray(k)
                    ovenOneArray(k) = allArray(j)
                    k += 1
                    'putting the lines that start with 2 in oven2 array
                ElseIf numberOfNumbers(0) = "2" Then
                    ReDim Preserve ovenTwoArray(z)
                    ovenTwoArray(z) = allArray(j)
                    z += 1
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
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
    'this  is where we save files for oven data/ pick location 
    Sub savePath()
        If saveLocation = "" Then
            Dim target As DialogResult = folderChooser.ShowDialog()
            If target = Windows.Forms.DialogResult.OK Then
                saveLocation = folderChooser.SelectedPath
            End If
        End If
    End Sub
    'this  is where we save files for errorlog / pick location 
    Sub errorSavePath()
        If errorSaveLocation = "" Then
            Dim target2 As DialogResult = folderChooser.ShowDialog()
            If target2 = Windows.Forms.DialogResult.OK Then
                errorSaveLocation = folderChooser.SelectedPath
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
    'close button get clicked
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    'this check if oven 1 is checked
    Private Sub rdbOven1_CheckedChanged(sender As Object, e As EventArgs) Handles rdbOven1.CheckedChanged
        If rdbOven1.Checked = True Then
            displayTarget = 2
        End If
    End Sub
    'this check if oven 2 is checked
    Private Sub rdbOven2_CheckedChanged(sender As Object, e As EventArgs) Handles rdbOven2.CheckedChanged
        If rdbOven2.Checked = True Then
            displayTarget = 3
        End If
    End Sub
    'this check if if all radio button is checked
    Private Sub rdbAll_CheckedChanged(sender As Object, e As EventArgs) Handles rdbAll.CheckedChanged
        If rdbAll.Checked = True Then
            displayTarget = 1
        End If
    End Sub
    'this is for title
    Sub listBoxTitle()
        lsbResult.Items.Add(String.Format("--------- Opening {0} ------------", fileName))
        lsbResult.Items.Add(" ")
    End Sub
    'this is when display button get clicked
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        If displayTarget <> 0 Then
            If cmbLowerRange.Text <> "" Then
                If cmbUpperRange.Text <> "" Then
                    lowerRange = CInt(cmbLowerRange.SelectedItem)
                    upperRange = CInt(cmbUpperRange.SelectedItem)
                    Try
                        Select Case displayTarget
                            Case 1
                                fileSet()
                                If fileName <> "" Then
                                    lsbResult.Items.Clear()
                                    listBoxTitle()
                                    For Each item In allArray
                                        Dim numberOfNumbers() As Char = item.ToCharArray
                                        Dim mustTemp As String = numberOfNumbers(1) & numberOfNumbers(2) & numberOfNumbers(3)
                                        If CInt(mustTemp) > lowerRange And CInt(mustTemp) < upperRange Then
                                            lsbResult.Items.Add(item)
                                        End If
                                    Next
                                End If
                            Case 2
                                fileSet()
                                If fileName <> "" Then
                                    lsbResult.Items.Clear()
                                    listBoxTitle()
                                    For Each item In ovenOneArray
                                        Dim numberOfNumbers() As Char = item.ToCharArray
                                        Dim mustTemp As String = numberOfNumbers(1) & numberOfNumbers(2) & numberOfNumbers(3)
                                        If CInt(mustTemp) > lowerRange And CInt(mustTemp) < upperRange Then
                                            lsbResult.Items.Add(item)
                                        End If
                                    Next
                                End If
                            Case 3
                                If fileName <> "" Then
                                    lsbResult.Items.Clear()
                                    listBoxTitle()
                                    For Each item In ovenTwoArray
                                        Dim numberOfNumbers() As Char = item.ToCharArray
                                        Dim mustTemp As String = numberOfNumbers(1) & numberOfNumbers(2) & numberOfNumbers(3)
                                        If CInt(mustTemp) > lowerRange And CInt(mustTemp) < upperRange Then
                                            lsbResult.Items.Add(item)
                                        End If
                                    Next
                                End If
                        End Select
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                Else
                    MsgBox("Please Select the upper range ")
                End If
            Else
                MsgBox("Please Select the lower range ")
            End If

        Else
            MsgBox("Please Select what to display first ")
        End If
    End Sub
    'this is where save data get clicked 
    Private Sub btnWriteData_Click(sender As Object, e As EventArgs) Handles btnWriteData.Click
        Try
            savePath()
            If saveLocation <> "" Then
                Dim Oven1Path = saveLocation & "\Oven1.txt"
                Dim Oven2Path = saveLocation & "\Oven2.txt"
                linkClose()
                robotFileWriter = New StreamWriter(Oven1Path, True)
                'text file for oven 1 Data
                For Each item In ovenOneArray
                    robotFileWriter.WriteLine(item)
                Next
                linkClose()
                'text file for oven 2 Data
                robotFileWriter = New StreamWriter(Oven2Path, True)
                For Each item In ovenTwoArray
                    robotFileWriter.WriteLine(item)
                Next
                linkClose()
            Else
                MsgBox("Please Select Where to save the files")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    'this is where sort button get Clicked
    Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnSort.Click
        If displayTarget <> 0 Then
            If cmbLowerRange.Text <> "" Then
                If cmbUpperRange.Text <> "" Then
                    lowerRange = CInt(cmbLowerRange.SelectedItem)
                    upperRange = CInt(cmbUpperRange.SelectedItem)
                    Try
                        Select Case displayTarget
                            Case 1
                                fileSet()
                                If fileName <> "" Then
                                    lsbResult.Items.Clear()
                                    listBoxTitle()
                                    Dim listToSort As New List(Of Tuple(Of String, String))
                                    For Each item In allArray
                                        Dim numberOfNumbers() As Char = item.ToCharArray
                                        Dim mustTemp As String = numberOfNumbers(1) & numberOfNumbers(2) & numberOfNumbers(3)
                                        If CInt(mustTemp) > lowerRange And CInt(mustTemp) < upperRange Then
                                            listToSort.Add(Tuple.Create(item, mustTemp))
                                        End If
                                    Next
                                    listToSort = listToSort.OrderBy(Function(i) i.Item2).ToList
                                    For Each tpl As Tuple(Of String, String) In listToSort
                                        lsbResult.Items.Add(tpl.Item1)
                                    Next
                                End If
                            Case 2
                                fileSet()
                                If fileName <> "" Then
                                    lsbResult.Items.Clear()
                                    listBoxTitle()
                                    Dim listToSort As New List(Of Tuple(Of String, String))
                                    For Each item In ovenOneArray
                                        Dim numberOfNumbers() As Char = item.ToCharArray
                                        Dim mustTemp As String = numberOfNumbers(1) & numberOfNumbers(2) & numberOfNumbers(3)
                                        If CInt(mustTemp) > lowerRange And CInt(mustTemp) < upperRange Then
                                            listToSort.Add(Tuple.Create(item, mustTemp))
                                        End If
                                    Next
                                    listToSort = listToSort.OrderBy(Function(i) i.Item2).ToList
                                    For Each tpl As Tuple(Of String, String) In listToSort
                                        lsbResult.Items.Add(tpl.Item1)
                                    Next
                                End If
                            Case 3
                                If fileName <> "" Then
                                    lsbResult.Items.Clear()
                                    listBoxTitle()
                                    Dim listToSort As New List(Of Tuple(Of String, String))
                                    For Each item In ovenTwoArray
                                        Dim numberOfNumbers() As Char = item.ToCharArray
                                        Dim mustTemp As String = numberOfNumbers(1) & numberOfNumbers(2) & numberOfNumbers(3)
                                        If CInt(mustTemp) > lowerRange And CInt(mustTemp) < upperRange Then
                                            listToSort.Add(Tuple.Create(item, mustTemp))
                                        End If
                                    Next
                                    listToSort = listToSort.OrderBy(Function(i) i.Item2).ToList
                                    For Each tpl As Tuple(Of String, String) In listToSort
                                        lsbResult.Items.Add(tpl.Item1)
                                    Next
                                End If
                        End Select
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                Else
                    MsgBox("Please Select the upper range ")
                End If
            Else
                MsgBox("Please Select the lower range ")
            End If

        Else
            MsgBox("Please Select what to display first ")
        End If
    End Sub
    'this is where error logs get clicked
    Private Sub btnLogErrors_Click(sender As Object, e As EventArgs) Handles btnLogErrors.Click
        Try
            errorSavePath()
            If errorSaveLocation <> "" Then
                Dim erorOven1Path = errorSaveLocation & "\errorLogOven1.txt"
                Dim errorOven2Path = errorSaveLocation & "\errorLogOven2.txt"
                linkClose()
                robotFileWriter = New StreamWriter(erorOven1Path, True)
                'text file for oven 1 Data
                For Each item In ovenOneArray
                    Dim numberOfErrors() As Char = item.ToCharArray
                    Dim mustTemp As String = numberOfErrors(1) & numberOfErrors(2) & numberOfErrors(3)
                    Dim currentTemp As String = numberOfErrors(6) & numberOfErrors(7) & numberOfErrors(8)
                    Dim errorGap As Integer
                    errorGap = CInt(mustTemp) - CInt(currentTemp)
                    If errorGap > 3 Or errorGap < -3 Then
                        robotFileWriter.WriteLine(item & " " & errorGap)
                    End If
                Next
                linkClose()
                'text file for oven 2 Data
                robotFileWriter = New StreamWriter(errorOven2Path, True)
                For Each item In ovenTwoArray
                    Dim numberOfErrors() As Char = item.ToCharArray
                    Dim mustTemp As String = numberOfErrors(1) & numberOfErrors(2) & numberOfErrors(3)
                    Dim currentTemp As String = numberOfErrors(6) & numberOfErrors(7) & numberOfErrors(8)
                    Dim errorGap As Integer
                    errorGap = CInt(mustTemp) - CInt(currentTemp)
                    If errorGap > 3 Or errorGap < -3 Then
                        robotFileWriter.WriteLine(item & " " & errorGap)
                    End If
                Next
                linkClose()
            Else
                MsgBox("Please Select Where to save the files")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
