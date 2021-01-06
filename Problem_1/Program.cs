using System;

namespace Euler.Problem_1 {
   class Program {
      static void Main(string[] args) {
         Console.WriteLine("Euler Problem 1");
         double res = mcp1(3.0, 999.0) + mcp1(5.0, 999.0) - mcp1(15.0, 999.0);
         Console.WriteLine(res);
         Console.ReadKey();
         return;
      }

      static double mcp1(double n, double m) {
         double fl = Math.Floor(m/n);
         return n*fl*(fl+1)/2;
      }
   }
}
