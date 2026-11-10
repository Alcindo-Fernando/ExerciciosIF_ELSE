float salario = 0.00f;

Console.WriteLine("informe o salario");
salario = float.Parse(Console.ReadLine());

if(salario <= 2000.00)
{
    salario = (float)(salario * 1.15);
}else if(salario > 2000.00 && salario < 4000.01)
{
    salario = (float)(salario * 1.10);
}else
{
    salario = (float)(salario * 1.05);
}

Console.WriteLine("Salario reajustado: "+salario);

Console.ReadKey();