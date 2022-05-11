using System;
using System.Collections.Generic;
using System.Drawing;

namespace Призма
{
    public class Prism
    {
        const float alpha = 3f / 5f * (float)Math.PI; // угол призмы

        public float Alpha
        {
            get
            {
                return alpha;
            }
        }

        public float Height // Высота
        {
            get
            {
                return (float)Math.Sqrt((Points[0].X - Points[5].X) * (Points[0].X - Points[5].X) + (Points[0].Y - Points[5].Y) * (Points[0].Y - Points[5].Y));
            }
        }

        public float Rib // Ребро
        {
            get
            {
                return (float)Math.Sqrt((Points[0].X - Points[1].X) * (Points[0].X - Points[1].X) + (Points[0].Y - Points[1].Y) * (Points[0].Y - Points[1].Y));
            }
        }

        public Point3D Center // Координата центра
        {
            get
            {
                Point3D med1 = Point3D.MiddlePoint(Points[0], Points[1]);
                Point3D cent1 = Point3D.MiddlePoint(med1, Points[3]);
                Point3D med2 = Point3D.MiddlePoint(Points[5], Points[6]);
                Point3D cent2 = Point3D.MiddlePoint(med2, Points[8]);
                return Point3D.MiddlePoint(cent1, cent2);
            }
        }

        public Point3D[] Points; // вершины

        public Point3D[][] Edges // ребра (все)
        {
            get
            {
                Point3D[][] res = new Point3D[15][];
                for (int i = 0; i < 15; i++)
                {
                    res[i] = new Point3D[2];
                }
                for (int i = 0; i < 4; i++)
                {
                    res[i][0] = Points[i];
                    res[i][1] = Points[i + 1];
                }
                res[4][0] = Points[4];
                res[4][1] = Points[0];
                for (int i = 10; i < 14; i++)
                {
                    res[i][0] = Points[i - 5];
                    res[i][1] = Points[i - 4];
                }
                res[14][0] = Points[9];
                res[14][1] = Points[5];
                for (int i = 5; i < 10; i++)
                {
                    res[i][0] = Points[i - 5];
                    res[i][1] = Points[i];
                }
                return res;
            }
        }

        public Point3D[][] VisibleEdges(Point3D C) // ребра (видимые)
        {
            bool[] IsVisible = new bool[7];
            IsVisible[0] = VisiblePolygon(C, Points[0], Points[4], Points[3]);
            IsVisible[1] = VisiblePolygon(C, Points[0], Points[1], Points[6]);
            IsVisible[2] = VisiblePolygon(C, Points[1], Points[2], Points[7]);
            IsVisible[3] = VisiblePolygon(C, Points[2], Points[3], Points[8]);
            IsVisible[4] = VisiblePolygon(C, Points[3], Points[4], Points[9]);
            IsVisible[5] = VisiblePolygon(C, Points[4], Points[0], Points[5]);
            IsVisible[6] = VisiblePolygon(C, Points[5], Points[6], Points[7]);
            Point3D[][] edges = Edges;
            Queue<Point3D[]> q = new Queue<Point3D[]>();
            for (int i = 0; i < 5; i++)
            {
                if (IsVisible[0] || IsVisible[i + 1])
                    q.Enqueue(edges[i]);
            }
            if (IsVisible[1] || IsVisible[5]) q.Enqueue(edges[5]);
            if (IsVisible[1] || IsVisible[2]) q.Enqueue(edges[6]);
            if (IsVisible[2] || IsVisible[3]) q.Enqueue(edges[7]);
            if (IsVisible[3] || IsVisible[4]) q.Enqueue(edges[8]);
            if (IsVisible[4] || IsVisible[5]) q.Enqueue(edges[9]);
            for (int i = 10; i < 15; i++)
            {
                if (IsVisible[6] || IsVisible[i - 9])
                    q.Enqueue(edges[i]);
            }
            return q.ToArray();
        }

