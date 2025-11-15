# any in typescript

let data ;

function getData(){
    return "place in india"
}

data = getData();

# here the variable data is treated as "any", because data dont know, which type will be stored in the variable and """its a bad practice""" 

# it will bypass type checking error
