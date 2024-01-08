// See https://aka.ms/new-console-template for more information
//Different Datatypes
/*
 
 text - string
interger - int
decimal - double, float, decimal
logical - bool ( true or false )
*/


//string
string name = "Charlotte Zee";
Console.WriteLine(name);
Console.WriteLine("I am " + name);
Console.WriteLine($"They call me {name}");
Console.WriteLine("I gave my self the name {0}", name);


//interger
int age = 25;
int retirement = 11;
int retirementAge = age + retirement;
Console.WriteLine("My age is "+ age);
Console.WriteLine("My retirement age is " + retirementAge);


//logical bool ( ture or false )
bool isRetired = false;
Console.WriteLine("Ami I retired? " + isRetired);










Console.ReadKey();