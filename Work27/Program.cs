// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//Метод ввода числа a
int GetNumber()
{
  Console.WriteLine("Введите число: ");
  return Convert.ToInt32(Console.ReadLine());
}

int SumDigit(int number)
{
  int sum = 0;
  for (int i = 0; number > 0; i++)
  {
    sum = sum + number % 10;
    number = number / 10;
  }
  return sum;
}

int a = GetNumber();
Console.WriteLine("Сумма цифр в числе " + a + ": " + SumDigit(a));
