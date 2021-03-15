#r "nuget: FSharpPlus"
open FSharpPlus
let readLines filePath = System.IO.File.ReadLines(filePath);
let lines = readLines "part3.txt"
let lineList =
  lines
  |> Seq.toList
  |> List.map int
  |> fun x -> printfn "%A" x; x
