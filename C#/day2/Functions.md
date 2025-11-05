# day 2

# function also known as methods

eg: void welcome(string name)
            {
                System.Console.WriteLine("Welcome to my Program {0}", name);
            }

-> if we used the static keyword, then we can access the function with out creating its instance, otherwise makes the instance and access using dot operator

-> void in the function means the function will not return anything

-> return type function 

# Parameter / Formal Parameter
A variable listed in a  functions declaration 
Inside the function definition

# Argument  / actual parameter
A value passed to the function when it is called
inside the function call

returnType functionName(parameter){

}

functionName(argument);


## default > keyword used to give default value in a function 
or we can also use Optional keyword
# optional parameter : void Add(int a, [Optional] int b);
void Add(int a, int b= default);

# named parameter
here we can keep our argument irrespective of their order
eg: add(age:ageInput, name:nameInput, address:addressInput);

string add(string name, int age, string address){}


