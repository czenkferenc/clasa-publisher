using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasa_publisher
{
    class Program
    {
        static void Main(string[] args)
        {
            Publisher p = new Publisher();
            SubsType1 a = new SubsType1();
            SubsType2 b = new SubsType2();

            p.evenim += new Iteratie(a.Iteratie);
            p.evenim += new Iteratie(b.Iteratie);

            p.DeclansareEveniment();
        }
    }
}
