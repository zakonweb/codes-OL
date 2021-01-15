Module Module1

    Sub Main()
        Dim largest, PN, Count, Avg, Total As Integer
        largest = -1000


        PN = Console.ReadLine
        While PN <> -1
            Total = Total + PN

            Count = Count + 1
            If PN > largest Then largest = PN

            PN = Console.ReadLine
        End While

        Avg = Total / Count
        Console.WriteLine(Avg)
        Console.WriteLine(largest)

        Console.ReadKey()
    End Sub

End Module
