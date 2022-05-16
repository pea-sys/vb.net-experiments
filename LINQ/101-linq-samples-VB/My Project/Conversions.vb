Imports System
Imports System.Linq

Namespace Try101LinqSamples
    Public Class Conversions
        Public Function ConvertToArray() As Integer
#Region "convert-to-array"
            Dim doubles = {1.7, 2.3, 1.9, 4.1, 2.9}
            Dim sortedDoubles = From d In doubles Order By d Select d
            Dim doublesArray = sortedDoubles.ToArray()
            Console.WriteLine("Every other double from highest to lowest:")

            For d = 0 To doublesArray.Length - 1 Step 2
                Console.WriteLine(doublesArray(d))
            Next
#End Region
            Return 0
        End Function

        Public Function ConvertToList() As Integer
#Region "convert-to-list"
            Dim words = {"cherry", "apple", "blueberry"}
            Dim sortedWords = From w In words Order By w Select w
            Dim wordList = sortedWords.ToList()
            Console.WriteLine("The sorted word list:")

            For Each w In wordList
                Console.WriteLine(w)
            Next
#End Region
            Return 0
        End Function

        Public Function ConvertToDictionary() As Integer
#Region "convert-to-dictionary"
            Dim scoreRecords = {New With {
                .Name = "Alice",
                .Score = 50
            }, New With {
                .Name = "Bob",
                .Score = 40
            }, New With {
                .Name = "Cathy",
                .Score = 45
            }}
            Dim scoreRecordsDict = scoreRecords.ToDictionary(Function(sr) sr.Name)
            Console.WriteLine("Bob's score: {0}", scoreRecordsDict("Bob"))
#End Region
            Return 0
        End Function

        Public Function ConvertSelectedItems() As Integer
#Region "convert-to-type"
            Dim numbers = {Nothing, 1.0, "two", 3, "four", 5, "six", 7.0}
            Dim doubles = numbers.OfType(Of Double)()
            Console.WriteLine("Numbers stored as doubles:")

            For Each d In doubles
                Console.WriteLine(d)
            Next
#End Region
            Return 0
        End Function
    End Class
End Namespace
