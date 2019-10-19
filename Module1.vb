Module Module1

    Sub Main()
        Dim STR1 As String
        Dim STR2 As String
        Dim count As Integer
        Dim Char1 As Char

        count = 0
        STR1 = ""
        STR2 = ""
        Char1 = ""

        Console.Write("enter string: ")
        STR1 = Console.ReadLine

        For count = Len(STR1) To 1 Step count - 1
            Char1 = Mid(STR1, count, 1)
            STR2 = STR2 & Char1
        Next

        Console.Write("inversed string is: " & STR2)
        Console.ReadKey()
    End Sub

End Module
