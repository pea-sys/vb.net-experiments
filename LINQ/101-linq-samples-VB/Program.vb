
Module Program

    Sub Main()
        RunAll()
    End Sub


    Private Function RunAll() As Integer
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
        Call New Projections().SelectByCaseTuple()
        Call New Projections().SelectAnonymousConstructions()
        Call New Projections().SelectTupleConstructions()
        Call New Projections().SelectPropertySubset()
        Call New Projections().SelectWithIndex()
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
        Call New Groupings().GroupingSyntax()
        Call New Groupings().GroupByProperty()
        Call New Groupings().GroupByCategory()
        Call New Groupings().NestedGrouBy()
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
        Call New Quantifiers().GroupedAnyMatchedElements()
        Call New Quantifiers().AllMatchedElements()
        Call New Quantifiers().GroupedAllMatchedElements()

        ' Aggregators: 73 - 93 (75 is missing)
        Call New AggregateOperators().CountSyntax()
        Call New AggregateOperators().CountConditional()
        Call New AggregateOperators().NestedCount()
        Call New AggregateOperators().GroupedCount()
        Call New AggregateOperators().SumSyntax()
        Call New AggregateOperators().SumProjection()
        Call New AggregateOperators().SumGrouped()
        Call New AggregateOperators().MinSyntax()
        Call New AggregateOperators().MinProjection()
        Call New AggregateOperators().MinGrouped()
        Call New AggregateOperators().MinEachGroup()
        Call New AggregateOperators().MaxSyntax()
        Call New AggregateOperators().MaxProjection()
        Call New AggregateOperators().MaxGrouped()
        Call New AggregateOperators().MaxEachGroup()
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

        Console.WriteLine("Complete")
        Console.ReadKey()
        Return 0
    End Function
End Module

