Imports System
Imports System.Collections.Generic
Imports System.Linq

Namespace Try101LinqSamples
    Public Class Projections
        Public Function GetProductList() As List(Of Product)
            Return ProductList
        End Function

        Public Function GetCustomerList() As List(Of Customer)
            Return CustomerList
        End Function

        Public Function SelectSyntax() As Integer
#Region "select-syntax"
            Dim numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0}
            Dim numsPlusOne = From n In numbers Select n + 1
            Console.WriteLine("Numbers + 1:")

            For Each i In numsPlusOne
                Console.WriteLine(i)
            Next

            Return 0
#End Region
        End Function

        Public Function SelectProperty() As Integer
#Region "select-property"
            Dim products As List(Of Product) = GetProductList()
            Dim productNames = From p In products Select p.ProductName
            Console.WriteLine("Product Names:")

            For Each productName In productNames
                Console.WriteLine(productName)
            Next
#End Region
            Return 0
        End Function

        Public Function TransformWithSelect() As Integer
#Region "select-transform"
            Dim numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0}
            Dim strings = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"}
            Dim textNums = From n In numbers Select strings(n)
            Console.WriteLine("Number strings:")

            For Each s In textNums
                Console.WriteLine(s)
            Next
#End Region
            Return 0
        End Function

        Public Function SelectByCaseAnonymous() As Integer
#Region "select-case-anonymous"
            Dim words = {"aPPLE", "BlUeBeRrY", "cHeRry"}
            Dim upperLowerWords = From w In words Select New With {
                .Upper = w.ToUpper(),
                .Lower = w.ToLower()
            }

            For Each ul In upperLowerWords
                Console.WriteLine($"Uppercase: {ul.Upper}, Lowercase: {ul.Lower}")
            Next
#End Region
            Return 0
        End Function

        '        Public Function SelectByCaseTuple() As Integer
        '#Region "select-case-tuple"
        '            Dim words = {"aPPLE", "BlUeBeRrY", "cHeRry"}
        '            Dim upperLowerWords = From w In words Select (w.ToUpper(), w.ToLower())

        '            For Each ul In upperLowerWords
        '                Console.WriteLine($"Uppercase: {ul.Upper}, Lowercase: {ul.Lower}")
        '            Next
        '#End Region
        '            Return 0
        '        End Function

        Public Function SelectAnonymousConstructions() As Integer
#Region "select-new-type"
            Dim numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0}
            Dim strings = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"}
            Dim digitOddEvens = From n In numbers Select New With {
                .Digit = strings(n),
                .Even = n Mod 2 = 0
            }

            For Each d In digitOddEvens
                Console.WriteLine($"The digit {d.Digit} is {If(d.Even, "even", "odd")}.")
            Next
#End Region
            Return 0
        End Function

        '        Public Function SelectTupleConstructions() As Integer
        '#Region "select-new-type-tuple"
        '            Dim numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0}
        '            Dim strings = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"}
        '            Dim digitOddEvens = From n In numbers Select (strings(n), n Mod 2 = 0)

        '            For Each d In digitOddEvens
        '                Console.WriteLine($"The digit {d.Digit} is {If(d.Even, "even", "odd")}.")
        '            Next
        '#End Region
        '            Return 0
        '        End Function

        '        Public Function SelectPropertySubset() As Integer
        '#Region "select-subset-properties"
        '            Dim products As List(Of Product) = GetProductList()
        '            Dim productInfos = From p In products Select (p.ProductName, p.Category, p.UnitPrice)
        '            Console.WriteLine("Product Info:")

        '            For Each productInfo In productInfos
        '                Console.WriteLine($"{productInfo.ProductName} is in the category {productInfo.Category} and costs {productInfo.Price} per unit.")
        '            Next
        '#End Region
        '            Return 0
        '        End Function

        '        Public Function SelectWithIndex() As Integer
        '#Region "select-with-index"
        '            Dim numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0}
        '            Dim numsInPlace = numbers.Select(Function(num, index) (num, num = index))
        '            Console.WriteLine("Number: In-place?")

        '            For Each n In numsInPlace
        '                Console.WriteLine($"{n.Num}: {n.InPlace}")
        '            Next
        '#End Region
        '            Return 0
        '        End Function

        Public Function SelectWithWhere() As Integer
