Module Module1

    Sub Main()
        Dim names(5) As String
        Dim gde(5) As Char
        Dim i As Integer

        Dim searchGde As String

        For i = 1 To 5
            names(i) = Console.ReadLine
            gde(i) = Console.ReadLine
        Next

        Console.Write("Enter Grade to search for: ")
        searchGde = Console.ReadLine
        For i = 1 To 5
            If searchGde = gde(i) Then Console.WriteLine(names(i))
        Next
    End Sub

End Module
