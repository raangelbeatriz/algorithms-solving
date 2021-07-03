using System;

namespace HighestAndLowest
{
    using System;

public class Kata
{
  public string HighAndLow(string numbers)
  {
    String [] Numbers = numbers.Split(" ");
    int length = Numbers.Length;

    int [] NumbersInt = new int[length];
    int nHigher = Int32.Parse(Numbers[0]);
    int nLower = Int32.Parse(Numbers[0]);
    
    for(int i = 0; i <= length-1; i++){
      NumbersInt[i] = Int32.Parse(Numbers[i]);
    }
     
   foreach (int n in NumbersInt){
      if (nHigher < n){
        nHigher = n;
      }
      if (nLower > n){
        nLower = n;
      }
   }
   String answer = nHigher + " " + nLower;
   Console.WriteLine(answer);
   return answer;
  }


}
class Program
{
    static void Main(string[] args)
    {
        Kata k = new Kata();
        k.HighAndLow("2 3 4 6 -2 70 90 -6");
    }
}
}
