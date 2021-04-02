using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardTask
{
    public class Coordinate
    {
        #region ========-------- PRIVATE DATA --------==========

        private int _x = -1;
        private int _y = -1;

        #endregion

        #region =======--------- CTOR -------=========

        public Coordinate(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public Coordinate(Coordinate source)
            : this(source._x, source._y)
        {

        }

        #endregion

        #region =======------ PROPERTIES --------========

        public int X
        {
            get
            {
                return _x;
            }

            private set
            {
                _x = value;
            }
        }

        public int Y
        {
            get
            {
                return _y;
            }

            private set
            {
                _y = value;
            }
        }

        #endregion

        public override bool Equals(object obj)
        {
            Coordinate someObj = obj as Coordinate;

            if (someObj == null)
            {
                return false;
            }

            return ((X == someObj.X) && (Y == someObj.Y));
        }

        public override int GetHashCode()
        {
            return (X | (Y << 2)); //ToDo: Сравнить вызов Equals << 2 или << 8
        }
    }
}
