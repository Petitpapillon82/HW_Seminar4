//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

Console.Clear();
Console.Write("Введите число элементов массива: ");
            int n = Convert.ToInt32(Console.ReadLine()); 
            string[] MyArray = new string[n]; //Объявляем массив строк длиной n (которую ввёл пользователь)
            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите число №{0}:    ", i + 1); 
                MyArray[i] = Console.ReadLine(); 
            }
            Console.WriteLine("Полученный массив: ");
            Console.Write("[");
            for (int i = 0; i < n; i++)
          
            {
               
                Console.Write(" " + MyArray[i] + " ");
            }
           Console.Write("]");