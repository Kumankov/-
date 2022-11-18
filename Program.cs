 Console.WriteLine("введите число от 2 до 9:");
int N = int.Parse(Console.ReadLine());
int i = 1;
while (i<=10)
{
    Console.Write(N);
    Console.Write(" * ");
    Console.Write(i);
    Console.Write(" = ");
    Console.WriteLine(N*i);
    i++;
}
