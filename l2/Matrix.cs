using System;

namespace Призма
{
    public class Matrix
    {
        public int n { get; private set; }
        public int m { get; private set; }

        public float[,] value;

        public Matrix(int n, int m)
        {
            this.n = n;
            this.m = m;
            value = new float[n, m];
        }

        public Matrix(Matrix m) // Копия
        {
            n = m.n;
            this.m = m.m;
            value = m.value.Clone() as float[,];
        }

        public Matrix(params float[] val) // Вектор-строка
        {
            n = 1;
            m = val.Length;
            value = new float[n, m];
            for (int i = 0; i < m; i++)
                this[i] = val[i];
        }

        public static Matrix Matrix4D(params float[] args)
        {
            Matrix res = new Matrix(4, 4);

            int counter = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    res[i, j] = args[counter];
                    counter++;
                }
            }

            return res;
        }

        public static Matrix operator +(Matrix m1, Matrix m2)
        {
            Matrix m = new Matrix(m1.n, m1.m);
            for (int i = 0; i < m.n; i++)
                for (int j = 0; j < m.m; j++)
                    m[i, j] = m1[i, j] + m2[i, j];
            return m;
        }

        public static Matrix operator *(Matrix m, float a)
        {
            Matrix res = new Matrix(m.n, m.m);
            for (int i = 0; i < m.n; i++)
                for (int j = 0; j < m.m; j++)
                    res[i, j] = a * m[i, j];
            return res;
        }

        public static Matrix operator *(float a, Matrix m)
        {
            return m * a;
        }

        public static Matrix operator -(Matrix m1, Matrix m2)
        {
            Matrix m = new Matrix(m1.n, m1.m);
            for (int i = 0; i < m.n; i++)
                for (int j = 0; j < m.m; j++)
                    m[i, j] = m1[i, j] - m2[i, j];
            return m;
        }

        public static Matrix operator *(Matrix m1, Matrix m2)
        {
            float sum;
            Matrix m = new Matrix(m1.n, m2.m);
            for (int i = 0; i < m.n; i++)
                for (int j = 0; j < m.m; j++)
                {
                    sum = 0;
                    for (int k = 0; k < m1.m; k++)
                        sum += m1[i, k] * m2[k, j];
                    m[i, j] = sum;
                }
            return m;
        }

        public float this[int index1, int index2]
        {
            get
            {
                return value[index1, index2];
            }
            set
            {
                this.value[index1, index2] = value;
            }
        }

        public float this[int index] // Для одномерного случая
        {
            get
            {
                if (n == 1) // Вектор-строка
                    return value[0, index];
                else // Вектор-столбец
                    return value[index, 0];
            }
            set
            {
                if (n == 1) // Вектор-строка
                    this.value[0, index] = value;
                else // Вектор-столбец
                    this.value[index, 0] = value;
            }
        }

        public float Det // Определитель
        {
            get
            {
                float res = 0;
                int l = n;
                if (l == 1) res = this[0, 0];
                else
                {
                    for (int i = 0; i < l; i++)
                    {
                        res = res + this[0, i] * ((float)Math.Pow(-1, i) * Submatrix(this, 0, i).Det);
                    }
                }
                return res;
            }
        }

        public Matrix Reverse
        {
            get
            {
                Matrix res = new Matrix(n, n);
                float d = Det;
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                    {
                        res[i, j] = Submatrix(this, j, i).Det / d * (float)Math.Pow(-1, i + j);
                    }
                return res;
            }
        }

        public static Matrix E(int n) // Единичная матрица
        {
            Matrix res = new Matrix(n, n);
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    if (i != j) res[i, j] = 0;
                    else res[i, j] = 1;

                }
            return res;
        }

        private static Matrix Submatrix(Matrix A, int a, int b) // Дополнение
        {
            Matrix res = new Matrix(A.n - 1, A.m - 1);
            int size = A.n;
            int m, n;
            m = n = 0;
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                {
                    if (i != a && j != b)
                    {
                        res[m, n] = A[i, j];
                        n++;
                        if (n == size - 1)
                        {
                            n = 0;
                            m++;
                        }
                    }
                }
            return res;
        }
    }
}
