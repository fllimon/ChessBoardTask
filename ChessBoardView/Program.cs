using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardView
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleValidator validator = new ConsoleValidator();

            bool result = validator.GetNumberValue(args[0], args[1]);

            ConsoleViewer menu = new ConsoleViewer();

            if (result)
            {
                menu.Start(ConsoleConvertor.ConvertData(args[0]), ConsoleConvertor.ConvertData(args[1]));
            }

            Console.ReadKey();
        }
    }
}
