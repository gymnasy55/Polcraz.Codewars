let solve n =
    seq { 1 .. n - 1 }
    |> Seq.filter (fun i -> i % 3 = 0 || i % 5 = 0)
    |> Seq.sum
    
[<EntryPoint>]
let main _ =
    solve 100 |> printfn "%A"
    0