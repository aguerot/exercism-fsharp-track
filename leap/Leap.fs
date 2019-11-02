module Leap


let leapYear (year: int): bool =
    let isDivisibleBy divisor = year % divisor = 0

    isDivisibleBy(400) || not (isDivisibleBy(100)) && isDivisibleBy(4)