using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardTask
{
    public interface IGameFieldContainer
    {
        int HeightBoard { get; }

        int WhidthBoard { get; }

        DefaultImage this[Coordinate position] { get; }

        void Add(Cell entity);
    }
}
