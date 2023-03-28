// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

void PrintName()
{
    Console.WriteLine("jemno");
}

void Soucet(int cislo1, int cislo2)
{
    Console.WriteLine($"coucet cisla {cislo1} a {cislo2} je: {cislo1 + cislo2} ") ;
}

int NejvetsiCislo( int cislo1, int cislo2, int cislo3)
{
    int nejvetsi = cislo1;

    if (nejvetsi < cislo2)
    {
        nejvetsi = cislo2;
    }
    if (nejvetsi < cislo3)
    {
        nejvetsi = cislo3;
    }

    return nejvetsi;

}

Console.WriteLine("napis cislo 1");
int c1= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("napis cislo 2");
int c2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("napis cislo 3");
int c3 = Convert.ToInt32(Console.ReadLine());


Soucet(c1,c2);

PrintName();

int result = NejvetsiCislo(c1, c2, c3);
Console.WriteLine($"nejvetsi cislo je: {result}");
//or
Console.WriteLine($"nejvetsi cislo je: {NejvetsiCislo(c1,c2,c3)}");
