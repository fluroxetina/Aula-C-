// Construa um programa que receba uma palavra do usuário. O programa deverá
// verificar se esta palavra corresponde à senha de acesso (senha: “Digix”). Se a palavra
// fornecida pelo usuário for igual a senha, o programa deverá informar “Acesso
// autorizado”, caso contrário, deverá informar “Acesso negado”

using System;

namespace Exercicio2
{
    class Exer2
    {
        static void Main(string[] args)
        {
            string senha = "Digix";
            System.Console.WriteLine("Digite a senha: ");
            string senhaDigitada = Console.ReadLine();
            
            if(senha != senhaDigitada){

                System.Console.WriteLine("Acesso negado");
            }
            else{
                System.Console.WriteLine("Acesso autorizado");
            }
        }
    }
}