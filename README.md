# F# labb

## Setup

Installera dotnet version 5. Om asdf är installerat finns det en .tools-version fil.
Testa följande och se att tre av testen går igenom och ett failar.
1. `dotnet restore --interactive`
1. `dotnet build`
1. `dotnet test`

När det är gjort testa att starta F# interactive med: `dotnet fsi`. (För att komma ur det skriv `#quit;;`)

## Labbar
Fundera på den här, diskussion i slutet.
Finns det något lib eller mönster som skulle ge ett värde i de pågående projekten?

### Del 1
Läs igenom [den här sidan](https://fsharpforfunandprofit.com/posts/fsharp-in-60-seconds/) om lite grundläggande F# syntax och testa att köra kommandon i REPL:n.
Klistra in en rad, avsluta med `;;` och sen enter.

### Del 2
Kolla igenom slidsen från presentationen och testa att köra några av de exemplen vi gick igenom.
Fixa det failande testet i projektet.

### Del 3
Med följandne [regler](https://fsharpforfunandprofit.com/learning-fsharp/#dos-and-donts) lös försök följande uppgift (endast första uppgiften) från Advent Of Code:
[AOC 2020-1](https://adventofcode.com/2020/day/1).

Finns uppsatt en grund för att börja det här i filen [Past3.fsx](/FsharpLabs/Part3.fsx).
Filändelsen `.fsx` säger att det är en F#-scriptfil vilket innebär att man kan köra filen med följand kommando: `dotnet fsi FsharpLabs/Part3.fsx`.

Kolla gärna in [lösningsförslaget](https://github.com/rq-abrahamsson/aoc/blob/master/2020-1/App.fsx) när du är klar och fundera på om vad som hade kunnat förbättras och varför (både din kod och lösningsförslaget).

BONUS: Sätt upp ett test som bekräftar att uppgiften är löst. Eller ännu bättre, sätt upp testet innan och lös det med TDD.

### Större uppgifter
De här uppgifterna kan göras snabbt och enkelt men de går också att ta ganska långt.
Så ni väljer själva om ni bara vill fokusera på en eller om ni vill göra lite av varje.

#### Modellering - Tic-Tac-Toe
Här ska vi modellera det enkla spelet [Tic-Tac-Toe](https://en.wikipedia.org/wiki/Tic-tac-toe). Det finns en start i filen [TicTacToe.fsx](/FsharpLabs/Part3-a):
```
type InitGame = unit -> Game
type PlayerXMoves = GameState * SomeOtherStuff -> GameState
```
Följ följande riktlinjer och kör en type first design:
* We start with types only – no implementation code.
* Every use-case or scenario corresponds to a function type, with one input and one output (which means I’ll use tuples when multiple parameters are needed).
* We work mostly top-down and outside-in, but occasionally bottom up as well.
* We ignore the UI for now. And there will be no events or observables in the design of the core domain. It will be purely functional.

När modellerandet är klart är det dags att implementera och se om modellen håller, tänk på att man vill kunna se spelet också.

När det är klart är det dags att fundera över det ni har gjort. Utgå gärna från när [Scott Wlaschin](https://fsharpforfunandprofit.com/posts/enterprise-tic-tac-toe/) gör samma sak.
Det är en väldigt lång artikel och hade lite andra utgångsvärden, men kan vara värdefullt att läsa en del och jämföra med er process och implementation.

Om ni har tid över kan ni försöka göra samma övning med JavaScript eller C# och kanske använda något funktionellt bibliotek som [Immutable.js](https://immutable-js.github.io/immutable-js/docs/#/), [Lodash](https://lodash.com/docs) eller [Language extensions](https://github.com/louthy/language-ext)

#### Railway Oriented Programming
Railway Oriented Programming.

#### State machines
Kanske en state machine, visa hur enkelt det är i F#?
