/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/


/* Первый вариант решения через Random
int n = 8;
int[] arr = new int[n];
Random rand = new Random();
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rand.Next(0,100);
}
Console.WriteLine(string.Join(", ", arr));


Второй вариант решения через ввод строкой от пользователя
*/

Start:
Console.WriteLine("Введите массив из 8 чисел, разделенных пробелами, запятыми или точками");
string text = Console.ReadLine()!;
char[] separators = new char[] { ' ', '.', ',' };
string[] splitArray = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

int[] arrNum = new int[splitArray.Length];
int digit = 0;

for (int i = 0; i < arrNum.Length; i++)
{
  if (int.TryParse(splitArray[i], out digit))
  {
    arrNum[i] = digit;
  }
  else
  {
    Console.WriteLine("Ввели не число или не корректное число. Повторите ввод!");
    Console.WriteLine("-----------");
    goto Start;
  }
}
Console.WriteLine($"Введенный пользователем массив - это {string.Join(", ", arrNum)}");
