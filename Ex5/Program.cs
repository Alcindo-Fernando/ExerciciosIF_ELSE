int ano = 0;

Console.WriteLine("informe o ano: ");
ano = int.Parse(Console.ReadLine());

if(ano > 0)
{
    if(ano % 4 == 0)
    {
        if(ano % 400 != 0 && ano % 100 == 0)
        {
            Console.WriteLine("nao bissexto");
        }
        else
        {
            Console.WriteLine("bissexto");
        }
    }
    else
    {
        Console.WriteLine("nao bissexto");
    }
}

Console.ReadKey();