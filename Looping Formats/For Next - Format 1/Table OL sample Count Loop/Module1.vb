Module Module1

    Sub Main()
        Dim Table As Integer
        Dim Range As Integer
        Dim Count As Integer
        Dim Product As Integer

        Console.WriteLine("Table? ")
        Table = Console.ReadLine

        Console.WriteLine("Upto ?")
        Range = Console.ReadLine

        For Count = 1 To Range
            Product = Table * Count
            Console.WriteLine(Table & " x " & Count & " = " & Product)
        Next

        Console.ReadKey()
    End Sub

End Module
