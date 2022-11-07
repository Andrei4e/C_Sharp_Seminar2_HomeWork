//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*int SecondDigital(int number)
{
    return (number%100/10);   
}

Console.Write("Введите трехзначное число: ");
int Number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Вторая цифра введенного числа равно {SecondDigital(Number)}");*/


//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*int ThirdDigital(int number)
{
    int num = number;
    int Result = 0;
    int DigitalCount = 0;
    int factor = 1;
    while (num>0)
    {
        DigitalCount++;
        num = num/10;
    }

    if (DigitalCount == 2) Result = -1;
    else
    {
        if (DigitalCount == 3) Result = number%100%10;
        if (DigitalCount > 3) 
        {
            for (int i = 1; i <= (DigitalCount-2); i++)
            {
                factor = factor*10;
            }  
            Result = number%factor/(factor/10);          
        }
        return Result;
    }
    return Result;   
}

Console.Write("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());

if (ThirdDigital(Number)==-1) Console.WriteLine("Третьей цифры в числе нет");
else Console.WriteLine($"Третья цифра введенного числа равно {ThirdDigital(Number)}");*/



//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*int DayOffCheck(int day)
{
    int result = 0;
    if (day>=1 & day<=5) result = 1;
    else if (day>=6 & day<=7) result = 2;
    return result;
}

Console.Write("Введите номер дня недели: ");
int Day = Convert.ToInt32(Console.ReadLine());

switch (DayOffCheck(Day))
{
    case 0:
        Console.WriteLine("Такого дня недели не существует");
        break;
    case 1:
        Console.WriteLine("Данный день не выходной");
        break;
    case 2:
        Console.WriteLine("Данный день выходной");
        break;
}*/