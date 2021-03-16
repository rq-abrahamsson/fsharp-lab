module FsharpLabs.Part4b.Rop

open FSharpPlus
open FsharpLabs.Part4b

type IPersonWorkflows = {
  addPerson: Dto.Person -> Result<Dto.PersonId, string>
  getPerson: Dto.PersonId -> Result<Dto.Person, string>
  getPeople: unit -> Result<Dto.Person list, string>
  updatePerson: Dto.PersonId -> Dto.PersonId -> Result<unit, string>
  deletePerson: Dto.PersonId -> Result<unit, string>
}

let validate (person : Dto.Person) : Result<Domain.Person, string> =
  Error ""

let addToDatabase (person : Domain.Person) : Result<Domain.PersonId, string> =
  Error ""

let toResponse (personId : Domain.PersonId) : Result<Dto.PersonId, string> =
  Error ""

let getPersonWorkflows () : IPersonWorkflows = {
  addPerson =
    fun (person : Dto.Person) ->
      Ok person
      >>= validate
      >>= addToDatabase
      >>= toResponse
  getPerson = fun _ -> Error ""
  getPeople = fun _ -> Error ""
  updatePerson = fun _ _ -> Error ""
  deletePerson = fun _ -> Error ""

}
