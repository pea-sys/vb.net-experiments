Imports System
Imports System.Collections.Generic
Imports System.Linq

Namespace Try101LinqSamples
    Public Class Partitions
        Public Function GetProductList() As List(Of Product)
            Return ProductList
        End Function

        Public Function GetCustomerList() As List(Of Customer)
            Return CustomerList
        End Function

        Public Function TakeSyntax() As Integer
#Region "take-syntax"
            Dim numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0}
            Dim first3Numbers = numbers.Take(3)
            Console.WriteLine("First 3 numbers:")

            For Each n In first3Numbers
                Console.WriteLine(n)
            Next
#End Region
            Return 0
        End Function

        Public Function NestedTake() As Integer
#Region "nested-take"
            Dim customers As List(Of Customer) = GetCustomerList()
            Dim first3WAOrders = (From cust In customers From order In cust.Orders Where Equals(cust.Region, "WA") Select (cust.CustomerID, order.OrderID, order.OrderDate)).Take(3)
            Console.WriteLine("First 3 orders in WA:")

            For Each order In first3WAOrders
                Console.WriteLine(order)
            Next
#End Region
            Return 0
        End Function

        Public Function SkipSyntax() As Integer
#Region "skip-syntax"
            Dim numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0}
            Dim allButFirst4Numbers = numbers.Skip(4)
            Console.WriteLine("All but first 4 numbers:")

            For Each n In allButFirst4Numbers
                Console.WriteLine(n)
            Next
#End Region
            Return 0
        End Function

        Public Function NestedSkip() As Integer
#Region "nested-skip"
            Dim customers As List(Of Customer) = GetCustomerList()
            Dim waOrders = From cust In customers From order In cust.Orders Where Equals(cust.Region, "WA") Select (cust.CustomerID, order.OrderID, order.OrderDate)
            Dim allButFirst2Orders = waOrders.Skip(2)
            Console.WriteLine("All but first 2 orders in WA:")

            For Each order In allButFirst2Orders
                Console.WriteLine(order)
            Next
#End Region
            Return 1
        End Function

        Public Function TakeWhileSyntax() As Integer
#Region "takewhile-syntax"
            Dim numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0}
            Dim firstNumbersLessThan6 = numbers.TakeWhile(Function(n) n < 6)
            Console.WriteLine("First numbers less than 6:")

            For Each num In firstNumbersLessThan6
                Console.WriteLine(num)
            Next
#End Region
            Return 0
        End Function

        Public Function IndexedTakeWhile() As Integer
#Region "indexed-takewhile"
            Dim numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0}
            Dim firstSmallNumbers = numbers.TakeWhile(Function(n, index) n >= index)
            Console.WriteLine("First numbers not less than their position:")

            For Each n In firstSmallNumbers
                Console.WriteLine(n)
            Next
#End Region
            Return 0
        End Function

        Public Function SkipWhileSyntax() As Integer
#Region "skipwhile-syntax"
            Dim numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0}

            ' In the lambda expression, 'n' is the input parameter that identifies each
            ' element in the collection in succession. It is is inferred to be
            ' of type int because numbers is an int array.
            Dim allButFirst3Numbers = numbers.SkipWhile(Function(n) n Mod 3 <> 0)
            Console.WriteLine("All elements starting from first element divisible by 3:")

            For Each n In allButFirst3Numbers
                Console.WriteLine(n)
            Next
#End Region
            Return 0
        End Function

        Public Function IndexedSkipWhile() As Integer
#Region "indexed-skipwhile"
            Dim numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0}
            Dim laterNumbers = numbers.SkipWhile(Function(n, index) n >= index)
            Console.WriteLine("All elements starting from first element less than its position:")

            For Each n In laterNumbers
                Console.WriteLine(n)
            Next
#End Region
            Return 0
        End Function
    End Class
End Namespace
