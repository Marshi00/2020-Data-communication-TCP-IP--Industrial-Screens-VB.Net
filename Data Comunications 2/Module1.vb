Imports System.IO.Ports
Module Module1
    Dim recString As String
    Sub Main()

        Dim mySerialPort As New SerialPort("COM3")
        mySerialPort.BaudRate = 9600
        mySerialPort.Parity = Parity.None
        mySerialPort.StopBits = StopBits.One
        mySerialPort.DataBits = 8
        mySerialPort.Handshake = Handshake.None
        mySerialPort.RtsEnable = True
        Try
            mySerialPort.Open()
        Catch ex As Exception
            Console.WriteLine(ex)
        End Try


        AddHandler mySerialPort.DataReceived, AddressOf DataReceivedHandler
        Console.WriteLine("type q to Quit")
        Dim message As String = Console.ReadLine()
        Do While message <> "q"
            'Console.WriteLine("You have not yet typed q")

            'writing to Ardu

            Dim bytePackage(1 + message.Length) As Byte
            bytePackage(1 + message.Length) = 10
            For i As Integer = 0 To message.Length - 1
                bytePackage(i) = Convert.ToByte(message(i))
            Next
            mySerialPort.Write(bytePackage, 0, bytePackage.Length)

            'read From Ardu 1 


            ' Console.WriteLine("Press any key to continue...")
            ' Console.WriteLine()
            'Console.ReadKey()

            'read From Ardu 2 





            message = Console.ReadLine()

        Loop


        mySerialPort.Close()
    End Sub

    Sub DataReceivedHandler(sender As Object, e As SerialDataReceivedEventArgs)
        Dim sp As SerialPort = CType(sender, SerialPort)
        ' Dim indata As String = sp.ReadExisting()
        'Console.WriteLine("Data Received:")
        'Console.WriteLine(indata)



        Do While sp.BytesToRead > 0

            Dim readByte As Byte = sp.ReadByte()


            If (readByte = 13) Then

                Console.WriteLine("Data concatonated is: " & recString)
                readByte = sp.ReadByte() 'read the 10
                recString = ""
            Else
                recString = recString & Chr(readByte)

            End If

        Loop
    End Sub


    'Read one Byte at a time

    ' Do While sp.BytesToRead > 0
    ' Dim readByte As Byte = sp.ReadByte()


    ' Loop

    'Monitor for a CR character

    '  If (readByte = 13) Then


    '   Else


    '   End If

    'Print after the CR character Is received
    '	Read the LF (Decimal 10) character which occurs after the CR character
    '	Clear the response String

    '              Console.WriteLine("Data concatonated is: " & recString)
    '              readByte = sp.ReadByte() 'read the 10
    '               recString = ""

    'Concatenate characters : 
    '			recString = recString & Chr(readByte)



End Module
