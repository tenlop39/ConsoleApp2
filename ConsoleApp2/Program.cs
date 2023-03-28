// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int n = 0;
Console.WriteLine("napis cislo ktere nechces prokrocit");
int max = Convert.ToInt32(Console.ReadLine());

while (n <= 5)
{
    Console.WriteLine("napis cislo");
    n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"tvoje cislo je: {n}");
}
Console.WriteLine($"napsal jsi vysi cislo nez: {max}");
