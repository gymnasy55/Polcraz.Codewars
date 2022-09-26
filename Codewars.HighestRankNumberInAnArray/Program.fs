open System.Linq

let highestRank (array: int[]) =
    array |> Array.sortDescending |> Array.maxBy (fun i -> array.Count(fun j -> i = j))

[<EntryPoint>]
let main _ =
    highestRank [|3; 3; 3; 12; 10; 8; 12; 7; 6; 4; 10; 12|] |> printfn "%A"
    0