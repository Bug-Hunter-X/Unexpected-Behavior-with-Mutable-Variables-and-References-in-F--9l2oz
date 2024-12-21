let mutable x = 1
let y = &x

//This will cause an error if x is modified after y is created.
printf "%d %d" x (!y)