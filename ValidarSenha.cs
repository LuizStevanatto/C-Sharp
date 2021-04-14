using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
  class Valid{
    
    int password = 2002;
  
    public bool verifc(int n){
      if(n == this.password)
      {
        return true;
      }
      else
      {
        return false;
      }   
    }   
  }

    class Program
    {
        static void Main(string[] args)
        {
          int n;

            Valid fds = new Valid();

            do{
              Console.WriteLine("Senha: ");
              n = Int32.Parse(Console.ReadLine());
              fds.verifc(n);
              
              if(fds.verifc(n) == false){
                Console.WriteLine("Senha Inválida");
              }
              else{
                Console.WriteLine("Senha Correta");
              }
                
            }while(fds.verifc(n) == false);
        }
    }
}
