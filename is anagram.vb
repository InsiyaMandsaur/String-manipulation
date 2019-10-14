Module Module1

    Sub Main()
        Dim string1, string2, nextchar As String
        Dim counter As Integer
        Dim isanagram As Boolean

        string1 = ""
        string2 = ""
        nextchar = ""
        counter = 0
        isanagram = True


        Console.WriteLine("Enter the string: ")
        string1 = Console.ReadLine
        Console.WriteLine("Enter the anagram: ")
        string2 = Console.ReadLine

        For counter = 1 To Len(string1)
            nextchar = Mid(string1, counter, 1)
            If InStr(string2, nextchar) = 0 Then
                isanagram = False
            End If
        Next
        If isanagram = False Then
            Console.WriteLine("this in not anagram")
            Console.ReadKey()
        End If

        Console.WriteLine("this is anagram")
        Console.ReadKey()
    End Sub

End Module
