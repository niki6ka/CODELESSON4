// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 6, 1, 33 -> [6, 1, 33]
int ArrLen = 8;
int[] Numbers = new int[ArrLen];
void FillArray(int[] Numbers)
{
    int index = 0;
    while (index < ArrLen)
    {
        Numbers[index] = new Random().Next(1, 100);
        Console.Write(Numbers[index] + " ");
        index++;
    }
}

FillArray(Numbers);
