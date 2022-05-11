using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace Призма
{
    public partial class FormPrism : Form
    {
        #region Поля

        Bitmap bmp;

        Graphics g;

        Prism prism;

        Point3D startPoint; // Начальная точка
        Point3D C; // Точка проектора

        float a; // длина ребра
        float h; // высота призмы

        float xAngle = 0;
        float yAngle = 0;
        float zAngle = 0;

        float xMove = 0;
        float yMove = 0;
        float zMove = 0;

        float xScale = 1;
        float yScale = 1;
        float zScale = 1;

        bool IsPressed = false;
        bool IsInit = false;

        PointF current;

        Size size;

        enum ProjectionMode { Perspective = 0, ProjectionZ = 1, ProjectionX = 2, ProjectionY = 3, Isometric = 4 }

        #endregion


        ProjectionMode projection
        {
            get
            {
                return (ProjectionMode)comboBoxSmooth.SelectedIndex;
            }
        }


        #region Методы

        void drawPrism(Color color)
        {
            g.Clear(Color.White);
            a = bmp.Width / 6f;
            h = bmp.Height / 4f;

            picture.Image = bmp;
            size = Size;

            C = new Point3D(bmp.Width / 2f, bmp.Height / 2f, -10f * a);

            Point3D[][] edges;
            Point3D[][] polygons;
            PointF[] p;
            GraphicsPath path;

            switch (projection)
            {
                default:
                    polygons = prism.VisiblePolygons();
                    for (int i = 0; i < polygons.Length; i++)
                    {
                        path = new GraphicsPath();
                        int j;
                        for (j = 0; j < polygons[i].Length - 1; j++)
                        {
                            path.AddLine(Prism.Point3DTo2D(polygons[i][j]), Prism.Point3DTo2D(polygons[i][j + 1]));
                        }
                        path.AddLine(Prism.Point3DTo2D(polygons[i][j]), Prism.Point3DTo2D(polygons[i][0]));
                        g.FillPath(new SolidBrush(Color.Yellow), path);
                    }
                    edges = prism.VisibleEdges();
                    for (int i = 0; i < edges.Length; i++)
                    {
                        p = Prism.Edge3DTo2D(edges[i]);
                        g.DrawPolygon(new Pen(color), p);
                    }
                    break;
            }
        }

        #endregion

        #region Конструктор и загрузчик

        public FormPrism()
        {
            InitializeComponent();
        }

        private void FormPrism_Load(object sender, EventArgs e)
        {
            MouseWheel += FormPism_MouseWheel;
            bmp = new Bitmap(picture.Width, picture.Height);
            picture.Image = bmp;
            g = Graphics.FromImage(bmp);
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.Clear(Color.White);

            numericUpDownXMove.Maximum = 2000;
            numericUpDownXMove.Minimum = -2000;
            numericUpDownYMove.Maximum = 2000;
            numericUpDownYMove.Minimum = -2000;
            numericUpDownZMove.Maximum = 2000;
            numericUpDownZMove.Minimum = -2000;

            g.Clear(Color.White);
            a = bmp.Width / 6f;
            h = bmp.Height / 4f;

            size = Size;

            startPoint = new Point3D(0, 0, 0);
            prism = new Prism(startPoint, a, h);
            prism.Move(10, 100, 0);
            centrifyPrism();
            drawPrism(Color.Black);
            comboBoxSmooth.SelectedIndex = 0;
            IsInit = true;
            picture.Image = bmp;
        }

        #endregion

        #region  Обработчики событий

        private void centrifyPrism()
        {
            var centerX = bmp.Width / 2f;
            var centerY = bmp.Height / 2f;
            prism.Move(centerX - prism.Center.X, centerY - prism.Center.Y, 0);
            //prism.Move(-a / 2 + bmp.Width / 2f, -h / 2 + bmp.Height / 2f, 0);
        }

        private void numericUpDownXRotate_ValueChanged(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            prism.XRotate(((float)numericUpDownXRotate.Value - xAngle) * -(float)Math.PI / 180f);
            drawPrism(Color.Black);
            picture.Image = bmp;
            xAngle = (float)numericUpDownXRotate.Value;
        }

        private void numericUpDownYRotate_ValueChanged(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            prism.YRotate(((float)numericUpDownYRotate.Value - yAngle) * -(float)Math.PI / 180f);
            drawPrism(Color.Black);
            picture.Image = bmp;
            yAngle = (float)numericUpDownYRotate.Value;
        }

        private void numericUpDownZRotate_ValueChanged(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            prism.ZRotate(((float)numericUpDownZRotate.Value - zAngle) * -(float)Math.PI / 180f);
            drawPrism(Color.Black);
            picture.Image = bmp;
            zAngle = (float)numericUpDownZRotate.Value;
        }

        private void numericUpDownXMove_ValueChanged(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            prism.Move((float)numericUpDownXMove.Value - xMove, 0, 0);
            drawPrism(Color.Black);
            picture.Image = bmp;
            xMove = (float)numericUpDownXMove.Value;
        }

        private void numericUpDownYMove_ValueChanged(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            prism.Move(0, (float)numericUpDownYMove.Value - yMove, 0);
            drawPrism(Color.Black);
            picture.Image = bmp;
            yMove = (float)numericUpDownYMove.Value;
        }

        private void numericUpDownZMove_ValueChanged(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            prism.Move(0, 0, (float)numericUpDownZMove.Value - zMove);
            drawPrism(Color.Black);
            picture.Image = bmp;
            zMove = (float)numericUpDownZMove.Value;
        }

        private void numericUpDownXScale_ValueChanged(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            prism.ScaleTransform((float)numericUpDownXScale.Value / xScale, 1, 1);
            drawPrism(Color.Black);
            picture.Image = bmp;
            xScale = (float)numericUpDownXScale.Value;
        }

        private void numericUpDownYScale_ValueChanged(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            prism.ScaleTransform(1, (float)numericUpDownYScale.Value / yScale, 1);
            drawPrism(Color.Black);
            picture.Image = bmp;
            yScale = (float)numericUpDownYScale.Value;
        }

        private void numericUpDownZScale_ValueChanged(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            prism.ScaleTransform(1, 1, (float)numericUpDownZScale.Value / zScale);
            drawPrism(Color.Black);
            picture.Image = bmp;
            zScale = (float)numericUpDownZScale.Value;
        }

        private void FormPism_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta == SystemInformation.MouseWheelScrollDelta)
            {
                numericUpDownXScale.Value += numericUpDownXScale.Increment;
                numericUpDownYScale.Value += numericUpDownYScale.Increment;
                numericUpDownZScale.Value += numericUpDownZScale.Increment;
            }
            else if (e.Delta == -SystemInformation.MouseWheelScrollDelta)
            {
                if (numericUpDownXScale.Value > numericUpDownXScale.Minimum)
                    numericUpDownXScale.Value -= numericUpDownXScale.Increment;
                if (numericUpDownYScale.Value > numericUpDownYScale.Minimum)
                    numericUpDownYScale.Value -= numericUpDownYScale.Increment;
                if (numericUpDownZScale.Value > numericUpDownZScale.Minimum)
                    numericUpDownZScale.Value -= numericUpDownZScale.Increment;
            }
        }

        private void FormPrism_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                numericUpDownYMove.Value -= 4 * numericUpDownYMove.Increment;
            }
            else if (e.KeyCode == Keys.Down)
            {
                numericUpDownYMove.Value += 4 * numericUpDownYMove.Increment;
            }
            else if (e.KeyCode == Keys.Left)
            {
                numericUpDownXMove.Value -= 4 * numericUpDownXMove.Increment;
            }

            else if (e.KeyCode == Keys.Right)
            {
                numericUpDownXMove.Value += 4 * numericUpDownXMove.Increment;
            }
        }

        private void splitContainer1_Panel2_MouseClick(object sender, MouseEventArgs e)
        {
            splitContainer.Panel2.Focus();
        }

        private void FormPrism_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized || !IsInit) return;
            if (Height < 300) Height = 300;
            if (Width < 300) Width = 300;
            bmp = new Bitmap(picture.Width, picture.Height);
            g = Graphics.FromImage(bmp);
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.Clear(Color.White);

            var x = (decimal)(Size.Width / (float)size.Width);
            var y = (decimal)(Size.Height / (float)size.Height);
            decimal shiftC = (x < 1 || y < 1) ? Math.Min(x, y) : Math.Max(x, y);
            
            numericUpDownXScale.Value *= shiftC;
            numericUpDownYScale.Value *= shiftC;
            numericUpDownZScale.Value *= shiftC;

            centrifyPrism();
            drawPrism(Color.Black);
            picture.Image = bmp;
            size = Size;
        }

        private void picture_MouseDown(object sender, MouseEventArgs e)
        {
            IsPressed = true;
            current = e.Location;
        }

        private void picture_MouseMove(object sender, MouseEventArgs e)
        {
            if (!IsPressed) return;
            numericUpDownYRotate.Value -= (decimal)(e.Location.X - current.X);
            numericUpDownXRotate.Value += (decimal)(e.Location.Y - current.Y);
            current = e.Location;
        }

        private void picture_MouseUp(object sender, MouseEventArgs e)
        {
            IsPressed = false;
        }

        private void comboBoxSmooth_SelectedIndexChanged(object sender, EventArgs e)
        {
            bmp = new Bitmap(picture.Width, picture.Height);
            g = Graphics.FromImage(bmp);
            g.Clear(Color.White);
            splitContainer.Panel2.Focus();

            a = bmp.Width / 6f;
            h = bmp.Height / 4f;

            size = Size;

            startPoint = new Point3D(0, 0, 0);
            C = new Point3D(bmp.Width / 2f, bmp.Height / 2f, -10f * a);

            numericUpDownXScale.Value = 1;
            numericUpDownYScale.Value = 1;
            numericUpDownZScale.Value = 1;

            prism = new Prism(startPoint, a, h);
            Matrix D;

            switch (projection)
            { 
                case ProjectionMode.Isometric:
                    float phi = (float)Math.Asin(Math.Sqrt(0.5));
                    float teta = -(float)Math.Asin(Math.Sqrt(1.0 / 3.0));
                    
                    float cos1 = (float)Math.Cos(phi);
                    float sin1 = (float)Math.Sin(phi);
                    Matrix D1  = Matrix.Matrix4D(1, 0, 0, 0, 0, cos1, -sin1, 0, 0, sin1, cos1, 0, 0, 0, 0, 1);

                    float cos2 = (float)Math.Cos(teta);
                    float sin2 = (float)Math.Sin(teta);
                    Matrix D2 = Matrix.Matrix4D(cos2, 0, sin2, 0, 0, 1, 0, 0, -sin2, 0, cos2, 0, 0, 0, 0, 1);

                    D = D1 * D2;
                    break;
                case ProjectionMode.ProjectionX:
                    D = Matrix.Matrix4D(0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1);
                    break;
                case ProjectionMode.ProjectionY:
                    D = Matrix.Matrix4D(1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1);
                    break;
                case ProjectionMode.ProjectionZ:
                    D = Matrix.Matrix4D(1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1);
                    break;

                default:
                    D = Matrix.Matrix4D(1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1);
                    break;
            }

            prism.Transform4D(D);
            centrifyPrism();
            drawPrism(Color.Black);
            picture.Image = bmp;
        }

        #endregion

        private void splitContainer_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormPrism_Shown(object sender, EventArgs e)
        {
            comboBoxSmooth_SelectedIndexChanged(null, null);
        }
    }
}
