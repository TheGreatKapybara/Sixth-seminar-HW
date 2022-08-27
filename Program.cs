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
    number[row,column] = 0;
    oldRow = row;
    oldColumn = column;
    if(key.Key == ConsoleKey.W)
    {
        row--;
    }
    if(key.Key == ConsoleKey.S)
    {
        row++;
    }
    if(key.Key == ConsoleKey.A)
    {
        column--;
    }
    if(key.Key == ConsoleKey.D)
    {
        column++;
    }
    if(row > number.GetLength(0)-1)
    {
        row = number.GetLength(0)-1;
    }
    if(row < 0)
    {
        row = 0;
    }
     if(column > number.GetLength(1)-1)
    {
        column = number.GetLength(1)-1;
    }
    if(column < 0)
    {
        column = 0;
    }
    
    
    if (number[row,column] == 2)
    {
         row = oldRow;
         column = oldColumn;
    }
    if (number[row,column] == 3)
    {
        score = score + 1;
        appleRow = new Random().Next(0,6);
        appleColumn = new Random().Next(0,6);
        if(number[appleRow,appleColumn] != 0)
        {
            appleRow = new Random().Next(0,6);
            appleColumn = new Random().Next(0,6);
        }
        number[appleRow,appleColumn] = 3;
    }
    Console.Clear();
    number[row,column] = 1;
    for (int i = 0; i < number.GetLength(0); i++)
    {
        for (int j = 0; j < number.GetLength(1); j++)
        {
            Console.Write(number[i,j] + " ");
        }
        Console.WriteLine();
        
    }
    System.Console.WriteLine();
    System.Console.Write($"Ваш рекорд - {score}");
  
}
// добавить 3 - фрукт который добавляет очки, фрукт генерируется рандомно, после съедения фрукт переммещается



