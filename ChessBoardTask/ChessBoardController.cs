using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardTask
{
    public class ChessBoardController
    {
        #region ======------ PRIVATE DATA --------=======

        private readonly ChessBoard _gameField;

        #endregion

        #region =======------- CTOR --------========

        public ChessBoardController(ChessBoard gameField)
        {
            _gameField = gameField;
        }

        #endregion

        private void AddCells()
        {
            for (int i = 0; i < _gameField.LongBoard; i++)
            {
                for (int j = 0; j < _gameField.WhidthBoard; j++)
                {
                    if (IsEvenValue(i, j))
                    {
                        _gameField.Add(new WhiteCell(_gameField, new Coordinate(i, j)));
                    }
                    else
                    {
                        _gameField.Add(new BlackCell(_gameField, new Coordinate(i, j)));
                    }
                }
            }
        }

        private bool IsEvenValue(int x, int y)
        {
            return (((x + y) % 2) == 0);
        }

        public void Run()
        {
            AddCells();
        }
    }
}
