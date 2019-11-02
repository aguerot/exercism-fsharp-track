module Raindrops

let convert number =

    let isFactor factor = number % factor = 0

    let mappings =
        [ (3, "Pling")
          (5, "Plang")
          (7, "Plong") ]

    mappings
    |> Seq.filter (fst >> isFactor)
    |> Seq.map snd
    |> String.concat ""
    |> function
    | "" -> number.ToString()
    | s -> s
