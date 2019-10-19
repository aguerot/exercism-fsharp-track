module Accumulate

let rec accumulate (func: 'a -> 'b) (input: 'a list): 'b list = 
    match input with
        | [] -> []      // quit when all processed
        | item :: remaining -> (func item) :: (accumulate func remaining) // extract first item , apply and process remaining