// Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao Multiplos", 
// indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em ordem crescente ou decrescente.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
  class Multi
  {
    int a, b;
       
    public Multi(int a, int b){
      if(a>b){
        this.a = a;
        this.b = b;
      }else{
        this.a = b;
        this.b = a;
      }
    }
    
    public string calculo(){
      if(this.a % this.b == 0){
        
        return "Sâo Multiplos";
      }else{
        return "Não são Multiplos" ;
      }
    }
  }
    class Program
    {
        static void Main(string[] args)
        {
          int n1, n2;
          
          Console.WriteLine("N1: ");
          n1 = Int32.Parse(Console.ReadLine());
          
          Console.WriteLine("N2: ");
          n2 = Int32.Parse(Console.ReadLine());
          
          Multi x = new Multi(n1, n2);    
          Console.WriteLine(x.calculo());
        }
    }
}
