using System;

namespace Призма
{
    public class Vector3D : Point3D
    {

        public Vector3D(Point3D p1, Point3D p2) : base(p2.X - p1.X, p2.Y - p1.Y, p2.Z - p1.Z) // от конца отнять начало
        {

        }

        public Vector3D(float x, float y, float z) : base(x, y, z)
        {

        }

        public Vector3D() : base()
        {

        }

        public float Length
        {
            get
            {
                return (float)Math.Sqrt(X * X + Y * Y + Z * Z);
            }
        }

        public void Normalize()
        {
            float l = Length;
            X /= l;
            Y /= l;
            Z /= l;
        }

        public static Vector3D Normalize(Vector3D v)
        {
            v.Normalize();
            return v;
        }

        public static float ScalarProduct(Vector3D v1, Vector3D v2)
        {
            return v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z;
        }

        public static Vector3D VectorProduct(Vector3D v1, Vector3D v2)
        {
            return new Vector3D(v1.Y * v2.Z - v1.Z * v2.Y, v1.Z * v2.X - v1.X * v2.Z, v1.X * v2.Y - v1.Y * v2.X);
        }

        public static float Cos(Vector3D v1, Vector3D v2)
        {
            return ScalarProduct(v1, v2) / v1.Length / v2.Length;
        }

        public static Vector3D Reflect(Vector3D I, Vector3D N)
        {
            return I - 2.0f * ScalarProduct(N, I) * N;
        }

        public static Vector3D operator *(float a, Vector3D v) // Умножение на число
        {
            return new Vector3D(v.X * a, v.Y * a, v.Z * a);
        }

        public static Vector3D operator *(Vector3D v, float a) // Умножение на число
        {
            return new Vector3D(v.X * a, v.Y * a, v.Z * a);
        }

        public static Vector3D operator /(Vector3D v, float a) // Деление на число
        {
            return new Vector3D(v.X / a, v.Y / a, v.Z / a);
        }

        public static Vector3D operator +(Vector3D v1, Vector3D v2) // Сложение векторов
        {
            return new Vector3D(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
        }

        public static Vector3D operator -(Vector3D v1, Vector3D v2) // Разность векторов
        {
            return new Vector3D(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
        }

        public static Vector3D operator *(Vector3D v1, Vector3D v2) 
        {
            return new Vector3D(v1.X * v2.X, v1.Y * v2.Y, v1.Z * v2.Z);
        }

        public static Vector3D operator -(Vector3D v) 
        {
            return new Vector3D(-v.X, -v.Y, -v.Z);
        }

    }
}
