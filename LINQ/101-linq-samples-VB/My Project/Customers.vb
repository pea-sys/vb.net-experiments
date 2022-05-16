Imports System.Collections.Generic
Imports System.Linq
Imports System.Xml.Linq

Namespace Try101LinqSamples
    Public Class Customer
        Public Property CustomerID As String
        Public Property CompanyName As String
        Public Property Address As String
        Public Property City As String
        Public Property Region As String
        Public Property PostalCode As String
        Public Property Country As String
        Public Property Phone As String
        Public Property Orders As Order()

        Public Overrides Function ToString() As String
            Return $"{CustomerID} {CompanyName}
{Address}
{City}, {Region} {PostalCode} {Country}
{Phone}"
        End Function
    End Class

    Public Class Order
        Public Property OrderID As Integer
        Public Property OrderDate As Date
        Public Property Total As Decimal

        Public Overrides Function ToString() As String
            Return $"{OrderID}: {OrderDate:d} for {Total:C2}"
        End Function
    End Class

    Public Module Customers
        Public ReadOnly Property CustomerList As List(Of Customer) = (From e In XDocument.Parse(CustomersXml).Root.Elements("customer") Select New Customer With {
            .CustomerID = CStr(e.Element("id")),
            .CompanyName = CStr(e.Element("name")),
            .Address = CStr(e.Element("address")),
            .City = CStr(e.Element("city")),
            .Region = CStr(e.Element("region")),
            .PostalCode = CStr(e.Element("postalcode")),
            .Country = CStr(e.Element("country")),
            .Phone = CStr(e.Element("phone")),
            .Orders = (From o In e.Elements("orders").Elements("order") Select New Order With {
                .OrderID = CInt(o.Element("id")),
                .OrderDate = CDate(o.Element("orderdate")),
                .Total = CDec(o.Element("total"))
            }).ToArray()
        }).ToList()
    End Module
End Namespace
