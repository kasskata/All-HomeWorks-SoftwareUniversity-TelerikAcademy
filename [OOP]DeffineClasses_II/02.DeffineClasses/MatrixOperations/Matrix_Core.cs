using System;
using System.Linq;
using System.Text;

namespace GenericMatrix
{
    public class Matrix<T> where T :
           struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {

        private const int sizeMatrix = 10;
        public int X { get; private set; }
        public int Y { get; private set; }
        private T[,] matrix;

        public Matrix()
        {
            matrix = new T[sizeMatrix, sizeMatrix];
        }

        public Matrix(int x, int y)
        {
            if (x < 0 || y < 0) throw new ArgumentOutOfRangeException("Negative row or col value");
            else
            {
                X = x;
                Y = y;
                matrix = new T[x, y];
            }
        }

        public Matrix(T[,] matrix)
        {
            this.matrix = matrix;
            X = matrix.GetLength(0);
            Y = matrix.GetLength(1);
        }

        public T this[int x, int y]
        {
            get
            {
                if (X < x || Y < y || x < 0 || y < 0) throw new ArgumentOutOfRangeException("Index out of range for some element");
                else return matrix[x, y];
            }
            set
            {
                if (X < x || Y < y || x < 0 || y < 0) throw new ArgumentOutOfRangeException("Index out of range for some element");
                else matrix[x, y] = value;
            }
        }

        public static Matrix<T> operator +(Matrix<T> batman, Matrix<T> robin)
        {
            if (batman.X == robin.X && batman.Y == robin.Y)
            {
                Matrix<T> tempMem = new Matrix<T>(batman.X, batman.Y);
                for (int i = 0; i < batman.X; i++)
                {
                    for (int j = 0; j < batman.Y; j++)
                    {
                        checked
                        {
                            tempMem[i, j] = (dynamic)batman[i, j] + robin[i, j];
                        }
                    }
                }
                return tempMem;
            }
            else throw new ArgumentException("Different Size Arrays");
        }

        public static Matrix<T> operator -(Matrix<T> batman, Matrix<T> robin)
        {
            if (batman.X == robin.X && batman.Y == robin.Y)
            {
                Matrix<T> tempMem = new Matrix<T>(batman.X, batman.Y);
                for (int i = 0; i < batman.X; i++)
                {
                    for (int j = 0; j < batman.Y; j++)
                    {
                        checked
                        {
                            tempMem[i, j] = (dynamic)batman[i, j] - robin[i, j];
                        }
                    }
                }
                return tempMem;
            }
            else
            {
                throw new ArgumentException("Different Size Arrays");
            }
        }

        public static Matrix<T> operator *(Matrix<T> first, Matrix<T> second)
        {
            if (first.Y == second.X && (first.X > 0 && second.Y > 0 && first.Y > 0))
            {
                Matrix<T> final = new Matrix<T>(first.X, second.Y);
                for (int i = 0; i < final.X; i++)
                {
                    for (int j = 0; j < final.Y; j++)
                    {
                        final[i, j] = (dynamic)0;
                        for (int k = 0; k < first.Y; k++)
                        {
                            checked
                            {
                                final[i, j] = final[i, j] + (dynamic)first[i, k] * second[k, j];
                            }
                        }
                    }
                }
                return final;
            }
            else
            {
                throw new ArgumentException("Row on the first matrix and col on the second matrix, are with different size!");
            }
        }
        public static Boolean operator true(Matrix<T> matrix)
        {
            int check = 0;
            for (int i = 0; i < matrix.X; i++)
            {
                for (int j = 0; j < matrix.Y; j++)
                {
                    if ((dynamic)matrix[i, j] == check)
                    {
                        return false;
                        //break;
                    }
                }
            }
            return true;
        }

        public static Boolean operator false(Matrix<T> matrix)
        {
            int check = 0;
            for (int i = 0; i < matrix.X; i++)
            {
                for (int j = 0; j < matrix.Y; j++)
                {
                    if ((dynamic)matrix[i, j] == check)
                    {
                        return false;
                        //break;
                    }
                }
            }
            return true;
        }
        public override string ToString()
        {
            StringBuilder toText = new StringBuilder();
            for (int i = 0; i < X; i++)
            {
                for (int j = 0; j < Y; j++)
                {
                    toText.Append(matrix[i, j] + " ");
                }
                toText.AppendLine();
            }
            return toText.ToString();
        }
    }
}