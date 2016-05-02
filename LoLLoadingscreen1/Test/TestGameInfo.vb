Imports ChampionLib
Public Class TestGameInfo

    Public Sub test()
        Dim m As New StopWatch
        m.startWatch()
        Try
            Console.WriteLine("Looking for Game.")
            Dim g As New Game()
            g.findGame(19267665, My.Computer.FileSystem.ReadAllText("E:\Tools\RiotApi.key"))

            Console.WriteLine("Game found.")
            Console.WriteLine("")
            Console.WriteLine("Banned Champions [BLUE SIDE]:")
            For Each b As BannedChampion In g.BANNED_BLUE
                Console.WriteLine(b.ChampionData.Name & " - " & b.ChampionData.Title)
            Next
            Console.WriteLine("")
            Console.WriteLine("Spieler [BLUE SIDE]:")
            For Each b As Champion In g.TEAM_BLUE
                Console.WriteLine(b.ChampionData.Name & " - " & b.ChampionData.Title & " [" & b.PlayerName & "]")
            Next
            Console.WriteLine("")
            Console.WriteLine("Banned Champions [RED SIDE]:")
            For Each b As BannedChampion In g.BANNED_RED
                Console.WriteLine(b.ChampionData.Name & " - " & b.ChampionData.Title)
            Next
            Console.WriteLine("")
            Console.WriteLine("Spieler [RED SIDE]:")
            For Each b As Champion In g.TEAM_RED
                Console.WriteLine(b.ChampionData.Name & " - " & b.ChampionData.Title & " [" & b.PlayerName & "]")
            Next

        Catch ex As Exception
            Console.WriteLine("No active Game found")
        End Try
        m.stopWatch()
        Console.WriteLine("Time: " & m.toString & " Seconds")
    End Sub


End Class
