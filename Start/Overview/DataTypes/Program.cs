// Exercise file for LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Example file for .NET Data Types

// Declare some types with values
// int a = 1;
// char c = 'A';
// float f = 123.45f;
// decimal d = 400.85m;
// int b = default; //0
// bool tf = default; //false

// Console.WriteLine($"{a}, {b}, {tf}, {c}, {f}, {d}");

// TODO: implicit type conversion
// Console.WriteLine($"{c + a}"); //66 bc the character gets converted to integer. A is 65 in ASCII, plus 1 = 66
// Console.WriteLine($"{(char)(c+a)}"); //B because the ASCII character for "66" is B
// Console.WriteLine($"{f + a}"); //124.45 - this is pretty much what we'd expect. can add floating point and integers together pretty easily
// Console.WriteLine($"{f + c}"); //188.45 - similar to what happened for c+a. added the floating point and 65

// TODO: Create an instance of a struct (which is a value type)

// s s1;
// s1.a = 5;
// s1.b = false;

// Perform an operation on a struct
// void StructOp(s theStruct) {
//     // Modify the struct properties inside the function
//     theStruct.a = 10;
//     theStruct.b = true;
//     Console.WriteLine($"{theStruct.a}, {theStruct.b}");
// }

// Console.WriteLine("Structs are passed by copy, since they are value types:");
// Console.WriteLine($"{s1.a}, {s1.b}");
// StructOp(s1);
// Console.WriteLine($"{s1.a}, {s1.b}");

// TODO: Create an object instance of a class (which is a reference type)
// MyClass cl = new MyClass{a =5, b = false};

// Perform an operation on the class
// void ClassOp(MyClass theClass) {
//     // Modify some of the properties of the class inside the function
//     theClass.a = 10;
//     theClass.b = true;
//     Console.WriteLine($"{theClass.a}, {theClass.b}");
// }

// Console.WriteLine("Objects are passed by reference, since they are reference types:");
// Console.WriteLine($"{cl.a}, {cl.b}");
// ClassOp(cl);
// Console.WriteLine($"{cl.a}, {cl.b}");

/* 
!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!  

One the function completes, the original values of the class contents have been changed. in struct they weren't. objects are reference types and any changes to the object that is being referred to take place outside of the function. struct doesn't change the original value but objects do

!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! 
*/

// These are declared at the bottom of the file because C# requires
// top-level statements to come before type declarations
class MyClass {
    public int a;
    public bool b;
}

struct s {
    public int a;
    public bool b;
}
