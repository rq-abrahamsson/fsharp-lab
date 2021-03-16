module FsharpLabs.Part4b.Rop

open System
open System.Collections.Generic
open FSharpPlus
open FsharpLabs.Part4b
open FsharpLabs.Part4b.Domain

let mutable simulatedDatabaseClient : IDictionary<string, Dto.Person> = Dictionary<string, Dto.Person>() :> IDictionary<string, Dto.Person>

type IPersonWorkflows = {
  addPerson: Dto.Person -> Result<Dto.PersonId, string>
  getPerson: Dto.PersonId -> Result<Dto.Person, string>
  getPeople: unit -> Result<Dto.Person list, string>
  updatePerson: Dto.PersonId -> Dto.PersonId -> Result<unit, string>
  deletePerson: Dto.PersonId -> Result<unit, string>
}

type Domain.Person with
  member this.toDto : Dto.Person = {
    firstName = this.firstName.value
    lastName = this.lastName.value
    email = this.email.value
  }

let validate (person : Dto.Person) : Result<Domain.Person, string> =
  Error ""

let addToDatabase (person : Domain.Person) : Result<Domain.PersonId, string> =
  let guid = Guid.NewGuid().ToString()
  simulatedDatabaseClient.Add(guid, person.toDto)
  guid |> NonEmptyString.create

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
