Module Module1

    Sub Main()
        Dim Count, Time As Integer
        Dim FS, Highest, Lowest, Total, AVG As Single

        Count = 0
        Time = 0
        FS = 0
        Total = 0
        AVG = 0
        Highest = -1000
        Lowest = 1000

        For Count = 1 To 5
            Time = Console.ReadLine()  'Input Time

            FS = 200 / Time
            Console.WriteLine(FS)    'Output FS

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
