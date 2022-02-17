//Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

int[] array = new int[8];
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(0,2);
        index++;
    }
}
void PrintArray(int[] coll)
{
    int count = coll.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{coll[position]} ");
        position ++;
    }

}
FillArray(array);
PrintArray(array);