Module Module1

    Sub Main()
        Dim string1, string3, mychar, nextchar As String
        Dim counter As Integer

        nextchar = ""
        string1 = ""
        string3 = ""
        mychar = ""
        counter = 0

        Console.WriteLine("Enter your string: ")
        string1 = Console.ReadLine

        Console.Write("Enter the character you want to truncate: ")
        mychar = Console.ReadLine

        For counter = 1 To Len(string1)
            nextchar = Mid(string1, counter, 1)
            If nextchar <> mychar Then
                string3 = string3 & nextchar
            End If
        Next
        Console.WriteLine("your final string is: " & string3)
        Console.ReadKey()
    End Sub

End Module
