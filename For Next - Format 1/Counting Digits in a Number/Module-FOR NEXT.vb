Module Module1

    Sub Main()
        Dim count, num, a, b, c, d, e As Integer
        Dim x, per As Single

        For count = 1 To 5
            num = Console.ReadLine
            x = Math.Log10(num)
            x = Int(x) + 1
            Select Case x
                Case 1 : a = a + 1
                Case 2 : b = b + 1
                Case 3 : c = c + 1
                Case 4 : d = d + 1
                Case Else : e = e + 1
            End Select
        Next
        per = (e / 5) * 100
        Console.WriteLine(a & ", " & b & ", " & c & ", " & d & ", " & per)
        Console.ReadKey()
    End Sub

End Module
