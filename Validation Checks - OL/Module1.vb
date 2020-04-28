Module Module1

    Sub Main()
        Dim name As String = ""
        Dim age As Integer = 0

        'Presence Check
        Console.Write("Enter Name:")
        name = Console.ReadLine
        While name = ""
            Console.WriteLine("You can not leave this field blank. ReEnter Please.")
            name = Console.ReadLine
        End While

        'Range check
        Console.Write("Enter Age:")
        age = Console.ReadLine
        While age < 15 Or age > 20
            Console.WriteLine("Incorrect, ReEnter Please.")
            age = Console.ReadLine
        End While
        Console.ReadKey()

    End Sub

End Module
