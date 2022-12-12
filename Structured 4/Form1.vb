Option Explicit On
Option Strict On
Imports System.Text.RegularExpressions
Public Class frmStringManipulation
    'this part convert the input to uppercase
    Function upCase(ByVal inputString As String) As String
        upCase = UCase(inputString)
    End Function
    'this part reverse the entire string 
    Function reverse(ByVal inputString As String) As String
        reverse = StrReverse(inputString)
    End Function

    'this is to check the number of words 
    Function wordNumber(ByVal inputString As String) As Integer
        Dim numberofWords As MatchCollection = Regex.Matches(inputString, "\S+")
        Return numberofWords.Count
        ' wordNumber = UBound(Split(Trim(Replace(inputString, Space(2), Space(1))))) + 1 ---> this logic is not giving results on ( , or other signs  )so  it's fail we could fix , by replace it with "" which is nothing  to issue a temprary fix but other signs still work
        'this is another outside source that seem to work fine -->  
    End Function
    'this is to check for student number only by splitting using (,)
    Function splitter(ByVal inputstring As String, ByVal neededInfo As Integer) As String
        Dim word() As String = Split(Trim(inputstring), ",")
        splitter = word(neededInfo)
    End Function
    ' this is to get the age of the user 
    Function ageCalculator(ByVal inputstring As String) As Integer
        Dim currentYear As Integer = System.DateTime.Now.Year
        ageCalculator = currentYear - CInt(splitter(inputstring, 4))
    End Function
    'this is to swap first and last name 
    Function nameSwap(ByVal inputstring As String) As String
        Dim word() As String = Split(Trim(splitter(inputstring, 0)), " ")
        nameSwap = String.Format("{1} {0}", word(0), word(1))
    End Function
    'this is to calculate all the nemrical values 
    Function numericalCalculator(ByVal inputstring As String) As Integer
        inputstring = inputstring.Replace(" ", "")
        For counter As Integer = 0 To inputstring.Length - 1
            numericalCalculator += CInt(inputstring.Substring(counter, 1))
        Next counter
    End Function


    'this is where total numeric value button get clicked 
    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        lblResult.Text = String.Format("the  total of all degits in the string is  {0} ", numericalCalculator(splitter(txtUserInfo.Text, 1)) + numericalCalculator(splitter(txtUserInfo.Text, 4)))
    End Sub
    'this is when swap button get clicked ( swapping first and last name positions)
    Private Sub btnSwap_Click(sender As Object, e As EventArgs) Handles btnSwap.Click
        lblResult.Text = String.Format("{4}, {0}, {1}, {2}, {3} ", splitter(txtUserInfo.Text, 1), splitter(txtUserInfo.Text, 2), splitter(txtUserInfo.Text, 3), splitter(txtUserInfo.Text, 4), nameSwap(txtUserInfo.Text))
    End Sub

    'this is when age button get clicked
    Private Sub btnAge_Click(sender As Object, e As EventArgs) Handles btnAge.Click
        lblResult.Text = String.Format("you are {0} years old ", ageCalculator(txtUserInfo.Text))
    End Sub

    'this is where student number button get clicked
    Private Sub btnStudentNumber_Click(sender As Object, e As EventArgs) Handles btnStudentNumber.Click
        lblResult.Text = String.Format("your student number is {0}", splitter(txtUserInfo.Text, 1))
    End Sub

    'this is where number of words button get clicked 
    Private Sub btnWordNumber_Click(sender As Object, e As EventArgs) Handles btnWordNumber.Click
        lblResult.Text = String.Format("There are {0} words", wordNumber(txtUserInfo.Text))
    End Sub

    'this is where reverse button get clicked 
    Private Sub btnReverse_Click(sender As Object, e As EventArgs) Handles btnReverse.Click

        lblResult.Text = String.Format("{0}", StrReverse(txtUserInfo.Text))

    End Sub

    'this is where upperCase button get clicked
    Private Sub btnConvertUpper_Click(sender As Object, e As EventArgs) Handles btnConvertUpper.Click

        lblResult.Text = String.Format("{0}", upCase(txtUserInfo.Text))

    End Sub

    'this close the program 
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub


End Class
