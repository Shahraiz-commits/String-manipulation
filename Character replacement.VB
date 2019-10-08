Module Module1

    Sub Main()
        Dim Str1, FinalStr As String
        Dim CharRemoval, CharReplacer, Char1 As Char
        Dim count As Integer


        Str1 = ""
        CharRemoval = ""
        CharReplacer = ""
        count = 0
        Char1 = ""
        FinalStr = ""

        Console.Write("Please enter a string: ")
        Str1 = Console.ReadLine()
        Console.Write("Please enter the character to be removed: ")
        CharRemoval = Console.ReadLine()
        Console.Write("Please enter the character it needs to be replaced with: ")
        CharReplacer = Console.ReadLine

        For count = 1 To Len(Str1)

            Char1 = Mid(Str1, count, 1)
            If Char1 = CharRemoval Then
                FinalStr = FinalStr & CharReplacer
            Else
                FinalStr = FinalStr & Char1

            End If

        Next
        Console.Write("The final string is" & " " & FinalStr & ".")
        Console.ReadKey()
    End Sub

End Module
