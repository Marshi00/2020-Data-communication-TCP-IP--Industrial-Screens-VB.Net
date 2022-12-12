Option Explicit On
Option Strict On
Imports System.IO
Public Class frmRobotDatabase
    Dim validationCode As Integer
    Dim robotStatus, fileName As String
    Dim fileChooser As New OpenFileDialog
    Dim robotFileReader As StreamReader
    Dim robotFileWriter As StreamWriter
    Dim newRobot As robot
    'this is structure to store function and variables reltared to the robot
    Public Structure robot
        Dim serialNumber As String
        Dim manufacturer As String
        Dim modelNumber As String
        Dim yearOfPurchase As Integer
        Dim currentRobotStatus As String
        'this check the waranth status of robot
        Function warrantyCheck(ByVal inputstring As Integer) As String
            Dim currentYear As Integer = System.DateTime.Now.Year
            If (currentYear - inputstring) < 1 Then
                warrantyCheck = "Valid"
            Else
                warrantyCheck = "Expired"
            End If
        End Function
    End Structure
    'this part check if path has been not set before and set a new path
    Sub fileSet()
        If fileName = "" Then
            Dim result As DialogResult = fileChooser.ShowDialog()
            If result = Windows.Forms.DialogResult.OK Then
                fileName = fileChooser.FileName
            End If
        End If
    End Sub
    'this part check the status of robot
    Private Sub rdbNew_CheckedChanged(sender As Object, e As EventArgs) Handles rdbNew.CheckedChanged
        If rdbNew.Checked = True Then
            robotStatus = "New"
        End If
    End Sub
    Private Sub rdbDead_CheckedChanged(sender As Object, e As EventArgs) Handles rdbDead.CheckedChanged
        If rdbDead.Checked = True Then
            robotStatus = "Dead"
        End If
    End Sub
    Private Sub rdbGood_CheckedChanged(sender As Object, e As EventArgs) Handles rdbGood.CheckedChanged
        If rdbGood.Checked = True Then
            robotStatus = "Good"
        End If
    End Sub
    'this add items in the combo box on form load
    Private Sub frmRobotDatabase_Load(sender As Object, e As EventArgs) Handles Me.Load
        For yearStart As Integer = 2016 To 2020
            cmbYearOfPurchase.Items.Add(yearStart)
        Next
    End Sub
    'this function checks the inputs are valid
    Function validation(ByVal input1 As String, ByVal input2 As String, ByVal input3 As String, ByVal input4 As String, ByVal input5 As String) As Integer
        Dim validationResult As Integer
        'Checking inputs are not empty
        If input1 <> "" Then
            If input2 <> "" Then
                If input3 <> "" Then
                    If input4 <> "" Then
                        If input5 <> "" Then
                            'this part checking the input is not numeric
                            If IsNumeric(input4) Then
                                newRobot.yearOfPurchase = CInt(input4)
                                'this part checking yearOfPurchase is not over current date
                                If newRobot.yearOfPurchase > System.DateTime.Now.Year Then
                                    validationResult = 7
                                Else
                                    validationResult = 8
                                    newRobot.serialNumber = input1
                                    newRobot.manufacturer = input2
                                    newRobot.modelNumber = input3
                                    newRobot.currentRobotStatus = input5
                                End If
                            Else
                                validationResult = 6
                            End If
                        Else
                            validationResult = 5
                        End If
                    Else
                        validationResult = 4
                    End If
                Else
                    validationResult = 3
                End If
            Else
                validationResult = 2
            End If
        Else
            validationResult = 1
        End If
        validation = validationResult
    End Function
    'This part is to show the needed Error Msg
    Sub errorMsg(ByVal inputMsgCode As Integer)
        Dim msgNote As String = ""
        Select Case inputMsgCode
            Case 8
                msgNote = "all values are valid"
            Case 1
                msgNote = "Please enter the robot serial number"
            Case 2
                msgNote = "Please enter the Manufacturer"
            Case 3
                msgNote = "Please enter the Model Number "
            Case 4
                msgNote = "Please enter the year of purchase"
            Case 5
                msgNote = "Please select the robot status"
            Case 6
                msgNote = " Please enter the year of purchase in numeric format"
            Case 7
                msgNote = " Year of purchase can not be over current date "
        End Select
        MsgBox(msgNote)
    End Sub
    'this clearout everything
    Sub clear()
        txtManufacturer.Text = ""
        txtModelNumber.Text = ""
        txtSerialNumber.Text = ""
        cmbYearOfPurchase.Text = ""
        rdbDead.Checked = False
        rdbGood.Checked = False
        rdbNew.Checked = False
        robotStatus = ""
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
    'this close the program
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    'this is where add button get clicked 
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'checking that inputs are valid
        validationCode = validation(txtSerialNumber.Text, txtManufacturer.Text, txtModelNumber.Text, cmbYearOfPurchase.Text, robotStatus)
        If validationCode = 8 Then
            fileSet()
            If fileName <> "" Then
                    linkClose()
                    robotFileWriter = New StreamWriter(fileName, True)
                robotFileWriter.WriteLine(String.Format("{0}, {1}, {2}, {3}, {4},{5}", newRobot.serialNumber, newRobot.manufacturer, newRobot.modelNumber, newRobot.yearOfPurchase, newRobot.warrantyCheck(newRobot.yearOfPurchase), newRobot.currentRobotStatus))
                linkClose()
                    clear()
                End If

            Else
                errorMsg(validationCode)
        End If
    End Sub
    'this is where display list button get clicked 
    Private Sub btnRobotList_Click(sender As Object, e As EventArgs) Handles btnRobotList.Click
        fileSet()
        If fileName <> "" Then
            linkClose()
            robotFileReader = New StreamReader(fileName)
            lsbResult.Items.Add(String.Format("--------- Opening {0} ------------", fileName))
            lsbResult.Items.Add(" ")
            Do While Not robotFileReader.EndOfStream
                lsbResult.Items.Add(robotFileReader.ReadLine)
            Loop
            linkClose()
        End If
    End Sub
End Class
