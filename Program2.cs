// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11 82 -> 10 9012 -> 12
int Sum(int numb)
{
    int LengtNumb = Convert.ToString(numb).Length;
    int promres = 0;
    int res = 0;
    for (int i = 0; i < LengtNumb; i++)
    {
      promres = numb - numb % 10;
      res = res + (numb - promres);
      numb = numb / 10;
    }
   return res;
  }
Console.WriteLine("Please enter the number: ");
int number = Convert.ToInt32(Console.ReadLine());

int sum = Sum(number);
Console.WriteLine("Sum of numbers in a digit " + sum);
