Module Module1

    Sub Main()
        Dim count, pop(5), la(5) As Integer
        Dim avg, H, L, pd(5), tot As Single

        For count = 1 To 5
            pop(count) = 0
            la(count) = 0
            pd(count) = 0
        Next

        H = -1000
        L = 1000

        'TASK1
        For count = 1 To 5
            pop(count) = Console.ReadLine()
            la(count) = Console.ReadLine
        Next

        'TASK2
        For count = 1 To 5
            pd(count) = pop(count) / la(count)
            Console.WriteLine(pd(count))

            tot = tot + pd(count)
        Next

        For count = 1 To 5
            If pd(count) > H Then
                H = pd(count)
            End If

            If pd(count) < L Then
                L = pd(count)
            End If
        Next
        avg = tot / 5
        Console.WriteLine(avg & "  " & H & "  " & L)
        Console.ReadKey()
    End Sub

End Module
