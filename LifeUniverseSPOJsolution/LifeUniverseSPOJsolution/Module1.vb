Module Module1

    Sub Main()
        ' This code uses Visual Basic syntax
        Dim number As Integer
        Dim i As Integer = 0
        Dim count As Boolean = True
        Do
            Console.WriteLine("")
            number = Integer.Parse(Console.ReadLine())
            Console.WriteLine(number)
            If number = 42 Then
                Exit Do
            End If
            i += 1
        Loop While count

        Console.ReadLine()
    End Sub

End Module
