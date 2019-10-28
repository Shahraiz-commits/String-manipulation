Module Module1

    Sub Main()
        Dim FinalSum As Integer
        Dim Count2 As Integer
        Dim NextChar2 As Char
        Dim ValidBinaryString As Boolean
        Dim NextChar As Char
        Dim Str1 As String
        Dim Count As Integer
        Dim X As Integer
        X = 0
        Str1 = ""
        NextChar = ""
        Count = 0
        ValidBinaryString = True
        FinalSum = 0
        Count2 = 0
        NextChar2 = ""
        Console.Write("Enter string: ")
        Str1 = Console.ReadLine
        If Len(Str1) <> 8 Then
            ValidBinaryString = False
        Else : For Count = 1 To Len(Str1)
                NextChar = Mid(Str1, Count, 1)
                If NextChar <> "0" And NextChar <> "1" Then ValidBinaryString = False
            Next
        End If
        If ValidBinaryString = False Then
            Console.Write("Not a valid binary string")
            Console.ReadKey()
        Else : For Count2 = 1 To Len(Str1)
                NextChar2 = Mid(Str1, Count2, 1)
                If Count2 = 1 Then X = Val(NextChar2) * 128
                If Count2 = 2 Then X = Val(NextChar2) * 64
                If Count2 = 3 Then X = Val(NextChar2) * 32
                If Count2 = 4 Then X = Val(NextChar2) * 16
                If Count2 = 5 Then X = Val(NextChar2) * 8
                If Count2 = 6 Then X = Val(NextChar2) * 4
                If Count2 = 7 Then X = Val(NextChar2) * 2
                If Count2 = 8 Then X = Val(NextChar2) * 1
                FinalSum = FinalSum + X
            Next
            Console.Write("The denary equivalent is" & " " & FinalSum)
            Console.ReadKey()
        End If


    End Sub

End Module
