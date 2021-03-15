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

### Välj en av följande
#### Modellering
Modellera data, jämför F# med C#/JavaScript
Använd ett lib från JavaScript eller Language extensions i C# https://github.com/louthy/language-ext

#### Railway Oriented Programming
Railway Oriented Programming.

#### State machines
Kanske en state machine, visa hur enkelt det är i F#?
