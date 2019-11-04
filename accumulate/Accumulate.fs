module Accumulate

let accumulate fn xs =
    let rec applyAccumulation fn xs acc =
        match xs with
        | [] -> List.rev acc    // in the end reverse the complete accumulator 
        | head :: tail -> applyAccumulation fn tail (fn head :: acc)

    applyAccumulation fn xs []
