// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите текст");
string PrivetMassiv = Console.ReadLine();

for (int j = PrivetMassiv.Length-1; j >= 0; j--)
{

   Console.Write(PrivetMassiv[j]);
   
}
Console.ReadLine();