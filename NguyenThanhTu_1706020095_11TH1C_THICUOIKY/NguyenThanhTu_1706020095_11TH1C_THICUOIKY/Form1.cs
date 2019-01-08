using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenThanhTu_1706020095_11TH1C_THICUOIKY
{

    public partial class Form1 : Form
    {
        private Dictionary<string, List<Diem>> data = new Dictionary<string, List<Diem>>();
        Graphics g;
        Pen pen = new Pen(Color.Red, 2);
        Diem Dau = new Diem();
        Diem Cuoi = new Diem();
        bool Line, TamGiac, Thoi;
        bool canDraw = false;
        Line line = new Line();
        TamGiac tamgiac = new TamGiac();

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Dau.PointX = e.X;
            Dau.PointY = e.Y;
            canDraw = true;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            canDraw = false;
            Cuoi = new Diem(e.X, e.Y);
            line.Dau = Dau;
            line.Cuoi = Cuoi;
            line.AddPoint();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (canDraw == true)
            {
                g.Clear(pictureBox1.BackColor);
                tamgiac.Cuoi = new Diem(e.X, e.Y);
                g.DrawLine(pen, Dau.X, Dau.Y, e.X, e.Y);
                line.Draw(g, pen);
                tamgiac.Draw(g, pen);
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "json| *.json";
            save.ShowDialog();
            data.Add("line", line.SaveData());
            data.Add("tamgiac", tamgiac.SaveData());
        }

        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
            Line = true;
            TamGiac = true;
            Thoi = false;

        }
        void select(int input)
        {
           switch(input)
            {
                case 1:
                    Line = true;
                    TamGiac = false;
                    Thoi = false;
                    break;
                case 2:
                    Line = false;
                    TamGiac = true;
                    Thoi = false;
                    break;
                case 3:
                    Line = false;
                    TamGiac = false;
                    Thoi = true;
                    break;

            }
        }
    }
}
