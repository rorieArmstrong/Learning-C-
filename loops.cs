using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
    int[] newArray = { 1, 2, 3, 4, 5 };

      for(int i = 0; i < newArray.Length; i++)
      {
        Console.WriteLine(newArray[i]);
      }

        Console.ReadLine();
  }
}