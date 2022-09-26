let deleteNth array max_e =
    let cache = System.Collections.Generic.Dictionary<int, int> ()
    array |> List.filter (fun i ->
        cache.[i] <- if cache.ContainsKey i then cache.[i] + 1 else 1
        cache.[i] <= max_e
    )
    
[<EntryPoint>]
let main _ =
    deleteNth [1; 1; 3; 3; 3; 3; 1; 1; 7; 2; 2; 2; 2] 3 |> printfn "%A"
    0