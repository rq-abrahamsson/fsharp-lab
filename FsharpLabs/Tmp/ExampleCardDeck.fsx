type Suit =
  | Club
  | Diamond
  | Heart
  | Spade

type Rank = | Two | Three | Four | Five | Six | Seven | Eight | Nine | Ten | Jack | Queen | King | Ace

type Card = (Suit * Rank)

type Deck = Card list


let deck = [(Club, Two)]

