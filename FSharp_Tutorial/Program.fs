// for in loop (yeah like python)
printfn "FOR IN LOOP"
let list = [1;2;3;4;5]
for i in list do
    printf $"{i}"


// for to loop (like the normal for)
printfn "\n\nFOR TO LOOP"
for i = 1 to 10 do
    printf $"{i}"
    

// for to loop in reverse
printfn "\n\nFOR TO LOOP (REVERESE)"
for i = 10 downto 1 do
    printf $"{i}"
    
    
// while loop
printfn "\n\nWHILE LOOP"
let mutable i = 0
while i < 10 do
    printf $"{i}"
    i <- i + 1