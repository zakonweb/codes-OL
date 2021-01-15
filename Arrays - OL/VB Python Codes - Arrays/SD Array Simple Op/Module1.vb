Module Module1

    Sub Main()
        Dim stuNames(5) As String
        Dim i As Integer
        Dim sN, n2s As String

        'Initialisation
        For i = 1 To 5
            stuNames(i) = ""
        Next

        'Population
        For i = 1 To 5
            Console.Write("Enter name " & i & ": ")
            sN = Console.ReadLine
            stuNames(i) = sN
        Next

        'Reading an Array
        For i = 1 To 5
            sN = stuNames(i)
            Console.WriteLine(sN)
        Next

        'searching
        Console.Write("Enter name to search: ")
        n2s = Console.ReadLine
        For i = 1 To 5
            sN = stuNames(i)
            If sN = n2s Then Console.WriteLine(sN & " is found @" & i)
        Next


        Console.ReadKey()
    End Sub

End Module
