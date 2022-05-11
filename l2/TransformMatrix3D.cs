using System;

namespace Призма
{
    public class TransformMatrix3D
    {
        public static Matrix D(float dx,float dy, float dz)
        {
            Matrix res = new Matrix(4, 4);
            res[0, 0] = res[1, 1] = res[2, 2] = res[3, 3] = 1;
            res[0, 1] = res[0, 2] = res[0, 3] = res[1, 0] = res[1, 2] = res[1, 3] = res[2, 0] = res[2, 1] = res[2, 3] = 0;
            res[3, 0] = dx;
            res[3, 1] = dy;
            res[3, 2] = dz;
            return res;
        }

        public static Matrix S(float sx, float sy, float sz)
        {
            Matrix res = new Matrix(4, 4);
            for(int i=0;i<res.m;i++)
                for (int j = 0; j < res.m && i!=j ; j++)
                {
                    res[i, j] = 0;
                }
            res[0, 0] = sx;
            res[1, 1] = sy;
            res[2, 2] = sz;
            res[3, 3] = 1;
            return res;
        }

        public static Matrix Rx(float alpha)
        {
            Matrix res = new Matrix(4, 4);
            res[0, 1] = res[0, 2] = res[0, 3] = res[1, 0] = res[1, 3] = res[2, 0] = res[2, 3] = res[3, 0] = res[3, 1] = res[3, 2] = 0;
            res[3, 3] = res[0, 0] = 1;
            res[1, 1] = res[2, 2] = (float)Math.Cos(alpha);
            res[2, 1] = -(float)Math.Sin(alpha);
            res[1, 2] = -res[2, 1];
            return res;
        }

        public static Matrix Ry(float alpha)
        {
            Matrix res = new Matrix(4, 4);
            res[0, 1] = res[0, 3] = res[1, 0] = res[1, 2] = res[1, 3] = res[2, 1] = res[2, 3] = res[3, 0] = res[3, 1] = res[3, 2] = 0;
            res[1, 1] = res[3, 3] = 1;
            res[0, 0] = res[2, 2] = (float)Math.Cos(alpha);
            res[0, 2] = -(float)Math.Sin(alpha);
            res[2, 0] = -res[0, 2];
            return res;
        }

        public static Matrix Rz(float alpha)
        {
            Matrix res = new Matrix(4, 4);
            res[0, 2] = res[0, 3] = res[1, 2] = res[1, 3] = res[2, 0] = res[2, 1] = res[2, 3] = res[3, 0] = res[3, 1] = res[3, 2] = 0;
            res[2, 2] = res[3, 3] = 1;
            res[0, 0] = res[1, 1] = (float)Math.Cos(alpha);
            res[0, 1] = (float)Math.Sin(alpha);
            res[1, 0] = -res[0, 1];
            return res;
        }

        public static Matrix ToRGB
        {
            get
            {
                Matrix res = new Matrix(3, 3);
                res[0, 0] = 0.41847f;
                res[0, 1] = -0.15866f;
                res[0, 2] = -0.082835f;
                res[1, 0] = -0.91169f;
                res[1, 1] = 0.25243f;
                res[1, 2] = 0.015708f;
                res[2, 0] = 0.00092090f;
                res[2, 1] = -0.0025498f;
                res[2, 2] = 0.17860f;
                return res;
            }
        }

        public static Matrix ToXYZ
        {
            get
            {
                return ToRGB.Reverse;
            }
        }

        public static Matrix toPoint4D(Point3D p)
        {
            return new Matrix(p.X, p.Y, p.Z, 1);
        }

        public static Point3D toPoint3D(Matrix m)
        {
            return new Point3D(m[0], m[1], m[2]);
        }
    }
}
