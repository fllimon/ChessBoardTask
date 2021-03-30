using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardView
{
    class ConsoleViewer
    {
        #region ========-------- PRIVATE DATA -------========

        private UserAction _result = UserAction.NoAction;
        private ConsoleController _controller;

        #endregion

        public void PrintMenu()
        {
            Console.WriteLine("=========------- Chess Board ---------==========");
            Console.WriteLine();
            Console.WriteLine($"Press <{DefaultSettings.START_KEY}> - to START");
            Console.WriteLine();
            Console.WriteLine($"======---- <{DefaultSettings.EXIT_KEY} - to EXIT> ------=====");
        }

        public void GetChessBoardParameters()
        {
            bool condition = true;

            do
            {
                try
                {
                    Console.Write("Enter chess board long: ");
                    int longBoard = int.Parse(Console.ReadLine());

                    if (longBoard < 0)
                    {
                        return; // ToDo: Fix
                    }

                    Console.Write("Enter chess board whidth: ");
                    int whidthBoard = int.Parse(Console.ReadLine());

                    if (whidthBoard < 0)
                    {
                        return; 
                    }

                    Start(longBoard, whidthBoard);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"The entered value is not correct. {ex.Message}");

                    condition = false;
                }

            } while (!condition);    //ToDo: Fix Exit action
        }

        private void Start(int longBoard, int whidthBoard)
        {
            _controller = new ConsoleController(longBoard, whidthBoard);
            Console.Clear();

            _controller.RunApplication();
        }

        public UserAction GetUserChoice()
        {
            switch (Console.ReadKey(true).Key)
            {
                case DefaultSettings.EXIT_KEY:
                    _result = UserAction.Exit;
                    break;
                case DefaultSettings.START_KEY:
                    _result = UserAction.Start;
                    break;
            }

            return _result;
        }
    }
}
