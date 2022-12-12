Imports System.Net.Sockets
Imports System.IO
Module Module1
    Dim client As System.Net.Sockets.TcpClient = New System.Net.Sockets.TcpClient("127.0.0.1", 502)
    Dim NS As NetworkStream = client.GetStream()
    Dim sw As New StreamWriter(NS)

    'Reading function
    Function ReadText(NS As NetworkStream) As String
        Try
            Do
                ReadText = ReadText & Chr(NS.ReadByte)
            Loop While NS.DataAvailable

            Console.WriteLine(ReadText)
        Catch ex As Exception
            Console.WriteLine(ex)
        End Try
    End Function


    Sub Main()
        sw.AutoFlush = True
        Console.WriteLine("Made connection, hit enter to continue")
        Console.ReadLine()

        'Taking the Target Coil 
        Console.WriteLine("Please Enter your Target Coil Adress , Must be 4 degits ")
        Dim targetCoilAdress As String = Console.ReadLine()

        'Taking the Target Coil number
        Console.WriteLine("Please Enter your Target Coil number ")
        Dim targetCoilnumber As String = Console.ReadLine()

        Dim targetcoil As String
        targetcoil = CStr((CInt(targetCoilAdress) + CInt(targetCoilnumber)) - 1)
        Dim hexString As String = Nothing
        Try
            hexString = Hex(targetCoil)
            Console.WriteLine(hexString)
            Dim hexArray() As Char = hexString.ToCharArray()

            Console.WriteLine(hexArray(0))
            Console.WriteLine(hexArray(1))
            Console.WriteLine(hexArray(2))
            Console.WriteLine(hexArray(3))


            ' taking the operation 
            Console.WriteLine("Please Select 1 if you want to turn on Target Coil or 0 if you want to turn it off ")
            Dim operation As String = Console.ReadLine()

            Try


                'setting up the reciecing array
                Dim bytePackage_Receive(11) As Byte


                'setting up the comunication array
                Dim bytePackage_Send(11) As Byte
                bytePackage_Send(0) = 0
                bytePackage_Send(1) = 1
                bytePackage_Send(2) = 0
                bytePackage_Send(3) = 0
                bytePackage_Send(4) = 0
                'length field
                bytePackage_Send(5) = 6
                bytePackage_Send(6) = 1
                'function code
                bytePackage_Send(7) = 5
                'Address High byte
                Dim highAddress As String = hexArray(0) & hexArray(1)
                Dim highAddressDec As Integer = Convert.ToInt32(highAddress, 16)
                bytePackage_Send(8) = highAddressDec
                'CDec(hexArray(0) & hexArray(1))
                '&H29 
                Console.WriteLine("The Address high byte is :" & bytePackage_Send(8))
                'Address Low Byte
                Dim lowAddress As String = hexArray(2) & hexArray(3)
                Dim lowAddressDec As Integer = Convert.ToInt32(lowAddress, 16)
                bytePackage_Send(9) = lowAddressDec
                'CDec(hexArray(2) & hexArray(3))
                Console.WriteLine("The Address Low byte is :" & bytePackage_Send(9))
                'output value High byte
                bytePackage_Send(10) = 0
                'output value Low byte
                bytePackage_Send(11) = CInt(operation)


                'writing the array to the client 

                Console.WriteLine("Writing the array to the client")

                Try
                    NS.Write(bytePackage_Send, 0, bytePackage_Send.Length)
                Catch ex As Exception
                    Console.WriteLine(ex)
                End Try

                Console.WriteLine("Writing the array to the client is Done")

                'reading the client response 

                Console.WriteLine("Reading the array of response")

                Try
                    NS.Read(bytePackage_Receive, 0, bytePackage_Receive.Length)
                Catch ex As Exception
                    Console.WriteLine(ex)
                End Try

                Console.WriteLine("Reading the array of response is Done")

                'wrting the response to consol


                Try
                    Dim response As String
                    If bytePackage_Receive(10) = 255 Then
                        Console.WriteLine("The Response is :" & bytePackage_Receive(10))
                        Console.WriteLine("The Coil Turned on successfully")
                    ElseIf bytePackage_Receive(10) = 0 Then
                        Console.WriteLine("The Response is :" & bytePackage_Receive(10))
                        Console.WriteLine("The Coil Turned off successfully")
                    Else
                        Console.WriteLine("ERROR")
                    End If

                Catch ex As Exception
                    Console.WriteLine(ex)
                End Try




                Console.WriteLine("Operation Done ")
                Console.ReadLine()
            Catch ex As Exception
                Console.WriteLine(ex)
            End Try
        Catch ex As Exception
            Console.WriteLine(ex)
        End Try

        Console.ReadLine()
    End Sub

End Module
