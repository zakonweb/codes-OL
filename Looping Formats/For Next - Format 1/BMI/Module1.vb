Module Module1

    Sub Main()
        Dim id, count, w, h, BMI As Integer
        id = 0
        count = 0
        w = 0
        h = 0
        BMI = 0

        For count = 1 To 5
            id = Console.ReadLine
            w = Console.ReadLine
            h = Console.ReadLine

            BMI = w / (h * h)
            Console.WriteLine("ID: " & id)
            Console.WriteLine("BMI: " & BMI)

            If BMI < 19 Then Console.WriteLine("Underweight")
            If BMI > 25 Then Console.WriteLine("Overweight")
            If BMI >= 19 And BMI <= 25 Then Console.WriteLine("Normal")

            Console.ReadKey()
        Next
    End Sub

End Module
