Module Module1

    Sub Main()
        Dim Count As Integer
        Dim Time, FS, Highest, Lowest, Total, AVG As Single
        Const Distance = 200

        Count = 0
        Time = 0
        FS = 0
        Total = 0
        AVG = 0
        Highest = -1000
        Lowest = 1000

        For Count = 1 To 5
            console.write("Enter time: ")
            Time = Console.ReadLine()  'Input Time

            FS = Distance / Time
            Console.WriteLine("Final speed = " & FS)    'Output FS

            Total = Total + FS

            If FS > Highest Then Highest = FS
            If FS < Lowest Then Lowest = FS
        Next
        AVG = Total / 5
        Console.WriteLine("Lowest speed was :" & Lowest)    'Output Lowest
        Console.WriteLine("Highest speed was :" & Highest)  'Output Highest
        Console.WriteLine("Average speed is :" & AVG)       'Output Avg
        Console.ReadKey()
    End Sub

End Module
