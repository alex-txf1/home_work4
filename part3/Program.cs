// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("напишите два числа одно из которых произведет другое в степень");
Console.WriteLine("_______________________________");
Console.Write("запуск процесса   ");
//int[] arr = numbers.ToArray();
var numbers = new Random().Next(1 , 100);
int[] arr = numbers.ToArray();
Console.WriteLine(string.Join(", ", arr));
