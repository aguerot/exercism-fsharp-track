module Bob

open System.Text.RegularExpressions

let response (input: string): string = 
    let clean = input.Trim()
    match clean with 
        | clean when Regex.IsMatch(clean, "[A-Z]{3,}.*\?$") -> "Calm down, I know what I'm doing!"
        | clean when Regex.IsMatch(clean, "^[^a-z]*[A-Z]{2,}[^a-z]*[^\?]$") -> "Whoa, chill out!"
        | clean when Regex.IsMatch(clean, "\?\s*$") -> "Sure."
        | clean when Regex.IsMatch(clean, "^\s*$") -> "Fine. Be that way!"
        | _ -> "Whatever."

// module Bob

// let (|MatchesRegex|) pattern input = 
//     System.Text.RegularExpressions.Regex.IsMatch(input, pattern)
    
// let response (input: string): string = 
//     match input with
//     | MatchesRegex "[A-Z]{3,}.*\?$" true                    -> "Calm down, I know what I'm doing!"
//     | MatchesRegex "^[^a-z]*[A-Z]{2,}[^a-z]*[^\?]$" true    -> "Whoa, chill out!"
//     | MatchesRegex "\?\s*$" true                            -> "Sure."
//     | MatchesRegex "^\s*$" true                             -> "Fine. Be that way!"
//     | _                                                     -> "Whatever."