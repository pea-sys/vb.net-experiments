Imports System
Imports System.Collections.Generic
Imports System.Linq

Public Class Quantifiers
        Public Function GetProductList() As List(Of Product)
            Return ProductList
        End Function

        Public Function GetCustomerList() As List(Of Customer)
            Return CustomerList
        End Function

        Public Function AnyMatchingElements() As Integer
#Region "any-matches"
            Dim words = {"believe", "relief", "receipt", "field"}
            Dim iAfterE = words.Any(Function(w) w.Contains("ei"))
            Console.WriteLine($"There is a word that contains in the list that contains 'ei': {iAfterE}")
#End Region
            Return 0
        End Function

    Public Function GroupedAnyMatchedElements() As Integer
#Region "any-grouped"
        Dim products As List(Of Product) = GetProductList()
        Dim productGroups = From p In products Group p By __groupByKey1__ = p.Category Into g = Group Select New With {Key .Category = __groupByKey1__, .Products = g}

        For Each group In productGroups

            Console.WriteLine(group.Category)

            For Each product In group.Products
                Console.WriteLine($"	{product}")
            Next
        Next
#End Region
            Return 0
    End Function

    Public Function AllMatchedElements() As Integer
#Region "all-match"
            Dim numbers = {1, 11, 3, 19, 41, 65, 19}
            Dim onlyOdd = numbers.All(Function(n) n Mod 2 = 1)
            Console.WriteLine($"The list contains only odd numbers: {onlyOdd}")
#End Region
            Return 0
        End Function

    Public Function GroupedAllMatchedElements() As Integer
#Region "all-grouped"
        Dim products As List(Of Product) = GetProductList()
        Dim productGroups = From p In products Group p By __groupByKey2__ = p.Category Into g = Group Select New With {Key .Category = __groupByKey2__, Key .Products = g}

        For Each group In productGroups
            Console.WriteLine(group.Category)

            For Each product In group.Products
                Console.WriteLine($"	{product}")
            Next
        Next
#End Region
        Return 0
    End Function
End Class
