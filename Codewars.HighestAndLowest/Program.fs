let highAndLow (str : string) = 
    let array = str.Split[|' '|] |> Array.map (fun i -> i |> int)
    $"%i{Array.max array} %i{Array.min array}"
    
[<EntryPoint>]
let main _ =
    highAndLow "1 2 3 4 5" |> printfn "%A"
    0