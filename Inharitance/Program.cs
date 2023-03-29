// See https://aka.ms/new-console-template for more information
// inheritance = shareing properties with sombady else

using Inharitance;



Console.WriteLine("enter length:");
int length = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("enter width:");
int width = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("enter heigt:");
int height = Convert.ToInt32(Console.ReadLine());


//var cube = new Cube(); // var si samo najde ze cube je tridy Cube
//var triangle = new Triangle();
//var rectangle = new Rectangle();

var cube = new Cube(width, height, length);

var triangle = new Triangle();
var triangle2= new Triangle() { Length = length, Height = height, Hypotenuese=10 };
var triangle1 = new Triangle(10);

var rectangle = new Rectangle() { Length = length, Width = width };

//var cube = new Cube() {Width=width, Length=length, Height=height};
//var triangle = new Triangle() { Length =length, Height=height};
//var rectangle = new Rectangle() {Length=length, Width=width};

//prirazeni hodnot promennych do property
//jiz neni potreba definovano pri tvoreni instance
//cube.Length = length;
//cube.Width = width;
//cube.Height = heigt;

//triangle.Length = length;
//triangle.Height = heigt;

//rectangle.Length = length;
//rectangle.Width = width;

Console.WriteLine($"Cube area is: {cube.GetArea()}");
Console.WriteLine($"Cube volume is: {cube.GetVolume()}");

Console.WriteLine($"Triangle area is: {triangle.GetArea()}");
Console.WriteLine($"Triangle area is: {triangle1.GetArea()}");
Console.WriteLine($"Triangle area is: {triangle2.GetArea()}");

Console.WriteLine($"Rectangle area is: {rectangle.GetArea()}");
