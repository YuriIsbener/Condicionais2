using System;

namespace Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual sua idade?");
            int idade = int.Parse(Console.ReadLine());

            if(idade >= 18){
                Console.WriteLine("Você gostaria de participar do time de CS GO? - Sim ou Não");
                string resposta = Console.ReadLine();
                if (resposta == "Sim"){
                    Console.WriteLine("Compareça a secretaria - Falar com a Sara");
                }
                else{
                    Console.WriteLine("Passar bem.");
                }
            }else{
              Console.WriteLine("Você gostaria de participar do time de Lol? - Sim ou Não");
              string resposta = Console.ReadLine();
              if (resposta == "Sim"){
                    Console.WriteLine("Compareça a secretaria - Falar com Jucelino");
                        
              }else{
                  Console.WriteLine("Muito Obrigado");
                        
              }
            }
        }
    }
}
