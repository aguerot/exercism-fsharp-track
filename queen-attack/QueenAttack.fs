module QueenAttack

let coherceRange (value: int) = 
    match value with
        | value when value < 0 -> false
        | value when value > 7 -> false
        | _ -> true

let create (position: int * int) = 
    let (x, y) = position
    coherceRange(x) && coherceRange(y)

let canAttack (queen1: int * int) (queen2: int * int) = 
    match (queen1, queen2) with
        | ((x1, _), (x2, _)) when x1 = x2 -> true // vertical align
        | ((_, y1), (_, y2)) when y1 = y2 -> true // horizontal align
        | ((x1, y1), (x2, y2)) when abs(x2 - x1) = abs(y2 - y1) -> true // diagonal align
        | _ -> false