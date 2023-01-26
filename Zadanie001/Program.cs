/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16 
*/

int GetNumber(string message)
{
  int resultNumber = 0;

  while (true)
  {
    Console.WriteLine(message);

    if (int.TryParse(Console.ReadLine(), out resultNumber))
    {
      break;
    }
    else
    {
      Console.WriteLine("Ввели не число или не корректное число. Повторите ввод!");
      Console.WriteLine("-----------");
    }
  }
  return resultNumber;
}

int Exponent(int firstNumber, int secondNumber)
{
  int expAinB = 1;

  for (int i = 1; i <= secondNumber; i++)
  {
    expAinB = expAinB * firstNumber;
  }
  return expAinB;
}

int a = GetNumber("Введите первое натуральное число (основание)");
int b = GetNumber("Введите второе натуральное число (степень)");

int expResult = Exponent(a, b);

Console.WriteLine($"Число {a} в степени {b} равно {expResult}");