#Region "select-with-where"
            Dim numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0}
            Dim digits = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"}
            Dim lowNums = From n In numbers Where n < 5 Select digits(n)
            Console.WriteLine("Numbers < 5:")

            For Each num In lowNums
                Console.WriteLine(num)
            Next
#End Region
            Return 0
        End Function

        Public Function SelectFromMultipleSequences() As Integer
#Region "select-many-syntax"
            Dim numbersA = {0, 2, 4, 5, 6, 8, 9}
            Dim numbersB = {1, 3, 5, 7, 8}
            Dim pairs = From a In numbersA From b In numbersB Where a < b Select (a, b)
            Console.WriteLine("Pairs where a < b:")

            For Each pair In pairs
                Console.WriteLine($"{pair.a} is less than {pair.b}")
            Next
#End Region
            Return 0
        End Function

        Public Function SelectFromChildSequence() As Integer
#Region "select-many-drilldown"
            Dim customers As List(Of Customer) = GetCustomerList()
            Dim orders = From c In customers From o In c.Orders Where o.Total < 500.00D Select (c.CustomerID, o.OrderID, o.Total)

            For Each order In orders
                Console.WriteLine($"Customer: {order.CustomerID}, Order: {order.OrderID}, Total value: {order.Total}")
            Next
#End Region
            Return 1
        End Function

        Public Function SelectManyWithWhere() As Integer
#Region "select-many-filter"
            Dim customers As List(Of Customer) = GetCustomerList()
            Dim orders = From c In customers From o In c.Orders Where o.OrderDate >= New DateTime(1998, 1, 1) Select (c.CustomerID, o.OrderID, o.OrderDate)

            For Each order In orders
                Console.WriteLine($"Customer: {order.CustomerID}, Order: {order.OrderID}, Total date: {order.OrderDate.ToShortDateString()}")
            Next
#End Region
            Return 0
        End Function

        Public Function SelectManyWhereAssignment() As Integer
#Region "select-many-assignment"
            Dim customers As List(Of Customer) = GetCustomerList()
            Dim orders = From c In customers From o In c.Orders Where o.Total >= 2000.0D Select (c.CustomerID, o.OrderID, o.Total)

            For Each order In orders
                Console.WriteLine($"Customer: {order.CustomerID}, Order: {order.OrderID}, Total value: {order.Total}")
            Next
#End Region
            Return 0
        End Function

        Public Function SelectMultipleWhereClauses() As Integer
#Region "multiple-where-clauses"
            Dim customers As List(Of Customer) = GetCustomerList()
            Dim cutoffDate As Date = New DateTime(1997, 1, 1)
            Dim orders = From c In customers Where Equals(c.Region, "WA") From o In c.Orders Where o.OrderDate >= cutoffDate Select (c.CustomerID, o.OrderID)

            For Each order In orders
                Console.WriteLine($"Customer: {order.CustomerID}, Order: {order.OrderID}")
            Next
#End Region
            Return 0
        End Function

        Public Function IndexedSelectMany() As Integer
#Region "indexed-select-many"
            Dim customers As List(Of Customer) = GetCustomerList()
            Dim customerOrders = customers.SelectMany(Function(cust, custIndex) cust.Orders.[Select](Function(o) "Customer #" & custIndex + 1 & " has an order with OrderID " & o.OrderID))

            For Each order In customerOrders
                Console.WriteLine(order)
            Next
#End Region
            Return 0
        End Function
    End Class
End Namespace
