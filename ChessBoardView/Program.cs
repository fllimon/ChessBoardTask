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
            ConsoleViewer menu = new ConsoleViewer();
            UserAction currentAction = UserAction.NoAction;

            menu.PrintMenu();
            currentAction = menu.GetUserChoice();
            Console.Clear();

            do
            {
                switch (currentAction)
                {
                    case UserAction.NoAction:
                        break;
                    case UserAction.Start:
                        menu.GetChessBoardParameters();
                        currentAction = UserAction.NoAction;
                        break;
                    case UserAction.Exit:
                        break;
                }
            } while (currentAction != UserAction.Exit);
        }
    }
}
