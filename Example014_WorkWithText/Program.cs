//=====Работа с текстом======
//Дан текст, в котором необходимо все пробелы заменить 
//черточками, маленькие буквы "к" заменить большими "К",
//а большие "C" заменить маленькие "с".

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
+ "ежели бы вас послали вместо нашего милого Винцегороде,"
+ "вы бы взяли приступом согласие прусского короля. "
+ "Вы так красноречивы. Вы дарите мне чаю?";

string Replace(string text, char oldValue, char newValue)
{
  string result = String.Empty;

  int length = text.Length;
  for (int i = 0; i < length; i++)
  {
    if (text[i] == oldValue) result +=$"{newValue}";//результат записывается посимвольно, заменяя
    else result += $"{text[i]}";                    //заменяя старый символ на новый
  }
  return result;
}
string newText = Replace(text, ' ', '_');
Console.WriteLine(newText);
Console.WriteLine();
string nextNewText = Replace(newText, 'к', 'К');
Console.WriteLine(nextNewText);
Console.WriteLine();
string finalText = Replace(nextNewText, 'С', 'с');
Console.WriteLine(finalText);

