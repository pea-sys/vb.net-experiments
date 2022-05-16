Imports System
Imports System.Collections.Generic
Imports System.Linq

Public Class AggregateOperators
    Public Function GetProductList() As List(Of Product)
        Return ProductList
    End Function

    Public Function GetCustomerList() As List(Of Customer)
        Return CustomerList
    End Function

    Public Function CountSyntax() As Integer
#Region "count-syntax"
        Dim factorsOf300 = {2, 2, 3, 5, 5}
        Dim uniqueFactors As Integer = factorsOf300.Distinct().Count()
        Console.WriteLine($"There are {uniqueFactors} unique factors of 300.")
#End Region
        Return 0
    End Function

    Public Function CountConditional() As Integer
#Region "count-conditional"
        Dim numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0}
        Dim oddNumbers = numbers.Count(Function(n) n Mod 2 = 1)
        Console.WriteLine("There are {0} odd numbers in the list.", oddNumbers)
#End Region
        Return 0
    End Function

    Public Function NestedCount() As Integer
#Region "nested-count"
        Dim customers As List(Of Customer) = GetCustomerList()
        Dim orderCounts = From c In customers Select (c.CustomerID, c.Orders.Count())

        For Each customer In orderCounts
            Console.WriteLine($"ID: {customer.CustomerID}, count: {customer.Count}")
        Next

#End Region
        Return 0
    End Function

    Public Function GroupedCount() As Integer
#Region "grouped-count"
        Dim products As List(Of Product) = GetProductList()
        Dim categoryCounts = From p In products Group p By __groupByKey1__ = p.Category Into g = Group Select New With {Key .Category = __groupByKey1__, Key .ProductCount = g.Count()}

        For Each c In categoryCounts
            Console.WriteLine($"Category: {c.Category}: Product count: {c.ProductCount}")
        Next
#End Region
        Return 0
    End Function

    Public Function SumSyntax() As Integer
#Region "sum-syntax"
        Dim numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0}
        Dim numSum As Double = numbers.Sum()
        Console.WriteLine($"The sum of the numbers is {numSum}")
#End Region
        Return 0
    End Function

    Public Function SumProjection() As Integer
#Region "sum-of-projection"
        Dim words = {"cherry", "apple", "blueberry"}
        Dim totalChars As Double = words.Sum(Function(w) w.Length)
        Console.WriteLine($"There are a total of {totalChars} characters in these words.")
#End Region
        Return 0
    End Function

    Public Function SumGrouped() As Integer
#Region "grouped-sum"
        Dim products As List(Of Product) = GetProductList()
        Dim categories = From p In products Group p By __groupByKey2__ = p.Category Into g = Group Select New With {Key .Category = __groupByKey2__, Key .ProductCount = g.Sum(Function(p) p.UnitsInStock)}

        For Each pair In categories
            Console.WriteLine($"Category: {pair.Category}, Units in stock: {pair.ProductCount}")
        Next
#End Region
        Return 0
    End Function

    Public Function MinSyntax() As Integer
#Region "min-syntax"
        Dim numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0}
        Dim minNum As Integer = numbers.Min()
        Console.WriteLine($"The minimum number is {minNum}")
#End Region
        Return 0
    End Function

    Public Function MinProjection() As Integer
#Region "min-projection"
        Dim words = {"cherry", "apple", "blueberry"}
        Dim shortestWord = words.Min(Function(w) w.Length)
        Console.WriteLine($"The shortest word is {shortestWord} characters long.")
#End Region
        Return 0
    End Function

    Public Function MinGrouped() As Integer
#Region "min-grouped"
        Dim products As List(Of Product) = GetProductList()
        Dim categories = From p In products Group p By __groupByKey3__ = p.Category Into g = Group Select New With {Key .Category = __groupByKey3__, Key .CheapestPrice = g.Min(Function(p) p.UnitPrice)}

        For Each c In categories
            Console.WriteLine($"Category: {c.Category}, Lowest price: {c.CheapestPrice}")
        Next
#End Region
        Return 0
    End Function

    Public Function MinEachGroup() As Integer
