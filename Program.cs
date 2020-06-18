using System;

namespace AulaPOOcelular
{
    class Program
    {
        static void Main(string[] args)
        {
            Celular xiaomi  = new Celular();

            xiaomi.modelo = "xiaomi redmi2"; 
            xiaomi.cor = "Preto";

            Console.WriteLine("Deseja ligar o celular?");
            xiaomi.ligado = Boolean.Parse(Console.ReadLine());

            if(xiaomi.ligado){

                while(xiaomi.ligado == true){

                    Console.WriteLine("o que deseja fazer? \n 1- Realizar ligação? \n 2- Enviar mensagem? \n 3- Reiniciar o celular? \n 4- Desligar o celular?"); 
                    int resposta = Int32.Parse(Console.ReadLine());
                    
                    switch (resposta)
                    {
                        
                        case 1:
                        Console.WriteLine(xiaomi.FazerLigacao());
                        break;

                        case 2:
                        Console.WriteLine(xiaomi.EnviarMensagem());
                        break;

                        case 3:
                        Console.WriteLine(xiaomi.Reiniciar());
                        break;

                        case 4:
                        Console.WriteLine(xiaomi.desligar());
                        break;

                        default:
                        Console.WriteLine(xiaomi.ligar());
                        break;
                    }
                }

         }
                
            
        }
    }
}
