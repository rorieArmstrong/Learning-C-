using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
    number target;
    Console.WriteLine ("How far Should I go?");
     
    // type your name into the console.
    target = Console.ReadLine();
      
    for(int i = 0; i < target; i++)
    {
        string output = "";
        if(i%3 == 0)
        {
            output += "Fizz";
        }
        if(i%5 == 0)
        {
            output += "Buzz";
        }
        if(output == ""){
            output += i;
        }
        Console.WriteLine(output);
    }

    Console.ReadLine();
  }
}