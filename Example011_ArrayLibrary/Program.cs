void FillArr(int[] collection)
{
  int lenght = collection.Length;
  int index = 0;
  while (index < lenght)
  {
    collection[index] = new Random().Next(1, 10);
    index++;
  }
}
void PrintArr(int[] coll)
{
  int count = coll.Length;
  int position = 0;
  while (position < count)
  {
    Console.Write($"{coll[position]} ");
    position++;
  }
}

int FindInArr(int[] collection, int find)
{
  int lenght = collection.Length;
  int index = 0;
  int position = -1;
  while (index < lenght)
  {
    if (collection[index] == find)
    {
      position = index;
      break;
    }
    index++;
  }
  return position;
}

int[] Arr = new int[10];

FillArr(Arr);
PrintArr(Arr);
Console.WriteLine();
int pos = FindInArr(Arr, 4);
Console.WriteLine(pos);