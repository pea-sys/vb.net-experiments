#LINQ のデバッグ

次のようなコードをデバッグしたい場合、  
num + 1 にカーソルを当てて、F9 ボタンを押すだけです。

```
    Sub Main()
        Dim numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0}
        Dim lowNums = From num In numbers Where num < 5 Select num + 1
        For Each x In lowNums
            Console.WriteLine(x)
        Next
    End Sub
```

デバッグでステップを進めると、Console.WriteLine と num + 1 を往復します。

短いけど、以上。
