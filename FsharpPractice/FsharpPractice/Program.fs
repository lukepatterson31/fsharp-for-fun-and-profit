
// Using iter()
let cards = [1..5]
List.iter(fun i-> printfn $"%i{i}") cards

//Using map()
type Person = { FirstName: string; LastName: string }
let people = [
    { FirstName="Albert"; LastName="Einstein" }
    { FirstName="Marie"; LastName="Curie" }
]
let nobelPrizeWinners = List.map (fun person -> person.FirstName + person.LastName) people
printfn $"%A{nobelPrizeWinners}"

// Using filter()
let filteredList = List.filter(fun i -> i % 2 = 0) cards
List.iter(fun i -> printfn $"%i{i}") filteredList

// Using sort()
let list = [2; 1; 5; 3]
let sortedList = List.sort list

// Using sortBy()
let fruits = ["Banana"; "Apple"; "Clementine"]
let sortedFruits :string List = List.sortBy(fun fruit -> fruit.Length) fruits

// Using sortWith() -> Microsoft example doesn't work, make one up

// Using find()
