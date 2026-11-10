
double numero1 = 0.0;
double numero2 = 0.0;
double resultado = 0.0;
int opcao = 0;

Console.WriteLine(" ---Escolha as opcoes--- ");
Console.WriteLine("1. multiplicar");
Console.WriteLine("2. somar");
Console.WriteLine("3. dividir");
Console.WriteLine("4. subtrair");
opcao = int.Parse(Console.ReadLine());
switch (opcao)
{
    case 1:
        Console.WriteLine(" multiplicar ");
        break;

    case 2:
        Console.WriteLine("somar");
        break;

    case 3:
        Console.WriteLine("dividir");
        break;

    case 4:
        Console.WriteLine("subtrair");
        break;

    default:
        Console.WriteLine("opcao nao cadastrada");
        Console.ReadKey();
        return;

}

Console.WriteLine("Informe o primeiro número");
numero1 = double.Parse(Console.ReadLine());

Console.WriteLine("Informe o segundo número");
numero2 = double.Parse(Console.ReadLine());

if(opcao == 1)
{
    resultado = numero1 * numero2;
}else if(opcao == 2)
{
    resultado = numero1 + numero2;
}else if(opcao == 3)
{
    resultado = numero1 / numero2;
}
else
{
    resultado = numero1 - numero2;
}

Console.WriteLine("Resultado = " + resultado);

Console.ReadKey();

