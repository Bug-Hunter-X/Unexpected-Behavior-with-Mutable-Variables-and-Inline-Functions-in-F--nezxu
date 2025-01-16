let x = 10
let y = 20

let add x y = x + y

let inline addInline x y = x + y

let result1 = add x y
let result2 = addInline x y

printfn "%d" result1
printfn "%d" result2

let x2 = 30
let y2 = 40

let result3 = add x2 y2
let result4 = addInline x2 y2

printfn "%d" result3
printfn "%d" result4