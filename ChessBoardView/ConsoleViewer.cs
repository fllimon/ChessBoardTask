using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardView
{
    class ConsoleViewer
    {
        #region ========-------- PRIVATE DATA -------========

        private ConsoleController _controller;

        #endregion

        public void Start(int longBoard, int whidthBoard)
        {
            _controller = new ConsoleController(longBoard, whidthBoard);
            
            _controller.RunApplication();
        }
    }
}
