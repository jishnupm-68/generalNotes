
interface  User  {
    readonly dbId: string,
    email:string,
    userId:number,
    googleId ?: string,
    // fun1 : ()=>string, // return type string in both fun1 and fun2
    fun2 ():string

}

// updating User interface , also called reopening interface
interface User{
    githubLogin ?:string
}

// extending from another interface
interface Admin extends User{
    role:"admin" | "leader"

}

const jish:Admin = {dbId : "45", email:"a@gmail.com", userId:4,
    fun2() {
        return "ok"
    },
    role:"admin"
}

