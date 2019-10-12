Module Module1

    Sub Main()
        Dim string1, middleword As String
        Dim spacepos1, spacepos2 As Integer

        string1 = ""
        middleword = ""
        spacepos1 = 0
        spacepos2 = 0

        Console.WriteLine("Enter name that consists of 3 words: ")
        string1 = Console.ReadLine

        spacepos1 = InStr(string1, " ")
        spacepos2 = InStr(spacepos1 + 1, string1, " ")
        middleword = Mid(string1, spacepos1 + 1, spacepos2 - spacepos1 - 1)

        Console.WriteLine(middleword)
        Console.ReadKey()

    End Sub

End Module
