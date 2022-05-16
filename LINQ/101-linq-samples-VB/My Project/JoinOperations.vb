Imports System
Imports System.Collections.Generic
Imports System.Linq

Namespace Try101LinqSamples
    Public Class JoinOperations
        Public Function GetProductList() As List(Of Product)
            Return ProductList
        End Function

        Public Function GetCustomerList() As List(Of Customer)
            Return CustomerList
        End Function

        Public Function CrossJoinQuery() As Integer
#Region "cross-join"
            Dim categories = {"Beverages", "Condiments", "Vegetables", "Dairy Products", "Seafood"}
            Dim products As List(Of Product) = GetProductList()
            Dim q = From c In categories Join p In products On c Equals p.Category Select (c, p.ProductName)

            For Each v In q
                Console.WriteLine(v.ProductName & ": " & v.Item1)
            Next
#End Region
            Return 0
        End Function

        Public Function GroupJoinQquery() As Integer
#Region "group-join"
            Dim categories = {"Beverages", "Condiments", "Vegetables", "Dairy Products", "Seafood"}
            Dim products As List(Of Product) = GetProductList()
            Dim q = From c In categories Group Join p In products On c Equals p.Category Into ps = Group Select (c, ps)

            For Each v In q
                Console.WriteLine(v.Item1 & ":")

                For Each p In v.Item2
                    Console.WriteLine("   " & p.ProductName)
                Next
            Next
#End Region
            Return 0
        End Function

        Public Function CrossGroupJoin() As Integer
#Region "cross-group-join"
            Dim categories = {"Beverages", "Condiments", "Vegetables", "Dairy Products", "Seafood"}
            Dim products As List(Of Product) = GetProductList()
            Dim q = From c In categories Group Join p In products On c Equals p.Category Into ps = Group From p In ps Select (c, p.ProductName)

            For Each v In q
                Console.WriteLine(v.ProductName & ": " & v.Item1)
            Next
#End Region
            Return 0
        End Function

        Public Function LeftOuterJoin() As Integer
#Region "left-outer-join"
            Dim categories = {"Beverages", "Condiments", "Vegetables", "Dairy Products", "Seafood"}
            Dim products As List(Of Product) = GetProductList()
            Dim q = From c In categories Group Join p In products On c Equals p.Category Into ps = Group From p In ps.DefaultIfEmpty() Select (c, If(p Is Nothing, "(No products)", p.ProductName))

            For Each v In q
                Console.WriteLine($"{v.Item1}: {v.Item2}")
            Next
#End Region
            Return 0
        End Function
    End Class
End Namespace

