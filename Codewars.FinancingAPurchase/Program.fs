let amort (rate: double) (balance: double) (term: int) (numPayments: int) : string =
    let mRate = rate / 100.0 / 12.0
    let c = mRate * balance / (1.0 - pown (1.0 + mRate) (-term))
    let rec calc b i =
        match i with
        | x when x > 0 && x < numPayments -> calc (b - (c - mRate * b)) (i + 1)
        | _ -> b
    let b = calc balance 1
    sprintf "num_payment %d c %.0f princ %.0f int %.0f balance %.0f"
        <| numPayments
        <| c
        <| (c - mRate * b)
        <| (mRate * b)
        <| (b - (c - mRate * b))


[<EntryPoint>]
let main _ =
  amort 7.4 10215.0 24 20 |> printfn "%A"
  0