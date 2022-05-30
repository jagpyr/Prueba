using Prueba;

//1
Console.WriteLine("Ingrese un número: ");
int num = Convert.ToInt32(Console.ReadLine());

Metodos.SumaMultiplos(num);

//2
String frs = "";
Console.WriteLine("Ingrese una frase: ");
frs = Console.ReadLine();

Metodos.CamelCase(frs);

//3
String frase = "";
Console.WriteLine("Ingrese una frase: ");
frase = Console.ReadLine();

Metodos.invertirPalabras(frase);