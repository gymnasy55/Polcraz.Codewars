let simpson (n: int) : float =
    let f x = (3.0 / 2.0) * pown (sin x) 3
    let h x = System.Math.PI / (x * (n |> float))

    f 0.0
    |> (+) (f System.Math.PI)
    |> (+)
        (
            [ for i in 1 .. (n / 2) -> ((i |> float) * 2.0 - 1.0) * h 1.0 ]
            |> List.map f
            |> List.sum
            |> (*) 4.0
        )
    |> (+)
        (
            [ for i in 1 .. (n / 2) - 1 -> ((i |> float) * 2.0) * h 1.0 ]
            |> List.map f
            |> List.sum
            |> (*) 2.0
        )
    |> (*) (h 3.0)

[<EntryPoint>]
let main _ =
    simpson 10 |> printfn "%A"
    0