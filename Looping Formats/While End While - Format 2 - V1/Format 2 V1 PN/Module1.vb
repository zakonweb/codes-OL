Module Module1

    Sub Main()
        Dim PN, Largest, Total, Count As Integer
        Dim AVG As Single

        PN = 0
        Largest = -1000
        Total = 0
        Count = 0
        AVG = 0

        Do
            PN = Console.ReadLine()
            Total = Total + PN
            Count = Count + 1

            If PN > Largest Then
                Largest = PN
            End If

        Loop Until (PN = -1)
        AVG = Total / Count
        Console.WriteLine(AVG)
        Console.WriteLine(Largest)
        Console.ReadKey()
    End Sub

End Module
