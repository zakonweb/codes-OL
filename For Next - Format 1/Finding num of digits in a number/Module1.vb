Module Module1

    Sub Main()
        Dim x, num, count, a, b, c, d, e As Integer
        Dim per As Single

        For count = 1 To 10
            num = Console.ReadLine
            x = Int(Math.Log10(num)) + 1
            Console.WriteLine(x)
            Select Case x
                Case 1 : a = a + 1
                Case 2 : b = b + 1
                Case 3 : c = c + 1
                Case 4 : d = d + 1
                Case Else : e = e + 1
            End Select
        Next
        per = (e / 10) * 100
        Console.WriteLine(a)
        Console.WriteLine(b)
        Console.WriteLine(c)
        Console.WriteLine(d)
        Console.WriteLine(per)

        Console.ReadKey()
    End Sub

End Module
