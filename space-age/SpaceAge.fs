module SpaceAge

open System

type Planet =
    | Earth
    | Mercury
    | Venus
    | Mars
    | Jupiter
    | Saturn
    | Uranus
    | Neptune

let planetYearsFactor planet =
    match planet with
    | Earth -> 1.0
    | Mercury -> 0.2408467
    | Venus -> 0.61519726
    | Mars -> 1.8808158
    | Jupiter -> 11.862615
    | Saturn -> 29.447498
    | Uranus -> 84.016846
    | Neptune -> 164.79132


let age (planet: Planet) (seconds: int64) =

    let hearthYears = float seconds / 31557600.0
    let targetPlanetYears = hearthYears / planetYearsFactor planet

    Math.Round(float targetPlanetYears, 2)
