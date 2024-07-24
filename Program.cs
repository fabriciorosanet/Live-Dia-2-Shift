/*int n1  = 67;
int n2 = 67;
int n3 = -45;
int n4 = 45;

int numero;


Console.Write("Digite um número: ");
numero = Convert.ToInt32(Console.ReadLine());    

if (numero < 0) 
{
    numero = numero * -1;
}

Console.WriteLine(numero); 

*/

/* Desvio Simples

int idade;

Console.Write("Digite sua idade: ");

idade = Convert.ToInt32(Console.ReadLine());

if (idade >= 12)
{
    Console.WriteLine("Boaaa! Você tem a idade necessária para jogar.");
}

*/

/*//Desvio Composto

int idade;

Console.Write("Digite sua idade: ");

idade = Convert.ToInt32(Console.ReadLine());

if (idade >= 12)
{
    Console.WriteLine("Boaaa! Você tem a idade necessária para jogar.");
}
else 
{
    Console.WriteLine("Que pena! Você não tem a idade necessária para jogar.");
}


int idade;

Console.Write("Digite sua idade: ");

idade = Convert.ToInt32(Console.ReadLine());

if (idade >= 18)
{
    Console.WriteLine("Maior de idade");
}
else
{
    Console.WriteLine("Menor de idade");
}

*/

double venda;

Console.Write("Venda R$ ");

venda = Convert.ToDouble(Console.ReadLine());

if (venda > 500)

{

    // calcular 12% de desconto

    venda = venda * 0.88;

}

else

{

    venda = venda * 0.94;

}

Console.WriteLine($"Novo valor: R$ {venda}");
