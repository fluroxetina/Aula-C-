// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace Exemplo_17_OO
// {
//     public class Produto
//     {
        
//         public  string Nome(get; set;);
//         private double _preco;
//         private int _qtd;

//         public Produto()
//         {

//         }

//         public Produto(string nome, double preco)
//         {
//             Nome = nome;
//             _preco = preco;
//         }

//         public Produto(string nome, double preco, int qtd) : this(nome, preco)
//         {
//             _qtd = qtd;
//         }

//         public string GetNome()
//         {
//             return _nome;
//         }

//         public void setNome(string nome)
//         {
//             if(nome!= null && nome.Length > 1)
//             {
//                 _nome = nome;
//             }
//         }


        // public string Nome
        // {
        //     get { return _nome; }

        //     set
        //     {
        //         if(value != null && value.Length > 1)
        //         {
        //             _nome = value;
        //         }
        //     }
        // }

        // public double GetPreco()
        // {
        //     return _preco;
        // }

        // public void SetPreco(double preco)
        // {
        //     if(preco > 0 && preco < 1000000)
        //     {
        //         _preco = preco;
        //     }
        // }
        // public double Preco
        // {
        //     get { return _preco; }

        //     set
        //     {
        //         if(value > 0 && value < 1000000)
        //         {
        //             _preco = value;
        //         }
        //     }
        // }

        // public int GetQtd()
        // {
        //     return _qtd;
        // }

        // public void SetQtd(int qtd)
        // {
        //     _qtd = qtd;
        // }

//         public int Qtd
//         {
//             get { return _qtd; }

//             set 
//             {
//                 if(value > 0)
//                 {
//                     _qtd = value;
//                 }
//             }
//         }

//         public void AdicioanrProduto(int qtd)
//         {
//             _qtd += qtd;
//         }

//         public void RemoverPrd(int qtd)
//         {
//             _qtd -= qtd;
//         }

//         public double CalcularEstoque()
//         {
//             return _preco * _qtd;
//         }
        
//         public override string ToString()
//         {
//             return $"Nome: {Nome}, Preco: ${_preco.ToString("F2")}, Qtd: {_qtd} Estoque: {CalcularEstoque().ToString("F2")}";             
//         }
//     }
// }