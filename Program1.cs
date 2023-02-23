// Урок 4. Функции Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
//возводит число A в натуральную степень B. 3, 5 -> 243 (3⁵) 2, 4 -> 16
// 
int Expo(int a, int b)
{
    int i = 1;
    int result = a;
    while (i < b)
    {
        result = result * a;
        i++;
    }
    return result;
}
Console.WriteLine("Please enter the first number (A)!");
int FirstNumb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter the second number (B)!");
int SecondNumb = Convert.ToInt32(Console.ReadLine());
int expon = Expo(FirstNumb, SecondNumb);
Console.WriteLine("Number A " + FirstNumb + " to the power of " + SecondNumb + " = " + expon);
