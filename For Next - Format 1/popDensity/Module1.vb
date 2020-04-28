Module Module1

    Sub Main()
        Dim count, pop, landArea, total As Integer
        Dim popDen, Highest, Lowest, Avg As Single
        count = pop = landArea = popDen = total = Avg = 0
        Highest = -1000
        Lowest = 1000

        For count = 1 To 5
            Console.Write("Enter Population")     'output
            pop = Console.ReadLine                'input

            Console.Write("Enter Land Area")     'output
            landArea = Console.ReadLine                'input

            popDen = pop / landArea
            Console.WriteLine(popDen)

            total = total + pop

            If popDen > Highest Then
                Highest = popDen
            End If

            If popDen < Lowest Then
                Lowest = popDen
            End If
        Next

        Avg = Total / 500
        Console.WriteLine(Highest)
        Console.WriteLine(Lowest)
        Console.WriteLine(Avg)

        Console.ReadKey()
    End Sub

End Module
