using System;

class Program 
{
  public static void Main (string[] args) 
  {
    Console.WriteLine("Введите количество элементов: ");
    int size = Int32.Parse(Console.ReadLine());
    string[] array = new string[size];
    FillArray(array);
    PrintArray(array);
    int mas_size = SizeArray(array);

    string[] mas = new string[mas_size];
    Console.WriteLine();
    PrintArray(Metod(array, mas));

    string[] Metod (string[] array, string[] mas)
    {
      int y = 0;
      for (int e = 0; e < array.Length; e++)
      {
        if (y < 3)
        {
          if (array[e] == "2" || array[e] == "-2" || array[e] == ":-)")
          {
            mas[y] = array[e];
            y++;
          }
        }
      }
      return mas;
    }
  }
}