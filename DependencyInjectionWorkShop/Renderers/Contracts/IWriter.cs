using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionWorkShop.Renderers.Contracts
{
    public interface IWriter
    {

        void Write (object value);


        void WriteLine(object value);
    }
}
