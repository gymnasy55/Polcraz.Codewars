let processNumber = function
    | x when x > 255 -> 255
    | x when x < 0 -> 0
    | x -> x

let toHex (str: int) = str.ToString("X").[1..]

let rgb r g b =
    (1 <<< 24)
    + ((processNumber r) <<< 16)
    + ((processNumber g) <<< 8)
    + processNumber b
    |> toHex
    
[<EntryPoint>]
let main _ =
    rgb 255 255 255 |> printfn "%A"
    0