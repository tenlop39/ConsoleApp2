// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Object Oriented Programing = Creating my own datatype

//Single Responsibility Principle. What?? kazdy soubor by mel mit pouze jeden ucel?

using Classes_nad_objects_OOP; //co to je a proc mi to bez toho nefunguje, kdyz to v tutorialu nema?



Person person = new Person();

Console.WriteLine("Napis svoje jmeno:");
person.FirstName = Console.ReadLine();

Console.WriteLine("Napis svoje prostredni jmeno:");
string prostredniJmeno = Console.ReadLine();

Console.WriteLine("Napis svoje prijmeni:");
person.LastName = Console.ReadLine();

Console.WriteLine("napis svuj vek:");
person.Age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Napis svuj plat:");
int plat = Convert.ToInt32(Console.ReadLine());
person.setPlat(plat);

Console.WriteLine("napis mi nejake tajemstvi:");
string tajemstvi = Console.ReadLine();
person.setTajemstvi(tajemstvi);


//int rokNarozeni = DateTime.Now.Year - person.Age;
person.rokNarozeni();


Console.WriteLine();
//Console.WriteLine($"Tvoje cele jemno je: {person.FirstName} {person.LastName}"); zruseno, vytvorena metado v pesron, ktera slucuje jm. a prijm.
//Console.WriteLine($"Tvoje cele jemno je: {person.fullName()}");    presunuto, vytvoren if pro prostredni jmeno
if (string.IsNullOrEmpty(prostredniJmeno))
{
    Console.WriteLine($"Tvoje cele jemno je: {person.fullName()}");
}
else
{
    Console.WriteLine($"Tvoje cele jmeno je: {person.fullName(prostredniJmeno)}");
}

Console.WriteLine($"Tvuj vek je: {person.Age}");
Console.WriteLine($"Rok narozeni je: {person.rokNarozeni()}");
Console.WriteLine($"Tvuj plat je: {person.getPlat()}");
Console.WriteLine($"Pssst, tvoje tajemstvi bylo: {person.getTajemstvi()}");


