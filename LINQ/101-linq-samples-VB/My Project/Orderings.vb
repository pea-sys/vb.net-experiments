Imports System
Imports System.Linq
Imports System.Collections.Generic

Namespace Try101LinqSamples
    Public Class Orderings
        Public Function GetProductList() As List(Of Product)
            Return ProductList
        End Function

        Public Function GetCustomerList() As List(Of Customer)
            Return CustomerList
        End Function

        Public Function OrderbySyntax() As Integer
#Region "orderby-syntax"
            Dim words = {"cherry", "apple", "blueberry"}
            Dim sortedWords = From word In words Order By word Select word
            Console.WriteLine("The sorted list of words:")

            For Each w In sortedWords
                Console.WriteLine(w)
            Next
#End Region
            Return 0
        End Function

        Public Function OrderbyProperty() As Integer
#Region "orderby-property"
            Dim words = {"cherry", "apple", "blueberry"}
            Dim sortedWords = From word In words Order By word.Length Select word
            Console.WriteLine("The sorted list of words (by length):")

            For Each w In sortedWords
                Console.WriteLine(w)
            Next
#End Region
            Return 0
        End Function

        Public Function OrderByProducts() As Integer
#Region "orderby-user-types"
            Dim products As List(Of Product) = GetProductList()
            Dim sortedProducts = From prod In products Order By prod.ProductName Select prod

            For Each product In sortedProducts
                Console.WriteLine(product)
            Next
#End Region
            Return 0
        End Function

#Region "custom-comparer"
        ' Custom comparer for use with ordering operators
        Public Class CaseInsensitiveComparer
            Implements IComparer(Of String)

            Public Function Compare(ByVal x As String, ByVal y As String) As Integer Implements IComparer(Of String).Compare
                Return String.Compare(x, y, StringComparison.OrdinalIgnoreCase)
            End Function
        End Class
#End Region

        Public Function OrderByWithCustomComparer() As Integer
#Region "orderby-custom-comparer"
            Dim words = {"aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry"}
            Dim sortedWords = words.OrderBy(Function(a) a, New CaseInsensitiveComparer())

            For Each word In sortedWords
                Console.WriteLine(word)
            Next
#End Region
            Return 0
        End Function

        Public Function OrderByDescendingSyntax() As Integer
#Region "orderbydescending-syntax"
            Dim doubles = {1.7, 2.3, 1.9, 4.1, 2.9}
            Dim sortedDoubles = From d In doubles Order By d Select d
            Console.WriteLine("The doubles from highest to lowest:")

            For Each d In sortedDoubles
                Console.WriteLine(d)
            Next
#End Region
            Return 0
        End Function

        Public Function OrderProductsDescending() As Integer
#Region "orderby-descending-type"
            Dim products As List(Of Product) = GetProductList()
            Dim sortedProducts = From prod In products Order By prod.UnitsInStock Select prod

            For Each product In sortedProducts
                Console.WriteLine(product)
            Next
#End Region
            Return 0
        End Function

        Public Function DescendingCustomComparer() As Integer
#Region "desc-custom-comparer"
            Dim words = {"aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry"}
            Dim sortedWords = words.OrderByDescending(Function(a) a, New CaseInsensitiveComparer())

            For Each word In sortedWords
                Console.WriteLine(word)
            Next
#End Region
            Return 0
        End Function

        Public Function ThenBySyntax() As Integer
#Region "thenby-syntax"
            Dim digits = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"}
            Dim sortedDigits = From digit In digits Order By digit.Length, digit Select digit
            Console.WriteLine("Sorted digits:")

            For Each d In sortedDigits
                Console.WriteLine(d)
            Next
#End Region
            Return 0
        End Function

        Public Function ThenByCustom() As Integer
#Region "thenby-custom"
            Dim words = {"aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry"}
            Dim sortedWords = words.OrderBy(Function(a) a.Length).ThenBy(Function(a) a, New CaseInsensitiveComparer())

            For Each word In sortedWords
                Console.WriteLine(word)
            Next
#End Region
            Return 0
        End Function

        Public Function ThenByDifferentOrdering() As Integer
#Region "thenby-ordering"
            Dim products As List(Of Product) = GetProductList()
            Dim sortedProducts = From prod In products Order By prod.Category, prod.UnitPrice Select prod

            For Each product In sortedProducts
                Console.WriteLine(product)
            Next
#End Region
            Return 0
        End Function

        Public Function CustomThenByDescending() As Integer
#Region "thenby-custom-descending"
            Dim words = {"aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry"}
            Dim sortedWords = words.OrderBy(Function(a) a.Length).ThenByDescending(Function(a) a, New CaseInsensitiveComparer())

            For Each word In sortedWords
                Console.WriteLine(word)
            Next
#End Region
            Return 0
        End Function

        Public Function OrderingReversal() As Integer
#Region "reverse"
            Dim digits = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"}
            Dim reversedIDigits = (From digit In digits Where digit(1) = "i"c Select digit).Reverse()
            Console.WriteLine("A backwards list of the digits with a second character of 'i':")

            For Each d In reversedIDigits
                Console.WriteLine(d)
            Next
#End Region
            Return 0
        End Function
    End Class
End Namespace
