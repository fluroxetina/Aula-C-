using System.Globalization;

namespace exer01
{
    internal class Teste2
    {
        static void Main(String[] args)
        {
            string produto1 = "Computador";
            string prd2 = "Mesa de Escritorio";

            byte idade = 30;
            int codigo = 5290; 
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine($"Produto: \n{produto1}, cujo preço é ${preco1} \n{prd2}, cujo o preço é ${preco2} \nRegistro: {idade} anos de idade, codigo {codigo} e gênero: {genero}\nMedida com oito casas decimais: {medida:F8} \nArredondado (três casas decimais): {medida:F3} \nSeparador decimal invariant culture: {medida.ToString("F3", CultureInfo.InvariantCulture)}");
           
        
         }
    }

}