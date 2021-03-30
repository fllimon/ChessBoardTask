﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardTask
{
    class BlackCell : Cell
    {
        #region ======------- CTOR -------=======

        public BlackCell(ChessBoard gameField, Coordinate position)
            : base(gameField, position)
        {

        }

        #endregion

        #region =========-------- PROPERTIES ---------=======

        public override DefaultImage Image
        {
            get
            {
                return DefaultImage.BlackCell;
            }
        }

        #endregion
    }
}
