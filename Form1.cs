using System;
using System.Drawing;
using System.Windows.Forms;

namespace GrapphicsPartOfLr2_graphics_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int[,] MirrorXY(int[,] xy, int[,] mxy, int[,] Cordmatrix)
        {
            int[,] NewMatrix = new int[Cordmatrix.GetLength(0), 2];
            bool fl = false;
            for (int i = 0; i < Cordmatrix.GetLength(0); i++)
            {

                if (!(Cordmatrix[i, 0] > 0 && Cordmatrix[i, 1] > 0 || Cordmatrix[i, 0] < 0 && Cordmatrix[i, 1] < 0))
                    fl = true;
            }

            if (fl)
                for (int w = 0; w < Cordmatrix.GetLength(0); w++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        for (int q = 0; q < 2; q++)
                        {
                            NewMatrix[w, j] += Cordmatrix[w, q] * mxy[q, j];
                        }
                    }
                }
            else
            {

                for (int w = 0; w < Cordmatrix.GetLength(0); w++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        for (int q = 0; q < 2; q++)
                        {
                            NewMatrix[w, j] += Cordmatrix[w, q] * xy[q, j];
                        }
                    }
                }

            }


            return NewMatrix;
        }
        public int[,] MirrorOX(int[,] ox, int[,] Cordmatrix)
        {
            int[,] NewMatrix = new int[Cordmatrix.GetLength(0), 2];
            for (int w = 0; w < Cordmatrix.GetLength(0); w++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int q = 0; q < 2; q++)
                    {
                        NewMatrix[w, j] += Cordmatrix[w, q] * ox[q, j];
                    }
                }
            }

            return NewMatrix;
        }
        public int[,] MirrorOY(int[,] oy, int[,] Cordmatrix)
        {
            int[,] NewMatrix = new int[Cordmatrix.GetLength(0), 2];
            for (int w = 0; w < Cordmatrix.GetLength(0); w++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int q = 0; q < 2; q++)
                    {
                        NewMatrix[w, j] += Cordmatrix[w, q] * oy[q, j];
                    }
                }
            }
            return NewMatrix;
        }
        static Double[,] DiscRotation(Double[,] disc, Double[,] Cordmatrix)
        {
            Double[,] NewMatrix = new Double[Cordmatrix.GetLength(0), 2];
            for (int w = 0; w < Cordmatrix.GetLength(0); w++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int q = 0; q < 2; q++)
                    {
                        NewMatrix[w, j] += (Cordmatrix[w, q] * disc[q, j])*100;
                    }
                }
            }
            return NewMatrix;
        }
        static int[,] Scaling(int[,] Matrix, Double k)
        {
            
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Matrix[i, j] = Convert.ToInt32( Matrix[i,j]* k);
                }
            }
            return Matrix;
        }
        public Double[,] ReadDMatrix(int l)
        {
            Double[,] dMatrix = new Double[l, 2];

            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < 2; j++)
                {

                    dMatrix[i, j] = Convert.ToInt32(cordMatrixReader.Rows[i].Cells[j].Value);

                }
            }
            return dMatrix;
        }

        public int[,] ReadMatrix(int l)
        {


            int[,] Matrix = new int[l, 2];

            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < 2; j++)
                {

                    Matrix[i, j] = Convert.ToInt32(cordMatrixReader.Rows[i].Cells[j].Value);

                }

            }

            return Matrix;
        }
        public void DrawDefoultFigure(Graphics graphics)
        {

            Point[] Cords = new Point[cordMatrixReader.RowCount];
            int[,] Matrix = ReadMatrix(Convert.ToInt32(lengthReader.Text));
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (j == 0)
                    {
                        Cords[i].X = Matrix[i, j];
                    }
                    else
                        Cords[i].Y = Matrix[i, j];
                }
            }
            Pen pen = new Pen(Color.Black);
            pen.Width = 2;
            graphics.DrawPolygon(pen, Cords);
        }
        public void DrawOYFigure(Graphics graphics)
        {
            int[,] oy = {
                { -1,0},
                { 0, 1}
            };

            Point[] Cords = new Point[cordMatrixReader.RowCount];
            int[,] Matrix = MirrorOY(oy, ReadMatrix(Convert.ToInt32(lengthReader.Text)));
            if (Convert.ToDouble((oyCoefReader.Text)) < 0 || Convert.ToDouble((oyCoefReader.Text)) > 0)
            {
                Matrix = Scaling(Matrix, Convert.ToDouble(oyCoefReader.Text));
            }
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (j == 0)
                    {
                        Cords[i].X = Matrix[i, j];
                    }
                    else
                        Cords[i].Y = Matrix[i, j];
                }
            }
            Pen pen = new Pen(Color.Black);
            pen.Width = 2;
            graphics.DrawPolygon(pen, Cords);
        }
        public void DrawOXFigure(Graphics graphics)
        {
           
            int[,] ox = {
                { 1,0},
                { 0,-1}
            };
            Point[] Cords = new Point[cordMatrixReader.RowCount];
            int[,] Matrix = MirrorOX(ox, ReadMatrix(Convert.ToInt32(lengthReader.Text)));
            if (Convert.ToDouble((OxCoefreader.Text)) < 0 || Convert.ToDouble((OxCoefreader.Text)) > 0)
            {
               Matrix = Scaling(Matrix, Convert.ToDouble(OxCoefreader.Text));
            }
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (j == 0)
                    {
                        Cords[i].X = Matrix[i, j];
                    }
                    else
                        Cords[i].Y = Matrix[i, j];
                }
            }
            Pen pen = new Pen(Color.Black);
            pen.Width = 2;
            graphics.DrawPolygon(pen, Cords);
        }
        public void DrawXYFigure(Graphics graphics)
        {

            int[,] xy = {
                { 0,1},
                { 1,0}
            };
            int[,] mxy = {
                { 0,-1},
                { -1,0}
            };

            Point[] Cords = new Point[cordMatrixReader.RowCount];
            int[,] Matrix = MirrorXY(xy, mxy, ReadMatrix(Convert.ToInt32(lengthReader.Text)));
            if (Convert.ToDouble((xyReader.Text)) < 0 || Convert.ToDouble((xyReader.Text)) > 0)
            {
                Matrix = Scaling(Matrix, Convert.ToDouble(xyReader.Text));
            }
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (j == 0)
                    {
                        Cords[i].X = Matrix[i, j];
                    }
                    else
                        Cords[i].Y = Matrix[i, j];
                }
            }
            Pen pen = new Pen(Color.Black);
            pen.Width = 2;
            graphics.DrawPolygon(pen, Cords);
        }
        public void DrawDiscretFigure(Graphics graphics)
        {
            Double f = Convert.ToDouble(rotationCoefReader.Text);
            Double[,] disc = {
                {Math.Cos(f)/180*Math.PI, Math.Sin(f)/180*Math.PI},
                {Math.Sin(-f)/180*Math.PI, Math.Cos(f)/180*Math.PI}
            };

            Point[] Cords = new Point[cordMatrixReader.RowCount];
            Double[,] Matrix = DiscRotation(disc, ReadDMatrix(Convert.ToInt32(lengthReader.Text)));

            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (j == 0)
                    {
                        Cords[i].X = Convert.ToInt32(Matrix[i, j]);
                    }
                    else
                        Cords[i].Y = Convert.ToInt32(Matrix[i, j]);
                }
            }
            Pen pen = new Pen(Color.Black);
            pen.Width = 2;
            graphics.DrawPolygon(pen, Cords);
        }

        public void DrawX(Point start, Point end, Graphics graphics)
        {
            graphics.DrawLine(Pens.Black, start, end);

            for (int i = start.X; i < end.X; i += 40)
            {
                graphics.DrawLine(Pens.Black, i, -3, i, 3);
            }
        }
        public void DrawY(Point start, Point end, Graphics graphics)
        {
            graphics.DrawLine(Pens.Black, start, end);

            for (int i = start.Y; i < end.Y; i += 40)
            {
                graphics.DrawLine(Pens.Black, -3, i, 3, i);
            }
        }
        public void DrawAll()
        {
            drawArea.Visible = true;
            drawArea.Enabled = true;
            drawArea.Paint += drawArea_Paint;

        }

        private void lengthApplyButton_Click(object sender, EventArgs e)
        {
            int l = Convert.ToInt32(lengthReader.Text);
            cordMatrixReader.RowCount = l;
            cordMatrixReader.Visible = true;
        }

        private void drawButton_Click(object sender, EventArgs e)
        {

            DrawAll();
            drawArea.Refresh();
        }

        private void drawArea_Paint(object sender, PaintEventArgs e)
        {
            int w = drawArea.ClientSize.Width / 2;
            int h = drawArea.ClientSize.Height / 2;
            e.Graphics.TranslateTransform(w, h);
            DrawX(new Point(-w, 0), new Point(w, 0), e.Graphics);
            DrawY(new Point(0, -h), new Point(0, h), e.Graphics);
            DrawDefoultFigure(e.Graphics);
            DrawDiscretFigure(e.Graphics);
            DrawOXFigure(e.Graphics);
            DrawOYFigure(e.Graphics);
            DrawXYFigure(e.Graphics);

        }

       
    }
}
