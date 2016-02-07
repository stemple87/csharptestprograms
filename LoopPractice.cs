using System;

class LoopPractice
{
  static void Main()
  {
    string[] friends = {"Ramon", "Brendan", "Justin", "Megan", "Kenney"};
    foreach (string pal in friends)
    {
      Console.WriteLine(pal + " is my friend");
    }
  }
}
