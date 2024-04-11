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
    Console.WriteLine("Введите максимальное количество элементов второй строки: ");
    int new_mas_size = Int32.Parse(Console.ReadLine());
    
    int mas_size = SizeArray(array, new_mas_size);

    string[] mas = new string[mas_size];
    Console.WriteLine();
    PrintArray(Metod(array, mas, mas_size));

    string[] Metod (string[] array, string[] mas, int mas_size)
    {
      int y = 0;
      for (int e = 0; e < array.Length; e++)
      {
        if (y < mas_size)
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

    int SizeArray (string[] array, int new_mas_size)
    {
      int k = 0;
      for (int h = 0; h < array.Length; h++)
      {
        if (k < new_mas_size)
        {
          if (array[h] == "2" || array[h] == "-2" || array[h] == ":-)")
          {
            k++;
          }
        }
      }
      return k;
    }

    void FillArray(string[] array)
    {
      for (int i = 0; i < size; i++)
      {
        Console.WriteLine("Введите элемент: ");
        array[i] = Console.ReadLine();
      }
    }

    void PrintArray(string[] array, int j = 0)
    {
      if (j < array.Length)
      {
        Console.Write($"{array[j]}\t");
        PrintArray(array, j + 1);
      }
    }
  }
}