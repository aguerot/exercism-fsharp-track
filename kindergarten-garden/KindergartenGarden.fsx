
type Plant = Violets | Radishes | Grass | Clover | Unknown

let children =
    [ "Alice"; "Bob"; "Charlie"; "David"; "Eve"; "Fred"; "Ginny"; "Harriet"; "Ileana"; "Joseph"; "Kincaid"; "Larry" ]

let toPlant letter =
    match letter with
    | 'V' -> Violets
    | 'R' -> Radishes
    | 'G' -> Grass
    | 'C' -> Clover
    | _ -> Unknown

let plants (diagram: string) (student: string) =
    let index = children |> Seq.findIndex (fun x -> x = student)

    diagram.Split [| '\n' |]
        |> Seq.collect (Seq.skip (2 * index) >> Seq.take 2)
        |> Seq.map toPlant
        |> Seq.toList

let diagram = "VRCGVVRVCGGCCGVRGCVCGCGV\nVRCCCGCRRGVCGCRVVCVGCGCV"
let student = "Bob"

let res = plants diagram student

printfn "%A" (plants diagram student)
