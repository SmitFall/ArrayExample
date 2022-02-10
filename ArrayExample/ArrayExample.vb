
Option Explicit On
Option Strict On

Module ArrayExample

    Sub Main()

    End Sub
    Sub simpleArray()
        'Declare an array of strings with 0 to 5 elements
        Dim names(6) As String

        'add data to the arry
        names(0) = "Jim"
        names(1) = "paul"
        names(2) = "Mary"
        names(4) = "sally"

        'exception
        'names(6) = "xxx"

        'access an element 
        Console.WriteLine((names(6)))
        Console.ReadLine()

    End Sub
    Sub TwoDimensionArrayloop()
        'it broke
        Dim number(9, 9) As Integer
        Dim Temp As String


        For row = 0 To 9
            For column = 0 To 9
                number(row, column) = row + column
            Next
        Next

        For row = 0 To 9
            For column = 0 To 9
                Temp = CStr(number(row, column)) & "|"
                Console.WriteLine(Temp.PadLeft(6))
            Next
            Console.WriteLine()
        Next
        Console.ReadLine()

    End Sub
    Sub ArrayBoundries()

        Dim Fruits(5) As String

        Fruits(0) = "apple"
        Fruits(1) = "pear"
        Fruits(2) = "orange"
        Fruits(3) = "plum"
        Fruits(4) = "grape"
        Fruits(5) = "tomato"

        For I = LBound(Fruits) To UBound(Fruits)
            Console.WriteLine(Fruits(I))
        Next

        For i = 0 To 5
            Console.WriteLine(Fruits(i))
        Next
        Console.ReadLine()

    End Sub
End Module
