Option Explicit On
Option Strict On
Public Class frmTemperatureConverter
    Dim temperatureC As Double
    Dim temperatureF As Double
    'This convert the temperature from Celcius to Fahrenheit when the button is clicked 
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        temperatureC = CDbl(txtTemperature.Text)
        temperatureF = 1.8 * temperatureC + 32
        lblResult.Text = CStr(temperatureF)
    End Sub



    Private Sub btnConvert_MouseHover(sender As Object, e As EventArgs) Handles btnConvert.MouseHover
        btnConvert.Text = "Converting"
    End Sub

    Private Sub btnConvert_MouseLeave(sender As Object, e As EventArgs) Handles btnConvert.MouseLeave
        btnConvert.Text = "Convert"
    End Sub

    Private Sub frmTemperatureConverter_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        MsgBox("Goodbye",, "Have a great day")
    End Sub

    Private Sub txtTemperature_TextChanged(sender As Object, e As EventArgs) Handles txtTemperature.TextChanged
        lblResult.Text = ""
    End Sub
End Class
