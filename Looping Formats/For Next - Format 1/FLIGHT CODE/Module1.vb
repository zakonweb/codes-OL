Module Module1

    Sub Main()
        Dim count, F, S, K As Integer
        Dim PF, PS, PK As Single
        Dim FC As String = ""

        count = F = S = K = PF = PS = PK = 0

        For count = 1 To 5
            FC = Console.ReadLine()
            Select Case FC
                Case "FA" : F += 1
                Case "SJ" : S += 1
                Case "KA" : K += 1
                Case Else : Console.WriteLine("Bad Input")
            End Select
        Next
        PF = F / 5
        PS = S / 5
        PK = K / 5
        Console.WriteLine(PF)
        Console.WriteLine(PS)
        Console.WriteLine(PK)

        Console.ReadKey()
    End Sub

End Module
