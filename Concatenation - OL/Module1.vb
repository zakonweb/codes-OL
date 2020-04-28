Module Module1

    Sub Main()
        Dim myName As String
        Dim myAge As Integer

        Console.WriteLine("Enter your Name?")
        myName = Console.ReadLine

        Console.WriteLine("What's your age? ")
        myAge = Console.ReadLine

        Console.WriteLine("Mr." & myName & "your age is: " & myAge)

        Console.ReadKey()
    End Sub

End Module
