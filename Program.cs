class Program
{
    static void Main(string[] args)
    {   Console.Write("Input x1 : ");
     double x1 =  double.Parse(Console.ReadLine());
        Console.Write("Input y1 : ");
     double y1 =  double.Parse(Console.ReadLine());
        Console.Write("Input w1 : ");
     double w1 =  double.Parse(Console.ReadLine());
        Console.Write("Input h1 : ");
     double h1 =  double.Parse(Console.ReadLine());
        Console.Write("Input x2 : ");
     double x2 =  double.Parse(Console.ReadLine());
        Console.Write("Input y2 : ");
     double y2 =  double.Parse(Console.ReadLine());
        Console.Write("Input w2 : ");
     double w2 =  double.Parse(Console.ReadLine());
        Console.Write("Input h2 : ");
     double h2 =  double.Parse(Console.ReadLine());
    
           
       if(a > 0 && a <= 8){Console.WriteLine("Not Much Overlapping");}
       else if(a > 8){Console.WriteLine("Too Much Overlapping");}
       else {Console.WriteLine("No Overlapping");
       }
     }
}
