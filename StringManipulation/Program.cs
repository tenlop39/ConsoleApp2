// See https://aka.ms/new-console-template for more information
// arrays

//int[] grades = new int[5];
//grades[0] = 1;
//grades[1] = 2;
//grades[2] = 3;
//grades[3] = 4;
//grades[4] = 5;
//Console.WriteLine(grades[0]);
//Console.WriteLine();

int pocetZaku = 0;

Console.Write("napis kolik zaku hodnotis: ");
pocetZaku = Convert.ToInt32(Console.ReadLine());
int[] grades = new int[pocetZaku];



//ore

//int[] znamka = new int[] { 1, 2, 3, 4, 5 };
//Console.WriteLine(znamka);

//for (int i = 0; i < znamka.Length; i++)
//{
//    Console.WriteLine("znamka je: " + znamka[i]);
//}

//ore
Console.WriteLine();
for (int i=0 ;i < grades.Length; i++)
{
    Console.Write("napisi znamku: ");
    grades[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("znamky ktere jsi napsal");
for (int i=0 ; i < grades.Length; i++)
{
    Console.Write(grades[i] + " ");
}


//strin array
Console.WriteLine();

string[] jmenoStudenta = new string[pocetZaku];

for (int i=0 ; i < jmenoStudenta.Length; i++)
{
    Console.Write("napis jmeno studenta: ");
    jmenoStudenta[i] = Console.ReadLine();
}

Console.WriteLine(
    );
for (int i=0 ; i<jmenoStudenta.Length ; i++)
{
    Console.WriteLine("tohle jsou jmena studentu: " + jmenoStudenta[i] + " a jejich znamky " + grades[i]);
}
