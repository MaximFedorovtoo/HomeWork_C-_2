Console.WriteLine("Введите трехзначное число чтобы узнать его вторую цифру");
int number = int.Parse(Console.ReadLine());
int second = number / 10 % 10;
Console.WriteLine(second);