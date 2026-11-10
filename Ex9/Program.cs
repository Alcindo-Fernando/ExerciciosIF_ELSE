int ladoA = 0;
int ladoB = 0;
int ladoC = 0;
bool existe = false; 

Console.WriteLine("informe o primeiro lado do triangulo: ");
ladoA = int.Parse(Console.ReadLine());

Console.WriteLine("informe o segundo lado do triangulo: ");
ladoB = int.Parse(Console.ReadLine());

Console.WriteLine("informe o terceiro lado do triangulo: ");
ladoC = int.Parse(Console.ReadLine());

if(ladoA < (ladoB + ladoC) && ladoB < (ladoA + ladoC) && ladoC < (ladoB + ladoA))
{
    existe = true;
}
else
{
    Console.WriteLine("Esse triangulo nao e possivel");
    existe = false;
}

if (existe)
{
    if(ladoA == ladoB &&  ladoB == ladoC)
    {
        Console.WriteLine("Equilatero");
    }else if(ladoA != ladoB && ladoB == ladoC || ladoA == ladoC && ladoB != ladoA || ladoA == ladoB && ladoC != ladoA)
    {
        Console.WriteLine("Isoceles");
    }
    else
    {
        Console.WriteLine("Escaleno");
    }
}

Console.ReadKey();
