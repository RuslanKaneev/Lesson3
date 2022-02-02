// See https://aka.ms/new-console-template for more information
char[,] MorskoyBoi =
{
    {'O','O','O','O','O','O','O','O','O','O'},
    {'O','X','O','X','O','O','X','O','O','X'},
    {'O','X','O','O','O','O','X','O','O','O'},
    {'O','X','O','X','O','O','X','O','O','O'},
    {'O','X','O','X','O','O','O','O','O','O'},
    {'O','O','O','O','O','O','O','O','O','O'},
    {'O','O','X','O','X','O','O','X','O','O'},
    {'O','O','X','O','X','O','O','X','O','O'},
    {'X','O','O','O','O','O','X','X','O','O'},
    {'O','O','O','O','O','O','O','O','O','O'},
};

for (int i = 0; i < MorskoyBoi.GetLength(0); i++)
{
    for (int j = 0; j < MorskoyBoi.GetLength(1); j++)
    {
        Console.Write($"{MorskoyBoi[i,j]}");
    }
    Console.WriteLine();
}

