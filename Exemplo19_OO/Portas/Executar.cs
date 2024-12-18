// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace Exemplo19_OO
// {
//     public class Executar12
//     {
//         static void Main(string[] args)
//         {
//             System.Console.WriteLine("Herança");
//             PortaCozinha porta = new PortaCozinha ("Azul", 1.5f, 2.0f, 3.0f);
//             porta.Abrir();  
//             porta.Fechar();
//             System.Console.WriteLine($"Porta da cozinha: {porta.Cor} {porta.Largura} {porta.Altura} {porta.Peso}");
            
//             System.Console.WriteLine("\n");

//             System.Console.WriteLine("Agregação");
//             Cozinha cozinha = new Cozinha(porta, true, 20);
//             cozinha.Entrar(porta);

//             System.Console.WriteLine("\n");

//             System.Console.WriteLine("Composição");
//             PortaQuarto porta2 = new PortaQuarto("Vermelho", 1.5f, 2.0f, 3.0f); 
//             Quarto quarto = new Quarto(porta2, true, 20);
//             System.Console.WriteLine("Quarto: " + quarto.Banheiro + " " + quarto.MetragemQuadrada + " " + quarto.portaQuarto.Cor + " " + quarto.portaQuarto.Largura + " " + quarto.portaQuarto.Altura + " " + quarto.portaQuarto.Peso);
//         }
//     }
// }