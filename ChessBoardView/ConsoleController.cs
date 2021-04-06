using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ChessBoardTask;

namespace ChessBoardView
{
    class ConsoleController
    {
        #region =======------- PRIVATE DATA --------=========

        private readonly ChessBoard _gameField;
        private readonly ChessBoardController _gameFieldController;

        #endregion

        #region =======------ CTOR -------===========

        public ConsoleController(int longBoard = DefaultSettings.DEFAULT_BOARD_LONG,
                                        int whidthBoard = DefaultSettings.DEFAULT_BOARD_WHIDTH)
        {
            _gameField = new ChessBoard(longBoard, whidthBoard);
            _gameFieldController = new ChessBoardController(_gameField);
        }

        #endregion

        public void RunApplication()
        {
            _gameFieldController.Run();
            Print();
        }

        private void Print()
        {
            for (int i = 0; i < _gameField.HeightBoard; i++)
            {
                for (int j = 0; j < _gameField.WhidthBoard; j++)
                {
                    Coordinate position = new Coordinate(i, j);

                    Console.Write((char)_gameField[position]);
                }

                Console.WriteLine();
            }
        }
    }
}
