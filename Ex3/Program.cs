
float nota1 = 0.0f;
float nota2 = 0.0f;
float nota3 = 0.0f;
float nota4 = 0.0f;
float media = 0.0f;


Console.WriteLine("Informe a primeira nota: ");
nota1 = float.Parse(Console.ReadLine());

Console.WriteLine("Informe a segunda nota: ");
nota2 = float.Parse(Console.ReadLine());


Console.WriteLine("Informe a terceira nota: ");
nota3 = float.Parse(Console.ReadLine());


Console.WriteLine("Informe a quarta nota: ");
nota4 = float.Parse(Console.ReadLine());


media = ((nota1 + nota2 + nota3 + nota4) / 4);

Console.WriteLine("Média: " +media);

if (media >= 7)
{
    Console.WriteLine("Aprovado!");
}
else if (media > 5 || media < 7)
{
    Console.WriteLine("Recuperação!");

}
else
{
    Console.WriteLine("Reprovado!");
}


Console.ReadKey();