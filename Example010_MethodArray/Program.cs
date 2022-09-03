int[] array = { 1, 45, 24, 4, 6, 59, 6, 8, 17 };

int n = array.Length;
int find = 6;

int index = 0;

while (index < n)
{
  if (array[index] == find)
  {
    Console.WriteLine(index);
    break;
  }
  index++;
}

