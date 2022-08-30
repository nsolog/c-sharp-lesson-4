// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите число: ");
string number = Console.ReadLine();

int result = 0;
for (int i = 0; i < number.Length; i++)
{
    result += int.Parse(number[i].ToString());
}

Console.WriteLine($"Сумма цифр в числе = {result}");