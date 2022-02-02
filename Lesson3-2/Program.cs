// See https://aka.ms/new-console-template for more information
string[,] TelefonSprav = { { "Руслан", "8916000000" }, { "Дмитрий", "8915000000" }, { "Рамзан", "8910000000" }, { "Владимир", "8917000000" }, { "Александр", "8919000000" } };
for (int i = 0; i < TelefonSprav.GetLength(0); i++)

{
    for (int j = 0; j < TelefonSprav.GetLength(1); j++)
    {
        Console.Write($"{TelefonSprav[i,j]} ");
    }
    Console.WriteLine();
}
Console.ReadLine();