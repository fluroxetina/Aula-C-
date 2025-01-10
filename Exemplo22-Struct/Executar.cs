// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace Exemplo22_Struct
// {
//     public struct Point
//     {
//         public int x { get; set; }
//         public int y { get; set; }

//         public Point(int x, int y)
//         {
//             this.x = x;
//             this.y = y;     
//         }

//         public double Distancia(Point p)
//         {
//             return Math.Sqrt(Math.Pow(x - p.x,2) + Math.Pow(y - p.y,2));
//         }
//     }

//     public class Player
//     {
//         public string Name { get; set; }
//         public Point Position { get; set; }

//         public Player(string name, Point position)
//         {
//             this.Name = name;
//             this.Position = position;
//         }

//         public void Move(Point newPosition)
//         {
//             Position = newPosition;
//         }
//     }

//     public class Executar
//     {
//         public static void ExecutarExemplo()
//         {
//             Point p1 = new Point(10, 20);
//             Point p2 = new Point(30, 40);

//             System.Console.WriteLine($"Distancia: entre p1 e p2 = {p1.Distancia(p2)}");

//             Player player = new Player("Willdanthe", p1);
//             System.Console.WriteLine($"Nome: {player.Name} Posicao: {player.Position.x} {player.Position.y}");

//             player.Move(p2);
//             System.Console.WriteLine($"Nome: {player.Name} Posicao: {player.Position.x} {player.Position.y}");
//         }
//     }
// }