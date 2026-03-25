using System;

while (true)
{

    System.Console.WriteLine("Как вас зовут?");

    string name = Console.ReadLine();

    System.Console.WriteLine($"Привет! {name}");
    System.Console.WriteLine($"Сегодня : {DateTime.Now.DayOfWeek}");

    System.Console.WriteLine("Хотите продолжить? (y/n)");

    string answer = Console.ReadLine();
    if (answer == "n")
    {
        System.Console.WriteLine($"Прощайте {name}!");
        break;
    }
}