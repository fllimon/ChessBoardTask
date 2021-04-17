using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardTask
{
    public interface IChessBoard
    {
        IGameFieldContainer InitializeGameField(int highBoard, int whidthBoard);

        IChessBoardStart InitializeGameFieldController(IGameFieldContainer gameField);
    }
}
