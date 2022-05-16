Imports System
Imports System.Collections.Generic
Imports System.Linq

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
        Dim q = From c In categories Join p In products On c Equals p.Category Select New With {Key .CategoryName = c, Key .ProductName = p.ProductName}

        For Each v In q
            Console.WriteLine(v.ProductName & ": " & v.CategoryName)
        Next
#End Region
            Return 0
        End Function

        Public Function GroupJoinQquery() As Integer
#Region "group-join"
            Dim categories = {"Beverages", "Condiments", "Vegetables", "Dairy Products", "Seafood"}
            Dim products As List(Of Product) = GetProductList()
        Dim q = From c In categories Group Join p In products On c Equals p.Category Into ps = Group Select New With {.CategoryName = c, .Products = ps}

        For Each v In q
            Console.WriteLine(v.CategoryName & ":")

            For Each p In v.Products
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
        Dim q = From c In categories Group Join p In products On c Equals p.Category Into ps = Group From p In ps Select New With {Key .Category = c, Key .ProductName = p.ProductName}

        For Each v In q
            Console.WriteLine(v.ProductName & ": " & v.Category)
        Next
#End Region
            Return 0
        End Function

        Public Function LeftOuterJoin() As Integer
#Region "left-outer-join"
            Dim categories = {"Beverages", "Condiments", "Vegetables", "Dairy Products", "Seafood"}
            Dim products As List(Of Product) = GetProductList()
        Dim q = From c In categories Group Join p In products On c Equals p.Category Into ps = Group From p In ps.DefaultIfEmpty() Select New With {Key .Category = c, Key .ProductName = If(p Is Nothing, "(No products)", p.ProductName)}

        For Each v In q
            Console.WriteLine($"{v.Category}: {v.ProductName}")
        Next
#End Region
            Return 0
        End Function
    End Class


