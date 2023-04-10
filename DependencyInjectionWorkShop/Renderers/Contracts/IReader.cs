using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionWorkShop.Renderers.Contracts
{
    public interface IReader
    {
        string Read();


        string ReadLine();
    }
}
