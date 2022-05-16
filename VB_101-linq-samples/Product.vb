Public Class Product
    Public Property ProductID As Integer
    Public Property ProductName As String
    Public Property Category As String
    Public Property UnitPrice As Decimal
    Public Property UnitsInStock As Integer

    Public Overrides Function ToString() As String
        Return $"ProductID={ProductID} ProductName={ProductName} Category={Category} UnitPrice={UnitPrice} UnitsInStock={UnitsInStock}"
    End Function
End Class
