// Create a list in line
let numbersInLine = [1;2;3;4;5]

// Create a list with multiple lines
let numbersBlock = [
    1
    2
    3
    4
    5
]

//** Is not possible to mix types in a list

// Create a list with .. operator
let numbersRange = [1..5] // 1,2,3,4,5


// ------------------------------------------

// Adding elements to a list
// List are inmutable, so we need to create a new list with the new elements

// 6,1,2,3,4,5  (Add at the beginning) [::] operator
let newNumbers = 6 :: numbersInLine


// Adding a list to a list (Concatenation) [@] operator
// 1,2,3,4,5,6,7,8,9
let newNumbers2 = numbersInLine @ [6;7;8;9]


// ------------------------------------------

// List properties
newNumbers2.Head // First element of the list (1)
newNumbers2.Tail // List without the first element (2,3,4,5,6,7,8,9)
newNumbers2.Length // Length of the list (9)
newNumbers2.IsEmpty // Check if the list is empty (false)
newNumbers2.Item 2 // Get the element in the position 2 (3)