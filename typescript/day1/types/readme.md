Types in typescript

> Number
> String
> Boolean
> Null
> undefined
> void
> object 
> Array
> tuple
> any (DONT USE THIS TYPE IN THE CODE)
> never
> unknown

usage :
    let variableName:type =value;


# type inference;
let num=43          -> case 1
let num:number = 34;-> case 2

here in the case 1, the typescript is smart enough to specify the type to the variable num, and in the future also it will store only numbers, otherwise throw error


# never 
# The never type represents values which are never observed. In a return type, this means that the function throw an exception or terminates execution of the program