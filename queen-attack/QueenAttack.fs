module QueenAttack

let coherceRange value = 
    match value with
    | value when value < 0 -> false
    | value when value > 7 -> false
    | _ -> true

let create position = 
    let x, y = position
    coherceRange(x) && coherceRange(y)

let canAttack white black = 
    let sameRow = fst white = fst black
    let sameColumn = snd white = snd black
    let sameDiagonal = abs(fst black - fst white) = abs (snd black - snd white)

    sameRow || sameColumn || sameDiagonal