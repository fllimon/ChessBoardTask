using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardTask
{
    public class ChessBoardInitializer : IChessBoard
    {
        public IGameFieldContainer InitializeGameField(int highBoard, int whidthBoard)
        {
            return new ChessBoard(highBoard, whidthBoard);
        }

        public IChessBoardStart InitializeGameFieldController(IGameFieldContainer gameField)
        {
            return new ChessBoardController(gameField);
        }
    }
}
