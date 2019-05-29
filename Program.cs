using System;
using System.Collections.Generic;

namespace stock_report
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> stocks = new Dictionary<string, string>();

            stocks.Add("GM", "General Motors");
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("MSFT", "Microsoft");
            stocks.Add("AAPL", "Apple");
            stocks.Add("AMD", "Advanced Micro Devices");
            stocks.Add("HPQ", "HP Inc");

            Dictionary<string, List<double>> portfolio = new Dictionary<string, List<double>>();

            List<double> GMInfo = new List<double>() {
                4892.12
            };

            List<double> AAPLInfo = new List<double>() {
                1214.90, 2881.95
            };

            List<double> MSFTInfo = new List<double>() {
                934.21, 9025.23, 4013.89
            };

            List<double> CATInfo = new List<double>() {
                180.44, 298.01, 9092.45
            };

            List<double> AMDInfo = new List<double>() {
                26.31, 19.21, 23.89
            };

            List<double> HPInfo = new List<double>() {
                19.00, 21.04
            };

            portfolio.Add("GM", GMInfo);
            portfolio.Add("AAPL", AAPLInfo);
            portfolio.Add("MSFT", MSFTInfo);
            portfolio.Add("CAT", CATInfo);
            portfolio.Add("AMD", AMDInfo);
            portfolio.Add("HPQ", HPInfo);

            // The position in apple is worth 7601.23
            foreach(KeyValuePair<string, List<double>> stockPurchases in portfolio) {
                double sum = 0.00;
                foreach(double stockInvestments in stockPurchases.Value)
                {
                    sum += stockInvestments;
                }

                Console.WriteLine($"The position in {stocks[stockPurchases.Key]} is worth ${sum}");
                
            }
        }
    }
}
