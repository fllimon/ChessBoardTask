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

        private readonly IGameFieldContainer _gameField;
        private readonly IChessBoard _gameFieldController;
        private readonly IChessBoardStart _runChessBoard;
        
        #endregion

        #region =======------ CTOR -------===========

        public ConsoleController(int heightBoard = DefaultSettings.DEFAULT_BOARD_LONG,
                                        int whidthBoard = DefaultSettings.DEFAULT_BOARD_WHIDTH)
        {
            _gameFieldController = new ChessBoardInitializer();
            _gameField = _gameFieldController.InitializeGameField(heightBoard, whidthBoard);
            _runChessBoard = _gameFieldController.InitializeGameFieldController(_gameField);
        }

        #endregion

        public void RunApplication()
        {
            _runChessBoard.Run();
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
