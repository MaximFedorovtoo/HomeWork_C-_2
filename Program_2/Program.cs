Console.Clear();
Console.WriteLine("Введите число чтобы узнать его третью цифру");
int number = int.Parse(Console.ReadLine());
if(number>=1000 || number >=100)
{
    while (number > 1000){number = number/10;}
    int third_numb = number % 10;
    Console.WriteLine($"Третья цифра: {third_numb}");
}
else{Console.WriteLine("Третьей цифры нет");}
