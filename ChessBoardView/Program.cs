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
            ConsoleViewer menu = new ConsoleViewer();

            try
            {
                int heightBoard = DataConvertor.ConvertData(args[0]);
                int whidthBoard = DataConvertor.ConvertData(args[1]);

                bool result = validator.GetNumberValue(heightBoard, whidthBoard);

                if (result)
                {
                    menu.Start(heightBoard, whidthBoard);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
           
            Console.ReadKey();
        }
    }
}
