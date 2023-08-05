/*Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8*/

Console.WriteLine("Enter num: ");
string num1 = Console.ReadLine();
int num = int.Parse(num1);
int count = 1;
if (num > 0) 
{ 
    if (num == 1) 
    {
        Console.WriteLine("Нет четных чисел!");
    } 
    else 
    {
        while (count <= num) 
        {
            if (count % 2 == 0) Console.Write(count);
            if (count % 2 != 0 && count != 1 && count < num) Console.Write(", ");
            count++;
        }
    }
} 
else 
{
    Console.WriteLine("Необходимо ввести число больше 0!");
}