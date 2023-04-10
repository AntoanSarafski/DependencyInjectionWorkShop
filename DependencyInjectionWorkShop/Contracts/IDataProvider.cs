using System;
using System.Collections.Generic;
using System.Text;

namespace ChessDependencyInversion.Contracts
{
    public interface IDataProvider
    {
        DateTime GetDate();
    }
}
