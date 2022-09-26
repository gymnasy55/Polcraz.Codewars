let zeros n =
    let rec calc i count =
        if n / i >= 1
        then calc (i * 5) (count + n / i)
        else count
    calc 5 0
    
[<EntryPoint>]
let main _ =
    zeros 10 |> printfn "%A"
    0