
int a = 0;
int b = 0;

Console.WriteLine("digite um número: ");
a = int.Parse(Console.ReadLine());

Console.WriteLine("digite outro número: ");
b = int.Parse(Console.ReadLine());

if (a == b)
{
    Console.WriteLine("são iguais");
}
else if(a > b)
{
    Console.WriteLine(a + " é maior que " + b);
}else
{
    Console.WriteLine(b + " é maior que " + a);
}


Console.ReadKey();
