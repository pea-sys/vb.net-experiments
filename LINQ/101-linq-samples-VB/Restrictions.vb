Imports System
Imports System.Collections.Generic
Imports System.Linq

Public Class Restrictions
        Public Function GetProductList() As List(Of Product)
            Return ProductList
        End Function

        Public Function GetCustomerList() As List(Of Customer)
            Return CustomerList
        End Function

        Public Function LowNumbers() As Integer
#Region "where-syntax"
            Dim numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0}
            Dim lowNums = From num In numbers Where num < 5 Select num
            Console.WriteLine("Numbers < 5:")

            For Each x In lowNums
                Console.WriteLine(x)
            Next
#End Region
            Return 0
        End Function

        Public Function ProductsOutOfStock() As Integer
#Region "where-property"
            Dim products As List(Of Product) = GetProductList()
            Dim soldOutProducts = From prod In products Where prod.UnitsInStock = 0 Select prod
            Console.WriteLine("Sold out products:")

            For Each product In soldOutProducts
                Console.WriteLine($"{product.ProductName} is sold out!")
            Next
#End Region
            Return 0
        End Function

        Public Function ExpensiveProductsInStock() As Integer
#Region "where-multiple-properties"
            Dim products As List(Of Product) = GetProductList()
            Dim expensiveInStockProducts = From prod In products Where prod.UnitsInStock > 0 AndAlso prod.UnitPrice > 3D Select prod
            Console.WriteLine("In-stock products that cost more than 3.00:")

            For Each product In expensiveInStockProducts
                Console.WriteLine($"{product.ProductName} is in stock and costs more than 3.00.")
            Next
#End Region
            Return 0
        End Function

        Public Function DisplayCustomerOrders() As Integer
#Region "where-drilldown"
            Dim customers As List(Of Customer) = GetCustomerList()
            Dim waCustomers = From cust In customers Where Equals(cust.Region, "WA") Select cust
            Console.WriteLine("Customers from Washington and their orders:")

            For Each customer In waCustomers
                Console.WriteLine($"Customer {customer.CustomerID}: {customer.CompanyName}")

                For Each order In customer.Orders
                    Console.WriteLine($"  Order {order.OrderID}: {order.OrderDate}")
                Next
            Next
#End Region
            Return 0
        End Function

        Public Function IndexedWhere() As Integer
#Region "where-indexed"
            Dim digits = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"}
            Dim shortDigits = digits.Where(Function(digit, index) digit.Length < index)
            Console.WriteLine("Short digits:")

            For Each d In shortDigits
                Console.WriteLine($"The word {d} is shorter than its value.")
            Next
#End Region
            Return 0
        End Function
    End Class

