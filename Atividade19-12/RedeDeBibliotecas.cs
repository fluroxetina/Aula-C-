using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade19_12
{
    public class RedeDeBibliotecas
    {
        public List<Biblioteca> Bibliotecas = new List<Biblioteca>();

        public RedeDeBibliotecas()
        {
            Bibliotecas = new List<Biblioteca>();
        } 

        public void AdicionarBiblioteca(Biblioteca biblioteca)
        {
            Bibliotecas.Add(biblioteca);
        }

        public void RemoverBiblioteca(Biblioteca biblioteca)
        {
            Bibliotecas.Remove(biblioteca); 
        }

        public void ExibirBibliotecas() 
        {   
            System.Console.WriteLine("==============Bibliotecas==============");
            foreach (var biblioteca in Bibliotecas)
            {
                Console.WriteLine($"Nome: {biblioteca.Nome} - Endereco: {biblioteca.Endereco} - Livros: {biblioteca.Catalogo.Livros.Count} - Funcionarios: {biblioteca.Funcionarios.Count}");
            }
        }
    }
}