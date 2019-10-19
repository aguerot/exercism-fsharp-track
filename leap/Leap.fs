module Leap


let leapYear (year: int): bool =
    let isDivisibleBy (divisor: int): bool = year % divisor = 0

    match year with
        | year when isDivisibleBy(400) -> true
        | year when isDivisibleBy(100) -> false
        | year when isDivisibleBy(4) -> true
        | _ -> false 