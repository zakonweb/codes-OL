Module Module1

    Sub Main()
        Dim N As Integer
        Dim T As Single
        N = Console.ReadLine()
        T = Math.Log10(N)
        T = Int(T)
        T = T + 1
        Console.WriteLine(T & ", " & N)
        Console.ReadKey()
    End Sub

End Module
