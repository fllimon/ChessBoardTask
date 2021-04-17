using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardTask
{
    class ChessBoard : IGameFieldContainer
    {
        #region ======----- PRIVATE DATA ------======

        private int _heightBoard = -1;
        private int _whidthBoard = -1;

        private Dictionary<Coordinate, Cell> _gameField;

        #endregion

        #region ======------ CTOR -------=======

        public ChessBoard(int longBoard, int whidthBoard)
        {
            _heightBoard = longBoard;
            _whidthBoard = whidthBoard;
            _gameField = new Dictionary<Coordinate, Cell>(_heightBoard * _whidthBoard);
        }

        #endregion

        #region =======-------- PROPERTIES ---------========

        public int HeightBoard
        {
            get
            {
                return _heightBoard;
            }
        }

        public int WhidthBoard
        {
            get
            {
                return _whidthBoard;
            }
        }

        #endregion



        public DefaultImage this[Coordinate position]
        {
            get
            {
                try
                {
                    return _gameField[position].Image;
                }
                catch (KeyNotFoundException)
                {
                    return DefaultImage.NoImage;
                }
            }
        }

        public void Add(Cell someEntity)
        {
            _gameField[someEntity.Position] = someEntity;
        }
    }
}
