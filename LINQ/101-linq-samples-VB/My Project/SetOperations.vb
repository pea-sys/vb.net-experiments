Imports System
Imports System.Collections.Generic
Imports System.Linq

Namespace Try101LinqSamples
    Public Class SetOperations
        Public Function GetProductList() As List(Of Product)
            Return ProductList
        End Function

        Public Function GetCustomerList() As List(Of Customer)
            Return CustomerList
        End Function

        Public Function DistinctSyntax() As Integer
#Region "distinct-syntax"
            Dim factorsOf300 = {2, 2, 3, 5, 5}
            Dim uniqueFactors = factorsOf300.Distinct()
            Console.WriteLine("Prime factors of 300:")

            For Each f In uniqueFactors
                Console.WriteLine(f)
            Next
#End Region
            Return 0
        End Function

        Public Function DistinctPropertyValues() As Integer
#Region "distinct-property-values"
            Dim products As List(Of Product) = GetProductList()
            Dim categoryNames = (From p In products Select p.Category).Distinct()
            Console.WriteLine("Category names:")

            For Each n In categoryNames
                Console.WriteLine(n)
            Next
#End Region
            Return 0
        End Function

        Public Function UnionSyntax() As Integer
#Region "union-syntax"
            Dim numbersA = {0, 2, 4, 5, 6, 8, 9}
            Dim numbersB = {1, 3, 5, 7, 8}
            Dim uniqueNumbers = numbersA.Union(numbersB)
            Console.WriteLine("Unique numbers from both arrays:")

            For Each n In uniqueNumbers
                Console.WriteLine(n)
            Next
#End Region
            Return 0
        End Function

        Public Function UnionOfQueryResults() As Integer
#Region "union-query-results"
            Dim products As List(Of Product) = GetProductList()
            Dim customers As List(Of Customer) = GetCustomerList()
            Dim productFirstChars = From p In products Select p.ProductName(0)
            Dim customerFirstChars = From c In customers Select c.CompanyName(0)
            Dim uniqueFirstChars = productFirstChars.Union(customerFirstChars)
            Console.WriteLine("Unique first letters from Product names and Customer names:")

            For Each ch In uniqueFirstChars
                Console.WriteLine(ch)
            Next
#End Region
            Return 0
        End Function

        Public Function IntersectSynxtax() As Integer
#Region "intersect-syntax"
            Dim numbersA = {0, 2, 4, 5, 6, 8, 9}
            Dim numbersB = {1, 3, 5, 7, 8}
            Dim commonNumbers = numbersA.Intersect(numbersB)
            Console.WriteLine("Common numbers shared by both arrays:")

            For Each n In commonNumbers
                Console.WriteLine(n)
            Next
#End Region
            Return 0
        End Function

        Public Function IntersectQueryResults() As Integer
#Region "intersect-different-queries"
            Dim products As List(Of Product) = GetProductList()
            Dim customers As List(Of Customer) = GetCustomerList()
            Dim productFirstChars = From p In products Select p.ProductName(0)
            Dim customerFirstChars = From c In customers Select c.CompanyName(0)
            Dim commonFirstChars = productFirstChars.Intersect(customerFirstChars)
            Console.WriteLine("Common first letters from Product names and Customer names:")

            For Each ch In commonFirstChars
                Console.WriteLine(ch)
            Next
#End Region
            Return 0
        End Function

        Public Function DifferenceOfSets() As Integer
#Region "except-syntax"
            Dim numbersA = {0, 2, 4, 5, 6, 8, 9}
            Dim numbersB = {1, 3, 5, 7, 8}
            Dim aOnlyNumbers = numbersA.Except(numbersB)
            Console.WriteLine("Numbers in first array but not second array:")

            For Each n In aOnlyNumbers
                Console.WriteLine(n)
            Next
#End Region
            Return 0
        End Function

        Public Function DifferenceOfQueries() As Integer
#Region "difference-of-queries"
            Dim products As List(Of Product) = GetProductList()
            Dim customers As List(Of Customer) = GetCustomerList()
            Dim productFirstChars = From p In products Select p.ProductName(0)
            Dim customerFirstChars = From c In customers Select c.CompanyName(0)
            Dim productOnlyFirstChars = productFirstChars.Except(customerFirstChars)
            Console.WriteLine("First letters from Product names, but not from Customer names:")

            For Each ch In productOnlyFirstChars
                Console.WriteLine(ch)
            Next
#End Region
            Return 1
        End Function
    End Class
End Namespace
