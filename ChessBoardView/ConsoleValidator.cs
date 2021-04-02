using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardView
{
    class ConsoleValidator
    {
        public bool GetNumberValue(int firstValue, int secondValue)
        {
            bool isOk = true;

            try
            {
                isOk = GetValidData(firstValue, secondValue);

                return isOk;
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Incorrect parameters! {ex.Message}");
                return isOk = false;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Parameters not specified! {ex.Message}");
                return isOk = false;
            }
        }

        private bool GetValidData(int longBoard, int whidthBoard)
        {
            bool isOk = true;

            if (IsNotCorrectValue(longBoard, whidthBoard))
            {
                return isOk = false;
            }

            return isOk;
        }

        private bool IsNotCorrectValue(int longBoard, int whidthBoard)
        {
            return ((longBoard < 2) || (whidthBoard < 2));
        }
    }
}
