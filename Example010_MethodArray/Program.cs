int[] array = { 15, 24, 32, 14, 53, 46, 75, 88 };
int n = array.Length;
int find = 53;
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index +=1;
}
