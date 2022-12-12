Option Strict On
Option Explicit On

'this is the needed structure
Public Structure gear
    Dim inputNGearA, outputNGearB As Double
    Dim inputNGearC, outputNGearD As Double
    Dim inputTorque, inputSpeed As Double
End Structure
Public Class frmGearCalculator
    Dim validationCode As Integer
    Dim newGear As gear


    'this happen on load 
    Private Sub frmGearCalculator_Load(sender As Object, e As EventArgs) Handles Me.Load
        'loading combo box values
        For i = 2 To 10 Step 1
            cmbInputSpeed.Items.Add(i)
        Next
        'loading the numeric up down values 
        nudInputTorque.Increment = 5
        nudInputTorque.Value = 0
        'Giving the min value 0 so the user does not start the program with 5 by mistake and making sure the user select value and 0 would give an error
        nudInputTorque.Minimum = 0
        nudInputTorque.Maximum = 50
        nudInputTorque.ReadOnly = True
    End Sub
    'validation input function
    Function validation(ByVal input1 As String, ByVal input2 As String, ByVal input3 As String, ByVal input4 As String, ByVal input5 As Double) As Integer
        'Checking inputs are not empty
        If input1 <> "" Then
            If input2 <> "" Then
                If input3 <> "" Then
                    If input4 <> "" Then
                        If input5 <> 0 Then
                            If IsNumeric(input1) And IsNumeric(input2) And IsNumeric(input3) And IsNumeric(input4) Then
                                'this part checking the input is not numeric
                                validation = 0
                                newGear.inputNGearA = CDbl(input1)
                                newGear.outputNGearB = CDbl(input2)
                                newGear.inputNGearC = CDbl(input3)
                                newGear.outputNGearD = CDbl(input4)
                                newGear.inputTorque = CDbl(input5)
                            Else
                                validation = -6
                            End If
                        Else
                            validation = -5
                        End If
                    Else
                        validation = -4
                    End If
                Else
                    validation = -3
                End If
            Else
                validation = -2
            End If
        Else
            validation = -1
        End If
        Return validation
    End Function
    'This part is to show the needed Error Msg
    Sub errorMsg(ByVal inputMsgCode As Integer)
        Dim msgNote As String = ""
        Select Case inputMsgCode
            Case 0
                msgNote = "all values are valid"
            Case -1
                msgNote = "Please enter the number of teeth for Gear A"
            Case -2
                msgNote = "Please enter the number of teeth for Gear B"
            Case -3
                msgNote = "Please enter the number of teeth for Gear C"
            Case -4
                msgNote = "Please enter the number of teeth for Gear D"
            Case -5
                msgNote = "Please Select the input Torque , it can not be zero"
            Case -6
                msgNote = "Please make sure all inputs are in numeric format"
            Case -7
                msgNote = "Please Select the input Speed"
        End Select
        MsgBox(msgNote)
    End Sub
    'this function clearout everything
    Sub clear()
        lblRatioTotalResult.Text = ""
        lblOutputSpeedResult.Text = ""
        lblOutputTorqueResult.Text = ""
    End Sub
    'this is when exit button get clicked
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        MsgBox("Have a Good Day")
        Me.Close()
    End Sub
    'this is where the torque /  speed button get clicked
    Private Sub btnGearTorqueRatioCalculator_Click(sender As Object, e As EventArgs) Handles btnGearTorqueRatioCalculator.Click
        validationCode = validation(txtGearTeethA.Text, txtGearTeethB.Text, txtGearTeethC.Text, txtGearTeethD.Text, nudInputTorque.Value)
        If validationCode = 0 Then
            lblRatioTotalResult.Text = CStr((newGear.outputNGearB / newGear.inputNGearA) * (newGear.outputNGearD / newGear.inputNGearC))
            lblOutputTorqueResult.Text = CStr(((newGear.outputNGearB / newGear.inputNGearA) * (newGear.outputNGearD / newGear.inputNGearC)) * newGear.inputTorque)
            'this part is to display the error msg
        Else
            errorMsg(validationCode)
        End If
    End Sub
    'this is when speed calculator button get clicked
    Private Sub btnSpeedCalculator_Click(sender As Object, e As EventArgs) Handles btnSpeedCalculator.Click
        validationCode = validation(txtGearTeethA.Text, txtGearTeethB.Text, txtGearTeethC.Text, txtGearTeethD.Text, nudInputTorque.Value)
        If validationCode = 0 Then
            If cmbInputSpeed.Text <> "" Then
                newGear.inputSpeed = CDbl(cmbInputSpeed.Text)
                lblOutputSpeedResult.Text = CStr(newGear.inputSpeed / ((newGear.outputNGearB / newGear.inputNGearA) * (newGear.outputNGearD / newGear.inputNGearC)))
                lblRatioTotalResult.Text = CStr((newGear.outputNGearB / newGear.inputNGearA) * (newGear.outputNGearD / newGear.inputNGearC))
                lblOutputTorqueResult.Text = CStr(((newGear.outputNGearB / newGear.inputNGearA) * (newGear.outputNGearD / newGear.inputNGearC)) * newGear.inputTorque)
            Else
                errorMsg(-7)
            End If

            'this part is to display the error msg
        Else
            errorMsg(validationCode)
        End If
    End Sub
    'THis part is to clear out the result when the inputs changes so we wouldn't be displaying wrong results at any given time
    Private Sub txtGearTeethA_TextChanged(sender As Object, e As EventArgs) Handles txtGearTeethA.TextChanged
        clear()
    End Sub

    Private Sub txtGearTeethB_TextChanged(sender As Object, e As EventArgs) Handles txtGearTeethB.TextChanged
        clear()
    End Sub

    Private Sub txtGearTeethC_TextChanged(sender As Object, e As EventArgs) Handles txtGearTeethC.TextChanged
        clear()
    End Sub

    Private Sub txtGearTeethD_TextChanged(sender As Object, e As EventArgs) Handles txtGearTeethD.TextChanged
        clear()
    End Sub

    Private Sub cmbInputSpeed_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbInputSpeed.SelectedIndexChanged
        clear()
    End Sub

    Private Sub nudInputTorque_ValueChanged(sender As Object, e As EventArgs) Handles nudInputTorque.ValueChanged
        clear()
    End Sub
End Class
