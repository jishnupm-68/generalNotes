const score : Array<number>=[];
const name : Array<string> = [];

function funOne(val:boolean|number): boolean|number{
    return val
}

function funTwo(val:any):any{
    return val
}

// generics , the type is locked here with the input
function funThree<Type>(val:Type):Type{
    return val
}

function funFour <T,U>(valOne:T, valTwo:U):Object{
    return {
        valOne,
        valTwo
    }
}

interface Quiz{
    name:string,
    type:string
}
interface Course{
    name:string,
    author:string,
    subject:string
}

class Selleable<T>{
    public card:T[]=[]

    addToCart(product:T){{
        this.card.push(product)
    }}
}
export{}