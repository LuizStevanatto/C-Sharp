// Fazer um programa que leia o número de identificação de um funcionário, seu número de horas trabalhadas, o valor que recebe por hora e 
// calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas decimais.

using System;


class MainClass {

  class Calc_sal_fun{
    double hrs, valor_hrs, sal;

    public double calc_Sal(){  
      double hrs, valor_hrs, sal;
    
      Console.WriteLine("Horas Trabalhadas: ");
      hrs = double.Parse(Console.ReadLine());

      Console.WriteLine("Preço Por Hora: ");
      valor_hrs = double.Parse(Console.ReadLine());
      
      sal = (hrs * valor_hrs);
      return Math.Round(sal, 2);
    } 
  }

  public static void Main (string[] args)
  {
    double id;
    Console.WriteLine("Id: ");
    id = Int32.Parse(Console.ReadLine());

    Calc_sal_fun f = new Calc_sal_fun();  
    Console.WriteLine($"ID NUMBER = {id} \nSalário: U$ {f.calc_Sal()}");   
  }
}
