using System;

class Program
{
    static void Main()
    {
        Random random = new Random();

        // Задаем размеры массива
       
        int rows = 4;
       
        int columns = 4;
        

        // Создаем двумерный массив заданного размера
        int[,] array = new int[rows, columns];

        // Заполняем массив случайными числами и выводим на экран

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array[i, j] = random.Next(1, 101); // случайные числа от 1 до 100
                Console.Write(array[i, j] + "\t"); // вывод элемента массива с табуляцией
            }
            Console.WriteLine(); 
        }



        int desiredRow = 2; 
        Console.WriteLine($"\nСтрока {desiredRow + 1}:");

        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[desiredRow, j] + "\t");
        }

        Console.WriteLine();
        int desiredColumn = 1; 
        Console.WriteLine($"\nСтолбец {desiredColumn + 1}:");

        for (int i = 0; i < rows; i++)
        {
            Console.WriteLine(array[i, desiredColumn]);
        }

    }
}
