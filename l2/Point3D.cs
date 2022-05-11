using System;
using System.Drawing;

namespace Призма
{
    public class Point3D : Matrix
    {
        public float X
        {
            get
            {
                return this[0];
            }
            set
            {
                this[0] = value;
            }
        }
        public float Y
        {
            get
            {
                return this[1];
            }
            set
            {
                this[1] = value;
            }
        }
        public float Z
        {
            get
            {
                return this[2];
            }
            set
            {
                this[2] = value;
            }
        }

        public Point3D(float x, float y, float z) : base(x, y, z)
        {

        }

        public Point3D() : base(1, 3)
        {

        }

        public static Point3D operator *(Point3D left, Matrix right)
        {
            float sum;
            Point3D p = new Point3D();
            for (int i = 0; i < 3; i++)
            {
                sum = 0;
                for (int k = 0; k < 3; k++)
                    sum += left[k] * right[i, k];
                p[i] = sum;
            }
            return p;
        }

        public static Point3D RatioPoint(Point3D p1, Point3D p2, float lyambda)
        {
            return new Point3D((p1.X + lyambda * p2.X) / (lyambda + 1), (p1.Y + lyambda * p2.Y) / (lyambda + 1), (p1.Z + lyambda * p2.Z) / (lyambda + 1));
        }

        public static Point3D MiddlePoint(Point3D p1, Point3D p2)
        {
            return RatioPoint(p1, p2, 1);
        }

        public static PointF Point3DTo2D(Point3D p)
        {
            return new PointF(p.X, p.Y);
        }

        public static float Distance(Point3D p1, Point3D p2)
        {
            return (float)Math.Sqrt((p1.X - p2.X) * (p1.X - p2.X) + (p1.Y - p2.Y) * (p1.Y - p2.Y) * (p1.Z - p2.Z) * (p1.Z - p2.Z));
        }

        public static Point3D Center(Point3D[] p) // Средняя точка
        {
            float x, y, z;
            int i;
            for (x = p[0].X, y = p[0].Y, z = p[0].Z, i = 1; i < p.Length; i++)
            {
                x += p[i].X;
                y += p[i].Y;
                z += p[i].Z;
            }
            x /= (float)p.Length;
            y /= (float)p.Length;
            z /= (float)p.Length;
            return new Point3D(x, y, z);
        }

        public Vector3D ToVector()
        {
            return new Vector3D(X, Y, Z);
        }
    }
}
