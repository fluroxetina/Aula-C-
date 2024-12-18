using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo19_OO
{
    public class ExecutarTudo
    {
        static void Main(string[] args)
        {
            Estado estado = new Estado("Mato Grosso do Sul", "MS");
            Cidade cidade = new Cidade("Campo Grande", estado);
            Endereco endereco = new Endereco("Rua 1", 123, "Bairro 1", "12345-678", cidade);

            Vendedor vendedor = new Vendedor("João", new DateTime(1990, 1, 1), "123456789", endereco, new EquipeVenda("Equipe 1"));

            System.Console.WriteLine($"Cidade: {cidade.Nome}, Estado: {cidade.Estado.Nome} ({cidade.Estado.Sigla})");

            System.Console.WriteLine($"VENDEDOR : {vendedor.Nome} - {vendedor.Nascimento} {vendedor.CPF} - {vendedor.Endereco.Rua} {vendedor.Endereco.Numero} - {vendedor.Endereco.Bairro} - {vendedor.Endereco.Cep} - {vendedor.Endereco.Cidade.Nome} ({vendedor.Endereco.Cidade.Estado.Sigla})");
            
        }
    }
}