type CardNumber = int
type ExpiryYear = int
type ExpiryMonth = int
type CardCode = int

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

