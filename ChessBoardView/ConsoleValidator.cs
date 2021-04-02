using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardView
{
    class ConsoleValidator
    {
        public bool GetValidData(int longBoard, int whidthBoard)
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
