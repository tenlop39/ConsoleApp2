// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Microsoft.VisualBasic;

List<string> names = new List<string>();
string name = string.Empty;
//vkladani do listu
names.Add("osoba");

Console.WriteLine("Seznam jmen ");

//while (!name.Equals("-1"))
//while (name.Equals("-1")==false)
while (name != "-1")
{
    Console.WriteLine("napis jmeno: ");
    name = Console.ReadLine();
    if (!string.IsNullOrEmpty(name) && !name.Equals("-1"))
    {
        
        names.Add(name);
        Console.WriteLine($"{name} bylo vlozeno do listu");
        Console.WriteLine();
    }
}


//vypsani listu
Console.WriteLine("zadana jmeno for loop: ");
for (int i = 0; i < names.Count; i++)
{
    Console.WriteLine(names[i]);
}

Console.WriteLine();

Console.WriteLine("zadana jmena foreach loop");
foreach (string item in names)
{
    Console.WriteLine(item);
}