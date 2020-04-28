Module Module1

    Sub Main()
        Dim Count, A, B, Temp, Lowest As Integer
        Lowest = 1000

        For Count = 1 To 5
            Temp = Console.ReadLine

            If Temp > 20 Then A = A + 1
            If Temp < 10 Then B = B + 1
            If Temp < Lowest Then Lowest = Temp
        Next
        Console.WriteLine(A)
        Console.WriteLine(B)
        Console.WriteLine(Lowest)

        Console.ReadKey()
    End Sub

End Module
