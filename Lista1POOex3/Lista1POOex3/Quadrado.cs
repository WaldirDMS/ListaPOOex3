using System;
using System.Collections.Generic;
using System.Text;

namespace Lista1POOex3
{
    class Quadrado
    {
        private int diag;
        private int area;

        public void setDiag(int p)
        {
            diag = p;
        }
        public int getArea()
        {
            return area;
        }

        public void calcularArea()
        {
            area = (diag * diag) / 2;
        }
    }
}
