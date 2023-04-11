Console.Clear();
Console.WriteLine("Задача 10: \n  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. \n" );

Console.WriteLine("Введите 3-значное число: ");
int num = int.Parse(Console.ReadLine());
num = (num / 10) % 10;
Console.WriteLine($"вторая цифра {num}");

System.Console.WriteLine("\n\nЗадача 13: \n  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. \n" );

Console.WriteLine("Введите число: ");
num = int.Parse(Console.ReadLine());

if (num / 100 != 0)
    {
        while (num / 1000 != 0)
        {
            num = num / 10;
        }
        Console.WriteLine($"третья цифра {num % 10}");
    }
else 
    { 
        Console.WriteLine("третьей цифры нет!");
    }

System.Console.WriteLine("\n\nЗадача 15: \n  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. \n" );

Console.WriteLine("Введите цифру (день недели): ");
num = int.Parse(Console.ReadLine());

switch (num)
{
    case 1:
        Console.WriteLine("ПН - рабочий день");
        break;
    case 2:
        Console.WriteLine("ВТ - рабочий день");
        break;
    case 3:
        Console.WriteLine("СР - рабочий день");
        break;
    case 4:
        Console.WriteLine("ЧТ - рабочий день");
        break;
    case 5:
        Console.WriteLine("ПТ - рабочий день");
        break;
    case 6:
        Console.WriteLine("СБ - выходной день!");
        break;
    case 7:
        Console.WriteLine("ВС - выходной день!");
        break;
    default:
        Console.WriteLine("Вы ввели некорректную цифру!");
        break;
}
