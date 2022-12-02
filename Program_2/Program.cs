//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Clear();
Console.WriteLine("Введите число чтобы узнать его третью цифру");
int number = int.Parse(Console.ReadLine());
if(number >=100 || number<=-100)
{
    while (number > 1000|| number < -1000 ){number = number/10;}
    int third_numb = number % 10;
    if(third_numb < 0 ){ third_numb =  third_numb * -1; }
    Console.WriteLine($"Третья цифра: {third_numb}");
}
else{Console.WriteLine("Третьей цифры нет");}
