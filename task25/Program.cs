// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4-> 16
// Не использовать Math.Pow() и аналоги
// Решаем строго через цикл

Console.WriteLine("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
// int res = 1;
int sum = 1;
int i;

for ( i = 1; i<= B; i++)
{
    // res = A * res;
    sum = A* sum;
}
// Console.WriteLine($"Число {A} в степени {B} равно {res}");
Console.WriteLine(sum);
