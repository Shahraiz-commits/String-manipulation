Module Module1

    Sub Main()
        Dim Str1 As String
        Dim Str2 As String
        Dim Count As Integer
        Dim NextChar As Char
        Dim Count2 As Integer
        Dim Str2char As Char
        Dim Vowels As Integer


        Vowels = 0
        Str2char = ""
        Count2 = 0
        NextChar = ""
        Count = 0
        Str1 = ""
        Str2 = ""

        Console.Write("Enter string: ")
        Str1 = Console.ReadLine
        Str2 = ("AEIOU")

        For Count = 1 To Len(Str1)
            NextChar = Mid(Str1, Count, 1)

            For Count2 = 1 To Len(Str2)
                Str2char = Mid(Str2, Count2, 1)
                If UCase(NextChar) = Str2char Then Vowels = Vowels + 1
            Next

        Next
        Console.Write("Number of vowels in this string are " & Vowels)
        Console.ReadKey()

    End Sub

End Module
