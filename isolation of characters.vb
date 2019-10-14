Module Module1

    Sub Main()
        Dim string1, string2, nextchar, alphabets, numbers, specials As String
        Dim counter As Integer

        string1 = ""
        string2 = ""
        numbers = ""
        alphabets = ""
        specials = ""
        nextchar = ""
        counter = 0

        Console.WriteLine("Enter the string: ")
        string1 = Console.ReadLine

        For counter = 1 To Len(string1)
            nextchar = Mid(string1, counter, 1)
            If UCase(nextchar) >= "A" And UCase(nextchar) <= "Z" Then
                alphabets = alphabets & nextchar
            ElseIf nextchar >= "0" And nextchar <= "9" Then
                numbers = numbers & nextchar
            Else
                specials = specials & nextchar
            End If
        Next
        Console.WriteLine("the alphabets in your string are: " & alphabets)
        Console.WriteLine("the numbers in your string are: " & numbers)
        Console.WriteLine("the specials in your string are: " & specials)
        Console.ReadKey()
    End Sub

End Module
