open System

let accum (s: string) =
  s.ToLower()
  |> Seq.mapi (fun i char -> (Char.ToUpper char |> string) + String.replicate i (string char)) 
  |> String.concat "-"
  
