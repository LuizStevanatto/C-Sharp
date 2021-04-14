using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
  class Conta 
  {
     
    public int numConta;
    public string nome;
    private double saldo;

    public Conta(string nome, int num){
      this.nome = nome;
      this.numConta = num;
      this.saldo = 0;
    }


    public double sacar(double valor){
      double taxa = 5;
      double saque = taxa + valor;
      this.saldo -= saque;
      return this.saldo;
    }

    public double depositar(double valor){
      this.saldo += valor;
      return this.saldo;
    }
    
    public double getSaldo()
    {
      return this.saldo;
    }

    public void setSaldo(double saldo)
    {
      this.saldo = saldo;
    }
  }
  


  class MainClass
  {

    public static void CriarCadastro(){
      
      Console.WriteLine("Nome: ");
      string nome = Console.ReadLine();

      Console.WriteLine("Numero da conta: ");
      int numConta = Int32.Parse(Console.ReadLine());

      Conta c = new Conta(nome, numConta);
      

      Console.WriteLine("Deseja depositar valor Inicial? [S/N]");
      string op = Console.ReadLine();
      
      if(op == "s"){
        op = "S";
      }

      if(op == "n"){
        op = "N";
      }

      double saldo;
      switch (op){
          case "S":
              Console.WriteLine("Digite o valor do deposito");
              saldo = double.Parse(Console.ReadLine());  
              c.setSaldo(saldo);
            break;

          case "N":
              saldo = 0;
              c.setSaldo(saldo);            
            break;


          default:
              Console.Clear();
              MainClass.CriarCadastro();
            break;      
                
        }   

        Console.Clear();

        while(true){

          System.Threading.Thread.Sleep(3300);
          Console.Clear();
          Console.WriteLine("\n-----------------------------");
          Console.WriteLine(" 1 | Ver Saldo");
          Console.WriteLine(" 2 | Sacar Valor");
          Console.WriteLine(" 3 | Depositar Valor");
          Console.WriteLine(" 0 | Sair ");   
          Console.WriteLine("-----------------------------");

          int op1 = Int32.Parse(Console.ReadLine());

          switch (op1){
            
            
            case 1:

                Console.WriteLine($"\nTitular: {c.nome}");
                Console.WriteLine($"Numero da Conta: {c.numConta}");
                Console.WriteLine($"Saldo: R${c.getSaldo()}");
                
              break;

            case 2:

              Console.WriteLine("\nValor: ");
              double v = double.Parse(Console.ReadLine());
            
              Console.WriteLine(c.sacar(v));

              break;
            
            case 3:

              Console.WriteLine("\nValor: ");
              v = double.Parse(Console.ReadLine());
            
              Console.WriteLine(c.depositar(v));

              break;

            case 0:
                Console.Clear();
                MainClass.CriarConta();
              break;
          }
        }


      }
    

    public static void CriarConta()
    {

      Console.WriteLine("-----------------------------");
      Console.WriteLine(" 1 | Criar Conta");
      Console.WriteLine(" 0 | Sair");
      Console.WriteLine("-----------------------------");
      
      int op = Int32.Parse(Console.ReadLine());
      
      switch (op) {

        case 1:
            MainClass.CriarCadastro();
          break;

        case 0:
            return;
          break;

        default:
            Console.Clear();
            Console.WriteLine("[!] | Opção inválida");
            MainClass.CriarConta();
          break;

      }
      
    }

    
    static void Main(string[] args)
    {
      
      MainClass.CriarConta();
      

    }
  }
}

