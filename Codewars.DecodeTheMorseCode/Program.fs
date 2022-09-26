open System

let split (sep: string[]) (str: string) = str.Split(sep, StringSplitOptions.None)

let decodeMorse (morseCode: string) =
    morseCode.Trim()
    |> split [|"  "|]
    |> Array.map (fun str -> str |> split [|" "|] |> Array.map MorseCode.get |> String.concat "")
    |> String.concat " "
    
[<EntryPoint>]
let main _ =
    decodeMorse ".... . -.--   .--- ..- -.. ." |> printfn "%A"
    0