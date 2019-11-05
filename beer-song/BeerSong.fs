module BeerSong

let singVerse (verseNumber) =
    match verseNumber with
    | 0 ->
        [ yield "No more bottles of beer on the wall, no more bottles of beer."
          yield "Go to the store and buy some more, 99 bottles of beer on the wall."
          yield "" ]
    | 1 ->
        [ yield "1 bottle of beer on the wall, 1 bottle of beer."
          yield "Take it down and pass it around, no more bottles of beer on the wall."
          yield "" ]
    | 2 ->
        [ yield "2 bottles of beer on the wall, 2 bottles of beer."
          yield "Take one down and pass it around, 1 bottle of beer on the wall."
          yield "" ]
    | _ ->
        [ yield sprintf "%i bottles of beer on the wall, %i bottles of beer." verseNumber verseNumber
          yield sprintf "Take one down and pass it around, %i bottles of beer on the wall." (verseNumber - 1)
          yield "" ]

let recite (startBottles: int) (takeDown: int) =
    let lowerLimit = startBottles - takeDown + 1

    [ startBottles .. -1 .. lowerLimit ] |> List.collect singVerse |> List.rev |> List.tail |> List.rev