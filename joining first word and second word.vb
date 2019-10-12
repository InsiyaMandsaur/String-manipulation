Module Module1

    Sub Main()
        Dim string1, string2, firstword, secondword As String
        Dim spacepos As Integer

        string1 = ""
        string2 = ""
        firstword = ""
        secondword = ""
        spacepos = 0

        Console.WriteLine("Enter first string: ")
        string1 = Console.ReadLine

        Console.WriteLine("Enter second string: ")
        string2 = Console.ReadLine

        spacepos = InStr(string1, " ")
        firstword = Left(string1, spacepos - 1)

        spacepos = InStr(string2, " ")
        secondword = Right(string2, Len(string2) - spacepos)

        Console.WriteLine("Final string is: " & firstword & " " & secondword)

        Console.ReadKey()
    End Sub

End Module
