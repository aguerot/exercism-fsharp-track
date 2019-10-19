module SpaceAge

open System

type Planet = Earth 
                | Mercury
                | Venus
                | Mars
                | Jupiter
                | Saturn
                | Uranus
                | Neptune

let age (planet: Planet) (seconds: int64) : float = 
    let planetYears planet years = 
        match planet with 
        | Earth -> years
        | Mercury -> years / 0.2408467
        | Venus -> years / 0.61519726
        | Mars -> years / 1.8808158
        | Jupiter -> years / 11.862615
        | Saturn -> years / 29.447498
        | Uranus -> years / 84.016846
        | Neptune -> years / 164.79132

    let hearthYears = float(seconds) / 31557600.0
    let targetPlanetYears = planetYears planet hearthYears

    Math.Round(float(targetPlanetYears), 2)