Module Module1

    Sub Main()
        Dim count, a, b, low, temp As Integer
        count = 0
        a = 0
        b = 0
        low = 1000
        temp = 0

        For count = 1 To 5
            'input temp 
            temp = Console.ReadLine
            If temp > 20 Then a = a + 1
            If temp < 10 Then b = b + 1
            If temp < low Then low = temp

        Next
        Console.WriteLine(">20 = " & a)
        Console.WriteLine("<10 = " & b)
        Console.WriteLine("Lowest = " & low)

    End Sub

End Module
