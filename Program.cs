System.Console.WriteLine("Выберете задачу:");
System.Console.WriteLine();
System.Console.WriteLine("1 - Игра");
System.Console.WriteLine("2 - Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");
System.Console.WriteLine("3 - Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями ");
System.Console.WriteLine("y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.");
System.Console.WriteLine();
int TaskIndex = int.Parse(Console.ReadLine());
if(TaskIndex == 0)
{
    System.Console.WriteLine("Такой задачи нет");
}
if(TaskIndex > 3)
{
    System.Console.WriteLine("Такой задачи нет");
}


if (TaskIndex == 1)
{
    int[,] number ={{0, 0, 0, 0, 0, 0, 0,},
                {0, 0, 0, 0, 2, 0, 0,},
                {0, 0, 0, 0, 2, 0, 0,},
                {0, 3, 0, 1, 2, 0, 0,},
                {0, 0, 0, 0, 0, 0, 0,},
                {0, 0, 0, 0, 0, 0, 0,},
                {0, 0, 0, 0, 0, 0, 0,}};
    //int row = int.Parse(Console.ReadLine());
    //int column = int.Parse(System.Console.ReadLine());
    //int[,] num = new int[row,column];
    //for (int i = 0; i < number.GetUpperBound(0)+1; i++)
    //{
    // for (int j = 0; j < number.GetUpperBound(1)+1; j++)
    //{
    //   System.Console.Write(number[i,j] + " ");
    //}
    //System.Console.WriteLine();
    //}
    int row = 3;
    int column = 3;
    int oldRow = 0;
    int oldColumn = 0;
    int score = 0;
    int appleRow = new int();
    int appleColumn = new int();
    while (true)
    {
        ConsoleKeyInfo key = Console.ReadKey();
        number[row, column] = 0;
        oldRow = row;
        oldColumn = column;
        if (key.Key == ConsoleKey.W)
        {
            row--;
        }
        if (key.Key == ConsoleKey.S)
        {
            row++;
        }
        if (key.Key == ConsoleKey.A)
        {
            column--;
        }
        if (key.Key == ConsoleKey.D)
        {
            column++;
        }
        if (row > number.GetLength(0) - 1)
        {
            row = number.GetLength(0) - 1;
        }
        if (row < 0)
        {
            row = 0;
        }
        if (column > number.GetLength(1) - 1)
        {
            column = number.GetLength(1) - 1;
        }
        if (column < 0)
        {
            column = 0;
        }


        if (number[row, column] == 2)
        {
            row = oldRow;
            column = oldColumn;
        }
        if (number[row, column] == 3)
        {
            score = score + 1;
            appleRow = new Random().Next(0, 6);
            appleColumn = new Random().Next(0, 6);
            if (number[appleRow, appleColumn] != 0)
            {
                appleRow = new Random().Next(0, 6);
                appleColumn = new Random().Next(0, 6);
            }
            number[appleRow, appleColumn] = 3;
        }
        Console.Clear();
        number[row, column] = 1;
        for (int i = 0; i < number.GetLength(0); i++)
        {
            for (int j = 0; j < number.GetLength(1); j++)
            {
                Console.Write(number[i, j] + " ");
            }
            Console.WriteLine();

        }
        System.Console.WriteLine();
        System.Console.Write($"Ваш рекорд - {score}");

    }
}
if(TaskIndex == 2)
{
    System.Console.Write("Введите числа через пробел: ");
    string numbers = Console.ReadLine();
    int[] array = GetArrayFromString(numbers);
    int PlusNull = 0;

    int[] GetArrayFromString (string stringArray)
    {
        string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        int[] res = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            res[i] = int.Parse(nums[i]);
        }
        return res;
    }
    
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            PlusNull = PlusNull + 1;
        }
    }
    System.Console.WriteLine($"Чисел больше нуля - {PlusNull}");
}

if(TaskIndex == 3)
{
    System.Console.WriteLine("Даны уравнения - y = k1 * x + b1, y = k2 * x + b2. Найдите пресечния прямых с их помощью!");
    System.Console.WriteLine();
    System.Console.WriteLine("Введите k1");
    float k1 = int.Parse(System.Console.ReadLine());
    System.Console.WriteLine("Введите k2");
    float k2 = int.Parse(System.Console.ReadLine());
    System.Console.WriteLine("Введите b1");
    float b1 = int.Parse(System.Console.ReadLine());
    System.Console.WriteLine("Введите b2");
    float b2 = int.Parse(System.Console.ReadLine());

    
    float x = (b2-b1)/(k1-k2);
    float y =k1*((b2-b1)/(k1-k2))+b1;
    System.Console.WriteLine($"({x},{y})");

}



