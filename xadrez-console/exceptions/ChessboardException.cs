using System;
using System.Collections.Generic;
using System.Text;

namespace exceptions
{
    class ChessboardException : Exception
    {

        public ChessboardException(string msg) : base(msg)
        {
        
        }

    }
}
