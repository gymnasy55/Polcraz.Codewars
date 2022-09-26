let race v1 v2 g =
    if v1 >= v2 then
        None
    else
        let v1s, v2s = float v1 / 3600.0, float v2 / 3600.0
        let mutable seconds = 1.0
        while v1s * seconds + float g > v2s * seconds do seconds <- seconds + 1.0
        let time = System.TimeSpan.FromSeconds seconds
        let secs = if time.Seconds = 0 then 0 else time.Seconds - 1
        Some [int <| floor time.TotalHours; time.Minutes; secs]
        
    
[<EntryPoint>]
let main _ =
    race 497 503 211 |> printfn "%A"
    race 720 850 70 |> printfn "%A"
    race 80 100 40 |> printfn "%A"
    race 80 91 37 |> printfn "%A"
    race 80 80 3700 |> printfn "%A"
    0