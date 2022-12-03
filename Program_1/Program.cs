//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.Clear();
int FindSecond(int var)
{
    Console.Write("Введите трехзначное число чтобы узнать его вторую цифру ");
    var = int.Parse(Console.ReadLine());
    return var;
}
int var = 0;
int secondNumb = FindSecond(var);
secondNumb = secondNumb / 10 % 10;
Console.WriteLine(secondNumb);