//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

//Первый вариант: общее решение для n элементов. В этом случае у меня сами числа задаются рандомно:

Console.Clear();
Console.Write("Введите число элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
n = array.Length;
Console.Write("[");
Random r = new Random();
for (int i = 0; i < array.Length; i++)
{
array[i] = r.Next(0, 101);
Console.Write(" " + array[i] + " ");
}
Console.Write("]");
Console.Read();