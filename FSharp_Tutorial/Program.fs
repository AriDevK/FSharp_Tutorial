// List functions
let cards = [1..10]

// Iter function
// this functions iterates over the list and applies the function to each element
// equals to do -> for i in cards do printfn "%d" i
List.iter(fun x -> printfn "%d" x) cards // print each element


// Map function
// this function iterates over the list and applies the function to each element
// and returns a new list with the results
let cards2 = List.map(fun x -> x * 2) cards // multiply each element by 2
printfn "%A" cards2


// Filter function
// this function iterates over the list and applies the function to each element
// and returns a new list with the elements that match the condition
let cards3 = List.filter(fun x -> x % 2 = 0) cards // filter even numbers


// Sort function
// this function iterates over the list and applies the function to each element
// and returns a new list with the elements that match the condition
let cards4 = List.sort cards

//  sort by function
let cards5 = List.sortBy(fun x -> x % 2) cards // sort by even and odd numbers


//  sort with function
let cards6 = List.sortWith(fun x y -> x - y) cards // sort by even and odd numbers




// Find function
// this function iterates over the list and applies the function to each element
// and returns the first element that match the condition
let card = List.find(fun x -> x % 2 = 0) cards // find the first even number

//  TryFind function
// this function iterates over the list and applies the function to each element
// and returns the first element that match the condition
let card2 = List.tryFind(fun x -> x % 2 = 0) cards // find the first even number


// And also some math and .NET functions in list
let sum = List.sum cards
let max = List.max cards
let min = List.min cards
let length = List.length cards
let exists = List.exists(fun x -> x % 2 = 0) cards // check if exists an even number
let forAll = List.forall(fun x -> x % 2 = 0) cards // check if all elements are even numbers
let contains = List.contains 5 cards // check if the list contains the element 5
let distinct = List.distinct cards // remove duplicates
let append = List.append cards cards2 // append two lists
let concat = List.concat [cards; cards2] // concat two lists
let rev = List.rev cards // reverse the list