int valor, res;

string Imenu()
{
    Console.WriteLine("Digite um valor: ");
    return Console.ReadLine();
}

valor = retornaErro();
res = fatorial(valor);

Console.WriteLine($"O fatorial de {valor} é: {res}");

int retornaErro()
{
    string stringValor = Imenu();
    int num;
    if (!int.TryParse(stringValor, out num))
    {
        Console.WriteLine("Informe um número válido");
        return retornaErro();
    }
    else
    {
        if ((num > 12)||(num < 0))
        {
            Console.WriteLine("O valor extrapola o limite");
            return retornaErro();
        }

    }
    return num;
}


int fatorial(int valor) 
{
    if (valor == 0)
    {
        return 1;
    }
    else
    {
        return (valor * fatorial(valor - 1));
    }
}