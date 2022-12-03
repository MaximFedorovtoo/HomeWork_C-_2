//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Clear();
int NumbEnter (int var)
{
    Console.WriteLine("Введите число чтобы узнать его третью цифру");
    var = int.Parse(Console.ReadLine());
    return var;
}
void FindThird (int var)
{
    if(var >= 100 || var <= -100)
    {
        while (var > 1000|| var < -1000 ){var = var/10;}
        int third_numb = var % 10;
        if(third_numb < 0 ){ third_numb =  third_numb * -1; }
        Console.WriteLine($"Третья цифра: {third_numb}");
    }
    else{Console.WriteLine("Третьей цифры нет");}
}
int var = 0;
int number = NumbEnter(var);
FindThird(number);


