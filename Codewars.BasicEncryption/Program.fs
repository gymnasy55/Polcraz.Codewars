let encrypt (rule : int) (str : string) : string = 
    str
    |> Seq.map (fun c -> c |> int |> (+) rule |> fun i -> i % 256 |> char)
    |> System.String.Concat
    
[<EntryPoint>]
let main _ =
    encrypt 2 "please encrypt me" |> printfn "%A"
    encrypt 1 "a" |> printfn "%A"
    0