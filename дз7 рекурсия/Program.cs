// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.
// M = 1; N = 5 -> "1, 2, 3, 4, 5" 
// M = 4; N = 8 -> "4, 5, 6, 7, 8"


// void PrintNumbers (int max, int min)
// {
//     if (max > min)
//     {
//         return;
//     }
//     System.Console.Write($"{max} ");
//     PrintNumbers(max+1, min);
// }

// System.Console.WriteLine("Задайте первое число:");
// int firstnumber = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Задайте второе число:");
// int secondnumber = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine();
// PrintNumbers (firstnumber, secondnumber);



// Задача 2: Напишите программу вычисления функции 
// Аккермана с помощью рекурсии. Даны два 
// неотрицательных числа m и n. 
// m = 2, n = 3 -> A(m,n) = 29


// int Akkerman(int firstnumber, int secondnumber)
// {
//     if (firstnumber == 0)
//     {
//         return secondnumber + 1;
//     }
//     else
//     {
//         if (firstnumber > 0 && secondnumber == 0)
//         {
//             return Akkerman(firstnumber - 1, 1);
//         }
//         else
//         {
//             return Akkerman(firstnumber - 1, Akkerman(firstnumber, secondnumber - 1));            
//         }
//     }
// }

// System.Console.WriteLine("Задайте первое число:");
// int firstnumber = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Задайте второе число:");
// int secondnumber = Convert.ToInt32(Console.ReadLine());
// int result = Akkerman(firstnumber, secondnumber);
// System.Console.Write($"Функция Аккермана равна: Akkerman({firstnumber}, {secondnumber}) = {result}");



// Задача 3: Задайте произвольный массив. Выведете 
// его элементы, начиная с конца. Использовать 
// рекурсию, не использовать циклы.
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 


// int [] RandomArray (int min, int max, int size)
// {
//     int [] array = new int [size];
//     for (int i=0; i<size; i++)
//     {
//         array[i] = new Random().Next(min, max+1);
//     }
//     return  array;
// } 

// void PrintArray (int [] array)
// {
//     foreach (int item in array)
//     {
//         System.Console.Write(item + " ");
//     }
//     System.Console.WriteLine();
// }

// void PrintOfDigitsReverse (int [] array, int index)
// {
//     if (index < 0)
//     {
//         return;
//     }
//     System.Console.Write(array[index] + " ");
//     PrintOfDigitsReverse(array, index - 1);
// }
// System.Console.WriteLine("Введите минимальноу значение массива:");
// int minimun = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите максимальное значение массива:");
// int maximum = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите размер массива:");
// int length = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine();
// int [] array = RandomArray(minimun,maximum,length);
// PrintArray(array);
// System.Console.WriteLine();
// PrintOfDigitsReverse(array, array.Length-1);
