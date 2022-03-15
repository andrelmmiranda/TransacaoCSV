using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readCSV
{
    class Transaction
    {

        public string DateTime { get; private set; }
        public string Acount { get; private set; }
        public string OperationType { get; private set; }
        public string CoinCameIn { get; private set; }
        public double ValueCameIn { get; set; }
        public string CoinCameOut { get; private set; }
        public double ValueCameOut { get; set; }

        public Transaction(string dateTime, string acount, string operationType, string coinCameIn, string valueCameIn, string coinCameOut, string valueCameOut)
        {
            DateTime = dateTime;
            Acount = acount;
            OperationType = operationType;
            CoinCameIn = coinCameIn;
            ValueCameIn = ToDouble(valueCameIn);
            CoinCameOut = coinCameOut;
            ValueCameOut = ToDouble(valueCameOut);

        }

        public override string ToString()
        {
            return string.Format($"{DateTime} - {Acount} - {OperationType} - {CoinCameIn} - {ValueCameIn} - {CoinCameOut} - {ValueCameOut}");
        }

        public static double ToDouble(string value)
        {
            if (value.Contains(","))
            {
                return double.Parse(value, CultureInfo.CreateSpecificCulture("pt-BR"));
            }
            else
            {
               return double.Parse(value, CultureInfo.InvariantCulture);
            }
        }
    }
}
