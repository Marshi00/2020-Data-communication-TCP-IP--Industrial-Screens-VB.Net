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



        Console.WriteLine("Select the type of operation you need , 1-Reading coils or 2 - writing coils ")
        Dim operation As String = Console.ReadLine()

        If CInt(operation) = 1 Then

            'Taking the Target Coil Adress
            Console.WriteLine("Please Enter your Target Coil Adress in HEX, Must be 4 degits")
            Dim targetCoilAdress As String = Console.ReadLine()

            'Taking the Target Coil number
            ' Console.WriteLine("Please Enter your Target Coil number ")
            ' Dim targetCoilnumber As String = Console.ReadLine()

            Dim targetcoil As String = targetCoilAdress
            'targetcoil = CStr((CInt(targetCoilAdress) + CInt(targetCoilnumber)) - 1)

            Try

                Dim targetcoil_HighByte As String = targetcoil.Substring(0, 2)
                Dim targetcoil_LowByte As String = targetcoil.Substring(2, 2)
                'Console.WriteLine(targetcoil)
                'Console.WriteLine(targetcoil_HighByte)
                'Console.WriteLine(targetcoil_LowByte)

                'converting high and low byte to Dec
                Dim targetcoil_HighByte_Dec As Byte = Convert.ToByte(targetcoil_HighByte, 16)
                Dim targetcoil_LowByte_Dec As Byte = Convert.ToByte(targetcoil_LowByte, 16)
                'Console.WriteLine(targetcoil_HighByte_Dec)
                'Console.WriteLine(targetcoil_LowByte_Dec)


                ' taking the operation 
                Console.WriteLine("Please Enter the number of coils that you want to read")
                Dim countOfCoils As String = Console.ReadLine()

                Try





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
                    bytePackage_Send(7) = 1
                    'Address High byte
                    bytePackage_Send(8) = targetcoil_HighByte_Dec

                    Console.WriteLine("The Address high byte is :" & bytePackage_Send(8))
                    'Address Low Byte
                    bytePackage_Send(9) = targetcoil_LowByte_Dec

                    Console.WriteLine("The Address Low byte is :" & bytePackage_Send(9))

                    'output value High byte
                    bytePackage_Send(10) = 0
                    'output value Low byte
                    bytePackage_Send(11) = CInt(countOfCoils)


                    'writing the array to the client 

                    Console.WriteLine("Writing the array to the client")

                    Try
                        NS.Write(bytePackage_Send, 0, bytePackage_Send.Length)
                    Catch ex As Exception
                        Console.WriteLine(ex)
                    End Try

                    Console.WriteLine("Writing the array to the client is Done")


                    'setting up the reciecing array
                    Dim response_Size As Integer
                    response_Size = CInt(countOfCoils) + 8
                    Dim bytePackage_Receive(response_Size) As Byte


                    'reading the client response 

                    Console.WriteLine("Reading the array of response")

                    Try
                        NS.Read(bytePackage_Receive, 0, bytePackage_Receive.Length)
                    Catch ex As Exception
                        Console.WriteLine(ex)
                    End Try

                    Console.WriteLine("Reading the array of response is Done")

                    'wrting the response to consol


                    Dim result As Integer
                    If countOfCoils > 8 Then
                        result = 1
                    Else
                        result = 0
                    End If

                    For i As Integer = 0 To result
                        Console.WriteLine("The Response is :" & bytePackage_Receive(i + 9))
                    Next
                    Dim sBinaryData As String = Convert.ToString(bytePackage_Receive(9), 2)
                    Dim sBinaryData2 As String = Convert.ToString(bytePackage_Receive(10), 2)


                    If countOfCoils > 8 Then
                        Console.WriteLine("binary 1 is :" & sBinaryData)
                        Console.WriteLine("binary 2 is :" & sBinaryData2)
                        Console.WriteLine("coil1 condition in order is " & StrReverse(sBinaryData) & StrReverse(sBinaryData2))

                    Else
                        Console.WriteLine("binary 1 is :" & sBinaryData)
                        Console.WriteLine("coil1 condition in order is " & StrReverse(sBinaryData))
                    End If



                    Console.WriteLine("Operation Done ")
                    Console.ReadLine()
                Catch ex As Exception
                    Console.WriteLine(ex)
                End Try
            Catch ex As Exception
                Console.WriteLine(ex)
            End Try

            Console.ReadLine()


            'Writing operation 

        ElseIf CInt(operation) = 2 Then




            'Taking the Target Coil Adress
            Console.WriteLine("Please Enter your Target Coil Adress in HEX, Must be 4 degits")
            Dim targetCoilAdress As String = Console.ReadLine()

            'Taking the Target Coil number
            ' Console.WriteLine("Please Enter your Target Coil number ")
            ' Dim targetCoilnumber As String = Console.ReadLine()

            Dim targetcoil As String = targetCoilAdress
            'targetcoil = CStr((CInt(targetCoilAdress) + CInt(targetCoilnumber)) - 1)

            Try

                Dim targetcoil_HighByte As String = targetcoil.Substring(0, 2)
                Dim targetcoil_LowByte As String = targetcoil.Substring(2, 2)
                'Console.WriteLine(targetcoil)
                'Console.WriteLine(targetcoil_HighByte)
                'Console.WriteLine(targetcoil_LowByte)

                'converting high and low byte to Dec
                Dim targetcoil_HighByte_Dec As Byte = Convert.ToByte(targetcoil_HighByte, 16)
                Dim targetcoil_LowByte_Dec As Byte = Convert.ToByte(targetcoil_LowByte, 16)
                'Console.WriteLine(targetcoil_HighByte_Dec)
                'Console.WriteLine(targetcoil_LowByte_Dec)


                ' taking the operation 
                Console.WriteLine("Please Enter the binary state of the coils you want to chage")
                Dim binaryState As String = Console.ReadLine()

                'reverseing it 
                Dim revBinaryState As String = StrReverse(binaryState)

                'converting to byte
                Dim bBits As Byte = Convert.ToByte(revBinaryState, 2)
                'length of bits to get quantity
                Dim bitLength As Byte = revBinaryState.Length
                Console.WriteLine("length is " & bitLength)
                'byte counts 
                Dim byteCount As Integer = 1
                ' If CDbl(bitLength) Mod 8 = 0 Then
                '  byteCount = CInt(bitLength) / 8
                ' Else
                ' Dim tragetRound As Double = CDbl(bitLength) Mod 8
                '   Dim theRounded = Math.Sign(CDbl(tragetRound)) * Math.Floor(Math.Abs(CDbl(tragetRound)) * 100) / 100.0
                '     Console.WriteLine("weqeqeqwe :::" & theRounded)
                ' byteCount = theRounded + 1
                'End If



                Try





                    'setting up the comunication array
                    Dim bytePackage_Send(14) As Byte
                    bytePackage_Send(0) = 0
                    bytePackage_Send(1) = 1
                    bytePackage_Send(2) = 0
                    bytePackage_Send(3) = 0
                    bytePackage_Send(4) = 0
                    'length field
                    bytePackage_Send(5) = 8
                    bytePackage_Send(6) = 1
                    'function code
                    bytePackage_Send(7) = 15
                    'Address High byte
                    bytePackage_Send(8) = targetcoil_HighByte_Dec

                    Console.WriteLine("The Address high byte is :" & bytePackage_Send(8))
                    'Address Low Byte
                    bytePackage_Send(9) = targetcoil_LowByte_Dec

                    Console.WriteLine("The Address Low byte is :" & bytePackage_Send(9))

                    'Quantitay of outputs high bit
                    bytePackage_Send(10) = 0
                    'Quantitay of outputs Low bit
                    bytePackage_Send(11) = CInt(bitLength)

                    'byte count 

                    bytePackage_Send(12) = CInt(byteCount)


                    'output value High byte
                    bytePackage_Send(13) = bBits




                    'writing the array to the client 

                    Console.WriteLine("Writing the array to the client")

                    Try
                        NS.Write(bytePackage_Send, 0, bytePackage_Send.Length)
                    Catch ex As Exception
                        Console.WriteLine(ex)
                    End Try

                    Console.WriteLine("Writing the array to the client is Done")


                    'setting up the reciecing array

                    Dim bytePackage_Receive(11) As Byte


                    'reading the client response 

                    Console.WriteLine("Reading the array of response")

                    Try
                        NS.Read(bytePackage_Receive, 0, bytePackage_Receive.Length)
                    Catch ex As Exception
                        Console.WriteLine(ex)
                    End Try

                    Console.WriteLine("Reading the array of response is Done")

                    'wrting the response to consol


                    'wrting the response to consol

                    Console.WriteLine("Starting Address Hi byte  is " & bytePackage_Receive(8))
                    Console.WriteLine("Starting Address Low byte  is" & bytePackage_Receive(9))
                    Console.WriteLine("Quantity of Outputs Hi byte is " & bytePackage_Receive(10))
                    Console.WriteLine("Quantity of Outputs Low byte is" & bytePackage_Receive(11))



                    Console.WriteLine("Operation Done ")
                    Console.ReadLine()
                Catch ex As Exception
                    Console.WriteLine(ex)
                End Try
            Catch ex As Exception
                Console.WriteLine(ex)
            End Try

            Console.ReadLine()

        Else
            Console.WriteLine("wrong request")
        End If

    End Sub

End Module