        public Point3D[][] VisibleEdges() // ребра (видимые)
        {
            bool[] IsVisible = new bool[7];
            IsVisible[0] = VisiblePolygon(Points[0], Points[4], Points[3]);
            IsVisible[1] = VisiblePolygon(Points[0], Points[1], Points[6]);
            IsVisible[2] = VisiblePolygon(Points[1], Points[2], Points[7]);
            IsVisible[3] = VisiblePolygon(Points[2], Points[3], Points[8]);
            IsVisible[4] = VisiblePolygon(Points[3], Points[4], Points[9]);
            IsVisible[5] = VisiblePolygon(Points[4], Points[0], Points[5]);
            IsVisible[6] = VisiblePolygon(Points[5], Points[6], Points[7]);
            Point3D[][] edges = Edges;
            Queue<Point3D[]> q = new Queue<Point3D[]>();
            for (int i = 0; i < 5; i++)
            {
                if (IsVisible[0] || IsVisible[i + 1])
                    q.Enqueue(edges[i]);
            }
            if (IsVisible[1] || IsVisible[5]) q.Enqueue(edges[5]);
            if (IsVisible[1] || IsVisible[2]) q.Enqueue(edges[6]);
            if (IsVisible[2] || IsVisible[3]) q.Enqueue(edges[7]);
            if (IsVisible[3] || IsVisible[4]) q.Enqueue(edges[8]);
            if (IsVisible[4] || IsVisible[5]) q.Enqueue(edges[9]);
            for (int i = 10; i < 15; i++)
            {
                if (IsVisible[6] || IsVisible[i - 9])
                    q.Enqueue(edges[i]);
            }
            return q.ToArray();
        }

        public Point3D[][] VisiblePolygons(Point3D C)
        {
            Point3D[] p = null;
            Queue<Point3D[]> q = new Queue<Point3D[]>();
            if (VisiblePolygon(C, Points[0], Points[4], Points[3]))
            {
                p = new Point3D[5];
                for (int i = 0; i < 5; i++)
                {
                    p[i] = Points[i];
                }
                q.Enqueue(p);
            }
            if (VisiblePolygon(C, Points[0], Points[1], Points[6]))
            {
                p = new Point3D[4];
                p[0] = Points[0];
                p[1] = Points[1];
                p[2] = Points[6];
                p[3] = Points[5];
                q.Enqueue(p);
            }
            if (VisiblePolygon(C, Points[1], Points[2], Points[7]))
            {
                p = new Point3D[4];
                p[0] = Points[1];
                p[1] = Points[2];
                p[2] = Points[7];
                p[3] = Points[6];
                q.Enqueue(p);
            }
            if (VisiblePolygon(C, Points[2], Points[3], Points[8]))
            {
                p = new Point3D[4];
                p[0] = Points[2];
                p[1] = Points[3];
                p[2] = Points[8];
                p[3] = Points[7];
                q.Enqueue(p);
            }
            if (VisiblePolygon(C, Points[3], Points[4], Points[9]))
            {
                p = new Point3D[4];
                p[0] = Points[3];
                p[1] = Points[4];
                p[2] = Points[9];
                p[3] = Points[8];
                q.Enqueue(p);
            }
            if (VisiblePolygon(C, Points[4], Points[0], Points[5]))
            {
                p = new Point3D[4];
                p[0] = Points[4];
                p[1] = Points[0];
                p[2] = Points[5];
                p[3] = Points[9];
                q.Enqueue(p);
            }
            if (VisiblePolygon(C, Points[5], Points[6], Points[7]))
            {
                p = new Point3D[5];
                p[0] = Points[5];
                p[1] = Points[6];
                p[2] = Points[7];
                p[3] = Points[8];
                p[4] = Points[9];
                q.Enqueue(p);
            }
            return q.ToArray();
        }

