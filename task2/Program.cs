Console.WriteLine("Введите первое чило: ");
int namber1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе чило: ");
int namber2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье чило: ");
int namber3 = int.Parse(Console.ReadLine());

int max = namber1;

while (max <namber2){
    max = namber2;
}
while (max <namber3){
        max = namber3;
    }

 Console.WriteLine("Наибольшее:" + max);