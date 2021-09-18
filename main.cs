using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter Salesperson Name");
    var nam1 = Console.ReadLine();

    Console.WriteLine ("Enter Sales Amount");
    var amo1 = Console.ReadLine();

    double amo2 = Convert.ToDouble(amo1);
    double x = .09;
    int y = 200;
    var amo3 = ((x*amo2)+y);
    Console.Write("Sales commission for ");
    Console.Write(nam1);
    Console.Write(" is $");
    Console.WriteLine(amo3);

    if (amo2 >=15000)
    {
      Console.WriteLine("Performance is Outstanding");
    }
    else if (amo2 >=10000)
    {
      Console.WriteLine("Performance is Excellent");
    }
    else if (amo2 >=5000)
    {
      Console.WriteLine("Performance is Good");
    }
    else if (amo2 >=3000)
    {
      Console.WriteLine("Performance is Average");
    }
    else
    {
      Console.WriteLine("Performance is Poor");
    }
  }
}