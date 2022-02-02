// See https://aka.ms/new-console-template for more information
int[,] DiagonalMassiv =
{
    { 0,35,16,126,12},
    { 4,31,19,173,166},
    { 5,13,190,93,1},
    { 6,9,112,43,15},
    { 7,5,101,23,18}
};
Console.WriteLine("Выводится прямая диагональ");
for (int i = 0; i < DiagonalMassiv.GetLength(0); i++)
{
    for (int j = 0; j < DiagonalMassiv.GetLength(1); j++)
    {
        if (i == j)
        {
            Console.WriteLine(DiagonalMassiv[i, j]);
        }

    }
}
Console.ReadLine();
Console.WriteLine("Выводится обратная диагональ");
for (int i = 0; i < DiagonalMassiv.GetLength(0); i++)
{
    for (int j = 0; j < DiagonalMassiv.GetLength(1); j++)
    {
        if (i == DiagonalMassiv.GetLength(1)-1 - j)
        {
            Console.WriteLine(DiagonalMassiv[i,j]);
        }
        
    }

    }


Console.ReadLine();