using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasa_publisher
{
    public delegate void Iteratie(int p);
    class Publisher
    {
        public event Iteratie evenim;

        public void DeclansareEveniment()
        {
            for (int i = 0; i < 5; i++)
            {
                if (this.evenim != null)
                    this.evenim(i);
                else
                    Console.WriteLine("Nu este eveniment");
            }
        }
    }
}
