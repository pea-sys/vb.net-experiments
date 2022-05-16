Imports System
Imports System.Collections.Generic
Imports System.Linq

Namespace Try101LinqSamples
    Public Class Groupings
        Public Function GetProductList() As List(Of Product)
            Return ProductList
        End Function

        Public Function GetCustomerList() As List(Of Customer)
            Return CustomerList
        End Function

        '        Public Function GroupingSyntax() As Integer
        '#Region "groupby-syntax"
        '            Dim numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0}
        '            Dim numberGroups = From n In numbers Group n By __groupByKey1__ = n Mod 5 Into g = Group Select (__groupByKey1__, g)

        '            For Each g In numberGroups
        '                Console.WriteLine($"Numbers with a remainder of {g.Remainder} when divided by 5:")

        '                For Each n In g.Numbers
        '                    Console.WriteLine(n)
        '                Next
        '            Next
        '#End Region
        '            Return 0
        '        End Function

        '        Public Function GroupByProperty() As Integer
        '#Region "groupby-property"
        '            Dim words = {"blueberry", "chimpanzee", "abacus", "banana", "apple", "cheese"}
        '            Dim wordGroups = From w In words Group w By __groupByKey2__ = w(0) Into g = Group Select (__groupByKey2__, g)

        '            For Each g In wordGroups
        '                Console.WriteLine("Words that start with the letter '{0}':", g.FirstLetter)

        '                For Each w In g.Words
        '                    Console.WriteLine(w)
        '                Next
        '            Next
        '#End Region
        '            Return 0
        '        End Function

        '        Public Function GroupByCategory() As Integer
        '#Region "groupby-category"
        '            Dim products As List(Of Product) = GetProductList()
        '            Dim orderGroups = From p In products Group p By __groupByKey3__ = p.Category Into g = Group Select (__groupByKey3__, g)

        '            For Each orderGroup In orderGroups
        '                Console.WriteLine($"Products in {orderGroup.Category} category:")

        '                For Each product In orderGroup.Products
        '                    Console.WriteLine($"	{product}")
        '                Next
        '            Next
        '#End Region
        '            Return 0
        '        End Function

        '        Public Function NestedGrouBy() As Integer
        '#Region "nested-groupby"
        '            Dim customers As List(Of Customer) = GetCustomerList()
        '            Dim customerOrderGroups = From c In customers Select (c.CompanyName, From o In c.Orders Group o By __groupByKey4__ = o.OrderDate.Year Into yg = Group Select (__groupByKey4__, From o In yg Group o By __groupByKey5__ = o.OrderDate.Month Into mg = Group Select (__groupByKey5__, mg)))

        '            For Each ordersByCustomer In customerOrderGroups
        '                Console.WriteLine($"Customer Name: {ordersByCustomer.CompanyName}")

        '                For Each ordersByYear In ordersByCustomer.YearGroups
        '                    Console.WriteLine($"	Year: {ordersByYear.Year}")

        '                    For Each ordersByMonth In ordersByYear.MonthGroups
        '                        Console.WriteLine($"		Month: {ordersByMonth.Month}")

        '                        For Each order In ordersByMonth.Orders
        '                            Console.WriteLine($"			Order: {order}")
        '                        Next
        '                    Next
        '                Next
        '            Next
        '#End Region
        '            Return 0
        '        End Function

        Public Function GroupByCustomComparer() As Integer
#Region "groupby-custom-comparer"
            Dim anagrams = {"from   ", " salt", " earn ", "  last   ", " near ", " form  "}
            Dim orderGroups = anagrams.GroupBy(Function(w) w.Trim(), New AnagramEqualityComparer())

            For Each [set] In orderGroups
                ' The key would be the first item in the set
                For Each word In [set]
                    Console.WriteLine(word)
                Next

                Console.WriteLine("...")
            Next
#End Region
            Return 0
        End Function

        Public Function NestedGroupByCustom() As Integer
#Region "nested-groupby-custom"
            Dim anagrams = {"from   ", " salt", " earn ", "  last   ", " near ", " form  "}
            Dim orderGroups = anagrams.GroupBy(Function(w) w.Trim(), Function(a) a.ToUpper(), New AnagramEqualityComparer())

            For Each [set] In orderGroups
                Console.WriteLine([set].Key)

                For Each word In [set]
                    Console.WriteLine($"	{word}")
                Next
            Next

#End Region
            Return 0
        End Function
    End Class

#Region "anagram-comparer"
    Public Class AnagramEqualityComparer
        Implements IEqualityComparer(Of String)

        Public Function Equals(ByVal x As String, ByVal y As String) As Boolean Implements IEqualityComparer(Of String).Equals
            Return Equals(getCanonicalString(x), getCanonicalString(y))
        End Function

        Public Function GetHashCode(ByVal obj As String) As Integer Implements IEqualityComparer(Of String).GetHashCode
            Return getCanonicalString(obj).GetHashCode()
        End Function

        Private Function getCanonicalString(ByVal word As String) As String
            Dim wordChars As Char() = word.ToCharArray()
            Array.Sort(wordChars)
            Return New String(wordChars)
        End Function
    End Class
#End Region
End Namespace
