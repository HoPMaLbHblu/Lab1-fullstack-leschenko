using System;

while (true)
{

    System.Console.WriteLine("Как вас зовут?");

    string name = Console.ReadLine();

    System.Console.WriteLine($"Привет! {name}");
    System.Console.WriteLine($"Сегодня : {DateTime.Now.DayOfWeek}");

}