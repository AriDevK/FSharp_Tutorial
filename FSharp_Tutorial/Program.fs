// Printing in console

// F# style
printf "Hello from printf\n"
printfn "Hello from printfn"


// .NET Style
open System
Console.WriteLine("Hello from Console.WriteLine")
    

// Printing vars
let name: string = "Ariadne"
let age: int = 22


// String interpolation
printfn $"Hello my name is {name}, I'm {age} years old"

// String specifiers
//  %s -> string
//  %d | %i -> int
//  %b -> bool
printfn "Hello my name is %s, I'm %i years old" name age