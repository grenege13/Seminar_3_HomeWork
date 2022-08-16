// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите Х для точки А : ");
double xA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите Y для точки А : ");
double yA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите Z для точки А : ");
double zA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите Х для точки B : ");
double xB = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите Y для точки А : ");
double yB = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите Z для точки А : ");
double zB = Convert.ToDouble(Console.ReadLine());

double dif = Math.Sqrt(Math.Pow((xA - xB), 2) + Math.Pow((yA - yB), 2) + Math.Pow((zA - zB), 2));

Console.WriteLine("Расстояние между точками = " + Math.Round(dif, 2));