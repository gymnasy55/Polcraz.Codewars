let rec squares length width seq =
    let x, y = min length width, max length width
    if x <= 0 then seq |> List.rev
    else squares x (y - x) (x :: seq)

let squaresInRect length width =
  if length = width then None
  else Some (squares length width [])
  
[<EntryPoint>]
let main _ =
    squaresInRect 5 3 |> printfn "%A"
    0