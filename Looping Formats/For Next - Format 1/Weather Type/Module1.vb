Module Module1

    Sub Main()
        Dim WT As String
        Dim count, Temp, c, r, s, f, Highest, lowest As Integer

        count = 0
        Temp = 0
        c = 0
        r = 0
        s = 0
        f = 0
        Highest = -1000
        lowest = 1000

        WT = ""

        For count = 1 To 5
            WT = Console.ReadLine
            Temp = Console.ReadLine

            If WT = "CLOUDY" Then c = c + 1
            If WT = "RAINING" Then r = r + 1
            If WT = "SUNNY" Then s = s + 1
            If WT = "FOGGY" Then f = f + 1

            If Temp > Highest Then Highest = Temp
            If Temp < lowest Then lowest = Temp
        Next count
        Console.WriteLine(c)
        Console.WriteLine(r)
        Console.WriteLine(s)
        Console.WriteLine(f)
        Console.WriteLine(Highest)
        Console.WriteLine(lowest)
        Console.ReadKey()
    End Sub

End Module
