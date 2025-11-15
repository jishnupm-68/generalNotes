const user ={
    name: "jishnu",
    email:"abc@gmail.com",
    inActive: true
}

function data({name : string, age : number}) {}
data({name:"xyz", age:345})
let userDetails = {name:"xyz", age:345, isPaid:true}
data({name:"xyz", age:345, isPaid:true}) // it will throw error
data(userDetails) // here we pass an object and not throwing error

export{}