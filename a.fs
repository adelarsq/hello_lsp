
let result = 1 + 1 = 2

let hello = "Hello" + " World"

let b, i, l = 86uy, 86, 86l

let rec fib' = function
    | 0 -> 0
    | 1 -> 1
    | n -> fib' (n - 1) + fib' (n - 2)

let list1 = ["a","b"]

let list2 = "c" :: list1

let list3 = list1 @ list2

let rec sum list =
    match list with
    | [] -> 0
    | x :: xs -> x + sum xs

let array1 = [| "a"; "b" |]

let first = array1.[0]







