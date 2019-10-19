module Raindrops

let convert (number: int): string = 

    let isFactor (factor: int) = number % factor = 0

    let mappings = [ (3, "Pling"); (5, "Plang"); (7, "Plong"); ] 

    mappings
        |> Seq.filter(fun (factor, _) -> isFactor(factor))
        |> Seq.map snd
        |> String.concat ""
        |> function "" -> number.ToString() | s -> s
