//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.Clear();
void WeekDay(int var)
{
    if(var == 6 || var == 7){Console.WriteLine("Да это выходной!");}
    else{Console.WriteLine("Нет это не выходной!");}
}
int NumbEnter (int var)
{
    Console.WriteLine("Введите число обозначающее день недели, проверим является ли этот день выходным?");
    var = int.Parse(Console.ReadLine());
    return var;
}
int numbDay = 0;
WeekDay(NumbEnter(numbDay));