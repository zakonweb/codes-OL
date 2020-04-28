Module Module1

    Sub Main()
        Dim x, total, val, range As Integer

        Console.WriteLine("How many Values?")
        range = Console.ReadLine

        For x = 1 To range
            Console.WriteLine("Enter value " & x)
            val = Console.ReadLine


            total = total + val
        Next

        Console.WriteLine("Your total is = " & total)



        Console.ReadKey()
    End Sub

End Module
