Imports System
Imports System.Collections.Generic
Imports System.Linq

Public Class SequenceOperations
        Public Function GetProductList() As List(Of Product)
            Return ProductList
        End Function

        Public Function GetCustomerList() As List(Of Customer)
            Return CustomerList
        End Function

        Public Function EqualSequence() As Integer
#Region "equal-sequence"
            Dim wordsA = New String() {"cherry", "apple", "blueberry"}
            Dim wordsB = New String() {"cherry", "apple", "blueberry"}
            Dim match = wordsA.SequenceEqual(wordsB)
            Console.WriteLine($"The sequences match: {match}")
#End Region
            Return 0
        End Function

        ' Combine in Markdown.s
        Public Function Linq97() As Integer
#Region "not-equal-sequence"
            Dim wordsA = New String() {"cherry", "apple", "blueberry"}
            Dim wordsB = New String() {"apple", "blueberry", "cherry"}
            Dim match = wordsA.SequenceEqual(wordsB)
            Console.WriteLine($"The sequences match: {match}")
#End Region
            Return 0
        End Function

        Public Function ConcatSeries() As Integer
#Region "concat-series"
            Dim numbersA = {0, 2, 4, 5, 6, 8, 9}
            Dim numbersB = {1, 3, 5, 7, 8}
            Dim allNumbers = numbersA.Concat(numbersB)
            Console.WriteLine("All numbers from both arrays:")

            For Each n In allNumbers
                Console.WriteLine(n)
            Next
#End Region
            Return 0
        End Function

        Public Function ConcatProjection() As Integer
#Region "concat-projections"
            Dim customers As List(Of Customer) = GetCustomerList()
            Dim products As List(Of Product) = GetProductList()
            Dim customerNames = From c In customers Select c.CompanyName
            Dim productNames = From p In products Select p.ProductName
            Dim allNames = customerNames.Concat(productNames)
            Console.WriteLine("Customer and product names:")

            For Each n In allNames
                Console.WriteLine(n)
            Next
#End Region
            Return 0
        End Function

        Public Function DotProduct() As Integer
#Region "dot-product"
            Dim vectorA = {0, 2, 4, 5, 6}
            Dim vectorB = {1, 3, 5, 7, 8}
            Dim lDotProduct As Integer = Enumerable.Zip(Of Integer, Global.System.Int32, Global.System.Int32)(vectorA, CType(vectorB, IEnumerable(Of Integer)), CType(Function(a, b) CInt(a * b), Func(Of Integer, Integer, Integer))).Sum()
            Console.WriteLine($"Dot product: {lDotProduct}")
#End Region
            Return 0
        End Function
    End Class
