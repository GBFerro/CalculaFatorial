int num, res;

Console.WriteLine("Digite o número: ");
num = int.Parse(Console.ReadLine());

res = 1;

for (int i = num; i > 0; i--)
{
    res *= i;
}

Console.WriteLine(res);