Module Module1

    Sub Main()
        Dim x(10), i, total, avg, high, low As Integer
        high = -1000
        low = 1000
        For i = 1 To 10
            x(i) = Console.ReadLine
            total = total + x(i)
            If x(i) > high Then high = x(i)
            If x(i) < low Then low = x(i)
        Next
        avg = total / 10
        Console.WriteLine("Avg= " & avg)
        Console.WriteLine("Highest= " & high)
        Console.WriteLine("Lowest= " & low)
    End Sub

End Module
