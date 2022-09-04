// Вид 1(Ничего не принимают, ничего не возвращают)
void Method1()
{
  Console.WriteLine("Просто вывести этот текст");
}

//Method1();

//Метод 2 (Что-то принимают, ничего не возвращают)
void Method2(string msg)
{
  Console.WriteLine(msg);
}

//Method2("Это текст сообщения");

void Method21(string msg, int count)
{
  for (int i = 0; i < count; i++)
  {
    Console.WriteLine(msg);
  }
}

Method21("Text", 4);
Method21(count: 4, msg: "text"); // Присваивание значений аргументам

//Вид 3(Ничего не принимают, что-то возвращают)
int Method3()
{
  return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);

//Вид 3(Что-то принимают, что-то возвращают)
string Method4(int count, string text)
{
  string res = string.Empty;
  for (int i = 0; i < count; i++)
  {
    res += text;
  }
  return res;
}
string resault = Method4(count: 5, text: "qwerty");
Console.WriteLine(resault);

