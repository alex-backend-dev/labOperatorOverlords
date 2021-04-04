using System;

namespace labOperatorOverlords
{

    /// Создаем класс для операций над векторами.

    class Vector
    {
        private int x;
        private int y;
        private int z;

        public Vector(int X, int Y, int Z)
        {
            x = X;
            y = Y;
            z = Z;
        }

        public int X
        {
            get
            {
                return x;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }
        }

        public int Z
        {
            get
            {
                return z;
            }
        }

        /// Метод возвращающий сумму 2-х векторов.

        public static Vector operator +(Vector V1, Vector V2)
        {
            return new Vector(V1.X + V2.X, V1.Y + V2.Y, V1.Z + V2.Z);
        }

        /// Метод, возвращающий вектор равный произведение 2-х векторов.

        public static Vector operator *(Vector V1, Vector V2)
        {
            return new Vector(V1.X * V2.X, V1.Y * V2.Y, V1.Z * V2.Z);
        }

        /// Метод, возвращающий разность 2-х векторов.

        public static Vector operator -(Vector V1, Vector V2)
        {
            return new Vector(V1.X - V2.X, V1.Y - V2.Y, V1.Z - V2.Z);
        }

        /// Метод, возвращающий вектор умноженый на скаляр.

        public static Vector operator *(Vector V1, int scalar)
        {
            return new Vector(V1.X * scalar, V1.Y * scalar, V1.Z * scalar);
        }

        /// Метод, возвращающий скалярное произведение двух векторов.

        public static int ScalarProduct(Vector V1, Vector V2)
        {
            return (V1.X * V2.X + V1.Y * V2.Y + V1.Z * V2.Z);
        }

        /// Метод, возращающий векторное произведение двух векторов.

        public static int VectorProduct(Vector V1, Vector V2)
        {
            return ((V1.Y * V2.Z - V1.Z * V2.Y) + (V1.Z * V2.X - V1.X * V2.Z) + (V1.X * V2.Y - V1.Y * V2.X));
        }

        /// Метод, возвращающий модуль вектора.
        public static double ModulVector(Vector V1)
        {
            return (Math.Sqrt(V1.X * V1.X + V1.Y * V1.Y + V1.Z * V1.Z));
        }

        public override string ToString()
        {
            return "{" + X + ", " + Y + ", " + Z + "}";
        }

    }

    class VectorDemo
    {
        static void Main(string[] args)
        {
            Vector v0 = new Vector(1, 5, -3);
            Vector v1 = new Vector(-3, 4, 2);

            Vector SumVectors = v0 + v1;
            Vector Substraction = v0 - v1;
            Vector ScalarProduct1 = v0 * 3;
            Vector ScalarProduct2 = v1 * 4;
            Vector ScalarProductVectors = v0 * v1;

            int VectorProduct = Vector.VectorProduct(v0, v1);
            double ModulVector1 = Vector.ModulVector(v0);
            double ModulVector2 = Vector.ModulVector(v1);

            Console.WriteLine("Первый исходный вектор: " + v0 +
                               "\nВторой исходный вектор: " + v1 +
                               "\nСумма этих векторов: " + SumVectors +
                               "\nРазность этих векторов: " + Substraction +
                               "\nПервый вектор умноженный на 3: " + ScalarProduct1 +
                               "\nВторой вектор умноженный на 3: " + ScalarProduct2 +
                               "\nСкалярное произведение векторов: " + ScalarProductVectors +
                               "\nВекторное произведение векторов: " + VectorProduct +
                               "\nМодуль первого вектора: " + ModulVector1 +
                               "\nМодуль второго вектора: " + ModulVector2);

            Console.ReadKey();
        }
    }

}