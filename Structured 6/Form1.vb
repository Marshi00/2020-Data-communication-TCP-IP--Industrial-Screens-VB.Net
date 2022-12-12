Option Explicit On
Option Strict On
Public Class frmExam
    Dim partNumber As Integer
    Dim j As String

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If cmbNumberParts.Text <> "" Then
            partNumber = CInt(cmbNumberParts.Text)
        End If

        If txtPartName.Text <> "" Then

            If txtDescription.Text <> "" Then

                If partNumber <> 0 Then
                    lsbResult.Items.Add("Part Name :" & txtPartName.Text)
                    lsbResult.Items.Add("Part Description :" & txtDescription.Text)
                    lsbResult.Items.Add("Number Of Parts :" & partNumber)
                    lsbResult.Items.Add("---------------------------------------- ")

                Else
                    MsgBox("Please select the number of parts ")
                End If

            Else
                MsgBox("PLease enter a description")

            End If

        Else
            MsgBox("Please enter part name")

        End If



    End Sub

    Private Sub frmExam_Load(sender As Object, e As EventArgs) Handles Me.Load
        For i As Integer = 1 To 20
            cmbNumberParts.Items.Add(i)
        Next
    End Sub

    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        Me.Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        For n As Integer = 0 To lsbResult.SelectedItems.Count - 1

            lsbResult.Items.RemoveAt(lsbResult.SelectedIndex)

        Next







    End Sub
End Class

