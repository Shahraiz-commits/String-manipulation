Module Module1

    Sub Main()
        Dim Str1 As String
        Dim Char1 As Char
        Dim Digits, Letters, Count As Integer

        Count = 0
        Digits = 0
        Letters = 0
        Char1 = ""
        Str1 = ""

        Console.Write("Enter string: ")
        Str1 = Console.ReadLine

        For Count = 1 To Len(Str1)
            Char1 = Mid(Str1, Count, 1)

            If Asc(Char1) >= 65 Then
                Letters = Letters + 1
            Else : Digits = Digits + 1


            End If

        Next
        Console.Write("Letters are " & Letters & " and digits are " & Digits)
        Console.ReadKey()

    End Sub

End Module
