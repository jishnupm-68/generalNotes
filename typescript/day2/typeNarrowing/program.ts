function detectType(val:number|string){
    if(typeof val=='number') return val+45;
    else return val.toLowerCase();
}

function provideId(id:string|null){
    if(!id) {
        console.log("Please provide id");
        return
    }

    id.toLowerCase()
}

let date = new Date();

function logVal(data: string|Date):void{
    if(data instanceof Date) console.log(data.toISOString())
    else console.log(data.toUpperCase())
}

interface Circle{
kind:"circle"    ,
radius:number
}

interface Square{
    kind:"square",
    side:number
}

interface Rectangle{
    kind:"rectangle",
    length:number,
    width:number
}

type Shape = Circle|Square

function getTrueShape(shape:Shape){
    if(shape.kind==="circle"){
        return Math.PI *shape.radius**2
    }
    return shape.side * shape.side
}