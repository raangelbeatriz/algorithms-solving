using System;


namespace GrowthofPopulation
{


class Arge {
    
    
    public static int NbYear(int p0, double percent, int aug, int p) {
      int countYear = 0;
      
      while (p0 < p){
        p0 += (int)(aug + ((p0 * percent)/100));
        countYear++;
      }
      Console.WriteLine(countYear);
      return countYear;

    }
}
    class Program
    {
        static void Main(string[] args)
        {
            Arge.NbYear(1500, 5, 100, 5000);
        }
    }
}
