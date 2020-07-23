using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace schedule
{
    class Chromosome
    {

        public int score;
        public List<Population> dnaChain = new List<Population>();
        public Chromosome(List<Population> cDnaChain)
        {
            score = 0;
            dnaChain = cDnaChain;
        }
        public Chromosome()
        {

        }


    }
}
