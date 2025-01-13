using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClosedXML.Excel;

namespace Exemplo23_ManipulandoArquivo
{
    public class JogaNoCorolla
    {
        static void Main(string[] args)
        {
            var cliente = new Customer("WilliamDanthe");

            var contaCorrente = new CurrentAccount(1234, cliente, 1000);
            var contaPoupanca = new SavingAccount(1235, cliente, 0.01);

            contaCorrente.Depositar(1000);
            contaCorrente.Sacar(200);

            contaPoupanca.Depositar(1000);
            contaPoupanca.AplicarRendimento();

            GerarExcel(new List<Account>{ contaCorrente, contaPoupanca});


        }

        public static void GerarExcel(List<Account> contas)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.AddWorksheet("Contas Bancarias");

                worksheet.Cell(1,1).Value = "Numero da Conta";
                worksheet.Cell(1,2).Value = "Numero do Cliente";
                worksheet.Cell(1,3).Value = "Tipo da Conta";
                worksheet.Cell(1,4).Value = "Saldo";

                int row = 2;
                foreach(var conta in contas)
                {
                    worksheet.Cell(row, 1).Value = conta.NumeroConta;
                    worksheet.Cell(row, 2).Value = conta.Cliente.Nome;
                    worksheet.Cell(row, 3).Value = conta.TipoConta.ToString();
                    worksheet.Cell(row, 4).Value = conta.Saldo;
                    row++;
                }

                workbook.SaveAs("ContasBancarias.xlsx");
                System.Console.WriteLine("Arquivo gerado com sucesso");
            }
        }
    }

}