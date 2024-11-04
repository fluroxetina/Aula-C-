using System;

namespace Exercicio3
{
    class Exercico
    {
        static void Teste()
        {
            System.Console.WriteLine("Digite o valor do investimento");
            double valor = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite \n1 - Para Poupança \n2 - Para Renda Fixa \n3 - Para Ações:");
            int tipoInvest = int.Parse(Console.ReadLine());

            double valorFinalGanho = 1.0;
            double valorFinalPerda = 0;
            if(tipoInvest == 1){

                Console.WriteLine("Seu investismento escolhido foi a Poupança");
                valorFinalGanho = (valor * 0.03) + valor;

            }

            else if(tipoInvest == 2) {
                System.Console.WriteLine("Seu investimento escolhido foi a Renda Fixa");
                valorFinalGanho = (valor *0.05) + valor;
            }

            else if(tipoInvest == 3){
                
                System.Console.WriteLine("Seu investimento escolhido foram as Ações");
                valorFinalGanho = (valor * 0.10) + valor ;

                if(true){
                    System.Console.WriteLine("Você também pode acabar perdendo dinheiro");
                    valorFinalPerda = valor * 0.05;
                }

            }

            else{
                System.Console.WriteLine("Tipo de investimento invalido");
            }

            System.Console.WriteLine("Por quando anos gostaria de investir seu dinheiro");
            int qtdAno = int.Parse(Console.ReadLine());

            System.Console.WriteLine($"{qtdAno * valorFinalGanho} foi o valor ganho e valor perdido foi de {valorFinalPerda}");


            // // Usando o switch case ////////////////////////////////////////////////////////////////////////////////////

            switch(tipoInvest)
            {
                case 1:
                    Console.WriteLine("Seu investismento escolhido foi a Poupança");
                    valorFinalGanho = (valor * 0.03) + valor;
                    break;
                
                case 2:
                    System.Console.WriteLine("Seu investimento escolhido foi a Renda Fixa");
                    valorFinalGanho = (valor *0.05) + valor;
                    break;
                
                case 3:
                    System.Console.WriteLine("Seu investimento escolhido foram as Ações");
                    valorFinalGanho = (valor * 0.10) + valor ;

                    if(true){
                        System.Console.WriteLine(" você também pode acabar perdendo dinheiro");
                        valorFinalPerda = valor * 0.05;
                    }
                    break;
                
                default:
                    System.Console.WriteLine("Tipo de investimento invalido");
                    break;
            }
        }      
    }
}


