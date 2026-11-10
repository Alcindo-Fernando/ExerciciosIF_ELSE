int altura = 0;
double peso = 0.0;
double alturaMetro = 0.0;
double IMC = 0.0;
bool verificacao = false;

Console.WriteLine("Coloque a sua altura em cm: ");
altura = int.Parse(Console.ReadLine());

Console.WriteLine("Coloque seu peso: ");
peso = double.Parse(Console.ReadLine());

if (altura <= 0 || peso <= 0)
{
    verificacao = false;
    Console.WriteLine("peso ou altura invalidos");
}
else
{
    verificacao = true;
}

if(verificacao) { 
    alturaMetro = (double)altura / 100;

    IMC = peso/(alturaMetro * alturaMetro);

    Console.WriteLine("IMC = " + IMC);

    if(IMC < 18.5)
    {
        Console.WriteLine("faixa abaixo");
    }else if(IMC < 25)
    {
        Console.WriteLine("faixa normal");
    }
    else
    {
        Console.WriteLine("faixa acima");
    }
}
Console.ReadKey();

