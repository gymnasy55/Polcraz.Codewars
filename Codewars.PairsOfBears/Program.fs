let bears (x : int) (s : string) : string * bool =
    let rec loop (s : string) (i : int) (out : string list) (flag : bool) (acc : int) (x : int) =
        match i with
        | i when i >= 0 && i < s.Length - 1 ->
            let temp = [s.[i]; s.[i + 1]] |> List.map string |> List.reduce (+)
            if (temp = "B8" || temp = "8B") && (not flag) then
                loop s (i + 1) (out @ [temp]) true (acc + 1) x
            else
                loop s (i + 1) out false acc x
        | _ -> (out |> String.concat "", acc >= x)
        
    loop s 0 [] false 0 x
    
[<EntryPoint>]
let main _ =
    bears 1 "j8BmB88B88gkBBlf8hg8888lbe88" |> printfn "%A"
    0
