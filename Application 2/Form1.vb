Option Explicit On
Option Strict On
Public Class frmStringParsing
    ' to avoid having the two threads accessing the same control at the same time
    Delegate Sub HMIUpdateDelegate(ByVal text As String)
    Public HMI_Update As HMIUpdateDelegate
    Dim WithEvents m_CellStatus As New TestRobotCell.TestRobotCell
    Dim elapseStartTime As DateTime
    'this is what happen at load 
    'enabling the interval and communication & also getting the start time 
    Private Sub frmStringParsing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        m_CellStatus.Enable = True
        m_CellStatus.Interval = 3000
        lblResultStartTime.Text = DateTime.Now.ToString("HH:mm:ss tt")
        elapseStartTime = DateTime.Now
        elapsedTimer.Enabled = True
        elapsedTimer.Interval = 1000
    End Sub
    'this splitting the info by a , & will target the location we are looking for
    Function splitterByComma(ByVal inputstring As String, ByVal neededInfo As Integer) As String
        Dim word() As String = Split(Trim(inputstring), ",")
        splitterByComma = word(neededInfo)
    End Function
    'this is indicating the status
    Function statusIndicator(ByVal statusCode As String) As String
        Dim code As Integer = CInt(statusCode)
        Select Case code
            Case 0
                statusIndicator = "stopped"
            Case 1
                statusIndicator = "Running"
            Case 2
                statusIndicator = "Paused"
        End Select
        Return statusIndicator
    End Function
    'this is indicating the colour of the status
    Function colorIndicator(ByVal colorCode As String) As Color
        Dim code As Integer = CInt(colorCode)
        Select Case code
            Case 0
                colorIndicator = Color.Red
            Case 1
                colorIndicator = Color.LightGreen
            Case 2
                colorIndicator = Color.Yellow
        End Select
        Return colorIndicator
    End Function
    'getting the current time and elapsed time
    Private Sub elapsedTimer_Tick(sender As Object, e As EventArgs) Handles elapsedTimer.Tick
        lblResultCurrentTime.Text = DateTime.Now.ToString("HH:mm:ss tt")
        Dim elapsedtime = DateTime.Now.Subtract(elapseStartTime)
        lblResultElapsedTime.Text = String.Format("{0}hour : {1}min : {2}sec", elapsedtime.Hours, elapsedtime.Minutes, elapsedtime.Seconds)
    End Sub
    'The next lines of code create a subroutine that handles the event that occurs when the dll sends the robot cell data.
    Private Sub m_CellStatus_Update(ByVal sCellUpdate As String) Handles m_CellStatus.Update
        'The data from the robot is in sCellUpdate.
        Try
            If lblResultStationName.InvokeRequired Then
                Dim HMI_Update As New HMIUpdateDelegate(AddressOf m_CellStatus_Update)
                Invoke(HMI_Update, New Object() {sCellUpdate})
            Else
                Try
                    'getting the number of good / bad and total parts 
                    lblResultStationName.Text = splitterByComma(sCellUpdate, 0)
                    lblResultGoodParts.Text = Trim(splitterByComma(sCellUpdate, 3))
                    lblResultTotalParts.Text = Trim(splitterByComma(sCellUpdate, 2))
                    lblResultBadParts.Text = CStr(CInt(splitterByComma(sCellUpdate, 2)) - CInt(splitterByComma(sCellUpdate, 3)))
                    'splitting the cell status code to get the status
                    Dim cellStatusCode As String = splitterByComma(sCellUpdate, 4)
                    'cleaning out leading / trailling white spaces and converting the code to array 
                    cellStatusCode = Replace(cellStatusCode, " ", "")
                    Dim numberOfNumbers() As Char = cellStatusCode.ToCharArray()
                    'using the finction to decode the status code and get the status for each machine  and type out the results 
                    lblResultInFeedStatus.Text = String.Format("The In Feed is {0}", statusIndicator(numberOfNumbers(0)))
                    lblResultInFeedStatus.BackColor = colorIndicator(numberOfNumbers(0))
                    lblResultRobotStatus.Text = String.Format("The Robot  is {0}", statusIndicator(numberOfNumbers(1)))
                    lblResultRobotStatus.BackColor = colorIndicator(numberOfNumbers(1))
                    lblResultTesterStatus.Text = String.Format("The Tester is {0}", statusIndicator(numberOfNumbers(2)))
                    lblResultTesterStatus.BackColor = colorIndicator(numberOfNumbers(2))
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        Catch ex As Exception
            'handle any errors here.
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    'closing the form in here
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        MsgBox("Have a Good Day")
        Me.Close()
    End Sub
End Class
