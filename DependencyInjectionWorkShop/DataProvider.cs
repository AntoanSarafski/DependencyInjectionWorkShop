using ChessDependencyInversion.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChessDependencyInversion
{
    public class DataProvider : IDataProvider

    {
        public DateTime GetDate()
        {
            return DateTime.Now;
        }
    }
}
