using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenThanhTu_1706020095_11TH1C_THICUOIKY
{
   
    class Diem
    {
        public int X, Y;
        public Diem()
        {

        }
        public Diem(int X, int Y)
        {
            X = X;
            Y = Y;
        }
        public int PointX
        {
            get
            {
                return X;
            }
            set
            {
                X = value;
            }
        }
        public int PointY
        {
            get
            {
                return Y;
            }
            set
            {
                Y = value;
            }
        }

    }
}
