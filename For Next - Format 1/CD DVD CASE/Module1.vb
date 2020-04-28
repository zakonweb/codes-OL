Module Module1

    Sub Main()
        Dim Count, Code, C, D, V, B, x As Integer
        For Count = 1 To 5
            Code = Console.ReadLine
            x = Int(Code / 10000)
            Select Case x
                Case 1 : C = C + 1
                Case 2 : D = D + 1
                Case 3 : V = V + 1
                Case 4 : B = B + 1
            End Select
        Next
        Console.WriteLine("CD = " & C)
        Console.WriteLine("DVD = " & D)
        Console.WriteLine("Videos = " & V)
        Console.WriteLine("Books = " & B)

        Console.ReadKey()

    End Sub

End Module
