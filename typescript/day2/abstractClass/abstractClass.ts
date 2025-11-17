abstract class TakePhoto{
    constructor(
        public cameraMode:string,
        public filter: string
    ){}
}

// const me = new TakePhoto("test", "test2");  // invalid

class myClass extends TakePhoto{}

const myNewClass = new myClass ("test", "test33")
