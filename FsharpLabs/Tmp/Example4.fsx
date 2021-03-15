
type CardDetails = {
  cardNumber : int
  expiryYear : int
  expiryMonth : int
  code : int
}

type InvoiceDetails = {
  invoiceId : string
  name : string
  address : string
}

type Method =
  | Card of CardDetails
  | Invoice of InvoiceDetails

type PaymentData = {
  amount : decimal
  method : string
}

// Interface
type MakePayment = Method -> string -> PaymentData
