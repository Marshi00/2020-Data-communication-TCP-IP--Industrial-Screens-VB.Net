Option Explicit On
Option Strict On
Public Class frmAdhesiveRobot
    Dim diameter, numberOfDot, centerX, centerY, targetY, targetX, anglePerDot, offsetDegree, i, j As Decimal
    Const pi As Double = 3.14159265358979
    Private Sub robDot2_CheckedChanged(sender As Object, e As EventArgs) Handles rdbDot2.CheckedChanged
        If rdbDot2.Checked Then
            numberOfDot = 2
            If numberOfDot <> 0 Then
                cmbSkipPlacement.Items.Clear()
                For i = 1 To numberOfDot
                    cmbSkipPlacement.Items.Add(i)
                Next
            End If
        End If
    End Sub

    Private Sub robDot4_CheckedChanged(sender As Object, e As EventArgs) Handles rdbDot4.CheckedChanged
        If rdbDot4.Checked Then
            numberOfDot = 4
            If numberOfDot <> 0 Then
                cmbSkipPlacement.Items.Clear()
                For i = 1 To numberOfDot
                    cmbSkipPlacement.Items.Add(i)
                Next
            End If
        End If
    End Sub

    Private Sub robDot8_CheckedChanged(sender As Object, e As EventArgs) Handles rdbDot8.CheckedChanged
        If rdbDot8.Checked Then
            numberOfDot = 8
            If numberOfDot <> 0 Then
                cmbSkipPlacement.Items.Clear()
                For i = 1 To numberOfDot
                    cmbSkipPlacement.Items.Add(i)
                Next
            End If
        End If
    End Sub

    Private Sub chbSkipPlacement_CheckedChanged(sender As Object, e As EventArgs) Handles chbSkipPlacement.CheckedChanged
        If chbSkipPlacement.Checked Then
            If numberOfDot <> 0 Then
                cmbSkipPlacement.Visible = True

            Else
                MsgBox("Please Pick the number of the adhesive to be placed")
                chbSkipPlacement.CheckState = 0

            End If
        Else
            cmbSkipPlacement.Visible = False
        End If
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If txtCircleDiameter.Text <> "" Then
            diameter = CDec(txtCircleDiameter.Text)

            If txtFirstDotLocation.Text <> "" Then

                offsetDegree = CDec(txtFirstDotLocation.Text)


                If numberOfDot <> 0 Then

                    If txtXcordCenterPoint.Text <> "" Then
                        centerX = CDec(txtXcordCenterPoint.Text)

                        If txtYcordCenterPoint.Text <> "" Then
                            centerY = CDec(txtYcordCenterPoint.Text)
                            anglePerDot = 360 / numberOfDot




                            lsbResultDotCord.Items.Add("circle diameter in mm : " & txtCircleDiameter.Text)
                            lsbResultDotCord.Items.Add("offset angle : " & txtFirstDotLocation.Text)
                            lsbResultDotCord.Items.Add("number of the adhesive to be placed : " & numberOfDot)
                            lsbResultDotCord.Items.Add("X position of center point in mm : " & txtXcordCenterPoint.Text)
                            lsbResultDotCord.Items.Add("Y position of center point in mm : " & txtYcordCenterPoint.Text)
                            If cmbSkipPlacement.Text <> "" Then
                                lsbResultDotCord.Items.Add("Placement to be skipped : Yes  number " & cmbSkipPlacement.Text)
                            Else
                                lsbResultDotCord.Items.Add("Placement to be skipped : No " & cmbSkipPlacement.Text)
                            End If
                            lsbResultDotCord.Items.Add("---------------------------------------------------- ")



                            For j = 0 To numberOfDot - 1
                                If cmbSkipPlacement.Text <> "" Then
                                    If j = (CDbl(cmbSkipPlacement.Text) - 1) And cmbSkipPlacement.Visible = True Then
                                        lsbResultDotCord.Items.Add("# point number " & j + 1 & " SKIPPED")
                                        lsbResultDotCord.Items.Add("---------------------------------------------------- ")
                                        Continue For
                                    Else
                                        lsbResultDotCord.Items.Add("# point number " & j + 1)
                                        targetX = (CDec((diameter / 2) * ((Math.Cos(((anglePerDot * j) + offsetDegree) * (pi / 180)))))) + centerX
                                        targetY = (CDec((diameter / 2) * ((Math.Sin(((anglePerDot * j) + offsetDegree) * (pi / 180)))))) + centerY
                                        lsbResultDotCord.Items.Add("Result X :" & targetX)
                                        lsbResultDotCord.Items.Add("Result Y :" & targetY)
                                        lsbResultDotCord.Items.Add("---------------------------------------------------- ")

                                    End If
                                Else
                                    lsbResultDotCord.Items.Add("# point number " & j + 1)
                                    targetX = (CDec((diameter / 2) * ((Math.Cos(((anglePerDot * j) + offsetDegree) * (pi / 180)))))) + centerX
                                    targetY = (CDec((diameter / 2) * ((Math.Sin(((anglePerDot * j) + offsetDegree) * (pi / 180)))))) + centerY
                                    lsbResultDotCord.Items.Add("Result X :" & targetX)
                                    lsbResultDotCord.Items.Add("Result Y :" & targetY)
                                    lsbResultDotCord.Items.Add("---------------------------------------------------- ")


                                End If


                            Next


                        Else
                            MsgBox("Please enter the coordination for Y")
                        End If
                    Else
                        MsgBox("Please enter the coordination for X")
                    End If
                Else
                    MsgBox("Please Pick the number of the adhesive to be placed")
                End If
            Else
                MsgBox("Please enter the offset angle for the first dot")
            End If

        Else
            MsgBox("Please enter the patern circle diameter")
        End If



    End Sub

    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        Me.Close()
    End Sub

    Private Sub txtCircleDiameter_TextChanged(sender As Object, e As EventArgs) Handles txtCircleDiameter.TextChanged
        lsbResultDotCord.Items.Clear()
    End Sub

    Private Sub txtFirstDotLocation_TextChanged(sender As Object, e As EventArgs) Handles txtFirstDotLocation.TextChanged
        lsbResultDotCord.Items.Clear()
    End Sub

    Private Sub txtXcordCenterPoint_TextChanged(sender As Object, e As EventArgs) Handles txtXcordCenterPoint.TextChanged
        lsbResultDotCord.Items.Clear()
    End Sub

    Private Sub txtYcordCenterPoint_TextChanged(sender As Object, e As EventArgs) Handles txtYcordCenterPoint.TextChanged
        lsbResultDotCord.Items.Clear()
    End Sub








End Class
