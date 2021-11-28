int[] array = {1, 5, 4, 19, 8, 15, 7, 4, 10};

int n = array.Length;
int find = 4;

int index = 0;

while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index = index + 1;
}