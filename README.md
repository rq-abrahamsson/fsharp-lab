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

### Del 2
Kolla igenom slidsen från presentationen och testa att köra de exemplerna vi gick igenom. 
Fixa det failande testet i projektet

### Del 3
Med följandne [regler](https://fsharpforfunandprofit.com/learning-fsharp/#dos-and-donts) lös följande uppgift.
Någon uppgift där man skriver F#-kod

### Välj en av följande
#### Modellering
Modellera data, jämför F# med C#/JavaScript
Använd ett lib från JavaScript eller Language extensions i C# https://github.com/louthy/language-ext

#### Railway Oriented Programming
Railway Oriented Programming.

#### State machines
Kanske en state machine, visa hur enkelt det är i F#?