#Region "min-each-group"
        Dim products As List(Of Product) = GetProductList()
        Dim categories = From p In products Group p By __groupByKey4__ = p.Category Into g = Group Select New With {Key .Category = __groupByKey4__, Key .CheapestProducts = g.Where(Function(p) p.UnitPrice = g.Min(Function(m) m.UnitPrice))}


        For Each c In categories
            Console.WriteLine($"Category: {c.Category}")

            For Each p In c.CheapestProducts
                Console.WriteLine($"	Product: {p}")
            Next
        Next
#End Region
        Return 0

    End Function

    Public Function MaxSyntax() As Integer
#Region "max-syntax"
        Dim numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0}
        Dim maxNum As Integer = numbers.Max()
        Console.WriteLine($"The maximum number is {maxNum}")
#End Region
        Return 0
    End Function

    Public Function MaxProjection() As Integer
#Region "max-projection"
        Dim words = {"cherry", "apple", "blueberry"}
        Dim longestLength = words.Max(Function(w) w.Length)
        Console.WriteLine($"The longest word is {longestLength} characters long.")
#End Region
        Return 0
    End Function

    Public Function MaxGrouped() As Integer
#Region "max-grouped"
        Dim products As List(Of Product) = GetProductList()
        Dim categories = From p In products Group p By __groupByKey5__ = p.Category Into g = Group Select New With {Key .Category = __groupByKey5__, Key .MostExpensivePrice = g.Max(Function(p) p.UnitPrice)}

        For Each c In categories
            Console.WriteLine($"Category: {c.Category} Most expensive product: {c.MostExpensivePrice}")
        Next
#End Region
        Return 0
    End Function

    Public Function MaxEachGroup() As Integer
#Region "max-each-group"
        Dim products As List(Of Product) = GetProductList()
        Dim categories = From p In products Group p By __groupByKey6__ = p.Category Into g = Group Select New With {Key .Category = __groupByKey6__, Key .MostExpensiveProducts = g.Where(Function(p) p.UnitPrice = g.Min(Function(m) m.UnitPrice))}

        For Each c In categories
            Console.WriteLine($"Category: {c.Category}")

            For Each p In c.MostExpensiveProducts
                Console.WriteLine($"	{p}")
            Next
        Next
#End Region
        Return 0
    End Function

    Public Function AverageSyntax() As Integer
#Region "average-syntax"
        Dim numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0}
        Dim averageNum As Double = numbers.Average()
        Console.WriteLine($"The average number is {averageNum}.")
#End Region
        Return 0
    End Function

    Public Function AverageProjection() As Integer
#Region "average-projection"
        Dim words = {"cherry", "apple", "blueberry"}
        Dim averageLength = words.Average(Function(w) w.Length)
        Console.WriteLine($"The average word length is {averageLength} characters.")
#End Region
        Return 0
    End Function

    Public Function AverageGrouped() As Integer
#Region "average-grouped"
        Dim products As List(Of Product) = GetProductList()
        Dim categories = From p In products Group p By __groupByKey7__ = p.Category Into g = Group Select New With {Key .Category = __groupByKey7__, Key .AveragePrice = g.Average(Function(p) p.UnitPrice)}
        For Each c In categories
            Console.WriteLine($"Category: {c.Category}, Average price: {c.AveragePrice}")
        Next
#End Region
        Return 0
    End Function

    Public Function AggregateSyntax() As Integer
#Region "aggregate-syntax"
        Dim doubles = {1.7, 2.3, 1.9, 4.1, 2.9}
        Dim product = doubles.Aggregate(Function(runningProduct, nextFactor) runningProduct * nextFactor)
        Console.WriteLine($"Total product of all numbers: {product}")
#End Region
        Return 0
    End Function

    Public Function SeededAggregate() As Integer
#Region "aggregate-seeded"
        Dim startBalance = 100.0
        Dim attemptedWithdrawals = {20, 10, 40, 50, 10, 70, 30}
        Dim endBalance = attemptedWithdrawals.Aggregate(startBalance, Function(balance, nextWithdrawal) If(nextWithdrawal <= balance, balance - nextWithdrawal, balance))
        Console.WriteLine($"Ending balance: {endBalance}")
#End Region
        Return 0
    End Function
End Class
