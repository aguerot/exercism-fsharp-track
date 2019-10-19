module GradeSchool

type School = Map<int, string list>

let empty: School = Map.empty<int, string list> 

let roster (school: School): string list = 
     school 
     |> Map.toList
     |> List.collect snd

let grade (number: int) (school: School): string list = 
    match school |> Map.tryFind number with
        | Some(g) -> g
        | None -> []
        |> List.sort

let add (student: string) (grd: int) (school: School): School = 
    let newList = student :: (school |> grade grd) |> List.sort
    
    school |> Map.add grd newList
