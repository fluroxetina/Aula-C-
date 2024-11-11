/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/

namespace Eceme
{
    public class Mudificadore
    {
        public int[] somaDiagonal(int [,] a)
        {
            int somaDiagonal1 = 0;
            int somaDiagonal2 = 0;
            

            for(int i = 0 ; i < a.GetLength(0); i++)
            {
                for (int j = 0 ; j < a.GetLength(1); j++)
                {
                    if (i == j){
                        somaDiagonal1 += a[i, j];

                    }
                    if (i + j == a.GetLength(0) - 1){

                        somaDiagonal2 += a[i , j];
                    } 
                }

            }
            int[] Dia = new int[2] {somaDiagonal1, somaDiagonal2};
            return Dia;

            
            

        }
        static void Main(string[] args)
        {
            Mudificadore mat = new Mudificadore();
            int[,] fa = new int[3,3]{
                {1,2,3},
                {4,5,6},
                {7,8,9}};

            int[] recebeDia = new int[2];
            recebeDia = mat.somaDiagonal(fa);

            Console.WriteLine($"A soma das diagonais é: {recebeDia[0]} e {recebeDia[1]}");

            
  
        }
    }
}




