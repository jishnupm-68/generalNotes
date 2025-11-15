class User{
    public email:string 
    private courseCount :number
    name:string
    private readonly city:string
    constructor(email:string, name:string, city:string, courseCount:number){
        this.email = email;
        this.name = name;
        this.city = city
        this.courseCount = courseCount
    }
    // getter
    get getAppleEmail():string{
        return "apple"+this.email
    }

    get getcourseCount():number{
        return this.courseCount
    }

    // no return type in setters
    set setCourseCount(courseNum:number){
        if(courseNum){
            throw new Error("course count is less than 1")
        }
        this.courseCount = courseNum

    }

}