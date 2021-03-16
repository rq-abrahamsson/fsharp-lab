
type Game = exn
type GameState = exn
type SomeOtherStuff = exn

type InitGame = unit -> Game

type PlayerXMoves = GameState * SomeOtherStuff -> GameState
