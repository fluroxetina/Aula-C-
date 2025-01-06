namespace Exemplo20_Enum
{
    public enum Estado
    {
        SP,
        RJ,
        MG,
        BA,
    }
    
    public class EstecaoEstado{
        public static string GetDescricao(Estado estado)
        {
            switch(estado)
            {
                case Estado.SP:
                    return "São Paulo";
                    break;
                
                case Estado.RJ:
                    return "Rio de Janeiro";
                    break;
                
                case Estado.MG:
                    return "Minas Gerais";
                    break;
                
                case Estado.BA:
                    return "Bahia";
                    break;
                
                default:
                    return "Estado não encontrado";
                    break;
            }
        }
    }

    public class Regiao
    {
        public string[] Regioes = {"Sul", "Sudeste", "Centro-Oeste", "Norte", "Nordeste"}; 

        public string GetRegiao(Estado estado)
        {
            return estado switch
            {
                Estado.SP => Regioes[1],
                Estado.RJ => Regioes[1],
                Estado.MG => Regioes[1],
                Estado.BA => Regioes[4],
                _ => "Regiao nao encontrada",
            };
        }
    }
}