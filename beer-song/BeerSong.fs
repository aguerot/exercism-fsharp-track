module BeerSong

let singVerse (verseNumber) =
    match verseNumber with
    | 0 ->
        [ ""
          "No more bottles of beer on the wall, no more bottles of beer."
          "Go to the store and buy some more, 99 bottles of beer on the wall."
        ]
    | 1 ->
        [ ""
          "1 bottle of beer on the wall, 1 bottle of beer."
          "Take it down and pass it around, no more bottles of beer on the wall." ]
    | 2 ->
        [ ""
          "2 bottles of beer on the wall, 2 bottles of beer."
          "Take one down and pass it around, 1 bottle of beer on the wall." ]
    | _ ->
        [ ""
          sprintf "%i bottles of beer on the wall, %i bottles of beer." verseNumber verseNumber
          sprintf "Take one down and pass it around, %i bottles of beer on the wall." (verseNumber - 1) ]

let recite (startBottles: int) (takeDown: int) =
    let lowerLimit = startBottles - takeDown + 1

    [ startBottles .. -1 .. lowerLimit ]
    |> List.collect singVerse
    |> List.tail
