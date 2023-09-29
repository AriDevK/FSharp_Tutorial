// functions
let add a b = a + b

// function that returns a value
let addAndMultiply a b c =
    let sum = add a b
    sum * c // return value
    

// function with defined return type and parameter types
let convert (param: string) : int =
    int param
    
    
// calling functions
printfn $"Sum function: {add 1 2}"
printfn $"Add and multiply function: {addAndMultiply 1 2 3}"
printfn "Convert function: %d" (convert "123")