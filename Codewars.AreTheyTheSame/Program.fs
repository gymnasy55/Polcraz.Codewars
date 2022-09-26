let comp(a, b) =
    match (a, b) with
    | x, y when (x |> List.length) = (y |> List.length) -> List.forall2 (fun i j -> i = j)
                                                             <| (a |> List.map (fun i -> i * i) |> List.sort)
                                                             <| (b |> List.sort)
    | _ -> false
    
[<EntryPoint>]
let main _ =
    comp ([1; 2], [1; 4]) |> printfn "%A";
    0