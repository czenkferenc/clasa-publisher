using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasa_publisher
{
    class SubsType1
    {
        public void Iteratie(int p)
        {
            Console.WriteLine("eveniment in SubType1, de publisher");
        }
    }

    class SubsType2
    {
        public void Iteratie(int p)
        {
            Console.WriteLine("eveniment in SubType2, de publisher");
        }
    }
}
