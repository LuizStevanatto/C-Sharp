using System;

class MainClass {

  class Calculator
    {
        public float sum(float n1, float n2){

          float total = n1 + n2;
          return total;

        }

        public float dif(float n1, float n2){

          float total = n1 - n2;
          return total;

        }

        public float times(float n1, float n2){

          float total = n1 * n2;
          return total;

        }

        public float div(float n1, float n2){

          if (n2 == 0){
            Console.WriteLine("Não pode ser divido por 0");
            return 0;
          }else{
            float total = n1 / n2;
            return total;
          }                  
        }
    }


    public static void Menu(){
      int op;
      
        Console.WriteLine("--------------------------------");
        Console.WriteLine("           Calculator           ");
        Console.WriteLine("--------------------------------");

        Console.WriteLine("1 | Soma");
        Console.WriteLine("2 | Subtração");
        Console.WriteLine("3 | Multiplicação");
        Console.WriteLine("4 | Divisão");
        Console.WriteLine("0 | Sair");

        op = Int32.Parse(Console.ReadLine());


      Calculator calc = new Calculator();
      float n1, n2;

      switch(op){
      
        case 1:            
            Console.WriteLine("Digite N1: ");
            n1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Digite N2: ");
            n2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine(calc.sum(n1,n2));
            MainClass.Menu();
          break;
      
        case 2:            
            Console.WriteLine("Digite N1: ");
            n1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Digite N2: ");
            n2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine(calc.dif(n1,n2));
            MainClass.Menu();
          break;

        case 3:            
            Console.WriteLine("Digite N1: ");
            n1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Digite N2: ");
            n2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine(calc.times(n1,n2));
            MainClass.Menu();
          break; 

        case 4:            
            Console.WriteLine("Digite N1: ");
            n1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Digite N2: ");
            n2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine(calc.div(n1,n2));
            MainClass.Menu();
          break;  

        case 0:
            return;
          break;

        default:
          MainClass.Menu();
          break;                
      }
    }
  public static void Main (string[] args) {
    
    MainClass.Menu();
  }
}