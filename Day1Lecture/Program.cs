// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//This is a comment
//Console.WriteLine("I am active");

/* Authoe: Justin Jones
 * Date: 1/9/23
 * blublahbleblublublublee
 */

//x is being declared
int x;
//x is being initialized
x = 10;

//combind
int y = 5;

//constant
const double TAXRATE = 0.06;
//TAXRATE = 1; cannot change a constant

//example

Console.WriteLine("Please enter a radius");
//string result = Console.ReadLine();
//double num = double.Parse(result);
double num = double.Parse(Console.ReadLine());
double area = num * num * Math.PI;
Console.WriteLine(area);

//NULL
string myName = null;
Console.WriteLine(myName);
string friend = "Josh Carolin";

if (friend == "Family")
{
    myName = "Justin";
}
else if (friend == "Josh Carolin")
{
    myName = "Jeo";
}
Console.WriteLine(myName);