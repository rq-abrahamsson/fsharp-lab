module FsharpLabs.Test.Part4b

open FsharpLabs.Part4b.Rop
open NUnit.Framework

[<SetUp>]
let Setup () =
    ()

[<Test>]
let Test1 () =
    let workflow : IPersonWorkflows = getPersonWorkflows()
    let people = workflow.getPeople()
    printfn "%A" people
    Assert.Pass()