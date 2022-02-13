//26 Возведите число А в натуральную степень B используя цикл

Console.WriteLine("Введите первое число: ");
int numA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int numB = int.Parse(Console.ReadLine());

int count = 1;
int result = 1;

while (count <= numB)
{
    result = result * numA;
    count++;
}

Console.WriteLine("Первое число в степени второго = " + result);