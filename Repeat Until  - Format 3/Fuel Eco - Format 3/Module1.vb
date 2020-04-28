Module Module1

    Sub Main()
        Dim Count, DT, Fuel As Integer
        Dim FE, Total, Highest, Lowest, AVG As Single

        Count = 0
        DT = 0
        Fuel = 0
        FE = 0
        Total = 0
        Highest = -1000
        Lowest = 1000
        AVG = 0

        For Count = 1 To 5
            DT = Console.ReadLine
            Fuel = Console.ReadLine

            FE = DT / Fuel
            Console.WriteLine(FE)

            Total = Total + FE

            If FE > Highest Then Highest = FE
            If FE < Lowest Then Lowest = FE
        Next


        AVG = Total / 5

        Console.WriteLine(AVG)
        Console.WriteLine(Highest)
        Console.WriteLine(Lowest)

        Console.ReadKey()
    End Sub

End Module
