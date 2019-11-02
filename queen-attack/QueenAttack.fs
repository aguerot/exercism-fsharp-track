module QueenAttack

let coherceRange value = value >= 0 && value <= 7

let create position =
    let x, y = position
    coherceRange x && coherceRange y

let canAttack white black =
    let whiteRow, whiteColumn = white
    let blackRow, blackColumn = black

    whiteRow = blackRow             // same row
    || whiteColumn = blackColumn    // same column 
    || abs (blackRow - whiteRow) = abs (blackColumn - whiteColumn) // same diagonal