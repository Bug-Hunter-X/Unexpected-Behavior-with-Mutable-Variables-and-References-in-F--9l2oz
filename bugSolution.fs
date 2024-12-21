let mutable x = 1
let y = ref x

//This is the correct way to handle the situation.
printf "%d %d" x (!y)

x <- 2
printf "%d %d" x (!y)