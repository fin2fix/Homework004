/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
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


int SumOfDigits(int userNumber)
{
  int tempNumber = Math.Abs(userNumber);
  int sumDigit = 0;

  while (tempNumber >= 1)
  {
    sumDigit = sumDigit + tempNumber % 10;
    tempNumber = tempNumber / 10;
  }
  return sumDigit;
}

int number = GetNumber("Введите любое натуральное число");
int result = SumOfDigits(number);

Console.WriteLine($"Сумма цифр введенного числа {number} равна {result}");

