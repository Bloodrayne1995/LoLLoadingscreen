
Module Module1

    Sub Main()
        'Get RiotKey
        Console.WriteLine("Read RiotAPI-KeyFile")
        Dim key As String = My.Computer.FileSystem.ReadAllText("E:\Tools\RiotApi.key")
        Console.Write("Riot-API-Key is: ")
        For i As Integer = 0 To 5
            Console.Write(key(i))
        Next
        Console.WriteLine()


        'define Path of XML file
        Dim pfad As String = "E:\Tools\Champions.xml"
        Console.WriteLine("Path of XML-File: " & pfad)

        'start generation
        Console.WriteLine("Start generation")
        Try
            Dim x As New XMLChampionWithSkins2XML
            x.createXMLFile(pfad, key)
            Console.WriteLine("Generation finished succesful")
        Catch ex As Exception
            Console.WriteLine("Generation finished with errors")
            'TODO: Exception handling
            Throw ex
        End Try

        'wait for input before window closes
        Console.ReadLine()
    End Sub

End Module
