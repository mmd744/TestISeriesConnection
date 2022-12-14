using IBM.Data.DB2.iSeries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestISeriesConnection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Connecting...");
            var connection = new iDB2Connection("DataSource=10.10.149.104;UserID=#MOBILEAPI;Password=TAMPAB#2; Default Collection=EXPRESS; DataCompression=True; AllowUnsupportedChar=True");
            connection.Open();
            Console.WriteLine("Connected");
            connection.Close();
            Console.ReadKey();
        }
    }
}
