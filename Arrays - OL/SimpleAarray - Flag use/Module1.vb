Module Module1

    Sub Main()
        Dim i As Integer
        Dim searchName, names(5) As String
        Dim isFound As Boolean
        isFound = False

        For i = 1 To 5
            names(i) = Console.ReadLine
        Next

        searchName = Console.ReadLine
        For i = 1 To 5
            If searchName = names(i) Then
                isFound = True
                Console.WriteLine("Found @" & i)
            End If
        Next.
        If isFound = False Then Console.WriteLine("Not FOund.")
        Console.ReadKey()

    End Sub

End Module
