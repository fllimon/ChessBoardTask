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
        
        #endregion

        #region =======-------- CTOR -------======

        public Cell(Coordinate coordinate)
        {
            _coordinate = coordinate;
        }

        public Cell( int x, int y)
            : this(new Coordinate(x, y))
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
