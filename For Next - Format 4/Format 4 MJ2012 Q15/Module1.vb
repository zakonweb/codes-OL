Module Module1

    Sub Main()
        Dim Days, NE, TE, Enquiry, HP, A, B As Integer
        Dim Per As Single

        Days = 0
        NE = 0
        TE = 0
        Enquiry = 0
        HP = 0
        A = 0
        B = 0
        Per = 0

        For Days = 1 To 7
            Console.Write("How many Enquires for Day " & Days & ": ")
            NE = Console.ReadLine

            TE = TE + NE

            For Enquiry = 1 To NE
                Console.Write("How much is the house price : ")
                HP = Console.ReadLine
                If HP < 100000 Then A = A + 1
                If HP > 500000 Then B = B + 1
            Next
            Console.WriteLine("Prices for house < 100000 :" & A)
            A = 0
        Next
        Per = (B / TE) * 100
        Console.WriteLine("Percentage of te HP > 500000 :" & Per)
        Console.ReadKey()
    End Sub

End Module
