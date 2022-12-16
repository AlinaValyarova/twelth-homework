using System;
using System.Collections.Generic;
using System.Text;

namespace Tumakov12
{
    public class Transactions
    {

        readonly DateTime data = DateTime.Now;
        private decimal summ;
        public decimal Summ 
        {
            get { return summ; }
            set { summ = value; }
        }

        public Transactions(decimal summ)
        {
            this.summ = summ;
        }

        public void Inf()
        {
            Console.WriteLine($" Date:{data} Sum:{summ}");
        }
    }
}
