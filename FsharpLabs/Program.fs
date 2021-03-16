// Learn more about F# at http://fsharp.org

open FsharpLabs.Part4b
open FsharpLabs.Part4b.Rop

[<EntryPoint>]
let main argv =
    let workflow : IPersonWorkflows = getPersonWorkflows()
    let people = workflow.getPeople()
    printfn "%A" people
    0 // return an integer exit code
