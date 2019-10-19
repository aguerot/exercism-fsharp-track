module Clock

let day = 24 * 60

let private normalise minutes =
    (minutes % day + day) % day // add + modulo day length to accomodate < 0h and > 24h overflow

let create hours minutes =
    hours * 60 + minutes |> normalise

let add minutes clock =
    clock + minutes |> normalise

let subtract minutes clock =
    add (- minutes) clock

let display clock =
    let minutes = clock % 60
    let hours = clock / 60
    sprintf "%02d:%02d" hours minutes