Module Module1

    Sub Main()

        'Using case selection
        Dim choice As String
        'Ask user for the number
        Console.WriteLine("1. Item 1")
        Console.WriteLine("2. Item 2")
        Console.WriteLine("3. Item 3")
        Console.WriteLine("Enter your choice: ")
        choice = Console.ReadLine
        'Multiple branches depending on selection
        Select Case choice
            Case Is = "1"
                Console.WriteLine("Item 1 chosen")
            Case Is = "2"
                Console.WriteLine("Item 2 chosen")
            Case Is = "3"
                Console.WriteLine("Item 3 chosen")
            Case Is > "3"
                Console.WriteLine("Invalid input")

        End Select
        Console.ReadLine()

    End Sub

End Module
