Imports System
Imports System.Linq


Public Class QueryExecution
        Public Function DeferredExecution() As Integer
#Region "deferred-execution"
            ' Sequence operators form first-class queries that
            ' are not executed until you enumerate over them.

            Dim numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0}
            Dim i = 0
            Dim q = From n In numbers Select Threading.Interlocked.Increment(i)

            ' Note, the local variable 'i' is not incremented
            ' until each element is evaluated (as a side-effect):
            For Each v In q
                Console.WriteLine($"v = {v}, i = {i}")
            Next
#End Region
            Return 0
        End Function

        Public Function EagerExecution() As Integer
#Region "eager-execution"
            ' Methods like ToList() cause the query to be
            ' executed immediately, caching the results.

            Dim numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0}
            Dim i = 0
            Dim q = (From n In numbers Select Threading.Interlocked.Increment(i)).ToList()

            ' The local variable i has already been fully
            ' incremented before we iterate the results:
            For Each v In q
                Console.WriteLine($"v = {v}, i = {i}")
            Next
#End Region
            Return 0
        End Function

        Public Function ReuseQueryDefinition() As Integer
#Region "reuse-query"
            ' Deferred execution lets us define a query once
            ' and then reuse it later after data changes.

            Dim numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0}
            Dim lowNumbers = From n In numbers Where n <= 3 Select n
            Console.WriteLine("First run numbers <= 3:")

            For Each n In lowNumbers
                Console.WriteLine(n)
            Next

            For i = 0 To 9
                numbers(i) = -numbers(i)
            Next

            ' During this second run, the same query object,
            ' lowNumbers, will be iterating over the new state
            ' of numbers[], producing different results:
            Console.WriteLine("Second run numbers <= 3:")

            For Each n In lowNumbers
                Console.WriteLine(n)
            Next
#End Region
            Return 0
        End Function
    End Class
