Module Module1

    Sub Main()

        Dim arr() As Integer = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}
        Dim mid, start, finish, key As Integer
        Dim found As Boolean = False

        start = 0
        finish = UBound(arr)

        Console.WriteLine("What do you want to search? ")
        key = Console.ReadLine()

        While (start < finish)

            mid = CInt((start + finish) / 2)

            If arr(mid) = key Then
                found = True
                Exit While
            ElseIf arr(mid) < key Then
                start = mid + 1
            Else
                finish = mid - 1
            End If
        End While

        If found = True Then
            Console.WriteLine("The thing is in the array and is at {0} no. index", mid)
        Else
            Console.WriteLine("Ain't in the array")
        End If

    End Sub

End Module
