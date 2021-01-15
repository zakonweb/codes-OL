Module Module1

    Sub Main()
        Dim Names(5) As String
        Dim Test1(5) As Integer
        Dim Test2(5) As Integer
        Dim Test3(5) As Integer
        Dim Total(5) As Integer

        Dim Highest, Avg, i, GT As Integer

        For i = 1 To 5
            Names(i) = Console.ReadLine
            Test1(i) = Console.ReadLine
            Test2(i) = Console.ReadLine
            Test3(i) = Console.ReadLine
            Total(i) = Test1(i) + Test2(i) + Test3(i)

            GT = GT + Total(i)
        Next i

        For i = 1 To 5
            Console.WriteLine(Names(i) & ", " & Total(i))
        Next i

        Avg = GT / 5
        Console.WriteLine("Average :" & Avg)

        Highest = -1000
        For i = 1 To 5
            If Total(i) > Highest Then Highest = Total(i)
        Next i

        Console.WriteLine("Highest = " & Highest)

        Console.ReadKey()
    End Sub

End Module
