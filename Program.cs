int[,] Create2Dmassive (int MinValue,int MaxValue,int rows, int colums)
{
    int[,] Newarray = new int [rows,colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            Newarray[i,j]= new Random().Next(MinValue,MaxValue+1);

        }

    }
        return Newarray;
}

void Show2dArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array [i,j]+ " ");


        }
        Console.WriteLine();
    }

}
Show2dArray( Create2Dmassive(0,9,4,4));