Module Module1

    Sub Main()
        Dim Str1, Str2, Char1, char2, nextChar As String
        Dim Count As Integer

        Str1 = ""
        Str2 = ""
        Char1 = ""
        char2 = ""
        nextChar = ""
        Count = 0

        Console.Write("Enter String to be processed: ")
        Str1 = Console.ReadLine

        Console.Write("Enter character to remove: ")
        Char1 = Console.ReadLine

        Console.Write("Enter character to be replced: ")
        char2 = Console.ReadLine

        For Count = 1 To Len(Str1)
            nextChar = Mid(Str1, Count, 1)
            If nextChar = Char1 Then
                nextChar = char2
            End If
            Str2 = Str2 & nextChar
        Next

        Console.WriteLine("New string = " & Str2)
        Console.ReadKey()
    End Sub

End Module
