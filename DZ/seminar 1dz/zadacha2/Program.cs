/*Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

Console.WriteLine("Enter num a: ");
string a1 = Console.ReadLine();
int a = int.Parse(a1);

Console.WriteLine("Enter num b: ");
string b1 = Console.ReadLine();
int b = int.Parse(b1);

Console.WriteLine("Enter num c: ");
string c1 = Console.ReadLine();
int c = int.Parse(c1);

if (a > b && a > c) Console.WriteLine("Max = " + a);
if (b > a && b > c) Console.WriteLine("Max = " + b);
if (c > a && c > b) Console.WriteLine("Max = " + c);