// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.
// while (true) // true == true
// {
// Console.Write("Введите текст: ");
// string text = Console.ReadLine();
// if (text == "q")
// {
// break;
// }
// // Нужно проверить, что строчка text cостоит ТОЛЬКО из цифр
// int number; // 0, если в строчке есть символы или само число
// if (int.TryParse(text, out number)) // == true
// {
// Console.WriteLine("Введенная строчка состоит из ЦИФР");
// int sum = 0; // 56 => 6+5
// while (number > 0)
// {
// sum = sum + number;
// number /= 10; // Избавляюсь от последней цифры
// }
// if (sum % 2 == 0)
// {
// break;
// }
// }
// }

// Задача 2: Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// int[] CreateNewArray(int size, int min, int max)
// {
// int[] array = new int[size]; // Массив array на size элементов
// for (int i = 0; i < array.Length; i++)
// {
// array[i] = new Random().Next(min, max + 1);
// }
// return array;
// }

// int GetCountOfInterestingNumbers(int[] arr)
// {
// int count = 0;
// for (int i = 0; i < arr.Length; i++)
// {
// if (arr[i] % 2 == 0)
// {
// count++; // count = count + 1
// }
// }
// return count;
// }

// // Вызов функции
// Console.Write("Введите размер массива: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int[] res = CreateNewArray(N, 100, 999);
// // CreateArray(N, 100, 999) => массив, размер: N
// // каждый элемент: число от 100 до 999 вкл-но
// Console.WriteLine($"Массив из трехзначных чисел: [ {string.Join("; ", res)} ]");
// Console.WriteLine($"Total: {GetCountOfInterestingNumbers(res)}");

// Задача 3: Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)
// int[] array = {1, 5, 10, 20, 30, 40, 99, 4, 90, 3};
// for (int i = 0; i < array.Length/2; i++)
// {
// int tmp = array[i];
// array[i] = array[array.Length - i - 1];
// array[array.Length - i - 1] = tmp;
// }
// Console.WriteLine(string.Join(" ", array));