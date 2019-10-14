Module Module1

    Sub Main()
        Dim string1, string2, nextchar As String
        Dim counter As Integer
        nextchar = ""
        string1 = ""
        string2 = ""
        counter = 0

        Console.WriteLine("Enter the string: ")
        string1 = Console.ReadLine

        For counter = Len(string1) To 1 Step -1
            nextchar = Mid(string1, counter, 1)
            string2 = string2 & nextchar

        Next
        Console.WriteLine(string2)
        Console.ReadKey()
    End Sub

End Module
