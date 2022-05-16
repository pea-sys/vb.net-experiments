Imports System
Imports System.Linq

Namespace Try101LinqSamples
    Public Class Generators
        Public Function RangeOfIntegers() As Integer
#Region "generate-range"
            Dim numbers = From n In Enumerable.Range(100, 50) Select (n, If(n Mod 2 = 1, "odd", "even"))

            For Each n In numbers

                Console.WriteLine("The number {0} is {1}.", n.Item1, n.Item2)
            Next
#End Region
            Return 0
        End Function

        Public Function RepeatNumber() As Integer
#Region "generate-repeat"
            Dim numbers = Enumerable.Repeat(7, 10)

            For Each n In numbers
                Console.WriteLine(n)
            Next
#End Region
            Return 0
        End Function
    End Class
End Namespace
