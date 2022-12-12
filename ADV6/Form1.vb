Option Strict On
Option Explicit On
Public Class frmClass
    'this close the form
    Dim allArray() As String
    Dim i As Integer = 0
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If txtInstanceName.Text <> "" Then
            If txtZipCode.Text <> "" And txtCity.Text <> "" And txtStreet.Text <> "" And txtAge.Text <> "" And txtLast.Text <> "" And txtFirst.Text <> "" Then
                Try
                    Dim instanceName As String = txtInstanceName.Text
                    Dim isMe As New NewPerson 'Creates a NEW instance of new person class.
                    'Sets the properties in isMe
                    isMe.FirstName = txtFirst.Text
                    isMe.LastName = txtLast.Text
                    isMe.Age = CShort(txtAge.Text)
                    isMe.City = txtCity.Text
                    isMe.StreetName = txtStreet.Text
                    isMe.ZipCode = txtZipCode.Text
                    isMe.Speak() 'Calls the sub in Speak() - in the class you'll note that this is OVERRIDABLE
                    isMe.print()
                    lsbResult.Items.Clear()
                    lsbResult.Items.Add("Instance:" & instanceName)
                    lsbResult.Items.Add(" ")
                    lsbResult.Items.Add(" ")
                    lsbResult.Items.Add(String.Format("Name: {0} LastName: {1} Age: {2} City: {3} Street: {4} ZipCode: {5} this instance name is {6} ", isMe.FirstName, isMe.LastName, isMe.Age, isMe.City, isMe.StreetName, isMe.ZipCode, instanceName))
                    ReDim Preserve allArray(i)
                    allArray(i) = String.Format("Name: {0} LastName: {1} Age: {2} City: {3} Street: {4} ZipCode: {5} this instance name is {6}", isMe.FirstName, isMe.LastName, isMe.Age, isMe.City, isMe.StreetName, isMe.ZipCode, instanceName)
                    i += 1
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            Else
                MsgBox("Please fill all the fields ")
            End If
        Else
                MsgBox("Please enter a name for the Instance ")
        End If
    End Sub
    'this checks the age 
    Private Sub txtAge_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAge.KeyPress
        'Error checking values for age
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
            Else e.Handled = True
                MessageBox.Show("Numbers only for age")
            End If
        End If
    End Sub
    'Our Class
    Public MustInherit Class Person
        Protected c_sFirstName As String 'class member to store name
        Protected c_sLastName As String 'class member to store last name
        Protected c_iAge As Int16   'class member to store age
        Protected c_sGender As String 'class member to store gender
        Protected c_sCity As String 'class member to store gender
        Protected c_sZipCode As String 'class member to store gender
        Protected c_sStreetName As String 'class member to store gender
        Public address As String
        Public MustOverride ReadOnly Property ClassName() As String 'We will override this with a get statement.

        ReadOnly Property BaseClassName() As String
            Get
                BaseClassName = "Person" 'this sets the base class name for any class that inherits from it, this allows the 'child' class knows where it came from.
            End Get
        End Property
        Public Property FirstName() As String 'This property is how any object reference to this class will GET or SET the first name.
            Get
                FirstName = c_sFirstName 'This RETURNS the firstname, a return could be used here if you wanted.
            End Get
            Set(ByVal Value As String) 'This takes the string and sets it into the class member
                c_sFirstName = Value
            End Set
        End Property
        Public Property City() As String 'This property is how any object reference to this class will GET or SET the last name.
            Get
                City = c_sCity 'This RETURNS the last name, a return could be used here if you wanted.
            End Get
            Set(ByVal Value As String) 'This takes the string and sets it into the class member
                c_sCity = Value
            End Set
        End Property
        Public Property Age() As Int16 'This property is how any object reference to this class will GET or SET the Age.
            Get
                Age = c_iAge 'This RETURNS the age, a return could be used here if you wanted.
            End Get
            Set(value As Int16) 'This takes the int16 and sets it into the class member
                c_iAge = value
            End Set
        End Property
        Public Property ZipCode() As String 'This property is how any object reference to this class will GET or SET the last name.
            Get
                ZipCode = c_sZipCode 'This RETURNS the last name, a return could be used here if you wanted.
            End Get
            Set(ByVal Value As String) 'This takes the string and sets it into the class member
                c_sZipCode = Value
            End Set
        End Property
        Public Property StreetName() As String 'This property is how any object reference to this class will GET or SET the last name.
            Get
                StreetName = c_sStreetName 'This RETURNS the last name, a return could be used here if you wanted.
            End Get
            Set(ByVal Value As String) 'This takes the string and sets it into the class member
                c_sStreetName = Value
            End Set
        End Property
        Public Property LastName() As String 'This property is how any object reference to this class will GET or SET the last name.
            Get
                LastName = c_sLastName 'This RETURNS the last name, a return could be used here if you wanted.
            End Get
            Set(ByVal Value As String) 'This takes the string and sets it into the class member
                c_sLastName = Value
            End Set
        End Property
        Overridable Sub Speak() ' This subroutine is overridable, meaning any class that inherits from this one can change how this subroutine works.
            MessageBox.Show("My name is " & c_sFirstName & " " & c_sLastName)
            MessageBox.Show("")
        End Sub
        'THIS IS MUST OVER RUDE SUB
        MustOverride Sub PrintAddress()
        Sub print()
            MessageBox.Show(" My Address is as the Following.")
            PrintAddress()
        End Sub
    End Class

    Public Class NewPerson
        Inherits Person
        ' THIS OVER RIDE THE MUST OVER RIDE SUB 
        Overrides Sub PrintAddress()
            MessageBox.Show("Currently i live in " & c_sStreetName & "Street" & " my zip code is : " & c_sZipCode & " and that is in: " & c_sCity & " City.")
        End Sub
        Public Overrides ReadOnly Property ClassName() As String
            Get
                ClassName = "NewPerson"
            End Get
        End Property

        Overrides Sub Speak() ' This is the OVERRIDE of the Speak() sub in the parent class... we're essentially changing what it does. See the difference?
            MessageBox.Show("My name is " & c_sFirstName & " " & c_sLastName & " I am: " & c_iAge & " years old.")
            MessageBox.Show(" and I am a new person.")
        End Sub


    End Class
    'show the history of instances 
    Private Sub btnShowHistory_Click(sender As Object, e As EventArgs) Handles btnShowHistory.Click
        lsbResult.Items.Clear()
        For Each item In allArray
            lsbResult.Items.Add(item)
            lsbResult.Items.Add("")
            lsbResult.Items.Add("-----------------------------------------------------------------------------------------------------------------------")
        Next
    End Sub
End Class
