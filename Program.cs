using System;

namespace Atividade_16_11
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Digite a operação que deseja fazer \nSoma,Subitração,Multiplicação,Divisão");
           string operação = Console.ReadLine();

            Console.WriteLine("Digite o 1 número");
            float num1 = float.Parse(Console.ReadLine());


            Console.WriteLine("Digite o 2 número");
            float num2 = float.Parse(Console.ReadLine());

            float resultado = 0;

            switch(operação){

                case "Soma":
                    resultado = num1+num2;
                    break;
                case "Subritação":
                    resultado = num1-num2;
                    break;

                case "Divisão":
                    resultado = num1/num2;
                    break;

                default:
                    Console.WriteLine("Operaçao nvalida");
                    break;
            }

                
            
        
            
            
        }
    }
}
