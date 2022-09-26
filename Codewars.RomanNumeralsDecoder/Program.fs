type RomanDigit = I | V | X | L | C | D | M
type ParsedChar =
    | Digit of RomanDigit
    | BadChar of char

let digitToInt =
    function
        | I -> 1
        | V -> 5
        | X -> 10
        | L -> 50
        | C -> 100
        | D -> 500
        | M -> 1000

let rec digitsToInt =
    function
        | [] -> 0
        | smaller :: larger :: ns when smaller < larger ->
            (digitToInt larger - digitToInt smaller)  + digitsToInt ns
        | digit :: ns ->
            digitToInt digit + digitsToInt ns

let toInt digits = digitsToInt digits

let charToRomanDigit =
    function
        | 'I' -> Digit I
        | 'V' -> Digit V
        | 'X' -> Digit X
        | 'L' -> Digit L
        | 'C' -> Digit C
        | 'D' -> Digit D
        | 'M' -> Digit M
        | ch -> BadChar ch
        
let toRomanDigitList (s: string) =
    s
    |> Seq.toList
    |> List.map charToRomanDigit

let toRomanNumeral s =
    toRomanDigitList s
    |> List.choose (
        function
            | Digit digit ->
                Some digit
            | BadChar ch ->
                eprintfn $"%c{ch} is not a valid character"
                None
        )

let FromRoman (romanNumeral: string) =
    toRomanNumeral romanNumeral
    |> toInt
    
[<EntryPoint>]
let main _ =
    FromRoman "XV" |> printfn "%A"
    0