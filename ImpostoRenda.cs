using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace App
{

    class Calc_imp_renda{
      double renda;

      public Calc_imp_renda(double n)
      {
        this.renda = n;
      }

      public double calc(double calc_renda)
      {
        double r = this.renda;
        
        if((r >= 0.00) && (r <= 2000.00)){ //isento
          Console.WriteLine("Isento");
        }
        else if((r >= 2000.01) && (r <= 3000.00)) //8
        {                  
          r = r - 2000.00;
          double total = (r * 8) / 100;
          
          return Math.Round(total, 2);
          
        }
        else if((r >= 3000.01) && (r <= 4500.00)) //18
        {
          double r1 = r - 3000.00; 
          double r2 = 80.00; 
          
          double r3 = (r1 * 18) / 100;

          double total = r2 + r3;

          return Math.Round(total, 2);
        }
        else // 28
        {
          double r1 = r - 4500.00; 
          double r2 = 80.00;
          double r3 = 270.00;
            
          double r4 = (r1 * 28) / 100;

          double total = r2 + r3 + r4;

          return Math.Round(total, 2);
          
        }
        return 0;
      }  
    } 
  
    class Program
    {
      static void Main(string[] args)
      {  
        Console.WriteLine("Renda: ");
        double n = double.Parse(Console.ReadLine());

        Calc_imp_renda rec_fed = new Calc_imp_renda(n);

        Console.WriteLine($"Total: R${rec_fed.calc(n)}");

      }
    }
}

/*
0 a 2000 = isento

2000.01 a 3000 = 8%

3000.01 a 4500 = 18%

++ 4500 = 20%



2.5000-2000 =500 %8


3500 - 2000 = 1500 18%
3500 - 2000 = 1500 %18

3002,00 = 1002
1000 %8
2 % 18%

*/
