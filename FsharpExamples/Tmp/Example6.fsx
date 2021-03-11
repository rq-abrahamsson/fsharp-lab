// Parse, don't validate

type CardNumber = private CardNumber of int
module CardNumber =
    let create v =
        if v |> string |> String.length = 16 then
            v |> CardNumber |> Ok
        else
            Error "Could not parse card value"
    let value (CardNumber v) =
        v

type ExpiryYear = private ExpiryYear of int
module ExpiryYear =
    let create v =
        if v |> string |> String.length = 2 then
            v |> ExpiryYear |> Ok
        else
            Error "Could not parse expiry year"
    let value (ExpiryYear v) =
        v

type ExpiryMonth = private ExpiryMonth of int
module ExpiryMonth =
    let create v =
        if v |> string |> String.length = 2 then
            v |> ExpiryMonth |> Ok
        else
            Error "Could not parse expiry month"
    let value (ExpiryMonth v) =
        v

type CardCode = private CardCode of int
module CardCode =
    let create v =
        let len = v |> string |> String.length 
        if len = 3 || let = 4 then
            v |> CardCode |> Ok
        else
            Error "Could not parse Card code"
    let value (CardCode v) =
        v

type CardDetails = {
  cardNumber : CardNumber
  expiryYear : ExpiryYear
  expiryMonth : ExpiryMonth
  code : CardCode
}

type InvoiceId = string
type Name = string
type Address = string

type InvoiceDetails = {
  invoiceId : InvoiceId
  name : Name
  address : Address
}

type Amount = decimal
type Method =
  | Card of CardDetails
  | Invoice of InvoiceDetails

type PaymentData = {
  amount : Amount
  method : Method
}

// Interface
type MakePayment = Method -> Amount -> PaymentData

