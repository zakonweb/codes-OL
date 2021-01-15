Module Module1

    Sub Main()
        Dim Cl, Stu, Avg1, tot1, X, age, old, young As Integer
        Dim Gde As String
        Dim per As Single

        Cl = 0
        Stu = 0
        Avg1 = 0
        tot1 = 0
        age = 0
        old = -1000
        young = 1000
        Gde = ""
        per = 0
        X = 0

        For Cl = 1 To 2
            tot1 = 0
            Avg1 = 0
            For Stu = 1 To 3
                age = Console.ReadLine
                Gde = Console.ReadLine

                tot1 = tot1 + age
                If Gde = "A" Then X = X + 1

                If age > old Then old = age
                If age < young Then young = age
            Next
            Avg1 = tot1 / 3
            Console.WriteLine(Avg1)
        Next
        per = (X / 6) * 100
        Console.WriteLine(X)
        Console.WriteLine(per)
        Console.WriteLine(old)
        Console.WriteLine(young)

        Console.ReadKey()
    End Sub

End Module
