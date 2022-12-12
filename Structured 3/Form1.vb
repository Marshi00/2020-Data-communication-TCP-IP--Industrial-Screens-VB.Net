Option Strict On
Option Explicit On
Public Class frmRobotArm
    Dim xCord, yCord, Zcord, liftResult, rotationResult, lengthResult As Single
    Dim validationCode As Integer
    'This part is to calculate the Arm Length 
    Function lengthCalculator(ByVal inputX As Single, ByVal inputY As Single, ByVal inputZ As Single) As Single
        Dim lengthCalculatorResult As Single
        lengthCalculatorResult = CSng(Math.Round(Math.Sqrt((inputX ^ 2) + (inputY ^ 2) + (inputZ ^ 2)), 2))
        lengthCalculator = lengthCalculatorResult
    End Function
    'This part is to calculate the rotation
    Function rotationCalculator(ByVal inputX As Single, ByVal inputY As Single) As Single
        Dim rotationCalculatorResult As Single
        rotationCalculatorResult = CSng(Math.Round((Math.Atan(inputY / inputX)) * (180 / Math.PI), 1))
        rotationCalculator = rotationCalculatorResult
    End Function


    'This part is to calculate the lift
    Function liftCalculator(ByVal inputX As Single, ByVal inputY As Single, ByVal inputZ As Single) As Single
        Dim liftCalculatorResult As Single
        liftCalculatorResult = CSng(Math.Round((Math.Atan(inputZ / (Math.Sqrt((inputX ^ 2) + (inputY ^ 2)))) * (180 / Math.PI)), 1))
        liftCalculator = liftCalculatorResult
    End Function
    'This part is to check errors
    Function validation(ByVal inputX As String, ByVal inputY As String, ByVal inputZ As String) As Integer
        Dim validationResult As Integer
        'Checking inputs are not empty
        If inputX <> "" And inputY <> "" And inputZ <> "" Then
            'this part checking the input is not numeric 
            If IsNumeric(inputX) And IsNumeric(inputY) And IsNumeric(inputZ) Then
                xCord = CSng(inputX)
                yCord = CSng(inputY)
                Zcord = CSng(inputZ)
                lengthResult = lengthCalculator(xCord, yCord, Zcord)
                rotationResult = rotationCalculator(xCord, yCord)
                liftResult = liftCalculator(xCord, yCord, Zcord)
                'this part checking the input is not nagetive 
                If xCord < 0 Or yCord < 0 Or Zcord < 0 Then
                    validationResult = -2
                    'this part is to check the length is in range 
                ElseIf lengthResult < 10 Or lengthResult > 25 Then
                    validationResult = -3
                    'this part is to check the rotation angle is in range 
                ElseIf rotationResult < -90 Or rotationResult > 90 Then
                    validationResult = -4
                    'this part is to check the lift angle is in range
                ElseIf liftResult < -10 Or liftResult > 45 Then
                    validationResult = -5
                Else
                    validationResult = 1
                End If
            Else
                validationResult = -1
            End If
        Else
            validationResult = 2
        End If
        validation = validationResult
    End Function
    'This part is to show the needed Error Msg 
    Sub errorMsg(ByVal inputMsgCode As Integer)
        Dim msgNote As String = ""
        Select Case inputMsgCode
            Case 1
                msgNote = "all values are valid"
            Case -1
                msgNote = "the input for X,Y,Z must be numeric"
            Case -2
                msgNote = "the input for X,Y,Z can not be negative"
            Case -3
                msgNote = "the length is not between 10 and 25 inches "
            Case -4
                msgNote = "the rotation angle  is not between -90 and 90"
            Case -5
                msgNote = "the lift angle  is not between -10 and 45"
            Case 2
                msgNote = " coordination for X, Y & Z can not be empty"
        End Select
        MsgBox(msgNote)
    End Sub
    'this is where Calculate button gets clicked 
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        validationCode = validation(txtCoordinationX.Text, txtCoordinationY.Text, txtCoordinationZ.Text)
        If validationCode = 1 Or validationCode < -2 Then
            lsbResult.Items.Add("X" & vbTab & "Y" & vbTab & "Z" & vbTab & "Length" & vbTab & "Rotation" & vbTab & "Lift ")
            lsbResult.Items.Add(xCord & vbTab & yCord & vbTab & Zcord & vbTab & lengthResult & vbTab & rotationResult & vbTab & liftResult)
            lsbResult.Items.Add("---------------------------------------------------------------------------------------------------------------")
            lsbResult.Items.Add("         ------------------------------------------------------------------------------------------")
            errorMsg(validationCode)
        Else
            errorMsg(validationCode)
        End If
    End Sub
    'This part is to close the program 
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
