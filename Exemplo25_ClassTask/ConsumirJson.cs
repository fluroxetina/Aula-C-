using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.IO;
using System.Threading;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace Exemplo25_ClassTask
{
    public class ConsumirJson
    {
        public static void SalvarEmTxt(JsonElement animeList, string nomeArquivo)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(nomeArquivo))
                {
                    foreach (var anime in animeList)
                    {
                        string title = anime.GetProperty("title").GetString()?? "Sem Titulo";
                        string type = anime.GetProperty("type").GetString()?? "Sem tipo";
                        string episodes = anime.GetProperty("episodes").GetString()?? "Sem episódios";
                        string status = anime.GetProperty("status").GetString()?? "Sem status";

                        string season = "N/A";
                        int year = 0;

                        // if(animeList.TryGetProperty("animeSeason", out JsonElement seasonElement))
                        // {
                        //     season = animeSeason.GetProperty("season").GetString()?? "N/A";
                        // }
                    }
                }
            }
            catch (System.Exception)
            {
                
                throw;
            }
           
        }
        static async Task Main(string[] args)
        {
            string url = "https://raw.githubusercontent.com/manami-project/anime-offline-database/master/anime-offline-database-minified.json";

            string nomeArquivo ="animes.json";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var response = await cliente.GetAsync(url);

                    var responseString = await response.Content.ReadAsStringAsync();

                    using (JsonDocument document = JsonDocument.Parse(responseString)
                    {
                        var animeList = document.RootElement.GetProperty("data").EnumerateArray();

                        SalvarEmTxt(animeList, nomeArquivo);
                    }

                    System.Console.WriteLine("Download concluído");
                }
                
            }
            catch (System.Exception)
            {
                
                throw;
            }

        }    
    }
}