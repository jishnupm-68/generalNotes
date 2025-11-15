
let score : number | string | boolean= 423;
score = true
score ="hello"

type User = {
    name: string,
    id: number
}

type Admin ={
    adminName:string,
    id: number,
}

// both admin and user role possible 
let myName :User | Admin = {
    adminName:"aaa",
    id:4532
}

myName = {
    name:"bbb",
    id:34
}

let name: 'aaa' | "bbb" | 23
name="aaa"
name=23     // only assifned values are used 
// name=234        // error

export{}