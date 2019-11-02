module TwoFer

let composeOutput input =
    sprintf "One for %s, one for me." input

let twoFer (input: string option): string = 
    input |> Option.defaultValue "you" |> composeOutput
