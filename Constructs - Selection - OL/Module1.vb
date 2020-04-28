Module Module1

    Sub Main()
        Dim X As Integer
        X = Console.ReadLine

        If X > 1 Then
            Console.WriteLine("Greater")
        Else
            Console.WriteLine("Lesser")
        End If

        If X = 1 Then Console.WriteLine("A")
        If X = 2 Then Console.WriteLine("B")
        If X = 3 Then Console.WriteLine("C")
        If X = 4 Then Console.WriteLine("D")

        If X = 1 Then
            Console.WriteLine("A")
        Else
            If X = 2 Then
                Console.WriteLine("A")
            Else
                If X = 3 Then
                    Console.WriteLine("A")
                End If
            End If
        End If

        If X = 1 Then
            Console.WriteLine("A")
        ElseIf X = 2 Then
            Console.WriteLine("B")
        ElseIf X = 3 Then
            Console.WriteLine("C")
        End If

        Select Case X
            Case 1 : Console.WriteLine("A")
            Case 2 : Console.WriteLine("B")
            Case 3 : Console.WriteLine("C")
            Case Else : Console.WriteLine("Error")
        End Select



    End Sub

End Module
