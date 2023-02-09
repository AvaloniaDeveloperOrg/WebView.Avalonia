namespace CefSharp.Core
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using CefSharp.Core.Interop;

    public struct CefPoint
    {
        private int _x;
        private int _y;

        public CefPoint(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }
    }
}
