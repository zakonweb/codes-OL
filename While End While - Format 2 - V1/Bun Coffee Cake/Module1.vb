Module Module1

    Sub Main()
        Dim ty, item As String
        Dim b, co, ca, s, d, total, h As Single

        h = -1000

        Console.Write("Enter item sold : ") 'INPUT
        item = Console.ReadLine

        While item <> "end"
            Select Case item
                Case "bun" : b = b + 0.5
                Case "coffee" : co = co + 1.2
                Case "cake" : ca = ca + 1.5
                Case "sandwich" : s = s + 2.1
                Case "dessert" : d = d + 4
            End Select

            Console.Write("Enter item sold : ")
            item = Console.ReadLine
        End While

        total = b + co + ca + s + d

        Console.WriteLine("Total of all items sold : " & total)

        If b > h Then
            h = b
            ty = "bun"
        End If

        If co > h Then
            h = co
            ty = "coffee"
        End If

        If ca > h Then
            h = ca
            ty = "cake"
        End If

        If s > h Then
            h = s
            ty = "sandwich"
        End If

        If d > h Then
            h = d
            ty = "dessert"
        End If

        Console.WriteLine("The item sold most is :" & ty)
        Console.ReadKey()
    End Sub

End Module
