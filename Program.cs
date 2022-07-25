void Zadacha58()
{
int rows = 4;
int columns = 4;
int [,] array = new int [rows, columns];
int index_i = 0;
int index_j = 0;
int change_i = 0;
int change_j = 1;
int steps = columns;
int tern = 0;
FillArray(array);
Split(array);

void Split (int [,] array)
{
for (int i = 1; i <= array.Length; i++)
{
    array[index_i, index_j] = i;
    steps --;
    if (steps == 0) 
    {
        steps = rows - 1 - tern/2;
        int temp = change_i;
        change_i = change_j;
        change_j = -temp;
        tern++;
        
    }
    index_i += change_i;
    index_j += change_j;
}
}
Console.WriteLine();
Console.WriteLine("Массив 4 на 4 заполненный спиралью: ");
PrintArray(array);
Console.WriteLine();



void FillArray(int[,] array)
{
    Random random = new Random(); 
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(0,10);
        }
    }
}
void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i< rows; i++)
        {
            for (int j = 0; j < columns; j++ )
            Console.Write(array [i, j] + "\t");
            Console.WriteLine();
        }
}
}
Zadacha58();
