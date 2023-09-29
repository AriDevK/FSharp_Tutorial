open System

// Reading a line from the console
let name: string = Console.ReadLine()


// Parsing a string to an int
let age: string = Console.ReadLine()
let intAge: int = Int32.Parse age


// Operators
let aux = 10
let isEven = aux % 2 = 0
printfn $"Divisible by two {isEven}"