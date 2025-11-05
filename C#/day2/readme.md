 # day2

 ---> if condition

 if(condition){
    //code
 }else{
    //code
 }


 # switch statement

 int day = 3;

 switch (day){      ### note this, "s" is small letter
    case 1: Console.WriteLine("Sun");
    break;
    case 2: Console.WriteLine("Mon");
    break;
    ....
    default:Console.WriteLine("Invalid");
    break;
 }



 # for loop
-> for (initialize; condition; updation){}
 for(int i=0;i<5;i++){
    //code
 }

 # while loop
-> first check the condition and run the code inside {}
 while(condition){
    code
 }

 # do while loop
-> it will run the code inside {} atleast for once and check the condition
 do{
    //code
 }while(condition);

 # conditional operator (?)
 result = (condition)? true: false ;

 # number formating
 Console.WriteLine(string.Format("{0:0.00}", 234/7.0)); 

 # try parse function

> exercise 1: multipication table
> exercise 2: Fizzbuzz

 # Verbatium String Literal
 Back slash is used for writing some symbol such as double quote "  in between the " "
 eg : Console.WriteLine("HEllo , \" XYZ \" ");
  we can write like this: @""
  This is mainly used with path of any object

 # String format 
 \n -> new line
    {0} can be used for formating. we can write the variable seperated by comma


# string interpolation using $
int age =  23;
string name = "jishnu";
Console.WriteLine($"name is {name} and age is {age}");


# string concatination using + or string.Concat()

#  empty string
string.Empty is used for checking empty string
s!= string.Empty

# string.Equals function

string mess= "hello";
string comp = "hello";
mess.Equals(comp); // will gives true

# string iteration looping


  string mess = "jishnu pm how are you";
      for(int i=0;i<mess.Length;i++){
      Console.Write( mess[i]);
      }


# string.isNullOrEmpty() function

# Exercise: password checker;
# Exercise: reverse string

# Arrays
int[] number= new int[3];

# for of loop analogy in cs: 
-> foreach(int item in nums)System.Console.WriteLine(item);

# array sort 
Array.sort(arrayName);

# Array reversal
Array.Reverse(arrayName);

# Array clearing
To make the array into default value 0
Array.Clear(arrayname, startIndex, length);

# Array indexof
System.Console.WriteLine(Array.IndexOf(numbers,search, startIndex, count));

## List 
List<dataType> listName = new List<dataType>(items)
listName.Add(item);
Accessing list data same as that of array
List doesnot have fixed size


## Dictionary > map in js
> key value pair
> mention the datatype
-> Add(key,value);
-> Remove(key);
-> Clear();
-> ContainsKey(key);
-> ContainsValue(value);
-> TryGetValue(ke, out string variableName);
-> count(), keys(), values(), 


# exercise odd/even List 