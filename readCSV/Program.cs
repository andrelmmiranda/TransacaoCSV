using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readCSV
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = new StreamReader(File.OpenRead(@"C:\Users\aluno10.TSACBRRJLP041\Downloads\transferoacademy_transações2.csv"));

            //Console.WriteLine(streamReader.ReadLine());
            
            string line;
            string[] separated;

            List<Transaction> list = new List<Transaction>();

            int index = 0;

            
            while (true)
            {
                line = streamReader.ReadLine();

                //Console.WriteLine($"{index}: {line}");
                index++;

                if (line == null) break;

                separated = line.Split(';');

                if (!separated[0].Contains("horario"))
                {
                    Transaction t = new Transaction(
                                            dateTime: separated[0],
                                            acount: separated[1],
                                            operationType: separated[2],
                                            coinCameIn: separated[3],
                                            valueCameIn: separated[4],
                                            coinCameOut: separated[5],
                                            valueCameOut: separated[6]
                                        );

                    list.Add(t);
                   // Console.WriteLine($"{t.DateTime}: {t.Acount}: {t.ValueCameOut}");
                }
                

            }
            //"conta da Binance"
            //"29/12/2021 15:44"
            //"26/11/2020 00:33"
            //"conta da FTX"
            //"deposit"
            IEnumerable<Transaction> filtered = list.Where(item => item.Acount.Contains("conta da Binance"));
          

            
            foreach (Transaction t in filtered)
            {
                Console.WriteLine(t.ToString());
                Console.WriteLine(t.ValueCameOut.GetType());
                Console.WriteLine();
            }



            Console.WriteLine("Acabou");
            

          

            Console.ReadKey();
        }
    }
}
