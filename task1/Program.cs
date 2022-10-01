Console.WriteLine("Введите первое чило: ");
int namber1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int namber2 = int.Parse(Console.ReadLine());

if (namber1 > namber2)
{
    Console.Write("Наибольшее число: " + namber1);
} 
else
{
    Console.Write("Наибольшее число: " + namber2);
}