module TwoFer

let composeOutput (input: string): string =
    "One for " + input + ", one for me."

let twoFer (input: string option): string = 
    match input with
        | Some name -> composeOutput(name)
        | None -> composeOutput("you") 
