open System

let length (str: string) = str.Length

let mxdiflg (a1: String []) (a2: String []) : int Option =
    if a1 = [||] || a2 = [||] then
        None
    else
        let a1MinLength, a1MaxLength = a1 |> Array.minBy length |> length, a1 |> Array.maxBy length |> length
        let a2MinLength, a2MaxLength = a2 |> Array.minBy length |> length, a2 |> Array.maxBy length |> length
        Some <| max (abs (a2MaxLength - a1MinLength)) (abs (a1MaxLength - a2MinLength))

[<EntryPoint>]
let main _ =
    mxdiflg [| "hoqq"
               "bbllkw"
               "oox"
               "ejjuyyy"
               "plmiis"
               "xxxzgpsssa"
               "xxwwkktt"
               "znnnnfqknaz"
               "qqquuhii"
               "dvvvwz" |] [|
        "cccooommaaqqoxii"
        "gggqaffhhh"
        "tttoowwwmmww"
    |]
    |> printfn "%A"
    0
