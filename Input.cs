using System;

class MainClass {
  public static void Main (string[] args) {
    string name;
    Console.WriteLine ("What's you're name?");
     
    // type your name into the console.
    name = Console.ReadLine();
    Console.WriteLine("Oh, hello " + name );
  }
}