int x = 0;

Console.WriteLine("digite um número: ");
x = int.Parse(Console.ReadLine());

if (x % 2 == 0)
{
    Console.WriteLine("esse número é par");
}
else
{
    Console.WriteLine("Esse número é ímpar");
}

Console.ReadKey();