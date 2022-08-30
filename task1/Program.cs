// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// Зачем тут в условии цикл?

for (int i = 0; i < 100; i++)
{
    Console.WriteLine("Введите 2 числа");
    int numberA = Convert.ToInt32(Console.ReadLine());
    int numberB = Convert.ToInt32(Console.ReadLine());

    double result = Math.Pow(numberA, numberB);
    
    Console.WriteLine($"{numberA} в степени {numberB} = {result}");
    Console.WriteLine();
}