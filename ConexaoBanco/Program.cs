using Npgsql;
using System;

class Program
{
    static void Main()
    {
        
        var connString = "Host=localhost;Username=postgres;Password=3@56Casa;Database=Aula1";
  
        using var conn = new NpgsqlConnection(connString);
        try
        {
            
            conn.Open();
            Console.WriteLine("Conexão bem-sucedida!");

            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite a idade: ");
            int idade = int.Parse(Console.ReadLine());
            
            using var cmd = new NpgsqlCommand
            {
                Connection = conn,
                CommandText = "INSERT INTO pessoas (nome, idade) VALUES (@nome, @idade)"
            };
            cmd.Parameters.AddWithValue("nome", nome);
            cmd.Parameters.AddWithValue("idade", idade);

            int linhasAfetadas = cmd.ExecuteNonQuery();
            Console.WriteLine($"Inserção realizada com sucesso! Linhas afetadas: {linhasAfetadas}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao conectar: {ex.Message}");
        }
    }
}