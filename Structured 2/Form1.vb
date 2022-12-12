Option Explicit On
Option Strict On
Public Class frmCncMachine
    Dim minSize, stockSizeIncrement, spindleSpeed As Double
    Dim matrixA(0, 6) As Double
    Dim p, q As Integer
    Dim result(6) As String
    Dim tempA As Integer
    Const pi As Double = 3.14159265358979

    'This part is to get the Stock size Increment from Radio boxes 
    Private Sub rdbSize1_CheckedChanged(sender As Object, e As EventArgs) Handles rdbSize1.CheckedChanged
        If rdbSize1.Checked = True Then
            stockSizeIncrement = 0.125
        End If
    End Sub

    Private Sub rdbSize2_CheckedChanged(sender As Object, e As EventArgs) Handles rdbSize2.CheckedChanged
        If rdbSize2.Checked = True Then
            stockSizeIncrement = 0.25
        End If
    End Sub

    Private Sub rdbSize3_CheckedChanged(sender As Object, e As EventArgs) Handles rdbSize3.CheckedChanged
        If rdbSize3.Checked = True Then
            stockSizeIncrement = 0.375
        End If
    End Sub

    Private Sub rdbSize4_CheckedChanged(sender As Object, e As EventArgs) Handles rdbSize4.CheckedChanged
        If rdbSize4.Checked = True Then
            stockSizeIncrement = 0.5
        End If
    End Sub
    'This part is to add items in the Min & Max & RMP combo box on load 
    Private Sub frmCncMachine_Load(sender As Object, e As EventArgs) Handles Me.Load
        For j = 500 To 5000 Step 100
            cmbSpindleSpeed.Items.Add(j)
        Next
    End Sub
    'This part is to add items in Min Combo Box based on Max
    Private Sub cmbMinStockSize_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMinStockSize.Click
        cmbMinStockSize.Items.Clear()
        If cmbMaxStockSize.Text <> "" Then
            For z = 0.25 To CDbl(cmbMaxStockSize.SelectedItem) - 0.25 Step 0.25
                cmbMinStockSize.Items.Add(z)
            Next
        Else
            For i = 0.25 To 4 Step 0.25
                cmbMinStockSize.Items.Add(i)
            Next
        End If
    End Sub
    'This part is to add items in Max Combo Box based on Min
    Private Sub cmbMaxStockSize_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMaxStockSize.Click
        cmbMaxStockSize.Items.Clear()
        If cmbMinStockSize.Text <> "" Then
            For k = CDbl(cmbMinStockSize.SelectedItem) + 0.25 To 4 Step 0.25
                cmbMaxStockSize.Items.Add(k)
            Next
        Else
            For i = 0.25 To 4 Step 0.25
                cmbMaxStockSize.Items.Add(i)
            Next
        End If
    End Sub

    'This part is when the Calculate button get clicked 

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'This part is to check Min box is not empty 

        If cmbMinStockSize.Text <> "" Then

            'This part is to check Max Box is not empty

            If cmbMaxStockSize.Text <> "" Then

                'This part is to check RPM Box is not empty

                If cmbSpindleSpeed.Text <> "" Then
                    'This part is to check Stock Size Increment is selected
                    If stockSizeIncrement <> 0 Then
                        spindleSpeed = CDbl(cmbSpindleSpeed.Text)
                        lsbResult.Items.Add(" Stock Size" & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & "Cutting Speed(ft/min)")
                        lsbResult.Items.Add("  (inches)" & vbTab & vbTab & "40" & vbTab & vbTab & "60" & vbTab & vbTab & "80" & vbTab & vbTab & "100" & vbTab & vbTab & "120" & vbTab & vbTab & "140" & vbTab & vbTab & "160")
                        lsbResult.Items.Add("")
                        lsbResult.Items.Add("")
                        'this part is to fill matrixA also known as V in the Equation
                        For w = 0 To 6
                            matrixA(0, w) = 40 + (w * 20)
                        Next
                        'this part is to get count of items in matrixB
                        For minSize = CDbl(cmbMinStockSize.SelectedItem) To CDbl(cmbMaxStockSize.SelectedItem) Step stockSizeIncrement
                            p += 1
                        Next
                        'this part is to get matrixB
                        Dim matrixB(0, p) As Double
                        For minSize = CDbl(cmbMinStockSize.SelectedItem) To CDbl(cmbMaxStockSize.SelectedItem) Step stockSizeIncrement
                            matrixB(0, q) = minSize
                            q += 1
                        Next
                        'this part is to get the values needed by the use of Equation and the matrix that we have made 
                        For m = 0 To matrixB.GetUpperBound(1)
                            For h = 0 To matrixA.GetUpperBound(1)
                                If (12 * matrixA(0, h)) / (pi * matrixB(0, m)) < spindleSpeed Then
                                    tempA = CInt((12 * matrixA(0, h)) / (pi * matrixB(0, m)))
                                    result(h) = CStr(tempA)
                                Else
                                    result(h) = "TOO HI"
                                End If

                            Next
                            If matrixB(0, m) <> 0 Then


                                lsbResult.Items.Add(" " & matrixB(0, m) & vbTab & vbTab & result(0) & vbTab & vbTab & result(1) & vbTab & vbTab & result(2) & vbTab & vbTab & result(3) & vbTab & vbTab & result(4) & vbTab & vbTab & result(5) & vbTab & vbTab & result(6) & " ")
                            End If
                        Next

                        lsbResult.Items.Add("--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------")
                        lsbResult.Items.Add("       -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------")
                    Else
                        MsgBox("Please Select the Stock Size Increment ")
                    End If
                Else
                    MsgBox("Please Select the Spindle Speed")
                End If
            Else
                MsgBox("Please Select the Maximum Stock Size")
            End If

        Else
            MsgBox("Please Select the Minimum Stock Size")
        End If
    End Sub

    'This part is to close the program 
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        MsgBox("HAVE A FANTASTIC DAY")
        Me.Close()
    End Sub


End Class