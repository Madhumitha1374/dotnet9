using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFaceProg
{
    internal interface IParInter<T>
    {
        T Add(T a, T b);
        T Sub(T a, T b);
    }
}
