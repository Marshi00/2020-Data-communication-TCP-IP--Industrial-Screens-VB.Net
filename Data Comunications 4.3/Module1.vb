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



        Console.WriteLine("Select the type of operation you need , 1-Reading Holding Registers or 2 - writing Holding Registers ")
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
                Dim targetcoil_HighByte_Dec As Integer = Convert.ToInt32(targetcoil_HighByte, 16)
                Dim targetcoil_LowByte_Dec As Integer = Convert.ToInt32(targetcoil_LowByte, 16)
                'Console.WriteLine(targetcoil_HighByte_Dec)
                'Console.WriteLine(targetcoil_LowByte_Dec)


                ' taking the operation 
                Console.WriteLine("Please Enter the number of Holding Registers that you want to read in 4 degits")
                Dim countOfRegisters As String = Console.ReadLine()
                Dim countOfRegisters_highValue As Integer = Convert.ToInt32(countOfRegisters.Substring(0, 2), 16)
                Dim countOfRegisters_LowValue As Integer = Convert.ToInt32(countOfRegisters.Substring(2, 2), 16)
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
                    bytePackage_Send(7) = 3
                    'Address High byte
                    bytePackage_Send(8) = targetcoil_HighByte_Dec

                    Console.WriteLine("The Address high byte is :" & bytePackage_Send(8))
                    'Address Low Byte
                    bytePackage_Send(9) = targetcoil_LowByte_Dec

                    Console.WriteLine("The Address Low byte is :" & bytePackage_Send(9))

                    'output value High byte
                    bytePackage_Send(10) = countOfRegisters_highValue
                    'output value Low byte
                    bytePackage_Send(11) = countOfRegisters_LowValue


                    'writing the array to the client 

                    Console.WriteLine("Writing the array to the client")

                    Try
                        NS.Write(bytePackage_Send, 0, bytePackage_Send.Length)
                    Catch ex As Exception
                        Console.WriteLine(ex)
                    End Try

                    Console.WriteLine("Writing the array to the client is Done")


                    'setting up the reciecing array
                    Dim response_Size As Integer = countOfRegisters_highValue * 256 + countOfRegisters_LowValue
                    Dim bytePackage_Receive(9 + 2 * response_Size) As Byte


                    'reading the client response 

                    Console.WriteLine("Reading the array of response")

                    Try
                        NS.Read(bytePackage_Receive, 0, bytePackage_Receive.Length)
                    Catch ex As Exception
                        Console.WriteLine(ex)
                    End Try

                    Console.WriteLine("Reading the array of response is Done")

                    'wrting the response to consol



                    Console.WriteLine("Byte count is " & bytePackage_Receive(8))

                    For j As Integer = 1 To 2 * response_Size Step 2
                        Console.WriteLine("Register value is " & Convert.ToString(bytePackage_Receive(8 + j), 16) & Convert.ToString(bytePackage_Receive(9 + j), 16))
                    Next

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
            Console.WriteLine("Please Enter your Target register Adress in HEX, Must be 4 degits")
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
                Dim targetcoil_HighByte_Dec As Integer = Convert.ToInt32(targetcoil_HighByte, 16)
                Dim targetcoil_LowByte_Dec As Integer = Convert.ToInt32(targetcoil_LowByte, 16)
                'Console.WriteLine(targetcoil_HighByte_Dec)
                'Console.WriteLine(targetcoil_LowByte_Dec)


                ' taking the operation 
                Console.WriteLine("Please Enter the number of Holding Registers that you want to write in 4 degits")
                Dim countOfRegisters As String = Console.ReadLine()
                Dim countOfRegisters_highValue As Integer = Convert.ToInt32(countOfRegisters.Substring(0, 2), 16)
                Dim countOfRegisters_LowValue As Integer = Convert.ToInt32(countOfRegisters.Substring(2, 2), 16)


                ' taking the operation 

                'length of bits to get quantity
                Dim QuantityReg As Integer = CInt(countOfRegisters)
                Console.WriteLine("length is " & QuantityReg)
                'byte counts 
                Dim Send_Size As Integer = countOfRegisters_highValue * 256 + countOfRegisters_LowValue
                Dim byteCount As Integer = QuantityReg * 2



                Try





                    'setting up the comunication array
                    Dim bytePackage_Send(12 + Send_Size * 2) As Byte
                    bytePackage_Send(0) = 0
                    bytePackage_Send(1) = 1
                    bytePackage_Send(2) = 0
                    bytePackage_Send(3) = 0
                    bytePackage_Send(4) = 0
                    'length field
                    bytePackage_Send(5) = 8
                    bytePackage_Send(6) = 1
                    'function code
                    bytePackage_Send(7) = 16
                    'Address High byte
                    bytePackage_Send(8) = targetcoil_HighByte_Dec

                    Console.WriteLine("The Address high byte is :" & bytePackage_Send(8))
                    'Address Low Byte
                    bytePackage_Send(9) = targetcoil_LowByte_Dec

                    Console.WriteLine("The Address Low byte is :" & bytePackage_Send(9))

                    'Quantitay of outputs high bit
                    bytePackage_Send(10) = countOfRegisters_highValue
                    'Quantitay of outputs Low bit
                    bytePackage_Send(11) = countOfRegisters_LowValue

                    'byte count 

                    bytePackage_Send(12) = CInt(byteCount)


                    'output value High byte
                    'Console.WriteLine("Please Enter the  state of the Registers you want to change")
                    ' Dim binaryState As String = Console.ReadLine()

                    'reverseing it 
                    'Dim revBinaryState As String = StrReverse(binaryState)

                    'converting to byte
                    'Dim bBits As Byte = Convert.ToByte(revBinaryState, 2)
                    For k As Integer = 1 To (QuantityReg * 2) Step 2
                        Console.WriteLine("Please Enter the value of " & CStr(k) & " and " & CStr(k + 1) & "  bytes for Holding Registers that you want to write ")
                        Dim response As String = Console.ReadLine()
                        Dim response_highValue As Integer = Convert.ToInt32(response.Substring(0, 2), 16)
                        Dim response_LowValue As Integer = Convert.ToInt32(response.Substring(2, 2), 16)
                        bytePackage_Send(12 + k) = response_highValue
                        bytePackage_Send(13 + k) = response_LowValue
                    Next




                    'writing the array to the client 

                    Console.WriteLine("Writing the array to the client")

                    Try
                        NS.Write(bytePackage_Send, 0, bytePackage_Send.Length)
                    Catch ex As Exception
                        Console.WriteLine(ex)
                    End Try

                    Console.WriteLine("Writing the array to the client is Done")


                    'setting up the reciecing array

                    Dim bytePackage_writeResponse(11) As Byte


                    'reading the client response 

                    Console.WriteLine("Reading the array of response")

                    Try
                        NS.Read(bytePackage_writeResponse, 0, bytePackage_writeResponse.Length)
                    Catch ex As Exception
                        Console.WriteLine(ex)
                    End Try

                    Console.WriteLine("Reading the array of response is Done")

                    'wrting the response to consol


                    'wrting the response to consol

                    Console.WriteLine("Starting Address Hi byte  is " & bytePackage_writeResponse(8))
                    Console.WriteLine("Starting Address Low byte  is" & bytePackage_writeResponse(9))
                    Console.WriteLine("Quantity of Outputs Hi byte is " & bytePackage_writeResponse(10))
                    Console.WriteLine("Quantity of Outputs Low byte is" & bytePackage_writeResponse(11))



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
