
type ActiveCartData = exn
type PaidCartData = exn

type ShoppingCart =
  | EmptyCart
  | ActiveCart of ActiveCartData
  | PaidCart of PaidCartData
