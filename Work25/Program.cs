//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//Метод ввода двух чисел а и b
int GetNumber (string name)
{
  Console.WriteLine("Введите число " + name);
  return Convert.ToInt32(Console.ReadLine());
}

int a = GetNumber("a");
int b = GetNumber("b");

//Метод возведения числа a в степень b
int DegreeNumber(int a, int b)
{
  int result = 1;
  for (int i = 1; i <= b; i++)
  {
    result *= a;
  }
  return result;
}

Console.WriteLine("Число " + a + " в натуральной степени "  + b + " равно " + DegreeNumber(a, b));

