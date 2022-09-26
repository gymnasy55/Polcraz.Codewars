open System

let toInt (c: char) = int c - int '0'
let getASCIILetter i = (if i > 90 then i % 91 + 65 else i) |> char

let playPass s shift =
    s |> String.mapi (fun i ch -> if Char.IsDigit ch then
                                        ch
                                        |> toInt
                                        |> (-) 9
                                        |> string
                                        |> char
                                  elif Char.IsLetter ch then
                                        ch // берем символ
                                        |> int // ASCII в int
                                        |> (+) (shift % 26) // двигаем
                                        |> getASCIILetter // int в ASCII
                                        |> if i % 2 = 0 then Char.ToUpper else Char.ToLower
                                  else ch)
    |> Seq.rev
    |> Seq.map string
    |> String.concat ""

[<EntryPoint>]
let main _ =
    playPass "BORN IN 2015!" 1 |> printfn "%A"
    0