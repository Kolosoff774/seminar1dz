//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("Enter num A : ");
string A1 = Console.ReadLine();
int A = int.Parse(A1);

Console.WriteLine("Enter num B : ");
string B1 = Console.ReadLine();
int B = int.Parse(B1);

if (A > B)
{
    Console.WriteLine("Max = " + A);
    Console.WriteLine("Min = " + B);
}
else
{
    Console.WriteLine("Max = " + B);
    Console.WriteLine("Min = " + A);
}