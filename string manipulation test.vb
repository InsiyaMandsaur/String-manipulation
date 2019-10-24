Module Module1

    Sub Main()
        Dim str1, nextchar As String
        Dim count, counter, totalworth As Integer
        Dim validBinarystring As Boolean

        str1 = ""
        nextchar = ""
        count = 0
        counter = 0
        totalworth = 0
        validBinarystring = True

        Console.WriteLine("enter a binary string: ")
        str1 = Console.ReadLine

        If Len(str1) < 1 Or Len(str1) > 8 Then
            validBinarystring = False
        Else
            For count = 1 To Len(str1)
                nextchar = Mid(str1, count, 1)
                If nextchar <> "1" And nextchar <> "0" Then
                    validBinarystring = False
                    Exit For
                End If
            Next
        End If

        If validBinarystring = False Then Console.Write("Not a valid binary number")
        Console.ReadKey()

        If validBinarystring = True Then
            For count = 1 To Len(str1)
                nextchar = Mid(str1, count, 1)
                totalworth = 2 * totalworth + nextchar
            Next
            Console.WriteLine(totalworth)
            Console.ReadKey()
        End If
    End Sub

End Module
