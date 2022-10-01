Console.WriteLine("Введите чило: ");
int N = int.Parse(Console.ReadLine());

int A = N / N;
while (A <= N)
{
    if (A % 2 == 0)
    {
        Console.Write(A);
        Console.Write(", ");
        A = A + 1;
    }
      else
    {
        A = A + 1;
    }
}
