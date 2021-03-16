module FsharpLabs.Part4b.Domain
open FSharpPlus

let private checkNotEmpty (s : string)  =
  if System.String.IsNullOrWhiteSpace(s)
  then Error "string cannot be empty"
  else Ok s

type NonEmptyString = private NonEmptyString of string
  with member this.value = this |> fun (NonEmptyString x) -> x

module NonEmptyString =
  let create (s : string) =
    s |> checkNotEmpty
    >>= (NonEmptyString >> Ok)

type Email = private Email of string
  with member this.value = this |> fun (Email x) -> x

module Email =
  let create (s: string) =
    s |> checkNotEmpty
    >>= (Email >> Ok)

type Person = {
  firstName: NonEmptyString
  lastName: NonEmptyString
  email: Email
}

type PersonId = NonEmptyString