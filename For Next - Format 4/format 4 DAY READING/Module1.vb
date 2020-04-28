Module Module1

    Sub Main()
        Dim DAY, READING, TEMP, T1, T2, H, L As Integer
        Dim AVG1, AVG2 As Single

        For DAY = 1 To 5
            AVG1 = 0
            T1 = 0
            For READING = 1 To 4
                TEMP = Console.ReadLine

                T1 = T1 + TEMP

                If TEMP > H Then H = TEMP
                If TEMP < L Then L = TEMP
            Next
            AVG1 = T1 / 4
            T2 = T2 + T1
            Console.WriteLine(AVG1)
        Next
        AVG2 = T2 / 20
        Console.WriteLine(AVG2 & " " & H & " " & L)
        Console.ReadKey()
    End Sub

End Module
