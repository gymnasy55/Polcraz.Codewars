let mostFrequentDays (year: int) =
    let day = System.DateTime(year, 1, 1)
    if System.DateTime.IsLeapYear year then
        if day.DayOfWeek = System.DayOfWeek.Sunday then
            [ "Monday"; "Sunday" ]
        else
            [ day.ToString("dddd", System.Globalization.CultureInfo "en-US")
              day.AddDays(1.0).ToString("dddd", System.Globalization.CultureInfo "en-US") ]
    else [ day.ToString("dddd", System.Globalization.CultureInfo "en-US") ]


    
[<EntryPoint>]
let main _ =
    mostFrequentDays 1984 |> printfn "%A"
    mostFrequentDays 2016 |> printfn "%A"
    0