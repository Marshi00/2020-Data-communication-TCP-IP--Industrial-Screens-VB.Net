Imports System.Net.Sockets
Imports System.IO
Module Module1
    Dim client As System.Net.Sockets.TcpClient = New System.Net.Sockets.TcpClient("ftp.drivehq.com", 21)
    Dim NS As NetworkStream = client.GetStream()
    Dim sw As New StreamWriter(NS)
    'm!47wW8HMJpewTG

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

    'Data Connection Function 
    Function dataStream(sw As StreamWriter, NS As NetworkStream) As NetworkStream
        Try

            sw.WriteLine("PASV")
            Dim strPASV As String = ReadText(NS)
            'Console.Write(strPASV)
            Dim pasvArr() = Split(strPASV, ",")
            Dim strHighByte As String = pasvArr(4)
            Dim strLowByte As String = Split(pasvArr(5), ")")(0)
            Dim DataPort As Integer = strLowByte + 256 * strHighByte
            Dim dataClient As System.Net.Sockets.TcpClient = New System.Net.Sockets.TcpClient("ftp.drivehq.com", DataPort)

            dataStream = dataClient.GetStream()

        Catch ex As Exception
            Console.WriteLine(ex)
        End Try
    End Function

    Sub Main()
        sw.AutoFlush = True
        Console.WriteLine("Made connection, hit enter to continue")
        Console.ReadLine()

        'Reading the first response from the server 

        ReadText(NS)

        'Taking the User Name 
        Console.WriteLine("Please Enter your user Name ")
        Dim userName As String = Console.ReadLine()
        sw.WriteLine("USER " & userName)

        ReadText(NS)

        'Taking the password 

        Console.WriteLine("Please Enter your PassWord ")
        Dim passWord As String = Console.ReadLine()
        sw.WriteLine("PASS " & passWord)

        ReadText(NS)

        'Starting Data connection and getting LIST

        Dim dataNS As NetworkStream = dataStream(sw, NS)
        sw.WriteLine("LIST")
        ReadText(NS)
        ReadText(dataNS)
        ReadText(NS)
        dataNS.Close()



        'Starting Data connection and getting NLST
        dataNS = dataStream(sw, NS)
        sw.WriteLine("NLST")
        ReadText(NS)
        ReadText(dataNS)
        ReadText(NS)
        dataNS.Close()


        'Starting Data coneection ang getting RETR 
        dataNS = dataStream(sw, NS)
        sw.WriteLine("RETR Smile.png")
        ReadText(NS)
        Dim fileStream As FileStream = New FileStream("D:\MySmile.png", FileMode.Create)

        Try

            Do
                Dim retrByte As Byte = dataNS.ReadByte()
                Console.Write(retrByte)
                fileStream.WriteByte(retrByte)
            Loop While dataNS.DataAvailable

        Catch ex As Exception
            Console.WriteLine(ex)
        End Try

        ReadText(NS)
        dataNS.Close()

        'Starting Data Connection and Sending an image
        dataNS = dataStream(sw, NS)
        sw.WriteLine("STOR Frown.png")
        ReadText(NS)
        Dim fsSource As FileStream = New FileStream("D:\Frown.png", FileMode.Open, FileAccess.Read)
        Try

            Do Until fsSource.Length = fsSource.Position
                Dim rByte As Byte = fsSource.ReadByte
                dataNS.WriteByte(rByte)
            Loop
        Catch ex As Exception
            Console.WriteLine(ex)
        End Try

        ReadText(NS)

        dataNS.Close()
        Console.WriteLine("DONE")
        Console.ReadLine()
    End Sub


End Module
