Imports System.Collections.Generic

Namespace Try101LinqSamples
    Public Class Product
        Public Property ProductID As Integer
        Public Property ProductName As String
        Public Property Category As String
        Public Property UnitPrice As Decimal
        Public Property UnitsInStock As Integer

        Public Overrides Function ToString() As String
            Return $"ProductID={ProductID} ProductName={ProductName} Category={Category} UnitPrice={UnitPrice:C2} UnitsInStock={UnitsInStock}"
        End Function
    End Class

    Public Module Products
        Public ReadOnly Property ProductList As List(Of Product) = New List(Of Product) From {
            New Product With {
                .ProductID = 1,
                .ProductName = "Chai",
                .Category = "Beverages",
                .UnitPrice = 18.0000D,
                .UnitsInStock = 39
            },
            New Product With {
                .ProductID = 2,
                .ProductName = "Chang",
                .Category = "Beverages",
                .UnitPrice = 19.0000D,
                .UnitsInStock = 17
            },
            New Product With {
                .ProductID = 3,
                .ProductName = "Aniseed Syrup",
                .Category = "Condiments",
                .UnitPrice = 10.0000D,
                .UnitsInStock = 13
            },
            New Product With {
                .ProductID = 4,
                .ProductName = "Chef Anton's Cajun Seasoning",
                .Category = "Condiments",
                .UnitPrice = 22.0000D,
                .UnitsInStock = 53
            },
            New Product With {
                .ProductID = 5,
                .ProductName = "Chef Anton's Gumbo Mix",
                .Category = "Condiments",
                .UnitPrice = 21.3500D,
                .UnitsInStock = 0
            },
            New Product With {
                .ProductID = 6,
                .ProductName = "Grandma's Boysenberry Spread",
                .Category = "Condiments",
                .UnitPrice = 25.0000D,
                .UnitsInStock = 120
            },
            New Product With {
                .ProductID = 7,
                .ProductName = "Uncle Bob's Organic Dried Pears",
                .Category = "Produce",
                .UnitPrice = 30.0000D,
                .UnitsInStock = 15
            },
            New Product With {
                .ProductID = 8,
                .ProductName = "Northwoods Cranberry Sauce",
                .Category = "Condiments",
                .UnitPrice = 40.0000D,
                .UnitsInStock = 6
            },
            New Product With {
                .ProductID = 9,
                .ProductName = "Mishi Kobe Niku",
                .Category = "Meat/Poultry",
                .UnitPrice = 97.0000D,
                .UnitsInStock = 29
            },
            New Product With {
                .ProductID = 10,
                .ProductName = "Ikura",
                .Category = "Seafood",
                .UnitPrice = 31.0000D,
                .UnitsInStock = 31
            },
            New Product With {
                .ProductID = 11,
                .ProductName = "Queso Cabrales",
                .Category = "Dairy Products",
                .UnitPrice = 21.0000D,
                .UnitsInStock = 22
            },
            New Product With {
                .ProductID = 12,
                .ProductName = "Queso Manchego La Pastora",
                .Category = "Dairy Products",
                .UnitPrice = 38.0000D,
                .UnitsInStock = 86
            },
            New Product With {
                .ProductID = 13,
                .ProductName = "Konbu",
                .Category = "Seafood",
                .UnitPrice = 6.0000D,
                .UnitsInStock = 24
            },
            New Product With {
                .ProductID = 14,
                .ProductName = "Tofu",
                .Category = "Produce",
                .UnitPrice = 23.2500D,
                .UnitsInStock = 35
            },
            New Product With {
                .ProductID = 15,
                .ProductName = "Genen Shouyu",
                .Category = "Condiments",
                .UnitPrice = 15.5000D,
                .UnitsInStock = 39
            },
            New Product With {
                .ProductID = 16,
                .ProductName = "Pavlova",
                .Category = "Confections",
                .UnitPrice = 17.4500D,
                .UnitsInStock = 29
            },
            New Product With {
                .ProductID = 17,
                .ProductName = "Alice Mutton",
                .Category = "Meat/Poultry",
                .UnitPrice = 39.0000D,
                .UnitsInStock = 0
            },
            New Product With {
                .ProductID = 18,
                .ProductName = "Carnarvon Tigers",
                .Category = "Seafood",
                .UnitPrice = 62.5000D,
                .UnitsInStock = 42
            },
            New Product With {
                .ProductID = 19,
                .ProductName = "Teatime Chocolate Biscuits",
                .Category = "Confections",
                .UnitPrice = 9.2000D,
                .UnitsInStock = 25
            },
            New Product With {
                .ProductID = 20,
                .ProductName = "Sir Rodney's Marmalade",
                .Category = "Confections",
                .UnitPrice = 81.0000D,
                .UnitsInStock = 40
            },
            New Product With {
                .ProductID = 21,
                .ProductName = "Sir Rodney's Scones",
                .Category = "Confections",
                .UnitPrice = 10.0000D,
                .UnitsInStock = 3
            },
            New Product With {
                .ProductID = 22,
                .ProductName = "Gustaf's Knäckebröd",
                .Category = "Grains/Cereals",
                .UnitPrice = 21.0000D,
                .UnitsInStock = 104
            },
            New Product With {
                .ProductID = 23,
                .ProductName = "Tunnbröd",
                .Category = "Grains/Cereals",
                .UnitPrice = 9.0000D,
                .UnitsInStock = 61
            },
            New Product With {
                .ProductID = 24,
                .ProductName = "Guaraná Fantástica",
                .Category = "Beverages",
                .UnitPrice = 4.5000D,
                .UnitsInStock = 20
            },
            New Product With {
                .ProductID = 25,
                .ProductName = "NuNuCa Nuß-Nougat-Creme",
                .Category = "Confections",
                .UnitPrice = 14.0000D,
                .UnitsInStock = 76
            },
            New Product With {
                .ProductID = 26,
                .ProductName = "Gumbär Gummibärchen",
                .Category = "Confections",
                .UnitPrice = 31.2300D,
                .UnitsInStock = 15
            },
            New Product With {
                .ProductID = 27,
                .ProductName = "Schoggi Schokolade",
                .Category = "Confections",
                .UnitPrice = 43.9000D,
                .UnitsInStock = 49
            },
            New Product With {
                .ProductID = 28,
                .ProductName = "Rössle Sauerkraut",
                .Category = "Produce",
                .UnitPrice = 45.6000D,
                .UnitsInStock = 26
            },
            New Product With {
                .ProductID = 29,
                .ProductName = "Thüringer Rostbratwurst",
                .Category = "Meat/Poultry",
                .UnitPrice = 123.7900D,
                .UnitsInStock = 0
            },
            New Product With {
                .ProductID = 30,
                .ProductName = "Nord-Ost Matjeshering",
                .Category = "Seafood",
                .UnitPrice = 25.8900D,
                .UnitsInStock = 10
            },
            New Product With {
                .ProductID = 31,
                .ProductName = "Gorgonzola Telino",
                .Category = "Dairy Products",
                .UnitPrice = 12.5000D,
                .UnitsInStock = 0
            },
            New Product With {
                .ProductID = 32,
                .ProductName = "Mascarpone Fabioli",
                .Category = "Dairy Products",
                .UnitPrice = 32.0000D,
                .UnitsInStock = 9
            },
            New Product With {
                .ProductID = 33,
                .ProductName = "Geitost",
                .Category = "Dairy Products",
                .UnitPrice = 2.5000D,
                .UnitsInStock = 112
            },
            New Product With {
                .ProductID = 34,
                .ProductName = "Sasquatch Ale",
                .Category = "Beverages",
                .UnitPrice = 14.0000D,
                .UnitsInStock = 111
            },
            New Product With {
                .ProductID = 35,
                .ProductName = "Steeleye Stout",
                .Category = "Beverages",
                .UnitPrice = 18.0000D,
                .UnitsInStock = 20
            },
            New Product With {
                .ProductID = 36,
                .ProductName = "Inlagd Sill",
                .Category = "Seafood",
                .UnitPrice = 19.0000D,
                .UnitsInStock = 112
            },
            New Product With {
                .ProductID = 37,
                .ProductName = "Gravad lax",
                .Category = "Seafood",
                .UnitPrice = 26.0000D,
                .UnitsInStock = 11
            },
            New Product With {
                .ProductID = 38,
                .ProductName = "Côte de Blaye",
                .Category = "Beverages",
                .UnitPrice = 263.5000D,
                .UnitsInStock = 17
            },
            New Product With {
                .ProductID = 39,
                .ProductName = "Chartreuse verte",
                .Category = "Beverages",
                .UnitPrice = 18.0000D,
                .UnitsInStock = 69
            },
            New Product With {
                .ProductID = 40,
                .ProductName = "Boston Crab Meat",
                .Category = "Seafood",
                .UnitPrice = 18.4000D,
                .UnitsInStock = 123
            },
            New Product With {
                .ProductID = 41,
                .ProductName = "Jack's New England Clam Chowder",
                .Category = "Seafood",
                .UnitPrice = 9.6500D,
                .UnitsInStock = 85
            },
            New Product With {
                .ProductID = 42,
                .ProductName = "Singaporean Hokkien Fried Mee",
                .Category = "Grains/Cereals",
                .UnitPrice = 14.0000D,
                .UnitsInStock = 26
            },
            New Product With {
                .ProductID = 43,
                .ProductName = "Ipoh Coffee",
                .Category = "Beverages",
                .UnitPrice = 46.0000D,
                .UnitsInStock = 17
            },
            New Product With {
                .ProductID = 44,
                .ProductName = "Gula Malacca",
                .Category = "Condiments",
                .UnitPrice = 19.4500D,
                .UnitsInStock = 27
            },
            New Product With {
                .ProductID = 45,
                .ProductName = "Rogede sild",
                .Category = "Seafood",
                .UnitPrice = 9.5000D,
                .UnitsInStock = 5
            },
            New Product With {
                .ProductID = 46,
                .ProductName = "Spegesild",
                .Category = "Seafood",
                .UnitPrice = 12.0000D,
                .UnitsInStock = 95
            },
            New Product With {
                .ProductID = 47,
                .ProductName = "Zaanse koeken",
                .Category = "Confections",
                .UnitPrice = 9.5000D,
                .UnitsInStock = 36
            },
            New Product With {
                .ProductID = 48,
                .ProductName = "Chocolade",
                .Category = "Confections",
                .UnitPrice = 12.7500D,
                .UnitsInStock = 15
            },
            New Product With {
                .ProductID = 49,
                .ProductName = "Maxilaku",
                .Category = "Confections",
                .UnitPrice = 20.0000D,
                .UnitsInStock = 10
            },
            New Product With {
                .ProductID = 50,
                .ProductName = "Valkoinen suklaa",
                .Category = "Confections",
                .UnitPrice = 16.2500D,
                .UnitsInStock = 65
            },
            New Product With {
                .ProductID = 51,
                .ProductName = "Manjimup Dried Apples",
                .Category = "Produce",
                .UnitPrice = 53.0000D,
                .UnitsInStock = 20
            },
            New Product With {
                .ProductID = 52,
                .ProductName = "Filo Mix",
                .Category = "Grains/Cereals",
                .UnitPrice = 7.0000D,
                .UnitsInStock = 38
            },
            New Product With {
                .ProductID = 53,
                .ProductName = "Perth Pasties",
                .Category = "Meat/Poultry",
                .UnitPrice = 32.8000D,
                .UnitsInStock = 0
            },
            New Product With {
                .ProductID = 54,
                .ProductName = "Tourtière",
                .Category = "Meat/Poultry",
                .UnitPrice = 7.4500D,
                .UnitsInStock = 21
            },
            New Product With {
                .ProductID = 55,
                .ProductName = "Pâté chinois",
                .Category = "Meat/Poultry",
                .UnitPrice = 24.0000D,
                .UnitsInStock = 115
            },
            New Product With {
                .ProductID = 56,
                .ProductName = "Gnocchi di nonna Alice",
                .Category = "Grains/Cereals",
                .UnitPrice = 38.0000D,
                .UnitsInStock = 21
            },
            New Product With {
                .ProductID = 57,
                .ProductName = "Ravioli Angelo",
                .Category = "Grains/Cereals",
                .UnitPrice = 19.5000D,
                .UnitsInStock = 36
            },
            New Product With {
                .ProductID = 58,
                .ProductName = "Escargots de Bourgogne",
                .Category = "Seafood",
                .UnitPrice = 13.2500D,
                .UnitsInStock = 62
            },
            New Product With {
                .ProductID = 59,
                .ProductName = "Raclette Courdavault",
                .Category = "Dairy Products",
                .UnitPrice = 55.0000D,
                .UnitsInStock = 79
            },
            New Product With {
                .ProductID = 60,
                .ProductName = "Camembert Pierrot",
                .Category = "Dairy Products",
                .UnitPrice = 34.0000D,
                .UnitsInStock = 19
            },
            New Product With {
                .ProductID = 61,
                .ProductName = "Sirop d'érable",
                .Category = "Condiments",
                .UnitPrice = 28.5000D,
                .UnitsInStock = 113
            },
            New Product With {
                .ProductID = 62,
                .ProductName = "Tarte au sucre",
                .Category = "Confections",
                .UnitPrice = 49.3000D,
                .UnitsInStock = 17
            },
            New Product With {
                .ProductID = 63,
                .ProductName = "Vegie-spread",
                .Category = "Condiments",
                .UnitPrice = 43.9000D,
                .UnitsInStock = 24
            },
            New Product With {
                .ProductID = 64,
                .ProductName = "Wimmers gute Semmelknödel",
                .Category = "Grains/Cereals",
                .UnitPrice = 33.2500D,
                .UnitsInStock = 22
            },
            New Product With {
                .ProductID = 65,
                .ProductName = "Louisiana Fiery Hot Pepper Sauce",
                .Category = "Condiments",
                .UnitPrice = 21.0500D,
                .UnitsInStock = 76
            },
            New Product With {
                .ProductID = 66,
                .ProductName = "Louisiana Hot Spiced Okra",
                .Category = "Condiments",
                .UnitPrice = 17.0000D,
                .UnitsInStock = 4
            },
            New Product With {
                .ProductID = 67,
                .ProductName = "Laughing Lumberjack Lager",
                .Category = "Beverages",
                .UnitPrice = 14.0000D,
                .UnitsInStock = 52
            },
            New Product With {
                .ProductID = 68,
                .ProductName = "Scottish Longbreads",
                .Category = "Confections",
                .UnitPrice = 12.5000D,
                .UnitsInStock = 6
            },
            New Product With {
                .ProductID = 69,
                .ProductName = "Gudbrandsdalsost",
                .Category = "Dairy Products",
                .UnitPrice = 36.0000D,
                .UnitsInStock = 26
            },
            New Product With {
                .ProductID = 70,
                .ProductName = "Outback Lager",
                .Category = "Beverages",
                .UnitPrice = 15.0000D,
                .UnitsInStock = 15
            },
            New Product With {
                .ProductID = 71,
                .ProductName = "Flotemysost",
                .Category = "Dairy Products",
                .UnitPrice = 21.5000D,
                .UnitsInStock = 26
            },
            New Product With {
                .ProductID = 72,
                .ProductName = "Mozzarella di Giovanni",
                .Category = "Dairy Products",
                .UnitPrice = 34.8000D,
                .UnitsInStock = 14
            },
            New Product With {
                .ProductID = 73,
                .ProductName = "Röd Kaviar",
                .Category = "Seafood",
                .UnitPrice = 15.0000D,
                .UnitsInStock = 101
            },
            New Product With {
                .ProductID = 74,
                .ProductName = "Longlife Tofu",
                .Category = "Produce",
                .UnitPrice = 10.0000D,
                .UnitsInStock = 4
            },
            New Product With {
                .ProductID = 75,
                .ProductName = "Rhönbräu Klosterbier",
                .Category = "Beverages",
                .UnitPrice = 7.7500D,
                .UnitsInStock = 125
            },
            New Product With {
                .ProductID = 76,
                .ProductName = "Lakkalikööri",
                .Category = "Beverages",
                .UnitPrice = 18.0000D,
                .UnitsInStock = 57
            },
            New Product With {
                .ProductID = 77,
                .ProductName = "Original Frankfurter grüne Soße",
                .Category = "Condiments",
                .UnitPrice = 13.0000D,
                .UnitsInStock = 32
            }
        }
    End Module
End Namespace
