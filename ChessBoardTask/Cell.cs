using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardTask
{
    public abstract class Cell
    {
        #region ======------ PRIVATE DATA -------=======

        private readonly Coordinate _coordinate;
        private readonly IGameFieldContainer _gameField;

        #endregion

        #region =======-------- CTOR -------======

        public Cell(ChessBoard gameField, Coordinate coordinate)
        {
            _gameField = gameField;
            _coordinate = coordinate;
        }

        public Cell(ChessBoard gameField, int x, int y)
            : this(gameField, new Coordinate(x, y))
        {

        }

        #endregion

        public abstract DefaultImage Image { get; }

        public Coordinate Position
        {
            get
            {
                return new Coordinate(_coordinate);
            }
        }
    }
}
