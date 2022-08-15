// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да


int number = 0;
int[] arrNum = {0};

while (number == 0)
{
    Console.WriteLine("Введите целое пятизначное число: ");
    number = Convert.ToInt32(Console.ReadLine());
    
    if (number >= 10000 && number < 100000)
    {
        arrNum = number.ToString().Select(x => x - '0').ToArray();
    }
    else
    {
        Console.WriteLine("Число не пятизначное !");
        number = 0;
    }
}

if (arrNum[0] == arrNum[4] && arrNum[1] == arrNum[3])
{
    Console.WriteLine("Число " + number + " - палиндром");
}
else
{
    Console.WriteLine("Число " + number + " - НЕ палиндром");
}