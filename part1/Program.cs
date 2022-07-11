// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("напишите два числа одно из которых произведет другое в степень");
Console.WriteLine("_______________________________");
Console.Write("число 1    ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("число два  ");
int stepen = Convert.ToInt32(Console.ReadLine());
void numbers(int number1 , int stepen)
{
    int result = Convert.ToInt32(Math.Pow(number1 ,  stepen ));
    Console.WriteLine(result);
}
numbers(number1 , stepen);


