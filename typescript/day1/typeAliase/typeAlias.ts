
// user defined type
type User = {
    name:string,
    email:string,
    isActive:boolean
}

function createUser (user:User){}


type User2 = {
    readonly _id:string,
    name:string,
    email:string, 
    isActive:boolean,
    creditCard ?: number 
}

let myUser : User2 = {
    _id:"123",
    name:"as",
    email:"asb",
    isActive:false
}

myUser.name = "sa";
// myUser._id = "dsfa" 


// mix usage of type
type CardNumber = { 
    cardNumber:string
}
type CardDate = {
    cardDate : string
}
// combining many types together
type CardDetails =  CardDate & CardNumber & {
    cvv:number
}