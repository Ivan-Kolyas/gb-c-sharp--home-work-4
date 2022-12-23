
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16


// int numberA = ReadInt("Enter number A: ");
// int numberB = ReadInt("Enter number B: ");
// Vstepen(numberA, numberB);

// void Vstepen(int a, int b)
// {
//     int result = 1;
//     for (int i = 1; i <= b; i++)
//     {
//         result = result * a;
//     }
//     Console.WriteLine(result);
// }

// int ReadInt(string message)
// {
//     Console.WriteLine(message);
//     return Convert.ToInt32(Console.ReadLine());
// }




// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

            // Console.Write("Введите число: ");
            // int Number = Convert.ToInt32(Console.ReadLine());
            // int result = 0;
            // while (Number != 0)
            // {
            //     result += Number % 10;
            //     Number /= 10;
            // }

            // Console.WriteLine($"Сумма цифр в числе = {result}");

            




// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]


// Массив
// int[] GreateRandomArray (int size, int minValue, int maxValue)
// {
//   int [] newArray = new int [size];
//   for (int i = 0; i < size; i++)
//   {
//     newArray[i] = new Random().Next(minValue, maxValue+1);
//   }
//   return newArray;
// }
// void ShowArray (int[] array)
// {
//     Console.Write("Получившийся массив ->");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i]+"  ");
//     }
  
// }
// Console.WriteLine("Введите размер массива");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение элемента");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение элемента");
// int max = Convert.ToInt32(Console.ReadLine());
// int[] myArray = GreateRandomArray(a,min,max);
// ShowArray(myArray);
