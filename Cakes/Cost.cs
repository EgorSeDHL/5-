using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cakes
{
    internal class Cost
    {
        public int one_cost;
        public int two_cost;
        public int three_cost;
        public int pos_cost;
        public Cost(int one_cost, int two_cost, int three_cost, int pos_cost)
        {
            this.one_cost = one_cost;
            this.two_cost = two_cost;
            this.three_cost = three_cost;
            this.pos_cost = pos_cost;
        }
    }
}