        public Point3D[][] VisiblePolygons()
        {
            Point3D[] p = null;
            Queue<Point3D[]> q = new Queue<Point3D[]>();
            if (VisiblePolygon(Points[0], Points[4], Points[3]))
            {
                p = new Point3D[5];
                for (int i = 0; i < 5; i++) p[i] = Points[i];
                q.Enqueue(p);
            }
            if (VisiblePolygon(Points[0], Points[1], Points[6]))
            {
                p = new Point3D[4];
                p[0] = Points[0];
                p[1] = Points[1];
                p[2] = Points[6];
                p[3] = Points[5];
                q.Enqueue(p);
            }
            if (VisiblePolygon(Points[1], Points[2], Points[7]))
            {
                p = new Point3D[4];
                p[0] = Points[1];
                p[1] = Points[2];
                p[2] = Points[7];
                p[3] = Points[6];
                q.Enqueue(p);
            }
            if (VisiblePolygon(Points[2], Points[3], Points[8]))
            {
                p = new Point3D[4];
                p[0] = Points[2];
                p[1] = Points[3];
                p[2] = Points[8];
                p[3] = Points[7];
                q.Enqueue(p);
            }
            if (VisiblePolygon(Points[3], Points[4], Points[9]))
            {
                p = new Point3D[4];
                p[0] = Points[3];
                p[1] = Points[4];
                p[2] = Points[9];
                p[3] = Points[8];
                q.Enqueue(p);
            }
            if (VisiblePolygon(Points[4], Points[0], Points[5]))
            {
                p = new Point3D[4];
                p[0] = Points[4];
                p[1] = Points[0];
                p[2] = Points[5];
                p[3] = Points[9];
                q.Enqueue(p);
            }
            if (VisiblePolygon(Points[5], Points[6], Points[7]))
            {
                p = new Point3D[5];
                p[0] = Points[5];
                p[1] = Points[6];
                p[2] = Points[7];
                p[3] = Points[8];
                p[4] = Points[9];
                q.Enqueue(p);
            }
            return q.ToArray();
        }

        public Prism(Point3D p, float a, float h) // инициализация
        {
            Points = new Point3D[10];
            Points[0] = new Point3D(p.X, p.Y, p.Z);

            Points[1] = new Point3D(p.X + a, p.Y, p.Z);

            Points[2] = new Point3D(
                Points[1].X + a * (float)Math.Cos(Math.PI - alpha),
                p.Y,
                Points[1].Z - a * (float)Math.Sin(Math.PI - alpha));

            Points[3] = new Point3D(
                p.X + a / 2f,
                p.Y,
                Points[2].Z - a * (float)Math.Sin(Math.PI / 2f - alpha / 2));

            Points[4] = new Point3D(
                p.X - a * (float)Math.Cos(Math.PI - alpha),
                p.Y,
                Points[2].Z);

            for (int i = 5; i < 10; i++)
            {
                Points[i] = new Point3D(
                    Points[i - 5].X, 
                    p.Y + h, 
                    Points[i - 5].Z);
            }
        }

        public void Move(float dx, float dy, float dz)
        {
            Matrix D = TransformMatrix3D.D(dx, dy, dz);
            for (int i = 0; i < Points.Length; i++)
            {
                Points[i] = TransformMatrix3D.toPoint3D(TransformMatrix3D.toPoint4D(Points[i]) * D);
            }
        }

        public void Transform4D(Matrix M)
        {
            Point3D cent = Center; // Координаты центра призмы
            Matrix D1 = TransformMatrix3D.D(-cent.X, -cent.Y, -cent.Z);
            Matrix D2 = TransformMatrix3D.D(cent.X, cent.Y, cent.Z);

            for (int i = 0; i < Points.Length; i++)
                Points[i] = TransformMatrix3D.toPoint3D(TransformMatrix3D.toPoint4D(Points[i]) * M);
        }

        public void ScaleTransform(float sx, float sy, float sz)
        {
            Matrix S = TransformMatrix3D.S(sx, sy, sz);
            Point3D cent = Center; // Координаты центра призмы
            Matrix D1 = TransformMatrix3D.D(-cent.X, -cent.Y, -cent.Z);
            Matrix D2 = TransformMatrix3D.D(cent.X, cent.Y, cent.Z);
            for (int i = 0; i < Points.Length; i++)
            {
                Points[i] = TransformMatrix3D.toPoint3D(TransformMatrix3D.toPoint4D(Points[i]) * D1 * S * D2);
            }
        }

