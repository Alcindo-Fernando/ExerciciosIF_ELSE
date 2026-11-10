int idade = 0;

Console.WriteLine("digite sua idade: ");
idade = int.Parse(Console.ReadLine());

if(idade >= 0)
{
    if(idade >= 0 && idade <= 12)
    {
        Console.WriteLine("Crianca");
    }else if(idade > 12 && idade < 18)
    {
        Console.WriteLine("adolescente");
    }else if(idade >= 18 && idade < 60)
    {
        Console.WriteLine("adulto");
    }
    else
    {
        Console.WriteLine("idoso");
    }
}
else
{
    Console.WriteLine("idade invalida");
}

Console.ReadKey();
