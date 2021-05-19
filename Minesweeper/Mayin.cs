using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Minesweeper
{
    public class Mayin
    {
        Point location;
        bool dolu;
        bool bakildi;
        public Mayin(Point loca)
        {
            dolu = false;
            location = loca;
        }
        public Point konum_al
        {
            get { return location; }
        }

        public bool mayin_var_mi
        {
            get
            {
                return dolu;
            }
            set
            {
                dolu = value;
            }

        }

        public bool bakildi_
        {
            get
            {
                return bakildi;
            }
            set
            {
                bakildi = value;
            }

        }

    }
}
