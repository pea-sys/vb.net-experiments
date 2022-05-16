Imports System
Imports System.Collections.Generic
Imports System.Linq


Public Class ElementOperations
        Public Function GetProductList() As List(Of Product)
            Return ProductList
        End Function

        Public Function GetCustomerList() As List(Of Customer)
            Return CustomerList
        End Function

        Public Function FirstElement() As Integer
#Region "first-element"
            Dim products As List(Of Product) = GetProductList()
            Dim product12 As Product = (From p In products Where p.ProductID = 12 Select p).First()
            Console.WriteLine(product12)
#End Region
            Return 0
        End Function

        Public Function FirstMatchingElement() As Integer
#Region "first-matching-element"
            Dim strings = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"}
            Dim startsWithO = strings.First(Function(s) s(0) = "o"c)
            Console.WriteLine($"A string starting with 'o': {startsWithO}")
#End Region
            Return 0
        End Function

        Public Function MaybeFirstElement() As Integer
#Region "first-or-default"
            Dim numbers As Integer() = {}
            Dim firstNumOrDefault As Integer = numbers.FirstOrDefault()
            Console.WriteLine(firstNumOrDefault)
#End Region
            Return 0
        End Function

        Public Function MaybeFirstMatchingElement() As Integer
#Region "first-matching-or-default"
            Dim products As List(Of Product) = GetProductList()
            Dim product789 = products.FirstOrDefault(Function(p) p.ProductID = 789)
            Console.WriteLine($"Product 789 exists: {product789 IsNot Nothing}")
#End Region
            Return 0
        End Function

        Public Function ElementAtPosition() As Integer
#Region "element-at"
            Dim numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0}
            Dim fourthLowNum = (From n In numbers Where n > 5 Select n).ElementAt(1)  ' second number is index 1 because sequences use 0-based indexing
            Console.WriteLine($"Second number > 5: {fourthLowNum}")
#End Region
            Return 0
        End Function
    End Class
