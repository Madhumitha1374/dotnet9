using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFaceProg
{
    internal class OverLoading
    {
        public int add(int i, int j)
        {
            return (i);
        }
        public int add(ref int i, ref int j)
        {
            return i + j;
        }

        public int add(out int i, out int j)
        {
            i = 5;
            j = 8;
            return i + j;
        }
    }
}
