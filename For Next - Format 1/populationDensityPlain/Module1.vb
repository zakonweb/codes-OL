Module Module1

    Sub Main()
        Dim count, LA, POP As Integer
        Dim PD, Total, H, L, Avg As Single

        count = 0
        LA = 0
        POP = 0
        PD = 0
        Total = 0
        H = -1000
        L = 1000
        Avg = 0

        For count = 1 To 5
            Console.Write("Enter population of country #" & count & "  :")
            POP = Console.ReadLine

            Console.Write("Enter land area of country #" & count & "  :")
            LA = Console.ReadLine

            PD = POP / LA
            Console.WriteLine("Population density of Country #" & count & " is = " & PD)

            Total = Total + POP

            If PD > H Then
                H = PD
            End If

            If PD < L Then
                L = PD
            End If
        Next count

        Avg = Total / 5

        Console.WriteLine("Average PD is =" & Avg & " and highest PD is =" & H & " and Lowest PD is =" & L)
        Console.ReadKey()
    End Sub

End Module
