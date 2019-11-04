module Accumulate

let accumulate fn xs =
    let rec applyAccumulation fn xs acc =
        match xs with
        | [] -> acc
        | head :: tail -> applyAccumulation fn tail (fn head :: acc)

    applyAccumulation fn xs [] |> List.rev // need to reverse the list
