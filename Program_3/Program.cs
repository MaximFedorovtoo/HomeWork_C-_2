Console.Clear();
Console.WriteLine("Введите число обозначающее день недели, проверим является ли этот день выходным?");
int numberDay = int.Parse(Console.ReadLine());
void WeekDay(int var)
{
    if(var == 6 || var == 7){Console.WriteLine("Да это выходной!");}
    else{Console.WriteLine("Нет это не выходной!");}
}
WeekDay(numberDay);