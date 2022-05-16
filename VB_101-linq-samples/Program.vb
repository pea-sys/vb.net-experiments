Imports System

Namespace Try101LinqSamples
    Class Program
        Private Function GetFunction(ByVal Optional region As String = Nothing, ByVal Optional session As String = Nothing, ByVal Optional package As String = Nothing, ByVal Optional project As String = Nothing, ByVal Optional args As String() = Nothing) As Integer
            Select Case region
                Case "where-syntax" : Return New Restrictions().LowNumbers()
                Case "where-property" : Return New Restrictions().ProductsOutOfStock()
                Case "where-multiple-properties" : Return New Restrictions().ExpensiveProductsInStock()
                Case "where-drilldown" : Return New Restrictions().DisplayCustomerOrders()
                Case "where-indexed" : Return New Restrictions().IndexedWhere()
                Case "select-syntax" : Return New Projections().SelectSyntax()
                Case "select-property" : Return New Projections().SelectProperty()
                Case "select-transform" : Return New Projections().TransformWithSelect()
                Case "select-case-anonymous" : Return New Projections().SelectByCaseAnonymous()
                'Case "select-case-tuple" : Return New Projections().SelectByCaseTuple()
                Case "select-new-type" : Return New Projections().SelectAnonymousConstructions()
                'Case "select-new-type-tuple" : Return New Projections().SelectTupleConstructions()
                'Case "select-subset-properties" : Return New Projections().SelectPropertySubset()
               ' Case "select-with-index" : Return New Projections().SelectWithIndex()
                Case "select-with-where" : Return New Projections().SelectWithWhere()
                Case "select-many-syntax" : Return New Projections().SelectFromMultipleSequences()
                Case "select-many-drilldown" : Return New Projections().SelectFromChildSequence()
                Case "select-many-filter" : Return New Projections().SelectManyWithWhere()
                Case "select-many-assignment" : Return New Projections().SelectManyWhereAssignment()
                Case "multiple-where-clauses" : Return New Projections().SelectMultipleWhereClauses()
                Case "indexed-select-many" : Return New Projections().IndexedSelectMany()

                Case "take-syntax" : Return New Partitions().TakeSyntax()
                Case "nested-take" : Return New Partitions().NestedTake()
                Case "skip-syntax" : Return New Partitions().SkipSyntax()
                Case "nested-skip" : Return New Partitions().NestedSkip()
                Case "takewhile-syntax" : Return New Partitions().TakeWhileSyntax()
                Case "indexed-takewhile" : Return New Partitions().IndexedTakeWhile()
                Case "skipwhile-syntax" : Return New Partitions().SkipWhileSyntax()
                Case "indexed-skipwhile" : Return New Partitions().IndexedSkipWhile()

                Case "orderby-syntax" : Return New Orderings().OrderbySyntax()
                Case "orderby-property" : Return New Orderings().OrderbyProperty()
                Case "orderby-user-types" : Return New Orderings().OrderByProducts()
                Case "custom-comparer"
                    Select Case session
                        Case "orderby-custom" : Return New Orderings().OrderByWithCustomComparer()
                        Case "orderby-custom-descending" : Return New Orderings().DescendingCustomComparer()
                        Case "orderby-custom-thenby" : Return New Orderings().ThenByCustom()
                        Case "orderby-custom-descending-thenby" : Return New Orderings().CustomThenByDescending()
                        Case Else : Return MissingTag(session, False)
                    End Select
                Case "orderby-custom-comparer" : Return New Orderings().OrderByWithCustomComparer()
                Case "orderbydescending-syntax" : Return New Orderings().OrderByDescendingSyntax()
                Case "orderby-descending-type" : Return New Orderings().OrderProductsDescending()
                Case "desc-custom-comparer" : Return New Orderings().DescendingCustomComparer()
                Case "thenby-syntax" : Return New Orderings().ThenBySyntax()
                Case "thenby-custom" : Return New Orderings().ThenByCustom()
                Case "thenby-ordering" : Return New Orderings().ThenByDifferentOrdering()
                Case "thenby-custom-descending" : Return New Orderings().CustomThenByDescending()
                Case "reverse" : Return New Orderings().OrderingReversal()

                'Case "groupby-syntax" : Return New Groupings().GroupingSyntax()
                'Case "groupby-property" : Return New Groupings().GroupByProperty()
                'Case "groupby-category" : Return New Groupings().GroupByCategory()
                'Case "nested-groupby" : Return New Groupings().NestedGrouBy()
                Case "anagram-comparer"
                    Select Case session
                        Case "groupby-custom-comparer" : Return New Groupings().GroupByCustomComparer()
                        Case "nested-groupby-custom" : Return New Groupings().NestedGroupByCustom()
                        Case Else : Return MissingTag(session, False)
                    End Select
                Case "groupby-custom-comparer" : Return New Groupings().GroupByCustomComparer()
                Case "nested-groupby-custom" : Return New Groupings().NestedGroupByCustom()
                Case "distinct-syntax" : Return New SetOperations().DistinctSyntax()
                Case "distinct-property-values" : Return New SetOperations().DistinctPropertyValues()
                Case "union-syntax" : Return New SetOperations().UnionSyntax()
                Case "union-query-results" : Return New SetOperations().UnionOfQueryResults()
                Case "intersect-syntax" : Return New SetOperations().IntersectSynxtax()
                Case "intersect-different-queries" : Return New SetOperations().IntersectQueryResults()
                Case "difference-of-sets" : Return New SetOperations().DifferenceOfSets()
                Case "difference-of-queries" : Return New SetOperations().DifferenceOfQueries()
                Case "except-syntax" : Return New SetOperations().DifferenceOfSets()

                Case "convert-to-array" : Return New Conversions().ConvertToArray()
                Case "convert-to-list" : Return New Conversions().ConvertToList()
                Case "convert-to-dictionary" : Return New Conversions().ConvertToDictionary()
                Case "convert-to-type" : Return New Conversions().ConvertSelectedItems()

                Case "first-element" : Return New ElementOperations().FirstElement()
                Case "first-matching-element" >= New ElementOperations().FirstMatchingElement()
                Case "first-or-default" : Return New ElementOperations().MaybeFirstElement()
                Case "first-matching-or-default" >= New ElementOperations().MaybeFirstMatchingElement()
                Case "element-at" : Return New ElementOperations().ElementAtPosition()

                Case "generate-range" : Return New Generators().RangeOfIntegers()
                Case "generate-repeat" : Return New Generators().RepeatNumber()

                Case "any-matches" : Return New Quantifiers().AnyMatchingElements()
                'Case "any-grouped" : Return New Quantifiers().GroupedAnyMatchedElements()
                Case "all-match" : Return New Quantifiers().AllMatchedElements()
                'Case "all-grouped" : Return New Quantifiers().GroupedAllMatchedElements()

                Case "count-syntax" : Return New AggregateOperators().CountSyntax()
                Case "count-conditional" : Return New AggregateOperators().CountConditional()
                'Case "nested-count" : Return New AggregateOperators().NestedCount()
               ' Case "grouped-count" : Return New AggregateOperators().GroupedCount()
                Case "sum-syntax" : Return New AggregateOperators().SumSyntax()
                Case "sum-of-projection" : Return New AggregateOperators().SumProjection()
                'Case "grouped-sum" : Return New AggregateOperators().SumGrouped()
                Case "min-syntax" : Return New AggregateOperators().MinSyntax()
                Case "min-projection" : Return New AggregateOperators().MinProjection()
                'Case "min-grouped" : Return New AggregateOperators().MinGrouped()
                'Case "min-each-group" : Return New AggregateOperators().MinEachGroup()
                Case "max-syntax" : Return New AggregateOperators().MaxSyntax()
                Case "max-projection" : Return New AggregateOperators().MaxProjection()
                'Case "max-grouped" : Return New AggregateOperators().MaxGrouped()
                'Case "max-each-group" : Return New AggregateOperators().MaxEachGroup()
                Case "average-syntax" : Return New AggregateOperators().AverageSyntax()
                Case "average-projection" : Return New AggregateOperators().AverageProjection()
                Case "average-grouped" : Return New AggregateOperators().AverageGrouped()
                Case "aggregate-syntax" : Return New AggregateOperators().AggregateSyntax()
                Case "aggregate-seeded" : Return New AggregateOperators().SeededAggregate()

                Case "concat-series" : Return New SequenceOperations().ConcatSeries()
                Case "concat-projections" : Return New SequenceOperations().ConcatProjection()
                Case "equal-sequence" : Return New SequenceOperations().EqualSequence()
                Case "dot-product" : Return New SequenceOperations().DotProduct()

                Case "deferred-execution" : Return New QueryExecution().DeferredExecution()
                Case "eager-execution" >= New QueryExecution().EagerExecution()
                Case "reuse-query" : Return New QueryExecution().ReuseQueryDefinition()

                Case "cross-join" : Return New JoinOperations().CrossJoinQuery()
                Case "group-join" : Return New JoinOperations().GroupJoinQquery()
                Case "cross-group-join" : Return New JoinOperations().CrossGroupJoin()
                Case "left-outer-join" : Return New JoinOperations().LeftOuterJoin()
                Case Else : Return RunAll()
            End Select
        End Function
        ''' <paramname="region">Takes in the --region option from the code fence options in markdown</param>
        ''' <paramname="session">Takes in the --session option from the code fence options in markdown</param>
        ''' <paramname="package">Takes in the --package option from the code fence options in markdown</param>
        ''' <paramname="project">Takes in the --project option from the code fence options in markdown</param>
        ''' <paramname="args">Takes in any additional arguments passed in the code fence options in markdown</param>
        ''' <see>To learn more see <ahref="https://aka.ms/learntdn">our documentation</a></see>
        Public Sub Main()
            Dim region As String = Nothing, session As String = Nothing, package As String = Nothing, project As String = Nothing, args As String() = Nothing
            region = "where-syntax"
            GetFunction(region, session, package, project, args)
        End Sub

        Private Shared Function MissingTag(ByVal tag As String, ByVal Optional region As Boolean = True) As Integer
            Console.WriteLine($"No code snippet configured for {If(region, "region", "session")}: {tag}")
            Return 1
        End Function

        Private Shared Function RunAll() As Integer
            ' 1- 5
            Call New Restrictions().LowNumbers()
            Call New Restrictions().ProductsOutOfStock()
            Call New Restrictions().ExpensiveProductsInStock()
            Call New Restrictions().DisplayCustomerOrders()
            Call New Restrictions().IndexedWhere()

            ' 6 - 19 (+ 2 for tuples)
            Call New Projections().SelectSyntax()
            Call New Projections().SelectProperty()
            Call New Projections().TransformWithSelect()
            Call New Projections().SelectByCaseAnonymous()
            'Call New Projections().SelectByCaseTuple()
            Call New Projections().SelectAnonymousConstructions()
            'Call New Projections().SelectTupleConstructions()
            'Call New Projections().SelectPropertySubset()
            'Call New Projections().SelectWithIndex()
            Call New Projections().SelectWithWhere()
            Call New Projections().SelectFromMultipleSequences()
            Call New Projections().SelectFromChildSequence()
            Call New Projections().SelectManyWithWhere()
            Call New Projections().SelectManyWhereAssignment()
            Call New Projections().SelectMultipleWhereClauses()
            Call New Projections().IndexedSelectMany()

            ' 20 - 27
            Call New Partitions().TakeSyntax()
            Call New Partitions().NestedTake()
            Call New Partitions().SkipSyntax()
            Call New Partitions().NestedSkip()
            Call New Partitions().TakeWhileSyntax()
            Call New Partitions().IndexedTakeWhile()
            Call New Partitions().SkipWhileSyntax()
            Call New Partitions().IndexedSkipWhile()

            ' Ordering: 28-39
            Call New Orderings().OrderbySyntax()
            Call New Orderings().OrderbyProperty()
            Call New Orderings().OrderByProducts()
            Call New Orderings().OrderByWithCustomComparer()
            Call New Orderings().OrderByDescendingSyntax()
            Call New Orderings().OrderProductsDescending()
            Call New Orderings().DescendingCustomComparer()
            Call New Orderings().ThenBySyntax()
            Call New Orderings().ThenByCustom()
            Call New Orderings().ThenByDifferentOrdering()
            Call New Orderings().CustomThenByDescending()
            Call New Orderings().OrderingReversal()

            ' Grouping: 40 - 45
            'Call New Groupings().GroupingSyntax()
            'Call New Groupings().GroupByProperty()
            'Call New Groupings().GroupByCategory()
            'Call New Groupings().NestedGrouBy()
            Call New Groupings().GroupByCustomComparer()
            Call New Groupings().NestedGroupByCustom()

            ' Set operations: 46 - 53
            Call New SetOperations().DistinctSyntax()
            Call New SetOperations().DistinctPropertyValues()
            Call New SetOperations().UnionSyntax()
            Call New SetOperations().UnionOfQueryResults()
            Call New SetOperations().IntersectSynxtax()
            Call New SetOperations().IntersectQueryResults()
            Call New SetOperations().DifferenceOfSets()
            Call New SetOperations().DifferenceOfQueries()

            ' Conversion Operators: 54 - 57
            Call New Conversions().ConvertToArray()
            Call New Conversions().ConvertToList()
            Call New Conversions().ConvertToDictionary()
            Call New Conversions().ConvertSelectedItems()

            ' Element operators: 58-64 (60 is missing.)
            Call New ElementOperations().FirstElement()
            Call New ElementOperations().FirstMatchingElement()
            Call New ElementOperations().MaybeFirstElement()
            Call New ElementOperations().MaybeFirstMatchingElement()
            Call New ElementOperations().ElementAtPosition()

            ' Generator operators: 65,66
            Call New Generators().RangeOfIntegers()
            Call New Generators().RepeatNumber()

            ' Quantifiers: 67 - 72 (68 and 71 are missing)
            Call New Quantifiers().AnyMatchingElements()
            'Call New Quantifiers().GroupedAnyMatchedElements()
            Call New Quantifiers().AllMatchedElements()
            'Call New Quantifiers().GroupedAllMatchedElements()

            ' Aggregators: 73 - 93 (75 is missing)
            Call New AggregateOperators().CountSyntax()
            Call New AggregateOperators().CountConditional()
            'Call New AggregateOperators().NestedCount()
            'Call New AggregateOperators().GroupedCount()
            Call New AggregateOperators().SumSyntax()
            Call New AggregateOperators().SumProjection()
            'Call New AggregateOperators().SumGrouped()
            Call New AggregateOperators().MinSyntax()
            Call New AggregateOperators().MinProjection()
            'Call New AggregateOperators().MinGrouped()
            'Call New AggregateOperators().MinEachGroup()
            Call New AggregateOperators().MaxSyntax()
            Call New AggregateOperators().MaxProjection()
            'Call New AggregateOperators().MaxGrouped()
            'Call New AggregateOperators().MaxEachGroup()
            Call New AggregateOperators().AverageSyntax()
            Call New AggregateOperators().AverageProjection()
            Call New AggregateOperators().AverageGrouped()
            Call New AggregateOperators().AggregateSyntax()

            ' Miscellaneous:
            Call New SequenceOperations().ConcatSeries()
            Call New SequenceOperations().ConcatProjection()
            Call New SequenceOperations().EqualSequence()
            Call New SequenceOperations().Linq97()
            Call New QueryExecution().DeferredExecution()
            Call New QueryExecution().EagerExecution()
            Call New QueryExecution().ReuseQueryDefinition()
            Call New JoinOperations().CrossJoinQuery()
            Call New JoinOperations().GroupJoinQquery()
            Call New JoinOperations().CrossGroupJoin()
            Call New JoinOperations().LeftOuterJoin()
            Return 0
        End Function
    End Class
End Namespace
