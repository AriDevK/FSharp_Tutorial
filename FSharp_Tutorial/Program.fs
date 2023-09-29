//* Base functions
let addTwo x = x + 2
let multiplyByFive x = x * 5


//-> Normal way
let addAndMultiply x =
    let total = addTwo x
    let result = multiplyByFive total
    result
    

//-> Composition way
//composition is a way to combine two functions into one
let addAndMultiplyCompose = addTwo >> multiplyByFive


//-> Canalization way
//canalization is a way to call a function and pass the result to another function
let addAndMultiplyCanalization x =
    x
    |> addTwo
    |> multiplyByFive
    
// also can be written as
// x |> addTwo |> multiplyByFive
   