        public void XRotate(float angle)
        {
            Point3D cent = Center; // Координаты центра призмы
            Matrix D1 = TransformMatrix3D.D(-cent.X, -cent.Y, -cent.Z);
            Matrix D2 = TransformMatrix3D.D(cent.X, cent.Y, cent.Z);
            Matrix R = TransformMatrix3D.Rx(angle);
            for (int i = 0; i < Points.Length; i++)
            {
                Points[i] = TransformMatrix3D.toPoint3D(TransformMatrix3D.toPoint4D(Points[i]) * D1 * R * D2);
            }
        }

        public void YRotate(float angle)
        {
            Point3D cent = Center; // Координаты центра призмы
            Matrix D1 = TransformMatrix3D.D(-cent.X, -cent.Y, -cent.Z);
            Matrix D2 = TransformMatrix3D.D(cent.X, cent.Y, cent.Z);
            Matrix R = TransformMatrix3D.Ry(angle);
            for (int i = 0; i < Points.Length; i++)
            {
                Points[i] = TransformMatrix3D.toPoint3D(TransformMatrix3D.toPoint4D(Points[i]) * D1 * R * D2);
            }
        }

        public void ZRotate(float angle)
        {
            Point3D cent = Center; // Координаты центра призмы
            Matrix D1 = TransformMatrix3D.D(-cent.X, -cent.Y, -cent.Z);
            Matrix D2 = TransformMatrix3D.D(cent.X, cent.Y, cent.Z);
            Matrix R = TransformMatrix3D.Rz(angle);
            for (int i = 0; i < Points.Length; i++)
            {
                Points[i] = TransformMatrix3D.toPoint3D(TransformMatrix3D.toPoint4D(Points[i]) * D1 * R * D2);
            }
        }

        public static bool VisiblePolygon(Point3D C, Point3D p1, Point3D p2, Point3D p3) // Видима ли грань? (Алгорим Робертса)
        {
            Vector3D v1 = new Vector3D(p1, p2);
            Vector3D v2 = new Vector3D(p2, p3);
            Vector3D N = Vector3D.VectorProduct(v1, v2); // вектор нормали
            Vector3D L = new Vector3D(C, p2);
            return Math.Sign(Vector3D.ScalarProduct(N, L)) >= 0;
        }

        public static bool VisiblePolygon(Point3D p1, Point3D p2, Point3D p3) // Видима ли грань? (Алгорим Робертса)
        {
            Vector3D v1 = new Vector3D(p1, p2);
            Vector3D v2 = new Vector3D(p2, p3);
            Vector3D N = Vector3D.VectorProduct(v1, v2); // вектор нормали
            Vector3D L = new Vector3D(new Point3D(p2.X, p2.Y, p2.Z - 1), p2);
            return Math.Sign(Vector3D.ScalarProduct(N, L)) >= 0;
        }

        public static PointF[] Edge3DTo2D(Point3D C, Point3D[] edge)
        {
            PointF[] res = new PointF[2];
            float t = edge[0].Z / (C.Z - edge[0].Z);
            res[0] = new PointF(edge[0].X + (edge[0].X - C.X) * t, edge[0].Y + (edge[0].Y - C.Y) * t);
            t = edge[1].Z / (C.Z - edge[1].Z);
            res[1] = new PointF(edge[1].X + (edge[1].X - C.X) * t, edge[1].Y + (edge[1].Y - C.Y) * t);
            return res;
        }

        public static PointF Point3DTo2D(Point3D C, Point3D p)
        {
            float t = p.Z / (C.Z - p.Z);
            return new PointF(p.X + (p.X - C.X) * t, p.Y + (p.Y - C.Y) * t);
        }

        public static PointF[] Edge3DTo2D(Point3D[] edge)
        {
            PointF[] res = new PointF[2];
            res[0] = new PointF(edge[0].X, edge[0].Y);
            res[1] = new PointF(edge[1].X, edge[1].Y);
            return res;
        }

        public static PointF Point3DTo2D(Point3D p)
        {
            return new PointF(p.X, p.Y);
        }

        private float isZero(float value)
        {
            return value == 0 ? 1 : 0;
        }
    }
}