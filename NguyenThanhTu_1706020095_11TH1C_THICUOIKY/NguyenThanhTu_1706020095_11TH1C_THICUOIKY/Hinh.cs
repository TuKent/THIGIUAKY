using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;
using Newtonsoft.Json;

namespace NguyenThanhTu_1706020095_11TH1C_THICUOIKY
{
    class Hinh
    {
        public List<Diem> save = new List<Diem>();
        public Hinh()
        {
        }
        public virtual void Draw(Graphics g, Pen pen)
        {
        }
        public List<Diem> SaveData()
        {
            List<Diem> temp = new List<Diem>();
            temp = save;
            return temp;
        }
    }
        class Line : Hinh
        {
            public Diem Dau = new Diem();
            public Diem Cuoi = new Diem();
        public Line()
        {
            Dau = new Diem(0, 0);
            Cuoi = new Diem(0, 0);
        }
        public Line(Diem A, Diem B)
            {
                Dau = A;
                Cuoi = B;
            }
            public override void Draw(Graphics g, Pen pen)
            {
                base.Draw(g, pen);
                foreach (var item in save)
                {
                    for (int i = 0; i < save.Count - 1; i += 2)
                    {
                       
                    }
                }
            }
            public void AddPoint()
            {
            save.Add(Dau);
            save.Add(Cuoi);
            }
        }
        class TamGiac : Hinh
    {
        public Diem Dau = new Diem();
        public Diem Cuoi  = new Diem();
        public TamGiac()
        {
            Dau = new Diem(0, 0);
            Cuoi = new Diem(0, 0);
        }
        public TamGiac(Diem A, Diem B)
        {
            Dau = A;
            Cuoi = B;
        }
        public Diem begin = new Diem();
        public Diem end = new Diem();

        public override void Draw(Graphics g, Pen pen)
        {
            base.Draw(g, pen);
            Rectangle rect = new Rectangle();
            rect.Size = new Size(Cuoi.X - Dau.Y, Cuoi.Y - Dau.Y);
            rect.X = Dau.X;
            rect.Y = Cuoi.Y;
            g.DrawLine(pen, rect.X, rect.Y + rect.Height, Cuoi.X, Cuoi.Y);
            g.DrawLine(pen, rect.X , rect.Y, Cuoi.X, Cuoi.Y);
            g.DrawLine(pen, rect.X, rect.Y, Cuoi.X - rect.Width, Cuoi.Y);
        }
        public void AddPoint()
        {
            save.Add(Dau);
            save.Add(Cuoi);
        }
    }
   }
