using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardView
{
    class DataConvertor
    {
        public static int ConvertData(string number)
        {
            try
            {
                return int.Parse(number);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
