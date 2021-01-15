Module Module1

    Sub Main()
        Dim Num, Total, Lar, Count As Integer
        Dim Avg As Single

        Num = 0
        Total = 0
        Lar = -1000
        Avg = 0
        Count = 0

        Do    'REPEAT
            Num = Console.ReadLine()
            Total = Total + Num
            If Num > Lar Then Lar = Num

            Count = Count + 1
        Loop Until Num = -1
        Avg = Total / Count
        Console.WriteLine("Largest =" & Lar)
        Console.WriteLine("Averag =" & Avg)

        Console.ReadKey()
    End Sub

End Module
