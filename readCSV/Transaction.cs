using System.Globalization;

namespace readCSV
{
    public class Transaction
    {
        public string Horario { get; private set; }
        public string Conta { get; private set; }
        public string TipoDeOperacao { get; private set; }
        public string MoedaQueEntrou { get; private set; }
        public double Entrou { get; private set; }
        public string MoedaQueSaiu { get; private set; }
        public double Saiu { get; private set; }
        public string MoedaDeTaxa { get; private set; }
        public double Taxa { get; private set; }
        public double MoedaRecebidaEmReais { get; set; }
        public double MoedaEnviadaEmReais { get; set; }

        public Transaction() { }

        public Transaction(string horario, string conta, string tipoDeOperacao, 
            string moedaQueEntrou, double entrou, string moedaQueSaiu, double saiu, string moedaDeTaxa,
            double taxa, double moedaRecebidaEmReais, double moedaEnviadaEmReais)
        {
            Horario = horario;
            Conta = conta;
            TipoDeOperacao = tipoDeOperacao;
            MoedaQueEntrou = moedaQueEntrou;
            Entrou = entrou;
            MoedaQueSaiu = moedaQueSaiu;
            Saiu = saiu;
            MoedaDeTaxa = moedaDeTaxa;
            Taxa = taxa;
            MoedaRecebidaEmReais = moedaRecebidaEmReais;
            MoedaEnviadaEmReais = moedaEnviadaEmReais;
        }

        public override string ToString()
        {
            return "Horario: " + Horario + "\n" +
                "Conta: " + Conta + "\n" +
                "TipoDeOperacao: " + TipoDeOperacao + "\n" +
                "MoedaQueEntrou: " + MoedaQueEntrou + "\n" +
                "Entrou: " + Entrou + "\n" +
                "MoedaQueSaiu: " + MoedaQueSaiu + "\n" +
                "Saiu: " + Saiu + "\n" +
                "MoedaDeTaxa: " + MoedaDeTaxa + "\n" +
                "Taxa: " + Taxa + "\n" +
                "MoedaRecebidaEmReais: " + MoedaRecebidaEmReais + "\n" +
                "MoedaEnviadaEmReais: " + MoedaEnviadaEmReais + "\n";
        }

        public static double ToDouble(string value)
        {
            if (value.Contains(","))
            {
                return double.Parse(value, CultureInfo.CreateSpecificCulture("pt-BR"));
            }
            else
            {
               return double.Parse(value);
            }
        }
    }
}
