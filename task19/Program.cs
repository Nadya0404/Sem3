// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да


Console.Write ($"Введите пятизначное число");
string? str = Console.ReadLine();

if (str!.Length==5)
{
    if (str[0]==str[4])
    {
        if (str[1]==str[3])
        {
        Console.Write ($"Да");
        }
        else
        {
        Console.WriteLine($"Это не палидром");
        }
    }
    else 
    {
    Console.WriteLine($"Это не палидром!");
    }
}
else 
{
    Console.WriteLine($"Число должно быть пятизначным!");
}

