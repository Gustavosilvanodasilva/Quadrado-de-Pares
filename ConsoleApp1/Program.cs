double valor1;

Console.WriteLine("Informe o valor 1");
valor1 = Convert.ToDouble(Console.ReadLine());

for(int i =2; i <= valor1; i++)
{

    if (i % 2 == 0)
    {
        Console.WriteLine("O quadrado é : " + i*i);
    }
}