let mutable x = 10
let mutable y = 20

let add x y = x + y

let inline addInline x y = x + y

let result1 = add x y
let result2 = addInline x y

printfn "%d" result1
printfn "%d" result2

x <- 30
y <- 40

let result3 = add x y
let result4 = addInline x y

printfn "%d" result3
printfn "%d" result4